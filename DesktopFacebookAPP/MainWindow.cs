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

        private List<VisualQuestion> m_VisualQuestions = new List<VisualQuestion>();

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
                    handleFansState();
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
            m_VisualQuestions = new List<VisualQuestion> {
                visualQuestion1,
            visualQuestion2,
            visualQuestion3,
            };

        uiThreadInvoke(() =>
            {
                initQuestions();
            });
        }

        private void initQuestions()
        {
                visualQuestion1.initQuestion(m_Game.Questions[0]);
                visualQuestion2.initQuestion(m_Game.Questions[1]);
                visualQuestion3.initQuestion(m_Game.Questions[2]);
        }

        private void handleFansState()
        {
            fansListBox.Items.Clear();
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

        private void updateDictionary(FacebookObjectCollection<User> i_PhotoLikedBy, Dictionary<string, int> i_UsersToLikes)
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
            foreach (VisualQuestion visualQuestion in m_VisualQuestions)
            {
                string userAnswer = visualQuestion.getUserAnswer();
                string expectedAnswer = visualQuestion.getRightAnswer();

                visualQuestion.resultPictureBox.Image = userAnswer.Equals(expectedAnswer)
                    ? Properties.Resources.V
                    : Properties.Resources.X;

                visualQuestion.resultPictureBox.Visible = true;
            }
        }

        private void colorAllAnswers()
        {
            foreach (VisualQuestion visualQuestion in m_VisualQuestions)
            {
                string rightAnswer = visualQuestion.getRightAnswer();
                foreach (Control control in visualQuestion.QuestionPanel.Controls)
                {
                    if (control is RadioButton)
                    {
                        control.ForeColor = control.Text.Equals(rightAnswer)
                            ? Color.Green
                            : Color.Red;
                    }
                }
            }
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            //clearGamePanel();
            handleGameState();

        }

        private void clearGamePanel()
        {
            foreach (VisualQuestion visualQuestion in m_VisualQuestions)
            {
                visualQuestion.clear();
            }
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
