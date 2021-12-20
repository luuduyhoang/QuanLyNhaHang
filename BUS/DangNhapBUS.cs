using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class DangNhapBUS
    {
        DangNhapDAO dangnhapDAO = new DangNhapDAO();
        public string CheckLogin(DangNhap dangnhap)
        {
            // Kiểm tra nghiệp vụ
            if (dangnhap.ID_NV == "")
            {
                return "required_id";
            }

            if (dangnhap.MK == "")
            {
                return "required_mk";
            }

            string v_str_info = dangnhapDAO.CheckLogin(dangnhap);
            return v_str_info;
        }
    }
}
