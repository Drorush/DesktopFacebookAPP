using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopFacebookAPP
{
    public partial class VisualQuestion
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
            this.m_QuestionPanel = new System.Windows.Forms.Panel();
            this.m_ResultPictureBox = new System.Windows.Forms.PictureBox();
            this.m_ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.m_QuestionDescriptionLabel = new System.Windows.Forms.Label();
            this.m_FirstAnswerRadioButton = new System.Windows.Forms.RadioButton();
            this.m_SecondAnswerRadioButton = new System.Windows.Forms.RadioButton();
            this.m_ThirdAnswerRadioButton = new System.Windows.Forms.RadioButton();
            this.m_QuestionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ResultPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionPanel
            // 
            this.m_QuestionPanel.BackColor = System.Drawing.Color.White;
            this.m_QuestionPanel.Controls.Add(this.m_ResultPictureBox);
            this.m_QuestionPanel.Controls.Add(this.m_ProfilePictureBox);
            this.m_QuestionPanel.Controls.Add(this.m_QuestionDescriptionLabel);
            this.m_QuestionPanel.Controls.Add(this.m_FirstAnswerRadioButton);
            this.m_QuestionPanel.Controls.Add(this.m_SecondAnswerRadioButton);
            this.m_QuestionPanel.Controls.Add(this.m_ThirdAnswerRadioButton);
            this.m_QuestionPanel.Location = new System.Drawing.Point(2, 2);
            this.m_QuestionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.m_QuestionPanel.Name = "QuestionPanel";
            this.m_QuestionPanel.Size = new System.Drawing.Size(990, 187);
            this.m_QuestionPanel.TabIndex = 48;
            // 
            // questionOneResultPictureBox
            // 
            this.m_ResultPictureBox.Location = new System.Drawing.Point(896, 60);
            this.m_ResultPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.m_ResultPictureBox.Name = "questionOneResultPictureBox";
            this.m_ResultPictureBox.Size = new System.Drawing.Size(56, 56);
            this.m_ResultPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_ResultPictureBox.TabIndex = 3;
            this.m_ResultPictureBox.TabStop = false;
            // 
            // firstQuestionPictureBox
            // 
            this.m_ProfilePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_ProfilePictureBox.Location = new System.Drawing.Point(732, 12);
            this.m_ProfilePictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.m_ProfilePictureBox.Name = "firstQuestionPictureBox";
            this.m_ProfilePictureBox.Size = new System.Drawing.Size(151, 138);
            this.m_ProfilePictureBox.TabIndex = 2;
            this.m_ProfilePictureBox.TabStop = false;
            // 
            // firstQuestionLabel
            // 
            this.m_QuestionDescriptionLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_QuestionDescriptionLabel.Location = new System.Drawing.Point(4, 4);
            this.m_QuestionDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.m_QuestionDescriptionLabel.Name = "firstQuestionLabel";
            this.m_QuestionDescriptionLabel.Size = new System.Drawing.Size(635, 121);
            this.m_QuestionDescriptionLabel.TabIndex = 1;
            this.m_QuestionDescriptionLabel.Text = "first Q text";
            this.m_QuestionDescriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // firstQuestionThirdOptionRadioButton
            // 
            this.m_FirstAnswerRadioButton.AutoSize = true;
            this.m_FirstAnswerRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_FirstAnswerRadioButton.Location = new System.Drawing.Point(516, 138);
            this.m_FirstAnswerRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.m_FirstAnswerRadioButton.Name = "firstQuestionThirdOptionRadioButton";
            this.m_FirstAnswerRadioButton.Size = new System.Drawing.Size(209, 47);
            this.m_FirstAnswerRadioButton.TabIndex = 0;
            this.m_FirstAnswerRadioButton.TabStop = true;
            this.m_FirstAnswerRadioButton.Text = "radioButton1";
            this.m_FirstAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstQuestionSecondOptionRadioButton
            // 
            this.m_SecondAnswerRadioButton.AutoSize = true;
            this.m_SecondAnswerRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_SecondAnswerRadioButton.Location = new System.Drawing.Point(264, 138);
            this.m_SecondAnswerRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.m_SecondAnswerRadioButton.Name = "firstQuestionSecondOptionRadioButton";
            this.m_SecondAnswerRadioButton.Size = new System.Drawing.Size(209, 47);
            this.m_SecondAnswerRadioButton.TabIndex = 0;
            this.m_SecondAnswerRadioButton.TabStop = true;
            this.m_SecondAnswerRadioButton.Text = "radioButton1";
            this.m_SecondAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // firstQuestionFirstOptionRadioButton
            // 
            this.m_ThirdAnswerRadioButton.AutoSize = true;
            this.m_ThirdAnswerRadioButton.Font = new System.Drawing.Font("Segoe Print", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ThirdAnswerRadioButton.Location = new System.Drawing.Point(12, 138);
            this.m_ThirdAnswerRadioButton.Margin = new System.Windows.Forms.Padding(2);
            this.m_ThirdAnswerRadioButton.Name = "firstQuestionFirstOptionRadioButton";
            this.m_ThirdAnswerRadioButton.Size = new System.Drawing.Size(209, 47);
            this.m_ThirdAnswerRadioButton.TabIndex = 0;
            this.m_ThirdAnswerRadioButton.TabStop = true;
            this.m_ThirdAnswerRadioButton.Text = "radioButton1";
            this.m_ThirdAnswerRadioButton.UseVisualStyleBackColor = true;
            // 
            // VisualQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_QuestionPanel);
            this.Name = "VisualQuestion";
            this.Size = new System.Drawing.Size(995, 192);
            this.m_QuestionPanel.ResumeLayout(false);
            this.m_QuestionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_ResultPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_ProfilePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }    
}
