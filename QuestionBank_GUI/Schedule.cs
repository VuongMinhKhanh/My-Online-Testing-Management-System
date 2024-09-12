using QuestionBank_GUI;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class Schedule
    {
        private int lichThiID;
        private int caThiID;
        private int lopHocMonHocID;
        private string quyCheThi;
        private DateTime thoiGianThi;
        private DateTime ngayThi;
        private int questionNumber;

        public Schedule()
        {  }

        public Schedule(int caThiID, string quyCheThi, DateTime thoiGianThi, DateTime ngayThi,int lopHocMonHocID, int questionNumber)
        {
            CaThiID = caThiID;
            QuyCheThi = quyCheThi;
            ThoiGianThi = thoiGianThi;
            NgayThi = ngayThi;
            LopHocMonHocID = lopHocMonHocID;
            this.questionNumber = questionNumber;
        }


        public int LichThiID { get => lichThiID; set => lichThiID = value; }
        public int CaThiID { get => caThiID; set => caThiID = value; }
        public string QuyCheThi { get => quyCheThi; set => quyCheThi = value; }
        public DateTime ThoiGianThi { get => thoiGianThi; set => thoiGianThi = value; }
        public DateTime NgayThi { get => ngayThi; set => ngayThi = value; }
        public int LopHocMonHocID { get => lopHocMonHocID; set => lopHocMonHocID = value; }
        public int QuestionNumber { get => questionNumber; set => questionNumber = value; }

        static public DataTable getAllSchedule()
        {
            SqlDataAdapter dataAdapter;//truy suat csdl
            DataTable dataTable = new DataTable();
            string query = "select id_LichThi as N'Lịch thi', ten_mon_hoc as N'Tên môn học',ngay_thi as N'Ngày thi',thoi_gian_thi as N'Thời gian thi',id_CaThi as N'Ca thi', so_cau as N'Số câu',id_LopHoc as N'Mã lớp', LopHoc_MonHoc.id_MonHoc as N'Mã môn', quy_che_thi as N'Quy chế thi' " +
                "from LichThi left join LopHoc_MonHoc on LichThi.id_LopHoc_MonHoc = LopHoc_MonHoc.id_LopHoc_MonHoc " +
                "join MonHoc on MonHoc.id_MonHoc = LopHoc_MonHoc.id_MonHoc ";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        static public SqlDataReader getScheduleByID(int id,SqlConnection sqlConnection)
        {
            
            string query = "select id_LichThi as 'Lịch thi', ten_mon_hoc as N'Tên môn học',ngay_thi as N'Ngày thi',thoi_gian_thi as N'Thời gian thi',LichThi.id_CaThi as N'Ca thi',id_LopHoc as N'Mã lớp', LopHoc_MonHoc.id_MonHoc as N'Mã môn', quy_che_thi as N'Quy chế thi', gio_bat_dau as N'Giờ bắt đầu' from LichThi left join CaThi on CaThi.id_CaThi = LichThi.id_CaThi join LopHoc_MonHoc on LichThi.id_LopHoc_MonHoc = LopHoc_MonHoc.id_LopHoc_MonHoc " +
                "join MonHoc on MonHoc.id_MonHoc = LopHoc_MonHoc.id_MonHoc " +
                "where id_LichThi=@lichThiID";
            SqlCommand sqlCommand = new SqlCommand(query,sqlConnection);
            sqlCommand.Parameters.AddWithValue("@lichThiID", id);
            return sqlCommand.ExecuteReader();
        }
        static public DataTable getAllSchedule(string studentID)
        {
            SqlDataAdapter dataAdapter;//truy suat csdl
            SqlCommand sqlCommand;//cap nhat csdl
            DataTable dataTable = new DataTable();
            string query = "Select ten_mon_hoc as N'Tên môn học', LopHoc_MonHoc.id_MonHoc as N'Mã môn', id_LopHoc as N'Mã lớp', ngay_thi as N'Ngày thi', so_cau as N'Số câu',CaThi.gio_bat_dau as N'Giờ bắt đầu',thoi_gian_thi as N'Thời gian thi', trang_thai as N'Tình trạng', id_Lop_MonHoc as N'idLop_Mon'" +
                " from SinhVien_DangKyMon left join LopHoc_MonHoc on SinhVien_DangKyMon.id_Lop_MonHoc = LopHoc_MonHoc.id_LopHoc_MonHoc" +
                " join LichThi on LichThi.id_LopHoc_MonHoc= LopHoc_MonHoc.id_LopHoc_MonHoc" +
                " join CaThi on CaThi.id_CaThi=LichThi.id_CaThi" +
                " join MonHoc on MonHoc.id_MonHoc = LopHoc_MonHoc.id_MonHoc " +
                " where SinhVien_DangKyMon.mssv = @mssv";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@mssv", studentID);
                dataAdapter = new SqlDataAdapter(sqlCommand);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }

            return dataTable;
        }
        static public int getLopHocMonHocIDByLichThiID(int lichThiID)
        {
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                string queryString = "SELECT id_LopHoc_MonHoc FROM LichThi where id_LichThi = @lichThiID"; // Thay TableName bằng tên bảng của bạn hoặc truy vấn SQL phù hợp
                SqlCommand command = new SqlCommand(queryString, sqlConnection);
                command.Parameters.AddWithValue("@lichThiID",lichThiID);
                return (int)command.ExecuteScalar();
            }
        }
        static public bool insert(Schedule schedule)
        {
            SqlCommand sqlCommand;//cap nhat csdl
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "insert into LichThi values (@ngayThi,@thoiGianThi,@quyCheThi,@caThiID,@lopHocMonHocID,@so_cau)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@ngayThi", SqlDbType.DateTime).Value = schedule.NgayThi;
                sqlCommand.Parameters.Add("@thoiGianThi", SqlDbType.DateTime).Value = schedule.ThoiGianThi;
                sqlCommand.Parameters.Add("@quyCheThi", SqlDbType.NVarChar).Value = schedule.QuyCheThi;
                sqlCommand.Parameters.Add("@caThiID", SqlDbType.Int).Value = schedule.CaThiID;
                sqlCommand.Parameters.Add("@lopHocMonHocID", SqlDbType.Int).Value = schedule.LopHocMonHocID;
                sqlCommand.Parameters.Add("@so_cau", SqlDbType.Int).Value = schedule.QuestionNumber;
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
        static public bool update(Schedule schedule)
        {
            SqlCommand sqlCommand;//cap nhat csdl
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "update LichThi set ngay_thi = @ngayThi, thoi_gian_thi=@thoiGianThi,quy_che_thi=@quyCheThi,id_CaThi=@caThiID,id_LopHoc_MonHoc=@lopHocMonHocID,so_cau=@so_cau where id_LichThi=@lichThiID";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@lichThiID", SqlDbType.Int).Value = schedule.LichThiID;
                sqlCommand.Parameters.Add("@ngayThi", SqlDbType.DateTime).Value = schedule.NgayThi;
                sqlCommand.Parameters.Add("@thoiGianThi", SqlDbType.DateTime).Value = schedule.ThoiGianThi;
                sqlCommand.Parameters.Add("@quyCheThi", SqlDbType.NVarChar).Value = schedule.QuyCheThi;
                sqlCommand.Parameters.Add("@caThiID", SqlDbType.Int).Value = schedule.CaThiID;
                sqlCommand.Parameters.Add("@lopHocMonHocID", SqlDbType.Int).Value = schedule.LopHocMonHocID;
                sqlCommand.Parameters.Add("@so_cau", SqlDbType.Int).Value = schedule.QuestionNumber;
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
        static public bool delete(int lichThiID)
        {
            SqlConnection sqlConnection = Connection.GetConnection();
            string query = "delete from LichThi where id_LichThi = @lichThiID";
            try
            {
                SqlCommand sqlCommand;//cap nhat csdl
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@lichThiID", SqlDbType.Int).Value = lichThiID;
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
        
    }
}
