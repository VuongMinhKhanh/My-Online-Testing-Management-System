using QuestionBank_DAO;
using QuestionBank_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank_BUS
{
    public class Score_BUS
    {
        Score_DAO score_dao = new Score_DAO();

        public bool addScore(Score_DTO score, string state, string studentId, int idClass_Subject)
        {
            return score_dao.addScore(score, state, studentId, idClass_Subject);
        }
        public DataTable getScores(string subjectId, int semester, int year)
        {
            return score_dao.getScores(subjectId, semester, year);
        }
        //public bool UpdateSubjectState(string state, string studentId, int idClass_Subject)
        //{
        //    return score_dao.UpdateSubjectState(state, studentId, idClass_Subject);
        //}
    }
}
