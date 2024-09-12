using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace QuestionBank_GUI
{
    public class Score
    {
        public int diemID, lopHocMonHocID;
        public string mssv,loaiDiem;
        public float diem;
        public Score() { }

        static public bool insert(string mssv, float diem, int lopMonHocID, string loaiDiem)
        {
            SqlCommand sqlCommand;//cap nhat csdl
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "insert into Diem(diem,loai_diem,id_sv,id_Lop_MonHoc) values (@diem,@loaiDiem,@mssv,@lopHocMonHocID)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@diem",diem);
                sqlCommand.Parameters.AddWithValue("@loaiDiem", loaiDiem);
                sqlCommand.Parameters.AddWithValue("@mssv", mssv);
                sqlCommand.Parameters.AddWithValue("@lopHocMonHocID", lopMonHocID);
                sqlCommand.ExecuteNonQuery();//Thuc thi lenh them
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        static public bool update(int diemID,float diem ,string loaiDiem)
        {
            SqlCommand sqlCommand;//cap nhat csdl
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "update Diem set diem = @diem, loai_diem = @loaiDiem where id_diem = @diemID";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@diem", diem);
                sqlCommand.Parameters.AddWithValue("@loaiDiem", loaiDiem);
                sqlCommand.Parameters.AddWithValue("@diemID", diemID);
                sqlCommand.ExecuteNonQuery();//Thuc thi lenh them
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        static public bool delete(int diemID)
        {
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "DELETE FROM Diem WHERE id_diem = @diemID";
            try
            {
                SqlCommand sqlCommand;//cap nhat csdl
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@diemID",diemID);
                sqlCommand.ExecuteNonQuery();//Thuc thi lenh them
            }
            catch
            {
                return false;
            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }
        static public SqlDataReader getStudentScore(string sinhVienID,SqlConnection sqlConnection)
        {
            String query = "select id_Lop_MonHoc as N'ID',ten_mon_hoc as N'Tên môn học', ten_lop as N'Tên lớp', diem as N'Điểm', ngay_bat_dau as N'ngày mở lớp' " +
                "from Diem left join LopHoc_MonHoc on LopHoc_MonHoc.id_LopHoc_MonHoc = Diem.id_Lop_MonHoc " +
                "join MonHoc on MonHoc.id_MonHoc = LopHoc_MonHoc.id_MonHoc " +
                "join Lop on Lop.id_Lop = LopHoc_MonHoc.id_LopHoc " +
                "where id_sv = @mssv " +
                "order by id_Lop_MonHoc";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@mssv", sinhVienID);
            return sqlCommand.ExecuteReader();
        }
        static public SqlDataReader getStudentScoreBySemeter(string sinhVienID,string hocKy,int namHoc ,SqlConnection sqlConnection)
        {
            String query = "select id_Lop_MonHoc as N'ID',ten_mon_hoc as N'Tên môn học', ten_lop as N'Tên lớp', diem as N'Điểm', ngay_bat_dau as N'ngày mở lớp' from Diem left join LopHoc_MonHoc on LopHoc_MonHoc.id_LopHoc_MonHoc = Diem.id_Lop_MonHoc join MonHoc on MonHoc.id_MonHoc = LopHoc_MonHoc.id_MonHoc join Lop on Lop.id_Lop = LopHoc_MonHoc.id_LopHoc where id_sv =@mssv";
            switch (hocKy)
            {
                case "HK1":
                    query += " and DATEPART(year,ngay_bat_dau)=@namHoc and (DATEPART(month, ngay_bat_dau) >= 11 OR DATEPART(month, ngay_bat_dau) <= 2)";
                    break;
                case "HK2":
                    query += " and DATEPART(year,ngay_bat_dau)=@namHoc and (DATEPART(month, ngay_bat_dau) > 2 and DATEPART(month, ngay_bat_dau) <= 6)";
                    break;
                case "HK3":
                    query += " and DATEPART(year,ngay_bat_dau)=@namHoc and (DATEPART(month, ngay_bat_dau) > 6 and DATEPART(month, ngay_bat_dau) <= 10)";
                    break;
            }
            query += " order by id_Lop_MonHoc";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@mssv", sinhVienID.ToString()); // chuyển id thành chuỗi
            sqlCommand.Parameters.AddWithValue("@namHoc", namHoc);
            return sqlCommand.ExecuteReader();
        }
    }
}
