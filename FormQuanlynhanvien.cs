using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
               CASE WHEN TrangThai = 1 THEN N'Đang làm việc' 
                    ELSE N'Đã nghỉ việc' 
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
            // 1. Lấy thông tin từ các ô nhập trên form
            string HoTen = txtHoten.Text;
            string SoDienThoai = txtSodienthoai.Text;
            string MoTa = txtMota.Text;

            // 2. Kiểm tra thông tin bắt buộc
            if (string.IsNullOrEmpty(HoTen) || string.IsNullOrEmpty(SoDienThoai))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Xử lý Mô tả (nếu để trống thì lưu NULL)
            string moTaSQL = string.IsNullOrEmpty(MoTa) ? "NULL" : "N'" + MoTa + "'";

            // 4. Viết câu lệnh SQL INSERT (Gán ngầm ChucVu mặc định là 'Nhân viên' để tránh lỗi CSDL)
            string sql = "INSERT INTO NhanVien (HoTen, SoDienThoai, ChucVu, TrangThai, MoTa) VALUES (";
            sql += "N'" + HoTen + "', ";
            sql += "'" + SoDienThoai + "', ";
            sql += "N'Nhân viên', "; // Gán giá trị mặc định vì cột ChucVu trong CSDL yêu cầu NOT NULL
            sql += "1, ";            // Trạng thái mặc định là 1 (Đang làm việc)
            sql += moTaSQL + ")";

            // 5. Thực thi câu lệnh
            int result = ConnectDB.writedata(sql);

            if (result > 0)
            {
                MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddtgNhanvien(); // Tải lại bảng dữ liệu
                cleardata();       // Xóa trắng các ô nhập
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem đã chọn nhân viên cần sửa chưa (dựa vào Mã nhân viên)
            if (string.IsNullOrEmpty(txtManhanvien.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần sửa từ bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy dữ liệu từ các ô nhập
            string maNV = txtManhanvien.Text;
            string hoTen = txtHoten.Text;
            string soDienThoai = txtSodienthoai.Text;
            string moTa = txtMota.Text;

            // Chuyển trạng thái từ ComboBox thành số (1: Đang làm việc, 0: Đã nghỉ việc - tùy theo CSDL của bạn)
            // Nếu cboTrangthai của bạn hiển thị chữ "Đang làm việc" / "Đã nghỉ việc":
            int trangThai = (cboTrangthai.Text == "Đang làm việc") ? 1 : 0;

            // 3. Kiểm tra thông tin bắt buộc
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(soDienThoai))
            {
                MessageBox.Show("Họ tên và Số điện thoại không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Xử lý Mô tả (nếu trống thì lưu NULL)
            string moTaSQL = string.IsNullOrEmpty(moTa) ? "NULL" : "N'" + moTa + "'";

            // 5. Viết câu lệnh SQL UPDATE
            string sql = "UPDATE NhanVien SET ";
            sql += "HoTen = N'" + hoTen + "', ";
            sql += "SoDienThoai = '" + soDienThoai + "', ";
            sql += "TrangThai = " + trangThai + ", ";
            sql += "MoTa = " + moTaSQL + " ";
            sql += "WHERE NhanVienID = " + maNV;

            // 6. Thực thi câu lệnh
            int result = ConnectDB.writedata(sql);

            if (result > 0)
            {
                MessageBox.Show("Cập nhật thông tin nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddtgNhanvien(); // Load lại bảng dữ liệu
                cleardata();       // Xóa trắng form
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgNhanvien_MouseClick(object sender, MouseEventArgs e)
        {
            int rowIndex = dtgNhanvien.HitTest(e.X, e.Y).RowIndex;

            if (rowIndex >= 0)
            {
                DataGridViewRow row = dtgNhanvien.Rows[rowIndex];

                // Gán đúng thứ tự cột từ trái sang phải trên bảng:
                txtManhanvien.Text = row.Cells[0].Value.ToString(); // Cột 0: Mã nhân viên
                txtHoten.Text = row.Cells[1].Value.ToString(); // Cột 1: Họ và tên
                txtSodienthoai.Text = row.Cells[2].Value.ToString(); // Cột 2: SĐT
                // (Nếu có ô txtChucvu thì gán row.Cells[3] vào đây, nếu không có thì bỏ qua)
                txtMota.Text = row.Cells[4].Value.ToString(); // Cột 4: Mô tả
                txtMataikhoan.Text = row.Cells[5].Value.ToString(); // Cột 5: Mã tài khoản
                cboTrangthai.Text = row.Cells[6].Value.ToString(); // Cột 6: Trạng thái
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem đã chọn nhân viên cần xóa chưa
            if (string.IsNullOrEmpty(txtManhanvien.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa từ bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Hiển thị hộp thoại xác nhận trước khi xóa
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa nhân viên có mã: " + txtManhanvien.Text + " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                string maNV = txtManhanvien.Text.Trim();

                // 3. Viết câu lệnh SQL DELETE
                string sql = "DELETE FROM NhanVien WHERE NhanVienID = " + maNV;

                // 4. Thực thi câu lệnh
                int result = ConnectDB.writedata(sql);

                if (result > 0)
                {
                    MessageBox.Show("Xóa nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoaddtgNhanvien(); // Tải lại bảng dữ liệu
                    cleardata();       // Xóa trắng form
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Nhân viên này có thể đang liên kết với dữ liệu khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            // 1. Gọi lại hàm xóa trắng các ô nhập liệu
            cleardata();

            // 2. Bỏ chọn dòng trên DataGridView (nếu đang chọn)
            dtgNhanvien.ClearSelection();

            // 3. Đặt lại trạng thái bật/tắt cho các nút bấm theo ý muốn của em
            // Ví dụ: Cho phép bấm Thêm, Sửa, Xóa nhưng tạm khóa nút Lưu cho đến khi bấm Thêm/Sửa
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

            // 4. Load lại dữ liệu mới nhất từ CSDL lên bảng (tùy chọn)
            LoaddtgNhanvien();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            // 1. Lấy từ khóa người dùng nhập vào
            string tuKhoa = txtTimkiem.Text;

            // 2. Viết câu lệnh SQL tìm kiếm (có thể tìm theo Mã nhân viên hoặc Họ tên)
            // Nếu tuKhoa là số (Mã nhân viên) hoặc chữ (Họ tên), câu lệnh dưới đây sẽ lọc được cả hai
            string sql = @"SELECT NhanVienID, HoTen, SoDienThoai, ChucVu, MoTa, TaiKhoanID, 
               CASE WHEN TrangThai = 1 THEN N'Đang làm việc' 
                    ELSE N'Đã nghỉ việc' 
               END AS TrangThai
               FROM NhanVien 
               WHERE NhanVienID LIKE N'%" + tuKhoa + "%' OR HoTen LIKE N'%" + tuKhoa + "%'";

            // 3. Thực thi câu lệnh và đổ dữ liệu vào DataTable
            DataTable dt = ConnectDB.readdata(sql);

            // 4. Hiển thị kết quả lên DataGridView
            if (dt != null && dt.Rows.Count > 0)
            {
                dtgNhanvien.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhân viên nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Nếu không tìm thấy, em có thể gọi lại LoaddtgNhanvien() để hiển thị toàn bộ danh sách cũ
                // LoaddtgNhanvien();
            }
        }

       
    }
}
