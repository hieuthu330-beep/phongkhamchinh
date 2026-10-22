using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phongkham1
{
    public partial class Formdontiepbenhnhan : Form
    {
        ConnectDB db = new ConnectDB();
        public Formdontiepbenhnhan()
        {
            InitializeComponent();
            LoadLichHenHomNay();
        }
        private void LoadLichHenHomNay(string tuKhoa = "")
        {
            string ngayHomNay = DateTime.Now.ToString("yyyy-MM-dd");
            string sql = $@"SELECT lh.LichHenID, 
                                    tk.HoTen AS TenBenhNhan, 
                                    tk.SoDienThoai, 
                                    bs.HoTen AS TenBacSi, 
                                    ck.TenChuyenKhoa, 
                                    lh.KhungGio, 
                                    lh.MoTaTrieuChung, 
                                    lh.TrangThai
                             FROM LichHen lh
                             JOIN TaiKhoan tk ON lh.TaiKhoanID = tk.TaiKhoanID
                             JOIN BacSi bs ON lh.BacSiID = bs.BacSiID
                             JOIN ChuyenKhoa ck ON lh.ChuyenKhoaID = ck.ChuyenKhoaID
                             WHERE lh.NgayKham = '{ngayHomNay}'";
            if (!string.IsNullOrWhiteSpace(tuKhoa))
            {
                sql += $" AND tk.HoTen LIKE N'%{tuKhoa}%'";
            }
            DataTable dt = db.readdata(sql);
            if (dt != null)
            {
                dgvLichHen.DataSource = dt;
            }
            else dgvLichHen.DataSource = null;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            LoadLichHenHomNay(tuKhoa);
        }

        private void btnLoadTatCa_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            LoadLichHenHomNay();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (dgvLichHen.SelectedRows.Count > 0)
            {
                int lichHenID = Convert.ToInt32(dgvLichHen.SelectedRows[0].Cells[0].Value);
                string trangThaiHienTai = dgvLichHen.SelectedRows[0].Cells[7].Value.ToString();
                if (trangThaiHienTai == "Đã hủy")
                {
                    MessageBox.Show("Lịch hẹn này đã bị hủy, không thể tiếp đón!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string updateQuery = $"UPDATE LichHen SET TrangThai = N'Chờ khám' WHERE LichHenID = {lichHenID}";
                int rowEffect = db.writedata(updateQuery);

                if (rowEffect > 0)
                {
                    MessageBox.Show("Tiếp đón bệnh nhân thành công! Đã chuyển vào hàng đợi của Bác sĩ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadLichHenHomNay(txtTimKiem.Text.Trim());
                }
                else
                {
                    MessageBox.Show("Cập nhật trạng thái thất bại, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lịch hẹn trên danh sách để check-in!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvLichHen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
