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

namespace QuestionBank_GUI
{
    public partial class HomePage_Admin : Form
    {
        private HomePage_Admin_BUS HomePage_Admin_BUS;
        private Manage_Users_DTO user;
        public HomePage_Admin()
        {
            InitializeComponent();
            HomePage_Admin_BUS = new HomePage_Admin_BUS();
        }
        public HomePage_Admin(Manage_Users_DTO user)
        {
            InitializeComponent();
            HomePage_Admin_BUS = new HomePage_Admin_BUS();
            this.user = user;
        }
        private void tabPageInvigilators_Enter(object sender, EventArgs e)
        {
            DataTable danhSachGiamThi = HomePage_Admin_BUS.getDachSachGiamThi();
            // Hiển thị danh sách giám thị lên giao diện
            //dataGridViewInvigilators.DataSource = danhSachGiamThi;
        }
        private void tabPageSchedule_Enter(object sender, EventArgs e)
        {
            // Gọi phương thức từ BUS để lấy thông tin lịch thi
            DataTable lichThi = HomePage_Admin_BUS.getLichThi();

            // Hiển thị thông tin lịch thi lên giao diện
            //dataGridViewSchedule.DataSource = lichThi; // Sửa tên dataGridView tương ứng
        }

        private void tabPageExams_Enter(object sender, EventArgs e)
        {
            // Gọi phương thức từ BUS để lấy thông tin đề thi
            DataTable deThi = HomePage_Admin_BUS.getDanhSachDeThi();

            // Hiển thị thông tin đề thi lên giao diện
            //listViewExams.Items.Clear();
            //foreach (DataRow row in deThi.Rows)
            //{
            //    string[] rowData = new string[row.ItemArray.Length];
            //    for (int i = 0; i < row.ItemArray.Length; i++)
            //    {
            //        rowData[i] = row.ItemArray[i].ToString();
            //    }
            //    listViewExams.Items.Add(new ListViewItem(rowData));
            //}
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!tabPageSchedule.Controls.OfType<ScheduleForm>().Any() && tabControlMain.SelectedTab.Text == "Lịch thi") 
            {
                Utils.AddScheduleFormToPanel(tabPageSchedule);
            }

            if (!tabPageReports.Controls.OfType<StatsForm>().Any() && tabControlMain.SelectedTab.Text == "Báo cáo - Thống kê")
            {
                Utils.AddStatsFormToPanel(tabPageReports);
            }

            //if (!tabPageUserManagement.Controls.OfType<Manage_Users>().Any() && tabControlMain.SelectedTab.Text == "Người dùng")
            //{
            //    Manage_Users manage_Users = new Manage_Users();
            //    Utils.AddFormToTab(tabPageUserManagement, manage_Users);
            //}
            
        }

        private void HomePage_Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void HomePage_Admin_Load(object sender, EventArgs e)
        {
            if (user != null)
                Text += user.FullName;

            Utils.AddUserHomeToTab(tabPageHome, new UserInfoForm(user));
        }

        private void listViewExams_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // còn báo cáo thông kê ch xong
    }
}
