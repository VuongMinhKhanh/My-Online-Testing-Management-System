using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionBank_DAO;
using QuestionBank_DTO;

namespace QuestionBank_BUS
{
    public class Subject_BUS
    {
        Subject_DAO subject = new Subject_DAO();
        public DataTable getId_Subjects()
        {
            return subject.getId_Subjects();
        }
        public DataTable getId_Subjects(string lecturerId)
        {
            return subject.getId_Subjects(lecturerId);
        }

        
    }
}
