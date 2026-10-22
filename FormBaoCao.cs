using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phongkham1
{
    public partial class FormBaoCao : Form
    {
        ConnectDB db = new ConnectDB();
        public FormBaoCao()
        {
            InitializeComponent();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            dtpTuNgay.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpDenNgay.Value = DateTime.Now;

            LoadDuLieuThongKe();
        }
        public void LoadDuLieuThongKe()
        {
            string tuNgay = dtpTuNgay.Value.ToString("yyyy-MM-dd");
            string denNgay = dtpDenNgay.Value.ToString("yyyy-MM-dd");
            if (dtpDenNgay.Value < dtpTuNgay.Value)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu!", "Lỗi chọn ngày", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpDenNgay.Value = dtpTuNgay.Value; // Tự động đồng bộ lại cho bằng nhau hoặc return
                return;
            }

            // Câu lệnh SQL tổng hợp số lượng lịch hẹn theo từng Chuyên Khoa và chi tiết các trạng thái
            string sql = $@"
                SELECT 
                    ck.TenChuyenKhoa AS N'Chuyên Khoa',
                    COUNT(lh.LichHenID) AS N'Tổng số lịch',
                    SUM(CASE WHEN lh.TrangThai = N'Chờ xác nhận' THEN 1 ELSE 0 END) AS N'Chờ xác nhận',
                    SUM(CASE WHEN lh.TrangThai = N'Chờ khám' THEN 1 ELSE 0 END) AS N'Chờ khám',
                    SUM(CASE WHEN lh.TrangThai = N'Chờ thanh toán' THEN 1 ELSE 0 END) AS N'Chờ thanh toán',
                    SUM(CASE WHEN lh.TrangThai = N'Hoàn tất' THEN 1 ELSE 0 END) AS N'Hoàn tất',
                    SUM(CASE WHEN lh.TrangThai = N'Đã hủy' THEN 1 ELSE 0 END) AS N'Đã hủy'
                FROM ChuyenKhoa ck
                JOIN LichHen lh ON ck.ChuyenKhoaID = lh.ChuyenKhoaID 
                    AND lh.NgayKham BETWEEN '{tuNgay}' AND '{denNgay}'
                GROUP BY ck.ChuyenKhoaID, ck.TenChuyenKhoa";

            DataTable dt = db.readdata(sql);
            dgvThongKe.DataSource = dt;
        }

        private void btnXemThongKe_Click(object sender, EventArgs e)
        {
            LoadDuLieuThongKe();
        }
    }
}
