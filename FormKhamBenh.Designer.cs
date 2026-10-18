namespace phongkham1
{
    partial class FormKhamBenh
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
            dgvDanhSachCho = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            siticonePanel1 = new SiticoneNetCoreUI.SiticonePanel();
            lblTrieuchung = new Label();
            siticonePanel2 = new SiticoneNetCoreUI.SiticonePanel();
            label2 = new Label();
            label1 = new Label();
            txtLoiDan = new TextBox();
            txtChanDoan = new TextBox();
            siticonePanel3 = new SiticoneNetCoreUI.SiticonePanel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            btnThemThuocVaoDon = new Button();
            cbThuoc = new ComboBox();
            txtCachDung = new TextBox();
            dgvChiTietDon = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            txtSoLuong = new TextBox();
            btnHoanTatKham = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachCho).BeginInit();
            siticonePanel1.SuspendLayout();
            siticonePanel2.SuspendLayout();
            siticonePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDon).BeginInit();
            SuspendLayout();
            // 
            // dgvDanhSachCho
            // 
            dgvDanhSachCho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachCho.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvDanhSachCho.Location = new Point(186, 105);
            dgvDanhSachCho.Name = "dgvDanhSachCho";
            dgvDanhSachCho.RowHeadersWidth = 51;
            dgvDanhSachCho.Size = new Size(840, 188);
            dgvDanhSachCho.TabIndex = 0;
            dgvDanhSachCho.CellMouseClick += dgvDanhSachCho_CellMouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "LichHenID";
            Column1.HeaderText = "Mã lịch hẹn";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenBenhNhan";
            Column2.HeaderText = "Họ tên bệnh nhân";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "SoDienThoai";
            Column3.HeaderText = "Số điện thoại";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "KhungGio";
            Column4.HeaderText = "Giờ hẹn";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "MoTaTrieuChung";
            Column5.HeaderText = "Triệu chứng";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "TrangThai";
            Column6.HeaderText = "Trạng thái";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // siticonePanel1
            // 
            siticonePanel1.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            siticonePanel1.BackColor = Color.Transparent;
            siticonePanel1.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            siticonePanel1.BorderColor = Color.Gray;
            siticonePanel1.BorderDashPattern = null;
            siticonePanel1.BorderGradientEndColor = Color.Purple;
            siticonePanel1.BorderGradientStartColor = Color.Blue;
            siticonePanel1.BorderThickness = 2F;
            siticonePanel1.Controls.Add(lblTrieuchung);
            siticonePanel1.CornerRadiusBottomLeft = 0F;
            siticonePanel1.CornerRadiusBottomRight = 0F;
            siticonePanel1.CornerRadiusTopLeft = 0F;
            siticonePanel1.CornerRadiusTopRight = 0F;
            siticonePanel1.EnableAcrylicEffect = false;
            siticonePanel1.EnableMicaEffect = false;
            siticonePanel1.EnableRippleEffect = false;
            siticonePanel1.FillColor = Color.White;
            siticonePanel1.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            siticonePanel1.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            siticonePanel1.Location = new Point(152, 355);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.PatternColor = Color.FromArgb(30, 0, 0, 0);
            siticonePanel1.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            siticonePanel1.RippleAlpha = 50;
            siticonePanel1.RippleAlphaDecrement = 3;
            siticonePanel1.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel1.RippleMaxSize = 600F;
            siticonePanel1.RippleSpeed = 15F;
            siticonePanel1.ShowBorder = true;
            siticonePanel1.Size = new Size(439, 318);
            siticonePanel1.TabIndex = 1;
            siticonePanel1.TabStop = true;
            siticonePanel1.UseBorderGradient = false;
            siticonePanel1.UseMultiGradient = false;
            siticonePanel1.UsePatternTexture = false;
            siticonePanel1.UseRadialGradient = false;
            // 
            // lblTrieuchung
            // 
            lblTrieuchung.AutoSize = true;
            lblTrieuchung.Location = new Point(79, 42);
            lblTrieuchung.Name = "lblTrieuchung";
            lblTrieuchung.Size = new Size(50, 20);
            lblTrieuchung.TabIndex = 0;
            lblTrieuchung.Text = "label1";
            // 
            // siticonePanel2
            // 
            siticonePanel2.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            siticonePanel2.BackColor = Color.Transparent;
            siticonePanel2.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            siticonePanel2.BorderColor = Color.Gray;
            siticonePanel2.BorderDashPattern = null;
            siticonePanel2.BorderGradientEndColor = Color.Purple;
            siticonePanel2.BorderGradientStartColor = Color.Blue;
            siticonePanel2.BorderThickness = 2F;
            siticonePanel2.Controls.Add(label2);
            siticonePanel2.Controls.Add(label1);
            siticonePanel2.Controls.Add(txtLoiDan);
            siticonePanel2.Controls.Add(txtChanDoan);
            siticonePanel2.CornerRadiusBottomLeft = 0F;
            siticonePanel2.CornerRadiusBottomRight = 0F;
            siticonePanel2.CornerRadiusTopLeft = 0F;
            siticonePanel2.CornerRadiusTopRight = 0F;
            siticonePanel2.EnableAcrylicEffect = false;
            siticonePanel2.EnableMicaEffect = false;
            siticonePanel2.EnableRippleEffect = false;
            siticonePanel2.FillColor = Color.White;
            siticonePanel2.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            siticonePanel2.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            siticonePanel2.Location = new Point(643, 355);
            siticonePanel2.Name = "siticonePanel2";
            siticonePanel2.PatternColor = Color.FromArgb(30, 0, 0, 0);
            siticonePanel2.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            siticonePanel2.RippleAlpha = 50;
            siticonePanel2.RippleAlphaDecrement = 3;
            siticonePanel2.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel2.RippleMaxSize = 600F;
            siticonePanel2.RippleSpeed = 15F;
            siticonePanel2.ShowBorder = true;
            siticonePanel2.Size = new Size(439, 318);
            siticonePanel2.TabIndex = 2;
            siticonePanel2.TabStop = true;
            siticonePanel2.UseBorderGradient = false;
            siticonePanel2.UseMultiGradient = false;
            siticonePanel2.UsePatternTexture = false;
            siticonePanel2.UseRadialGradient = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 152);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 3;
            label2.Text = "lời dặn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 71);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "chuẩn đoán";
            // 
            // txtLoiDan
            // 
            txtLoiDan.Location = new Point(151, 154);
            txtLoiDan.Name = "txtLoiDan";
            txtLoiDan.Size = new Size(125, 27);
            txtLoiDan.TabIndex = 1;
            // 
            // txtChanDoan
            // 
            txtChanDoan.Location = new Point(165, 65);
            txtChanDoan.Name = "txtChanDoan";
            txtChanDoan.Size = new Size(125, 27);
            txtChanDoan.TabIndex = 0;
            // 
            // siticonePanel3
            // 
            siticonePanel3.AcrylicTintColor = Color.FromArgb(128, 255, 255, 255);
            siticonePanel3.BackColor = Color.Transparent;
            siticonePanel3.BorderAlignment = System.Drawing.Drawing2D.PenAlignment.Center;
            siticonePanel3.BorderColor = Color.Gray;
            siticonePanel3.BorderDashPattern = null;
            siticonePanel3.BorderGradientEndColor = Color.Purple;
            siticonePanel3.BorderGradientStartColor = Color.Blue;
            siticonePanel3.BorderThickness = 2F;
            siticonePanel3.Controls.Add(label5);
            siticonePanel3.Controls.Add(label4);
            siticonePanel3.Controls.Add(label3);
            siticonePanel3.Controls.Add(btnThemThuocVaoDon);
            siticonePanel3.Controls.Add(cbThuoc);
            siticonePanel3.Controls.Add(txtCachDung);
            siticonePanel3.Controls.Add(dgvChiTietDon);
            siticonePanel3.Controls.Add(txtSoLuong);
            siticonePanel3.CornerRadiusBottomLeft = 0F;
            siticonePanel3.CornerRadiusBottomRight = 0F;
            siticonePanel3.CornerRadiusTopLeft = 0F;
            siticonePanel3.CornerRadiusTopRight = 0F;
            siticonePanel3.EnableAcrylicEffect = false;
            siticonePanel3.EnableMicaEffect = false;
            siticonePanel3.EnableRippleEffect = false;
            siticonePanel3.FillColor = Color.White;
            siticonePanel3.GradientColors = new Color[]
    {
    Color.White,
    Color.LightGray,
    Color.Gray
    };
            siticonePanel3.GradientPositions = new float[]
    {
    0F,
    0.5F,
    1F
    };
            siticonePanel3.Location = new Point(1111, 355);
            siticonePanel3.Name = "siticonePanel3";
            siticonePanel3.PatternColor = Color.FromArgb(30, 0, 0, 0);
            siticonePanel3.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            siticonePanel3.RippleAlpha = 50;
            siticonePanel3.RippleAlphaDecrement = 3;
            siticonePanel3.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel3.RippleMaxSize = 600F;
            siticonePanel3.RippleSpeed = 15F;
            siticonePanel3.ShowBorder = true;
            siticonePanel3.Size = new Size(730, 631);
            siticonePanel3.TabIndex = 3;
            siticonePanel3.TabStop = true;
            siticonePanel3.UseBorderGradient = false;
            siticonePanel3.UseMultiGradient = false;
            siticonePanel3.UsePatternTexture = false;
            siticonePanel3.UseRadialGradient = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(274, 157);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 6;
            label5.Text = "cách dùng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(275, 37);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 5;
            label4.Text = "thuốc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 89);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "số lượng";
            // 
            // btnThemThuocVaoDon
            // 
            btnThemThuocVaoDon.Location = new Point(110, 209);
            btnThemThuocVaoDon.Name = "btnThemThuocVaoDon";
            btnThemThuocVaoDon.Size = new Size(222, 29);
            btnThemThuocVaoDon.TabIndex = 3;
            btnThemThuocVaoDon.Text = "thêm vào đơn";
            btnThemThuocVaoDon.UseVisualStyleBackColor = true;
            btnThemThuocVaoDon.Click += btnThemThuocVaoDon_Click;
            // 
            // cbThuoc
            // 
            cbThuoc.FormattingEnabled = true;
            cbThuoc.Location = new Point(74, 32);
            cbThuoc.Name = "cbThuoc";
            cbThuoc.Size = new Size(151, 28);
            cbThuoc.TabIndex = 2;
            // 
            // txtCachDung
            // 
            txtCachDung.Location = new Point(100, 154);
            txtCachDung.Name = "txtCachDung";
            txtCachDung.Size = new Size(125, 27);
            txtCachDung.TabIndex = 1;
            // 
            // dgvChiTietDon
            // 
            dgvChiTietDon.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietDon.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10 });
            dgvChiTietDon.Location = new Point(89, 310);
            dgvChiTietDon.Name = "dgvChiTietDon";
            dgvChiTietDon.RowHeadersWidth = 51;
            dgvChiTietDon.Size = new Size(553, 188);
            dgvChiTietDon.TabIndex = 0;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "ThuocID";
            Column7.HeaderText = "ThuocID";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "TenThuoc";
            Column8.HeaderText = "TenThuoc";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "SoLuong";
            Column9.HeaderText = "SoLuong";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "CachDung";
            Column10.HeaderText = "CachDung";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 125;
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(100, 85);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(125, 27);
            txtSoLuong.TabIndex = 0;
            // 
            // btnHoanTatKham
            // 
            btnHoanTatKham.Location = new Point(733, 875);
            btnHoanTatKham.Name = "btnHoanTatKham";
            btnHoanTatKham.Size = new Size(112, 29);
            btnHoanTatKham.TabIndex = 4;
            btnHoanTatKham.Text = "Hoàn tất";
            btnHoanTatKham.UseVisualStyleBackColor = true;
            btnHoanTatKham.Click += btnHoanTatKham_Click;
            // 
            // FormKhamBenh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(btnHoanTatKham);
            Controls.Add(siticonePanel3);
            Controls.Add(siticonePanel2);
            Controls.Add(siticonePanel1);
            Controls.Add(dgvDanhSachCho);
            Name = "FormKhamBenh";
            Text = "FormKhamBenh";
            FormClosing += FormKhamBenh_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachCho).EndInit();
            siticonePanel1.ResumeLayout(false);
            siticonePanel1.PerformLayout();
            siticonePanel2.ResumeLayout(false);
            siticonePanel2.PerformLayout();
            siticonePanel3.ResumeLayout(false);
            siticonePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDanhSachCho;
        private SiticoneNetCoreUI.SiticonePanel siticonePanel1;
        private Label lblTrieuchung;
        private SiticoneNetCoreUI.SiticonePanel siticonePanel2;
        private TextBox txtLoiDan;
        private TextBox txtChanDoan;
        private SiticoneNetCoreUI.SiticonePanel siticonePanel3;
        private Button btnThemThuocVaoDon;
        private ComboBox cbThuoc;
        private TextBox txtCachDung;
        private DataGridView dgvChiTietDon;
        private TextBox txtSoLuong;
        private Button btnHoanTatKham;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label5;
        private Label label4;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}