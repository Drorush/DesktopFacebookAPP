using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using static DesktopFacebookAPP.HowWellDoYouKnowYourFriendsGame;

namespace DesktopFacebookAPP
{
    public enum eState
    {
        Login,
        MainState,
        Home,
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
            LoginResult result = FacebookService.Login(
                r_GuyAppID,
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
                case eState.Home:
                    handleHomeState();
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

        private void handleHomeState()
        {
            clearScreen();
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
            catch (NotEnoughFriendsException)
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
            m_Game = HowWellDoYouKnowYourFriendsGame.Instance(LoggedInUser);

            uiThreadInvoke(() =>
            {
                initFirstQuestion();
                initSecondQuestion();
                initThirdQuestion();
            });
        }

        private void initThirdQuestion()
        {
            Question question = m_Game.Questions[2];

            thirdQuestionLabel.Text = question.QuestionContent;

            thirdQuestionFirstOptionRadioButton.Text = question.PossibleAnswers[0];
            thirdQuestionSecondOptionRadioButton.Text = question.PossibleAnswers[1];
            thirdQuestionThirdOptionRadioButton.Text = question.PossibleAnswers[2];
        }

        private void initSecondQuestion()
        {
            Question question = m_Game.Questions[1];

            secondQuestionLabel.Text = question.QuestionContent;

            secondQuestionFirstOptionRadioButton.Text = question.PossibleAnswers[0];
            secondQuestionSecondOptionRadioButton.Text = question.PossibleAnswers[1];
            secondQuestionThirdOptionRadioButton.Text = question.PossibleAnswers[2];
        }

        private void initFirstQuestion()
        {
            Question question = m_Game.Questions[0];

            firstQuestionLabel.Text = question.QuestionContent;
            firstQuestionPictureBox.LoadAsync(question.Answer.PictureNormalURL);

            firstQuestionFirstOptionRadioButton.Text = question.PossibleAnswers[0];
            firstQuestionSecondOptionRadioButton.Text = question.PossibleAnswers[1];
            firstQuestionThirdOptionRadioButton.Text = question.PossibleAnswers[2];
        }

        private void handleFirstFeature()
        {
            fansPanel.Visible = true;
            
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

            Dictionary<User, int> usersToLikes = new Dictionary<User, int>();
            foreach (Photo photo in photos)
            {
                updateDictionary(photo.LikedBy, usersToLikes);
            }

            List<KeyValuePair<User, int>> listToSort = usersToLikes.ToList();

            listToSort.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            uiThreadInvoke(() =>
            {
                fanBindingSource.DataSource = listToSort.Select(kvp => new Fan(kvp.Key, kvp.Value));
                fanDisplayPanel.Visible = true;
                loadingLabel.Visible = false;
            });
        }

        private void uiThreadInvoke(Action action)
        {
            Invoke(action);
        }

        private void handleLikedPagesState()
        {
            likedPagesPanel.Visible = true;

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
                MessageBox.Show(string.Format(
                    "Couldn't show liked pages{0}{1}",
                    Environment.NewLine,
                    ex.Message));
            }
        }

        private void handleEventsState()
        {
            eventsPanel.Visible = true;

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
                MessageBox.Show(string.Format(
                    "Couldn't show events{0}{1}",
                    Environment.NewLine,
                    ex.Message));
            }
        }

        private void handlePostState()
        {
            postPanel.Visible = true;
        }

        private void handleMainState()
        {
            profilePictureBox.LoadAsync(LoggedInUser.PictureNormalURL);

            List<Control> controlsToShow = new List<Control>()
            {
                upperLinePanel,
                profilePicturePanel,
                optionsPanel
            };

            foreach (Control ctrl in controlsToShow)
            {
                ctrl.Visible = true;
            }

            welcomeLabel.Text = string.Format("Welcome {0}!", LoggedInUser.Name);
        }

        private void postButton_Click(object sender, System.EventArgs e)
        {
            m_CurrentState = eState.Post;
            handleOptionClick(sender, e);
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
                MessageBox.Show(string.Format(
                    "Couldn't post{0}{1}",
                    Environment.NewLine,
                    ex.Message));
            }
        }

        private void upcomingEventsButton_Click(object sender, System.EventArgs e)
        {
            m_CurrentState = eState.Events;
            handleOptionClick(sender, e);
        }

        /// <summary>
        /// hides all controls except MainWindow controls
        /// </summary>
        private void clearScreen()
        {
            List<Control> controlsToShow = new List<Control>()
            {
                this,
                upperLinePanel,
                profilePicturePanel,
                optionsPanel
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
            handleOptionClick(sender, e);
        }

        private void fansButton_Click(object sender, System.EventArgs e)
        {
            m_CurrentState = eState.FirstFeature;
            handleOptionClick(sender, e);
        }

        private void updateDictionary(FacebookObjectCollection<User> i_PhotoLikedBy, Dictionary<User, int> i_UsersToLikes)
        {
            foreach (User user in i_PhotoLikedBy)
            {
                if (!i_UsersToLikes.ContainsKey(user))
                {
                    i_UsersToLikes.Add(user, 1);
                }
                else
                {
                    i_UsersToLikes[user]++;
                }
            }
        }

        private void friendsGameButton_Click(object sender, System.EventArgs e)
        {
            m_CurrentState = eState.HowWellDoYouKnowYourFriendsGame;
            handleOptionClick(sender, e);
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
            catch (Exception)
            {
                MessageBox.Show("You must answer all the questions!");
            }
        }

        private void showAnswerFeedbackPictures()
        {
            string firstAnswer = getUserAnswer(firstQuestionPanel);
            string secondAnswer = getUserAnswer(secondQuestionPanel);
            string thirdAnswer = getUserAnswer(thirdQuestionPanel);

            ShowAnswerFeedback(questionOneResultPictureBox, firstAnswer, m_Game.Questions[0].Answer);
            ShowAnswerFeedback(questionTwoResultPictureBox, secondAnswer, m_Game.Questions[1].Answer);
            ShowAnswerFeedback(questionThreeResultPictureBox, thirdAnswer, m_Game.Questions[2].Answer);
        }

        private void colorAllAnswers()
        {
            colorQuestionAnswers(firstQuestionPanel, m_Game.Questions[0].Answer);
            colorQuestionAnswers(secondQuestionPanel, m_Game.Questions[1].Answer);
            colorQuestionAnswers(thirdQuestionPanel, m_Game.Questions[2].Answer);
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
            i_PictureBox.Image = i_UserAnswer.Equals(i_ExpectedAnswer.Name)
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

        private void homeButton_Click(object sender, EventArgs e)
        {
            m_CurrentState = eState.Home;
            handleOptionClick(sender, e);
        }

        private void handleOptionClick(object sender, EventArgs e)
        {
            sidePanel.Top = (sender as Button).Top;
            sidePanel.Height = (sender as Button).Height;
            handleState();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
