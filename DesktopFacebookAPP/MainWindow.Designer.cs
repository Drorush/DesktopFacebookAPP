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
            this.commentBackTextBox = new System.Windows.Forms.TextBox();
            this.loginButton = new DesktopFacebookAPP.RoundedEdgeButton();
            this.cancelPostButton = new DesktopFacebookAPP.RoundedEdgeButton();
            this.sendPostButton = new DesktopFacebookAPP.RoundedEdgeButton();
            this.secondFeatureButton = new DesktopFacebookAPP.RoundButton();
            this.fansButton = new DesktopFacebookAPP.RoundButton();
            this.likedPagesButton = new DesktopFacebookAPP.RoundButton();
            this.upcomingEventsButton = new DesktopFacebookAPP.RoundButton();
            this.postButton = new DesktopFacebookAPP.RoundButton();
            this.commentButton = new DesktopFacebookAPP.RoundedEdgeButton();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profilePictureBox.Location = new System.Drawing.Point(172, 794);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(8);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(301, 257);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.welcomeLabel.Location = new System.Drawing.Point(148, 1074);
            this.welcomeLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(408, 162);
            this.welcomeLabel.TabIndex = 2;
            this.welcomeLabel.Text = "Welcome !!!";
            this.welcomeLabel.Visible = false;
            this.welcomeLabel.Click += new System.EventHandler(this.welcomeLabel_Click);
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(627, 442);
            this.postTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.postTextBox.Multiline = true;
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(463, 146);
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
            this.eventsListBox.ItemHeight = 31;
            this.eventsListBox.Location = new System.Drawing.Point(850, 442);
            this.eventsListBox.Margin = new System.Windows.Forms.Padding(8);
            this.eventsListBox.Name = "eventsListBox";
            this.eventsListBox.Size = new System.Drawing.Size(480, 66);
            this.eventsListBox.TabIndex = 41;
            this.eventsListBox.Visible = false;
            // 
            // likePagedListBox
            // 
            this.likePagedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.likePagedListBox.DisplayMember = "name";
            this.likePagedListBox.FormattingEnabled = true;
            this.likePagedListBox.ItemHeight = 31;
            this.likePagedListBox.Location = new System.Drawing.Point(527, 442);
            this.likePagedListBox.Margin = new System.Windows.Forms.Padding(8);
            this.likePagedListBox.Name = "likePagedListBox";
            this.likePagedListBox.Size = new System.Drawing.Size(1194, 407);
            this.likePagedListBox.TabIndex = 42;
            this.likePagedListBox.Visible = false;
            // 
            // fansListBox
            // 
            this.fansListBox.FormattingEnabled = true;
            this.fansListBox.ItemHeight = 31;
            this.fansListBox.Location = new System.Drawing.Point(606, 627);
            this.fansListBox.Margin = new System.Windows.Forms.Padding(8);
            this.fansListBox.Name = "fansListBox";
            this.fansListBox.Size = new System.Drawing.Size(404, 97);
            this.fansListBox.TabIndex = 43;
            this.fansListBox.Visible = false;
            // 
            // commentBackTextBox
            // 
            this.commentBackTextBox.Location = new System.Drawing.Point(503, 590);
            this.commentBackTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.commentBackTextBox.Multiline = true;
            this.commentBackTextBox.Name = "commentBackTextBox";
            this.commentBackTextBox.Size = new System.Drawing.Size(1176, 134);
            this.commentBackTextBox.TabIndex = 44;
            this.commentBackTextBox.Text = "Write something ";
            this.commentBackTextBox.Visible = false;
            // 
            // loginButton
            // 
            this.loginButton.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.login1;
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Location = new System.Drawing.Point(145, 1168);
            this.loginButton.Margin = new System.Windows.Forms.Padding(8);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(540, 135);
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
            this.cancelPostButton.Location = new System.Drawing.Point(1200, 940);
            this.cancelPostButton.Margin = new System.Windows.Forms.Padding(8);
            this.cancelPostButton.Name = "cancelPostButton";
            this.cancelPostButton.Size = new System.Drawing.Size(315, 154);
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
            this.sendPostButton.Location = new System.Drawing.Point(850, 940);
            this.sendPostButton.Margin = new System.Windows.Forms.Padding(8);
            this.sendPostButton.Name = "sendPostButton";
            this.sendPostButton.Size = new System.Drawing.Size(315, 154);
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
            this.secondFeatureButton.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondFeatureButton.Location = new System.Drawing.Point(1699, 39);
            this.secondFeatureButton.Margin = new System.Windows.Forms.Padding(8);
            this.secondFeatureButton.Name = "secondFeatureButton";
            this.secondFeatureButton.Size = new System.Drawing.Size(300, 300);
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
            this.fansButton.Location = new System.Drawing.Point(1303, 39);
            this.fansButton.Margin = new System.Windows.Forms.Padding(8);
            this.fansButton.Name = "fansButton";
            this.fansButton.Size = new System.Drawing.Size(300, 300);
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
            this.likedPagesButton.Location = new System.Drawing.Point(895, 16);
            this.likedPagesButton.Margin = new System.Windows.Forms.Padding(8);
            this.likedPagesButton.Name = "likedPagesButton";
            this.likedPagesButton.Size = new System.Drawing.Size(300, 300);
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
            this.upcomingEventsButton.Location = new System.Drawing.Point(442, 16);
            this.upcomingEventsButton.Margin = new System.Windows.Forms.Padding(8);
            this.upcomingEventsButton.Name = "upcomingEventsButton";
            this.upcomingEventsButton.Size = new System.Drawing.Size(300, 300);
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
            this.postButton.Margin = new System.Windows.Forms.Padding(8);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(300, 300);
            this.postButton.TabIndex = 3;
            this.postButton.Text = "post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Visible = false;
            this.postButton.Click += new System.EventHandler(this.postButton_Click);
            this.postButton.MouseLeave += new System.EventHandler(this.postButton_MouseLeave);
            this.postButton.MouseHover += new System.EventHandler(this.postButton_MouseHover);
            // 
            // commentButton
            // 
            this.commentButton.Location = new System.Drawing.Point(1109, 627);
            this.commentButton.Margin = new System.Windows.Forms.Padding(8);
            this.commentButton.Name = "commentButton";
            this.commentButton.Size = new System.Drawing.Size(86, 56);
            this.commentButton.TabIndex = 45;
            this.commentButton.Text = "Comment!";
            this.commentButton.UseVisualStyleBackColor = true;
            this.commentButton.Visible = false;
            this.commentButton.Click += new System.EventHandler(this.commentButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::DesktopFacebookAPP.Properties.Resources.welcomeScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2092, 1415);
            this.Controls.Add(this.loginButton);
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
            this.Controls.Add(this.commentButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "MainWindow";
            this.Text = "Facebook APP";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
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
        private System.Windows.Forms.TextBox commentBackTextBox;
        private RoundedEdgeButton commentButton;
    }
}