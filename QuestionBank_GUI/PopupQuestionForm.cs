using QuestionBank_BUS;
using QuestionBank_DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuestionBank_GUI
{
    public partial class PopupQuestionForm : Form
    {
        Question_BUS question_bus = new Question_BUS();
        Question_DTO oldQuestion_dto;
        string idSubject;
        bool btnFinishClicked = false;
        public PopupQuestionForm()
        {
            InitializeComponent();
        }

        public PopupQuestionForm(string idSubject)
        {
            InitializeComponent();
            this.idSubject = idSubject;
        }

        public PopupQuestionForm(string idSubject, Question_DTO question)
        {
            InitializeComponent();

            this.idSubject = idSubject;
            oldQuestion_dto = question;

            txtQuestion.Text = question.Question;
            txtAnswer1.Text = question.Answers[0];
            txtAnswer2.Text = question.Answers[1];

            if (question.Answers.Count >= 3)
                txtAnswer3.Text = question.Answers[2];

            if (question.Answers.Count == 4)
                txtAnswer4.Text = question.Answers[3];

            switch (question.CorrectAnswer)
            {
                case 1: rdAnswer1.Checked = true; break;
                case 2: rdAnswer2.Checked = true; break;
                case 3: rdAnswer3.Checked = true; break;
                case 4: rdAnswer4.Checked = true; break;
            }

            btnFinish.Text = "Chỉnh sửa";
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            btnFinishClicked = true;

            int rdIndex = 0;
            int correctAnswer = 0;
            // test missing
            List<string> list = new List<string>();

            if (txtAnswer1.Text != "")
            {
                list.Add(txtAnswer1.Text);
                rdIndex++;
                if (rdAnswer1.Checked)
                    correctAnswer = rdIndex;
            }

            if (txtAnswer2.Text != "")
            {
                list.Add(txtAnswer2.Text);
                rdIndex++;
                if (rdAnswer2.Checked)
                    correctAnswer = rdIndex;
            }

            if (txtAnswer3.Text != "")
            {
                list.Add(txtAnswer3.Text);
                rdIndex++;
                if (rdAnswer3.Checked)
                    correctAnswer = rdIndex;
            }

            if (txtAnswer4.Text != "")
            {
                list.Add(txtAnswer4.Text);
                rdIndex++;
                if (rdAnswer4.Checked)
                    correctAnswer = rdIndex;
            }

            //MessageBox.Show((txtAnswer1.Text == "").ToString());

            if (!Utils.IsValidQuestion(
                txtQuestion,
                txtAnswer1, rdAnswer1,
                txtAnswer2, rdAnswer2,
                txtAnswer3, rdAnswer3,
                txtAnswer4, rdAnswer4))
                return;
                

            Question_DTO newQuestion = new Question_DTO(
                txtQuestion.Text,
                list,
                correctAnswer,
                true,
                idSubject);

            if (btnFinish.Text == "Chỉnh sửa")
            {
                Question_DTO adjustedQuestion = oldQuestion_dto;

                if (newQuestion.Question == adjustedQuestion.Question)
                    adjustedQuestion.Question = "";
                else
                    adjustedQuestion.Question = newQuestion.Question;

                for (int i = 0; i < adjustedQuestion.Answers.Count; i++)
                {
                    if (newQuestion.Answers[i] == adjustedQuestion.Answers[i])
                        adjustedQuestion.Answers[i] = "";
                    else
                        adjustedQuestion.Answers[i] = newQuestion.Answers[i];
                }
                //if (newQuestion.Answers.SequenceEqual(adjustedQuestion.Answers))
                if (newQuestion.CorrectAnswer == adjustedQuestion.CorrectAnswer)
                    adjustedQuestion.CorrectAnswer = -1;
                else
                    adjustedQuestion.CorrectAnswer = newQuestion.CorrectAnswer;
                //if (newQuestion.IdSubject == adjustedQuestion.IdSubject)
                //    adjustedQuestion.IdSubject = "";
                // MessageBox.Show(oldQuestion_dto.Question.ToString() + " " + adjustedQuestion.Question.ToString());
                
                if (question_bus.adjustQuestion(adjustedQuestion))
                    MessageBox.Show("Adjust successfully!");
                else
                    MessageBox.Show("Adjust unsuccessfully!");
            }
            else
            {
                if (question_bus.addQuestion(newQuestion))
                    MessageBox.Show("Add successfully!");
                else
                    MessageBox.Show("Add unsuccessfully!");
            }

            Dispose();
        }

        private void PopupQuestionForm_Load(object sender, EventArgs e)
        {

        }

        private void txtQuestion_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rdAnswer2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PopupQuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (btnFinishClicked)
                DialogResult = DialogResult.OK;
        }
    }
}
