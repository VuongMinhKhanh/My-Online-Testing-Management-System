using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank_DTO
{
    internal class Login_DTO
    {
        public string Username { get { return Username; } set { Username = value; } }
        public string Password { get { return Password; } set { Password = value; } }
        public string UserRole { get { return UserRole; } set { UserRole = value; } }
    }
}
