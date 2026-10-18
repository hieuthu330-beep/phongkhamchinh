using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phongkham1
{
    public partial class formThanhToanPhatthuocNhanvien : Form
    {
        ConnectDB db = new ConnectDB();
        public formThanhToanPhatthuocNhanvien()
        {
            InitializeComponent();
            loaddanhsachbenhnhanchothanhtoan();
        }
        private void loaddanhsachbenhnhanchothanhtoan()
        {
            string ngayHomNay = DateTime.Now.ToString("yyyy-MM-dd");
            string sql = $@"SELECT lh.LichHenID, 
                            tk.HoTen AS TenBenhNhan, 
                            tk.SoDienThoai, 
                            bs.HoTen AS TenBacSi, 
                            lh.KhungGio, 
                            lh.TrangThai
                     FROM LichHen lh
                     JOIN TaiKhoan tk ON lh.TaiKhoanID = tk.TaiKhoanID
                     JOIN BacSi bs ON lh.BacSiID = bs.BacSiID
                     WHERE lh.NgayKham = '{ngayHomNay}' 
                       AND lh.TrangThai = N'Chờ thanh toán'";
            DataTable dt = db.readdata(sql);
            dgvDanhSachChoThanhToan.DataSource = dt;
        }
        int selectedLichHenID = -1;
        private void dgvDanhSachChoThanhToan_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedLichHenID = Convert.ToInt32(dgvDanhSachChoThanhToan.CurrentRow.Cells[0].Value);
            string sql = $@"SELECT t.TenThuoc, 
                                        t.DonViTinh, 
                                        ct.SoLuong, 
                                        t.DonGia, 
                                        (ct.SoLuong * t.DonGia) AS ThanhTien, 
                                        ct.CachDung
                                 FROM DonThuoc dt
                                 JOIN ChiTietDonThuoc ct ON dt.DonThuocID = ct.DonThuocID
                                 JOIN Thuoc t ON ct.ThuocID = t.ThuocID
                                 WHERE dt.LichHenID = {selectedLichHenID}";
            DataTable dt = db.readdata(sql);
            dgvChiTietDonThanhToan.DataSource = dt;
            decimal tongTienThuoc = 0;
            if (dgvChiTietDonThanhToan != null)
            {
                foreach (DataGridViewRow r in dgvChiTietDonThanhToan.Rows)
                {
                    tongTienThuoc += Convert.ToDecimal(r.Cells[4].Value);
                }
            }

            // Giả sử phí khám cố định là 150,000 VNĐ, tổng tiền = Phí khám + Tiền thuốc
            decimal phiKham = 150000;
            decimal tongThanhToan = phiKham + tongTienThuoc;

            // Hiển thị ra Label tổng tiền trên giao diện (Ví dụ: lblTongTien)
            lblTongTien.Text = tongThanhToan.ToString("N0") + " VNĐ";
            tongtienkham = tongThanhToan;
        }
        private decimal tongtienkham;
        private void btnThanhToanXuatThuoc_Click(object sender, EventArgs e)
        {
            if (selectedLichHenID == -1)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần thanh toán trong danh sách!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int nhanVienID = UserSession.CurrentUser.TaiKhoanID; 
            decimal tongTien = tongtienkham;
            string insertHoaDon = $@"INSERT INTO HoaDon (LichHenID, NhanVienID, NgayThanhToan, TienKham, TienThuoc, TongTien, TrangThai) 
                                  VALUES ({selectedLichHenID}, {nhanVienID}, GETDATE(), 150000, {tongTien - 150000}, {tongTien}, N'Đã thanh toán')";
            db.writedata(insertHoaDon);
            string getDonThuocID = $"SELECT DonThuocID FROM DonThuoc WHERE LichHenID = {selectedLichHenID}";
            DataTable dtDon = db.readdata(getDonThuocID);
            if (dtDon != null && dtDon.Rows.Count > 0)
            {
                int donThuocID = Convert.ToInt32(dtDon.Rows[0]["DonThuocID"]);

                // Cập nhật trạng thái đơn thuốc thành "Đã cấp thuốc"
                db.writedata($"UPDATE DonThuoc SET TrangThai = N'Đã cấp thuốc' WHERE DonThuocID = {donThuocID}");

                // 3. Trừ số lượng tồn kho trong bảng Thuoc dựa vào các chi tiết đơn thuốc
                string getChiTiet = $"SELECT ThuocID, SoLuong FROM ChiTietDonThuoc WHERE DonThuocID = {donThuocID}";
                DataTable dtCT = db.readdata(getChiTiet);
                foreach (DataRow row in dtCT.Rows)
                {
                    int thuocID = Convert.ToInt32(row["ThuocID"]);
                    int soLuongBan = Convert.ToInt32(row["SoLuong"]);

                    // Trừ kho
                    db.writedata($"UPDATE Thuoc SET SoLuongTon = SoLuongTon - {soLuongBan} WHERE ThuocID = {thuocID}");
                }
            }

            // 4. Cập nhật trạng thái lịch hẹn thành "Hoàn tất"
            db.writedata($"UPDATE LichHen SET TrangThai = N'Hoàn tất' WHERE LichHenID = {selectedLichHenID}");

            MessageBox.Show("Thanh toán và xuất kho thuốc thành công! Ca khám đã hoàn tất.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Load lại danh sách chờ thanh toán
            loaddanhsachbenhnhanchothanhtoan();
            dgvChiTietDonThanhToan.DataSource=null;
            selectedLichHenID = -1;
        }
    }

}
