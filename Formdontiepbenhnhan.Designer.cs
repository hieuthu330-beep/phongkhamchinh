namespace phongkham1
{
    partial class Formdontiepbenhnhan
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
            dgvLichHen = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            txtTimKiem = new TextBox();
            btnTimKiem = new Button();
            btnLoadTatCa = new Button();
            btnCheckIn = new Button();
            siticonePanel1 = new SiticoneNetCoreUI.SiticonePanel();
            siticonePanel2 = new SiticoneNetCoreUI.SiticonePanel();
            ((System.ComponentModel.ISupportInitialize)dgvLichHen).BeginInit();
            siticonePanel1.SuspendLayout();
            siticonePanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvLichHen
            // 
            dgvLichHen.BackgroundColor = SystemColors.ButtonFace;
            dgvLichHen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichHen.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dgvLichHen.GridColor = SystemColors.Menu;
            dgvLichHen.Location = new Point(62, 31);
            dgvLichHen.Name = "dgvLichHen";
            dgvLichHen.RowHeadersWidth = 51;
            dgvLichHen.Size = new Size(1053, 572);
            dgvLichHen.TabIndex = 0;
            dgvLichHen.CellContentClick += dgvLichHen_CellContentClick;
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
            Column2.HeaderText = "Bệnh nhân";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "SoDienThoai";
            Column3.HeaderText = "SDT";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TenBacSi";
            Column4.HeaderText = "Bác sĩ phụ trách";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "TenChuyenKhoa";
            Column5.HeaderText = "Chuyên khoa";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "KhungGio";
            Column6.HeaderText = "Giờ hẹn";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "MoTaTrieuChung";
            Column7.HeaderText = "Triệu chứng";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "TrangThai";
            Column8.HeaderText = "Trạng thái";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 12.2264156F);
            txtTimKiem.Location = new Point(56, 15);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên bệnh nhân...";
            txtTimKiem.Size = new Size(697, 31);
            txtTimKiem.TabIndex = 1;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.FromArgb(21, 101, 192);
            btnTimKiem.FlatStyle = FlatStyle.Flat;
            btnTimKiem.Font = new Font("Segoe UI", 12.2264156F);
            btnTimKiem.ForeColor = Color.White;
            btnTimKiem.Location = new Point(71, 52);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(97, 42);
            btnTimKiem.TabIndex = 2;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnLoadTatCa
            // 
            btnLoadTatCa.Font = new Font("Segoe UI", 12.2264156F);
            btnLoadTatCa.Location = new Point(630, 52);
            btnLoadTatCa.Name = "btnLoadTatCa";
            btnLoadTatCa.Size = new Size(97, 42);
            btnLoadTatCa.TabIndex = 2;
            btnLoadTatCa.Text = "Làm mới";
            btnLoadTatCa.UseVisualStyleBackColor = true;
            btnLoadTatCa.Click += btnLoadTatCa_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.BackColor = Color.FromArgb(255, 218, 214);
            btnCheckIn.FlatStyle = FlatStyle.Flat;
            btnCheckIn.Font = new Font("Segoe UI", 12.2264156F);
            btnCheckIn.Location = new Point(372, 52);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(97, 42);
            btnCheckIn.TabIndex = 2;
            btnCheckIn.Text = "Check in";
            btnCheckIn.UseVisualStyleBackColor = false;
            btnCheckIn.Click += btnCheckIn_Click;
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
            siticonePanel1.Controls.Add(dgvLichHen);
            siticonePanel1.CornerRadiusBottomLeft = 15F;
            siticonePanel1.CornerRadiusBottomRight = 15F;
            siticonePanel1.CornerRadiusTopLeft = 15F;
            siticonePanel1.CornerRadiusTopRight = 15F;
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
            siticonePanel1.Location = new Point(179, 218);
            siticonePanel1.Name = "siticonePanel1";
            siticonePanel1.PatternColor = Color.FromArgb(30, 0, 0, 0);
            siticonePanel1.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            siticonePanel1.RippleAlpha = 50;
            siticonePanel1.RippleAlphaDecrement = 3;
            siticonePanel1.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel1.RippleMaxSize = 600F;
            siticonePanel1.RippleSpeed = 15F;
            siticonePanel1.ShowBorder = true;
            siticonePanel1.Size = new Size(1154, 643);
            siticonePanel1.TabIndex = 3;
            siticonePanel1.TabStop = true;
            siticonePanel1.UseBorderGradient = false;
            siticonePanel1.UseMultiGradient = false;
            siticonePanel1.UsePatternTexture = false;
            siticonePanel1.UseRadialGradient = false;
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
            siticonePanel2.Controls.Add(txtTimKiem);
            siticonePanel2.Controls.Add(btnTimKiem);
            siticonePanel2.Controls.Add(btnCheckIn);
            siticonePanel2.Controls.Add(btnLoadTatCa);
            siticonePanel2.CornerRadiusBottomLeft = 15F;
            siticonePanel2.CornerRadiusBottomRight = 15F;
            siticonePanel2.CornerRadiusTopLeft = 15F;
            siticonePanel2.CornerRadiusTopRight = 15F;
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
            siticonePanel2.Location = new Point(343, 87);
            siticonePanel2.Name = "siticonePanel2";
            siticonePanel2.PatternColor = Color.FromArgb(30, 0, 0, 0);
            siticonePanel2.PatternStyle = System.Drawing.Drawing2D.HatchStyle.Max;
            siticonePanel2.RippleAlpha = 50;
            siticonePanel2.RippleAlphaDecrement = 3;
            siticonePanel2.RippleColor = Color.FromArgb(50, 255, 255, 255);
            siticonePanel2.RippleMaxSize = 600F;
            siticonePanel2.RippleSpeed = 15F;
            siticonePanel2.ShowBorder = true;
            siticonePanel2.Size = new Size(822, 110);
            siticonePanel2.TabIndex = 4;
            siticonePanel2.TabStop = true;
            siticonePanel2.UseBorderGradient = false;
            siticonePanel2.UseMultiGradient = false;
            siticonePanel2.UsePatternTexture = false;
            siticonePanel2.UseRadialGradient = false;
            // 
            // Formdontiepbenhnhan
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(1684, 897);
            Controls.Add(siticonePanel2);
            Controls.Add(siticonePanel1);
            Name = "Formdontiepbenhnhan";
            Text = "Formdontiepbenhnhan";
            ((System.ComponentModel.ISupportInitialize)dgvLichHen).EndInit();
            siticonePanel1.ResumeLayout(false);
            siticonePanel2.ResumeLayout(false);
            siticonePanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvLichHen;
        private TextBox txtTimKiem;
        private Button btnTimKiem;
        private Button btnLoadTatCa;
        private Button btnCheckIn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private SiticoneNetCoreUI.SiticonePanel siticonePanel1;
        private SiticoneNetCoreUI.SiticonePanel siticonePanel2;
    }
}