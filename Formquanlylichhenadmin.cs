using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phongkham1
{
    public partial class Formquanlylichhenadmin : Form
    {
        private ConnectDB db = new ConnectDB();
        public Formquanlylichhenadmin()
        {
            InitializeComponent();
            LoadComboBoxFilter();
            LoadDanhSachGiamSat();
        }
        private void LoadComboBoxFilter()
        {
            cboTrangThaiFilter.Items.Clear();
            cboTrangThaiFilter.Items.Add("Tất cả");
            cboTrangThaiFilter.Items.Add("Chờ xác nhận");
            cboTrangThaiFilter.Items.Add("Chờ khám");
            cboTrangThaiFilter.Items.Add("Chờ thanh toán");
            cboTrangThaiFilter.Items.Add("Hoàn tất");
            cboTrangThaiFilter.Items.Add("Đã hủy");
            cboTrangThaiFilter.SelectedIndex = 0;
        }
        public void LoadDanhSachGiamSat()
        {
            string ngayKham = dtpNgayKhamFilter.Value.ToString("yyyy-MM-dd");
            string trangThai = cboTrangThaiFilter.SelectedItem != null ? cboTrangThaiFilter.SelectedItem.ToString() : "Tất cả";
            string tuKhoa = txtTimKiem.Text.Trim();

            // Câu lệnh SQL khớp chính xác với cấu trúc cột từ các bảng bạn cung cấp
            string sql = $@"
                SELECT 
                    lh.LichHenID,
                    tk.HoTen AS TenBenhNhan,
                    tk.SoDienThoai,
                    ck.TenChuyenKhoa,
                    bs.HoTen AS TenBacSi,
                    lh.NgayKham,
                    lh.KhungGio,
                    lh.TrangThai,
                    lh.MoTaTrieuChung 
                FROM LichHen lh
                 JOIN TaiKhoan tk ON lh.TaiKhoanID = tk.TaiKhoanID
                JOIN ChuyenKhoa ck ON lh.ChuyenKhoaID = ck.ChuyenKhoaID
                JOIN BacSi bs ON lh.BacSiID = bs.BacSiID
                WHERE CAST(lh.NgayKham AS DATE) = '{ngayKham}'";

            if (trangThai != "Tất cả")
            {
                sql += $" AND lh.TrangThai = N'{trangThai}'";
            }

            if (!string.IsNullOrEmpty(tuKhoa))
            {
                sql += $" AND (tk.HoTen LIKE N'%{tuKhoa}%' OR tk.SoDienThoai LIKE '%{tuKhoa}%')";
            }

            sql += " ORDER BY lh.KhungGio ASC";

            DataTable dt = db.readdata(sql);
            dgvLichHen.DataSource = dt;
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachGiamSat();
            MessageBox.Show("Đã làm mới dữ liệu lịch hẹn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgvLichHen_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridViewRow row = dgvLichHen.CurrentRow;

            txtMaLichHen.Text = row.Cells[0].Value?.ToString();
            txtTenBenhNhan.Text = row.Cells[1].Value?.ToString();
            txtSoDienThoai.Text = row.Cells[2].Value?.ToString();
            txtChuyenKhoa.Text = row.Cells[3].Value?.ToString();
            txtBacSi.Text = row.Cells[4].Value?.ToString();
            txtTrangThai.Text = row.Cells[7].Value?.ToString();
            txtTrieuchung.Text = row.Cells[8].Value?.ToString();
        }

    }

        
}
    

