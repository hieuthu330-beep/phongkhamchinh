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
            string sql = "SELECT ChuyenKhoaID ,TenChuyenKhoa FROM ChuyenKhoa";
            DataTable dt = db.readdata(sql);
            if (dt != null)
            {
                cboChuyenkhoa.DataSource = dt;
                cboChuyenkhoa.DisplayMember = "TenChuyenKhoa";
                cboChuyenkhoa.ValueMember = "ChuyenKhoaID";
            }
        }

        private void LoaddtgDanhsachbacsi()
        {
            string sql = @"SELECT b.BacSiID, b.HoTen, c.TenChuyenKhoa, b.MoTa, b.SoDienThoai, 
                   CASE WHEN b.TrangThai = 1 THEN N'Đang hoạt động' ELSE N'Ngừng hoạt động' END AS TrangThai 
                   FROM BacSi b JOIN ChuyenKhoa c ON b.ChuyenKhoaID = c.ChuyenKhoaID";

            DataTable dt = db.readdata(sql);
            if (dt != null)
            {

                dtgDanhsachbacsi.DataSource = dt;
            }
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void Formqlybacsi_Load(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            string Hoten = txtHoten.Text;
            string Chuyenkhoa = cboChuyenkhoa.SelectedValue.ToString();
            string Mota = txtMota.Text;
            string Sdt = txtSdt.Text;
            string Trangthai = cboTrangthai.SelectedIndex.ToString();

            if (Hoten != "")
            {
                string sql = $@"INSERT INTO BacSi (HoTen, ChuyenKhoaID, MoTa, SoDienThoai, TrangThai)
                            VALUES (N'{Hoten}', {Chuyenkhoa}, N'{Mota}', N'{Sdt}',{Trangthai})";
                int roweffect = db.writedata(sql);
                if (roweffect > 0)
                {
                    MessageBox.Show("Thêm dữ liệu thành công");
                    LoaddtgDanhsachbacsi();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Mã bác sĩ và Họ tên!", "Cảnh báo");
            }
            LoaddtgDanhsachbacsi();
            btnLuu.Enabled = false;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Xóa trắng các ô để nhập mới
            txtMabs.Clear();
            txtHoten.Clear();
            txtMota.Clear();
            txtSdt.Clear();

            // Khóa/mở các nút theo ý bạn
            btnThem.Enabled = false;
            btnLuu.Enabled = true;   // Lúc này nút Lưu mới sáng lên
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // Nhảy con trỏ chuột về ô Mã bác sĩ
            txtHoten.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgDanhsachbacsi.CurrentRow != null)
            {
                // Lấy Mã bác sĩ từ cột đầu tiên (hoặc tên cột tương ứng trong CSDL của bạn, ví dụ: BacSiID)
                // Lưu ý: Đảm bảo tên cột trong Cells đúng với tên cột bạn SELECT lên DataGridView
                string maBacSi = dtgDanhsachbacsi.CurrentRow.Cells[0].Value.ToString();

                // 2. Tạo hộp thoại hỏi xác nhận trước khi xóa để tránh xóa nhầm
                DialogResult dialogResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa bác sĩ này không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (dialogResult == DialogResult.Yes)
                {
                    // 3. Câu lệnh SQL để xóa
                    string sql = $"DELETE FROM BacSi WHERE BacSiID = '{maBacSi}'";

                    // 4. Thực thi câu lệnh qua hàm writedata của bạn
                    int roweffect = db.writedata(sql);

                    if (roweffect > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Load lại danh sách bác sĩ trên bảng
                        LoaddtgDanhsachbacsi();

                        // Xóa trắng các ô nhập liệu (nếu cần)
                        txtMabs.Clear();
                        txtHoten.Clear();
                        txtMota.Clear();
                        txtSdt.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra, không thể xóa dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dòng bác sĩ cần xóa trên bảng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtgDanhsachbacsi_MouseClick(object sender, MouseEventArgs e)
        {
            //Lấy dữ liệu của row mà chúng ta click => đổ vảo textBox
            txtMabs.Text = dtgDanhsachbacsi.CurrentRow.Cells[0].Value.ToString();
            txtHoten.Text = dtgDanhsachbacsi.CurrentRow.Cells[1].Value.ToString();
            cboChuyenkhoa.Text = dtgDanhsachbacsi.CurrentRow.Cells[2].Value.ToString();
            txtMota.Text = dtgDanhsachbacsi.CurrentRow.Cells[3].Value.ToString();
            txtSdt.Text = dtgDanhsachbacsi.CurrentRow.Cells[4].Value.ToString();
            cboTrangthai.Text = dtgDanhsachbacsi.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // 1. Lấy dữ liệu từ các ô nhập liệu trên giao diện
            string mabs = txtMabs.Text.Trim();
            string hoten = txtHoten.Text.Trim();
            string chuyenkhoa = cboChuyenkhoa.SelectedValue?.ToString() ?? "";
            string mota = txtMota.Text.Trim();
            string sdt = txtSdt.Text.Trim();
            string trangthai = cboTrangthai.SelectedIndex.ToString();

            // 2. Kiểm tra xem đã chọn mã bác sĩ chưa (đảm bảo không bị trống khóa chính)
            if (mabs != "")
            {
                // 3. Câu lệnh SQL UPDATE sử dụng cú pháp Chuỗi nội suy ($@"...") tương tự như lúc Thêm
                string sql = $@"UPDATE BacSi 
                       SET HoTen = N'{hoten}', 
                           ChuyenKhoaID = '{chuyenkhoa}', 
                           MoTa = N'{mota}', 
                           SoDienThoai = '{sdt}', 
                           TrangThai = '{trangthai}' 
                       WHERE BacSiID = '{mabs}'";

                // 4. Thực thi câu lệnh qua hàm writedata của bạn
                int roweffect = db.writedata(sql);

                if (roweffect > 0)
                {
                    MessageBox.Show("Cập nhật thông tin bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Load lại danh sách lên DataGridView
                    LoaddtgDanhsachbacsi();

                    // Reset lại trạng thái các nút và ô nhập liệu
                    txtMabs.Clear();
                    txtHoten.Clear();
                    txtMota.Clear();
                    txtSdt.Clear();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra, không thể cập nhật dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vوي lòng chọn bác sĩ cần sửa từ danh sách bảng!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            // Giả sử ô nhập từ khóa tìm kiếm của bạn tên là txtTim (hoặc bạn có thể thay bằng txtHoten, txtMabs tùy ý)
            string keyword = txtTimkiem.Text.Trim();

            // Câu lệnh SQL tìm kiếm (có thể tìm theo Mã bác sĩ hoặc Họ tên bác sĩ chứa từ khóa)
            string sql = $@"SELECT b.BacSiID, b.HoTen, c.TenChuyenKhoa, b.MoTa, b.SoDienThoai, 
                   CASE WHEN b.TrangThai = 1 THEN N'Đang hoạt động' ELSE N'Ngừng hoạt động' END AS TrangThai 
                   FROM BacSi b 
                   JOIN ChuyenKhoa c ON b.ChuyenKhoaID = c.ChuyenKhoaID 
                   WHERE b.BacSiID LIKE N'%{keyword}%' OR b.HoTen LIKE N'%{keyword}%'";

            // Gọi hàm đọc dữ liệu và đổ vào bảng
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
    }
}
