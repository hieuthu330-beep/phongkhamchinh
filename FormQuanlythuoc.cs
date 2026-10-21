using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phongkham1
{
    public partial class FormQuanlythuoc : Form
    {
        public FormQuanlythuoc()
        {
            InitializeComponent();
            Loaddata();
        }

        ConnectDB ConnectDB = new ConnectDB();

        private void Loaddata()
        {
            string sql = "SELECT * FROM Thuoc";
            DataTable dt = ConnectDB.readdata(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                dtgThuoc.DataSource = dt;
            }
            else
            {
                // Không bắt buộc hiển thị thông báo khi form vừa load nếu chưa có dữ liệu
            }
        }
        private void FormQuanlythuoc_Load(object sender, EventArgs e)
        {
            LoaddtgThuoc();
        }

        private void LoaddtgThuoc()
        {
            string sql = "SELECT ThuocID, TenThuoc, DonViTinh, DonGia, SoLuongTon, MoTa FROM Thuoc";
            DataTable dt = ConnectDB.readdata(sql);
            if (dt != null)
            {
                dtgThuoc.DataSource = dt;
            }
        }
        private void cleardata()
        {
            txtMathuoc.Text = "";
            txtTenthuoc.Text = "";
            txtDonvitinh.Text = "";
            txtDongia.Text = "";
            txtSoluongton.Text = "";
            txtMota.Text = "";
        }

        private void dtgThuoc_MouseClick(object sender, MouseEventArgs e)
        {
            int rowIndex = dtgThuoc.HitTest(e.X, e.Y).RowIndex;

            if (rowIndex >= 0)
            {
                DataGridViewRow row = dtgThuoc.Rows[rowIndex];

                // Gán đúng thứ tự cột từ trái sang phải trên bảng:
                txtMathuoc.Text = row.Cells[0].Value.ToString(); // Cột 0: Mã thuốc
                txtTenthuoc.Text = row.Cells[1].Value.ToString(); // Cột 1: Tên thuốc
                txtDonvitinh.Text = row.Cells[2].Value.ToString(); // Cột 2: Đơn vị tính
                txtDongia.Text = row.Cells[3].Value.ToString(); // Cột 3: Đơn giá
                txtSoluongton.Text = row.Cells[4].Value.ToString(); // Cột 4: Số lượng tồn
                txtMota.Text = row.Cells[5].Value.ToString(); // Cột 5: Mô tả
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Bật nút Lưu, khóa các nút Thêm, Sửa, Ngừng SD lại
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnNgungsd.Enabled = false; // Hoặc btnXoa tùy theo tên nút của bạn

            // Xóa trắng các ô nhập và mở khóa (nếu bạn có khóa các ô nhập)
            cleardata();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // 1. Lấy thông tin từ các ô nhập trên form
            string tenThuoc = txtTenthuoc.Text;
            string donViTinh = txtDonvitinh.Text;
            string donGiaStr = txtDongia.Text;
            string soLuongStr = txtSoluongton.Text;
            string moTa = txtMota.Text;

            // 2. Kiểm tra thông tin bắt buộc
            if (string.IsNullOrEmpty(tenThuoc) || string.IsNullOrEmpty(donViTinh) || string.IsNullOrEmpty(donGiaStr) || string.IsNullOrEmpty(soLuongStr))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên thuốc, Đơn vị tính, Đơn giá và Số lượng tồn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng số cho Đơn giá và Số lượng tồn
            if (!decimal.TryParse(donGiaStr, out decimal donGia) || !int.TryParse(soLuongStr, out int soLuongTon))
            {
                MessageBox.Show("Đơn giá và Số lượng tồn phải là kiểu số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Xử lý Mô tả (nếu để trống thì lưu NULL)
            string moTaSQL = string.IsNullOrEmpty(moTa) ? "NULL" : "N'" + moTa + "'";

            // 4. Viết câu lệnh SQL INSERT
            string sql = "INSERT INTO Thuoc (TenThuoc, DonViTinh, DonGia, SoLuongTon, MoTa) VALUES (";
            sql += "N'" + tenThuoc + "', ";
            sql += "N'" + donViTinh + "', ";
            sql += donGia + ", ";
            sql += soLuongTon + ", ";
            sql += moTaSQL + ")";

            // 5. Thực thi câu lệnh
            int result = ConnectDB.writedata(sql);

            if (result > 0)
            {
                MessageBox.Show("Thêm thuốc mới thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddtgThuoc();
                cleardata();

                // Sau khi lưu xong, trả các nút về trạng thái ban đầu
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnNgungsd.Enabled = true;
            }
            else
            {
                MessageBox.Show("Thêm thuốc thất bại! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bSua_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem đã chọn thuốc cần sửa chưa (dựa vào Mã thuốc)
            if (string.IsNullOrEmpty(txtMathuoc.Text))
            {
                MessageBox.Show("Vui lòng chọn thuốc cần sửa từ bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Lấy dữ liệu từ các ô nhập
            string maThuoc = txtMathuoc.Text;
            string tenThuoc = txtTenthuoc.Text;
            string donViTinh = txtDonvitinh.Text;
            string donGiaStr = txtDongia.Text;
            string soLuongStr = txtSoluongton.Text;
            string moTa = txtMota.Text;

            // 3. Kiểm tra thông tin bắt buộc
            if (string.IsNullOrEmpty(tenThuoc) || string.IsNullOrEmpty(donViTinh) || string.IsNullOrEmpty(donGiaStr) || string.IsNullOrEmpty(soLuongStr))
            {
                MessageBox.Show("Tên thuốc, Đơn vị tính, Đơn giá và Số lượng tồn không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng số cho Đơn giá và Số lượng tồn
            if (!decimal.TryParse(donGiaStr, out decimal donGia) || !int.TryParse(soLuongStr, out int soLuongTon))
            {
                MessageBox.Show("Đơn giá và Số lượng tồn phải là kiểu số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 4. Xử lý Mô tả (nếu trống thì lưu NULL)
            string moTaSQL = string.IsNullOrEmpty(moTa) ? "NULL" : "N'" + moTa + "'";

            // 5. Viết câu lệnh SQL UPDATE
            string sql = "UPDATE Thuoc SET ";
            sql += "TenThuoc = N'" + tenThuoc + "', ";
            sql += "DonViTinh = N'" + donViTinh + "', ";
            sql += "DonGia = " + donGia + ", ";
            sql += "SoLuongTon = " + soLuongTon + ", ";
            sql += "MoTa = " + moTaSQL + " ";
            sql += "WHERE ThuocID = " + maThuoc;

            // 6. Thực thi câu lệnh
            int result = ConnectDB.writedata(sql);

            if (result > 0)
            {
                MessageBox.Show("Cập nhật thông tin thuốc thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoaddtgThuoc(); // Load lại bảng dữ liệu
                cleardata();       // Xóa trắng form
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại! Vui lòng kiểm tra lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNgungsd_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra xem đã chọn thuốc cần thao tác chưa
            if (string.IsNullOrEmpty(txtMathuoc.Text))
            {
                MessageBox.Show("Vui lòng chọn thuốc cần ngừng sử dụng/xóa từ bảng danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Hiển thị hộp thoại xác nhận
            DialogResult dialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa/ngừng sử dụng thuốc có mã: " + txtMathuoc.Text + " không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                string maThuoc = txtMathuoc.Text.Trim();

                // 3. Viết câu lệnh SQL DELETE (hoặc UPDATE trạng thái nếu CSDL của bạn có cột TrangThai)
                string sql = "DELETE FROM Thuoc WHERE ThuocID = " + maThuoc;

                // 4. Thực thi câu lệnh
                int result = ConnectDB.writedata(sql);

                if (result > 0)
                {
                    MessageBox.Show("Thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoaddtgThuoc(); // Tải lại bảng dữ liệu
                    cleardata();       // Xóa trắng form
                }
                else
                {
                    MessageBox.Show("Thất bại! Thuốc này có thể đang được liên kết với đơn thuốc hoặc hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLammoi_Click(object sender, EventArgs e)
        {
            cleardata();
            dtgThuoc.ClearSelection();

            // Trả lại trạng thái sáng cho các nút Thêm, Sửa, Ngừng SD và khóa nút Lưu
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnNgungsd.Enabled = true;
            btnLuu.Enabled = false;

            LoaddtgThuoc();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            // 1. Lấy từ khóa người dùng nhập vào ô tìm kiếm
            string tuKhoa = txtTimkiem.Text;

            // 2. Viết câu lệnh SQL tìm kiếm theo Mã thuốc (ThuocID) hoặc Tên thuốc (TenThuoc)
            string sql = @"SELECT ThuocID, TenThuoc, DonViTinh, DonGia, SoLuongTon, MoTa 
                   FROM Thuoc 
                   WHERE ThuocID LIKE N'%" + tuKhoa + "%' OR TenThuoc LIKE N'%" + tuKhoa + "%'";

            // 3. Thực thi câu lệnh và đổ dữ liệu vào DataTable
            DataTable dt = ConnectDB.readdata(sql);

            // 4. Hiển thị kết quả lên DataGridView
            if (dt != null && dt.Rows.Count > 0)
            {
                dtgThuoc.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy loại thuốc nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tùy chọn: Nếu không tìm thấy, có thể load lại toàn bộ danh sách cũ
                // LoaddtgThuoc();
            }
        }
    }
}
