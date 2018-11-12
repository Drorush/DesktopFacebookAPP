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
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.likePagedListBox = new System.Windows.Forms.ListBox();
            this.fansListBox = new System.Windows.Forms.ListBox();
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
            this.loginButton = new DesktopFacebookAPP.RoundedEdgeButton();
            this.cancelPostButton = new DesktopFacebookAPP.RoundedEdgeButton();
            this.sendPostButton = new DesktopFacebookAPP.RoundedEdgeButton();
            this.secondFeatureButton = new DesktopFacebookAPP.RoundButton();
            this.fansButton = new DesktopFacebookAPP.RoundButton();
            this.likedPagesButton = new DesktopFacebookAPP.RoundButton();
            this.upcomingEventsButton = new DesktopFacebookAPP.RoundButton();
            this.postButton = new DesktopFacebookAPP.RoundButton();
            this.playAgainButton = new DesktopFacebookAPP.RoundButton();
            this.checkGameResultsButton = new DesktopFacebookAPP.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.firstQuestionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionOneResultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstQuestionPictureBox)).BeginInit();
            this.secondQuestionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionTwoResultPictureBox)).BeginInit();
            this.thirdQuestionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.questionThreeResultPictureBox)).BeginInit();
            this.gamePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePictureBox.Location = new System.Drawing.Point(69, 349);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(120, 120);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Visible = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(64, 473);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(199, 65);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome !!!";
            this.welcomeLabel.Visible = false;
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(642, 144);
            this.postTextBox.Multiline = true;
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(200, 89);
            this.postTextBox.TabIndex = 9;
            this.postTextBox.Text = "whats on your";
            this.postTextBox.Visible = false;
            this.postTextBox.WordWrap = false;
            // 
            // eventsListBox
            // 
            this.eventsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsListBox.DisplayMember = "name";
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.Location = new System.Drawing.Point(6, 239);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(257, 95);
            this.eventsListBox.TabIndex = 41;
            this.eventsListBox.Visible = false;
            // 
            // likePagedListBox
            // 
            this.likePagedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.likePagedListBox.DisplayMember = "name";
            this.likePagedListBox.FormattingEnabled = true;
            this.likePagedListBox.Location = new System.Drawing.Point(26, 138);
            this.likePagedListBox.Name = "likePagedListBox";
            this.likePagedListBox.Size = new System.Drawing.Size(208, 95);
            this.likePagedListBox.TabIndex = 42;
            this.likePagedListBox.Visible = false;
            // 
            // fansListBox
            // 
            this.fansListBox.FormattingEnabled = true;
            this.fansListBox.Location = new System.Drawing.Point(612, 349);
            this.fansListBox.Name = "fansListBox";
            this.fansListBox.Size = new System.Drawing.Size(308, 82);
            this.fansListBox.TabIndex = 43;
            this.fansListBox.Visible = false;
            // 
            // loadingLabel
            // 
            this.loadingLabel.Location = new System.Drawing.Point(668, 287);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(109, 24);
            this.loadingLabel.TabIndex = 46;
            this.loadingLabel.Text = "Loading Fans...";
            this.loadingLabel.Visible = false;
            // 
            // firstQuestionPanel
            // 
            this.firstQuestionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstQuestionPanel.Controls.Add(this.questionOneResultPictureBox);
            this.firstQuestionPanel.Controls.Add(this.firstQuestionPictureBox);
            this.firstQuestionPanel.Controls.Add(this.firstQuestionLabel);
            this.firstQuestionPanel.Controls.Add(this.firstQuestionThirdOptionRadioButton);
            this.firstQuestionPanel.Controls.Add(this.firstQuestionSecondOptionRadioButton);
            this.firstQuestionPanel.Controls.Add(this.firstQuestionFirstOptionRadioButton);
            this.firstQuestionPanel.Location = new System.Drawing.Point(12, 11);
            this.firstQuestionPanel.Name = "firstQuestionPanel";
            this.firstQuestionPanel.Size = new System.Drawing.Size(323, 135);
            this.firstQuestionPanel.TabIndex = 47;
            // 
            // questionOneResultPictureBox
            // 
            this.questionOneResultPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionOneResultPictureBox.Location = new System.Drawing.Point(236, 60);
            this.questionOneResultPictureBox.Name = "questionOneResultPictureBox";
            this.questionOneResultPictureBox.Size = new System.Drawing.Size(35, 30);
            this.questionOneResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionOneResultPictureBox.TabIndex = 3;
            this.questionOneResultPictureBox.TabStop = false;
            this.questionOneResultPictureBox.Click += new System.EventHandler(this.questionOneResultPictureBox_Click);
            // 
            // firstQuestionPictureBox
            // 
            this.firstQuestionPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstQuestionPictureBox.Location = new System.Drawing.Point(98, 24);
            this.firstQuestionPictureBox.Name = "firstQuestionPictureBox";
            this.firstQuestionPictureBox.Size = new System.Drawing.Size(80, 80);
            this.firstQuestionPictureBox.TabIndex = 2;
            this.firstQuestionPictureBox.TabStop = false;
            // 
            // firstQuestionLabel
            // 
            this.firstQuestionLabel.Location = new System.Drawing.Point(4, 6);
            this.firstQuestionLabel.Name = "firstQuestionLabel";
            this.firstQuestionLabel.Size = new System.Drawing.Size(277, 23);
            this.firstQuestionLabel.TabIndex = 1;
            this.firstQuestionLabel.Text = "firsttttquestionnnnnnnnnnnnn";
            // 
            // firstQuestionThirdOptionRadioButton
            // 
            this.firstQuestionThirdOptionRadioButton.AutoSize = true;
            this.firstQuestionThirdOptionRadioButton.Location = new System.Drawing.Point(225, 114);
            this.firstQuestionThirdOptionRadioButton.Name = "firstQuestionThirdOptionRadioButton";
            this.firstQuestionThirdOptionRadioButton.Size = new System.Drawing.Size(85, 17);
            this.firstQuestionThirdOptionRadioButton.TabIndex = 0;
            this.firstQuestionThirdOptionRadioButton.TabStop = true;
            this.firstQuestionThirdOptionRadioButton.Text = "radioButton1";
            this.firstQuestionThirdOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstQuestionSecondOptionRadioButton
            // 
            this.firstQuestionSecondOptionRadioButton.AutoSize = true;
            this.firstQuestionSecondOptionRadioButton.Location = new System.Drawing.Point(117, 112);
            this.firstQuestionSecondOptionRadioButton.Name = "firstQuestionSecondOptionRadioButton";
            this.firstQuestionSecondOptionRadioButton.Size = new System.Drawing.Size(85, 17);
            this.firstQuestionSecondOptionRadioButton.TabIndex = 0;
            this.firstQuestionSecondOptionRadioButton.TabStop = true;
            this.firstQuestionSecondOptionRadioButton.Text = "radioButton1";
            this.firstQuestionSecondOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstQuestionFirstOptionRadioButton
            // 
            this.firstQuestionFirstOptionRadioButton.AutoSize = true;
            this.firstQuestionFirstOptionRadioButton.Location = new System.Drawing.Point(6, 112);
            this.firstQuestionFirstOptionRadioButton.Name = "firstQuestionFirstOptionRadioButton";
            this.firstQuestionFirstOptionRadioButton.Size = new System.Drawing.Size(85, 17);
            this.firstQuestionFirstOptionRadioButton.TabIndex = 0;
            this.firstQuestionFirstOptionRadioButton.TabStop = true;
            this.firstQuestionFirstOptionRadioButton.Text = "radioButton1";
            this.firstQuestionFirstOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondQuestionPanel
            // 
            this.secondQuestionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.secondQuestionPanel.Controls.Add(this.questionTwoResultPictureBox);
            this.secondQuestionPanel.Controls.Add(this.secondQuestionLabel);
            this.secondQuestionPanel.Controls.Add(this.secondQuestionThirdOptionRadioButton);
            this.secondQuestionPanel.Controls.Add(this.secondQuestionSecondOptionRadioButton);
            this.secondQuestionPanel.Controls.Add(this.secondQuestionFirstOptionRadioButton);
            this.secondQuestionPanel.Location = new System.Drawing.Point(15, 161);
            this.secondQuestionPanel.Name = "secondQuestionPanel";
            this.secondQuestionPanel.Size = new System.Drawing.Size(320, 67);
            this.secondQuestionPanel.TabIndex = 48;
            // 
            // questionTwoResultPictureBox
            // 
            this.questionTwoResultPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionTwoResultPictureBox.Location = new System.Drawing.Point(279, 4);
            this.questionTwoResultPictureBox.Name = "questionTwoResultPictureBox";
            this.questionTwoResultPictureBox.Size = new System.Drawing.Size(35, 30);
            this.questionTwoResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionTwoResultPictureBox.TabIndex = 3;
            this.questionTwoResultPictureBox.TabStop = false;
            // 
            // secondQuestionLabel
            // 
            this.secondQuestionLabel.Location = new System.Drawing.Point(8, 7);
            this.secondQuestionLabel.Name = "secondQuestionLabel";
            this.secondQuestionLabel.Size = new System.Drawing.Size(266, 27);
            this.secondQuestionLabel.TabIndex = 2;
            this.secondQuestionLabel.Text = "second questionnnnnnnnnnn";
            // 
            // secondQuestionThirdOptionRadioButton
            // 
            this.secondQuestionThirdOptionRadioButton.AutoSize = true;
            this.secondQuestionThirdOptionRadioButton.Location = new System.Drawing.Point(226, 43);
            this.secondQuestionThirdOptionRadioButton.Name = "secondQuestionThirdOptionRadioButton";
            this.secondQuestionThirdOptionRadioButton.Size = new System.Drawing.Size(85, 17);
            this.secondQuestionThirdOptionRadioButton.TabIndex = 1;
            this.secondQuestionThirdOptionRadioButton.TabStop = true;
            this.secondQuestionThirdOptionRadioButton.Text = "radioButton1";
            this.secondQuestionThirdOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondQuestionSecondOptionRadioButton
            // 
            this.secondQuestionSecondOptionRadioButton.AutoSize = true;
            this.secondQuestionSecondOptionRadioButton.Location = new System.Drawing.Point(111, 42);
            this.secondQuestionSecondOptionRadioButton.Name = "secondQuestionSecondOptionRadioButton";
            this.secondQuestionSecondOptionRadioButton.Size = new System.Drawing.Size(85, 17);
            this.secondQuestionSecondOptionRadioButton.TabIndex = 2;
            this.secondQuestionSecondOptionRadioButton.TabStop = true;
            this.secondQuestionSecondOptionRadioButton.Text = "radioButton1";
            this.secondQuestionSecondOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // secondQuestionFirstOptionRadioButton
            // 
            this.secondQuestionFirstOptionRadioButton.AutoSize = true;
            this.secondQuestionFirstOptionRadioButton.Location = new System.Drawing.Point(3, 42);
            this.secondQuestionFirstOptionRadioButton.Name = "secondQuestionFirstOptionRadioButton";
            this.secondQuestionFirstOptionRadioButton.Size = new System.Drawing.Size(85, 17);
            this.secondQuestionFirstOptionRadioButton.TabIndex = 3;
            this.secondQuestionFirstOptionRadioButton.TabStop = true;
            this.secondQuestionFirstOptionRadioButton.Text = "radioButton6";
            this.secondQuestionFirstOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // thirdQuestionPanel
            // 
            this.thirdQuestionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.thirdQuestionPanel.Controls.Add(this.questionThreeResultPictureBox);
            this.thirdQuestionPanel.Controls.Add(this.thirdQuestionLabel);
            this.thirdQuestionPanel.Controls.Add(this.thirdQuestionThirdOptionRadioButton);
            this.thirdQuestionPanel.Controls.Add(this.thirdQuestionSecondOptionRadioButton);
            this.thirdQuestionPanel.Controls.Add(this.thirdQuestionFirstOptionRadioButton);
            this.thirdQuestionPanel.Location = new System.Drawing.Point(16, 245);
            this.thirdQuestionPanel.Name = "thirdQuestionPanel";
            this.thirdQuestionPanel.Size = new System.Drawing.Size(319, 77);
            this.thirdQuestionPanel.TabIndex = 49;
            // 
            // questionThreeResultPictureBox
            // 
            this.questionThreeResultPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionThreeResultPictureBox.Location = new System.Drawing.Point(278, 3);
            this.questionThreeResultPictureBox.Name = "questionThreeResultPictureBox";
            this.questionThreeResultPictureBox.Size = new System.Drawing.Size(35, 30);
            this.questionThreeResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.questionThreeResultPictureBox.TabIndex = 3;
            this.questionThreeResultPictureBox.TabStop = false;
            // 
            // thirdQuestionLabel
            // 
            this.thirdQuestionLabel.Location = new System.Drawing.Point(6, 7);
            this.thirdQuestionLabel.Name = "thirdQuestionLabel";
            this.thirdQuestionLabel.Size = new System.Drawing.Size(266, 27);
            this.thirdQuestionLabel.TabIndex = 4;
            this.thirdQuestionLabel.Text = "thirdddddquestionnnnnnnnnnn";
            // 
            // thirdQuestionThirdOptionRadioButton
            // 
            this.thirdQuestionThirdOptionRadioButton.AutoSize = true;
            this.thirdQuestionThirdOptionRadioButton.Location = new System.Drawing.Point(220, 52);
            this.thirdQuestionThirdOptionRadioButton.Name = "thirdQuestionThirdOptionRadioButton";
            this.thirdQuestionThirdOptionRadioButton.Size = new System.Drawing.Size(85, 17);
            this.thirdQuestionThirdOptionRadioButton.TabIndex = 1;
            this.thirdQuestionThirdOptionRadioButton.TabStop = true;
            this.thirdQuestionThirdOptionRadioButton.Text = "radioButton1";
            this.thirdQuestionThirdOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // thirdQuestionSecondOptionRadioButton
            // 
            this.thirdQuestionSecondOptionRadioButton.AutoSize = true;
            this.thirdQuestionSecondOptionRadioButton.Location = new System.Drawing.Point(115, 51);
            this.thirdQuestionSecondOptionRadioButton.Name = "thirdQuestionSecondOptionRadioButton";
            this.thirdQuestionSecondOptionRadioButton.Size = new System.Drawing.Size(85, 17);
            this.thirdQuestionSecondOptionRadioButton.TabIndex = 2;
            this.thirdQuestionSecondOptionRadioButton.TabStop = true;
            this.thirdQuestionSecondOptionRadioButton.Text = "radioButton1";
            this.thirdQuestionSecondOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // thirdQuestionFirstOptionRadioButton
            // 
            this.thirdQuestionFirstOptionRadioButton.AutoSize = true;
            this.thirdQuestionFirstOptionRadioButton.Location = new System.Drawing.Point(6, 51);
            this.thirdQuestionFirstOptionRadioButton.Name = "thirdQuestionFirstOptionRadioButton";
            this.thirdQuestionFirstOptionRadioButton.Size = new System.Drawing.Size(85, 17);
            this.thirdQuestionFirstOptionRadioButton.TabIndex = 3;
            this.thirdQuestionFirstOptionRadioButton.TabStop = true;
            this.thirdQuestionFirstOptionRadioButton.Text = "radioButton9";
            this.thirdQuestionFirstOptionRadioButton.UseVisualStyleBackColor = true;
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.gamePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gamePanel.Controls.Add(this.firstQuestionPanel);
            this.gamePanel.Controls.Add(this.playAgainButton);
            this.gamePanel.Controls.Add(this.checkGameResultsButton);
            this.gamePanel.Controls.Add(this.secondQuestionPanel);
            this.gamePanel.Controls.Add(this.thirdQuestionPanel);
            this.gamePanel.Location = new System.Drawing.Point(269, 140);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(352, 375);
            this.gamePanel.TabIndex = 51;
            this.gamePanel.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.login1;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(58, 468);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(216, 54);
            this.loginButton.TabIndex = 0;
            this.loginButton.TabStop = false;
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            this.loginButton.MouseEnter += new System.EventHandler(this.loginButton_MouseEnter);
            this.loginButton.MouseLeave += new System.EventHandler(this.loginButton_MouseLeave);
            this.loginButton.MouseHover += new System.EventHandler(this.loginButton_MouseEnter);
            // 
            // cancelPostButton
            // 
            this.cancelPostButton.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.cancel2;
            this.cancelPostButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelPostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelPostButton.Location = new System.Drawing.Point(480, 376);
            this.cancelPostButton.Name = "cancelPostButton";
            this.cancelPostButton.Size = new System.Drawing.Size(126, 62);
            this.cancelPostButton.TabIndex = 11;
            this.cancelPostButton.UseVisualStyleBackColor = true;
            this.cancelPostButton.Visible = false;
            this.cancelPostButton.Click += new System.EventHandler(this.cancelPostButton_Click);
            this.cancelPostButton.MouseLeave += new System.EventHandler(this.cancelPostButton_MouseLeave);
            this.cancelPostButton.MouseHover += new System.EventHandler(this.cancelPostButton_MouseHover);
            // 
            // sendPostButton
            // 
            this.sendPostButton.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.post2;
            this.sendPostButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendPostButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendPostButton.Location = new System.Drawing.Point(340, 376);
            this.sendPostButton.Name = "sendPostButton";
            this.sendPostButton.Size = new System.Drawing.Size(126, 62);
            this.sendPostButton.TabIndex = 10;
            this.sendPostButton.UseVisualStyleBackColor = true;
            this.sendPostButton.Visible = false;
            this.sendPostButton.Click += new System.EventHandler(this.sendPostButton_Click);
            this.sendPostButton.MouseLeave += new System.EventHandler(this.sendPostButton_MouseLeave);
            this.sendPostButton.MouseHover += new System.EventHandler(this.sendPostButton_MouseHover);
            // 
            // secondFeatureButton
            // 
            this.secondFeatureButton.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.optionButton1;
            this.secondFeatureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secondFeatureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secondFeatureButton.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondFeatureButton.Location = new System.Drawing.Point(691, 10);
            this.secondFeatureButton.Name = "secondFeatureButton";
            this.secondFeatureButton.Size = new System.Drawing.Size(120, 120);
            this.secondFeatureButton.TabIndex = 7;
            this.secondFeatureButton.Text = "how well do you know your friends?";
            this.secondFeatureButton.UseVisualStyleBackColor = true;
            this.secondFeatureButton.Visible = false;
            this.secondFeatureButton.Click += new System.EventHandler(this.secondFeatureButton_Click);
            this.secondFeatureButton.MouseLeave += new System.EventHandler(this.secondFeatureButton_MouseLeave);
            this.secondFeatureButton.MouseHover += new System.EventHandler(this.secondFeatureButton_MouseHover);
            // 
            // fansButton
            // 
            this.fansButton.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.optionButton1;
            this.fansButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fansButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fansButton.Font = new System.Drawing.Font("Segoe Script", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fansButton.Location = new System.Drawing.Point(527, 12);
            this.fansButton.Name = "fansButton";
            this.fansButton.Size = new System.Drawing.Size(120, 120);
            this.fansButton.TabIndex = 6;
            this.fansButton.Text = "Fans";
            this.fansButton.UseVisualStyleBackColor = true;
            this.fansButton.Visible = false;
            this.fansButton.Click += new System.EventHandler(this.fansButton_Click);
            this.fansButton.MouseLeave += new System.EventHandler(this.fansButton_MouseLeave);
            this.fansButton.MouseHover += new System.EventHandler(this.fansButton_MouseHover);
            // 
            // likedPagesButton
            // 
            this.likedPagesButton.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.optionButton1;
            this.likedPagesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.likedPagesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.likedPagesButton.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likedPagesButton.Location = new System.Drawing.Point(364, 12);
            this.likedPagesButton.Name = "likedPagesButton";
            this.likedPagesButton.Size = new System.Drawing.Size(120, 120);
            this.likedPagesButton.TabIndex = 5;
            this.likedPagesButton.Text = "pages";
            this.likedPagesButton.UseVisualStyleBackColor = true;
            this.likedPagesButton.Visible = false;
            this.likedPagesButton.Click += new System.EventHandler(this.likedPagesButton_Click);
            this.likedPagesButton.MouseLeave += new System.EventHandler(this.likedPagesButton_MouseLeave);
            this.likedPagesButton.MouseHover += new System.EventHandler(this.likedPagesButton_MouseHover);
            // 
            // upcomingEventsButton
            // 
            this.upcomingEventsButton.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.optionButton1;
            this.upcomingEventsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.upcomingEventsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upcomingEventsButton.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upcomingEventsButton.Location = new System.Drawing.Point(209, 12);
            this.upcomingEventsButton.Name = "upcomingEventsButton";
            this.upcomingEventsButton.Size = new System.Drawing.Size(120, 120);
            this.upcomingEventsButton.TabIndex = 4;
            this.upcomingEventsButton.Text = "events";
            this.upcomingEventsButton.UseVisualStyleBackColor = true;
            this.upcomingEventsButton.Visible = false;
            this.upcomingEventsButton.Click += new System.EventHandler(this.upcomingEventsButton_Click);
            this.upcomingEventsButton.MouseLeave += new System.EventHandler(this.upcomingEventsButton_MouseLeave);
            this.upcomingEventsButton.MouseHover += new System.EventHandler(this.upcomingEventsButton_MouseHover);
            // 
            // postButton
            // 
            this.postButton.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.optionButton1;
            this.postButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.postButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.postButton.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postButton.Location = new System.Drawing.Point(38, 12);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(120, 120);
            this.postButton.TabIndex = 3;
            this.postButton.Text = "post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Visible = false;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            this.postButton.MouseLeave += new System.EventHandler(this.postButton_MouseLeave);
            this.postButton.MouseHover += new System.EventHandler(this.postButton_MouseHover);
            // 
            // playAgainButton
            // 
            this.playAgainButton.BackColor = System.Drawing.Color.LightCyan;
            this.playAgainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playAgainButton.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.playAgainButton.Location = new System.Drawing.Point(157, 326);
            this.playAgainButton.Name = "playAgainButton";
            this.playAgainButton.Size = new System.Drawing.Size(98, 47);
            this.playAgainButton.TabIndex = 50;
            this.playAgainButton.Text = "Play again";
            this.playAgainButton.UseVisualStyleBackColor = false;
            this.playAgainButton.Click += new System.EventHandler(this.PlayAgainButton_Click);
            // 
            // checkGameResultsButton
            // 
            this.checkGameResultsButton.BackColor = System.Drawing.Color.LightCyan;
            this.checkGameResultsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkGameResultsButton.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Bold);
            this.checkGameResultsButton.Location = new System.Drawing.Point(40, 326);
            this.checkGameResultsButton.Name = "checkGameResultsButton";
            this.checkGameResultsButton.Size = new System.Drawing.Size(98, 47);
            this.checkGameResultsButton.TabIndex = 50;
            this.checkGameResultsButton.Text = "Answer!";
            this.checkGameResultsButton.UseVisualStyleBackColor = false;
            this.checkGameResultsButton.Click += new System.EventHandler(this.checkGameResultsButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.welcomeScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(854, 549);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.cancelPostButton);
            this.Controls.Add(this.sendPostButton);
            this.Controls.Add(this.secondFeatureButton);
            this.Controls.Add(this.likePagedListBox);
            this.Controls.Add(this.fansButton);
            this.Controls.Add(this.likedPagesButton);
            this.Controls.Add(this.upcomingEventsButton);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.fansListBox);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.gamePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainWindow";
            this.Text = "Facebook APP";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundedEdgeButton loginButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label welcomeLabel;
        private RoundButton postButton;
        private RoundButton upcomingEventsButton;
        private RoundButton likedPagesButton;
        private RoundButton fansButton;
        private RoundButton secondFeatureButton;
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
    }
}