using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Drawing;

namespace QuestionBank_GUI
{
    public class Class
    {
        private string lopID, tenLop, tinhTrangLop;
        private int siSo;
        public Class() { }

        public Class(string lopID, string tenLop, string tinhTrangLop, int siSo)
        {
            LopID = lopID;
            TenLop = tenLop;
            TinhTrangLop = tinhTrangLop;
            SiSo = siSo;
        }

        public string LopID { get => lopID; set => lopID = value; }
        public string TenLop { get => tenLop; set => tenLop = value; }
        public string TinhTrangLop { get => tinhTrangLop; set => tinhTrangLop = value; }
        public int SiSo { get => siSo; set => siSo = value; }

        static public DataTable getAllClass(string giangVienID, int indexPage, int size)
        {
            //size là số lượng đổ ra
            // indexPage là thứ tự trang
            SqlDataAdapter dataAdapter;
            DataTable dataTable = new DataTable();
            string query = "select id_LopHoc_MonHoc as N'ID', id_LopHoc as N'Mã lớp', LopHoc_MonHoc.id_MonHoc as N'Mã môn', ten_mon_hoc as N'Tên môn học' , ngay_bat_dau as N'Ngày mở' from GiangVien left join LopHoc_MonHoc on GiangVien.id_GiangVien  = LopHoc_MonHoc.id_GiangVien join Lop on Lop.id_Lop = LopHoc_MonHoc.id_LopHoc join MonHoc on MonHoc.id_MonHoc = LopHoc_MonHoc.id_MonHoc where GiangVien.id_GiangVien = @giangVienID order by ngay_bat_dau DESC, id_LopHoc OFFSET @page ROWS FETCH NEXT @size ROWS ONLY";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@giangVienID",giangVienID);
                sqlCommand.Parameters.AddWithValue("@page", (indexPage-1)*size);
                sqlCommand.Parameters.AddWithValue("@size", size);
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        static public DataTable getAllClassByLopHocMonHocID(string giangVienID, int indexPage, int size,string maLop,string maMon)
        {
            //size là số lượng đổ ra
            // indexPage là thứ tự trang
            SqlDataAdapter dataAdapter;
            DataTable dataTable = new DataTable();
            string query = "select id_LopHoc_MonHoc as N'ID', id_LopHoc as N'Mã lớp', LopHoc_MonHoc.id_MonHoc as N'Mã môn', ten_mon_hoc as N'Tên môn học' , ngay_bat_dau as N'Ngày mở' from GiangVien left join LopHoc_MonHoc on GiangVien.id_GiangVien  = LopHoc_MonHoc.id_GiangVien join Lop on Lop.id_Lop = LopHoc_MonHoc.id_LopHoc join MonHoc on MonHoc.id_MonHoc = LopHoc_MonHoc.id_MonHoc where GiangVien.id_GiangVien = @giangVienID";
            query += " and (id_LopHoc like @maLop and LopHoc_MonHoc.id_MonHoc like @maMon)";
            query += " order by ngay_bat_dau DESC, id_LopHoc";
            query+=" OFFSET @page ROWS FETCH NEXT @size ROWS ONLY";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@giangVienID", giangVienID);
                sqlCommand.Parameters.AddWithValue("@maLop","%"+maLop+"%");
                sqlCommand.Parameters.AddWithValue("@maMon", "%" + maMon + "%");
                sqlCommand.Parameters.AddWithValue("@page", (indexPage - 1) * size);
                sqlCommand.Parameters.AddWithValue("@size", size);
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        static public int countClassByLopHocMonHocID(string giangVienID, string maLop, string maMon)
        {
            //size là số lượng đổ ra
            // indexPage là thứ tự trang
            DataTable dataTable = new DataTable();
            string query = "select count(LopHoc_MonHoc.id_LopHoc_MonHoc) from GiangVien left join LopHoc_MonHoc on GiangVien.id_GiangVien  = LopHoc_MonHoc.id_GiangVien where GiangVien.id_GiangVien = @giangVienID";
            query += " and (id_LopHoc like @maLop and LopHoc_MonHoc.id_MonHoc like @maMon)";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@giangVienID", giangVienID);
                sqlCommand.Parameters.AddWithValue("@maLop", "%" + maLop + "%");
                sqlCommand.Parameters.AddWithValue("@maMon", "%" + maMon + "%");
                return (int)sqlCommand.ExecuteScalar();
            }
        }   
    }
}
