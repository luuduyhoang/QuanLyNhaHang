using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DangNhapDAO : DatabaseAccess
    {
        public string CheckLogin(DangNhap dangnhap)
        {
            string v_str_info = CheckLoginDTO(dangnhap);
            return v_str_info;
        }
    }
}
