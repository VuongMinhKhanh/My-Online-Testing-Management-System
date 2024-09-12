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
    public class HomePage_Admin_BUS
    {
        private HomePage__Admin_DAO Admin_DAO;

        public HomePage_Admin_BUS()
        {
            Admin_DAO = new HomePage__Admin_DAO();
        }
        public DataTable getLichThi()
        {
            return Admin_DAO.getLichThi();
        }

        public DataTable getDachSachGiamThi()
        {
            return Admin_DAO.getDanhSachGiamThi();
        }
        public DataTable getDanhSachDeThi()
        {
            return Admin_DAO.getDanhSachDeThi();
        }
    }
}
