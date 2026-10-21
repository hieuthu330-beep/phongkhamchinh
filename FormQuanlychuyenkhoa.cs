using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phongkham1
{
    public partial class FormQuanlychuyenkhoa : Form
    {
        // Hàm khởi tạo Form (Constructor), chạy đầu tiên khi mở form lên
        public FormQuanlychuyenkhoa()
        {
            InitializeComponent();
            Loaddata(); // Gọi hàm load dữ liệu thô ban đầu
        }

        // Khởi tạo đối tượng kết nối cơ sở dữ liệu từ lớp ConnectDB đã viết sẵn
        ConnectDB ConnectDB = new ConnectDB();

        // Hàm load dữ liệu dự phòng từ bảng ChuyenKhoa
        private void Loaddata()
        {
            string sql = "SELECT * FROM Chuyenkhoa";
            DataTable dt = ConnectDB.readdata(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                dtgChuyenkhoa.DataSource = dt;
            }
        }

        // Sự kiện xảy ra khi Form vừa được tải lên màn hình
        private void FormQuanlychuyenkhoa_Load(object sender, EventArgs e)
        {
            LoaddtgChuyenkhoa(); // Đổ dữ liệu có format chuẩn lên bảng DataGridView
            btnLuu.Enabled = false; // Ban đầu khóa nút Lưu lại (chưa cho bấm khi chưa bấm Thêm)
        }

        // Hàm load dữ liệu chính lên bảng (DataGridView) kèm đổi số trạng thái thành chữ tiếng Việt đẹp mắt
        private void LoaddtgChuyenkhoa()
        {
            // Dùng CASE WHEN trong SQL để chuyển cột TrangThai từ số (1, 0) thành chữ "Đang hoạt động" / "Ngừng hoạt động"
            string sql = @"SELECT ChuyenKhoaID, TenChuyenKhoa, MoTa, 
                           CASE WHEN TrangThai = 1 THEN N'Đang hoạt động' 
                                ELSE N'Ngừng hoạt động' 
                           END AS TrangThai 
                           FROM ChuyenKhoa";
            DataTable dt = ConnectDB.readdata(sql);
            if (dt != null)
            {
                dtgChuyenkhoa.DataSource = dt;
            }
        }

        // Hàm phụ dùng để xóa trắng tất cả các ô nhập liệu trên form
        private void cleardata()
        {
            txtMachuyenkhoa.Text = "";
            txtTenchuyenkhoa.Text = "";
            txtMota.Text = "";
            cboTrangthai.SelectedIndex = -1; // Bỏ chọn ComboBox (về trạng thái trống)
        }

        // Sự kiện khi bấm nút "Thêm"
        private void btnThem_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;   // Mở khóa nút Lưu để người dùng điền xong bấm lưu
            btnThem.Enabled = false; // Khóa nút Thêm lại để tránh bấm nhiều lần
            btnSua.Enabled = false;  // Khóa nút Sửa
            btnXoa.Enabled = false;  // Khóa nút Xóa
            cleardata();             // Làm sạch form cho người dùng nhập mới
            txtTenchuyenkhoa.Focus();// Đưa con trỏ chuột nhấp nháy vào ô Tên chuyên khoa
        }

        // Sự kiện khi bấm nút "Lưu" (sau khi bấm Thêm)
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string tenChuyenKhoa = txtTenchuyenkhoa.Text.Trim();
            string moTa = txtMota.Text.Trim();

            // Lấy giá trị trạng thái từ ComboBox: nếu chọn "Đang hoạt động" thì lưu số 1, ngược lại lưu số 0
            int trangThai = (cboTrangthai.Text == "Đang hoạt động") ? 1 : 0;

            // Kiểm tra ràng buộc: Tên chuyên khoa không được để trống
            if (string.IsNullOrEmpty(tenChuyenKhoa))
            {
                MessageBox.Show("Vui lòng nhập Tên chuyên khoa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Dừng lại không thực hiện tiếp
            }

            // Xử lý mô tả: nếu ô mô tả trống thì lưu giá trị NULL vào cơ sở dữ liệu, có chữ thì thêm N'' chống lỗi tiếng Việt
            string moTaSQL = string.IsNullOrEmpty(moTa) ? "NULL" : "N'" + moTa + "'";

            // Viết câu lệnh SQL thêm mới dữ liệu
            string sql = "INSERT INTO ChuyenKhoa (TenChuyenKhoa, MoTa, TrangThai) VALUES (";
            sql += "N'" + tenChuyenKhoa + "', ";
            sql += moTaSQL + ", ";
            sql += trangThai + ")";

            // Thực thi câu lệnh thông qua hàm writedata
            int result = ConnectDB.writedata(sql);

            if (result > 0)
            {
                MessageBox.Show("Thêm chuyên khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddtgChuyenkhoa(); // Tải lại bảng dữ liệu mới
                cleardata();         // Xóa form

                // Trả các nút bấm về trạng thái bình thường ban đầu
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thêm chuyên khoa thất bại! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi bấm nút "Sửa"
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn dòng chuyên khoa nào trên bảng chưa (dựa vào Mã chuyên khoa ẩn/hiện)
            if (string.IsNullOrEmpty(txtMachuyenkhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn chuyên khoa cần sửa từ bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maChuyenKhoa = txtMachuyenkhoa.Text.Trim();
            string tenChuyenKhoa = txtTenchuyenkhoa.Text.Trim();
            string moTa = txtMota.Text.Trim();

            // Chuyển đổi trạng thái từ ComboBox thành số nguyên để lưu vào CSDL
            int trangThai = (cboTrangthai.Text == "Đang hoạt động") ? 1 : 0;

            if (string.IsNullOrEmpty(tenChuyenKhoa))
            {
                MessageBox.Show("Tên chuyên khoa không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string moTaSQL = string.IsNullOrEmpty(moTa) ? "NULL" : "N'" + moTa + "'";

            // Viết câu lệnh SQL cập nhật (UPDATE)
            string sql = "UPDATE ChuyenKhoa SET ";
            sql += "TenChuyenKhoa = N'" + tenChuyenKhoa + "', ";
            sql += "MoTa = " + moTaSQL + ", ";
            sql += "TrangThai = " + trangThai + " ";
            sql += "WHERE ChuyenKhoaID = " + maChuyenKhoa;

            int result = ConnectDB.writedata(sql);

            if (result > 0)
            {
                MessageBox.Show("Cập nhật chuyên khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddtgChuyenkhoa();
                cleardata();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Sự kiện khi bấm nút "Xóa"
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMachuyenkhoa.Text))
            {
                MessageBox.Show("Vui lòng chọn chuyên khoa cần xóa từ bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hiển thị bảng hỏi Yes/No xác nhận trước khi xóa tránh bấm nhầm
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa chuyên khoa có mã: " + txtMachuyenkhoa.Text + " không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                string maChuyenKhoa = txtMachuyenkhoa.Text.Trim();
                string sql = "DELETE FROM ChuyenKhoa WHERE ChuyenKhoaID = " + maChuyenKhoa;

                int result = ConnectDB.writedata(sql);

                if (result > 0)
                {
                    MessageBox.Show("Xóa chuyên khoa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoaddtgChuyenkhoa();
                    cleardata();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại! Chuyên khoa này có thể đang được liên kết với bác sĩ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Sự kiện khi bấm nút "Làm mới"
        private void btnLammoi_Click(object sender, EventArgs e)
        {
            cleardata();                  // Xóa trắng ô nhập
            dtgChuyenkhoa.ClearSelection();// Hủy chọn dòng trên bảng

            // Đưa các nút bấm về trạng thái ban đầu
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;

            LoaddtgChuyenkhoa(); // Load lại toàn bộ danh sách
        }

        // Sự kiện khi bấm nút "Tìm kiếm"
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tuKhoa = txtTimkiem.Text.Trim(); // Lấy từ khóa người dùng gõ vào ô tìm kiếm

            // Lọc dữ liệu theo Mã chuyên khoa hoặc Tên chuyên khoa chứa từ khóa
            string sql = @"SELECT ChuyenKhoaID, TenChuyenKhoa, MoTa, 
                           CASE WHEN TrangThai = 1 THEN N'Đang hoạt động' 
                                ELSE N'Ngừng hoạt động' 
                           END AS TrangThai 
                           FROM ChuyenKhoa 
                           WHERE ChuyenKhoaID LIKE N'%" + tuKhoa + "%' OR TenChuyenKhoa LIKE N'%" + tuKhoa + "%'";

            DataTable dt = ConnectDB.readdata(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                dtgChuyenkhoa.DataSource = dt; // Hiển thị kết quả tìm được lên bảng
            }
            else
            {
                MessageBox.Show("Không tìm thấy chuyên khoa phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Sự kiện khi người dùng click chuột vào một dòng trên bảng DataGridView để đưa dữ liệu ngược lên các ô nhập
        private void dtgChuyenkhoa_MouseClick(object sender, MouseEventArgs e)
        {
            int rowIndex = dtgChuyenkhoa.HitTest(e.X, e.Y).RowIndex; // Lấy vị trí dòng được click

            if (rowIndex >= 0)
            {
                DataGridViewRow row = dtgChuyenkhoa.Rows[rowIndex];

                // Đổ dữ liệu từ các cột của dòng đó lên các TextBox / ComboBox tương ứng
                txtMachuyenkhoa.Text = row.Cells[0].Value.ToString();   // Cột 0: Mã chuyên khoa
                txtTenchuyenkhoa.Text = row.Cells[1].Value.ToString();  // Cột 1: Tên chuyên khoa
                txtMota.Text = row.Cells[2].Value.ToString() == "" ? "" : row.Cells[2].Value.ToString(); // Cột 2: Mô tả
                cboTrangthai.Text = row.Cells[3].Value.ToString();      // Cột 3: Trạng thái ("Đang hoạt động" hoặc "Ngừng hoạt động")
            }
        }
    }
}