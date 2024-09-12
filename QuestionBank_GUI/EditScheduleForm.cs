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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace QuestionBank_GUI
{
    public partial class EditScheduleForm : Form
    {
        public EditScheduleForm()
        {
            InitializeComponent();
        }
        public static Schedule scheduleEdit;

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
            using (SqlConnection connection = Connection.GetConnection())
            {
                connection.Open();
                using (SqlDataReader reader = ClassSubject.getAllClassSubjectByID(scheduleEdit.LopHocMonHocID, connection))
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
                            cbLopHocMonHoc.Text= reader.GetInt32(indexID).ToString() + "| Mã môn:" + reader.GetString(indexMaMon) + "| Mã lớp:" + reader.GetString(indexMaLop);
                        }
                    }

                }
            }
        }

        private void EditScheduleForm_Load(object sender, EventArgs e)
        {
            LoadShiftToComboBox();
            loadClassSubjectToCombobox();
            txtLichThi.Text = scheduleEdit.LichThiID.ToString();
            cbCaThi.Text = scheduleEdit.CaThiID.ToString();
            dateNgayThi.Value = scheduleEdit.NgayThi;
            rtxtQuyCheThi.Text = scheduleEdit.QuyCheThi;
            txtThoiGianThi.Text = scheduleEdit.ThoiGianThi.ToString("HH:mm:ss");
            txtQuesNum.Text = scheduleEdit.QuestionNumber.ToString();
        }

        private void btConfirm_Click_1(object sender, EventArgs e)
        {
            if (DateTime.Compare(scheduleEdit.NgayThi,dateNgayThi.Value)<=0)
            {
                int caThi = cbCaThi.SelectedIndex + 1;
                int lopHocMonHocID = int.Parse(cbLopHocMonHoc.Text.Substring(0, 1));
                try
                {
                    DateTime thoiGianThi;
                    if (DateTime.TryParseExact(txtThoiGianThi.Text, "HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out thoiGianThi))
                    {
                        scheduleEdit = new Schedule(caThi, rtxtQuyCheThi.Text, thoiGianThi, dateNgayThi.Value, lopHocMonHocID, int.Parse(txtQuesNum.Text));
                        scheduleEdit.LichThiID = int.Parse(txtLichThi.Text);
                        if (Schedule.update(scheduleEdit))
                        {
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại");
                        }
                    }  
                    else
                    {
                        MessageBox.Show("Thời gian thi theo định dạng HH:mm:ss");
                    }    
                }
                catch
                {
                    MessageBox.Show("Nhập theo format HH:mm:ss");
                }
            }
            else
            {
                MessageBox.Show("Giá trị ngày thi hiện tại phải trễ hơn hoặc bằng ngày thi ban đầu");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            scheduleEdit = null;
            Close();
        }
    }
}
