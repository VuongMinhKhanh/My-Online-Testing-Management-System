using QuestionBank_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestionBank_DAO
{
    public class Question_DAO: DBConnect
    {
        public DataTable getQuestions(string idSubject)
        {
            conn.Open();

            SqlDataAdapter da;
            string sqlCmd;

            try
            {
                sqlCmd = "select CauHoi.id_CauHoi, cau_hoi, id_DapAn, cau_tra_loi from CauHoi " +
                "join ChiTietCauHoi on ChiTietCauHoi.id_CauHoi = CauHoi.id_CauHoi " +
                "join DapAn on DapAn.id_ChiTietCauHoi = ChiTietCauHoi.id_ChiTietCauHoi " +
                $"where id_MonHoc = '{idSubject}'";

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

        public DataTable getAnswers(int idQuestion)
        {
            conn.Open();

            string sqlCmd;
            SqlDataAdapter da;

            try
            {
                sqlCmd = "select id_ChiTietCauHoi, cau_tra_loi from CauHoi " +
                    "join ChiTietCauHoi on ChiTietCauHoi.id_CauHoi = CauHoi.id_CauHoi " +
                    $"where CauHoi.id_CauHoi = '{idQuestion}'";
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

        public DataTable getRandomQuestions(int questionNumber, string idSubject)
        {
            conn.Open();

            string sqlCmd;
            SqlDataAdapter da;

            try
            {
                sqlCmd = "SELECT ch.id_CauHoi, cau_hoi, cth.id_ChiTietCauHoi, cau_tra_loi, id_DapAn " +
                    "FROM ( " +
                    $"SELECT TOP {questionNumber} * FROM CauHoi " +
                    $"Where id_MonHoc = '{idSubject}' " +
                    "ORDER BY NEWID() " +
                    ") AS ch " +
                    "JOIN ChiTietCauHoi cth ON ch.id_CauHoi = cth.id_CauHoi " +
                    "LEFT JOIN DapAn da ON cth.id_ChiTietCauHoi = da.id_ChiTietCauHoi; ";

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

        public bool addQuestion(Question_DTO question)
        {
            conn.Open();

            string sqlCmd;
            SqlCommand cmd;
            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                sqlCmd = $"Insert into CauHoi(cau_hoi, id_MonHoc) Values (@Question, @idMonHoc);";
                cmd = new SqlCommand(sqlCmd, conn, transaction);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Question", question.Question);
                cmd.Parameters.AddWithValue("@idMonHoc", question.IdSubject);

                if (cmd.ExecuteNonQuery() <= 0)
                    return false;

                string sqlCauHoiCurrentId = "Select Max(id_CauHoi) from CauHoi;";
                cmd = new SqlCommand(sqlCauHoiCurrentId, conn, transaction);
                int cauHoiId = Convert.ToInt32(cmd.ExecuteScalar());
                //MessageBox.Show(cauHoiId.ToString());

                foreach (string answer in question.Answers)
                {
                    sqlCmd = $"Insert into ChiTietCauHoi(id_CauHoi, cau_tra_loi) Values (@cauHoiId, @answer);";
                    cmd = new SqlCommand(sqlCmd, conn, transaction);

                    cmd.Parameters.AddWithValue("@cauHoiId", cauHoiId);
                    cmd.Parameters.AddWithValue("@answer", answer);
                    //cmd.CommandType = CommandType.Text;
                    if (cmd.ExecuteNonQuery() <= 0)
                        return false;
                }

                string sqlCTCHCurrentId = "Select max(id_ChiTietCauHoi) from ChiTietCauHoi";
                cmd = new SqlCommand(sqlCTCHCurrentId, conn, transaction);
                int ctchId = Convert.ToInt32(cmd.ExecuteScalar()) - question.Answers.Count + 1;
                //MessageBox.Show(ctchId.ToString() + " " + (question.CorrectAnswer + ctchId - 1).ToString());
                sqlCmd = "";
                sqlCmd += $"Insert into DapAn(id_ChiTietCauHoi) Values (@correctAnswer)";
                cmd = new SqlCommand(sqlCmd, conn, transaction);
                cmd.Parameters.AddWithValue("@correctAnswer", question.CorrectAnswer + ctchId - 1);
                //cmd.CommandType = CommandType.Text;
                if (cmd.ExecuteNonQuery() <= 0)
                    return false;

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

        public bool adjustQuestion(Question_DTO question)
        {
            conn.Open();

            string sqlCmd;
            SqlCommand cmd;
            SqlTransaction transaction = conn.BeginTransaction();

            try
            {
                if (question.Question != "")
                {
                    sqlCmd = "Update CauHoi " +
                        $"Set cau_hoi = N'{question.Question}'" +
                        $"Where id_CauHoi = {question.IdQuestion}";
                    cmd = new SqlCommand(sqlCmd, conn, transaction);
                    //cmd.CommandType = CommandType.Text;
                    if (cmd.ExecuteNonQuery() <= 0)
                        return false;
                }

                for (int i = 0; i < question.Answers.Count; i++)
                {
                    if (question.Answers[i] != "")
                    {
                        sqlCmd = "Update ChiTietCauHoi " +
                        $"Set cau_tra_loi = N'{question.Answers[i]}'" +
                        $"Where id_ChiTietCauHoi = {question.IdAnswers[i]}";
                        cmd = new SqlCommand(sqlCmd, conn, transaction);
                        //cmd.CommandType = CommandType.Text;
                        if (cmd.ExecuteNonQuery() <= 0)
                            return false;
                    }
                }

                if (question.CorrectAnswer != -1)
                {
                    sqlCmd = "Update DapAn " +
                        $"Set id_ChiTietCauHoi = {question.CorrectAnswer + question.IdAnswers[0] - 1}" +
                        $"Where id_DapAn = {question.IdCorrectAnswer}";
                    cmd = new SqlCommand(sqlCmd, conn, transaction);
                    //cmd.CommandType = CommandType.Text;
                    if (cmd.ExecuteNonQuery() <= 0)
                        return false;
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

        public bool deleteQuestion(Question_DTO question)
        {
            conn.Open();

            SqlTransaction transaction = conn.BeginTransaction();
            string sqlCmd;
            SqlCommand cmd;

            try
            {
                sqlCmd = "Delete from DapAn " +
                    $"Where id_DapAn = @idCorrectAnswer";
                cmd = new SqlCommand(sqlCmd, conn, transaction);
                cmd.Parameters.AddWithValue("@idCorrectAnswer", question.IdCorrectAnswer);
                if (cmd.ExecuteNonQuery() <= 0)
                    return false;

                foreach (int id in question.IdAnswers)
                {
                    sqlCmd = "Delete from ChiTietCauHoi " +
                    $"Where id_ChiTietCauHoi = @id";
                    cmd = new SqlCommand(sqlCmd, conn, transaction);
                    cmd.Parameters.AddWithValue("@id", id);
                    if (cmd.ExecuteNonQuery() <= 0)
                        return false;
                }

                sqlCmd = "Delete from CauHoi " +
                    $"Where id_CauHoi = @idQuestion";
                cmd = new SqlCommand(sqlCmd, conn, transaction);
                cmd.Parameters.AddWithValue("@idQuestion", question.IdQuestion);
                if (cmd.ExecuteNonQuery() <= 0)
                    return false;

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
}
