using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using static DesktopFacebookAPP.HowWellDoYouKnowYourFriendsGame;

namespace DesktopFacebookAPP
{
    enum eState
    {
        Login,
        MainState,
        Post,
        Events,
        LikedPages,
        FirstFeature,
        HowWellDoYouKnowYourFriendsGame
    }

    public partial class MainWindow : Form
    {
        private readonly string r_AppID = "1168955353252324";

        private readonly string r_GuyAppID = "1450160541956417";

        private User LoggedInUser { get; set; }

        private eState m_CurrentState;

        private HowWellDoYouKnowYourFriendsGame m_Game;

        public MainWindow()
        {
            InitializeComponent();
            m_CurrentState = eState.Login;
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login(r_GuyAppID,
                "publish_to_groups",
                "public_profile",
                "user_birthday",
                "user_friends",
                "user_events",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_photos",
                "user_posts",
                "user_tagged_places",
                "user_videos",
                "read_page_mailboxes",
                "manage_pages",
                "publish_pages");

            if (!string.IsNullOrEmpty(result.AccessToken))
            {
                LoggedInUser = result.LoggedInUser;
                // do something with user info
            }
            else
            {
                MessageBox.Show(result.ErrorMessage);
            }

        }

        private void loginButton_Click(object sender, System.EventArgs e)
        {
            loginAndInit();
            m_CurrentState = eState.MainState;
            handleState();
        }


        private void handleState()
        {
            clearScreen();

            switch (m_CurrentState)
            {
                case eState.MainState:
                    handleMainState();
                    break;
                case eState.Post:
                    handlePostState();
                    break;
                case eState.Events:
                    handleEventsState();
                    break;
                case eState.LikedPages:
                    handleLikedPagesState();
                    break;
                case eState.FirstFeature:
                    handleFirstFeature();
                    break;
                case eState.HowWellDoYouKnowYourFriendsGame:
                    handleGameState();
                    break;
            }
        }

        private void handleGameState()
        {
            try
            {
                new Thread(() =>
                {
                    uiThreadInvoke(clearGamePanel);
                    startGame();
                    uiThreadInvoke(() => gamePanel.Visible = true);
                }).Start();
            }
            catch (NotEnoughFriendsException e)
            {
                MessageBox.Show("You don't have enough friends to play the game, sorry :'(");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void startGame()
        {
            m_Game = new HowWellDoYouKnowYourFriendsGame(LoggedInUser);
            uiThreadInvoke(() =>
            {
                initFirstQuestion();
                initSecondQuestion();
                initThirdQuestion();
            });
        }

        private void initThirdQuestion()
        {
            Question question = m_Game.ThirdQuestion;

            thirdQuestionLabel.Text = question.QuestionContent;

            thirdQuestionFirstOptionRadioButton.Text = question.PossibleAnswers[0];
            thirdQuestionSecondOptionRadioButton.Text = question.PossibleAnswers[1];
            thirdQuestionThirdOptionRadioButton.Text = question.PossibleAnswers[2];
        }

        private void initSecondQuestion()
        {
            Question question = m_Game.SecondQuestion;

            secondQuestionLabel.Text = question.QuestionContent;

            secondQuestionFirstOptionRadioButton.Text = question.PossibleAnswers[0];
            secondQuestionSecondOptionRadioButton.Text = question.PossibleAnswers[1];
            secondQuestionThirdOptionRadioButton.Text = question.PossibleAnswers[2];
        }

        private void initFirstQuestion()
        {
            Question question = m_Game.FirstQuestion;

            firstQuestionLabel.Text = question.QuestionContent;
            firstQuestionPictureBox.LoadAsync(question.Answer.PictureNormalURL);

            firstQuestionFirstOptionRadioButton.Text = question.PossibleAnswers[0];
            firstQuestionSecondOptionRadioButton.Text = question.PossibleAnswers[1];
            firstQuestionThirdOptionRadioButton.Text = question.PossibleAnswers[2];
        }

        private void handleFirstFeature()
        {
            fansListBox.Items.Clear();
            fansListBox.Visible = true;
            
            try
            {
                new Thread(findFans).Start();
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format("Couldn't show fans {0} {1}", Environment.NewLine, e.Message));
            }
        }

        private void findFans()
        {
                uiThreadInvoke(() => loadingLabel.Visible = true);
                FacebookObjectCollection<Album> albums = LoggedInUser.Albums;
                List<Photo> photos = new List<Photo>();
                foreach (Album album in albums)
                {
                    foreach (Photo photo in album.Photos)
                    {
                        if (photo.LikedBy.Count > 0)
                        {
                        photos.Add(photo);
                        }
                    }
                }

                Dictionary<string, int> usersToLikes = new Dictionary<string, int>();
                foreach (Photo photo in photos)
                {
                    updateDictionary(photo.LikedBy, usersToLikes);
                }

                List<KeyValuePair<string, int>> listToSort = usersToLikes.ToList();

                listToSort.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

                foreach (KeyValuePair<string, int> pair in listToSort)
                {
                    uiThreadInvoke(() =>
                        fansListBox.Items.Add(string.Format("{0} - {1} Likes", pair.Key, pair.Value)));
                }

            uiThreadInvoke(() => loadingLabel.Visible = false);
        }

        private void uiThreadInvoke(Action action)
        {
            Invoke((MethodInvoker) delegate() { action(); });
        }


        private void handleLikedPagesState()
        {
            likePagedListBox.Visible = true;

            try
            {
                likePagedListBox.Items.Clear();
                likePagedListBox.DisplayMember = "Name";

                foreach (Page page in LoggedInUser.LikedPages)
                {
                    likePagedListBox.Items.Add(page);
                }

                if (LoggedInUser.LikedPages.Count == 0)
                {
                    MessageBox.Show("No liked pages");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Couldn't show liked pages{0}{1}",
                    Environment.NewLine,
                    ex.Message));
            }
        }

        private void handleEventsState()
        {
            eventsListBox.Visible = true;

            try
            {
                eventsListBox.Items.Clear();
                eventsListBox.DisplayMember = "Name";

                foreach (Event fbEvent in LoggedInUser.Events)
                {
                    eventsListBox.Items.Add(fbEvent);
                }

                if (LoggedInUser.Events.Count == 0)
                {
                    MessageBox.Show("No events found");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Couldn't show events{0}{1}",
                    Environment.NewLine,
                    ex.Message));
            }
        }

        private void handlePostState()
        {
            postTextBox.Visible = true;
            sendPostButton.Visible = true;
            cancelPostButton.Visible = true;
        }

        private void handleMainState()
        {
            this.BackgroundImage = Properties.Resources.mainWindow1;
            profilePictureBox.LoadAsync(LoggedInUser.PictureNormalURL);

            List<Control> controlsToShow = new List<Control>()
            {
                profilePictureBox,
                welcomeLabel,
                postButton,
                upcomingEventsButton,
                likedPagesButton,
                fansButton,
                secondFeatureButton
            };

            foreach (Control ctrl in controlsToShow)
            {
                ctrl.Visible = true;
            }

            welcomeLabel.Text = string.Format("Logged in as: {0}", LoggedInUser.Name);
        }

        private void loginButton_MouseEnter(object sender, System.EventArgs e)
        {
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = FlatStyle.Flat;
            this.loginButton.TabStop = false;
            loginButton.BackgroundImage = Properties.Resources.login2;
        }

        private void loginButton_MouseLeave(object sender, System.EventArgs e)
        {
            loginButton.BackgroundImage = Properties.Resources.login1;
        }

        private void postButton_Click(object sender, System.EventArgs e)
        {
            m_CurrentState = eState.Post;
            handleState();
        }

        private void sendPostButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                Status postedStatus = LoggedInUser.PostStatus(postTextBox.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Couldn't post{0}{1}",
                    Environment.NewLine,
                    ex.Message));
            }

        }

        private void upcomingEventsButton_Click(object sender, System.EventArgs e)
        {
            m_CurrentState = eState.Events;
            handleState();
        }

        /// <summary>
        /// hides all controls except MainWindow controls
        /// </summary>
        private void clearScreen()
        {
            List<Control> controlsToShow = new List<Control>()
            {
                this,
                profilePictureBox,
                welcomeLabel,
                postButton,
                upcomingEventsButton,
                likedPagesButton,
                fansButton,
                secondFeatureButton
            };

            foreach (Control ctrl in this.Controls)
            {
                if (!controlsToShow.Contains(ctrl))
                {
                    ctrl.Visible = false;
                }
            }
        }

        private void likedPagesButton_Click(object sender, System.EventArgs e)
        {
            m_CurrentState = eState.LikedPages;
            handleState();
        }

        private void fansButton_Click(object sender, System.EventArgs e)
        {
            m_CurrentState = eState.FirstFeature;
            handleState();
        }

        private void updateDictionary(FacebookObjectCollection<User> i_PhotoLikedBy,
            Dictionary<string, int> i_UsersToLikes)
        {
            foreach (User user in i_PhotoLikedBy)
            {
                if (!i_UsersToLikes.ContainsKey(user.Name))
                {
                    i_UsersToLikes.Add(user.Name, 1);
                }
                else
                {
                    i_UsersToLikes[user.Name]++;
                }
            }
        }

        private void secondFeatureButton_Click(object sender, System.EventArgs e)
        {
            m_CurrentState = eState.HowWellDoYouKnowYourFriendsGame;
            handleState();
        }

        private void postButton_MouseHover(object sender, EventArgs e)
        {
            postButton.BackgroundImage = Properties.Resources.optionButton2;
        }

        private void postButton_MouseLeave(object sender, EventArgs e)
        {
            postButton.BackgroundImage = Properties.Resources.optionButton1;
        }

        private void upcomingEventsButton_MouseHover(object sender, EventArgs e)
        {
            upcomingEventsButton.BackgroundImage = Properties.Resources.optionButton2;
        }

        private void upcomingEventsButton_MouseLeave(object sender, EventArgs e)
        {
            upcomingEventsButton.BackgroundImage = Properties.Resources.optionButton1;
        }

        private void likedPagesButton_MouseHover(object sender, EventArgs e)
        {
            likedPagesButton.BackgroundImage = Properties.Resources.optionButton2;
        }

        private void likedPagesButton_MouseLeave(object sender, EventArgs e)
        {
            likedPagesButton.BackgroundImage = Properties.Resources.optionButton1;
        }

        private void fansButton_MouseHover(object sender, EventArgs e)
        {
            fansButton.BackgroundImage = Properties.Resources.optionButton2;
        }

        private void fansButton_MouseLeave(object sender, EventArgs e)
        {
            fansButton.BackgroundImage = Properties.Resources.optionButton1;
        }

        private void secondFeatureButton_MouseHover(object sender, EventArgs e)
        {
            secondFeatureButton.BackgroundImage = Properties.Resources.optionButton2;
        }

        private void secondFeatureButton_MouseLeave(object sender, EventArgs e)
        {
            secondFeatureButton.BackgroundImage = Properties.Resources.optionButton1;
        }

        private void cancelPostButton_MouseHover(object sender, EventArgs e)
        {
            cancelPostButton.BackgroundImage = Properties.Resources.cancel1;
        }

        private void cancelPostButton_MouseLeave(object sender, EventArgs e)
        {
            cancelPostButton.BackgroundImage = Properties.Resources.cancel2;
        }


        private void sendPostButton_MouseHover(object sender, EventArgs e)
<<<<<<< HEAD
=======
        {
            sendPostButton.BackgroundImage = Properties.Resources.post1;
        }

        private void sendPostButton_MouseLeave(object sender, EventArgs e)
        {
            sendPostButton.BackgroundImage = Properties.Resources.post2;
        }

        private void welcomeLabel_Click(object sender, EventArgs e)
>>>>>>> f6226097531ae9d7ec056c17d4e1ece05d315e62
        {
            sendPostButton.BackgroundImage = Properties.Resources.post1;
        }

        private void sendPostButton_MouseLeave(object sender, EventArgs e)
        {
            sendPostButton.BackgroundImage = Properties.Resources.post2;
        }

        private void cancelPostButton_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        private void checkGameResultsButton_Click(object sender, EventArgs e)
        {
            try
            {
                showAnswerFeedbackPictures();
                colorAllAnswers();
            }
            catch (Exception exception)
            {
                MessageBox.Show("You must answer all the questions!");
            }

        }

        private void showAnswerFeedbackPictures()
        {
            string firstAnswer = getUserAnswer(firstQuestionPanel);
            string secondAnswer = getUserAnswer(secondQuestionPanel);
            string thirdAnswer = getUserAnswer(thirdQuestionPanel);

            ShowAnswerFeedback(questionOneResultPictureBox, firstAnswer, m_Game.FirstQuestion.Answer);
            ShowAnswerFeedback(questionTwoResultPictureBox, secondAnswer, m_Game.SecondQuestion.Answer);
            ShowAnswerFeedback(questionThreeResultPictureBox, thirdAnswer, m_Game.ThirdQuestion.Answer);
        }

        private void colorAllAnswers()
        {
            colorQuestionAnswers(firstQuestionPanel, m_Game.FirstQuestion.Answer);
            colorQuestionAnswers(secondQuestionPanel, m_Game.SecondQuestion.Answer);
            colorQuestionAnswers(thirdQuestionPanel, m_Game.ThirdQuestion.Answer);
        }

        private void colorQuestionAnswers(Panel i_QuestionPanel, User i_Answer)
        {
            foreach (Control control in i_QuestionPanel.Controls)
            {
                if (control is RadioButton)
                {
                    control.ForeColor = control.Text.Equals(i_Answer.Name)
                        ? Color.Green
                        : Color.Red;
                }
            }
        }

        private void ShowAnswerFeedback(PictureBox i_PictureBox, string i_UserAnswer, User i_ExpectedAnswer)
        {
            i_PictureBox.Image = (i_UserAnswer.Equals(i_ExpectedAnswer.Name))
                ? Properties.Resources.V
                : Properties.Resources.X;

            i_PictureBox.Visible = true;
        }

        private string getUserAnswer(Panel i_QuestionPanel)
        {
            foreach (Control control in i_QuestionPanel.Controls)
            {
                if (control is RadioButton)
                {
                    if ((control as RadioButton).Checked)
                    {
                        return control.Text;
                    }
                }
            }

            throw new Exception();
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            clearGamePanel();
            handleGameState();
        }

        private void clearGamePanel()
        {
            foreach (Control control in gamePanel.Controls)
            {
                if (control is Panel)
                {
                    foreach (Control ctrl in control.Controls)
                    {
                        if (ctrl is RadioButton)
                        {
                            (ctrl as RadioButton).Checked = false;
                            ctrl.ForeColor = Color.Black;
                        }
                    }
                }
            }

            questionOneResultPictureBox.Visible = false;
            questionTwoResultPictureBox.Visible = false;
            questionThreeResultPictureBox.Visible = false;
        }

        private void questionOneResultPictureBox_Click(object sender, EventArgs e)
        {

        }
    }

    public class RoundButton : Button
    {
        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            GraphicsPath grPath = new GraphicsPath();
            grPath.AddEllipse(1, 1, this.Width - 4 , this.Height - 4);
            this.Region = new System.Drawing.Region(grPath);
            base.OnPaint(e);
        }
    }

    public class RoundedEdgeButton : Button
    {
        GraphicsPath GetRoundPath(RectangleF Rect, int radius)
        {
            float r2 = radius / 2f;
            GraphicsPath GraphPath = new GraphicsPath();

            GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
            GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
            GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
            GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
            GraphPath.AddArc(Rect.X + Rect.Width - radius,
                             Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
            GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
            GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
            GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);

            GraphPath.CloseFigure();
            return GraphPath;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
            GraphicsPath GraphPath = GetRoundPath(Rect, 50);

            this.Region = new Region(GraphPath);
            using (Pen pen = new Pen(Color.WhiteSmoke, 3f))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, GraphPath);
            }
        }
    }
}
