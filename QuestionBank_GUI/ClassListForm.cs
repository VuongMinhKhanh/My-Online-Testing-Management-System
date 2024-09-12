using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace QuestionBank_GUI
{
    public partial class ClassListForm : Form
    {
        public ClassListForm()
        {
            InitializeComponent();
        }
        static public int lopHocMonHocID;
        //load danh sách sinh viên
        private void loadStudentListByKeyword(string kw)
        {
            dataGridViewStudent.DataSource = ClassSubject.getStudentFromClassByKw(lopHocMonHocID, kw);
        }

        private void ClassListForm_Load(object sender, EventArgs e)
        {
            loadStudentListByKeyword(txtFind.Text);
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
                loadStudentListByKeyword(txtFind.Text);
        }

        private void btDetail_Click(object sender, EventArgs e)
        {           
            foreach (DataGridViewRow row in dataGridViewStudent.SelectedRows)
            {
                if (dataGridViewStudent.Rows[row.Index].Cells[0].Value != null)
                {
                    StudentScoreResult.lopHocMonHocID = lopHocMonHocID;
                    StudentScoreResult.mssv = dataGridViewStudent.Rows[row.Index].Cells["MSSV"].Value.ToString();
                    StudentScoreResult.hoTen = dataGridViewStudent.Rows[row.Index].Cells["Họ và tên"].Value.ToString();
                }
                else
                {
                    return;
                }
            }
            StudentScoreResult f = new StudentScoreResult();
            f.StartPosition = FormStartPosition.CenterParent;
            f.ShowDialog();
        }

        private void btFind_Click(object sender, EventArgs e)
        {

        }
    }
}
