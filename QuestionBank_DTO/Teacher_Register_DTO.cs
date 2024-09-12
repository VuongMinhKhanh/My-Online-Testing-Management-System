using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank_DTO
{
    public class Teacher_Register_DTO 
    {
        public int Id { get { return Id; } set { Id = value; } }
        public int GiangVienId { get { return GiangVienId; } set { GiangVienId = value; } }
        public DateTime NgayThi { get { return NgayThi; } set { NgayThi = value; } }
        public string CaThi { get { return CaThi; } set { CaThi = value; } }
    }
}
