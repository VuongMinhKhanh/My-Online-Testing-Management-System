using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank_GUI
{
    public class Semeter
    {
        private string hocKyID;
        private int hocKy;
        private int namHoc;
        public Semeter() { }

        public Semeter(string hocKyID, int hocKy, int namHoc)
        {
            this.HocKyID = hocKyID;
            this.HocKy = hocKy;
            this.NamHoc = namHoc;
        }

        public string HocKyID { get => hocKyID; set => hocKyID = value; }
        public int HocKy { get => hocKy; set => hocKy = value; }
        public int NamHoc { get => namHoc; set => namHoc = value; }

        static public DataTable getAllSemeter()
        {
            SqlDataAdapter dataAdapter;
            DataTable dataTable = new DataTable();
            string query = "select * from HocKy order by nam_hoc DESC, hoc_ky DESC";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        static public DataTable getAllSemeter(string studentID)
        {
            SqlDataAdapter dataAdapter;
            SqlCommand sqlCommand;
            DataTable dataTable = new DataTable();
            string query = "select * from HocKy where nam_hoc >= (select nam_nhap_hoc from SinhVien where mssv = @mssv) order by nam_hoc DESC, hoc_ky DESC"; // lấy chuỗi '@mssv'
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@mssv", studentID.ToString()); //chuyển id thành chuỗi
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
    }
}
