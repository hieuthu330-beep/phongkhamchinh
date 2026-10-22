using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phongkham1
{
    public partial class FormMainAdmin : Form
    {
        public FormMainAdmin()
        {
            InitializeComponent();
        }
        private void loadAdmin(Form admin)
        {
            pnlNoidung.Controls.Clear();
            admin.TopLevel = false;
            pnlNoidung.Controls.Add(admin);
            admin.Show();
        }
        private void btn_Nhanvien_Click(object sender, EventArgs e)
        {
            loadAdmin(new FormQuanlynhanvien());
        }

        private void btn_Thuoc_Click(object sender, EventArgs e)
        {
            loadAdmin(new FormQuanlythuoc());
        }

        private void btn_Chuyenkhoa_Click(object sender, EventArgs e)
        {
            loadAdmin(new FormQuanlychuyenkhoa());
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            // 1. Hiển thị hộp thoại xác nhận đăng xuất (tùy chọn)
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn đăng xuất không?",
                "Xác nhận đăng xuất",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                // 2. Tùy chọn: Xóa các thông tin phiên làm việc / người dùng hiện tại (nếu có)
                // Session.CurrentUser = null;

                // 3. Khởi tạo và hiển thị màn hình giới thiệu / đăng nhập
                // Thay 'FormIntro' bằng tên class Form giới thiệu thực tế trong dự án của bạn
                Form1 formIntro = new Form1();
                formIntro.Show();

                // 4. Đóng Form quản trị hiện tại (FormMainAdmin)
                this.Close();

                // Hoặc dùng this.Hide() nếu bạn muốn giữ FormMainAdmin ẩn trong bộ nhớ:
                // this.Hide();
            }
        }

        private void btn_Lichhen_Click(object sender, EventArgs e)
        {
            loadAdmin(new Formquanlylichhenadmin());
        }

        private void btn_Baocao_Click(object sender, EventArgs e)
        {
            loadAdmin(new FormBaoCao());
        }

        private void btn_Bacsi_Click(object sender, EventArgs e)
        {
            loadAdmin(new Formqlybacsi());
        }
    }
}
