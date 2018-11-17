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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.likePagedListBox = new System.Windows.Forms.ListBox();
            this.fansListBox = new System.Windows.Forms.ListBox();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.firstQuestionPanel = new System.Windows.Forms.Panel();
            this.firstQuestionLabel = new System.Windows.Forms.Label();
            this.firstQuestionThirdOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.firstQuestionSecondOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.firstQuestionFirstOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.secondQuestionPanel = new System.Windows.Forms.Panel();
            this.secondQuestionLabel = new System.Windows.Forms.Label();
            this.secondQuestionThirdOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.secondQuestionSecondOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.secondQuestionFirstOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.thirdQuestionPanel = new System.Windows.Forms.Panel();
            this.thirdQuestionLabel = new System.Windows.Forms.Label();
            this.thirdQuestionThirdOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.thirdQuestionSecondOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.thirdQuestionFirstOptionRadioButton = new System.Windows.Forms.RadioButton();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.eventsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.postButton = new System.Windows.Forms.Button();
            this.upperLinePanel = new System.Windows.Forms.Panel();
            this.optionsPanel = new System.Windows.Forms.Panel();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.homeButton = new System.Windows.Forms.Button();
            this.friendsGameButton = new System.Windows.Forms.Button();
            this.fansButton = new System.Windows.Forms.Button();
            this.likedPagesButton = new System.Windows.Forms.Button();
            this.upcomingEventsButton = new System.Windows.Forms.Button();
            this.profilePicturePanel = new System.Windows.Forms.Panel();
            this.postPanel = new System.Windows.Forms.Panel();
            this.postHeadlineLabel = new System.Windows.Forms.Label();
            this.likedPagesPanel = new System.Windows.Forms.Panel();
            this.eventsHeadlineLabel = new System.Windows.Forms.Label();
            this.fansPanel = new System.Windows.Forms.Panel();
            this.fansSecondHeadlineLabel = new System.Windows.Forms.Label();
            this.fansHeadlineLabel = new System.Windows.Forms.Label();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.questionOneResultPictureBox = new System.Windows.Forms.PictureBox();
            this.firstQuestionPictureBox = new System.Windows.Forms.PictureBox();
            this.questionTwoResultPictureBox = new System.Windows.Forms.PictureBox();
            this.questionThreeResultPictureBox = new System.Windows.Forms.PictureBox();
            this.loginButton = new DesktopFacebookAPP.RoundedEdgeButton();
            this.sendPostButton = new DesktopFacebookAPP.RoundedEdgeButton();
            this.cancelPostButton = new DesktopFacebookAPP.RoundedEdgeButton();
            this.playAgainButton = new DesktopFacebookAPP.RoundButton();
            this.checkGameResultsButton = new DesktopFacebookAPP.RoundButton();
            this.firstQuestionPanel.SuspendLayout();
            this.secondQuestionPanel.SuspendLayout();
            this.thirdQuestionPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.eventsPanel.SuspendLayout();
            this.optionsPanel.SuspendLayout();
            this.profilePicturePanel.SuspendLayout();
            this.postPanel.SuspendLayout();
            this.likedPagesPanel.SuspendLayout();
            this.fansPanel.SuspendLayout();
            this.loginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionOneResultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstQuestionPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionTwoResultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionThreeResultPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(1, 178);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(265, 71);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome !!!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click_1);
            // 
            // postTextBox
            // 
            this.postTextBox.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postTextBox.Location = new System.Drawing.Point(75, 187);
            this.postTextBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.postTextBox.Multiline = true;
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(822, 361);
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
            this.eventsListBox.Location = new System.Drawing.Point(66, 176);
            this.eventsListBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(803, 460);
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
            this.likePagedListBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.likePagedListBox.Name = "likePagedListBox";
            this.likePagedListBox.Size = new System.Drawing.Size(822, 514);
            this.likePagedListBox.TabIndex = 42;
            // 
            // fansListBox
            // 
            this.fansListBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fansListBox.FormattingEnabled = true;
            this.fansListBox.ItemHeight = 34;
            this.fansListBox.Location = new System.Drawing.Point(61, 293);
            this.fansListBox.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.fansListBox.Name = "fansListBox";
            this.fansListBox.Size = new System.Drawing.Size(869, 446);
            this.fansListBox.TabIndex = 43;
            // 
            // loadingLabel
            // 
            this.loadingLabel.Font = new System.Drawing.Font("Century Gothic", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.Location = new System.Drawing.Point(218, 472);
            this.loadingLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(550, 83);
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
            this.firstQuestionPanel.Location = new System.Drawing.Point(44, 98);
            this.firstQuestionPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.firstQuestionPanel.Name = "firstQuestionPanel";
            this.firstQuestionPanel.Size = new System.Drawing.Size(991, 188);
            this.firstQuestionPanel.TabIndex = 47;
            // 
            // firstQuestionLabel
            // 
            this.firstQuestionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstQuestionLabel.Location = new System.Drawing.Point(3, 3);
            this.firstQuestionLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.firstQuestionLabel.Name = "firstQuestionLabel";
            this.firstQuestionLabel.Size = new System.Drawing.Size(636, 120);
            this.firstQuestionLabel.TabIndex = 1;
            this.firstQuestionLabel.Text = "first Q text";
            this.firstQuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstQuestionThirdOptionRadioButton
            // 
            this.firstQuestionThirdOptionRadioButton.AutoSize = true;
            this.firstQuestionThirdOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstQuestionThirdOptionRadioButton.Location = new System.Drawing.Point(517, 138);
            this.firstQuestionThirdOptionRadioButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.firstQuestionThirdOptionRadioButton.Name = "firstQuestionThirdOptionRadioButton";
            this.firstQuestionThirdOptionRadioButton.Size = new System.Drawing.Size(209, 47);
            this.firstQuestionThirdOptionRadioButton.TabIndex = 0;
            this.firstQuestionThirdOptionRadioButton.TabStop = true;
            this.firstQuestionThirdOptionRadioButton.Text = "radioButton1";
            this.firstQuestionThirdOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstQuestionSecondOptionRadioButton
            // 
            this.firstQuestionSecondOptionRadioButton.AutoSize = true;
            this.firstQuestionSecondOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstQuestionSecondOptionRadioButton.Location = new System.Drawing.Point(265, 138);
            this.firstQuestionSecondOptionRadioButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.firstQuestionSecondOptionRadioButton.Name = "firstQuestionSecondOptionRadioButton";
            this.firstQuestionSecondOptionRadioButton.Size = new System.Drawing.Size(209, 47);
            this.firstQuestionSecondOptionRadioButton.TabIndex = 0;
            this.firstQuestionSecondOptionRadioButton.TabStop = true;
            this.firstQuestionSecondOptionRadioButton.Text = "radioButton1";
            this.firstQuestionSecondOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstQuestionFirstOptionRadioButton
            // 
            this.firstQuestionFirstOptionRadioButton.AutoSize = true;
            this.firstQuestionFirstOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstQuestionFirstOptionRadioButton.Location = new System.Drawing.Point(13, 138);
            this.firstQuestionFirstOptionRadioButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.firstQuestionFirstOptionRadioButton.Name = "firstQuestionFirstOptionRadioButton";
            this.firstQuestionFirstOptionRadioButton.Size = new System.Drawing.Size(209, 47);
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
            this.secondQuestionPanel.Location = new System.Drawing.Point(44, 304);
            this.secondQuestionPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.secondQuestionPanel.Name = "secondQuestionPanel";
            this.secondQuestionPanel.Size = new System.Drawing.Size(991, 188);
            this.secondQuestionPanel.TabIndex = 48;
            // 
            // secondQuestionLabel
            // 
            this.secondQuestionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondQuestionLabel.Location = new System.Drawing.Point(6, 7);
            this.secondQuestionLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.secondQuestionLabel.Name = "secondQuestionLabel";
            this.secondQuestionLabel.Size = new System.Drawing.Size(634, 116);
            this.secondQuestionLabel.TabIndex = 2;
            this.secondQuestionLabel.Text = "second Q text";
            this.secondQuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // secondQuestionThirdOptionRadioButton
            // 
            this.secondQuestionThirdOptionRadioButton.AutoSize = true;
            this.secondQuestionThirdOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondQuestionThirdOptionRadioButton.Location = new System.Drawing.Point(517, 134);
            this.secondQuestionThirdOptionRadioButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.secondQuestionThirdOptionRadioButton.Name = "secondQuestionThirdOptionRadioButton";
            this.secondQuestionThirdOptionRadioButton.Size = new System.Drawing.Size(209, 47);
            this.secondQuestionThirdOptionRadioButton.TabIndex = 1;
            this.secondQuestionThirdOptionRadioButton.TabStop = true;
            this.secondQuestionThirdOptionRadioButton.Text = "radioButton1";
            this.secondQuestionThirdOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondQuestionSecondOptionRadioButton
            // 
            this.secondQuestionSecondOptionRadioButton.AutoSize = true;
            this.secondQuestionSecondOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondQuestionSecondOptionRadioButton.Location = new System.Drawing.Point(264, 134);
            this.secondQuestionSecondOptionRadioButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.secondQuestionSecondOptionRadioButton.Name = "secondQuestionSecondOptionRadioButton";
            this.secondQuestionSecondOptionRadioButton.Size = new System.Drawing.Size(209, 47);
            this.secondQuestionSecondOptionRadioButton.TabIndex = 2;
            this.secondQuestionSecondOptionRadioButton.TabStop = true;
            this.secondQuestionSecondOptionRadioButton.Text = "radioButton1";
            this.secondQuestionSecondOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondQuestionFirstOptionRadioButton
            // 
            this.secondQuestionFirstOptionRadioButton.AutoSize = true;
            this.secondQuestionFirstOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondQuestionFirstOptionRadioButton.Location = new System.Drawing.Point(11, 134);
            this.secondQuestionFirstOptionRadioButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.secondQuestionFirstOptionRadioButton.Name = "secondQuestionFirstOptionRadioButton";
            this.secondQuestionFirstOptionRadioButton.Size = new System.Drawing.Size(209, 47);
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
            this.thirdQuestionPanel.Location = new System.Drawing.Point(44, 510);
            this.thirdQuestionPanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.thirdQuestionPanel.Name = "thirdQuestionPanel";
            this.thirdQuestionPanel.Size = new System.Drawing.Size(991, 188);
            this.thirdQuestionPanel.TabIndex = 49;
            // 
            // thirdQuestionLabel
            // 
            this.thirdQuestionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdQuestionLabel.Location = new System.Drawing.Point(1, -1);
            this.thirdQuestionLabel.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.thirdQuestionLabel.Name = "thirdQuestionLabel";
            this.thirdQuestionLabel.Size = new System.Drawing.Size(670, 129);
            this.thirdQuestionLabel.TabIndex = 4;
            this.thirdQuestionLabel.Text = "third Q text";
            this.thirdQuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // thirdQuestionThirdOptionRadioButton
            // 
            this.thirdQuestionThirdOptionRadioButton.AutoSize = true;
            this.thirdQuestionThirdOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdQuestionThirdOptionRadioButton.Location = new System.Drawing.Point(517, 137);
            this.thirdQuestionThirdOptionRadioButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.thirdQuestionThirdOptionRadioButton.Name = "thirdQuestionThirdOptionRadioButton";
            this.thirdQuestionThirdOptionRadioButton.Size = new System.Drawing.Size(209, 47);
            this.thirdQuestionThirdOptionRadioButton.TabIndex = 1;
            this.thirdQuestionThirdOptionRadioButton.TabStop = true;
            this.thirdQuestionThirdOptionRadioButton.Text = "radioButton1";
            this.thirdQuestionThirdOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // thirdQuestionSecondOptionRadioButton
            // 
            this.thirdQuestionSecondOptionRadioButton.AutoSize = true;
            this.thirdQuestionSecondOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdQuestionSecondOptionRadioButton.Location = new System.Drawing.Point(265, 137);
            this.thirdQuestionSecondOptionRadioButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.thirdQuestionSecondOptionRadioButton.Name = "thirdQuestionSecondOptionRadioButton";
            this.thirdQuestionSecondOptionRadioButton.Size = new System.Drawing.Size(209, 47);
            this.thirdQuestionSecondOptionRadioButton.TabIndex = 2;
            this.thirdQuestionSecondOptionRadioButton.TabStop = true;
            this.thirdQuestionSecondOptionRadioButton.Text = "radioButton1";
            this.thirdQuestionSecondOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // thirdQuestionFirstOptionRadioButton
            // 
            this.thirdQuestionFirstOptionRadioButton.AutoSize = true;
            this.thirdQuestionFirstOptionRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdQuestionFirstOptionRadioButton.Location = new System.Drawing.Point(13, 137);
            this.thirdQuestionFirstOptionRadioButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.thirdQuestionFirstOptionRadioButton.Name = "thirdQuestionFirstOptionRadioButton";
            this.thirdQuestionFirstOptionRadioButton.Size = new System.Drawing.Size(209, 47);
            this.thirdQuestionFirstOptionRadioButton.TabIndex = 3;
            this.thirdQuestionFirstOptionRadioButton.TabStop = true;
            this.thirdQuestionFirstOptionRadioButton.Text = "radioButton9";
            this.thirdQuestionFirstOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gamePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gamePanel.Controls.Add(this.label2);
            this.gamePanel.Controls.Add(this.firstQuestionPanel);
            this.gamePanel.Controls.Add(this.playAgainButton);
            this.gamePanel.Controls.Add(this.checkGameResultsButton);
            this.gamePanel.Controls.Add(this.secondQuestionPanel);
            this.gamePanel.Controls.Add(this.thirdQuestionPanel);
            this.gamePanel.Location = new System.Drawing.Point(650, 52);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(1084, 837);
            this.gamePanel.TabIndex = 51;
            this.gamePanel.Visible = false;
            this.gamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.gamePanel_Paint);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(226, 1);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(604, 96);
            this.label2.TabIndex = 51;
            this.label2.Text = "How well do you know your friends? Answer the questions to find out!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // eventsPanel
            // 
            this.eventsPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.eventsPanel.Controls.Add(this.label1);
            this.eventsPanel.Controls.Add(this.eventsListBox);
            this.eventsPanel.Location = new System.Drawing.Point(712, 64);
            this.eventsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.eventsPanel.Name = "eventsPanel";
            this.eventsPanel.Size = new System.Drawing.Size(938, 769);
            this.eventsPanel.TabIndex = 54;
            this.eventsPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.label1.Location = new System.Drawing.Point(140, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 90);
            this.label1.TabIndex = 12;
            this.label1.Text = "Here are your upcoming events, Stay tuned!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.postButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(325, 105);
            this.postButton.TabIndex = 3;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = false;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            // 
            // upperLinePanel
            // 
            this.upperLinePanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.upperLinePanel.Location = new System.Drawing.Point(-1, 0);
            this.upperLinePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.upperLinePanel.Name = "upperLinePanel";
            this.upperLinePanel.Size = new System.Drawing.Size(1739, 31);
            this.upperLinePanel.TabIndex = 52;
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
            this.optionsPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.optionsPanel.Name = "optionsPanel";
            this.optionsPanel.Size = new System.Drawing.Size(337, 897);
            this.optionsPanel.TabIndex = 0;
            this.optionsPanel.Visible = false;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.sidePanel.Location = new System.Drawing.Point(2, 67);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.homeButton.Location = new System.Drawing.Point(5, 67);
            this.homeButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(325, 105);
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
            this.friendsGameButton.Location = new System.Drawing.Point(5, 680);
            this.friendsGameButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.friendsGameButton.Name = "friendsGameButton";
            this.friendsGameButton.Size = new System.Drawing.Size(325, 140);
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
            this.fansButton.Location = new System.Drawing.Point(5, 552);
            this.fansButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.fansButton.Name = "fansButton";
            this.fansButton.Size = new System.Drawing.Size(325, 105);
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
            this.likedPagesButton.Location = new System.Drawing.Point(5, 423);
            this.likedPagesButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.likedPagesButton.Name = "likedPagesButton";
            this.likedPagesButton.Size = new System.Drawing.Size(325, 105);
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
            this.upcomingEventsButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.upcomingEventsButton.Name = "upcomingEventsButton";
            this.upcomingEventsButton.Size = new System.Drawing.Size(325, 97);
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
            this.profilePicturePanel.Location = new System.Drawing.Point(346, 31);
            this.profilePicturePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profilePicturePanel.Name = "profilePicturePanel";
            this.profilePicturePanel.Size = new System.Drawing.Size(268, 257);
            this.profilePicturePanel.TabIndex = 0;
            this.profilePicturePanel.Visible = false;
            // 
            // postPanel
            // 
            this.postPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.postPanel.Controls.Add(this.postHeadlineLabel);
            this.postPanel.Controls.Add(this.sendPostButton);
            this.postPanel.Controls.Add(this.cancelPostButton);
            this.postPanel.Controls.Add(this.postTextBox);
            this.postPanel.Location = new System.Drawing.Point(678, 80);
            this.postPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.postPanel.Name = "postPanel";
            this.postPanel.Size = new System.Drawing.Size(955, 769);
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
            this.postHeadlineLabel.Size = new System.Drawing.Size(746, 90);
            this.postHeadlineLabel.TabIndex = 12;
            this.postHeadlineLabel.Text = "What\'s on your mind?";
            this.postHeadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // likedPagesPanel
            // 
            this.likedPagesPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.likedPagesPanel.Controls.Add(this.eventsHeadlineLabel);
            this.likedPagesPanel.Controls.Add(this.likePagedListBox);
            this.likedPagesPanel.Location = new System.Drawing.Point(731, 52);
            this.likedPagesPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.likedPagesPanel.Name = "likedPagesPanel";
            this.likedPagesPanel.Size = new System.Drawing.Size(978, 810);
            this.likedPagesPanel.TabIndex = 55;
            this.likedPagesPanel.Visible = false;
            // 
            // eventsHeadlineLabel
            // 
            this.eventsHeadlineLabel.Font = new System.Drawing.Font("Century Gothic", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventsHeadlineLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.eventsHeadlineLabel.Location = new System.Drawing.Point(140, 58);
            this.eventsHeadlineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.eventsHeadlineLabel.Name = "eventsHeadlineLabel";
            this.eventsHeadlineLabel.Size = new System.Drawing.Size(663, 90);
            this.eventsHeadlineLabel.TabIndex = 12;
            this.eventsHeadlineLabel.Text = "Here are all the pages you liked!";
            this.eventsHeadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fansPanel
            // 
            this.fansPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.fansPanel.Controls.Add(this.loadingLabel);
            this.fansPanel.Controls.Add(this.fansSecondHeadlineLabel);
            this.fansPanel.Controls.Add(this.fansHeadlineLabel);
            this.fansPanel.Controls.Add(this.fansListBox);
            this.fansPanel.Location = new System.Drawing.Point(650, 106);
            this.fansPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fansPanel.Name = "fansPanel";
            this.fansPanel.Size = new System.Drawing.Size(1042, 756);
            this.fansPanel.TabIndex = 55;
            this.fansPanel.Visible = false;
            // 
            // fansSecondHeadlineLabel
            // 
            this.fansSecondHeadlineLabel.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fansSecondHeadlineLabel.Location = new System.Drawing.Point(54, 113);
            this.fansSecondHeadlineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fansSecondHeadlineLabel.Name = "fansSecondHeadlineLabel";
            this.fansSecondHeadlineLabel.Size = new System.Drawing.Size(883, 58);
            this.fansSecondHeadlineLabel.TabIndex = 47;
            this.fansSecondHeadlineLabel.Text = "Here are the friends who liked your pictures the most";
            // 
            // fansHeadlineLabel
            // 
            this.fansHeadlineLabel.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fansHeadlineLabel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.fansHeadlineLabel.Location = new System.Drawing.Point(134, 30);
            this.fansHeadlineLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fansHeadlineLabel.Name = "fansHeadlineLabel";
            this.fansHeadlineLabel.Size = new System.Drawing.Size(722, 80);
            this.fansHeadlineLabel.TabIndex = 12;
            this.fansHeadlineLabel.Text = "Find out your secert fans!  ";
            this.fansHeadlineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.fansHeadlineLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.facebookBG;
            this.loginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Location = new System.Drawing.Point(-1, 0);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(2);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(1737, 906);
            this.loginPanel.TabIndex = 0;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePictureBox.Location = new System.Drawing.Point(51, 0);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(164, 164);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            // 
            // questionOneResultPictureBox
            // 
            this.questionOneResultPictureBox.Location = new System.Drawing.Point(896, 59);
            this.questionOneResultPictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.questionOneResultPictureBox.Name = "questionOneResultPictureBox";
            this.questionOneResultPictureBox.Size = new System.Drawing.Size(56, 56);
            this.questionOneResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionOneResultPictureBox.TabIndex = 3;
            this.questionOneResultPictureBox.TabStop = false;
            // 
            // firstQuestionPictureBox
            // 
            this.firstQuestionPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstQuestionPictureBox.Location = new System.Drawing.Point(731, 13);
            this.firstQuestionPictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.firstQuestionPictureBox.Name = "firstQuestionPictureBox";
            this.firstQuestionPictureBox.Size = new System.Drawing.Size(150, 139);
            this.firstQuestionPictureBox.TabIndex = 2;
            this.firstQuestionPictureBox.TabStop = false;
            // 
            // questionTwoResultPictureBox
            // 
            this.questionTwoResultPictureBox.Location = new System.Drawing.Point(896, 61);
            this.questionTwoResultPictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.questionTwoResultPictureBox.Name = "questionTwoResultPictureBox";
            this.questionTwoResultPictureBox.Size = new System.Drawing.Size(56, 56);
            this.questionTwoResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionTwoResultPictureBox.TabIndex = 3;
            this.questionTwoResultPictureBox.TabStop = false;
            // 
            // questionThreeResultPictureBox
            // 
            this.questionThreeResultPictureBox.Location = new System.Drawing.Point(896, 72);
            this.questionThreeResultPictureBox.Margin = new System.Windows.Forms.Padding(1);
            this.questionThreeResultPictureBox.Name = "questionThreeResultPictureBox";
            this.questionThreeResultPictureBox.Size = new System.Drawing.Size(56, 56);
            this.questionThreeResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionThreeResultPictureBox.TabIndex = 3;
            this.questionThreeResultPictureBox.TabStop = false;
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
            this.loginButton.Location = new System.Drawing.Point(680, 397);
            this.loginButton.Margin = new System.Windows.Forms.Padding(6);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(398, 121);
            this.loginButton.TabIndex = 0;
            this.loginButton.TabStop = false;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // sendPostButton
            // 
            this.sendPostButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.sendPostButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendPostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendPostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendPostButton.Font = new System.Drawing.Font("Century Gothic", 14.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendPostButton.Location = new System.Drawing.Point(156, 601);
            this.sendPostButton.Margin = new System.Windows.Forms.Padding(6);
            this.sendPostButton.Name = "sendPostButton";
            this.sendPostButton.Size = new System.Drawing.Size(269, 115);
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
            this.cancelPostButton.Location = new System.Drawing.Point(516, 601);
            this.cancelPostButton.Margin = new System.Windows.Forms.Padding(6);
            this.cancelPostButton.Name = "cancelPostButton";
            this.cancelPostButton.Size = new System.Drawing.Size(269, 115);
            this.cancelPostButton.TabIndex = 11;
            this.cancelPostButton.Text = "Cancel";
            this.cancelPostButton.UseVisualStyleBackColor = false;
            this.cancelPostButton.Click += new System.EventHandler(this.cancelPostButton_Click);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.LightSteelBlue;
            this.playAgainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playAgainButton.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.playAgainButton.Location = new System.Drawing.Point(562, 718);
            this.playAgainButton.Margin = new System.Windows.Forms.Padding(1);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(185, 104);
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
            this.checkGameResultsButton.Location = new System.Drawing.Point(274, 718);
            this.checkGameResultsButton.Margin = new System.Windows.Forms.Padding(1);
            this.checkGameResultsButton.Name = "checkGameResultsButton";
            this.checkGameResultsButton.Size = new System.Drawing.Size(185, 104);
            this.checkGameResultsButton.TabIndex = 50;
            this.checkGameResultsButton.Text = "Answer!";
            this.checkGameResultsButton.UseVisualStyleBackColor = false;
            this.checkGameResultsButton.Click += new System.EventHandler(this.checkGameResultsButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1732, 897);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.eventsPanel);
            this.Controls.Add(this.postPanel);
            this.Controls.Add(this.fansPanel);
            this.Controls.Add(this.optionsPanel);
            this.Controls.Add(this.profilePicturePanel);
            this.Controls.Add(this.upperLinePanel);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.likedPagesPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook APP";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.firstQuestionPanel.ResumeLayout(false);
            this.firstQuestionPanel.PerformLayout();
            this.secondQuestionPanel.ResumeLayout(false);
            this.secondQuestionPanel.PerformLayout();
            this.thirdQuestionPanel.ResumeLayout(false);
            this.thirdQuestionPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.eventsPanel.ResumeLayout(false);
            this.optionsPanel.ResumeLayout(false);
            this.profilePicturePanel.ResumeLayout(false);
            this.postPanel.ResumeLayout(false);
            this.postPanel.PerformLayout();
            this.likedPagesPanel.ResumeLayout(false);
            this.fansPanel.ResumeLayout(false);
            this.loginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionOneResultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstQuestionPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionTwoResultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionThreeResultPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RoundedEdgeButton loginButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label welcomeLabel;
        private Button postButton;
        private Button upcomingEventsButton;
        private Button likedPagesButton;
        private Button fansButton;
        private Button friendsGameButton;
        private TextBox postTextBox;
        private RoundedEdgeButton sendPostButton;
        private RoundedEdgeButton cancelPostButton;
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
        private RoundButton checkGameResultsButton;
        private Panel gamePanel;
        private PictureBox questionOneResultPictureBox;
        private PictureBox questionTwoResultPictureBox;
        private PictureBox questionThreeResultPictureBox;
        private RoundButton playAgainButton;
        private Panel upperLinePanel;
        private Panel optionsPanel;
        private Panel profilePicturePanel;
        private Panel loginPanel;
        private Panel postPanel;
        private Label postHeadlineLabel;
        private Label label1;
        private Panel eventsPanel;
        private Label label2;
        private Panel likedPagesPanel;
        private Label eventsHeadlineLabel;
        private Panel fansPanel;
        private Label fansHeadlineLabel;
        private Label fansSecondHeadlineLabel;
        private Button homeButton;
        private Panel sidePanel;
    }
}