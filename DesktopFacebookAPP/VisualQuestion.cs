using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopFacebookAPP
{
    public partial class VisualQuestion : UserControl
    {
        public VisualQuestion()
        {
            InitializeComponent();
        }

        private Panel m_QuestionPanel;
        private PictureBox m_ResultPictureBox;
        private Question m_Question;
        private PictureBox m_ProfilePictureBox;
        private Label m_QuestionDescriptionLabel;
        private RadioButton m_FirstAnswerRadioButton;
        private RadioButton m_SecondAnswerRadioButton;
        private RadioButton m_ThirdAnswerRadioButton;

        internal void InitQuestion(Question i_Question)
        {
            this.m_Question = i_Question;
            m_QuestionDescriptionLabel.Text = m_Question.QuestionContent;
            m_FirstAnswerRadioButton.Text = m_Question.PossibleAnswers[0];
            m_SecondAnswerRadioButton.Text = m_Question.PossibleAnswers[1];
            m_ThirdAnswerRadioButton.Text = m_Question.PossibleAnswers[2];

            if (i_Question is QuestionIdentifyByProfilePicture)
            {
                m_ProfilePictureBox.LoadAsync(m_Question.Answer.PictureNormalURL);
            }
            else
            {
                m_ProfilePictureBox.Visible = false;
            }
        }

        internal void Clear()
        {
            foreach (Control control in m_QuestionPanel.Controls)
            {
                if (control is RadioButton)
                {
                    (control as RadioButton).Checked = false;
                    control.ForeColor = Color.Black;
                }
            }

            m_ResultPictureBox.Visible = false;
        }
  
    internal void ShowAnswerFeedbackPicture()
        {
            string userAnswer = this.getUserAnswer();
            string expectedAnswer = this.getRightAnswer();

            this.m_ResultPictureBox.Image = userAnswer.Equals(expectedAnswer)
                ? Properties.Resources.V
                : Properties.Resources.X;

            this.m_ResultPictureBox.Visible = true;
        }

        internal void ColorAnswer()
        {
            string rightAnswer = this.getRightAnswer();
            foreach (Control control in this.m_QuestionPanel.Controls)
            {
                if (control is RadioButton)
                {
                    control.ForeColor = control.Text.Equals(rightAnswer)
                        ? Color.Green
                        : Color.Red;
                }
            }
        }

        private string getUserAnswer()
        {
            foreach (Control control in m_QuestionPanel.Controls)
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

        private string getRightAnswer()
        {
            return m_Question.Answer.Name;
        }
    }
}
