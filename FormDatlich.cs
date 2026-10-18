using SiticoneNetCoreUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace phongkham1
{
    public partial class FormDatlich : Form
    {
        private int currentYear;
        private int currentMonth;
        public FormDatlich()
        {
            InitializeComponent();
            btnXacnhandatlich.Enabled = false;
            currentYear = DateTime.Now.Year;
            currentMonth = DateTime.Now.Month;
            HienThiLichThang();
            // Buổi Sáng
            btn8h.Tag = "08:00";
            btn8h30.Tag = "08:30";
            btn9h.Tag = "09:00";
            btn9h30.Tag = "09:30";
            btn10h.Tag = "10:00";
            btn10h30.Tag = "10:30";

            // Buổi Chiều
            btn14h.Tag = "14:00";
            btn14h30.Tag = "14:30";
            btn15h.Tag = "15:00";
            btn15h30.Tag = "15:30";
            btn16h.Tag = "16:00";
            btn16h30.Tag = "16:30";
            foreach (Control ctrl in siticonePanel7.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Click += TimeButton_Click;
                }
            }
            LoadChuyenKhoa();
            lblName.Text = UserSession.CurrentUser.HoTen;
            lblSDT.Text = UserSession.CurrentUser.SoDienThoai;
        }
        private void HienThiLichThang()
        {
            labNgaythang.Text = $"Tháng {currentMonth}, {currentYear}";
            flpNgaythang.Controls.Clear();

            int tongngay = DateTime.DaysInMonth(currentYear, currentMonth);

            for (int day = 1; day <= tongngay; day++)
            {
                DateTime tagngaythangpanel = new DateTime(currentYear, currentMonth, day);
                SiticonePanel pnlDay = new SiticonePanel();
                pnlDay.Width = 60;
                pnlDay.Height = 60;
                pnlDay.CornerRadiusBottomLeft = 15;
                pnlDay.CornerRadiusBottomRight = 15;
                pnlDay.CornerRadiusTopLeft = 15;
                pnlDay.CornerRadiusTopRight = 15;
                pnlDay.Margin = new Padding(4);
                pnlDay.BackColor = Color.Transparent;
                pnlDay.BorderColor = Color.Transparent;
                pnlDay.Tag = tagngaythangpanel;
                Label lblDay = new Label();
                lblDay.Text = day.ToString();
                lblDay.Dock = DockStyle.Top;
                lblDay.TextAlign = ContentAlignment.MiddleCenter;
                lblDay.Font = new Font("Segoe UI", 10, FontStyle.Bold);
                pnlDay.Controls.Add(lblDay);
                if (tagngaythangpanel < DateTime.Today)
                {
                    pnlDay.FillColor = Color.FromArgb(240, 240, 240); // Màu xám nhạt
                    lblDay.ForeColor = Color.DarkGray;                  // Chữ màu xám
                    pnlDay.Cursor = Cursors.Default;                    // Con trỏ chuột mặc định
                    lblDay.Cursor = Cursors.Default;
                }
                else
                {
                    pnlDay.FillColor = Color.FromArgb(234, 237, 255); // Màu nền bình thường
                    lblDay.ForeColor = Color.Black;                  // Chữ màu đen
                    pnlDay.Cursor = Cursors.Hand;                    // Con trỏ hình bàn tay
                    lblDay.Cursor = Cursors.Hand;

                    // ĐĂNG KÝ SỰ KIỆN CLICK
                    pnlDay.Click += PnlDay_Click;
                    lblDay.Click += PnlDay_Click;
                }
                flpNgaythang.Controls.Add(pnlDay);
            }
        }
        private SiticonePanel selectedPanel = null;
        public DateTime SelectedDate { get; private set; }
        private void PnlDay_Click(object sender, EventArgs e)
        {
            SiticonePanel clickedPanel = null;
            if (sender is Label lbl)
            {
                clickedPanel = lbl.Parent as SiticonePanel;
            }
            else if (sender is SiticonePanel pnl)
            {
                clickedPanel = pnl;
            }
            SelectedDate = (DateTime)clickedPanel.Tag;
            if (selectedPanel != null)
            {
                selectedPanel.FillColor = Color.FromArgb(234, 237, 255);
                if (selectedPanel.Controls.Count > 0 && selectedPanel.Controls[0] is Label oldLbl)
                {
                    oldLbl.ForeColor = Color.Black;
                }
            }
            clickedPanel.FillColor = Color.FromArgb(0, 97, 148);
            if (clickedPanel.Controls.Count > 0 && clickedPanel.Controls[0] is Label newLbl)
            {
                newLbl.ForeColor = Color.White;
            }
            selectedPanel = clickedPanel;
            if (clickedPanel.Tag != null)
            {
                lblNgaykham.Text = Convert.ToDateTime(clickedPanel.Tag).ToString("dd/MM/yyyy");
            }
        }

        private void btnSangtrai_Click(object sender, EventArgs e)
        {
            currentMonth--;
            if (currentMonth < 1)
            {
                currentMonth = 12;
                currentYear--;
            }
            HienThiLichThang();
        }

        private void btnSangphai_Click(object sender, EventArgs e)
        {
            currentMonth++;
            if (currentMonth > 12)
            {
                currentMonth = 1;
                currentYear++;
            }
            HienThiLichThang();
        }
        private Button selectedTimeButton = null;
        public string SelectedTimeSpan { get; private set; }
        private void TimeButton_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedBtn)
            {
                if (clickedBtn.Tag != null)
                {
                    SelectedTimeSpan = clickedBtn.Tag.ToString();
                }
                if (selectedTimeButton != null)
                {
                    selectedTimeButton.BackColor = Color.FromArgb(234, 237, 255); // Màu nền gốc
                    selectedTimeButton.ForeColor = Color.Black;                  // Màu chữ gốc
                }
                clickedBtn.BackColor = Color.FromArgb(0, 97, 148);
                clickedBtn.ForeColor = Color.White;
                selectedTimeButton = clickedBtn;
                if (clickedBtn.Tag != null)
                {
                    string gio = clickedBtn.Tag.ToString();
                    string buoi = (int.Parse(gio.Substring(0, 2)) < 12) ? " (Buổi sáng)" : " (Buổi chiều)";
                    lblGiokham.Text = gio + buoi;
                }
            }
        }
        private void LoadChuyenKhoa()
        {
            flpChuyenkhoa.Controls.Clear();

            string sql = "SELECT ChuyenKhoaID, TenChuyenKhoa, MoTa FROM ChuyenKhoa WHERE TrangThai = 1";
            ConnectDB db = new ConnectDB();
            DataTable dt = db.readdata(sql);

            if (dt == null || dt.Rows.Count == 0) return;

            foreach (DataRow row in dt.Rows)
            {
                int chuyenKhoaID = Convert.ToInt32(row["ChuyenKhoaID"]);
                string tenChuyenKhoa = row["TenChuyenKhoa"].ToString();
                string moTa = row["MoTa"] != DBNull.Value ? row["MoTa"].ToString() : "";
                SiticonePanel pnlChuyenKhoa = new SiticonePanel();
                pnlChuyenKhoa.Width = 300;
                pnlChuyenKhoa.Height = 150;
                pnlChuyenKhoa.CornerRadiusBottomLeft = 15;
                pnlChuyenKhoa.CornerRadiusBottomRight = 15;
                pnlChuyenKhoa.CornerRadiusTopLeft = 15;
                pnlChuyenKhoa.CornerRadiusTopRight = 15;

                pnlChuyenKhoa.Margin = new Padding(8);
                pnlChuyenKhoa.BackColor = Color.Transparent;
                pnlChuyenKhoa.FillColor = Color.White;
                pnlChuyenKhoa.BorderColor = Color.FromArgb(226, 232, 240);
                pnlChuyenKhoa.BorderThickness = 1;
                pnlChuyenKhoa.Tag = chuyenKhoaID;
                Label lblTenChuyenKhoa = new Label();
                lblTenChuyenKhoa.Text = tenChuyenKhoa;
                lblTenChuyenKhoa.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lblTenChuyenKhoa.ForeColor = Color.FromArgb(30, 41, 59);
                lblTenChuyenKhoa.Location = new Point(18, 18);
                lblTenChuyenKhoa.AutoSize = true;
                Label lblMoTa = new Label();
                lblMoTa.Text = moTa;
                lblMoTa.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                lblMoTa.ForeColor = Color.FromArgb(100, 116, 139);
                lblMoTa.Location = new Point(15, 48);
                lblMoTa.AutoSize = true;
                pnlChuyenKhoa.Controls.Add(lblTenChuyenKhoa);
                pnlChuyenKhoa.Controls.Add(lblMoTa);
                pnlChuyenKhoa.Click += PnlChuyenKhoa_Click;
                lblTenChuyenKhoa.Click += PnlChuyenKhoa_Click;
                lblMoTa.Click += PnlChuyenKhoa_Click;
                flpChuyenkhoa.Controls.Add(pnlChuyenKhoa);
            }
        }
        private int selectedChuyenKhoaID = -1;
        private SiticonePanel selectedPanelChuyenKhoa = null;
        private void PnlChuyenKhoa_Click(object sender, EventArgs e)
        {
            SiticonePanel clickedPanel = null;

            if (sender is SiticonePanel panel)
            {
                clickedPanel = panel;
            }
            else if (sender is Label lbl)
            {
                clickedPanel = lbl.Parent as SiticonePanel;
            }
            if (selectedPanelChuyenKhoa != null)
            {
                selectedPanelChuyenKhoa.FillColor = Color.White;
                selectedPanelChuyenKhoa.BorderColor = Color.FromArgb(226, 232, 240);
                selectedPanelChuyenKhoa.BorderThickness = 1;
            }
            selectedPanelChuyenKhoa = clickedPanel;
            selectedPanelChuyenKhoa.FillColor = Color.FromArgb(240, 249, 255);
            selectedPanelChuyenKhoa.BorderColor = Color.FromArgb(14, 165, 233);
            selectedPanelChuyenKhoa.BorderThickness = 2;
            selectedChuyenKhoaID = Convert.ToInt32(clickedPanel.Tag);
            foreach (Control ctrl in clickedPanel.Controls)
            {
                if (ctrl is Label lbl && lbl.Font.Bold) // Label tên chuyên khoa đang để chữ đậm (Bold)
                {
                    lblChuyenKhoa.Text = lbl.Text;
                    break;
                }
            }
            LoadBacSiTheoChuyenKhoa(selectedChuyenKhoaID);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnXacnhandatlich.Enabled = checkBox1.Checked;
        }
        public EventHandler Xacnhandatlich;
        public int NewLichHenID { get; private set; } = -1;
        private void btnXacnhandatlich_Click(object sender, EventArgs e)
        {
            if (selectedChuyenKhoaID == -1)
            {
                MessageBox.Show("Vui lòng chọn chuyên khoa khám!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (selectedBacSiID == -1)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ khám!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (SelectedDate == default(DateTime))
            {
                MessageBox.Show("Vui lòng chọn ngày khám bệnh!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(SelectedTimeSpan))
            {
                MessageBox.Show("Vui lòng chọn khung giờ khám!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int taiKhoanID = UserSession.CurrentUser.TaiKhoanID;
            int chuyenKhoaID = selectedChuyenKhoaID;
            int bacSiID = selectedBacSiID;
            string ngayKham = SelectedDate.ToString("yyyy-MM-dd"); // Định dạng chuẩn ngày tháng SQL
            string khungGio = SelectedTimeSpan; // Ví dụ: "08:00"
            string Trieuchung = selectedTrieuchung;
            string trangThai = "chờ xác nhận"; // Trạng thái mặc định khi mới đặt lịch
            string sqlInsert = $"INSERT INTO LichHen (TaiKhoanID, BacSiID, ChuyenKhoaID, NgayKham, KhungGio,MoTaTrieuChung, TrangThai) " +
                               $"VALUES ({taiKhoanID}, {bacSiID}, {chuyenKhoaID}, '{ngayKham}', N'{khungGio}',N'{Trieuchung}', N'{trangThai}')";
            ConnectDB db = new ConnectDB();
            int rowEffect = db.writedata(sqlInsert);

            if (rowEffect > 0)
            {
                string sqlGetID = $"SELECT MAX(LichHenID) FROM LichHen WHERE TaiKhoanID = {taiKhoanID}";
                DataTable dtID = db.readdata(sqlGetID);

                if (dtID != null && dtID.Rows.Count > 0)
                {
                    NewLichHenID = Convert.ToInt32(dtID.Rows[0][0]);
                }
                Xacnhandatlich?.Invoke(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Đặt lịch thất bại, vui lòng kiểm tra lại kết nối cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBacSiTheoChuyenKhoa(int chuyenKhoaID)
        {
            flpBacsi.Controls.Clear();
            string sql = $"SELECT BacSiID, HoTen, MoTa, SoDienThoai FROM BacSi WHERE ChuyenKhoaID = {chuyenKhoaID} AND TrangThai = 1";
            ConnectDB db = new ConnectDB();
            DataTable dt = db.readdata(sql);

            if (dt == null || dt.Rows.Count == 0)
            {
                return;
            }
            foreach (DataRow row in dt.Rows)
            {
                int bacSiID = Convert.ToInt32(row["BacSiID"]);
                string tenBacSi = row["HoTen"].ToString();
                string moTaBs = row["MoTa"] != DBNull.Value ? row["MoTa"].ToString() : "";
                SiticonePanel pnlBacSi = new SiticonePanel();
                pnlBacSi.Width = 340;   // Chiều rộng card bác sĩ (có thể điều chỉnh cho vừa layout)
                pnlBacSi.Height = 150;  // Chiều cao card
                pnlBacSi.CornerRadiusBottomLeft = 15;
                pnlBacSi.CornerRadiusBottomRight = 15;
                pnlBacSi.CornerRadiusTopLeft = 15;
                pnlBacSi.CornerRadiusTopRight = 15;

                pnlBacSi.Margin = new Padding(8);
                pnlBacSi.BackColor = Color.Transparent;
                pnlBacSi.FillColor = Color.White;
                pnlBacSi.BorderColor = Color.FromArgb(226, 232, 240);
                pnlBacSi.BorderThickness = 1;
                pnlBacSi.Tag = bacSiID; // Lưu ID bác sĩ ẩn vào Tag
                Label lblTenBS = new Label();
                lblTenBS.Text = tenBacSi;
                lblTenBS.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                lblTenBS.ForeColor = Color.FromArgb(30, 41, 59);
                lblTenBS.Location = new Point(15, 15);
                lblTenBS.AutoSize = true;
                Label lblMoTaBS = new Label();
                lblMoTaBS.Text = moTaBs;
                lblMoTaBS.Font = new Font("Segoe UI", 9, FontStyle.Regular);
                lblMoTaBS.ForeColor = Color.FromArgb(100, 116, 139);
                lblMoTaBS.Location = new Point(15, 48);
                lblMoTaBS.AutoSize = true;

                pnlBacSi.Controls.Add(lblTenBS);
                pnlBacSi.Controls.Add(lblMoTaBS);
                pnlBacSi.Click += PnlBacSi_Click;
                lblTenBS.Click += PnlBacSi_Click;
                lblMoTaBS.Click += PnlBacSi_Click;
                flpBacsi.Controls.Add(pnlBacSi);
            }
        }
        private int selectedBacSiID = -1;
        private SiticonePanel selectedPanelBacSi = null;
        private void PnlBacSi_Click(object sender, EventArgs e)
        {
            SiticonePanel clickedPanel = null;
            if (sender is SiticonePanel panel)
            {
                clickedPanel = panel;
            }
            else if (sender is Label lbl)
            {
                clickedPanel = lbl.Parent as SiticonePanel;
            }

            if (clickedPanel == null) return;
            if (selectedPanelBacSi != null)
            {
                selectedPanelBacSi.FillColor = Color.White;
                selectedPanelBacSi.BorderColor = Color.FromArgb(226, 232, 240);
                selectedPanelBacSi.BorderThickness = 1;
            }
            selectedPanelBacSi = clickedPanel;
            selectedPanelBacSi.FillColor = Color.FromArgb(240, 249, 255);
            selectedPanelBacSi.BorderColor = Color.FromArgb(14, 165, 233);
            selectedPanelBacSi.BorderThickness = 2;
            foreach (Control ctrl in clickedPanel.Controls)
            {
                if (ctrl is Label lbl && lbl.Font.Bold) // Label tên bác sĩ để chữ đậm
                {
                    lblBacsi.Text = lbl.Text;
                    break;
                }
            }
            selectedBacSiID = Convert.ToInt32(clickedPanel.Tag);
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private string selectedTrieuchung = "";
        private void txtTrieuchung_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTrieuchung.Text))
            {
                lblTrieuchung.Text = "(Không có)"; // Hoặc để trống tùy ý bạn
                lblTrieuchung.ForeColor = Color.DarkGray;
            }
            else
            {
                lblTrieuchung.Text = txtTrieuchung.Text;
                lblTrieuchung.ForeColor = Color.FromArgb(30, 41, 59);
                selectedTrieuchung= txtTrieuchung.Text;
                // Màu chữ bình thường
            }
        }
    }

}
