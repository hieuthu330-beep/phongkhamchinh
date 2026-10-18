using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phongkham1
{
    public partial class Formlichhen : Form
    {
        ConnectDB db = new ConnectDB();
        public Formlichhen()
        {
            InitializeComponent();
            LoadDanhSachLichHen();
        }


        private void LoadDanhSachLichHen()
        {
            flpLichhen.Controls.Clear();

            int currentTaiKhoanID = UserSession.CurrentUser.TaiKhoanID;

            // Câu lệnh SQL lấy lịch hẹn và lọc thẳng theo TaiKhoanID đang đăng nhập
            string query = $@"SELECT lh.LichHenID, tk.HoTen AS TenKhachHang, tk.SoDienThoai AS SoDienThoaiKH, 
                                    bs.HoTen AS TenBacSi, ck.TenChuyenKhoa, lh.NgayKham, lh.KhungGio, lh.TrangThai
                             FROM LichHen lh
                             INNER JOIN TaiKhoan tk ON lh.TaiKhoanID = tk.TaiKhoanID
                             INNER JOIN BacSi bs ON lh.BacSiID = bs.BacSiID
                             INNER JOIN ChuyenKhoa ck ON lh.ChuyenKhoaID = ck.ChuyenKhoaID
                             WHERE lh.TaiKhoanID = {currentTaiKhoanID}";

            DataTable dt = db.readdata(query);

            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    int lichHenID = Convert.ToInt32(row["LichHenID"]);
                    string tenKH = row["TenKhachHang"].ToString();
                    string sdtKH = row["SoDienThoaiKH"] == DBNull.Value ? "Chưa có" : row["SoDienThoaiKH"].ToString();
                    string tenBS = row["TenBacSi"].ToString();
                    string tenCK = row["TenChuyenKhoa"].ToString();

                    DateTime ngayKham = Convert.ToDateTime(row["NgayKham"]);
                    string ngayKhamStr = ngayKham.ToString("dd/MM/yyyy");

                    string khungGio = row["KhungGio"].ToString();
                    string trangThai = row["TrangThai"].ToString();

                    Panel pnlItem = TaoPanelLichHen(lichHenID, tenKH, sdtKH, tenBS, tenCK, ngayKhamStr, khungGio, trangThai);
                    flpLichhen.Controls.Add(pnlItem);
                }
            }
            else
            {
                Label lblEmpty = new Label();
                lblEmpty.Text = "Bạn chưa có lịch hẹn nào.";
                lblEmpty.Font = new Font("Segoe UI", 24, FontStyle.Italic);
                lblEmpty.ForeColor = Color.Gray;
                lblEmpty.AutoSize = true;
                flpLichhen.Controls.Add(lblEmpty);
            }
        }

        private Panel TaoPanelLichHen(int id, string tenKH, string sdtKH, string tenBS, string tenCK, string ngayKham, string khungGio, string trangThai)
        {
            Panel panel = new Panel();
            panel.Size = new Size(flpLichhen.Width - 30, 110);
            panel.BackColor = Color.White;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Margin = new Padding(5);

            // Label Tên & SĐT Khách Hàng
            Label lblKhachHang = new Label();
            lblKhachHang.Text = $"Khách hàng: {tenKH} - SĐT: {sdtKH}";
            lblKhachHang.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            lblKhachHang.ForeColor = Color.FromArgb(0, 50, 100);
            lblKhachHang.Location = new Point(15, 12);
            lblKhachHang.AutoSize = true;
            panel.Controls.Add(lblKhachHang);

            // Label Chuyên Khoa & Bác Sĩ
            Label lblChuyenKhoaBacSi = new Label();
            lblChuyenKhoaBacSi.Text = $"Chuyên khoa: {tenCK} | Bác sĩ: {tenBS}";
            lblChuyenKhoaBacSi.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblChuyenKhoaBacSi.Location = new Point(15, 40);
            lblChuyenKhoaBacSi.AutoSize = true;
            panel.Controls.Add(lblChuyenKhoaBacSi);

            // Label Thời Gian Khám
            Label lblThoiGian = new Label();
            lblThoiGian.Text = $"Thời gian: {ngayKham} ({khungGio})";
            lblThoiGian.Font = new Font("Segoe UI", 9, FontStyle.Regular);
            lblThoiGian.Location = new Point(15, 65);
            lblThoiGian.AutoSize = true;
            panel.Controls.Add(lblThoiGian);

            // Label Trạng Thái
            Label lblTrangThai = new Label();
            lblTrangThai.Text = $"Trạng thái: {trangThai}";
            lblTrangThai.Font = new Font("Segoe UI", 9, FontStyle.Italic);
            lblTrangThai.ForeColor = (trangThai == "Đã hủy") ? Color.Red : Color.Green;
            lblTrangThai.Location = new Point(15, 88);
            lblTrangThai.AutoSize = true;
            panel.Controls.Add(lblTrangThai);

            // Nút Hủy Lịch
            Button btnHuy = new Button();
            btnHuy.Text = "Hủy lịch";
            btnHuy.Size = new Size(90, 30);
            btnHuy.Location = new Point(panel.Width - 110, 38);
            btnHuy.BackColor = Color.FromArgb(231, 76, 60);
            btnHuy.ForeColor = Color.White;
            btnHuy.FlatStyle = FlatStyle.Flat;
            btnHuy.Cursor = Cursors.Hand;

            btnHuy.Tag = id;
            if (trangThai == "chờ xác nhận"|| trangThai == "xác nhận")
            {
                btnHuy.Click += BtnHuy_Click;
            }
            panel.Controls.Add(btnHuy);

            return panel;
        }

        private void BtnHuy_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                int lichHenID = (int)btn.Tag;

                DialogResult dr = MessageBox.Show("Bạn có chắc chắn muốn hủy lịch hẹn này không?",
                                                 "Xác nhận hủy lịch", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    string query = $"UPDATE LichHen SET TrangThai = N'Đã hủy' WHERE LichHenID = {lichHenID}";
                    int rowEffect = db.writedata(query);

                    if (rowEffect > 0)
                    {
                        MessageBox.Show("Hủy lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDanhSachLichHen();
                    }
                    else
                    {
                        MessageBox.Show("Hủy lịch hẹn thất bại. Vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
