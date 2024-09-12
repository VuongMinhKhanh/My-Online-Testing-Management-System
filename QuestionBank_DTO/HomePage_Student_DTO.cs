using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuestionBank_DTO
{
    public class HomePage_Student_DTO
    {
        private DataTable _examSchedule;
        public DataTable ExamSchedule { get { return _examSchedule; } set { _examSchedule = value; } }
        public string Studentname { get { return Studentname; } set { Studentname = value; } }
    }
}
