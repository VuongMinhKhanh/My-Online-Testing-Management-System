using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace QuestionBank_GUI
{
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }

        public string MaMonVD = "";
        public string MaLopVD = "";
        void LoadSemeterToComboBox()
        {
            try
            {
                cbHocKy.DataSource = Semeter.getAllSemeter();
                cbHocKy.DisplayMember = "id_HocKy";
                cbHocKy.ValueMember = "id_HocKy";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void loadSchedule()
        {
            try
            {
                LoadSemeterToComboBox();
                dataGridViewSchedule.DataSource = Schedule.getAllSchedule();
                dataGridViewSchedule.Columns["Lịch thi"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Find(object sender, EventArgs e)
        {
            string maMon = txtMaMon.Text.Trim();
            string maLop = txtMaLop.Text.Trim();
            string hocKy = cbHocKy.Text;
            string[] arr = hocKy.Split('-');
            int namHoc = int.Parse(arr[1]);
            if (maMon == MaMonVD)
                maMon = "";
            if (maLop == MaLopVD)
                maLop = "";
            SqlDataAdapter dataAdapter;
            DataTable dataTable = new DataTable();
            if (checkBoxHocKy.Checked || checkBoxMaLop.Checked || checkBoxMaMon.Checked)
                using (SqlConnection sqlConnection = Connection.GetConnection())
                {
                    sqlConnection.Open();
                    string query = "select id_LichThi as N'Lịch thi', ten_mon_hoc as N'Tên môn học',ngay_thi as N'Ngày thi',thoi_gian_thi as N'Thời gian thi',id_CaThi as N'Ca thi', so_cau as N'Số câu',id_LopHoc as N'Mã lớp', LopHoc_MonHoc.id_MonHoc as N'Mã môn', quy_che_thi as N'Quy chế thi' " +
                        "from LichThi left join LopHoc_MonHoc on LichThi.id_LopHoc_MonHoc = LopHoc_MonHoc.id_LopHoc_MonHoc " +
                        "join MonHoc on MonHoc.id_MonHoc = LopHoc_MonHoc.id_MonHoc ";
                    if (checkBoxHocKy.Checked)
                        switch (arr[0])
                        {
                            case "HK1":
                                query += " and DATEPART(year,ngay_thi)=@namHoc and (DATEPART(month, ngay_thi) >= 11 OR DATEPART(month, ngay_thi) <= 2)";
                                break;
                            case "HK2":
                                query += " and DATEPART(year,ngay_thi)=@namHoc and (DATEPART(month, ngay_thi) > 2 and DATEPART(month, ngay_thi) <= 6)";
                                break;
                            case "HK3":
                                query += " and DATEPART(year,ngay_thi)=@namHoc and (DATEPART(month, ngay_thi) > 6 and DATEPART(month, ngay_thi) <= 10)";
                                break;
                        }
                    if (checkBoxMaLop.Checked) query += " and LopHoc_MonHoc.id_LopHoc like @maLop";
                    if (checkBoxMaMon.Checked) query += " and LopHoc_MonHoc.id_MonHoc like @maMon";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    if (checkBoxMaLop.Checked) sqlCommand.Parameters.AddWithValue("@maLop", "%" + maLop + "%");
                    if (checkBoxMaMon.Checked) sqlCommand.Parameters.AddWithValue("@maMon", "%" + maMon + "%");
                    if (checkBoxHocKy.Checked) sqlCommand.Parameters.AddWithValue("@namHoc", namHoc);
                    dataAdapter = new SqlDataAdapter(sqlCommand);
                    dataAdapter.Fill(dataTable);
                    dataGridViewSchedule.DataSource = dataTable;
                }
        }
        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            loadSchedule();
            txtMaLop.TextChanged += Find;
            txtMaMon.TextChanged += Find;
            cbHocKy.SelectedIndexChanged += Find;
        }

        private void txtMaMon_Enter(object sender, EventArgs e)
        {
            //TextBox t = (TextBox)sender;
            //if (t.Text == MaMonVD || t.Text == MaLopVD)
            //    t.Text = "";
            //t.ForeColor = System.Drawing.Color.Black;
        }

        private void txtMaMon_Leave(object sender, EventArgs e)
        {
            //TextBox t = (TextBox)sender;
            //if (t.Text == "")
            //{
            //    t.ForeColor = System.Drawing.Color.DarkGray;
            //    switch (t.Name)
            //    {
            //        case "txtMaMon":
            //            t.Text = MaMonVD;
            //            break;
            //        case "txtMaLop":
            //            t.Text = MaLopVD;
            //            break;
            //    }
            //}
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            CreateScheduleForm f = new CreateScheduleForm();
            f.ShowDialog();
            loadSchedule();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa lịch thi này?", "Cảnh báo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dataGridViewSchedule.SelectedRows)
                {
                    if(dataGridViewSchedule.Rows[row.Index].Cells[0].Value!=null)
                    {
                        Schedule.delete(int.Parse(dataGridViewSchedule.Rows[row.Index].Cells[0].Value.ToString()));
                        dataGridViewSchedule.Rows.Remove(row);
                    }    
                }
            }
        }
        private void btEdit_Click(object sender, EventArgs e)
        {
            EditScheduleForm f = new EditScheduleForm();
            EditScheduleForm.scheduleEdit = new Schedule();
            foreach (DataGridViewRow row in dataGridViewSchedule.SelectedRows)
            {
                if (dataGridViewSchedule.Rows[row.Index].Cells[0].Value != null)
                {
                    EditScheduleForm.scheduleEdit.LichThiID = int.Parse(dataGridViewSchedule.Rows[row.Index].Cells["Lịch thi"].Value.ToString());
                    EditScheduleForm.scheduleEdit.NgayThi = DateTime.Parse(dataGridViewSchedule.Rows[row.Index].Cells["Ngày thi"].Value.ToString());
                    EditScheduleForm.scheduleEdit.ThoiGianThi = DateTime.Parse(dataGridViewSchedule.Rows[row.Index].Cells["Thời gian thi"].Value.ToString());
                    EditScheduleForm.scheduleEdit.QuyCheThi = dataGridViewSchedule.Rows[row.Index].Cells["Quy chế thi"].Value.ToString();
                    EditScheduleForm.scheduleEdit.CaThiID = int.Parse(dataGridViewSchedule.Rows[row.Index].Cells["Ca thi"].Value.ToString());
                    EditScheduleForm.scheduleEdit.LopHocMonHocID = Schedule.getLopHocMonHocIDByLichThiID(EditScheduleForm.scheduleEdit.LichThiID);
                    EditScheduleForm.scheduleEdit.QuestionNumber = int.Parse(dataGridViewSchedule.Rows[row.Index].Cells["Số câu"].Value.ToString());
                }  
                else
                {
                    return;
                }    
            }
            f.ShowDialog();
            if (EditScheduleForm.scheduleEdit != null)
            {
                EditScheduleForm.scheduleEdit = null;
                loadSchedule();
            }
        }

        private void txtMaLop_TextChanged(object sender, EventArgs e)
        {

        }
    }
}