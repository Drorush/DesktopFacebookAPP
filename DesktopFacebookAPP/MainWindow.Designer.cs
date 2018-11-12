using System.Drawing;

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
            this.loginButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.sendPostButton = new System.Windows.Forms.Button();
            this.cancelPostButton = new System.Windows.Forms.Button();
            this.eventsListBox = new System.Windows.Forms.ListBox();
            this.likePagedListBox = new System.Windows.Forms.ListBox();
            this.fansListBox = new System.Windows.Forms.ListBox();
            this.commentBackTextBox = new System.Windows.Forms.TextBox();
            this.commentButton = new System.Windows.Forms.Button();
            this.secondFeatureButton = new DesktopFacebookAPP.RoundButton();
            this.fansButton = new DesktopFacebookAPP.RoundButton();
            this.likedPagesButton = new DesktopFacebookAPP.RoundButton();
            this.upcomingEventsButton = new DesktopFacebookAPP.RoundButton();
            this.postButton = new DesktopFacebookAPP.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.login1;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(58, 467);
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
            // profilePictureBox
            // 
            this.profilePictureBox.Location = new System.Drawing.Point(58, 354);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(178, 164);
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            this.profilePictureBox.Visible = false;
            this.profilePictureBox.Click += new System.EventHandler(this.profilePictureBox_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(88, 524);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(158, 26);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome !!!";
            this.welcomeLabel.Visible = false;
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(222, 180);
            this.postTextBox.Multiline = true;
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(463, 146);
            this.postTextBox.TabIndex = 9;
            this.postTextBox.Text = "whats on your";
            this.postTextBox.Visible = false;
            this.postTextBox.WordWrap = false;
            // 
            // sendPostButton
            // 
            this.sendPostButton.Location = new System.Drawing.Point(336, 332);
            this.sendPostButton.Name = "sendPostButton";
            this.sendPostButton.Size = new System.Drawing.Size(80, 30);
            this.sendPostButton.TabIndex = 10;
            this.sendPostButton.Text = "post";
            this.sendPostButton.UseVisualStyleBackColor = true;
            this.sendPostButton.Visible = false;
            this.sendPostButton.Click += new System.EventHandler(this.sendPostButton_Click);
            // 
            // cancelPostButton
            // 
            this.cancelPostButton.Location = new System.Drawing.Point(430, 332);
            this.cancelPostButton.Name = "cancelPostButton";
            this.cancelPostButton.Size = new System.Drawing.Size(80, 30);
            this.cancelPostButton.TabIndex = 11;
            this.cancelPostButton.Text = "cancel";
            this.cancelPostButton.UseVisualStyleBackColor = true;
            this.cancelPostButton.Visible = false;
            this.cancelPostButton.Click += new System.EventHandler(this.cancelPostButton_Click);
            // 
            // eventsListBox
            // 
            this.eventsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.eventsListBox.DisplayMember = "name";
            this.eventsListBox.FormattingEnabled = true;
            this.eventsListBox.Location = new System.Drawing.Point(194, 180);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(524, 82);
            this.eventsListBox.TabIndex = 41;
            this.eventsListBox.Visible = false;
            // 
            // likePagedListBox
            // 
            this.likePagedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.likePagedListBox.DisplayMember = "name";
            this.likePagedListBox.FormattingEnabled = true;
            this.likePagedListBox.Location = new System.Drawing.Point(194, 142);
            this.likePagedListBox.Name = "likePagedListBox";
            this.likePagedListBox.Size = new System.Drawing.Size(524, 173);
            this.likePagedListBox.TabIndex = 42;
            this.likePagedListBox.Visible = false;
            // 
            // fansListBox
            // 
            this.fansListBox.FormattingEnabled = true;
            this.fansListBox.Location = new System.Drawing.Point(346, 180);
            this.fansListBox.Name = "fansListBox";
            this.fansListBox.Size = new System.Drawing.Size(164, 134);
            this.fansListBox.TabIndex = 43;
            this.fansListBox.Visible = false;
            // 
            // commentBackTextBox
            // 
            this.commentBackTextBox.Location = new System.Drawing.Point(194, 214);
            this.commentBackTextBox.Multiline = true;
            this.commentBackTextBox.Name = "commentBackTextBox";
            this.commentBackTextBox.Size = new System.Drawing.Size(473, 56);
            this.commentBackTextBox.TabIndex = 44;
            this.commentBackTextBox.Text = "Write something ";
            this.commentBackTextBox.Visible = false;
            // 
            // commentButton
            // 
            this.commentButton.Location = new System.Drawing.Point(543, 332);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(86, 56);
            this.commentButton.TabIndex = 45;
            this.commentButton.Text = "Comment!";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Visible = false;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // secondFeatureButton
            // 
            this.secondFeatureButton.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.optionButton1;
            this.secondFeatureButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secondFeatureButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.secondFeatureButton.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondFeatureButton.Location = new System.Drawing.Point(692, 16);
            this.secondFeatureButton.Name = "secondFeatureButton";
            this.secondFeatureButton.Size = new System.Drawing.Size(120, 120);
            this.secondFeatureButton.TabIndex = 7;
            this.secondFeatureButton.Text = "Reply all";
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
            this.fansButton.Location = new System.Drawing.Point(528, 16);
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
            this.likedPagesButton.Location = new System.Drawing.Point(364, 16);
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
            this.upcomingEventsButton.Location = new System.Drawing.Point(200, 16);
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
            this.postButton.Location = new System.Drawing.Point(36, 16);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.welcomeScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(881, 556);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.commentButton);
            this.Controls.Add(this.commentBackTextBox);
            this.Controls.Add(this.fansListBox);
            this.Controls.Add(this.likePagedListBox);
            this.Controls.Add(this.eventsListBox);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.cancelPostButton);
            this.Controls.Add(this.sendPostButton);
            this.Controls.Add(this.secondFeatureButton);
            this.Controls.Add(this.fansButton);
            this.Controls.Add(this.likedPagesButton);
            this.Controls.Add(this.upcomingEventsButton);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.welcomeLabel);
            this.Controls.Add(this.profilePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainWindow";
            this.Text = "Facebook APP";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label welcomeLabel;
        private RoundButton postButton;
        private RoundButton upcomingEventsButton;
        private RoundButton likedPagesButton;
        private RoundButton fansButton;
        private RoundButton secondFeatureButton;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Button sendPostButton;
        private System.Windows.Forms.Button cancelPostButton;
        private System.Windows.Forms.ListBox eventsListBox;
        private System.Windows.Forms.ListBox likePagedListBox;
        private System.Windows.Forms.ListBox fansListBox;
        private System.Windows.Forms.TextBox commentBackTextBox;
        private System.Windows.Forms.Button commentButton;
    }
}