namespace phongkham1
{
    partial class Formqlybacsi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formqlybacsi));
            label1 = new Label();
            panel1 = new Panel();
            txtTimkiem = new TextBox();
            label2 = new Label();
            btnTimkiem = new Button();
            label12 = new Label();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            btnThem = new Button();
            txtMota = new TextBox();
            txtSdt = new TextBox();
            txtHoten = new TextBox();
            cboChuyenkhoa = new ComboBox();
            cboTrangthai = new ComboBox();
            txtMabs = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label7 = new Label();
            label4 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label13 = new Label();
            dtgDanhsachbacsi = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgDanhsachbacsi).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 77, 153);
            label1.Location = new Point(692, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 25);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ BÁC SĨ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLightLight;
            panel1.Controls.Add(txtTimkiem);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnTimkiem);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnLuu);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtMota);
            panel1.Controls.Add(txtSdt);
            panel1.Controls.Add(txtHoten);
            panel1.Controls.Add(cboChuyenkhoa);
            panel1.Controls.Add(cboTrangthai);
            panel1.Controls.Add(txtMabs);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(13, 86);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 497);
            panel1.TabIndex = 1;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Location = new Point(52, 355);
            txtTimkiem.Margin = new Padding(2);
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.Size = new Size(197, 25);
            txtTimkiem.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 77, 153);
            label2.Location = new Point(27, 11);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 18);
            label2.TabIndex = 28;
            label2.Text = "QUẢN LÝ BÁC SĨ";
            // 
            // btnTimkiem
            // 
            btnTimkiem.Location = new Point(267, 350);
            btnTimkiem.Margin = new Padding(2);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(69, 31);
            btnTimkiem.TabIndex = 27;
            btnTimkiem.Text = "Tìm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(311, 13);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(96, 17);
            label12.TabIndex = 25;
            label12.Text = "Chi tiết bản ghi";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(186, 26, 26);
            btnXoa.FlatAppearance.BorderColor = Color.FromArgb(186, 26, 26);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.ForeColor = SystemColors.Control;
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(311, 302);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(69, 31);
            btnXoa.TabIndex = 24;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(236, 238, 241);
            btnSua.FlatAppearance.BorderColor = Color.FromArgb(236, 238, 241);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.ForeColor = SystemColors.ActiveCaptionText;
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(223, 302);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(69, 31);
            btnSua.TabIndex = 23;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(21, 101, 192);
            btnLuu.FlatAppearance.BorderColor = Color.FromArgb(21, 101, 192);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.ForeColor = SystemColors.Control;
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(129, 302);
            btnLuu.Margin = new Padding(2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(69, 31);
            btnLuu.TabIndex = 22;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(0, 77, 153);
            btnThem.FlatAppearance.BorderColor = Color.FromArgb(0, 77, 153);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.ForeColor = SystemColors.ButtonHighlight;
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(36, 302);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(69, 31);
            btnThem.TabIndex = 21;
            btnThem.Text = "  Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // txtMota
            // 
            txtMota.Location = new Point(123, 173);
            txtMota.Margin = new Padding(2);
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(281, 25);
            txtMota.TabIndex = 20;
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(123, 212);
            txtSdt.Margin = new Padding(2);
            txtSdt.MaxLength = 10;
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(281, 25);
            txtSdt.TabIndex = 18;
            // 
            // txtHoten
            // 
            txtHoten.Location = new Point(123, 92);
            txtHoten.Margin = new Padding(2);
            txtHoten.Name = "txtHoten";
            txtHoten.Size = new Size(281, 25);
            txtHoten.TabIndex = 17;
            // 
            // cboChuyenkhoa
            // 
            cboChuyenkhoa.FormattingEnabled = true;
            cboChuyenkhoa.Location = new Point(123, 133);
            cboChuyenkhoa.Margin = new Padding(2);
            cboChuyenkhoa.Name = "cboChuyenkhoa";
            cboChuyenkhoa.Size = new Size(281, 25);
            cboChuyenkhoa.TabIndex = 16;
            // 
            // cboTrangthai
            // 
            cboTrangthai.FormattingEnabled = true;
            cboTrangthai.Items.AddRange(new object[] { "Ngừng hoạt động", "Đang hoạt động" });
            cboTrangthai.Location = new Point(123, 254);
            cboTrangthai.Margin = new Padding(2);
            cboTrangthai.Name = "cboTrangthai";
            cboTrangthai.Size = new Size(281, 25);
            cboTrangthai.TabIndex = 15;
            // 
            // txtMabs
            // 
            txtMabs.Location = new Point(123, 53);
            txtMabs.Margin = new Padding(2);
            txtMabs.Name = "txtMabs";
            txtMabs.ReadOnly = true;
            txtMabs.Size = new Size(281, 25);
            txtMabs.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 258);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(69, 17);
            label11.TabIndex = 10;
            label11.Text = "Trạng thái:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 176);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(46, 17);
            label10.TabIndex = 9;
            label10.Text = "Mô tả:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 138);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(85, 17);
            label9.TabIndex = 8;
            label9.Text = "Chuyên khoa:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(28, 216);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(88, 17);
            label7.TabIndex = 6;
            label7.Text = "Số điện thoại:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 96);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 17);
            label4.TabIndex = 3;
            label4.Text = "Họ và tên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 57);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(68, 17);
            label3.TabIndex = 2;
            label3.Text = "Mã bác sĩ:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(7, 13);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(17, 17);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label13);
            panel2.Location = new Point(438, 86);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1194, 497);
            panel2.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Location = new Point(13, 53);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(486, 403);
            panel4.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(7, 13);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(15, 22);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(0, 77, 153);
            label13.Location = new Point(25, 8);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(162, 18);
            label13.TabIndex = 0;
            label13.Text = "DANH SÁCH BÁC SĨ";
            // 
            // dtgDanhsachbacsi
            // 
            dtgDanhsachbacsi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDanhsachbacsi.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column7, Column3, Column5, Column8 });
            dtgDanhsachbacsi.Location = new Point(453, 137);
            dtgDanhsachbacsi.Margin = new Padding(2);
            dtgDanhsachbacsi.Name = "dtgDanhsachbacsi";
            dtgDanhsachbacsi.RowHeadersWidth = 82;
            dtgDanhsachbacsi.RowTemplate.Height = 33;
            dtgDanhsachbacsi.Size = new Size(1157, 413);
            dtgDanhsachbacsi.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "BacSiID";
            Column1.HeaderText = "Mã bác sĩ";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 95;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "HoTen";
            Column2.FillWeight = 192.3077F;
            Column2.HeaderText = "Họ và tên";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            Column2.Width = 259;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "TenChuyenKhoa";
            Column7.FillWeight = 31.3016777F;
            Column7.HeaderText = "Chuyên khoa";
            Column7.MinimumWidth = 10;
            Column7.Name = "Column7";
            Column7.Width = 200;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "MoTa";
            Column3.FillWeight = 158.574371F;
            Column3.HeaderText = "Mô tả";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            Column3.Width = 500;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "SoDienThoai";
            Column5.FillWeight = 116.605293F;
            Column5.HeaderText = "Số điện thoại";
            Column5.MinimumWidth = 10;
            Column5.Name = "Column5";
            Column5.Width = 157;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "TrangThai";
            Column8.FillWeight = 0.172847971F;
            Column8.HeaderText = "Trạng thái";
            Column8.MinimumWidth = 10;
            Column8.Name = "Column8";
            Column8.Width = 170;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(13, 15);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1619, 60);
            panel3.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // Formqlybacsi
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(1675, 1059);
            Controls.Add(dtgDanhsachbacsi);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "Formqlybacsi";
            Text = "Form1";
            Load += Formqlybacsi_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgDanhsachbacsi).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.ComboBox cboChuyenkhoa;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtMabs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dtgDanhsachbacsi;
        private ComboBox cboTrangthai;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column8;
        private Label label10;
    }

}
