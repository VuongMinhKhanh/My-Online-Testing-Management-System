using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuestionBank_DAO
{
    public class DBConnect
    {
        protected SqlConnection conn = new SqlConnection("Server = OLDIEPC\\KENKING;" +
            "Initial Catalog=OnlineTesting;" +
            "User id = sa;" +
            "Password = sa;");
    }
}
