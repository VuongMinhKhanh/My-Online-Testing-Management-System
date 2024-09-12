using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;

namespace QuestionBank_GUI
{
    public partial class StudentScoreForm : Form
    {
        static public string studentID = "1";
        public StudentScoreForm()
        {
            InitializeComponent();
        }
        public StudentScoreForm(string userId)
        {
            InitializeComponent();
            studentID = userId;
        }

        void LoadSemeterToComboBox(string studentID)
        {           
            try
            {
                cbHocKy.DataSource = Semeter.getAllSemeter(studentID);
                cbHocKy.DisplayMember = "id_HocKy";
                cbHocKy.ValueMember = "id_HocKy";
                //cbHocKy.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void loadScore()
        {
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                SqlDataReader reader = Score.getStudentScore(studentID,sqlConnection);
                if (reader.HasRows)
                {
                    int indexTenMonHoc = reader.GetOrdinal("Tên môn học");
                    int indexTenLop = reader.GetOrdinal("Tên lớp");
                    int indexDiem = reader.GetOrdinal("Điểm");
                    int indexId = reader.GetOrdinal("ID");
                    while (reader.Read())
                    {
                        try
                        {
                            double diem = reader.GetDouble(indexDiem);
                            string tenMonHoc = reader.GetString(indexTenMonHoc);
                            string tenLop = reader.GetString(indexTenLop);
                            int id = reader.GetInt32(indexId);
                            dataGridViewScore.Rows.Add(new object[] { id, tenMonHoc, tenLop, diem });

                        }
                        catch (System.Data.SqlTypes.SqlNullValueException)
                        {
                            string tenMonHoc = reader.GetString(indexTenMonHoc);
                            string tenLop = reader.GetString(indexTenLop);
                            int id = reader.GetInt32(indexId);
                            dataGridViewScore.Rows.Add(new object[] { id, tenMonHoc, tenLop, "" });
                        }
                        
                    }
                }    
            }              
        }
        private void StudentScoreFrom_Load(object sender, EventArgs e)
        {
            loadScore();
            LoadSemeterToComboBox(studentID);
        }

        private void cbHocKy_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridViewScore.Rows.Clear();
            string hocKy = cbHocKy.Text;
            string[] arr = hocKy.Split('-');
            int namHoc = 2024;
            if (arr.Length >= 2)
            {
                namHoc = int.Parse(arr[1]);
                // Tiếp tục xử lý namHoc...
            }
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                SqlDataReader reader = Score.getStudentScoreBySemeter(studentID, arr[0], namHoc, sqlConnection);
                if (reader.HasRows)
                {
                    int indexTenMonHoc = reader.GetOrdinal("Tên môn học");
                    int indexTenLop = reader.GetOrdinal("Tên lớp");
                    int indexDiem = reader.GetOrdinal("Điểm");
                    int indexId = reader.GetOrdinal("ID");
                    while (reader.Read())
                    {
                        try
                        {
                            double diem = reader.GetDouble(indexDiem);
                            string tenMonHoc = reader.GetString(indexTenMonHoc);
                            string tenLop = reader.GetString(indexTenLop);
                            int id = reader.GetInt32(indexId);
                            dataGridViewScore.Rows.Add(new object[] { id, tenMonHoc, tenLop, diem });

                        }
                        catch (System.Data.SqlTypes.SqlNullValueException)
                        {
                            string tenMonHoc = reader.GetString(indexTenMonHoc);
                            string tenLop = reader.GetString(indexTenLop);
                            int id = reader.GetInt32(indexId);
                            dataGridViewScore.Rows.Add(new object[] { id, tenMonHoc, tenLop, "" });
                        }

                    }
                }
            }
        }

        private void dataGridViewScore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
