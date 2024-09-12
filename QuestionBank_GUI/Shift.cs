using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank_GUI
{
    public class Shift
    {
        private int caThiID;
        private DateTime gioBatDau;
        private DateTime gioKetThuc;
        public Shift()
        {
        }

        public Shift(int caThiID, DateTime gioBatDau, DateTime gioKetThuc)
        {
            CaThiID = caThiID;
            GioBatDau = gioBatDau;
            GioKetThuc = gioKetThuc;
        }

        public int CaThiID { get => caThiID; set => caThiID = value; }
        public DateTime GioBatDau { get => gioBatDau; set => gioBatDau = value; }
        public DateTime GioKetThuc { get => gioKetThuc; set => gioKetThuc = value; }

        static public DataTable getAllShift()
        {
            SqlDataAdapter dataAdapter;
            DataTable dataTable = new DataTable();
            string query = "select * from CaThi";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }
        static public DateTime getShiftStartingTime(int caThiID)
        {
            SqlCommand sqlCommand;
            DateTime dateTime = new DateTime();
            string query = "select gio_bat_dau from CaThi where id_CaThi = @caThiID";
            using (SqlConnection sqlConnection = Connection.GetConnection())
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@caThiID", SqlDbType.Int).Value = caThiID;
                dateTime = DateTime.Parse(sqlCommand.ExecuteScalar().ToString());
                sqlConnection.Close();
            }
            return dateTime;
        }
    }
}
