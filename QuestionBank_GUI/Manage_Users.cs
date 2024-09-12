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
    public partial class Manage_Users : Form
    {
        private Manage_Users_BUS Manage_Users_BUS;
        public Manage_Users()
        {
            InitializeComponent();
            Manage_Users_BUS = new Manage_Users_BUS();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //string username = txtUsername.Text.Trim();
            //string password = txtPassword.Text.Trim();
            //string userRole = cboUserRole.SelectedItem.ToString();

            //if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(userRole))
            //{
            //    bool result = Manage_Users_BUS.AddUser(username, password, userRole);

            //    if (result)
            //    {
            //        MessageBox.Show("User added successfully.", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        // Sau khi thêm thành công, có thể làm mới danh sách người dùng hoặc các tác vụ khác cần thiết
            //    }
            //    else
            //    {
            //        MessageBox.Show("Username already exists!", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please enter username, password, and select user role.", "Add User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }


        private void btnEditUser_Click(object sender, EventArgs e)
        {
            //private void btnEditUser_Click(object sender, EventArgs e)
            //{
            //    int userId = int.Parse(txtUserID.Text); // Lấy userId từ control txtUserID
            //    string username = txtUsername.Text.Trim();
            //    string password = txtPassword.Text.Trim();
            //    string userRole = cboUserRole.SelectedItem.ToString();

            //    if (userId > 0 && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(userRole))
            //    {
            //        bool result = manage_Users_BUS.UpdateUser(userId, username, password, userRole);

            //        if (result)
            //        {
            //            MessageBox.Show("User updated successfully.", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            // Sau khi cập nhật thành công, có thể làm mới danh sách người dùng hoặc các tác vụ khác cần thiết
            //        }
            //        else
            //        {
            //            MessageBox.Show("Username already exists!", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Please enter valid user information.", "Edit User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}

        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            int userId;
            if (int.TryParse(txtUser.Text, out userId))
            {
                if (userId > 0)
                {
                    Manage_Users_BUS.DeleteUser(userId);
                    MessageBox.Show("Người dùng đã được xóa thành công.", "Xóa Người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Sau khi xóa thành công, có thể làm mới danh sách người dùng hoặc các tác vụ khác cần thiết
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập một ID người dùng hợp lệ.", "Xóa Người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một ID người dùng hợp lệ.", "Xóa Người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            if (txtUser.Text != "")
            {
                DataTable userTable = Manage_Users_BUS.GetUsersByID(txtUser.Text);
                if (userTable != null)
                {
                    dataGridViewUsers.DataSource = userTable;
                    // Hiển thị thông tin người dùng tìm được lên giao diện
                    //txtUsername.Text = user["Username"].ToString();
                    // Các thông tin khác có thể được hiển thị tương tự
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người dùng.", "Tìm kiếm Người dùng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Xóa thông tin người dùng trên giao diện (nếu có)
                    //txtUsername.Text = "";
                    // Các control khác có thể được xóa tương tự
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một ID người dùng hợp lệ.", "Tìm kiếm Người dùng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
