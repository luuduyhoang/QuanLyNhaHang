using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace QuanLyNhaHang
{
    public partial class Login : Form
    {
        DangNhap dangnhap = new DangNhap();
        DangNhapBUS dangnhapBUS = new DangNhapBUS();
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            dangnhap.ID_NV = m_txt_ID.Text;
            dangnhap.MK = m_txt_MK.Text;

            string getuser = dangnhapBUS.CheckLogin(dangnhap);

            // Thể hiện trả lại kết quả nếu nghiệp vụ không đúng
            switch (getuser)
            {
                case "required_id":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;

                case "required_mk":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;

                case "Tài khoản hoặc mật khẩu không chính xác!":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!");
                    return;
            }

            MessageBox.Show("Xin chúc mừng bạn đã đăng nhập thành công hệ thống!");

        }
    }
}
