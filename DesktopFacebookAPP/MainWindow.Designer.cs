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
            this.firstQuestionPanel = new System.Windows.Forms.Panel();
            this.questionOneResultPictureBox = new System.Windows.Forms.PictureBox();
            this.firstQuestionPictureBox = new System.Windows.Forms.PictureBox();
            this.firstQuestionLabel = new System.Windows.Forms.Label();
            this.firstQuestionThirdOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.firstQuestionSecondOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.firstQuestionFirstOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.secondQuestionPanel = new System.Windows.Forms.Panel();
            this.questionTwoResultPictureBox = new System.Windows.Forms.PictureBox();
            this.secondQuestionLabel = new System.Windows.Forms.Label();
            this.secondQuestionThirdOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.secondQuestionSecondOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.secondQuestionFirstOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.thirdQuestionPanel = new System.Windows.Forms.Panel();
            this.questionThreeResultPictureBox = new System.Windows.Forms.PictureBox();
            this.thirdQuestionLabel = new System.Windows.Forms.Label();
            this.thirdQuestionThirdOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.thirdQuestionSecondOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.thirdQuestionFirstOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.FriendsGameHeadlineLabel = new System.Windows.Forms.Label();
            this.playAgainButton = new DesktopFacebookAPP.RoundedButton();
            this.checkGameResultsButton = new DesktopFacebookAPP.RoundedButton();
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
            this.firstQuestionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionOneResultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstQuestionPictureBox)).BeginInit();
            this.secondQuestionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionTwoResultPictureBox)).BeginInit();
            this.thirdQuestionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionThreeResultPictureBox)).BeginInit();
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
            numOfLikesLabel.Location = new System.Drawing.Point(12, 133);
            numOfLikesLabel.Name = "numOfLikesLabel";
            numOfLikesLabel.Size = new System.Drawing.Size(74, 13);
            numOfLikesLabel.TabIndex = 0;
            numOfLikesLabel.Text = "Num Of Likes:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(12, 164);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // linkLabel
            // 
            linkLabel.AutoSize = true;
            linkLabel.Location = new System.Drawing.Point(12, 196);
            linkLabel.Name = "linkLabel";
            linkLabel.Size = new System.Drawing.Size(30, 13);
            linkLabel.TabIndex = 8;
            linkLabel.Text = "Link:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 104);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 10;
            nameLabel.Text = "Name:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Location = new System.Drawing.Point(12, 231);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(48, 13);
            birthdayLabel.TabIndex = 11;
            birthdayLabel.Text = "Birthday:";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(1, 102);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(151, 41);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome !!!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // postTextBox
            // 
            this.postTextBox.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postTextBox.Location = new System.Drawing.Point(43, 107);
            this.postTextBox.Margin = new System.Windows.Forms.Padding(1);
            this.postTextBox.Multiline = true;
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(471, 208);
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
            this.eventsListBox.Location = new System.Drawing.Point(38, 101);
            this.eventsListBox.Margin = new System.Windows.Forms.Padding(1);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(461, 264);
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
            this.likePagedListBox.ItemHeight = 21;
            this.likePagedListBox.Location = new System.Drawing.Point(56, 99);
            this.likePagedListBox.Margin = new System.Windows.Forms.Padding(1);
            this.likePagedListBox.Name = "likePagedListBox";
            this.likePagedListBox.Size = new System.Drawing.Size(471, 277);
            this.likePagedListBox.TabIndex = 42;
            // 
            // fansListBox
            // 
            this.fansListBox.DataSource = this.fanBindingSource;
            this.fansListBox.DisplayMember = "FanDisplayContent";
            this.fansListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fansListBox.FormattingEnabled = true;
            this.fansListBox.ItemHeight = 21;
            this.fansListBox.Location = new System.Drawing.Point(9, 121);
            this.fansListBox.Margin = new System.Windows.Forms.Padding(1);
            this.fansListBox.Name = "fansListBox";
            this.fansListBox.Size = new System.Drawing.Size(328, 277);
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
            this.loadingLabel.Location = new System.Drawing.Point(14, 238);
            this.loadingLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(314, 47);
            this.loadingLabel.TabIndex = 46;
            this.loadingLabel.Text = "Loading your fans... It might take up to 30 seconds, But it worth it!";
            this.loadingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loadingLabel.Visible = false;
            // 
            // firstQuestionPanel
            // 
            this.firstQuestionPanel.BackColor = System.Drawing.Color.White;
            this.firstQuestionPanel.Controls.Add(this.questionOneResultPictureBox);
            this.firstQuestionPanel.Controls.Add(this.firstQuestionPictureBox);
            this.firstQuestionPanel.Controls.Add(this.firstQuestionLabel);
            this.firstQuestionPanel.Controls.Add(this.firstQuestionThirdOptionRadioButton);
            this.firstQuestionPanel.Controls.Add(this.firstQuestionSecondOptionRadioButton);
            this.firstQuestionPanel.Controls.Add(this.firstQuestionFirstOptionRadioButton);
            this.firstQuestionPanel.Location = new System.Drawing.Point(25, 56);
            this.firstQuestionPanel.Margin = new System.Windows.Forms.Padding(1);
            this.firstQuestionPanel.Name = "firstQuestionPanel";
            this.firstQuestionPanel.Size = new System.Drawing.Size(566, 107);
            this.firstQuestionPanel.TabIndex = 47;
            // 
            // questionOneResultPictureBox
            // 
            this.questionOneResultPictureBox.Location = new System.Drawing.Point(512, 34);
            this.questionOneResultPictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.questionOneResultPictureBox.Name = "questionOneResultPictureBox";
            this.questionOneResultPictureBox.Size = new System.Drawing.Size(32, 32);
            this.questionOneResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionOneResultPictureBox.TabIndex = 3;
            this.questionOneResultPictureBox.TabStop = false;
            // 
            // firstQuestionPictureBox
            // 
            this.firstQuestionPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstQuestionPictureBox.Location = new System.Drawing.Point(418, 7);
            this.firstQuestionPictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.firstQuestionPictureBox.Name = "firstQuestionPictureBox";
            this.firstQuestionPictureBox.Size = new System.Drawing.Size(87, 80);
            this.firstQuestionPictureBox.TabIndex = 2;
            this.firstQuestionPictureBox.TabStop = false;
            // 
            // firstQuestionLabel
            // 
            this.firstQuestionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstQuestionLabel.Location = new System.Drawing.Point(2, 2);
            this.firstQuestionLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.firstQuestionLabel.Name = "firstQuestionLabel";
            this.firstQuestionLabel.Size = new System.Drawing.Size(363, 69);
            this.firstQuestionLabel.TabIndex = 1;
            this.firstQuestionLabel.Text = "first Q text";
            this.firstQuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstQuestionThirdOptionRadioButton
            // 
            this.firstQuestionThirdOptionRadioButton.AutoSize = true;
            this.firstQuestionThirdOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstQuestionThirdOptionRadioButton.Location = new System.Drawing.Point(295, 79);
            this.firstQuestionThirdOptionRadioButton.Margin = new System.Windows.Forms.Padding(1);
            this.firstQuestionThirdOptionRadioButton.Name = "firstQuestionThirdOptionRadioButton";
            this.firstQuestionThirdOptionRadioButton.Size = new System.Drawing.Size(124, 28);
            this.firstQuestionThirdOptionRadioButton.TabIndex = 0;
            this.firstQuestionThirdOptionRadioButton.TabStop = true;
            this.firstQuestionThirdOptionRadioButton.Text = "radioButton1";
            this.firstQuestionThirdOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstQuestionSecondOptionRadioButton
            // 
            this.firstQuestionSecondOptionRadioButton.AutoSize = true;
            this.firstQuestionSecondOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstQuestionSecondOptionRadioButton.Location = new System.Drawing.Point(151, 79);
            this.firstQuestionSecondOptionRadioButton.Margin = new System.Windows.Forms.Padding(1);
            this.firstQuestionSecondOptionRadioButton.Name = "firstQuestionSecondOptionRadioButton";
            this.firstQuestionSecondOptionRadioButton.Size = new System.Drawing.Size(124, 28);
            this.firstQuestionSecondOptionRadioButton.TabIndex = 0;
            this.firstQuestionSecondOptionRadioButton.TabStop = true;
            this.firstQuestionSecondOptionRadioButton.Text = "radioButton1";
            this.firstQuestionSecondOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstQuestionFirstOptionRadioButton
            // 
            this.firstQuestionFirstOptionRadioButton.AutoSize = true;
            this.firstQuestionFirstOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstQuestionFirstOptionRadioButton.Location = new System.Drawing.Point(7, 79);
            this.firstQuestionFirstOptionRadioButton.Margin = new System.Windows.Forms.Padding(1);
            this.firstQuestionFirstOptionRadioButton.Name = "firstQuestionFirstOptionRadioButton";
            this.firstQuestionFirstOptionRadioButton.Size = new System.Drawing.Size(124, 28);
            this.firstQuestionFirstOptionRadioButton.TabIndex = 0;
            this.firstQuestionFirstOptionRadioButton.TabStop = true;
            this.firstQuestionFirstOptionRadioButton.Text = "radioButton1";
            this.firstQuestionFirstOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondQuestionPanel
            // 
            this.secondQuestionPanel.BackColor = System.Drawing.Color.White;
            this.secondQuestionPanel.Controls.Add(this.questionTwoResultPictureBox);
            this.secondQuestionPanel.Controls.Add(this.secondQuestionLabel);
            this.secondQuestionPanel.Controls.Add(this.secondQuestionThirdOptionRadioButton);
            this.secondQuestionPanel.Controls.Add(this.secondQuestionSecondOptionRadioButton);
            this.secondQuestionPanel.Controls.Add(this.secondQuestionFirstOptionRadioButton);
            this.secondQuestionPanel.Location = new System.Drawing.Point(25, 174);
            this.secondQuestionPanel.Margin = new System.Windows.Forms.Padding(1);
            this.secondQuestionPanel.Name = "secondQuestionPanel";
            this.secondQuestionPanel.Size = new System.Drawing.Size(566, 107);
            this.secondQuestionPanel.TabIndex = 48;
            // 
            // questionTwoResultPictureBox
            // 
            this.questionTwoResultPictureBox.Location = new System.Drawing.Point(512, 35);
            this.questionTwoResultPictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.questionTwoResultPictureBox.Name = "questionTwoResultPictureBox";
            this.questionTwoResultPictureBox.Size = new System.Drawing.Size(32, 32);
            this.questionTwoResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionTwoResultPictureBox.TabIndex = 3;
            this.questionTwoResultPictureBox.TabStop = false;
            // 
            // secondQuestionLabel
            // 
            this.secondQuestionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondQuestionLabel.Location = new System.Drawing.Point(3, 4);
            this.secondQuestionLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.secondQuestionLabel.Name = "secondQuestionLabel";
            this.secondQuestionLabel.Size = new System.Drawing.Size(362, 66);
            this.secondQuestionLabel.TabIndex = 2;
            this.secondQuestionLabel.Text = "second Q text";
            this.secondQuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondQuestionThirdOptionRadioButton
            // 
            this.secondQuestionThirdOptionRadioButton.AutoSize = true;
            this.secondQuestionThirdOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondQuestionThirdOptionRadioButton.Location = new System.Drawing.Point(295, 77);
            this.secondQuestionThirdOptionRadioButton.Margin = new System.Windows.Forms.Padding(1);
            this.secondQuestionThirdOptionRadioButton.Name = "secondQuestionThirdOptionRadioButton";
            this.secondQuestionThirdOptionRadioButton.Size = new System.Drawing.Size(124, 28);
            this.secondQuestionThirdOptionRadioButton.TabIndex = 1;
            this.secondQuestionThirdOptionRadioButton.TabStop = true;
            this.secondQuestionThirdOptionRadioButton.Text = "radioButton1";
            this.secondQuestionThirdOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondQuestionSecondOptionRadioButton
            // 
            this.secondQuestionSecondOptionRadioButton.AutoSize = true;
            this.secondQuestionSecondOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondQuestionSecondOptionRadioButton.Location = new System.Drawing.Point(151, 77);
            this.secondQuestionSecondOptionRadioButton.Margin = new System.Windows.Forms.Padding(1);
            this.secondQuestionSecondOptionRadioButton.Name = "secondQuestionSecondOptionRadioButton";
            this.secondQuestionSecondOptionRadioButton.Size = new System.Drawing.Size(124, 28);
            this.secondQuestionSecondOptionRadioButton.TabIndex = 2;
            this.secondQuestionSecondOptionRadioButton.TabStop = true;
            this.secondQuestionSecondOptionRadioButton.Text = "radioButton1";
            this.secondQuestionSecondOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondQuestionFirstOptionRadioButton
            // 
            this.secondQuestionFirstOptionRadioButton.AutoSize = true;
            this.secondQuestionFirstOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondQuestionFirstOptionRadioButton.Location = new System.Drawing.Point(6, 77);
            this.secondQuestionFirstOptionRadioButton.Margin = new System.Windows.Forms.Padding(1);
            this.secondQuestionFirstOptionRadioButton.Name = "secondQuestionFirstOptionRadioButton";
            this.secondQuestionFirstOptionRadioButton.Size = new System.Drawing.Size(124, 28);
            this.secondQuestionFirstOptionRadioButton.TabIndex = 3;
            this.secondQuestionFirstOptionRadioButton.TabStop = true;
            this.secondQuestionFirstOptionRadioButton.Text = "radioButton6";
            this.secondQuestionFirstOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // thirdQuestionPanel
            // 
            this.thirdQuestionPanel.BackColor = System.Drawing.Color.White;
            this.thirdQuestionPanel.Controls.Add(this.questionThreeResultPictureBox);
            this.thirdQuestionPanel.Controls.Add(this.thirdQuestionLabel);
            this.thirdQuestionPanel.Controls.Add(this.thirdQuestionThirdOptionRadioButton);
            this.thirdQuestionPanel.Controls.Add(this.thirdQuestionSecondOptionRadioButton);
            this.thirdQuestionPanel.Controls.Add(this.thirdQuestionFirstOptionRadioButton);
            this.thirdQuestionPanel.Location = new System.Drawing.Point(25, 291);
            this.thirdQuestionPanel.Margin = new System.Windows.Forms.Padding(1);
            this.thirdQuestionPanel.Name = "thirdQuestionPanel";
            this.thirdQuestionPanel.Size = new System.Drawing.Size(566, 107);
            this.thirdQuestionPanel.TabIndex = 49;
            // 
            // questionThreeResultPictureBox
            // 
            this.questionThreeResultPictureBox.Location = new System.Drawing.Point(512, 41);
            this.questionThreeResultPictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.questionThreeResultPictureBox.Name = "questionThreeResultPictureBox";
            this.questionThreeResultPictureBox.Size = new System.Drawing.Size(32, 32);
            this.questionThreeResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionThreeResultPictureBox.TabIndex = 3;
            this.questionThreeResultPictureBox.TabStop = false;
            // 
            // thirdQuestionLabel
            // 
            this.thirdQuestionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdQuestionLabel.Location = new System.Drawing.Point(1, -1);
            this.thirdQuestionLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.thirdQuestionLabel.Name = "thirdQuestionLabel";
            this.thirdQuestionLabel.Size = new System.Drawing.Size(383, 74);
            this.thirdQuestionLabel.TabIndex = 4;
            this.thirdQuestionLabel.Text = "third Q text";
            this.thirdQuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirdQuestionThirdOptionRadioButton
            // 
            this.thirdQuestionThirdOptionRadioButton.AutoSize = true;
            this.thirdQuestionThirdOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdQuestionThirdOptionRadioButton.Location = new System.Drawing.Point(295, 78);
            this.thirdQuestionThirdOptionRadioButton.Margin = new System.Windows.Forms.Padding(1);
            this.thirdQuestionThirdOptionRadioButton.Name = "thirdQuestionThirdOptionRadioButton";
            this.thirdQuestionThirdOptionRadioButton.Size = new System.Drawing.Size(124, 28);
            this.thirdQuestionThirdOptionRadioButton.TabIndex = 1;
            this.thirdQuestionThirdOptionRadioButton.TabStop = true;
            this.thirdQuestionThirdOptionRadioButton.Text = "radioButton1";
            this.thirdQuestionThirdOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // thirdQuestionSecondOptionRadioButton
            // 
            this.thirdQuestionSecondOptionRadioButton.AutoSize = true;
            this.thirdQuestionSecondOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdQuestionSecondOptionRadioButton.Location = new System.Drawing.Point(151, 78);
            this.thirdQuestionSecondOptionRadioButton.Margin = new System.Windows.Forms.Padding(1);
            this.thirdQuestionSecondOptionRadioButton.Name = "thirdQuestionSecondOptionRadioButton";
            this.thirdQuestionSecondOptionRadioButton.Size = new System.Drawing.Size(124, 28);
            this.thirdQuestionSecondOptionRadioButton.TabIndex = 2;
            this.thirdQuestionSecondOptionRadioButton.TabStop = true;
            this.thirdQuestionSecondOptionRadioButton.Text = "radioButton1";
            this.thirdQuestionSecondOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // thirdQuestionFirstOptionRadioButton
            // 
            this.thirdQuestionFirstOptionRadioButton.AutoSize = true;
            this.thirdQuestionFirstOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdQuestionFirstOptionRadioButton.Location = new System.Drawing.Point(7, 78);
            this.thirdQuestionFirstOptionRadioButton.Margin = new System.Windows.Forms.Padding(1);
            this.thirdQuestionFirstOptionRadioButton.Name = "thirdQuestionFirstOptionRadioButton";
            this.thirdQuestionFirstOptionRadioButton.Size = new System.Drawing.Size(124, 28);
            this.thirdQuestionFirstOptionRadioButton.TabIndex = 3;
            this.thirdQuestionFirstOptionRadioButton.TabStop = true;
            this.thirdQuestionFirstOptionRadioButton.Text = "radioButton9";
            this.thirdQuestionFirstOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePanel.Controls.Add(this.FriendsGameHeadlineLabel);
            this.gamePanel.Controls.Add(this.firstQuestionPanel);
            this.gamePanel.Controls.Add(this.playAgainButton);
            this.gamePanel.Controls.Add(this.checkGameResultsButton);
            this.gamePanel.Controls.Add(this.secondQuestionPanel);
            this.gamePanel.Controls.Add(this.thirdQuestionPanel);
            this.gamePanel.Location = new System.Drawing.Point(371, 30);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(1);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(620, 482);
            this.gamePanel.TabIndex = 51;
            this.gamePanel.Visible = false;
            // 
            // FriendsGameHeadlineLabel
            // 
            this.FriendsGameHeadlineLabel.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FriendsGameHeadlineLabel.Location = new System.Drawing.Point(129, 1);
            this.FriendsGameHeadlineLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.FriendsGameHeadlineLabel.Name = "FriendsGameHeadlineLabel";
            this.FriendsGameHeadlineLabel.Size = new System.Drawing.Size(345, 55);
            this.FriendsGameHeadlineLabel.TabIndex = 51;
            this.FriendsGameHeadlineLabel.Text = "How well do you know your friends? Answer the questions to find out!";
            this.FriendsGameHeadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.playAgainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playAgainButton.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.playAgainButton.Location = new System.Drawing.Point(321, 410);
            this.playAgainButton.Margin = new System.Windows.Forms.Padding(1);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(106, 59);
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
            this.checkGameResultsButton.Location = new System.Drawing.Point(157, 410);
            this.checkGameResultsButton.Margin = new System.Windows.Forms.Padding(1);
            this.checkGameResultsButton.Name = "checkGameResultsButton";
            this.checkGameResultsButton.Size = new System.Drawing.Size(106, 59);
            this.checkGameResultsButton.TabIndex = 50;
            this.checkGameResultsButton.Text = "Answer!";
            this.checkGameResultsButton.UseVisualStyleBackColor = false;
            this.checkGameResultsButton.Click += new System.EventHandler(this.checkGameResultsButton_Click);
            // 
            // eventsPanel
            // 
            this.eventsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eventsPanel.Controls.Add(this.eventsHeadlineLabel);
            this.eventsPanel.Controls.Add(this.eventsListBox);
            this.eventsPanel.Location = new System.Drawing.Point(407, 37);
            this.eventsPanel.Margin = new System.Windows.Forms.Padding(1);
            this.eventsPanel.Name = "eventsPanel";
            this.eventsPanel.Size = new System.Drawing.Size(536, 439);
            this.eventsPanel.TabIndex = 54;
            this.eventsPanel.Visible = false;
            // 
            // eventsHeadlineLabel
            // 
            this.eventsHeadlineLabel.Font = new System.Drawing.Font("Century Gothic", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsHeadlineLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.eventsHeadlineLabel.Location = new System.Drawing.Point(75, 37);
            this.eventsHeadlineLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.eventsHeadlineLabel.Name = "eventsHeadlineLabel";
            this.eventsHeadlineLabel.Size = new System.Drawing.Size(379, 51);
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
            this.postButton.Location = new System.Drawing.Point(3, 100);
            this.postButton.Margin = new System.Windows.Forms.Padding(1);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(186, 60);
            this.postButton.TabIndex = 3;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = false;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // upperLinePanel
            // 
            this.upperLinePanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.upperLinePanel.Controls.Add(this.closeButton);
            this.upperLinePanel.Location = new System.Drawing.Point(-1, 0);
            this.upperLinePanel.Margin = new System.Windows.Forms.Padding(1);
            this.upperLinePanel.Name = "upperLinePanel";
            this.upperLinePanel.Size = new System.Drawing.Size(994, 18);
            this.upperLinePanel.TabIndex = 52;
            // 
            // closeButton
            // 
            this.closeButton.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.x30;
            this.closeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(970, -1);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 18);
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
            this.optionsPanel.Location = new System.Drawing.Point(-1, 0);
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(1);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(193, 512);
            this.optionsPanel.TabIndex = 0;
            this.optionsPanel.Visible = false;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sidePanel.Location = new System.Drawing.Point(1, 38);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(1);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(9, 60);
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
            this.homeButton.Location = new System.Drawing.Point(3, 38);
            this.homeButton.Margin = new System.Windows.Forms.Padding(1);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(186, 60);
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
            this.friendsGameButton.Location = new System.Drawing.Point(3, 389);
            this.friendsGameButton.Margin = new System.Windows.Forms.Padding(1);
            this.friendsGameButton.Name = "friendsGameButton";
            this.friendsGameButton.Size = new System.Drawing.Size(186, 80);
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
            this.fansButton.Location = new System.Drawing.Point(3, 315);
            this.fansButton.Margin = new System.Windows.Forms.Padding(1);
            this.fansButton.Name = "fansButton";
            this.fansButton.Size = new System.Drawing.Size(186, 60);
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
            this.likedPagesButton.Location = new System.Drawing.Point(3, 242);
            this.likedPagesButton.Margin = new System.Windows.Forms.Padding(1);
            this.likedPagesButton.Name = "likedPagesButton";
            this.likedPagesButton.Size = new System.Drawing.Size(186, 60);
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
            this.upcomingEventsButton.Location = new System.Drawing.Point(3, 173);
            this.upcomingEventsButton.Margin = new System.Windows.Forms.Padding(1);
            this.upcomingEventsButton.Name = "upcomingEventsButton";
            this.upcomingEventsButton.Size = new System.Drawing.Size(186, 55);
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
            this.profilePicturePanel.Location = new System.Drawing.Point(198, 18);
            this.profilePicturePanel.Margin = new System.Windows.Forms.Padding(1);
            this.profilePicturePanel.Name = "profilePicturePanel";
            this.profilePicturePanel.Size = new System.Drawing.Size(153, 147);
            this.profilePicturePanel.TabIndex = 0;
            this.profilePicturePanel.Visible = false;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePictureBox.Location = new System.Drawing.Point(29, 0);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(94, 94);
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
            this.postPanel.Location = new System.Drawing.Point(387, 46);
            this.postPanel.Margin = new System.Windows.Forms.Padding(1);
            this.postPanel.Name = "postPanel";
            this.postPanel.Size = new System.Drawing.Size(546, 439);
            this.postPanel.TabIndex = 53;
            this.postPanel.Visible = false;
            // 
            // postHeadlineLabel
            // 
            this.postHeadlineLabel.Font = new System.Drawing.Font("Century Gothic", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postHeadlineLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.postHeadlineLabel.Location = new System.Drawing.Point(50, 32);
            this.postHeadlineLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.postHeadlineLabel.Name = "postHeadlineLabel";
            this.postHeadlineLabel.Size = new System.Drawing.Size(426, 51);
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
            this.likedPagesPanel.Location = new System.Drawing.Point(418, 30);
            this.likedPagesPanel.Margin = new System.Windows.Forms.Padding(1);
            this.likedPagesPanel.Name = "likedPagesPanel";
            this.likedPagesPanel.Size = new System.Drawing.Size(559, 463);
            this.likedPagesPanel.TabIndex = 55;
            this.likedPagesPanel.Visible = false;
            // 
            // likedPagesHeadlineLabel
            // 
            this.likedPagesHeadlineLabel.Font = new System.Drawing.Font("Century Gothic", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likedPagesHeadlineLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.likedPagesHeadlineLabel.Location = new System.Drawing.Point(80, 33);
            this.likedPagesHeadlineLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.likedPagesHeadlineLabel.Name = "likedPagesHeadlineLabel";
            this.likedPagesHeadlineLabel.Size = new System.Drawing.Size(379, 51);
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
            this.fansPanel.Location = new System.Drawing.Point(353, 20);
            this.fansPanel.Margin = new System.Windows.Forms.Padding(1);
            this.fansPanel.Name = "fansPanel";
            this.fansPanel.Size = new System.Drawing.Size(640, 492);
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
            this.fanDisplayPanel.Location = new System.Drawing.Point(340, 121);
            this.fanDisplayPanel.Name = "fanDisplayPanel";
            this.fanDisplayPanel.Size = new System.Drawing.Size(280, 277);
            this.fanDisplayPanel.TabIndex = 48;
            this.fanDisplayPanel.Visible = false;
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.fanBindingSource, "FanUser.Birthday", true));
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(70, 227);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.birthdayDateTimePicker.TabIndex = 12;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fanBindingSource, "FanUser.Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(116, 161);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 5;
            // 
            // imageNormalPictureBox
            // 
            this.imageNormalPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.fanBindingSource, "FanUser.ImageNormal", true));
            this.imageNormalPictureBox.Location = new System.Drawing.Point(30, 18);
            this.imageNormalPictureBox.Name = "imageNormalPictureBox";
            this.imageNormalPictureBox.Size = new System.Drawing.Size(100, 75);
            this.imageNormalPictureBox.TabIndex = 7;
            this.imageNormalPictureBox.TabStop = false;
            // 
            // linkLinkLabel
            // 
            this.linkLinkLabel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fanBindingSource, "FanUser.Link", true));
            this.linkLinkLabel.Location = new System.Drawing.Point(116, 196);
            this.linkLinkLabel.Name = "linkLinkLabel";
            this.linkLinkLabel.Size = new System.Drawing.Size(100, 23);
            this.linkLinkLabel.TabIndex = 9;
            this.linkLinkLabel.TabStop = true;
            this.linkLinkLabel.Text = "linkLabel1";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fanBindingSource, "FanUser.Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(116, 101);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 11;
            // 
            // numOfLikesTextBox
            // 
            this.numOfLikesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fanBindingSource, "NumOfLikes", true));
            this.numOfLikesTextBox.Location = new System.Drawing.Point(116, 127);
            this.numOfLikesTextBox.Name = "numOfLikesTextBox";
            this.numOfLikesTextBox.Size = new System.Drawing.Size(100, 20);
            this.numOfLikesTextBox.TabIndex = 1;
            // 
            // fansSecondHeadlineLabel
            // 
            this.fansSecondHeadlineLabel.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fansSecondHeadlineLabel.Location = new System.Drawing.Point(31, 65);
            this.fansSecondHeadlineLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.fansSecondHeadlineLabel.Name = "fansSecondHeadlineLabel";
            this.fansSecondHeadlineLabel.Size = new System.Drawing.Size(505, 33);
            this.fansSecondHeadlineLabel.TabIndex = 47;
            this.fansSecondHeadlineLabel.Text = "Here are the friends who liked your pictures the most";
            // 
            // fansHeadlineLabel
            // 
            this.fansHeadlineLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fansHeadlineLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.fansHeadlineLabel.Location = new System.Drawing.Point(77, 17);
            this.fansHeadlineLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.fansHeadlineLabel.Name = "fansHeadlineLabel";
            this.fansHeadlineLabel.Size = new System.Drawing.Size(413, 46);
            this.fansHeadlineLabel.TabIndex = 12;
            this.fansHeadlineLabel.Text = "Find out your secert fans!  ";
            this.fansHeadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // loginPanel
            // 
            this.loginPanel.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.facebookBG;
            this.loginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Location = new System.Drawing.Point(-1, 0);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(1);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(991, 511);
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
            this.loginButton.Location = new System.Drawing.Point(389, 227);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(227, 69);
            this.loginButton.TabIndex = 0;
            this.loginButton.TabStop = false;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 494);
            this.Controls.Add(this.fansPanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.eventsPanel);
            this.Controls.Add(this.postPanel);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.profilePicturePanel);
            this.Controls.Add(this.upperLinePanel);
            this.Controls.Add(this.likedPagesPanel);
            this.Controls.Add(this.loginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook APP";
            ((System.ComponentModel.ISupportInitialize)(this.fanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.firstQuestionPanel.ResumeLayout(false);
            this.firstQuestionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionOneResultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstQuestionPictureBox)).EndInit();
            this.secondQuestionPanel.ResumeLayout(false);
            this.secondQuestionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionTwoResultPictureBox)).EndInit();
            this.thirdQuestionPanel.ResumeLayout(false);
            this.thirdQuestionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionThreeResultPictureBox)).EndInit();
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
        private Panel firstQuestionPanel;
        private Panel secondQuestionPanel;
        private Panel thirdQuestionPanel;
        private Label firstQuestionLabel;
        private RadioButton firstQuestionThirdOptionRadioButton;
        private RadioButton firstQuestionSecondOptionRadioButton;
        private RadioButton firstQuestionFirstOptionRadioButton;
        private Label secondQuestionLabel;
        private RadioButton secondQuestionThirdOptionRadioButton;
        private RadioButton secondQuestionSecondOptionRadioButton;
        private RadioButton secondQuestionFirstOptionRadioButton;
        private RadioButton thirdQuestionThirdOptionRadioButton;
        private RadioButton thirdQuestionSecondOptionRadioButton;
        private RadioButton thirdQuestionFirstOptionRadioButton;
        private PictureBox firstQuestionPictureBox;
        private Label thirdQuestionLabel;
        private RoundedButton checkGameResultsButton;
        private Panel gamePanel;
        private PictureBox questionOneResultPictureBox;
        private PictureBox questionTwoResultPictureBox;
        private PictureBox questionThreeResultPictureBox;
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
    }
}