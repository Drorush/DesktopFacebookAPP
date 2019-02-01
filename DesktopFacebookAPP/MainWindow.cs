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
    public partial class MainWindow : Form
    {
        private readonly string r_AppID = "1168955353252324";

        private readonly string r_GuyAppID = "1450160541956417";

        private User LoggedInUser { get; set; }

        private HowWellDoYouKnowYourFriendsGame m_Game;

        private List<VisualQuestion> m_VisualQuestions = new List<VisualQuestion>();

        public MainWindow()
        {
            InitializeComponent();
            InitializeCollections();
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }

        private void InitializeCollections()
        {
            m_VisualQuestions = new List<VisualQuestion>
            {
                firstVisualQuestion,
                secondVisualQuestion,
                thirdVisualQuestion,
            };
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
            clearScreen();
            handleMainState();
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
                    initQuestions();
                });
        }

        private void initQuestions()
        {
            int i = 0;
            foreach (VisualQuestion visualQuestion in m_VisualQuestions)
            {
                visualQuestion.InitQuestion(m_Game.Questions[i++]);
            }
        }

        private void handleFansState()
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
            catch (Exception ex)
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
            catch (Exception ex)
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

        private void sendPostButton_Click(object sender, System.EventArgs e)
        {
            try
            {
                Status postedStatus = LoggedInUser.PostStatus(postTextBox.Text);
                MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format(
                    "Couldn't post{0}{1}",
                    Environment.NewLine,
                    ex.Message));
            }
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
                visualQuestion.ShowAnswerFeedbackPicture();
            }
        }

        private void colorAllAnswers()
        {
            foreach (VisualQuestion visualQuestion in m_VisualQuestions)
            {
                visualQuestion.ColorAnswer();
            }
        }

        private void PlayAgainButton_Click(object sender, EventArgs e)
        {
            handleGameState();
        }

        private void clearGamePanel()
        {
            foreach (VisualQuestion visualQuestion in m_VisualQuestions)
            {
                visualQuestion.Clear();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public abstract class MainItemClickCommand : ICommand {
            public MainWindow Client;

            public void Execute()
            {
                Client.clearScreen();

                handleState();

            }

            public abstract void handleState();
        }

        public class HomeClickCommand : MainItemClickCommand
        {
            public override void handleState()
            {
                Client.handleHomeState();
            }
        }

        public class PostClickCommand : MainItemClickCommand
        {
            public override void handleState()
            {
                Client.handlePostState();
            }
        }

        public class EventsClickCommand : MainItemClickCommand
        {
            public override void handleState()
            {
                Client.handleEventsState();
            }
        }

        public class LikedPagesClickCommand : MainItemClickCommand
        {
            public override void handleState()
            {
                Client.handleLikedPagesState();
            }
        }

        public class FansClickCommand : MainItemClickCommand
        {
            public override void handleState()
            {
                Client.handleFansState();
            }
        }

        public class GameClickCommand : MainItemClickCommand
        {
            public override void handleState()
            {
                Client.handleGameState();
            }
        }
    }
}
