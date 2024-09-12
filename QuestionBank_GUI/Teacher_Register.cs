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
    public partial class Teacher_Register : Form
    {
        private Teacher_Register_BUS giamThiBUS = new Teacher_Register_BUS();
        public Teacher_Register()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            DateTime ngayThi = dateTimePickerNgayThi.Value;
            string caThi = txtCaThi.Text;

            Teacher_Register_DTO existingGiamThi = giamThiBUS.LayGiamThiTheoNgayVaCa(ngayThi, caThi);

            if (existingGiamThi != null)
            {
                MessageBox.Show("Có giảng viên đăng ký rồi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Teacher_Register_DTO giamThi = new Teacher_Register_DTO()
                {
                    GiangVienId = int.Parse(txtGiangVienId.Text),
                    NgayThi = ngayThi,
                    CaThi = caThi
                };
                giamThiBUS.ThemGiamThi(giamThi);
                MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
