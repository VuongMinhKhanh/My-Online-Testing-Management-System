using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using QuestionBank_DAO;
using QuestionBank_DTO;

namespace QuestionBank_BUS
{
    public class HomePage_Teacher_BUS
    {
        private HomePage_Teacher_DAO homepage_teacher_DAO;

        public HomePage_Teacher_BUS()
        {
           homepage_teacher_DAO = new HomePage_Teacher_DAO();
        }

        public DataTable getLichThi()
        {
            return homepage_teacher_DAO.getLichThi();
        }

        public DataTable getDeThi()
        {
            return homepage_teacher_DAO.getDanhSachDeThi();
        }
        public DataTable DangKiGiamThi()
        {
            return homepage_teacher_DAO.DangKiGiamThi();
        }
    }
}
