using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank_GUI
{
    public class Student
    {
        public int mssv,namNhapHoc;
        public Student()
        {
        }

        public Student(int mssv, int namNhapHoc)
        {
            this.mssv = mssv;
            this.namNhapHoc = namNhapHoc;
        }
        static public DataTable getScoreOfStudentFromClass(string mssv)
        {
            DataTable dataTable = new DataTable();
            //string query = "select id_diem as N'ID', diem as N'Điểm'" +
            //    " from SinhVien_DangKyMon" +
            //    " left join LopHoc_MonHoc on SinhVien_DangKyMon.id_Lop_MonHoc = LopHoc_MonHoc.id_LopHoc_MonHoc" +
            //    " join Diem on Diem.id_sv = SinhVien_DangKyMon.mssv and Diem.id_Lop_MonHoc = LopHoc_MonHoc.id_LopHoc_MonHoc" +
            //    " where mssv = @mssv and loai_diem=N'Điểm tổng'"; // and LopHoc_MonHoc.id_LopHoc_MonHoc = @lopHocMonHocID
            string query = "select ten_mon_hoc as N'Tên môn học', ten_lop as N'Tên lớp', diem as N'Điểm', ngay_bat_dau as N'ngày mở lớp' " +
                "from Diem left join LopHoc_MonHoc on LopHoc_MonHoc.id_LopHoc_MonHoc = Diem.id_Lop_MonHoc " +
                "join MonHoc on MonHoc.id_MonHoc = LopHoc_MonHoc.id_MonHoc " +
                "join Lop on Lop.id_Lop = LopHoc_MonHoc.id_LopHoc " +
                "where id_sv = @mssv " +
                "order by id_Lop_MonHoc";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                SqlDataAdapter dataAdapter;
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@mssv", mssv);
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
    }
}
