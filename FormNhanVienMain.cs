using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phongkham1
{
    public partial class FormNhanVienMain : Form
    {
        Formdontiepbenhnhan frm = new Formdontiepbenhnhan();
        public FormNhanVienMain()
        {
            InitializeComponent();
            HienThiForm(frm);
        }
        private void HienThiForm(Form formCon)
        {
            pnlNhanvienmain.Controls.Clear();
            formCon.TopLevel = false;
            formCon.FormBorderStyle = FormBorderStyle.None;
            formCon.Dock = DockStyle.Fill;

            pnlNhanvienmain.Controls.Add(formCon);
            formCon.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            HienThiForm(frm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formThanhToanPhatthuocNhanvien from = new formThanhToanPhatthuocNhanvien();
            HienThiForm(from);
        }

        private void FormNhanVienMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
