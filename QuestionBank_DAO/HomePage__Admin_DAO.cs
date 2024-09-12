using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuestionBank_DAO
{
    public class HomePage__Admin_DAO : DBConnect
    {
        public DataTable getLichThi()
        {
            DataTable lichThi = new DataTable();

            try
            {
                string query = "SELECT * FROM LichThi";

                conn.Open();
                {
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(lichThi);
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
            finally
            {
                // Đảm bảo rằng kết nối được đóng sau khi sử dụng
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

            return lichThi;
        }
        public DataTable getDanhSachGiamThi()
        {
            DataTable danhSachGiamThi = new DataTable();

            try
            {
                string query = "SELECT * FROM NguoiDung WHERE UserRole = 'Giảng viên'";
                conn.Open();
                {
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(danhSachGiamThi);
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
            finally
            {
                // Đảm bảo rằng kết nối được đóng sau khi sử dụng
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return danhSachGiamThi;
        }
        public DataTable getDanhSachDeThi()
        {
            DataTable danhSachDeThi = new DataTable();

            try
            {
                string query = "SELECT * FROM DeThi";
                conn.Open();
                {
                    SqlCommand command = new SqlCommand(query, conn);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(danhSachDeThi);
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
            finally
            {
                // Đảm bảo rằng kết nối được đóng sau khi sử dụng
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return danhSachDeThi;
        }

    }
}

