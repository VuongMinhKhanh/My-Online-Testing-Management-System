using QuestionBank_DTO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuestionBank_DAO
{
    public class Manage_Users_DAO : DBConnect
    {
        // Lấy danh sách người dùng từ cơ sở dữ liệu
        public DataTable GetUsers()
        {
            DataTable dtUser = new DataTable();
            try
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM NguoiDung", conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(command))
                    {
                        da.Fill(dtUser);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dtUser;
        }
        public Manage_Users_DTO GetUserById(string userId)
        {
            string query = "SELECT * FROM NguoiDung WHERE id_user = @userId";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@userId", userId);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime? tempDOB = null;  // Use nullable DateTime, allowing null ngay_sinh
                            if (!reader.IsDBNull(reader.GetOrdinal("ngay_sinh")))
                            {
                                tempDOB = (DateTime)reader["ngay_sinh"];
                            }
                                return new Manage_Users_DTO
                            {
                                UserId = reader["id_user"] as string,
                                FullName = reader["ho_ten"] as string,
                                Address = reader["dia_chi"] as string,
                                Phone = reader["SDT"] as string,
                                DOB = (DateTime)tempDOB,
                                Username = reader["Username"] as string,
                                UserRole = reader["UserRole"] as string,
                            };
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
            return null;
        }
        public DataTable GetUsersById(string userId)
        {
            conn.Open();

            SqlDataAdapter da;
            string sqlCmd;

            try
            {
                sqlCmd = "select * from NguoiDung " +
                $"where id_user = '{userId}'";

                da = new SqlDataAdapter(sqlCmd, conn);
                DataTable dtSubject = new DataTable();
                da.Fill(dtSubject);

                return dtSubject;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return new DataTable();
            }
            finally
            {
                conn.Close();
            }
        }

        // Thêm một người dùng mới vào cơ sở dữ liệu
        public void AddUser(string username, string password, string userRole)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO Account (Username, Password, UserRole) VALUES (@Username, @Password, @UserRole)";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@UserRole", userRole);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Cập nhật thông tin người dùng trong cơ sở dữ liệu
        public void UpdateUser(int userId, string username, string password, string userRole)
        {
            try
            {
                conn.Open();
                string query = "UPDATE Account SET Username = @Username, Password = @Password, UserRole = @UserRole WHERE UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@UserRole", userRole);
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        // Xóa người dùng khỏi cơ sở dữ liệu dựa trên userId
        public void DeleteUser(int userId)
        {
            try
            {
                conn.Open();
                string query = "DELETE FROM Account WHERE UserId = @UserId";
                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@UserId", userId);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
