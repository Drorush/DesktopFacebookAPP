using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
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
            LoginResult result = FacebookService.Login("1450160541956417",
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
                "manage_pages"
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
                FacebookObjectCollection<Album> albums = LoggedInUser.Albums;
                List<Photo> photos = new List<Photo>();
                foreach (Album album in albums)
                {
                    foreach (Photo photo in album.Photos)
                    {
                        photos.Add(photo);
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
            m_CurrentState = eState.SecondFeature;
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

        private void welcomeLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelPostButton_Click(object sender, EventArgs e)
        {
            clearScreen();
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void commentButton_Click(object sender, EventArgs e)
        {
            try
            {
                List<Post> todayPosts = LoggedInUser.WallPosts
                    .Where(post =>
                        post.CreatedTime.GetValueOrDefault(DateTime.MinValue).Date == DateTime.Today)
                    .ToList();

                foreach (Post post in todayPosts)
                {
                    post.Comment(commentBackTextBox.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Couldn't comment on friends' posts:{0}{1}",
                    Environment.NewLine, ex.Message));
            }
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
