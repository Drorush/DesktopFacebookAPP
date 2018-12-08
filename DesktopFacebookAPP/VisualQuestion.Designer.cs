using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopFacebookAPP
{
    partial class VisualQuestion
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.resultPictureBox = new System.Windows.Forms.PictureBox();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.questionDescriptionLabel = new System.Windows.Forms.Label();
            this.firstAnswerRadioButton = new System.Windows.Forms.RadioButton();
            this.secondAnswerRadioButton = new System.Windows.Forms.RadioButton();
            this.thirdAnswerRadioButton = new System.Windows.Forms.RadioButton();
            this.QuestionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.BackColor = System.Drawing.Color.White;
            this.QuestionPanel.Controls.Add(this.resultPictureBox);
            this.QuestionPanel.Controls.Add(this.profilePictureBox);
            this.QuestionPanel.Controls.Add(this.questionDescriptionLabel);
            this.QuestionPanel.Controls.Add(this.firstAnswerRadioButton);
            this.QuestionPanel.Controls.Add(this.secondAnswerRadioButton);
            this.QuestionPanel.Controls.Add(this.thirdAnswerRadioButton);
            this.QuestionPanel.Location = new System.Drawing.Point(2, 2);
            this.QuestionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(990, 187);
            this.QuestionPanel.TabIndex = 48;
            // 
            // questionOneResultPictureBox
            // 
            this.resultPictureBox.Location = new System.Drawing.Point(896, 60);
            this.resultPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.resultPictureBox.Name = "questionOneResultPictureBox";
            this.resultPictureBox.Size = new System.Drawing.Size(56, 56);
            this.resultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.resultPictureBox.TabIndex = 3;
            this.resultPictureBox.TabStop = false;
            // 
            // firstQuestionPictureBox
            // 
            this.profilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.profilePictureBox.Location = new System.Drawing.Point(732, 12);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.profilePictureBox.Name = "firstQuestionPictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(151, 138);
            this.profilePictureBox.TabIndex = 2;
            this.profilePictureBox.TabStop = false;
            // 
            // firstQuestionLabel
            // 
            this.questionDescriptionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionDescriptionLabel.Location = new System.Drawing.Point(4, 4);
            this.questionDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionDescriptionLabel.Name = "firstQuestionLabel";
            this.questionDescriptionLabel.Size = new System.Drawing.Size(635, 121);
            this.questionDescriptionLabel.TabIndex = 1;
            this.questionDescriptionLabel.Text = "first Q text";
            this.questionDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstQuestionThirdOptionRadioButton
            // 
            this.firstAnswerRadioButton.AutoSize = true;
            this.firstAnswerRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstAnswerRadioButton.Location = new System.Drawing.Point(516, 138);
            this.firstAnswerRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.firstAnswerRadioButton.Name = "firstQuestionThirdOptionRadioButton";
            this.firstAnswerRadioButton.Size = new System.Drawing.Size(209, 47);
            this.firstAnswerRadioButton.TabIndex = 0;
            this.firstAnswerRadioButton.TabStop = true;
            this.firstAnswerRadioButton.Text = "radioButton1";
            this.firstAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstQuestionSecondOptionRadioButton
            // 
            this.secondAnswerRadioButton.AutoSize = true;
            this.secondAnswerRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondAnswerRadioButton.Location = new System.Drawing.Point(264, 138);
            this.secondAnswerRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.secondAnswerRadioButton.Name = "firstQuestionSecondOptionRadioButton";
            this.secondAnswerRadioButton.Size = new System.Drawing.Size(209, 47);
            this.secondAnswerRadioButton.TabIndex = 0;
            this.secondAnswerRadioButton.TabStop = true;
            this.secondAnswerRadioButton.Text = "radioButton1";
            this.secondAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstQuestionFirstOptionRadioButton
            // 
            this.thirdAnswerRadioButton.AutoSize = true;
            this.thirdAnswerRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thirdAnswerRadioButton.Location = new System.Drawing.Point(12, 138);
            this.thirdAnswerRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.thirdAnswerRadioButton.Name = "firstQuestionFirstOptionRadioButton";
            this.thirdAnswerRadioButton.Size = new System.Drawing.Size(209, 47);
            this.thirdAnswerRadioButton.TabIndex = 0;
            this.thirdAnswerRadioButton.TabStop = true;
            this.thirdAnswerRadioButton.Text = "radioButton1";
            this.thirdAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // VisualQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.QuestionPanel);
            this.Name = "VisualQuestion";
            this.Size = new System.Drawing.Size(995, 192);
            this.QuestionPanel.ResumeLayout(false);
            this.QuestionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal Question Question;
        internal System.Windows.Forms.Panel QuestionPanel { get; set; }
        internal System.Windows.Forms.PictureBox resultPictureBox { get; set; }
        internal System.Windows.Forms.PictureBox profilePictureBox { get; set; }
        internal System.Windows.Forms.Label questionDescriptionLabel { get; set; }
        internal System.Windows.Forms.RadioButton firstAnswerRadioButton { get; set; }
        internal System.Windows.Forms.RadioButton secondAnswerRadioButton { get; set; }
        internal System.Windows.Forms.RadioButton thirdAnswerRadioButton { get; set; }

        public void initQuestion(Question i_Question)
        {
            this.Question = i_Question;
            questionDescriptionLabel.Text = Question.QuestionContent;
            firstAnswerRadioButton.Text = Question.PossibleAnswers[0];
            secondAnswerRadioButton.Text = Question.PossibleAnswers[1];
            thirdAnswerRadioButton.Text = Question.PossibleAnswers[2];

            if(i_Question is QuestionIdentifyByProfilePicture)
            {
                profilePictureBox.LoadAsync(Question.Answer.PictureNormalURL);
            }
            else
            {
                profilePictureBox.Visible = false;
            }      
        }

        public string getUserAnswer()
        {
            foreach (Control control in QuestionPanel.Controls)
            {
                if (control is RadioButton)
                {
                    if ((control as RadioButton).Checked)
                    {
                        return control.Text;
                    }
                }
            }

            throw new Exception();
        }

        public string getRightAnswer()
        {
            return Question.Answer.Name;
        }

        public void clear()
        {
            foreach (Control control in QuestionPanel.Controls)
            {
                if (control is RadioButton)
                {
                    (control as RadioButton).Checked = false;
                    control.ForeColor = Color.Black;
                }
            }

            resultPictureBox.Visible = false;
        }
    }
}
