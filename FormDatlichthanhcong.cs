using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phongkham1
{
    public partial class FormDatlichthanhcong : Form
    {
        public FormDatlichthanhcong(int lichHenID)
        {
            InitializeComponent();
            LoadThongTinPhieuKham(lichHenID);
        }
        private void LoadThongTinPhieuKham(int ID)
        {
            // Câu lệnh SQL JOIN lấy trọn vẹn thông tin từ các bảng liên quan
            string sql = $@"SELECT lh.LichHenID, lh.NgayKham, lh.KhungGio, lh.TrangThai, 
                           tk.HoTen AS TenBenhNhan, tk.SoDienThoai, 
                           bs.HoTen AS TenBacSi, 
                           ck.TenChuyenKhoa 
                    FROM LichHen lh
                    JOIN TaiKhoan tk ON lh.TaiKhoanID = tk.TaiKhoanID
                    JOIN BacSi bs ON lh.BacSiID = bs.BacSiID
                    JOIN ChuyenKhoa ck ON lh.ChuyenKhoaID = ck.ChuyenKhoaID
                    WHERE lh.LichHenID = {ID}";

            ConnectDB db = new ConnectDB();
            DataTable dt = db.readdata(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                DateTime ngayKham = Convert.ToDateTime(row["NgayKham"]);

                // Gán dữ liệu lên các Label hiển thị tương ứng
                lblMaPhieu.Text = "#EH-" + ngayKham.ToString("yyyyMMdd") + "-" + row["LichHenID"].ToString();
                lblHoTen.Text = row["TenBenhNhan"].ToString();
                lblSdt.Text = row["SoDienThoai"].ToString();
                lblChuyenKhoa.Text = row["TenChuyenKhoa"].ToString();
                lblBacSi.Text = row["TenBacSi"].ToString();
                lblNgayKham.Text = ngayKham.ToString("dd/MM/yyyy");
                lblKhungGio.Text = row["KhungGio"].ToString();
            }
            else return;
        }
        private void siticoneAdvancedPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
