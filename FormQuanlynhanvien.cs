using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace phongkham1
{
    public partial class FormQuanlynhanvien : Form
    {
        public FormQuanlynhanvien()
        {
            InitializeComponent();
            Loaddata();
        }

        ConnectDB ConnectDB = new ConnectDB();

        private void Loaddata()
        {
            string sql = "SELECT * FROM NhanVien";
            DataTable dt = ConnectDB.readdata(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                dtgNhanvien.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không có dữ liệu nhân viên để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormQuanlynhanvien_Load(object sender, EventArgs e)
        {
            LoaddtgNhanvien();
        }

        private void LoaddtgNhanvien()
        {
            string sql = @"SELECT NhanVienID, HoTen, SoDienThoai, ChucVu, MoTa, TaiKhoanID,  
                           CASE WHEN TrangThai = 0 THEN N'Đã nghỉ việc'  
                                ELSE N'Đang làm việc'  
                           END AS TrangThai
                           FROM NhanVien";
            DataTable dt = ConnectDB.readdata(sql);
            if (dt != null)
            {
                dtgNhanvien.DataSource = dt;
            }
        }

        private void cleardata()
        {
            txtManhanvien.Text = "";
            txtHoten.Text = "";
            txtSodienthoai.Text = "";
            txtMota.Text = "";
            cboTrangthai.SelectedIndex = -1;
            txtMataikhoan.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            cleardata();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Lấy thông tin từ các ô nhập
            string HoTen = txtHoten.Text.Trim();
            string SoDienThoai = txtSodienthoai.Text.Trim();
            string MoTa = txtMota.Text.Trim();

            if (string.IsNullOrEmpty(HoTen) || string.IsNullOrEmpty(SoDienThoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // --- BƯỚC 1: Thêm tài khoản mới bằng writedata (dùng lệnh INSERT thuần túy) ---
            string sqlInsertTK = $@"INSERT INTO TaiKhoan (HoTen, TenDangNhap, MatKhauHash, SoDienThoai, VaiTro) 
                        VALUES (N'{HoTen}', '{SoDienThoai}', '123456', '{SoDienThoai}', N'NhanVien')";

            int ketQuaTK = ConnectDB.writedata(sqlInsertTK);
            if (ketQuaTK <= 0)
            {
                MessageBox.Show("Tạo tài khoản thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // --- BƯỚC 2: Dùng readdata để SELECT lấy ra TaiKhoanID vừa tạo dựa vào Số điện thoại ---
            string sqlLayID = $"SELECT TaiKhoanID FROM TaiKhoan WHERE SoDienThoai = '{SoDienThoai}'";
            DataTable dtTK = ConnectDB.readdata(sqlLayID);

            if (dtTK == null || dtTK.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy mã tài khoản vừa tạo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lấy được con số ID tài khoản
            string taiKhoanID = dtTK.Rows[0]["TaiKhoanID"].ToString();

            // --- BƯỚC 3: Dùng writedata để thêm nhân viên gắn kèm cái TaiKhoanID vừa lấy ---
            string moTaSQL = string.IsNullOrEmpty(MoTa) ? "NULL" : "N'" + MoTa + "'";

            string sqlInsertNV = $@"INSERT INTO NhanVien (HoTen, SoDienThoai, ChucVu, TrangThai, MoTa, TaiKhoanID) 
                        VALUES (N'{HoTen}', '{SoDienThoai}', N'Nhan vien', 1, {moTaSQL}, {taiKhoanID})";

            int ketQuaNV = ConnectDB.writedata(sqlInsertNV);

            if (ketQuaNV > 0)
            {
                MessageBox.Show("Thêm nhân viên và tạo tài khoản thành công!\n(Tài khoản: " + SoDienThoai + " / MK: 123456)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddtgNhanvien();
                cleardata();
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtManhanvien.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa từ bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = txtManhanvien.Text;
            string hoTen = txtHoten.Text;
            string soDienThoai = txtSodienthoai.Text;
            string moTa = txtMota.Text;

            int trangThai = (cboTrangthai.Text == "Đang làm việc") ? 1 : 0;

            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Họ tên và Số điện thoại không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string moTaSQL = string.IsNullOrEmpty(moTa) ? "NULL" : "N'" + moTa + "'";

            string sql = "UPDATE NhanVien SET ";
            sql += "HoTen = N'" + hoTen + "', ";
            sql += "SoDienThoai = '" + soDienThoai + "', ";
            sql += "TrangThai = " + trangThai + ", ";
            sql += "MoTa = " + moTaSQL + " ";
            sql += "WHERE NhanVienID = " + maNV;

            int result = ConnectDB.writedata(sql);

            if (result > 0)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddtgNhanvien();
                cleardata();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgNhanvien_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgNhanvien.Rows[e.RowIndex];

                txtManhanvien.Text = row.Cells[0].Value.ToString();
                txtHoten.Text = row.Cells[1].Value.ToString();
                txtSodienthoai.Text = row.Cells[2].Value.ToString();
                txtMota.Text = row.Cells[4].Value.ToString();
                txtMataikhoan.Text = row.Cells[5].Value.ToString();
                cboTrangthai.Text = row.Cells[6].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtManhanvien.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa từ bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên và tài khoản có mã: " + txtManhanvien.Text + " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                string maNV = txtManhanvien.Text.Trim();
                string maTK = txtMataikhoan.Text.Trim();

                // Xóa nhân viên trước (vì bảng NhanVien chứa khóa ngoại trỏ sang TaiKhoan)
                string sqlXoaNV = "DELETE FROM NhanVien WHERE NhanVienID = " + maNV;
                int result = ConnectDB.writedata(sqlXoaNV);

                if (result > 0)
                {
                    // Sau khi xóa nhân viên thành công thì xóa luôn dòng tài khoản tương ứng
                    if (!string.IsNullOrEmpty(maTK))
                    {
                        string sqlXoaTK = "DELETE FROM TaiKhoan WHERE TaiKhoanID = " + maTK;
                        ConnectDB.writedata(sqlXoaTK);
                    }

                    MessageBox.Show("Xóa nhân viên và tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoaddtgNhanvien();
                    cleardata();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Nhân viên này có thể đang liên kết với dữ liệu khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            cleardata();
            dtgNhanvien.ClearSelection();

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

            LoaddtgNhanvien();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimkiem.Text.Trim();

            string sql = @"SELECT NhanVienID, HoTen, SoDienThoai, ChucVu, MoTa, TaiKhoanID,  
                           CASE WHEN TrangThai = 0 THEN N'Đã nghỉ việc'  
                                ELSE N'Đang làm việc'  
                           END AS TrangThai
                           FROM NhanVien  
                           WHERE NhanVienID LIKE N'%" + tuKhoa + "%' OR HoTen LIKE N'%" + tuKhoa + "%'";

            DataTable dt = ConnectDB.readdata(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                dtgNhanvien.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}