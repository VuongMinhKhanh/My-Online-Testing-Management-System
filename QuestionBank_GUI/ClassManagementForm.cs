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

namespace QuestionBank_GUI
{
    public partial class ClassManagementForm : Form
    {
        private string lecturerID = "3";
        // số lượng đổ ra dataGridViewClass
        const int SIZE = 4;
        // Trang hiện tại
        int currentPage = 1;
        int numOfPage;
        public ClassManagementForm()
        {
            InitializeComponent();
        }
        public ClassManagementForm(string lecturerId)
        {
            InitializeComponent();
            lecturerID = lecturerId;
        }
        private void loadTxtPage()
        {
            txtPage.Text = "Page "+ currentPage.ToString() + " of " + numOfPage.ToString();
        }
        private void UpdateDataGridView(string lecturerID,int indexPage,int SIZE)
        {
            if (txtFind.Text == "")
            {
                numOfPage = Class.countClassByLopHocMonHocID(lecturerID, "", "") / SIZE + 1;
                dataGridViewClass.DataSource = Class.getAllClass(lecturerID, indexPage, SIZE);
            }    
            else
            {
                try
                {
                    string[] arr = txtFind.Text.Split('-');
                    numOfPage = Class.countClassByLopHocMonHocID(lecturerID, arr[0], arr[1]) / SIZE + 1;
                    dataGridViewClass.DataSource = Class.getAllClassByLopHocMonHocID(lecturerID, indexPage, SIZE, arr[0], arr[1]);

                }
                catch (System.IndexOutOfRangeException)
                {
                    MessageBox.Show("Nhập sai đinh dạng!");
                }
            }
            loadTxtPage();
        }
        private void ScoreManagedForm_Load(object sender, EventArgs e)
        {           
            UpdateDataGridView(lecturerID,currentPage,SIZE);
        }
        // Hàm để điều hướng đến trang trước
        private void btPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                UpdateDataGridView(lecturerID,currentPage,SIZE);
            }
        }
        // Hàm để điều hướng đến trang sau
        private void btNext_Click(object sender, EventArgs e)
        {
            if (currentPage < numOfPage)
            {
                currentPage++;
                UpdateDataGridView(lecturerID, currentPage, SIZE);
            }
        }
        //Tìm kiếm
        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            if (txtFind.TextLength>0)
            {
                //Load kết quả tìm kiếm ra dataGridViewSearchResult
                SqlDataAdapter dataAdapter;
                DataTable dataTable = new DataTable();
                string query = "select id_LopHoc as N'Mã lớp', LopHoc_MonHoc.id_MonHoc as N'Mã môn' from GiangVien left join LopHoc_MonHoc on GiangVien.id_GiangVien  = LopHoc_MonHoc.id_GiangVien join Lop on Lop.id_Lop = LopHoc_MonHoc.id_LopHoc join MonHoc on MonHoc.id_MonHoc = LopHoc_MonHoc.id_MonHoc where GiangVien.id_GiangVien = @giangVienID";
                query += " and (id_LopHoc like @kw or LopHoc_MonHoc.id_MonHoc like @kw)";
                using (SqlConnection sqlConnection = Connection.GetConnection())
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@giangVienID", lecturerID);
                    sqlCommand.Parameters.AddWithValue("@kw", "%"+txtFind.Text+"%");
                    dataAdapter = new SqlDataAdapter(sqlCommand);
                    dataAdapter.Fill(dataTable);
                    if(dataTable !=null && dataTable.Rows.Count>0)
                    {
                        dataGridViewSearchResult.DataSource = dataTable;
                        dataGridViewSearchResult.Height = dataGridViewSearchResult.Rows.Count * 30;
                    }    
                    else
                    {
                        dataGridViewSearchResult.Height = 0;
                    }    
                    sqlConnection.Close();
                }
            } 
            else
                dataGridViewSearchResult.Height = 0;
        }

        private void dataGridViewSearchResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtFind.Text = dataGridViewSearchResult.Rows[e.RowIndex].Cells["Mã lớp"].Value.ToString().Trim()+ "-" + dataGridViewSearchResult.Rows[e.RowIndex].Cells["Mã môn"].Value.ToString().Trim();
            dataGridViewSearchResult.Height = 0;
        }
        //nhấn nút tìm kiếm
        private void btFind_Click(object sender, EventArgs e)
        {               
                UpdateDataGridView(lecturerID, currentPage, SIZE);
        }

        private void btDetail_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewClass.SelectedRows)
            {
                if (dataGridViewClass.Rows[row.Index].Cells[0].Value != null)
                {
                    ClassListForm f = new ClassListForm();
                    ClassListForm.lopHocMonHocID = (int)dataGridViewClass.Rows[row.Index].Cells["ID"].Value;
                    f.StartPosition = FormStartPosition.CenterParent;
                    f.ShowDialog();
                }
            }
        }
    }
}
