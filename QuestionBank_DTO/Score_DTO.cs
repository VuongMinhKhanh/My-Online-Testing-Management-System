using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank_DTO
{
    public class Score_DTO
    {
        //private int idScore;
        private string idStudent;
        private string idSubject;
        private double score;
        private int idClass_Subject;

        public string IdStudent { get { return idStudent; } set { idStudent = value; } }
        public string IdSubject { get { return idSubject; } set { idSubject = value; } }
        public double Score { get { return score; } set { score = value; } }
        public int IdClass_Subject { get { return idClass_Subject; } set { idClass_Subject = value; } }

        public Score_DTO() { }
        public Score_DTO(string idStudent, string idSubject, double score, int idClass_Subject)
        {
            this.idStudent = idStudent;
            this.idSubject = idSubject;
            this.score = score;
            this.idClass_Subject = idClass_Subject;
        }   
    }
}
