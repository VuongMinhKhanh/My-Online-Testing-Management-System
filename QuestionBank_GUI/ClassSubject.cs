using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank_GUI
{
    public class ClassSubject
    {
        int lopHocMonHocID;
        string lopHocID, monHocID;
        DateTime ngayBatDau;
        public ClassSubject() { }

        public ClassSubject(int lopHocMonHocID, string lopHocID, string monHocID, DateTime ngayBatDau)
        {
            this.lopHocMonHocID = lopHocMonHocID;
            this.lopHocID = lopHocID;
            this.monHocID = monHocID;
            this.ngayBatDau = ngayBatDau;
        }

        static public SqlDataReader getAllClassSubject(SqlConnection sqlConnection)
        {
            String query = "select LopHoc_MonHoc.id_LopHoc_MonHoc as N'ID' ,id_LopHoc as N'Mã lớp', id_MonHoc as N'Mã môn', so_cau as N'Số câu' , ngay_bat_dau as N'Ngày bắt đầu' " +
                "from LopHoc_MonHoc " +
                "full join LichThi on LichThi.id_LopHoc_MonHoc = LopHoc_MonHoc.id_LopHoc_MonHoc";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            return sqlCommand.ExecuteReader();
        }
        static public SqlDataReader getAllClassSubjectByID(int id,SqlConnection sqlConnection)
        {
            String query = "select LopHoc_MonHoc.id_LopHoc_MonHoc as N'ID' ,id_LopHoc as N'Mã lớp', id_MonHoc as N'Mã môn', so_cau as N'Số câu' , ngay_bat_dau as N'Ngày bắt đầu' " +
                "from LopHoc_MonHoc " +
                "join LichThi on LichThi.id_LopHoc_MonHoc = LopHoc_MonHoc.id_LopHoc_MonHoc " +
                "where LopHoc_MonHoc.id_LopHoc_MonHoc = @ID";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@ID", id);
            return sqlCommand.ExecuteReader();
        }
        static public DataTable getStudentFromClass(int lopHocMonHocID)
        {
            DataTable dataTable = new DataTable();
            string query = "select mssv N'MSSV',ho_ten as N'Họ và tên' from Lop left join LopHoc_MonHoc on Lop.id_Lop = LopHoc_MonHoc.id_LopHoc join SinhVien_DangKyMon on SinhVien_DangKyMon.id_Lop_MonHoc = LopHoc_MonHoc.id_LopHoc_MonHoc join NguoiDung on mssv = NguoiDung.id_user where id_Lop_MonHoc = @lopHocMonHocID order by id_Lop_MonHoc,mssv";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                SqlDataAdapter dataAdapter;
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@lopHocMonHocID", lopHocMonHocID);
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        static public DataTable getStudentFromClassByKw(int lopHocMonHocID,string kw)
        {
            DataTable dataTable = new DataTable();
            string query = "select mssv N'MSSV',ho_ten as N'Họ và tên' from Lop left join LopHoc_MonHoc on Lop.id_Lop = LopHoc_MonHoc.id_LopHoc join SinhVien_DangKyMon on SinhVien_DangKyMon.id_Lop_MonHoc = LopHoc_MonHoc.id_LopHoc_MonHoc join NguoiDung on mssv = NguoiDung.id_user where id_Lop_MonHoc = @lopHocMonHocID and (mssv like @kw or ho_ten like @kw)";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                SqlDataAdapter dataAdapter;
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@lopHocMonHocID", lopHocMonHocID);
                sqlCommand.Parameters.AddWithValue("@kw", "%"+kw+"%");
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
    }
}
