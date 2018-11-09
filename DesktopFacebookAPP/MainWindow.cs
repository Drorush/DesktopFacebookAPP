using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
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
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }
        
        private void loginAndInit()
        { 
           LoginResult result = FacebookService.Login(r_GuyAppID,
               "email",
                "user_posts",
                "user_friends",
                "user_likes",
                "user_photos",
                "user_events",
                "user_birthday",
                "user_location",
                "user_gender");

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
                case eState.SecondFeature:
                    handleSecondFeature();
                    break;
            }
        }

        private void handleSecondFeature()
        {
            commentBackTextBox.Visible = true;
            commentButton.Visible = true;
        }

        private void handleFirstFeature()
        {
            fansListBox.Visible = true;
        }

        private void handleLikedPagesState()
        {
            likePagedListBox.Visible = true;
        }

        private void handleEventsState()
        {
            eventsListBox.Visible = true;
        }

        private void handlePostState()
        {
            postTextBox.Visible = true;
            sendPostButton.Visible = true;
            cancelPostButton.Visible = true;
        }

        private void handleMainState()
        {
            this.BackgroundImage = Properties.Resources.mainScreen;
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
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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

            if (LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No events found");
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

        private void updateDictionary(FacebookObjectCollection<User> i_PhotoLikedBy,
            Dictionary<User, int> i_UsersToLikes)
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

        private void secondFeatureButton_Click(object sender, System.EventArgs e)
        {
            handleState();

            List<Post> todayPosts = LoggedInUser.WallPosts
                .Where(post =>
                    post.CreatedTime.GetValueOrDefault(DateTime.MinValue).Date == DateTime.Today)
                .ToList();

            foreach (Post post in todayPosts)
            {
                post.Comment(commentBackTextBox.Text);
            }
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

        private void welcomeLabel_Click(object sender, EventArgs e)
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
}
