using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phongkham1
{
    public partial class FormKhamBenh : Form
    {
        public FormKhamBenh()
        {
            InitializeComponent();
            LayBacSiIDHienTai();
            LoadDanhSachCho();
            LoadComboboxThuoc();
        }
        ConnectDB db = new ConnectDB();
        private int currentBacSiID = -1;
        private void LayBacSiIDHienTai()
        {
            int taiKhoanID = UserSession.CurrentUser.TaiKhoanID;
            string query = $"SELECT BacSiID FROM BacSi WHERE TaiKhoanID = {taiKhoanID}";
            DataTable dt = db.readdata(query);
            currentBacSiID = Convert.ToInt32(dt.Rows[0]["BacSiID"]);
        }
        private void LoadDanhSachCho()
        {
            string ngayHomNay = DateTime.Now.ToString("yyyy-MM-dd");
            string query = $@"SELECT lh.LichHenID, tk.HoTen AS TenBenhNhan, tk.SoDienThoai, 
                                    lh.KhungGio, lh.MoTaTrieuChung, lh.TrangThai
                             FROM LichHen lh
                             JOIN TaiKhoan tk ON lh.TaiKhoanID = tk.TaiKhoanID
                             WHERE lh.BacSiID = {currentBacSiID} 
                               AND lh.NgayKham = '{ngayHomNay}' 
                               AND lh.TrangThai = N'Chờ khám'";

            DataTable dt = db.readdata(query);
            dgvDanhSachCho.DataSource = dt;
        }
        private int selectedLichHenID = -1;

        private void dgvDanhSachCho_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            selectedLichHenID = Convert.ToInt32(dgvDanhSachCho.CurrentRow.Cells[0].Value);

            if (dgvDanhSachCho.CurrentRow.Cells[4].Value != null)
            {
                lblTrieuchung.Text = dgvDanhSachCho.CurrentRow.Cells[4].Value.ToString();
            }
        }


        private void LoadComboboxThuoc()
        {
            string query = "SELECT ThuocID, TenThuoc, DonViTinh, DonGia FROM Thuoc WHERE SoLuongTon > 0";
            DataTable dt = db.readdata(query);
            if (dt != null)
            {
                cbThuoc.DataSource = dt;
                cbThuoc.DisplayMember = "TenThuoc";
                cbThuoc.ValueMember = "ThuocID";
            }
        }

        private void btnThemThuocVaoDon_Click(object sender, EventArgs e)
        {
            if (cbThuoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn thuốc trong kho!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int thuocID = Convert.ToInt32(cbThuoc.SelectedValue);
            string tenThuoc = cbThuoc.Text;
            int soLuong = 0;
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text) || !int.TryParse(txtSoLuong.Text.Trim(), out soLuong) || soLuong <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng thuốc là số nguyên lớn hơn 0!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoLuong.Focus();
                return;
            }

            string cachDung = txtCachDung.Text.Trim();

            bool daCo = false;
            foreach (DataGridViewRow row in dgvChiTietDon.Rows)
            {
                if (row.IsNewRow) continue;

                if (row.Cells[0].Value != null && Convert.ToInt32(row.Cells[0].Value) == thuocID)
                {
                    int slCu = Convert.ToInt32(row.Cells[2].Value);
                    row.Cells[2].Value = slCu + soLuong;
                    row.Cells[3].Value = cachDung;
                    daCo = true;
                    break;
                }
            }

            // Nếu chưa có thì thêm dòng mới vào DataGridView
            if (!daCo)
            {
                dgvChiTietDon.Rows.Add(thuocID, tenThuoc, soLuong, cachDung);
            }

            // Xóa trắng ô nhập liệu để nhập loại tiếp theo
            txtCachDung.Clear();
            txtSoLuong.Clear();
        }
        private void btnHoanTatKham_Click(object sender, EventArgs e)
        {
            if (selectedLichHenID == -1)
            {
                MessageBox.Show("Vui lòng chọn bệnh nhân cần khám trong danh sách chờ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string chanDoan = txtChanDoan.Text.Trim();
            string loiDan = txtLoiDan.Text.Trim();

            if (string.IsNullOrEmpty(chanDoan))
            {
                MessageBox.Show("Vui lòng nhập chẩn đoán bệnh!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgvChiTietDon.Rows.Count == 0 || (dgvChiTietDon.Rows.Count == 1 && dgvChiTietDon.Rows[0].IsNewRow))
            {
                MessageBox.Show("Đơn thuốc chưa có loại thuốc nào!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bước A: Lưu vào bảng DonThuoc
            string ghiChuDon = $"Chẩn đoán: {chanDoan} | Lời dặn: {loiDan}";
            string insertDonThuoc = $"INSERT INTO DonThuoc (LichHenID, BacSiID,NgayKe, LoiDan, TrangThai) VALUES ({selectedLichHenID}, {currentBacSiID},'{DateTime.Now}', N'{ghiChuDon}', N'Chưa thanh toán')";
            int rowDon = db.writedata(insertDonThuoc);

            if (rowDon > 0)
            {
                // Lấy DonThuocID vừa được tạo tự động gần nhất
                string getIDQuery = "SELECT MAX(DonThuocID) FROM DonThuoc";
                DataTable dtID = db.readdata(getIDQuery);
                int donThuocID = Convert.ToInt32(dtID.Rows[0][0]);

                // Bước B: Duyệt qua các dòng trong dgvChiTietDon để lưu vào database
                foreach (DataGridViewRow row in dgvChiTietDon.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        int tID = Convert.ToInt32(row.Cells[0].Value);
                        int sl = Convert.ToInt32(row.Cells[2].Value);
                        string cachDung = row.Cells[2].Value?.ToString() ?? "";

                        string insertChiTiet = $@"INSERT INTO ChiTietDonThuoc (DonThuocID, ThuocID, SoLuong, CachDung) 
                                                      VALUES ({donThuocID}, {tID}, {sl}, N'{cachDung}')";
                        db.writedata(insertChiTiet);
                    }
                }

                // Bước C: Cập nhật trạng thái lịch hẹn sang "Chờ thanh toán"
                string updateLichHen = $"UPDATE LichHen SET TrangThai = N'Chờ thanh toán' WHERE LichHenID = {selectedLichHenID}";
                db.writedata(updateLichHen);

                MessageBox.Show("Khám bệnh và kê đơn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset lại giao diện
                LoadDanhSachCho();
                txtChanDoan.Clear();
                txtLoiDan.Clear();
                dgvChiTietDon.Rows.Clear();
                selectedLichHenID = -1;
            }
            else
            {
                MessageBox.Show("Lỗi khi lưu đơn thuốc, vui lòng thử lại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormKhamBenh_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
