using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phongkham1
{
    public partial class FormMain : Form
    {
        private FormTrangchu formtrangChu;
        private FormDatlich formDatlich;
        public FormMain()
        {
            InitializeComponent();
            // khởi tạo form trangchu rồi lưu vào biến formtrangchu xong đặt sự kiện
            formtrangChu = new FormTrangchu();
            formtrangChu.DatLichkhamngay += From_Datlichkhamngay;
            HienThiForm(formtrangChu);
        }
        // giúp hiện thị các formcon trong panelMain
        private void HienThiForm(Form formCon)
        {
            panelMain.Controls.Clear();
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;

            panelMain.Controls.Add(formCon);
            formCon.Show();
        }
        private void From_Xacnhandatlich(object sender, EventArgs e)
        {
            if (sender is FormDatlich frmDatLich)
            {
                // 2. Lấy LichHenID vừa được INSERT thành công từ thuộc tính NewLichHenID của FormDatlich
                int idVuaTao = frmDatLich.NewLichHenID;

                // 3. Khởi tạo FormDatlichthanhcong và truyền idVuaTao sang
                FormDatlichthanhcong frmThanhCong = new FormDatlichthanhcong(idVuaTao);

                // 4. Hiển thị form thành công lên panelMain
                HienThiForm(frmThanhCong);
            }
        }
        private void From_Datlichkhamngay(object sender, EventArgs e)
        {
            formDatlich = new FormDatlich();
            formDatlich.Xacnhandatlich += From_Xacnhandatlich;
            HienThiForm(formDatlich);
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnTrangchu_Click(object sender, EventArgs e)
        {
            HienThiForm(formtrangChu);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HienThiForm(new Formlichhen());
        }

        private void btnDatlichkham_Click(object sender, EventArgs e)
        {
            formDatlich = new FormDatlich();
            formDatlich.Xacnhandatlich += From_Xacnhandatlich;
            HienThiForm(formDatlich);
        }
    }
}
