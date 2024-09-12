using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace QuestionBank_GUI
{
    public partial class CreateScheduleForm : Form
    {
        public static Schedule scheduleCreated;
        public CreateScheduleForm()
        {
            InitializeComponent();
        }
        void LoadShiftToComboBox()
        {
            try
            {
                cbCaThi.DataSource = Shift.getAllShift();
                cbCaThi.DisplayMember = "id_CaThi";
                cbCaThi.ValueMember = "id_CaThi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void loadClassSubjectToCombobox()
        {
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlDataReader reader = ClassSubject.getAllClassSubject(connection))
                {
                    if (reader.HasRows)
                    {

                        // Đọc từng dòng dữ liệu
                        while (reader.Read())
                        {
                            // Lấy giá trị từ cột column_name và thêm vào danh sách
                            int indexMaMon = reader.GetOrdinal("Mã môn");
                            int indexMaLop = reader.GetOrdinal("Mã lớp");
                            int indexID = reader.GetOrdinal("ID");
                            // Chỉ số 0 là chỉ số của cột
                            string item = reader.GetInt32(indexID).ToString() + "| Mã môn:" + reader.GetString(indexMaMon) + "| Mã lớp:" + reader.GetString(indexMaLop);
                            cbLopHocMonHoc.Items.Add(item);

                        }
                    }

                }
            }
        }

        private void CreateScheduleForm_Load(object sender, EventArgs e)
        {
            LoadShiftToComboBox();
            loadClassSubjectToCombobox();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            scheduleCreated = null;
            TimeSpan difference = dateNgayThi.Value - DateTime.Now;
            int daysDifference = Math.Abs(difference.Days);
            if (cbLopHocMonHoc.Text == "")
            {
                MessageBox.Show("Chưa chọn lớp thi");
                return;
            }
            if (dateNgayThi.Value > DateTime.Now && daysDifference >= 30)
            {
                int caThi = cbCaThi.SelectedIndex + 1;
                int lopHocMonHocID = int.Parse(cbLopHocMonHoc.Text.Substring(0,1));
                DateTime thoiGianThi;
                if (DateTime.TryParseExact(txtThoiGianThi.Text, "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out thoiGianThi))
                {
                    scheduleCreated = new Schedule(caThi, rtxtQuyCheThi.Text, thoiGianThi, dateNgayThi.Value, lopHocMonHocID, int.Parse(txtQuesNum.Text));
                    if (Schedule.insert(scheduleCreated))
                    {
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Thời gian thi phải theo đinh dạng HH:mm:ss");
                }
            }
            else
            {
                MessageBox.Show("Ngày thi phải trễ hơn ngày hiện tại ít nhất 30 ngày");
            }    
        }

        private void cbMaLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCaThi_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dateNgayThi_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}
