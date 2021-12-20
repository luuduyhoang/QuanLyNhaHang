using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class SqlConnectionData
    {
        //Tao chuoi ket noi
        public static SqlConnection Connect()
        {
            string strcon = @"Data Source=.;Initial Catalog=NhaHang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(strcon);
            return conn;
        }
    }

    public class DatabaseAccess
    {
        public static string CheckLoginDTO(DangNhap dangnhap)
        {
            string user = null;
            // Hàm connect tới CSDL
            SqlConnection conn = SqlConnectionData.Connect();
            conn.Open();
            SqlCommand command = new SqlCommand("proc_Login", conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@ID", dangnhap.ID_NV);
            command.Parameters.AddWithValue("@MK", dangnhap.MK);
            // Kiểm tra quyền các bạn thêm 1 cái parameter...
            command.Connection = conn;
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    user = reader.GetString(0);
                }
                reader.Close();
                conn.Close();
            }
            else
            {
                return "Tài khoản hoặc mật khẩu không chính xác!";
            }

            return user;
        }
    }
}
