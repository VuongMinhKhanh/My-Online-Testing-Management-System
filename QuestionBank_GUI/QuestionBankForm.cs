using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestionBank_BUS;
using QuestionBank_DTO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuestionBank_GUI
{
    public partial class QuestionBankForm : Form
    {
        private Subject_BUS subject_bus = new Subject_BUS();
        private Question_BUS question_bus = new Question_BUS();
        private DataRow[] drSubjects;
        private DataRow[] drQuestions;
        private string lecturerId;
        public QuestionBankForm()
        {
            InitializeComponent();
        }
        public QuestionBankForm(string userId)
        {
            InitializeComponent();
            lecturerId = userId;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            drSubjects = subject_bus.getId_Subjects(lecturerId).Select();
            Utils.LoadSubjects(cbSubject, drSubjects, "ten_mon_hoc");

            //cbSubject_SelectedIndexChanged(sender, e);
            cbSubject.SelectedIndex = 0;
            cbSubject.Tag = drSubjects[0]["id_MonHoc"];
            cbSubject.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbSubject.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PopupQuestionForm popUpForm = new PopupQuestionForm(cbSubject.Tag.ToString());
            popUpForm.ShowDialog();

            if (popUpForm.DialogResult == DialogResult.OK)
                ReloadQuestions();
            //MessageBox.Show("updated");
        }

        private void ReloadQuestions()
        {
            drQuestions = question_bus.getQuestions(cbSubject.Tag.ToString()).Select();
            Utils.LoadQuestions(listQuestion, drQuestions, "id_CauHoi", "cau_hoi", "cau_tra_loi", txtQuestionFilter.Text);
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSubject.SelectedIndex != -1)
                cbSubject.Tag = drSubjects[cbSubject.SelectedIndex]["id_MonHoc"];

            ReloadQuestions();
        }

        private Question_DTO GetQuestionFromPopUp()
        {
            int idQuestion = int.Parse(listQuestion.SelectedItems[0].Tag.ToString());

            DataRow[] drAnswers = question_bus.getAnswers(idQuestion).Select();
            DataRow[] drQuestion = question_bus.getQuestions(cbSubject.Tag.ToString()).Select($"id_CauHoi = {idQuestion}");

            return Utils.GetQuestion(drQuestion, drAnswers, cbSubject.Tag.ToString());
        }

        private void PopupQuestionForm()
        {
            Question_DTO question = GetQuestionFromPopUp();

            PopupQuestionForm popUpForm = new PopupQuestionForm(cbSubject.Tag.ToString(), question);
            popUpForm.ShowDialog();

            if (popUpForm.DialogResult == DialogResult.OK)
                ReloadQuestions();
            //popUpForm.Dispose();

        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            if (listQuestion.SelectedItems.Count > 0)
            {
                PopupQuestionForm();
            }
            else
            {
                MessageBox.Show("Please select a question");
            }
        }

        private void listQuestion_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PopupQuestionForm();

            //txtQuestionFilter_TextChanged(sender, e);

            ReloadQuestions();
            //MessageBox.Show("updated");
        }

        private void addDelete_Click(object sender, EventArgs e)
        {
            if (listQuestion.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Do you want to delete this record?",
                "Delete Warning!!!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Question_DTO question = GetQuestionFromPopUp();
                    //MessageBox.Show(question.IdQuestion
                    //    + " " + question.IdAnswers[0]
                    //    + " " + question.IdCorrectAnswer);
                    if (question_bus.deleteQuestion(question))
                    {
                        MessageBox.Show("Delete successfully!");

                        ReloadQuestions();
                    }
                }
            }
            else
                MessageBox.Show("Please select a question");
            
        }

        private void txtQuestionFilter_TextChanged(object sender, EventArgs e)
        {
            Utils.LoadQuestions(listQuestion, drQuestions, "id_CauHoi", "cau_hoi", "cau_tra_loi", txtQuestionFilter.Text);
        }
    }
}
