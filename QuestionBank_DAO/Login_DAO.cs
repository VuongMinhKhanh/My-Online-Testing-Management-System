using System;
using System.Data;
using System.Data.SqlClient;
using BCrypt.Net;
using QuestionBank_DTO;

namespace QuestionBank_DAO
{
    public class Login_DAO : DBConnect
    {
        public DataTable GetUsers()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM NguoiDung Where Username = @Username", conn);
            DataTable dtUser = new DataTable();

            conn.Open();

            da.Fill(dtUser);

            conn.Close();

            return dtUser;
        }

        public Manage_Users_DTO CheckLogin(string username, string password, string userRole)
        {
            string query = "SELECT * FROM NguoiDung " +
                "WHERE Username = @Username " +
                "AND UserRole = @UserRole";

            using (SqlCommand command = new SqlCommand(query, conn))
            {
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@UserRole", userRole);

                try
                {
                    conn.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string storedHash = reader["Password"] as string;
                            //Console.WriteLine(storedHash);
                            bool isVerified = BCrypt.Net.BCrypt.Verify(password, storedHash);
                            if (isVerified)
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
    }
}
