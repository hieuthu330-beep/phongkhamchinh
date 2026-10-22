namespace phongkham1
{
    partial class Formquanlylichhenadmin
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
            Column9 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            txtTimKiem = new TextBox();
            btnLamMoi = new Button();
            cboTrangThaiFilter = new ComboBox();
            dtpNgayKhamFilter = new DateTimePicker();
            txtMaLichHen = new TextBox();
            txtTenBenhNhan = new TextBox();
            txtSoDienThoai = new TextBox();
            txtChuyenKhoa = new TextBox();
            txtBacSi = new TextBox();
            txtTrieuchung = new TextBox();
            txtTrangThai = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLichHen).BeginInit();
            SuspendLayout();
            // 
            // dgvLichHen
            // 
            dgvLichHen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichHen.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column9, Column5, Column6, Column7, Column8 });
            dgvLichHen.Location = new Point(285, 602);
            dgvLichHen.Name = "dgvLichHen";
            dgvLichHen.RowHeadersWidth = 51;
            dgvLichHen.Size = new Size(1179, 298);
            dgvLichHen.TabIndex = 0;
            dgvLichHen.CellClick += dgvLichHen_CellClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "LichHenID";
            Column1.HeaderText = "Lịch hẹn ID";
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
            Column4.DataPropertyName = "TenChuyenKhoa";
            Column4.HeaderText = "Chuyên khoa";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "TenBacSi";
            Column9.HeaderText = "Bác sĩ";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "NgayKham";
            Column5.HeaderText = "Ngày khám";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "KhungGio";
            Column6.HeaderText = "Giờ khám";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "TrangThai";
            Column7.HeaderText = "Trạng thái";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "MoTaTrieuChung";
            Column8.HeaderText = "Triệu chứng";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(970, 531);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên bệnh nhân";
            txtTimKiem.Size = new Size(284, 27);
            txtTimKiem.TabIndex = 1;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(1384, 533);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 2;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // cboTrangThaiFilter
            // 
            cboTrangThaiFilter.FormattingEnabled = true;
            cboTrangThaiFilter.Location = new Point(256, 531);
            cboTrangThaiFilter.Name = "cboTrangThaiFilter";
            cboTrangThaiFilter.Size = new Size(151, 28);
            cboTrangThaiFilter.TabIndex = 3;
            // 
            // dtpNgayKhamFilter
            // 
            dtpNgayKhamFilter.Format = DateTimePickerFormat.Short;
            dtpNgayKhamFilter.Location = new Point(550, 532);
            dtpNgayKhamFilter.Name = "dtpNgayKhamFilter";
            dtpNgayKhamFilter.Size = new Size(250, 27);
            dtpNgayKhamFilter.TabIndex = 4;
            // 
            // txtMaLichHen
            // 
            txtMaLichHen.Location = new Point(305, 47);
            txtMaLichHen.Name = "txtMaLichHen";
            txtMaLichHen.ReadOnly = true;
            txtMaLichHen.Size = new Size(230, 27);
            txtMaLichHen.TabIndex = 5;
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(891, 47);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(284, 27);
            txtTenBenhNhan.TabIndex = 6;
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Location = new Point(1365, 54);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(125, 27);
            txtSoDienThoai.TabIndex = 7;
            // 
            // txtChuyenKhoa
            // 
            txtChuyenKhoa.Location = new Point(305, 151);
            txtChuyenKhoa.Name = "txtChuyenKhoa";
            txtChuyenKhoa.Size = new Size(230, 27);
            txtChuyenKhoa.TabIndex = 8;
            // 
            // txtBacSi
            // 
            txtBacSi.Location = new Point(305, 256);
            txtBacSi.Name = "txtBacSi";
            txtBacSi.Size = new Size(230, 27);
            txtBacSi.TabIndex = 9;
            // 
            // txtTrieuchung
            // 
            txtTrieuchung.Location = new Point(891, 151);
            txtTrieuchung.Multiline = true;
            txtTrieuchung.Name = "txtTrieuchung";
            txtTrieuchung.Size = new Size(503, 166);
            txtTrieuchung.TabIndex = 10;
            // 
            // txtTrangThai
            // 
            txtTrangThai.Location = new Point(303, 347);
            txtTrangThai.Name = "txtTrangThai";
            txtTrangThai.Size = new Size(232, 27);
            txtTrangThai.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 54);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 12;
            label1.Text = "Mã lịch hẹn:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(735, 57);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 12;
            label2.Text = "Tên bệnh nhân:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1283, 61);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 12;
            label3.Text = "SDT:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 158);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 12;
            label4.Text = "Chuyên khoa:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 263);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 12;
            label5.Text = "Bác sĩ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(735, 158);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 12;
            label6.Text = "Triệu chứng:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(191, 350);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 12;
            label7.Text = "Trạng thái:";
            // 
            // Formquanlylichhenadmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1657, 1012);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTrangThai);
            Controls.Add(txtTrieuchung);
            Controls.Add(txtBacSi);
            Controls.Add(txtChuyenKhoa);
            Controls.Add(txtSoDienThoai);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(txtMaLichHen);
            Controls.Add(dtpNgayKhamFilter);
            Controls.Add(cboTrangThaiFilter);
            Controls.Add(btnLamMoi);
            Controls.Add(txtTimKiem);
            Controls.Add(dgvLichHen);
            Name = "Formquanlylichhenadmin";
            Text = "Formquanlylichhenadmin";
            ((System.ComponentModel.ISupportInitialize)dgvLichHen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvLichHen;
        private TextBox txtTimKiem;
        private Button btnLamMoi;
        private ComboBox cboTrangThaiFilter;
        private DateTimePicker dtpNgayKhamFilter;
        private TextBox txtMaLichHen;
        private TextBox txtTenBenhNhan;
        private TextBox txtSoDienThoai;
        private TextBox txtChuyenKhoa;
        private TextBox txtBacSi;
        private TextBox txtTrieuchung;
        private TextBox txtTrangThai;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}