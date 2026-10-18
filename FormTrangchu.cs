using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phongkham1
{
    public partial class FormTrangchu : Form
    {
        public FormTrangchu()
        {
            InitializeComponent();
        }
        public EventHandler DatLichkhamngay;
        private void btnDatlichkhamngay_Click(object sender, EventArgs e)
        {
            DatLichkhamngay?.Invoke(this, EventArgs.Empty);
        }
    }
}
