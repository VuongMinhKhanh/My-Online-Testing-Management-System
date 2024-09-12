using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuestionBank_DTO
{
    public class Manage_Users_DTO
    {
        private string userId;
        private string fullName;
        private string address;
        private DateTime dob; 
        private string phone;
        private string userName;
        //private string password;
        private string userRole;

        public string UserId { get { return userId; } set { userId = value; } }
        public string Username { get { return userName; } set { userName = value; } }
        public string FullName { get { return fullName; } set { fullName = value; } }
        //public string Password { get { return password; } set { password = value; } }
        public string UserRole { get { return userRole; } set { userRole = value; } }
        public string Address { get { return address; } set { address = value; } }
        public DateTime DOB { get { return dob; } set { dob = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
    }
}
