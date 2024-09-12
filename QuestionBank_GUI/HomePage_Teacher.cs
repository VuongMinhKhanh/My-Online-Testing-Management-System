using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using QuestionBank_BUS;
using QuestionBank_DTO;

namespace QuestionBank_GUI
{
    public partial class HomePage_Teacher : Form
    {
        private HomePage_Teacher_BUS homePage_Teacher_BUS;
        private Manage_Users_DTO user;
        private SplitContainer splitContainer;
        public HomePage_Teacher()
        {
            InitializeComponent();
            homePage_Teacher_BUS = new HomePage_Teacher_BUS();
        }
        public HomePage_Teacher(Manage_Users_DTO user)
        {
            InitializeComponent();
            homePage_Teacher_BUS = new HomePage_Teacher_BUS();
            this.user = user;
        }

        // Xử lý sự kiện khi tab "Lịch thi" được chọn
        private void tabPageSchedule_Enter(object sender, EventArgs e)
        {
            // Gọi phương thức từ BUS để lấy thông tin lịch thi
            DataTable lichThi = homePage_Teacher_BUS.getLichThi();

            // Hiển thị thông tin lịch thi lên giao diện
            //dataGridViewSchedule.DataSource = lichThi; // Sửa tên dataGridView tương ứng
        }

        // Xử lý sự kiện khi tab "Đề thi" được chọn
      
        private void tabPageExams_Enter(object sender, EventArgs e)
        {
            // Gọi phương thức từ BUS để lấy thông tin đề thi
            DataTable deThi = homePage_Teacher_BUS.getDeThi();

            // Hiển thị thông tin đề thi lên giao diện
            listViewExams.Items.Clear();
            foreach (DataRow row in deThi.Rows)
            {
                string[] rowData = new string[row.ItemArray.Length];
                for (int i = 0; i < row.ItemArray.Length; i++)
                {
                    rowData[i] = row.ItemArray[i].ToString();
                }
                listViewExams.Items.Add(new ListViewItem(rowData));
            }
        }

        // Xử lý sự kiện khi tab "Đăng kí giám thị" được chọn
        private void tabPageInvigilatorRegistration_Enter(object sender, EventArgs e)
        {
            // Gọi phương thức từ BUS để lấy thông tin đăng kí giám thị
            DataTable dangKiGiamThi = homePage_Teacher_BUS.DangKiGiamThi();

            // Hiển thị thông tin đăng kí giám thị lên giao diện
            //dataGridViewInvigilatorRegistration.DataSource = dangKiGiamThi; // Sửa tên dataGridView tương ứng
        }

        private void HomePage_Teacher_Load(object sender, EventArgs e)
        {
            Text += user.FullName;

            Utils.AddUserHomeToTab(tabPageHome, new UserInfoForm(user));
        }

        private void HomePage_Teacher_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tabControlMain_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!tabPageExams.Controls.OfType<QuestionBankForm>().Any() && tabControlMain.SelectedTab.Text == "Quản lý đề thi")
                Utils.AddQuestionBankToTab(tabPageExams, user.UserId);

            if (!tabPageClass.Controls.OfType<ClassManagementForm>().Any() && tabControlMain.SelectedTab.Text == "Xem lớp")
            {
                ClassManagementForm scoreManagedForm = new ClassManagementForm(user.UserId);
                Utils.AddFormToTab(tabPageClass, scoreManagedForm);
            }

            if (!tabPageScoreView.Controls.OfType<StudentScoreResult>().Any() && tabControlMain.SelectedTab.Text == "Xem điểm")
            {
                splitContainer = new SplitContainer();
                splitContainer.Dock = DockStyle.Fill;
                splitContainer.SplitterDistance = splitContainer.Width / 2;
                splitContainer.IsSplitterFixed = true;
                tabPageScoreView.Controls.Add(splitContainer);

                Utils.AddStudentScoreToPanel(splitContainer);
                //Utils.AddStudentInfoToPanel(splitContainer.Panel2, "1");
            }
        }
    }
}
