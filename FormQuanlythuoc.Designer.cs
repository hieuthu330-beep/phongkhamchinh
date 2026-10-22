namespace phongkham1
{
    partial class FormQuanlythuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanlythuoc));
            dtgThuoc = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            btnSua = new Button();
            label14 = new Label();
            btnThem = new Button();
            btnLuu = new Button();
            btnLammoi = new Button();
            btnNgungsd = new Button();
            panel3 = new Panel();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtMathuoc = new TextBox();
            txtTenthuoc = new TextBox();
            txtDonvitinh = new TextBox();
            txtDongia = new TextBox();
            txtSoluongton = new TextBox();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            txtMota = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dtgThuoc).BeginInit();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // dtgThuoc
            // 
            dtgThuoc.BackgroundColor = Color.White;
            dtgThuoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgThuoc.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5, Column6, Column7, Column8 });
            dtgThuoc.Location = new Point(801, 233);
            dtgThuoc.Margin = new Padding(3, 4, 3, 4);
            dtgThuoc.Name = "dtgThuoc";
            dtgThuoc.RowHeadersWidth = 45;
            dtgThuoc.Size = new Size(732, 701);
            dtgThuoc.TabIndex = 50;
            dtgThuoc.CellMouseClick += dtgThuoc_CellMouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ThuocID";
            Column1.HeaderText = "Mã thuốc";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 80;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenThuoc";
            Column2.HeaderText = "Tên thuốc";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 150;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "DonViTinh";
            Column5.HeaderText = "ĐVT";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 110;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "DonGia";
            Column6.HeaderText = "Đơn giá";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 150;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "SoLuongTon";
            Column7.HeaderText = "Số lượng tồn";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 110;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "MoTa";
            Column8.HeaderText = "Mô tả ";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 200;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(236, 238, 241);
            panel4.Controls.Add(btnSua);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(btnThem);
            panel4.Controls.Add(btnLuu);
            panel4.Controls.Add(btnLammoi);
            panel4.Controls.Add(btnNgungsd);
            panel4.Location = new Point(27, 759);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(746, 175);
            panel4.TabIndex = 50;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 219, 201);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Bold);
            btnSua.ForeColor = Color.FromArgb(117, 52, 0);
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(272, 82);
            btnSua.Margin = new Padding(3, 4, 3, 4);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 48);
            btnSua.TabIndex = 14;
            btnSua.Text = "   Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += bSua_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(18, 24);
            label14.Name = "label14";
            label14.Size = new Size(204, 30);
            label14.TabIndex = 11;
            label14.Text = "THAO TÁC DỮ LIỆU";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(236, 238, 241);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Bold);
            btnThem.ForeColor = Color.FromArgb(0, 77, 153);
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(22, 82);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(115, 48);
            btnThem.TabIndex = 12;
            btnThem.Text = "      Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.FromArgb(21, 101, 192);
            btnLuu.FlatStyle = FlatStyle.Flat;
            btnLuu.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Bold);
            btnLuu.ForeColor = Color.White;
            btnLuu.Image = (Image)resources.GetObject("btnLuu.Image");
            btnLuu.ImageAlign = ContentAlignment.MiddleLeft;
            btnLuu.Location = new Point(154, 82);
            btnLuu.Margin = new Padding(3, 4, 3, 4);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 48);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "    Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnLammoi
            // 
            btnLammoi.FlatStyle = FlatStyle.Flat;
            btnLammoi.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Bold);
            btnLammoi.Image = (Image)resources.GetObject("btnLammoi.Image");
            btnLammoi.ImageAlign = ContentAlignment.MiddleLeft;
            btnLammoi.Location = new Point(572, 82);
            btnLammoi.Margin = new Padding(3, 4, 3, 4);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(141, 48);
            btnLammoi.TabIndex = 15;
            btnLammoi.Text = "     Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // btnNgungsd
            // 
            btnNgungsd.BackColor = Color.FromArgb(255, 218, 214);
            btnNgungsd.FlatStyle = FlatStyle.Flat;
            btnNgungsd.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Bold);
            btnNgungsd.ForeColor = Color.FromArgb(147, 0, 10);
            btnNgungsd.Image = (Image)resources.GetObject("btnNgungsd.Image");
            btnNgungsd.ImageAlign = ContentAlignment.MiddleLeft;
            btnNgungsd.Location = new Point(389, 82);
            btnNgungsd.Margin = new Padding(3, 4, 3, 4);
            btnNgungsd.Name = "btnNgungsd";
            btnNgungsd.Size = new Size(159, 48);
            btnNgungsd.TabIndex = 16;
            btnNgungsd.Text = "Ngừng SD";
            btnNgungsd.TextAlign = ContentAlignment.MiddleRight;
            btnNgungsd.UseVisualStyleBackColor = false;
            btnNgungsd.Click += btnNgungsd_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(236, 238, 241);
            panel3.Controls.Add(btnTimkiem);
            panel3.Controls.Add(txtTimkiem);
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(801, 124);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(732, 86);
            panel3.TabIndex = 50;
            // 
            // btnTimkiem
            // 
            btnTimkiem.Font = new Font("Segoe UI", 10.18868F);
            btnTimkiem.Location = new Point(365, 29);
            btnTimkiem.Margin = new Padding(3, 4, 3, 4);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(61, 35);
            btnTimkiem.TabIndex = 5;
            btnTimkiem.Text = "Tìm";
            btnTimkiem.UseVisualStyleBackColor = true;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Font = new Font("Segoe UI", 10.18868F);
            txtTimkiem.Location = new Point(438, 30);
            txtTimkiem.Margin = new Padding(3, 4, 3, 4);
            txtTimkiem.Multiline = true;
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.PlaceholderText = "Nhập Mã thuốc hoặc tên thuốc...";
            txtTimkiem.Size = new Size(265, 32);
            txtTimkiem.TabIndex = 4;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(16, 22);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(32, 32);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 77, 153);
            label3.Location = new Point(55, 25);
            label3.Name = "label3";
            label3.Size = new Size(245, 32);
            label3.TabIndex = 0;
            label3.Text = "DANH SÁCH THUỐC";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 14);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1508, 96);
            panel1.TabIndex = 51;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(629, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.6981125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 77, 153);
            label1.Location = new Point(692, 22);
            label1.Name = "label1";
            label1.Size = new Size(285, 45);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ THUỐC";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 238, 241);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(27, 124);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(746, 85);
            panel2.TabIndex = 52;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(53, 29);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 26);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 77, 153);
            label2.Location = new Point(89, 25);
            label2.Name = "label2";
            label2.Size = new Size(237, 32);
            label2.TabIndex = 0;
            label2.Text = "THÔNG TIN THUỐC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12.2264156F);
            label4.Location = new Point(29, 15);
            label4.Name = "label4";
            label4.Size = new Size(113, 30);
            label4.TabIndex = 31;
            label4.Text = "Mã thuốc: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.2264156F);
            label5.Location = new Point(29, 85);
            label5.Name = "label5";
            label5.Size = new Size(115, 30);
            label5.TabIndex = 32;
            label5.Text = "Tên thuốc: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12.2264156F);
            label9.Location = new Point(29, 165);
            label9.Name = "label9";
            label9.Size = new Size(127, 30);
            label9.TabIndex = 36;
            label9.Text = "Đơn vị tính: ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12.2264156F);
            label10.Location = new Point(24, 247);
            label10.Name = "label10";
            label10.Size = new Size(160, 30);
            label10.TabIndex = 37;
            label10.Text = "Đơn giá (VNĐ): ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12.2264156F);
            label11.Location = new Point(29, 321);
            label11.Name = "label11";
            label11.Size = new Size(144, 30);
            label11.TabIndex = 38;
            label11.Text = "Số lượng tồn: ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12.2264156F);
            label12.Location = new Point(37, 492);
            label12.Name = "label12";
            label12.Size = new Size(0, 30);
            label12.TabIndex = 39;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12.2264156F);
            label13.Location = new Point(29, 400);
            label13.Name = "label13";
            label13.Size = new Size(79, 30);
            label13.TabIndex = 40;
            label13.Text = "Mô tả: ";
            // 
            // txtMathuoc
            // 
            txtMathuoc.BackColor = Color.White;
            txtMathuoc.Font = new Font("Segoe UI", 12.2264156F);
            txtMathuoc.Location = new Point(197, 12);
            txtMathuoc.Margin = new Padding(3, 4, 3, 4);
            txtMathuoc.Multiline = true;
            txtMathuoc.Name = "txtMathuoc";
            txtMathuoc.ReadOnly = true;
            txtMathuoc.Size = new Size(429, 43);
            txtMathuoc.TabIndex = 41;
            // 
            // txtTenthuoc
            // 
            txtTenthuoc.Font = new Font("Segoe UI", 12.2264156F);
            txtTenthuoc.Location = new Point(198, 85);
            txtTenthuoc.Margin = new Padding(3, 4, 3, 4);
            txtTenthuoc.Multiline = true;
            txtTenthuoc.Name = "txtTenthuoc";
            txtTenthuoc.Size = new Size(429, 43);
            txtTenthuoc.TabIndex = 42;
            // 
            // txtDonvitinh
            // 
            txtDonvitinh.Font = new Font("Segoe UI", 12.2264156F);
            txtDonvitinh.Location = new Point(198, 165);
            txtDonvitinh.Margin = new Padding(3, 4, 3, 4);
            txtDonvitinh.Multiline = true;
            txtDonvitinh.Name = "txtDonvitinh";
            txtDonvitinh.Size = new Size(429, 43);
            txtDonvitinh.TabIndex = 46;
            // 
            // txtDongia
            // 
            txtDongia.Font = new Font("Segoe UI", 12.2264156F);
            txtDongia.Location = new Point(200, 242);
            txtDongia.Margin = new Padding(3, 4, 3, 4);
            txtDongia.Multiline = true;
            txtDongia.Name = "txtDongia";
            txtDongia.Size = new Size(429, 43);
            txtDongia.TabIndex = 47;
            // 
            // txtSoluongton
            // 
            txtSoluongton.Font = new Font("Segoe UI", 12.2264156F);
            txtSoluongton.Location = new Point(200, 321);
            txtSoluongton.Margin = new Padding(3, 4, 3, 4);
            txtSoluongton.Multiline = true;
            txtSoluongton.Name = "txtSoluongton";
            txtSoluongton.Size = new Size(429, 43);
            txtSoluongton.TabIndex = 48;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(236, 238, 241);
            panel5.Controls.Add(pictureBox4);
            panel5.Controls.Add(txtMota);
            panel5.Controls.Add(txtSoluongton);
            panel5.Controls.Add(txtDongia);
            panel5.Controls.Add(txtDonvitinh);
            panel5.Controls.Add(txtTenthuoc);
            panel5.Controls.Add(txtMathuoc);
            panel5.Controls.Add(label13);
            panel5.Controls.Add(label12);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(27, 233);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(746, 508);
            panel5.TabIndex = 32;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(592, 24);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(16, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 50;
            pictureBox4.TabStop = false;
            // 
            // txtMota
            // 
            txtMota.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMota.Location = new Point(200, 386);
            txtMota.Margin = new Padding(3, 4, 3, 4);
            txtMota.Multiline = true;
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(429, 103);
            txtMota.TabIndex = 49;
            // 
            // FormQuanlythuoc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(1674, 941);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(dtgThuoc);
            Controls.Add(panel5);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormQuanlythuoc";
            Text = "FormQuanlythuoc";
            Load += FormQuanlythuoc_Load;
            ((System.ComponentModel.ISupportInitialize)dtgThuoc).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dtgThuoc;
        private Panel panel4;
        private Button btnSua;
        private Label label14;
        private Button btnThem;
        private Button btnLuu;
        private Button btnLammoi;
        private Button btnNgungsd;
        private Panel panel3;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private PictureBox pictureBox3;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtMathuoc;
        private TextBox txtTenthuoc;
        private TextBox txtDonvitinh;
        private TextBox txtDongia;
        private TextBox txtSoluongton;
        private Panel panel5;
        private TextBox txtMota;
        private PictureBox pictureBox4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}