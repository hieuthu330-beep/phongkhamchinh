using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phongkham1
{
    public partial class Formqlybacsi : Form
    {
        ConnectDB db = new ConnectDB();

        public Formqlybacsi()
        {
            InitializeComponent();
            LoadChuyenkhoa();
            LoaddtgDanhsachbacsi();
        }

        private void LoadChuyenkhoa()
        {
            string sql = "SELECT ChuyenKhoaID, TenChuyenKhoa FROM ChuyenKhoa";
            DataTable dt = db.readdata(sql);
            if (dt != null)
            {
                cboChuyenkhoa.DataSource = dt;
                cboChuyenkhoa.DisplayMember = "TenChuyenKhoa";
                cboChuyenkhoa.ValueMember = "ChuyenKhoaID";
                cboChuyenkhoa.SelectedIndex = -1;
            }
        }

        private void LoaddtgDanhsachbacsi()
        {
            string sql = @"SELECT b.BacSiID, b.HoTen, c.TenChuyenKhoa, b.MoTa, b.SoDienThoai, b.TaiKhoanID, 
                   CASE WHEN b.TrangThai = 1 THEN N'Đang hoạt động' ELSE N'Ngừng hoạt động' END AS TrangThai 
                   FROM BacSi b JOIN ChuyenKhoa c ON b.ChuyenKhoaID = c.ChuyenKhoaID";

            DataTable dt = db.readdata(sql);
            if (dt != null)
            {
                dtgDanhsachbacsi.DataSource = dt;
            }
        }

        private void cleardata()
        {
            txtMabs.Text = "";
            txtHoten.Text = "";
            cboChuyenkhoa.SelectedIndex = -1;
            txtMota.Text = "";
            txtSdt.Text = "";
            cboTrangthai.SelectedIndex = -1;
            // Nếu trên form có ô chứa mã tài khoản ẩn hoặc hiện, em clear luôn ở đây:
            // txtMataikhoan.Text = ""; 
        }

        private void Formqlybacsi_Load(object sender, EventArgs e)
        {
            LoaddtgDanhsachbacsi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            cleardata();
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            txtHoten.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string hoten = txtHoten.Text.Trim();
            if (cboChuyenkhoa.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn chuyên khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string chuyenkhoaID = cboChuyenkhoa.SelectedValue.ToString();
            string mota = txtMota.Text.Trim();
            string sdt = txtSdt.Text.Trim();

            // Lấy trạng thái từ ComboBox (hoặc mặc định là 1 nếu chưa chọn)
            int trangThai = (cboTrangthai.Text == "Đang hoạt động" || cboTrangthai.SelectedIndex == 0) ? 1 : 0;

            if (string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // BƯỚC 1: Tự động tạo tài khoản đăng nhập cho Bác sĩ trong bảng TaiKhoan
            string sqlTaoTK = $@"INSERT INTO TaiKhoan (HoTen, TenDangNhap, MatKhauHash, SoDienThoai, VaiTro) 
                                VALUES (N'{hoten}', '{sdt}', '123456', '{sdt}', N'BacSi'); 
                                SELECT IDENT_CURRENT('TaiKhoan') AS TaiKhoanID;";

            DataTable dtTK = db.readdata(sqlTaoTK);

            if (dtTK == null || dtTK.Rows.Count == 0)
            {
                MessageBox.Show("Tạo tài khoản thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string taiKhoanID = dtTK.Rows[0]["TaiKhoanID"].ToString();

            // BƯỚC 2: Xử lý Mô tả (nếu trống thì lưu NULL)
            string motaSQL = string.IsNullOrEmpty(mota) ? "NULL" : "N'" + mota + "'";

            // BƯỚC 3: Thêm Bác sĩ mới gắn kèm TaiKhoanID vừa tạo
            string sql = $@"INSERT INTO BacSi (HoTen, ChuyenKhoaID, MoTa, SoDienThoai, TrangThai, TaiKhoanID)
                            VALUES (N'{hoten}', {chuyenkhoaID}, {motaSQL}, '{sdt}', {trangThai}, {taiKhoanID})";

            int roweffect = db.writedata(sql);
            if (roweffect > 0)
            {
                MessageBox.Show("Thêm bác sĩ và tạo tài khoản thành công!\n(Tài khoản: " + sdt + " / MK: 123456)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddtgDanhsachbacsi();
                cleardata();

                // Khôi phục trạng thái nút bấm
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thêm bác sĩ thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mabs = txtMabs.Text.Trim();
            string hoten = txtHoten.Text.Trim();
            string chuyenkhoaID = cboChuyenkhoa.SelectedValue?.ToString() ?? "";
            string mota = txtMota.Text.Trim();
            string sdt = txtSdt.Text.Trim();
            int trangThai = (cboTrangthai.Text == "Đang hoạt động") ? 1 : 0;

            if (string.IsNullOrEmpty(mabs))
            {
                MessageBox.Show("Vui lòng chọn bác sĩ cần sửa từ danh sách bảng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Họ tên và Số điện thoại không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string motaSQL = string.IsNullOrEmpty(mota) ? "NULL" : "N'" + mota + "'";

            string sql = $@"UPDATE BacSi 
                       SET HoTen = N'{hoten}', 
                           ChuyenKhoaID = {chuyenkhoaID}, 
                           MoTa = {motaSQL}, 
                           SoDienThoai = '{sdt}', 
                           TrangThai = {trangThai} 
                       WHERE BacSiID = '{mabs}'";

            int roweffect = db.writedata(sql);

            if (roweffect > 0)
            {
                MessageBox.Show("Cập nhật thông tin bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddtgDanhsachbacsi();
                cleardata();
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra, không thể cập nhật dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgDanhsachbacsi.CurrentRow != null && !string.IsNullOrEmpty(txtMabs.Text))
            {
                string maBacSi = txtMabs.Text.Trim();

                // Lấy mã tài khoản từ cột thứ 5 (hoặc cell tương ứng chứa TaiKhoanID trên DataGridView)
                string maTK = "";
                if (dtgDanhsachbacsi.CurrentRow.Cells.Count > 5 && dtgDanhsachbacsi.CurrentRow.Cells[5].Value != null)
                {
                    maTK = dtgDanhsachbacsi.CurrentRow.Cells[5].Value.ToString();
                }

                DialogResult dialogResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa bác sĩ và tài khoản liên kết không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.Yes)
                {
                    // Xóa Bác sĩ trước (vì chứa khóa ngoại trỏ sang TaiKhoan)
                    string sqlXoaBS = $"DELETE FROM BacSi WHERE BacSiID = '{maBacSi}'";
                    int roweffect = db.writedata(sqlXoaBS);

                    if (roweffect > 0)
                    {
                        // Xóa luôn tài khoản tương ứng trong bảng TaiKhoan nếu có
                        if (!string.IsNullOrEmpty(maTK))
                        {
                            string sqlXoaTK = $"DELETE FROM TaiKhoan WHERE TaiKhoanID = {maTK}";
                            db.writedata(sqlXoaTK);
                        }

                        MessageBox.Show("Xóa bác sĩ và tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoaddtgDanhsachbacsi();
                        cleardata();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại! Bác sĩ này có thể đang liên kết với lịch khám hoặc dữ liệu khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng bác sĩ cần xóa trên bảng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Đổi từ MouseClick sang CellMouseClick để chuẩn xác và tránh lỗi vùng trống


        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTimkiem.Text.Trim();

            string sql = $@"SELECT b.BacSiID, b.HoTen, c.TenChuyenKhoa, b.MoTa, b.SoDienThoai, b.TaiKhoanID, 
                   CASE WHEN b.TrangThai = 1 THEN N'Đang hoạt động' ELSE N'Ngừng hoạt động' END AS TrangThai 
                   FROM BacSi b 
                   JOIN ChuyenKhoa c ON b.ChuyenKhoaID = c.ChuyenKhoaID 
                   WHERE b.BacSiID LIKE N'%{keyword}%' OR b.HoTen LIKE N'%{keyword}%'";

            DataTable dt = db.readdata(sql);

            if (dt != null)
            {
                dtgDanhsachbacsi.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy kết quả nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dtgDanhsachbacsi_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtgDanhsachbacsi.Rows[e.RowIndex];

                txtMabs.Text = row.Cells[0].Value?.ToString() ?? "";
                txtHoten.Text = row.Cells[1].Value?.ToString() ?? "";
                cboChuyenkhoa.Text = row.Cells[2].Value?.ToString() ?? "";
                txtMota.Text = row.Cells[3].Value?.ToString() ?? "";
                txtSdt.Text = row.Cells[4].Value?.ToString() ?? "";

                // Nếu cột 5 là TaiKhoanID, cột 6 là TrangThai (tùy theo thứ tự select của câu lệnh SQL ở hàm Load)
                if (row.Cells.Count > 6)
                {
                    cboTrangthai.Text = row.Cells[6].Value?.ToString() ?? "";
                }
            }
        }
    }
}