using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace QuestionBank_DTO
{
    public class HomePage_Admin_DTO
    {
        public string adminName { get { return adminName; } set { adminName = value; } }
        public string TenDe { get { return TenDe; } set { TenDe = value; } } // Tên đề
        public string MonHoc { get { return MonHoc; } set { MonHoc = value; } } // Môn học của đề
        public int ThoiGianLamBai { get { return ThoiGianLamBai; } set { ThoiGianLamBai = value; } } // Thời gian làm bài
        public DateTime NgayTao { get { return NgayTao; } set { NgayTao = value; } } // Ngày tạo đề
        // báo cáo thống kê chưa xử lý
    }
}
