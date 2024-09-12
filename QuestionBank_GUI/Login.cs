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
using BCrypt.Net;
using QuestionBank_DTO;
using System.Threading;

namespace QuestionBank_GUI
{
    public partial class Login : Form
    {
        private Login_BUS loginBUS;
        public Login()
        {
            InitializeComponent();
            loginBUS = new Login_BUS();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string userRole = cmbUserRole.SelectedItem as string;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(userRole))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập!");
                return;
            }

            // Thực hiện kiểm tra đăng nhập
            Manage_Users_DTO user = loginBUS.XacThucDangNhap(username, password, userRole);
            
            if (user != null)
            {
                switch (userRole)
                {
                    case "Sinh viên":
                        // Hiển thị trang chủ của sinh viên
                        HomePage_Student studentHomePage = new HomePage_Student(user);
                        studentHomePage.Show();
                        Hide();
                        break;
                    case "Giảng viên":
                        // Hiển thị trang chủ của giảng viên
                        HomePage_Teacher teacherHomePage = new HomePage_Teacher(user);
                        teacherHomePage.Show();
                        Hide();
                        break;
                    case "Admin":
                        // Hiển thị trang chủ của admin
                        HomePage_Admin adminHomePage = new HomePage_Admin(user);
                        adminHomePage.Show();
                        Hide();
                        break;
                    default:
                        MessageBox.Show("Vai trò không hợp lệ!");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            cmbUserRole.SelectedIndex = 1;
        }

        private void cmbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoginByKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, new EventArgs());
        }
        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            LoginByKeyDown(sender, e);
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            LoginByKeyDown(sender, e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            LoginByKeyDown(sender, e);
        }

        private void btnLogin_KeyDown(object sender, KeyEventArgs e)
        {
            LoginByKeyDown(sender, e);
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
