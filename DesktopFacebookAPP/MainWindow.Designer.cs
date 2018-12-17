using System.Drawing;
using System.Windows.Forms;

namespace DesktopFacebookAPP
{
    public partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label numOfLikesLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label linkLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label birthdayLabel;
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.likePagedListBox = new System.Windows.Forms.ListBox();
            this.fansListBox = new System.Windows.Forms.ListBox();
            this.fanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadingLabel = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.playAgainButton = new DesktopFacebookAPP.RoundedButton();
            this.checkGameResultsButton = new DesktopFacebookAPP.RoundedButton();
            this.thirdVisualQuestion = new DesktopFacebookAPP.VisualQuestion();
            this.secondVisualQuestion = new DesktopFacebookAPP.VisualQuestion();
            this.firstVisualQuestion = new DesktopFacebookAPP.VisualQuestion();
            this.FriendsGameHeadlineLabel = new System.Windows.Forms.Label();
            this.eventsPanel = new System.Windows.Forms.Panel();
            this.eventsHeadlineLabel = new System.Windows.Forms.Label();
            this.postButton = new System.Windows.Forms.Button();
            this.upperLinePanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.friendsGameButton = new System.Windows.Forms.Button();
            this.fansButton = new System.Windows.Forms.Button();
            this.likedPagesButton = new System.Windows.Forms.Button();
            this.upcomingEventsButton = new System.Windows.Forms.Button();
            this.profilePicturePanel = new System.Windows.Forms.Panel();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.postPanel = new System.Windows.Forms.Panel();
            this.postHeadlineLabel = new System.Windows.Forms.Label();
            this.sendPostButton = new DesktopFacebookAPP.RoundedEdgesButton();
            this.cancelPostButton = new DesktopFacebookAPP.RoundedEdgesButton();
            this.likedPagesPanel = new System.Windows.Forms.Panel();
            this.likedPagesHeadlineLabel = new System.Windows.Forms.Label();
            this.fansPanel = new System.Windows.Forms.Panel();
            this.fanDisplayPanel = new System.Windows.Forms.Panel();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.imageNormalPictureBox = new System.Windows.Forms.PictureBox();
            this.linkLinkLabel = new System.Windows.Forms.LinkLabel();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numOfLikesTextBox = new System.Windows.Forms.TextBox();
            this.fansSecondHeadlineLabel = new System.Windows.Forms.Label();
            this.fansHeadlineLabel = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginButton = new DesktopFacebookAPP.RoundedEdgesButton();
            numOfLikesLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            linkLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.gamePanel.SuspendLayout();
            this.eventsPanel.SuspendLayout();
            this.upperLinePanel.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.profilePicturePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.postPanel.SuspendLayout();
            this.likedPagesPanel.SuspendLayout();
            this.fansPanel.SuspendLayout();
            this.fanDisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).BeginInit();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // numOfLikesLabel
            // 
            numOfLikesLabel.AutoSize = true;
            numOfLikesLabel.Location = new System.Drawing.Point(12, 157);
            numOfLikesLabel.Name = "numOfLikesLabel";
            numOfLikesLabel.Size = new System.Drawing.Size(136, 25);
            numOfLikesLabel.TabIndex = 0;
            numOfLikesLabel.Text = "Num Of Likes:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 210);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(66, 25);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new System.Drawing.Point(12, 263);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(54, 25);
            linkLabel.TabIndex = 8;
            linkLabel.Text = "Link:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 104);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(70, 25);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(12, 316);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(89, 25);
            birthdayLabel.TabIndex = 11;
            birthdayLabel.Text = "Birthday:";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(2, 178);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(264, 72);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome !!!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // postTextBox
            // 
            this.postTextBox.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postTextBox.Location = new System.Drawing.Point(75, 187);
            this.postTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.postTextBox.Multiline = true;
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(821, 361);
            this.postTextBox.TabIndex = 9;
            this.postTextBox.Text = "Write your post here, than click \"share!\"";
            this.postTextBox.WordWrap = false;
            // 
            // eventsListBox
            // 
            this.eventsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsListBox.DisplayMember = "name";
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.ItemHeight = 24;
            this.eventsListBox.Location = new System.Drawing.Point(66, 177);
            this.eventsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(804, 436);
            this.eventsListBox.TabIndex = 41;
            this.eventsListBox.Visible = false;
            // 
            // likePagedListBox
            // 
            this.likePagedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.likePagedListBox.DisplayMember = "name";
            this.likePagedListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likePagedListBox.FormattingEnabled = true;
            this.likePagedListBox.ItemHeight = 34;
            this.likePagedListBox.Location = new System.Drawing.Point(98, 173);
            this.likePagedListBox.Margin = new System.Windows.Forms.Padding(2);
            this.likePagedListBox.Name = "likePagedListBox";
            this.likePagedListBox.Size = new System.Drawing.Size(821, 480);
            this.likePagedListBox.TabIndex = 42;
            // 
            // fansListBox
            // 
            this.fansListBox.DataSource = this.fanBindingSource;
            this.fansListBox.DisplayMember = "FanDisplayContent";
            this.fansListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fansListBox.FormattingEnabled = true;
            this.fansListBox.ItemHeight = 34;
            this.fansListBox.Location = new System.Drawing.Point(61, 292);
            this.fansListBox.Margin = new System.Windows.Forms.Padding(2);
            this.fansListBox.Name = "fansListBox";
            this.fansListBox.Size = new System.Drawing.Size(495, 378);
            this.fansListBox.TabIndex = 43;
            // 
            // fanBindingSource
            // 
            this.fanBindingSource.DataSource = typeof(DesktopFacebookAPP.Fan);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // loadingLabel
            // 
            this.loadingLabel.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.Location = new System.Drawing.Point(169, 423);
            this.loadingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(258, 136);
            this.loadingLabel.TabIndex = 46;
            this.loadingLabel.Text = "Loading your fans... It might take up to 30 seconds, But it worth it!";
            this.loadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadingLabel.Visible = false;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePanel.Controls.Add(this.playAgainButton);
            this.gamePanel.Controls.Add(this.checkGameResultsButton);
            this.gamePanel.Controls.Add(this.thirdVisualQuestion);
            this.gamePanel.Controls.Add(this.secondVisualQuestion);
            this.gamePanel.Controls.Add(this.firstVisualQuestion);
            this.gamePanel.Controls.Add(this.FriendsGameHeadlineLabel);
            this.gamePanel.Location = new System.Drawing.Point(649, 52);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(1085, 844);
            this.gamePanel.TabIndex = 51;
            this.gamePanel.Visible = false;
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.playAgainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playAgainButton.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.playAgainButton.Location = new System.Drawing.Point(506, 728);
            this.playAgainButton.Margin = new System.Windows.Forms.Padding(1);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(188, 101);
            this.playAgainButton.TabIndex = 50;
            this.playAgainButton.Text = "Play again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // checkGameResultsButton
            // 
            this.checkGameResultsButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.checkGameResultsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkGameResultsButton.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.checkGameResultsButton.Location = new System.Drawing.Point(256, 728);
            this.checkGameResultsButton.Margin = new System.Windows.Forms.Padding(1);
            this.checkGameResultsButton.Name = "checkGameResultsButton";
            this.checkGameResultsButton.Size = new System.Drawing.Size(185, 101);
            this.checkGameResultsButton.TabIndex = 50;
            this.checkGameResultsButton.Text = "Answer!";
            this.checkGameResultsButton.UseVisualStyleBackColor = false;
            this.checkGameResultsButton.Click += new System.EventHandler(this.checkGameResultsButton_Click);
            // 
            // thirdVisualQuestion
            // 
            this.thirdVisualQuestion.Location = new System.Drawing.Point(28, 519);
            this.thirdVisualQuestion.Name = "thirdVisualQuestion";
            this.thirdVisualQuestion.Size = new System.Drawing.Size(995, 192);
            this.thirdVisualQuestion.TabIndex = 54;
            // 
            // secondVisualQuestion
            // 
            this.secondVisualQuestion.Location = new System.Drawing.Point(30, 321);
            this.secondVisualQuestion.Name = "secondVisualQuestion";
            this.secondVisualQuestion.Size = new System.Drawing.Size(995, 192);
            this.secondVisualQuestion.TabIndex = 53;
            // 
            // firstVisualQuestion
            // 
            this.firstVisualQuestion.Location = new System.Drawing.Point(31, 123);
            this.firstVisualQuestion.Name = "firstVisualQuestion";
            this.firstVisualQuestion.Size = new System.Drawing.Size(995, 192);
            this.firstVisualQuestion.TabIndex = 52;
            // 
            // FriendsGameHeadlineLabel
            // 
            this.FriendsGameHeadlineLabel.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsGameHeadlineLabel.Location = new System.Drawing.Point(226, 2);
            this.FriendsGameHeadlineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FriendsGameHeadlineLabel.Name = "FriendsGameHeadlineLabel";
            this.FriendsGameHeadlineLabel.Size = new System.Drawing.Size(604, 96);
            this.FriendsGameHeadlineLabel.TabIndex = 51;
            this.FriendsGameHeadlineLabel.Text = "How well do you know your friends? Answer the questions to find out!";
            this.FriendsGameHeadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventsPanel
            // 
            this.eventsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eventsPanel.Controls.Add(this.eventsHeadlineLabel);
            this.eventsPanel.Controls.Add(this.eventsListBox);
            this.eventsPanel.Location = new System.Drawing.Point(712, 65);
            this.eventsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.eventsPanel.Name = "eventsPanel";
            this.eventsPanel.Size = new System.Drawing.Size(938, 768);
            this.eventsPanel.TabIndex = 54;
            this.eventsPanel.Visible = false;
            // 
            // eventsHeadlineLabel
            // 
            this.eventsHeadlineLabel.Font = new System.Drawing.Font("Century Gothic", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsHeadlineLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.eventsHeadlineLabel.Location = new System.Drawing.Point(131, 65);
            this.eventsHeadlineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventsHeadlineLabel.Name = "eventsHeadlineLabel";
            this.eventsHeadlineLabel.Size = new System.Drawing.Size(663, 89);
            this.eventsHeadlineLabel.TabIndex = 12;
            this.eventsHeadlineLabel.Text = "Here are your upcoming events, Stay tuned!";
            this.eventsHeadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // postButton
            // 
            this.postButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.postButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.postButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postButton.FlatAppearance.BorderSize = 0;
            this.postButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.postButton.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postButton.ForeColor = System.Drawing.Color.White;
            this.postButton.Location = new System.Drawing.Point(5, 175);
            this.postButton.Margin = new System.Windows.Forms.Padding(2);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(326, 105);
            this.postButton.TabIndex = 3;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = false;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // upperLinePanel
            // 
            this.upperLinePanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.upperLinePanel.Controls.Add(this.closeButton);
            this.upperLinePanel.Location = new System.Drawing.Point(-2, 0);
            this.upperLinePanel.Margin = new System.Windows.Forms.Padding(2);
            this.upperLinePanel.Name = "upperLinePanel";
            this.upperLinePanel.Size = new System.Drawing.Size(1740, 32);
            this.upperLinePanel.TabIndex = 52;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.x30;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(1698, -2);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(32, 32);
            this.closeButton.TabIndex = 57;
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // optionsPanel
            // 
            this.optionsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.optionsPanel.Controls.Add(this.sidePanel);
            this.optionsPanel.Controls.Add(this.homeButton);
            this.optionsPanel.Controls.Add(this.friendsGameButton);
            this.optionsPanel.Controls.Add(this.fansButton);
            this.optionsPanel.Controls.Add(this.likedPagesButton);
            this.optionsPanel.Controls.Add(this.upcomingEventsButton);
            this.optionsPanel.Controls.Add(this.postButton);
            this.optionsPanel.Location = new System.Drawing.Point(-2, 0);
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(2);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(338, 903);
            this.optionsPanel.TabIndex = 0;
            this.optionsPanel.Visible = false;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sidePanel.Location = new System.Drawing.Point(2, 66);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(16, 105);
            this.sidePanel.TabIndex = 56;
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.homeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(5, 66);
            this.homeButton.Margin = new System.Windows.Forms.Padding(2);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(326, 105);
            this.homeButton.TabIndex = 8;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // friendsGameButton
            // 
            this.friendsGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.friendsGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.friendsGameButton.FlatAppearance.BorderSize = 0;
            this.friendsGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.friendsGameButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsGameButton.ForeColor = System.Drawing.Color.White;
            this.friendsGameButton.Location = new System.Drawing.Point(5, 681);
            this.friendsGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.friendsGameButton.Name = "friendsGameButton";
            this.friendsGameButton.Size = new System.Drawing.Size(326, 140);
            this.friendsGameButton.TabIndex = 7;
            this.friendsGameButton.Text = "How well do you know your friends?";
            this.friendsGameButton.UseVisualStyleBackColor = true;
            this.friendsGameButton.Click += new System.EventHandler(this.friendsGameButton_Click);
            // 
            // fansButton
            // 
            this.fansButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fansButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fansButton.FlatAppearance.BorderSize = 0;
            this.fansButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fansButton.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fansButton.ForeColor = System.Drawing.Color.White;
            this.fansButton.Location = new System.Drawing.Point(5, 551);
            this.fansButton.Margin = new System.Windows.Forms.Padding(2);
            this.fansButton.Name = "fansButton";
            this.fansButton.Size = new System.Drawing.Size(326, 105);
            this.fansButton.TabIndex = 6;
            this.fansButton.Text = "Fans";
            this.fansButton.UseVisualStyleBackColor = true;
            this.fansButton.Click += new System.EventHandler(this.fansButton_Click);
            // 
            // likedPagesButton
            // 
            this.likedPagesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.likedPagesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.likedPagesButton.FlatAppearance.BorderSize = 0;
            this.likedPagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likedPagesButton.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likedPagesButton.ForeColor = System.Drawing.Color.White;
            this.likedPagesButton.Location = new System.Drawing.Point(5, 424);
            this.likedPagesButton.Margin = new System.Windows.Forms.Padding(2);
            this.likedPagesButton.Name = "likedPagesButton";
            this.likedPagesButton.Size = new System.Drawing.Size(326, 105);
            this.likedPagesButton.TabIndex = 5;
            this.likedPagesButton.Text = "Liked Pages";
            this.likedPagesButton.UseVisualStyleBackColor = true;
            this.likedPagesButton.Click += new System.EventHandler(this.likedPagesButton_Click);
            // 
            // upcomingEventsButton
            // 
            this.upcomingEventsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.upcomingEventsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upcomingEventsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upcomingEventsButton.FlatAppearance.BorderSize = 0;
            this.upcomingEventsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upcomingEventsButton.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingEventsButton.ForeColor = System.Drawing.Color.White;
            this.upcomingEventsButton.Location = new System.Drawing.Point(5, 303);
            this.upcomingEventsButton.Margin = new System.Windows.Forms.Padding(2);
            this.upcomingEventsButton.Name = "upcomingEventsButton";
            this.upcomingEventsButton.Size = new System.Drawing.Size(326, 96);
            this.upcomingEventsButton.TabIndex = 4;
            this.upcomingEventsButton.Text = " Upcoming events";
            this.upcomingEventsButton.UseVisualStyleBackColor = false;
            this.upcomingEventsButton.Click += new System.EventHandler(this.upcomingEventsButton_Click);
            // 
            // profilePicturePanel
            // 
            this.profilePicturePanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.profilePicturePanel.Controls.Add(this.profilePictureBox);
            this.profilePicturePanel.Controls.Add(this.welcomeLabel);
            this.profilePicturePanel.Location = new System.Drawing.Point(346, 32);
            this.profilePicturePanel.Margin = new System.Windows.Forms.Padding(2);
            this.profilePicturePanel.Name = "profilePicturePanel";
            this.profilePicturePanel.Size = new System.Drawing.Size(268, 257);
            this.profilePicturePanel.TabIndex = 0;
            this.profilePicturePanel.Visible = false;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePictureBox.Location = new System.Drawing.Point(51, 0);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(164, 164);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            // 
            // postPanel
            // 
            this.postPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.postPanel.Controls.Add(this.postHeadlineLabel);
            this.postPanel.Controls.Add(this.sendPostButton);
            this.postPanel.Controls.Add(this.cancelPostButton);
            this.postPanel.Controls.Add(this.postTextBox);
            this.postPanel.Location = new System.Drawing.Point(677, 80);
            this.postPanel.Margin = new System.Windows.Forms.Padding(2);
            this.postPanel.Name = "postPanel";
            this.postPanel.Size = new System.Drawing.Size(956, 768);
            this.postPanel.TabIndex = 53;
            this.postPanel.Visible = false;
            // 
            // postHeadlineLabel
            // 
            this.postHeadlineLabel.Font = new System.Drawing.Font("Century Gothic", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postHeadlineLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.postHeadlineLabel.Location = new System.Drawing.Point(88, 56);
            this.postHeadlineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.postHeadlineLabel.Name = "postHeadlineLabel";
            this.postHeadlineLabel.Size = new System.Drawing.Size(746, 89);
            this.postHeadlineLabel.TabIndex = 12;
            this.postHeadlineLabel.Text = "What\'s on your mind?";
            this.postHeadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sendPostButton
            // 
            this.sendPostButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sendPostButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendPostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendPostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendPostButton.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendPostButton.Location = new System.Drawing.Point(89, 343);
            this.sendPostButton.Name = "sendPostButton";
            this.sendPostButton.Size = new System.Drawing.Size(154, 66);
            this.sendPostButton.TabIndex = 10;
            this.sendPostButton.Text = "Share!";
            this.sendPostButton.UseVisualStyleBackColor = false;
            this.sendPostButton.Click += new System.EventHandler(this.sendPostButton_Click);
            // 
            // cancelPostButton
            // 
            this.cancelPostButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.cancelPostButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelPostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelPostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelPostButton.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelPostButton.Location = new System.Drawing.Point(295, 343);
            this.cancelPostButton.Name = "cancelPostButton";
            this.cancelPostButton.Size = new System.Drawing.Size(154, 66);
            this.cancelPostButton.TabIndex = 11;
            this.cancelPostButton.Text = "Cancel";
            this.cancelPostButton.UseVisualStyleBackColor = false;
            this.cancelPostButton.Click += new System.EventHandler(this.cancelPostButton_Click);
            // 
            // likedPagesPanel
            // 
            this.likedPagesPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.likedPagesPanel.Controls.Add(this.likedPagesHeadlineLabel);
            this.likedPagesPanel.Controls.Add(this.likePagedListBox);
            this.likedPagesPanel.Location = new System.Drawing.Point(732, 52);
            this.likedPagesPanel.Margin = new System.Windows.Forms.Padding(2);
            this.likedPagesPanel.Name = "likedPagesPanel";
            this.likedPagesPanel.Size = new System.Drawing.Size(978, 810);
            this.likedPagesPanel.TabIndex = 55;
            this.likedPagesPanel.Visible = false;
            // 
            // likedPagesHeadlineLabel
            // 
            this.likedPagesHeadlineLabel.Font = new System.Drawing.Font("Century Gothic", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likedPagesHeadlineLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.likedPagesHeadlineLabel.Location = new System.Drawing.Point(140, 58);
            this.likedPagesHeadlineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.likedPagesHeadlineLabel.Name = "likedPagesHeadlineLabel";
            this.likedPagesHeadlineLabel.Size = new System.Drawing.Size(663, 89);
            this.likedPagesHeadlineLabel.TabIndex = 12;
            this.likedPagesHeadlineLabel.Text = "Here are all the pages you liked!";
            this.likedPagesHeadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fansPanel
            // 
            this.fansPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fansPanel.Controls.Add(this.fanDisplayPanel);
            this.fansPanel.Controls.Add(this.loadingLabel);
            this.fansPanel.Controls.Add(this.fansSecondHeadlineLabel);
            this.fansPanel.Controls.Add(this.fansHeadlineLabel);
            this.fansPanel.Controls.Add(this.fansListBox);
            this.fansPanel.Location = new System.Drawing.Point(649, 107);
            this.fansPanel.Margin = new System.Windows.Forms.Padding(2);
            this.fansPanel.Name = "fansPanel";
            this.fansPanel.Size = new System.Drawing.Size(1041, 756);
            this.fansPanel.TabIndex = 55;
            this.fansPanel.Visible = false;
            // 
            // fanDisplayPanel
            // 
            this.fanDisplayPanel.BackColor = System.Drawing.Color.Gray;
            this.fanDisplayPanel.Controls.Add(birthdayLabel);
            this.fanDisplayPanel.Controls.Add(this.birthdayDateTimePicker);
            this.fanDisplayPanel.Controls.Add(emailLabel);
            this.fanDisplayPanel.Controls.Add(this.emailTextBox);
            this.fanDisplayPanel.Controls.Add(this.imageNormalPictureBox);
            this.fanDisplayPanel.Controls.Add(linkLabel);
            this.fanDisplayPanel.Controls.Add(this.linkLinkLabel);
            this.fanDisplayPanel.Controls.Add(nameLabel);
            this.fanDisplayPanel.Controls.Add(this.nameTextBox);
            this.fanDisplayPanel.Controls.Add(numOfLikesLabel);
            this.fanDisplayPanel.Controls.Add(this.numOfLikesTextBox);
            this.fanDisplayPanel.Location = new System.Drawing.Point(593, 294);
            this.fanDisplayPanel.Name = "fanDisplayPanel";
            this.fanDisplayPanel.Size = new System.Drawing.Size(405, 376);
            this.fanDisplayPanel.TabIndex = 48;
            this.fanDisplayPanel.Visible = false;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fanBindingSource, "FanUser.Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(164, 310);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 29);
            this.birthdayDateTimePicker.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fanBindingSource, "FanUser.Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(222, 210);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 29);
            this.emailTextBox.TabIndex = 5;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.fanBindingSource, "FanUser.ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(26, 13);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(75, 75);
            this.imageNormalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageNormalPictureBox.TabIndex = 7;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fanBindingSource, "FanUser.Link", true));
            this.linkLinkLabel.Location = new System.Drawing.Point(222, 263);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(100, 23);
            this.linkLinkLabel.TabIndex = 9;
            this.linkLinkLabel.TabStop = true;
            this.linkLinkLabel.Text = "linkLabel1";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fanBindingSource, "FanUser.Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(222, 104);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 29);
            this.nameTextBox.TabIndex = 11;
            // 
            // numOfLikesTextBox
            // 
            this.numOfLikesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fanBindingSource, "NumOfLikes", true));
            this.numOfLikesTextBox.Location = new System.Drawing.Point(222, 157);
            this.numOfLikesTextBox.Name = "numOfLikesTextBox";
            this.numOfLikesTextBox.Size = new System.Drawing.Size(100, 29);
            this.numOfLikesTextBox.TabIndex = 1;
            // 
            // fansSecondHeadlineLabel
            // 
            this.fansSecondHeadlineLabel.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fansSecondHeadlineLabel.Location = new System.Drawing.Point(54, 114);
            this.fansSecondHeadlineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fansSecondHeadlineLabel.Name = "fansSecondHeadlineLabel";
            this.fansSecondHeadlineLabel.Size = new System.Drawing.Size(884, 58);
            this.fansSecondHeadlineLabel.TabIndex = 47;
            this.fansSecondHeadlineLabel.Text = "Here are the friends who liked your pictures the most";
            // 
            // fansHeadlineLabel
            // 
            this.fansHeadlineLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fansHeadlineLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.fansHeadlineLabel.Location = new System.Drawing.Point(135, 30);
            this.fansHeadlineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fansHeadlineLabel.Name = "fansHeadlineLabel";
            this.fansHeadlineLabel.Size = new System.Drawing.Size(723, 80);
            this.fansHeadlineLabel.TabIndex = 12;
            this.fansHeadlineLabel.Text = "Find out your secert fans!  ";
            this.fansHeadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginPanel
            // 
            this.loginPanel.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.facebookBG;
            this.loginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Location = new System.Drawing.Point(-2, 0);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1734, 894);
            this.loginPanel.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 26.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(681, 397);
            this.loginButton.Margin = new System.Windows.Forms.Padding(5);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(397, 121);
            this.loginButton.TabIndex = 0;
            this.loginButton.TabStop = false;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1738, 901);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.fansPanel);
            this.Controls.Add(this.eventsPanel);
            this.Controls.Add(this.postPanel);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.profilePicturePanel);
            this.Controls.Add(this.upperLinePanel);
            this.Controls.Add(this.likedPagesPanel);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook APP";
            ((System.ComponentModel.ISupportInitialize)(this.fanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.gamePanel.ResumeLayout(false);
            this.eventsPanel.ResumeLayout(false);
            this.upperLinePanel.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.profilePicturePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.postPanel.ResumeLayout(false);
            this.postPanel.PerformLayout();
            this.likedPagesPanel.ResumeLayout(false);
            this.fansPanel.ResumeLayout(false);
            this.fanDisplayPanel.ResumeLayout(false);
            this.fanDisplayPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageNormalPictureBox)).EndInit();
            this.loginPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedEdgesButton loginButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label welcomeLabel;
        private Button postButton;
        private Button upcomingEventsButton;
        private Button likedPagesButton;
        private Button fansButton;
        private Button friendsGameButton;
        private TextBox postTextBox;
        private RoundedEdgesButton sendPostButton;
        private RoundedEdgesButton cancelPostButton;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.ListBox likePagedListBox;
        private System.Windows.Forms.ListBox fansListBox;
        private Label loadingLabel;
        private RoundedButton checkGameResultsButton;
        private Panel gamePanel;
        private RoundedButton playAgainButton;
        private Panel upperLinePanel;
        private Panel optionsPanel;
        private Panel profilePicturePanel;
        private Panel loginPanel;
        private Panel postPanel;
        private Label postHeadlineLabel;
        private Label eventsHeadlineLabel;
        private Panel eventsPanel;
        private Label FriendsGameHeadlineLabel;
        private Panel likedPagesPanel;
        private Label likedPagesHeadlineLabel;
        private Panel fansPanel;
        private Label fansHeadlineLabel;
        private Label fansSecondHeadlineLabel;
        private Button homeButton;
        private Panel sidePanel;
        private Button closeButton;
        private BindingSource userBindingSource;
        private Panel fanDisplayPanel;
        private BindingSource fanBindingSource;
        private TextBox emailTextBox;
        private PictureBox imageNormalPictureBox;
        private LinkLabel linkLinkLabel;
        private TextBox nameTextBox;
        private TextBox numOfLikesTextBox;
        private DateTimePicker birthdayDateTimePicker;
        private VisualQuestion thirdVisualQuestion;
        private VisualQuestion secondVisualQuestion;
        private VisualQuestion firstVisualQuestion;
    }
}