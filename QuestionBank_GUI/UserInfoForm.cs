using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestionBank_BUS;
using QuestionBank_DTO;

namespace QuestionBank_GUI
{
    public partial class UserInfoForm : Form
    {
        private Manage_Users_DTO user;
        public UserInfoForm()
        {
            InitializeComponent();

            EnableAllFields();
        }
        public UserInfoForm(Manage_Users_DTO user)
        {
            InitializeComponent();
            this.user = user;
            SetupForm();
        }
        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            
        }
        private void SetupForm()
        {
            txtUserId.Text = user.UserId;
            txtFullName.Text = user.FullName;
            txtAddress.Text = user.Address;
            txtPhone.Text =  user.Phone;
            dateTimeDOB.Value = user.DOB;
            txtUserRole.Text = user.UserRole;

            if (user.UserRole == "Admin")
            {
                //cbUserRole.SelectedIndex = 2;
                labelUserId.Text = "Admin ID";
            }
            else if (user.UserRole == "Giảng viên")
            {
                cbUserRole.SelectedIndex = 1;
                labelUserId.Text = "Giảng viên ID";
            }
            else
            {
                cbUserRole.SelectedIndex = 0;
                labelUserId.Text = "MSSV";
            }
        }
        private void EnableAllFields()
        {
            txtUserId.Enabled = true;
            txtFullName.Enabled = true;
            txtAddress.Enabled = true;
            txtPhone.Enabled = true;
            //cbUserRole.Enabled = true;
        }

        private void cbUserRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbUserRole.SelectedIndex == 2)
            //    labelUserId.Text = "Admin ID";
            //else if (cbUserRole.SelectedIndex == 1)
            //    labelUserId.Text = "Giảng viên ID";
            //else
            //    labelUserId.Text = "MSSV";
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //if (cbUserRole.SelectedIndex != -1 &&
            //    txtUserId.Text != "" &&
            //    txtFullName.Text != "" &&
            //    txtAddress.Text != "" &&
            //    txtPhone.Text != "")
            //{

            //    if (cbUserRole.SelectedIndex == 0)
            //    {

            //    }
            //}
        }

        private void cbUserRole_DropDown(object sender, EventArgs e)
        {
            ((ComboBox)sender).DroppedDown = false;
        }
    }
}
