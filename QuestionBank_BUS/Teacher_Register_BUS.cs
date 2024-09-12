using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestionBank_DAO;
using QuestionBank_DTO;

namespace QuestionBank_BUS
{
    public class Teacher_Register_BUS
    {
        private Teacher_Register_DAO giamThiDAO = new Teacher_Register_DAO();

        public Teacher_Register_BUS()
        {
            giamThiDAO = new Teacher_Register_DAO();
        }
        public Teacher_Register_DTO LayGiamThiTheoNgayVaCa(DateTime ngayThi, string caThi)
        {
            return giamThiDAO.LayGiamThiTheoNgayVaCa(ngayThi, caThi);
        }

        public void ThemGiamThi(Teacher_Register_DTO giamThi)
        {
            giamThiDAO.ThemGiamThi(giamThi);
        }
    }
}
