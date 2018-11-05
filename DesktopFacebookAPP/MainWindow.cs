using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

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
        SecondFeature
    }

    public partial class MainWindow : Form
    {
        private readonly string r_AppID = "1168955353252324";

        private readonly string r_GuyAppID = "1450160541956417";

        private User LoggedInUser { get; set; }

        private eState m_CurrentState;

        public MainWindow()
        {
            InitializeComponent();
            m_CurrentState = eState.Login;
        }

        private void loginAndInit()
        {
            LoginResult result = FacebookService.Login(r_AppID,
                "public_profile",
                "user_birthday",
                "user_email",
                "user_friends"
            );

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
            changeState();
        }

        private void changeState()
        {
            if (m_CurrentState == eState.Login)
            {
                handleSecondState();

                m_CurrentState = eState.MainState;
            }
        }

        private void handleSecondState()
        {
            loginButton.Visible = false;
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
            welcomeLabel.Text = string.Format("Welcome {0}!", LoggedInUser.Name);
        }

        private void loginButton_MouseEnter(object sender, System.EventArgs e)
        {
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.TabStop = false;
            loginButton.BackgroundImage = Properties.Resources.second;
        }

        private void loginButton_MouseLeave(object sender, System.EventArgs e)
        {
            loginButton.BackgroundImage = Properties.Resources.first;
        }

        private void postButton_Click(object sender, System.EventArgs e)
        {
            postTextBox.Visible = true;
            sendPostButton.Visible = true;
            cancelPostButton.Visible = true;
        }

        private void sendPostButton_Click(object sender, System.EventArgs e)
        {
            Status postedStatus = LoggedInUser.PostStatus(postTextBox.Text);
            MessageBox.Show("Status Posted! ID: " + postedStatus.Id);
        }

        private void upcomingEventsButton_Click(object sender, System.EventArgs e)
        {
            clearScreen();
            eventsListBox.Items.Clear();
            eventsListBox.DisplayMember = "Name";
            foreach (Event fbEvent in LoggedInUser.Events)
            {
                eventsListBox.Items.Add(fbEvent);
            }

            eventsListBox.Visible = true;

            if (LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No events found");
            }
        }

        /// <summary>
        /// hides all the controls
        /// </summary>
        private void clearScreen()
        {
        }

        private void likedPagesButton_Click(object sender, System.EventArgs e)
        {

        }

        private void fansButton_Click(object sender, System.EventArgs e)
        {
            FacebookObjectCollection<Album> albums = LoggedInUser.Albums;
            IEnumerable<Photo> photos = new FacebookObjectCollection<Photo>();
            foreach (Album album in albums)
            {
                photos = photos.Union(album.Photos);
            }

            Dictionary<User, int> usersToLikes = new Dictionary<User, int>();
            foreach (Photo photo in photos)
            {
                updateDictionary(photo.LikedBy, usersToLikes);
            }

            List<KeyValuePair<User, int>> listToSort = usersToLikes.ToList();

            listToSort.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));

            foreach (KeyValuePair<User, int> pair in listToSort)
            {
                fansListBox.Items.Add(pair.Key.UserName);
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
    }
}
