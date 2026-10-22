using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static QRCoder.PayloadGenerator;

namespace phongkham1
{
    public partial class FormDky : Form
    {
        private ConnectDB db = new ConnectDB();
        public FormDky()
        {
            InitializeComponent();
        }

        private void btnDky_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ các ô TextBox
            string hoTen = txtHoten.Text;
            string tenDangNhap = txtTendn.Text;
            string matKhau = txtMk.Text;
            string xacNhanMK = txtXacnhanmk.Text;
            string sdt = txtSdt.Text;
            string email = txtEmail.Text;

            // 2. Dùng if-else kiểm tra thông tin bắt buộc có dấu (*)
            if (string.IsNullOrEmpty(hoTen))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoten.Focus();
            }
            else if (string.IsNullOrEmpty(tenDangNhap))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTendn.Focus();
            }
            else if (string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMk.Focus();
            }
            else if (string.IsNullOrEmpty(xacNhanMK))
            {
                MessageBox.Show("Vui lòng xác nhận lại mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtXacnhanmk.Focus();
            }
            else if (string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
            }
            // 3. Kiểm tra mật khẩu khớp nhau không
            else if (matKhau != xacNhanMK)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtXacnhanmk.Clear();
                txtXacnhanmk.Focus();
            }
            else
            {
                // 4. Kiểm tra xem Tên đăng nhập đã tồn tại trong database chưa bằng hàm readdata
                string checkQuery = "SELECT * FROM TaiKhoan WHERE TenDangNhap = N'" + tenDangNhap + "'";
                DataTable dt = db.readdata(checkQuery);

                if (dt != null && dt.Rows.Count > 0)
                {
                    // Nếu bảng có dữ liệu nghĩa là tên đăng nhập đã tồn tại
                    MessageBox.Show("Tên đăng nhập này đã được sử dụng. Vui lòng chọn tên khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTendn.Focus();
                }
                else
                {
                    // 5. Nếu chưa tồn tại, tiến hành INSERT tài khoản mới bằng hàm writedata
                    string insertQuery = $@"INSERT INTO TaiKhoan(HoTen, TenDangNhap, MatKhauHash, SoDienThoai, Email, VaiTro)
                        VALUES(N'{hoTen}', '{tenDangNhap}', '{matKhau}', '{sdt}', '{email}', N'KhachHang')";

                    int rowEffect = db.writedata(insertQuery);

                    // Kiểm tra kết quả trả về từ writedata
                    if (rowEffect > 0)
                    {
                        MessageBox.Show("Đăng ký tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // (Tùy chọn) Xóa trắng form sau khi đăng ký thành công
                        txtHoten.Clear();
                        txtTendn.Clear();
                        txtMk.Clear();
                        txtXacnhanmk.Clear();
                        txtSdt.Clear();
                        txtEmail.Clear();
                        txtHoten.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại, vui lòng kiểm tra lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        public EventHandler bamnutdangky;
        private void btnDnhap_Click(object sender, EventArgs e)
        {
            // Chuyển về form đăng nhập (nếu có)
            bamnutdangky?.Invoke(this ,EventArgs.Empty );
            
            this.Close();
        }
    }

}
