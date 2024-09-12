using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionBank_DAO;
using QuestionBank_DTO;
using System.Data;

namespace QuestionBank_BUS
{
    public class HomePage_Student_BUS
    {
        private HomePage_Student_DAO homepageStudent_Dao;

        public HomePage_Student_BUS()
        {
            homepageStudent_Dao = new HomePage_Student_DAO();
        }
        public DataTable getLichThi()
        {
            return homepageStudent_Dao.getLichThi();
        }
    }
}
