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
    public class Manage_Users_BUS
    {
        private Manage_Users_DAO userDAO;

        public Manage_Users_BUS()
        {
            userDAO = new Manage_Users_DAO();
        }
        public Manage_Users_DTO GetUserById(string userId)
        {
            return userDAO.GetUserById(userId);
        }
        public DataTable GetUsersByID(string userId)
        {
            return userDAO.GetUsersById(userId); 
        }

        public bool AddUser(string username, string password, string userRole)
        {
            // Kiểm tra điều kiện nếu tên người dùng không tồn tại
            if (!IsUsernameExist(username))
            {
                userDAO.AddUser(username, password, userRole);
                return true;
            }
            else
            {
                Console.WriteLine("Username already exists!");
                return false;
            }
        }

        // Cập nhật thông tin người dùng trong cơ sở dữ liệu
        public bool UpdateUser(int userId, string username, string password, string userRole)
        {
            // Kiểm tra điều kiện nếu tên người dùng không tồn tại
            if (!IsUsernameExist(username, userId))
            {
                userDAO.UpdateUser(userId, username, password, userRole);
                return true;
            }
            else
            {
                Console.WriteLine("Username already exists!");
                return false;
            }
        }

        // Xóa người dùng khỏi cơ sở dữ liệu dựa trên userId
        public void DeleteUser(int userId)
        {
            userDAO.DeleteUser(userId);
        }

        // Kiểm tra xem tên người dùng đã tồn tại hay chưa
        private bool IsUsernameExist(string username)
        {
            DataTable dt = userDAO.GetUsers();
            foreach (DataRow row in dt.Rows)
            {
                if (row["Username"].ToString() == username)
                {
                    return true;
                }
            }
            return false;
        }

        // Kiểm tra xem tên người dùng đã tồn tại hay chưa, trừ userId đang xử lý
        private bool IsUsernameExist(string username, int userId)
        {
            DataTable dt = userDAO.GetUsers();
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["UserId"]) != userId && row["Username"].ToString() == username)
                {
                    return true;
                }
            }
            return false;
        }
        public DataRow GetUserById(int userId)
        {
            DataTable dt = userDAO.GetUsers();
            foreach (DataRow row in dt.Rows)
            {
                if (Convert.ToInt32(row["UserId"]) == userId)
                {
                    return row;
                }
            }
            return null; // Trả về null nếu không tìm thấy người dùng với userId tương ứng
        }
    }
}

