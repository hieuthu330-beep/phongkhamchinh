using System;
using System.Collections.Generic;
using System.Text;

namespace phongkham1
{
    internal class UserSession
    {
        public static UserSession CurrentUser { get; set; }

        public int TaiKhoanID { get; set; }
        public string HoTen { get; set; }
        public string TenDangNhap { get; set; }
        public string Email { get; set; }
        public string SoDienThoai { get; set; }
        public string VaiTro { get; set; }

        // Constructor để gán dữ liệu
        public UserSession(int taiKhoanID, string hoTen, string tenDangNhap, string email, string soDienThoai, string vaiTro)
        {
            TaiKhoanID = taiKhoanID;
            HoTen = hoTen;
            TenDangNhap = tenDangNhap;
            Email = email;
            SoDienThoai = soDienThoai;
            VaiTro = vaiTro;
        }

        // Hàm đăng xuất
        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
