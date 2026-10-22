using System.Data;
using System.Drawing.Text;

namespace phongkham1
{
    public partial class  Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
        private void bamnutdangkyy(object sender, EventArgs e)
        {
            this.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtUsername.Text.Trim();
            string matKhau = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(tenDangNhap) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên đăng nhập và mật khẩu!");
                return;
            }

            string sql = $"SELECT TaiKhoanID, HoTen, TenDangNhap, Email, SoDienThoai, VaiTro " +
                         $"FROM TaiKhoan " +
                         $"WHERE TenDangNhap = '{tenDangNhap}' AND MatKhauHash = '{matKhau}'";

            ConnectDB db = new ConnectDB();
            DataTable dt = db.readdata(sql);

            if (dt != null && dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                // Khởi tạo thẻ định danh ngầm
                UserSession.CurrentUser = new UserSession(
                    taiKhoanID: Convert.ToInt32(row["TaiKhoanID"]),
                    hoTen: row["HoTen"].ToString(),
                    tenDangNhap: row["TenDangNhap"].ToString(),
                    email: row["Email"] != DBNull.Value ? row["Email"].ToString() : "",
                    soDienThoai: row["SoDienThoai"] != DBNull.Value ? row["SoDienThoai"].ToString() : "",
                    vaiTro: row["VaiTro"].ToString()
                );

                MessageBox.Show($"Đăng nhập thành công! Xin chào {UserSession.CurrentUser.HoTen}", "Thông báo");

                // === PHÂN QUYỀN ĐIỀU HƯỚNG FORM DỰA VÀO VAI TRÒ ===
                string vaiTro = UserSession.CurrentUser.VaiTro.Trim();

                if (vaiTro == "BacSi")
                {
                    // Nếu là Admin -> Mở Form quản trị của Admin
                    FormKhamBenh frmbasi = new FormKhamBenh();
                    frmbasi.Show();
                    this.Hide();

                }
                else if(vaiTro == "Admin")
                {
                    FormMainAdmin frmadmin = new FormMainAdmin();
                    frmadmin.Show();
                    this.Hide();
                }
                else if (vaiTro == "NhanVien")
                {
                    // Nếu là Admin -> Mở Form quản trị của Admin
                    FormNhanVienMain frm = new FormNhanVienMain();
                    frm.Show();
                    this.Hide();
                }
                else // Hoặc kiểm tra "Khách hàng" / "Patient" tùy theo dữ liệu trong DB của bạn
                {
                    // Nếu là Khách hàng -> Mở Form chính / Form đặt lịch
                    FormMain frmMain = new FormMain();
                    frmMain.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormDky dky= new FormDky();
            
            dky.bamnutdangky += bamnutdangkyy;
            dky.Show();
            this.Hide();
        }
    }
}
