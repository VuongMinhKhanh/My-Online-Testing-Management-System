using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using QuestionBank_DTO;
using QuestionBank_BUS;

namespace QuestionBank_GUI
{
    public partial class StudentScoreResult : Form
    {
        static public string mssv = "1";
        static public int lopHocMonHocID = 7;
        static public string hoTen = "";
        ToastMessageForm f;
        private Panel splitPanel;
        private Manage_Users_BUS users_BUS = new Manage_Users_BUS(); 
        public StudentScoreResult()
        {
            InitializeComponent();
        }
        public StudentScoreResult(Panel splitPanel)
        {
            InitializeComponent();
            this.splitPanel = splitPanel;
        }
        //lấy danh sách điểm của sinh viên
        private void loadStudentScore(string studentId)
        {
            //StudentScoreForm studentScoreForm = new StudentScoreForm(student.UserId);
            dataGridViewScore.DataSource = Student.getScoreOfStudentFromClass(studentId);
        }
        private void StudentScoreResult_Load(object sender, EventArgs e)
        {
            //txtHoTen.Text = hoTen;
            //txtMSSV.Text = mssv;
            //gbModify.Tag = null;
            //gbModify.Visible = false;
            //loadStudentScore();
        }
        //HÀM THÔNG BÁO 
        private void Notice(string title, string message, Color color,int icon)
        {
            ToastMessageForm.title = title;
            ToastMessageForm.message = message;
            ToastMessageForm.borderColor = color;
            ToastMessageForm.icon = icon;
            f = new ToastMessageForm();
            f.Show();
            timerShowMessage.Start();
        }
        //  BẤM NÚT THOÁT
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //BẤM NÚT ADD
        private void btAdd_Click(object sender, EventArgs e)
        {
            gbModify.Tag = "ADD";
            gbModify.Visible = true;
            gbModify.Text = "Thêm";
        }
        bool isScrore()
        {
            return float.Parse(txtDiem.Text) >= 0 && float.Parse(txtDiem.Text) <= 10 ? true : false;
        }
        //HÀM THÊM ĐIỂM
        private void Add()
        {
            try
            {
                if (isScrore())
                {
                    if (Score.insert(mssv, float.Parse(txtDiem.Text), lopHocMonHocID, txtLoaiDiem.Text))
                    {
                        Notice("Thêm thành công", "Thêm thành công điểm", Color.FromArgb(51, 153, 0), 1);
                        //loadStudentScore(student.UserId);
                    }
                }
                else
                    throw new FormatException();
                    
            }
            catch (System.FormatException)
            {
                Notice("Thêm thất bại", "Nhập điểm không được là số âm và bé hơn bằng 10", Color.FromArgb(226, 27, 27),0);
            }

        }
        //HÀM SỬA ĐIỂM
        private void Edit()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridViewScore.SelectedRows)
                {
                    if (dataGridViewScore.Rows[row.Index].Cells[0].Value != null)
                    {
                        if (isScrore())
                        {
                            if (Score.update(int.Parse(dataGridViewScore.Rows[row.Index].Cells["ID"].Value.ToString()), float.Parse(txtDiem.Text), txtLoaiDiem.Text))
                            {
                                Notice("Sửa thành công", "Sửa thành công điểm", Color.FromArgb(51, 153, 0), 1);
                                //loadStudentScore(student.UserId);
                            }
                        }    
                        else
                            throw new FormatException();
                        
                    }
                }
            }
            catch (FormatException)
            {
                Notice("Sửa thất bại", "Sửa điểm thất bại", Color.FromArgb(226, 27, 27),0);
            }

        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            gbModify.Tag = "Edit";
            gbModify.Visible = true;
            gbModify.Text = "Chỉnh sửa";
        }
        //BẤM NÚT SAVE
        private void btSave_Click(object sender, EventArgs e)
        {
            if (gbModify.Visible == true)
            if (txtDiem.Text != "" && txtLoaiDiem.Text != "")
            {
                switch (gbModify.Tag)
                {
                    case "ADD":
                        Add();                       
                        break;
                    case "Edit":
                        Edit();
                        break;
                }
                txtDiem.Text = "";
                txtLoaiDiem.Text = "";
                gbModify.Tag = null;
                gbModify.Visible = false;
                }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa điểm thi này?", "Cảnh báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewScore.SelectedRows)
                {
                    if (dataGridViewScore.Rows[row.Index].Cells[0].Value != null)
                    {
                        Score.delete(int.Parse(dataGridViewScore.Rows[row.Index].Cells["ID"].Value.ToString()));
                        dataGridViewScore.Rows.Remove(row);
                        Notice("Xóa thành công", "Xóa thành công điểm", Color.FromArgb(51, 153, 0),1);
                    }
                    else
                    {
                        Notice("Xóa thất bại", "Xóa điểm thất bại", Color.FromArgb(226, 27, 27),0);
                    }    
                }
            }
        }

        private void timerShowMessage_Tick(object sender, EventArgs e)
        {
            timerShowMessage.Stop();
            f.Close();
            f.Dispose();
            f = null;
        }

        private void StudentScoreResult_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void StudentScoreResult_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMSSV_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Manage_Users_DTO tempUser = users_BUS.GetUserById(txtMSSV.Text);
                //MessageBox.Show((tempUser == null).ToString());
                if (tempUser != null)
                {
                    loadStudentScore(txtMSSV.Text);
                    if (splitPanel != null)
                    {
                        foreach (Control control in splitPanel.Controls)
                        {
                            if (control is UserInfoForm form)
                            {
                                form.Close(); // Ensure the form is closed properly
                                form.Dispose(); // Dispose the form
                            }
                        }

                        Utils.AddStudentInfoToPanel(splitPanel, tempUser);
                    }

                }
                else
                {
                    MessageBox.Show("No student found");
                }
            }
        }
    }
}
