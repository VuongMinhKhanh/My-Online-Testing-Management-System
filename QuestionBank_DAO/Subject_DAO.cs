using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestionBank_DTO;

namespace QuestionBank_DAO
{
    public class Subject_DAO : DBConnect
    {
        public DataTable getId_Subjects()
        {
            SqlDataAdapter da = new SqlDataAdapter(
                "select id_MonHoc, ten_mon_hoc from MonHoc",
                conn);
            DataTable dtSubject = new DataTable();

            conn.Open();

            da.Fill(dtSubject);

            conn.Close();

            return dtSubject;
        }
        public DataTable getId_Subjects(string lecturerId)
        {
            //SqlDataAdapter da = new SqlDataAdapter(
            //    "select id_MonHoc, ten_mon_hoc from MonHoc" +
            //    "join LopHoc_MonHoc on LopHoc_MonHoc.id_MonHoc = MonHoc.id" +
            //    "where id_GiangVien = @lecturerId ",
            //    conn);
            //DataTable dtSubject = new DataTable();

            //conn.Open();

            //da.Fill(dtSubject);

            //conn.Close();

            //return dtSubject;
            string sqlCommand = "SELECT MonHoc.id_MonHoc, ten_mon_hoc FROM MonHoc " +
                        "JOIN GiangVien_MonHoc ON GiangVien_MonHoc.id_MonHoc = MonHoc.id_MonHoc " +
                        "WHERE id_GiangVien = @lecturerId";

            SqlDataAdapter da = new SqlDataAdapter(sqlCommand, conn);
            DataTable dtSubject = new DataTable();

            da.SelectCommand.Parameters.AddWithValue("@lecturerId", lecturerId);

            try
            {
                conn.Open();

                da.Fill(dtSubject);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            // Return the filled DataTable
            return dtSubject;
        }

        
    }
}
