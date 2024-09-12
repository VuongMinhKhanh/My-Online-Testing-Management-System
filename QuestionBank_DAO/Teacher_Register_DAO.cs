using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using QuestionBank_DTO;


namespace QuestionBank_DAO
{
    public class Teacher_Register_DAO : DBConnect
    {
        int Id;
        int GiangVienId;
        DateTime NgayThi;
        string CaThi;
        public Teacher_Register_DTO LayGiamThiTheoNgayVaCa(DateTime ngayThi, string caThi)
        {
            Teacher_Register_DTO giamThi = null;

            try
            {
                conn.Open();
                string query = "SELECT * FROM GiamThi WHERE NgayThi = @NgayThi AND CaThi = @CaThi";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@NgayThi", ngayThi);
                cmd.Parameters.AddWithValue("@CaThi", caThi);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    giamThi = new Teacher_Register_DTO();
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        GiangVienId = reader.GetInt32(reader.GetOrdinal("GiangVienId"));
                        NgayThi = reader.GetDateTime(reader.GetOrdinal("NgayThi"));
                        CaThi = reader.GetString(reader.GetOrdinal("CaThi"));
                    };
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ ở đây, ví dụ: ghi log, hiển thị thông báo lỗi, ...
                Console.WriteLine("Lỗi " + ex.Message);
                // Đóng kết nối nếu có lỗi xảy ra
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return giamThi;
        }

        public void ThemGiamThi(Teacher_Register_DTO giamThi)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO GiamThi (GiangVienId, NgayThi, CaThi) VALUES (@GiangVienId, @NgayThi, @CaThi)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@GiangVienId", giamThi.GiangVienId);
                cmd.Parameters.AddWithValue("@NgayThi", giamThi.NgayThi);
                cmd.Parameters.AddWithValue("@CaThi", giamThi.CaThi);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ ở đây, ví dụ: ghi log, hiển thị thông báo lỗi, ...
                Console.WriteLine("Lỗi " + ex.Message);
                // Đóng kết nối nếu có lỗi xảy ra
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
