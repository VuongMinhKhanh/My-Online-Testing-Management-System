using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QuestionBank_GUI
{
    public class Connection
    {
        private static string stringConnection = "Server = OLDIEPC\\KENKING;" +
            "Initial Catalog=OnlineTesting;" +
            "User id = sa;" +
            "Password = sa;";
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }


}
