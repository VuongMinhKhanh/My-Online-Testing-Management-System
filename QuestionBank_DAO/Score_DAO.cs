using QuestionBank_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Data.SqlTypes;

namespace QuestionBank_DAO
{
    public class Score_DAO: DBConnect
    {
        public bool addScore(Score_DTO score, string state, string studentId, int idClass_Subject)
        {
            using (conn)
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();
                try
                {
                    // Perform the insertion using a direct command
                    string insertSql = "INSERT INTO Diem (id_sv, diem, id_Lop_MonHoc) VALUES (@IdStudent, @Score, @IdClassSubject)";
                    using (SqlCommand insertCmd = new SqlCommand(insertSql, conn, transaction))
                    {
                        insertCmd.Parameters.AddWithValue("@IdStudent", score.IdStudent);
                        insertCmd.Parameters.AddWithValue("@Score", score.Score);
                        insertCmd.Parameters.AddWithValue("@IdClassSubject", score.IdClass_Subject);
                        insertCmd.ExecuteNonQuery();
                    }

                    // Update the state
                    string updateSql = "UPDATE SinhVien_DangKyMon SET trang_thai = @state WHERE id_Lop_MonHoc = @idClassSubject AND mssv = @studentId";
                    using (SqlCommand updateCmd = new SqlCommand(updateSql, conn, transaction))
                    {
                        updateCmd.Parameters.AddWithValue("@state", state);
                        updateCmd.Parameters.AddWithValue("@studentId", studentId);
                        updateCmd.Parameters.AddWithValue("@idClassSubject", idClass_Subject);
                        int result = updateCmd.ExecuteNonQuery();
                        if (result <= 0)
                        {
                            throw new Exception("Update command affected no rows.");
                        }
                    }

                    transaction.Commit();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                    transaction.Rollback();
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        public DataTable getScores(string subjectId, int semester, int year)
        {
            string sql = "Select diem, Count(id_diem) as Qty " +
                "From Diem " +
                "Join LopHoc_MonHoc on id_LopHoc_MonHoc = id_Lop_MonHoc " +
                " WHERE Diem.id_Lop_MonHoc in (" +
                        " Select id_LopHoc_MonHoc" +
                        " From LopHoc_MonHoc" +
                        $" Where id_MonHoc = '{subjectId}'";
            if (semester != 0)
                sql += $" AND HocKy = {semester}";

            if (year != 0)
                sql += $" AND NamHoc = {year}"; 

                sql += " ) Group By diem " +
                " Order By Count(id_diem)";

            SqlDataAdapter dataAdapter;
            SqlCommandBuilder commandBuilder;
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();

            try
            {
                conn.Open();

                dataAdapter = new SqlDataAdapter(sql, conn);
                commandBuilder = new SqlCommandBuilder(dataAdapter);

                dataAdapter.Fill(dataSet, "Diem");

                return dataSet.Tables[0];
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return dataTable;
            }
            finally
            {
                conn.Close();
            }   
        }
        //public bool UpdateSubjectState(string state, string studentId, int idClass_Subject)
        //{
            //if (conn.State != ConnectionState.Open)
            //    conn.Open();

            //string sqlCmd = "UPDATE SinhVien_DangKyMon SET trang_thai = @state WHERE id_Lop_MonHoc = @idClassSubject AND mssv = @studentId";
            //SqlTransaction transaction = conn.BeginTransaction();

            //try
            //{
            //    using (SqlCommand cmd = new SqlCommand(sqlCmd, conn, transaction))
            //    {
            //        // Use parameters to avoid SQL injection
            //        cmd.Parameters.AddWithValue("@state", state);
            //        cmd.Parameters.AddWithValue("@studentId", studentId);
            //        cmd.Parameters.AddWithValue("@idClassSubject", idClass_Subject);

            //        int result = cmd.ExecuteNonQuery();
            //        if (result <= 0)
            //            return false;

            //        transaction.Commit();
            //        return true;
            //    }
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.ToString());
            //    transaction.Rollback();
            //    return false;
            //}
            //finally
            //{
            //    // Ensure the connection is closed
            //    if (conn.State == ConnectionState.Open)
            //        conn.Close();
            //}
        //}
    }
}
