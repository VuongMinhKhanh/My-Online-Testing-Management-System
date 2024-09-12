using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QuestionBank_DTO
{
    public class Subject_DTO
    {
        private string subject_id;
        private string subject_name;
        private int credit;
        private bool status;

        // getter setter
        public string Subject_ID {  get { return subject_id; } set {  subject_id = value; } }
        public string Subject_Name {  get { return subject_name; } set { subject_name = value; } }
        public int Credit { get { return credit; } set { credit = value; } }
        public bool Status {  get { return status; } set {  status = value; } }

        public Subject_DTO(string id, string name, int credit, bool status) {
            subject_id = id;
            subject_name = name;
            this.credit = credit;
            this.status = status;
        }
    }
}
