namespace phongkham1
{
    partial class formThanhToanPhatthuocNhanvien
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
            dgvDanhSachChoThanhToan = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            dgvChiTietDonThanhToan = new DataGridView();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            lblTongTien = new Label();
            btnThanhToanXuatThuoc = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachChoThanhToan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDonThanhToan).BeginInit();
            SuspendLayout();
            // 
            // dgvDanhSachChoThanhToan
            // 
            dgvDanhSachChoThanhToan.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDanhSachChoThanhToan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDanhSachChoThanhToan.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvDanhSachChoThanhToan.Location = new Point(12, 156);
            dgvDanhSachChoThanhToan.Name = "dgvDanhSachChoThanhToan";
            dgvDanhSachChoThanhToan.RowHeadersWidth = 51;
            dgvDanhSachChoThanhToan.Size = new Size(805, 532);
            dgvDanhSachChoThanhToan.TabIndex = 0;
            dgvDanhSachChoThanhToan.CellMouseClick += dgvDanhSachChoThanhToan_CellMouseClick;
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
            Column4.DataPropertyName = "TenBacSi";
            Column4.HeaderText = "Bác sĩ khám";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "KhungGio";
            Column5.HeaderText = "Giờ hẹn";
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
            // dgvChiTietDonThanhToan
            // 
            dgvChiTietDonThanhToan.BackgroundColor = SystemColors.ButtonHighlight;
            dgvChiTietDonThanhToan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvChiTietDonThanhToan.Columns.AddRange(new DataGridViewColumn[] { Column7, Column8, Column9, Column10, Column12, Column11 });
            dgvChiTietDonThanhToan.Location = new Point(866, 156);
            dgvChiTietDonThanhToan.Name = "dgvChiTietDonThanhToan";
            dgvChiTietDonThanhToan.RowHeadersWidth = 51;
            dgvChiTietDonThanhToan.Size = new Size(806, 450);
            dgvChiTietDonThanhToan.TabIndex = 1;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "TenThuoc";
            Column7.HeaderText = "Tên thuốc";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "DonViTinh";
            Column8.HeaderText = "Đơn vị tính";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 125;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "SoLuong";
            Column9.HeaderText = "Số lượng";
            Column9.MinimumWidth = 6;
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 125;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "DonGia";
            Column10.HeaderText = "Đơn giá";
            Column10.MinimumWidth = 6;
            Column10.Name = "Column10";
            Column10.ReadOnly = true;
            Column10.Width = 125;
            // 
            // Column12
            // 
            Column12.DataPropertyName = "ThanhTien";
            Column12.HeaderText = "Thành tiền";
            Column12.MinimumWidth = 6;
            Column12.Name = "Column12";
            Column12.ReadOnly = true;
            Column12.Width = 125;
            // 
            // Column11
            // 
            Column11.DataPropertyName = "CachDung";
            Column11.HeaderText = "Cách dùng";
            Column11.MinimumWidth = 6;
            Column11.Name = "Column11";
            Column11.ReadOnly = true;
            Column11.Width = 125;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(853, 642);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(431, 41);
            lblTongTien.TabIndex = 2;
            lblTongTien.Text = "Hiển thị tổng tiền thanh toán";
            // 
            // btnThanhToanXuatThuoc
            // 
            btnThanhToanXuatThuoc.BackColor = Color.FromArgb(21, 101, 192);
            btnThanhToanXuatThuoc.FlatStyle = FlatStyle.Flat;
            btnThanhToanXuatThuoc.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToanXuatThuoc.ForeColor = Color.White;
            btnThanhToanXuatThuoc.Location = new Point(598, 725);
            btnThanhToanXuatThuoc.Name = "btnThanhToanXuatThuoc";
            btnThanhToanXuatThuoc.Size = new Size(245, 62);
            btnThanhToanXuatThuoc.TabIndex = 3;
            btnThanhToanXuatThuoc.Text = "Xác nhận thanh toán & Xuất thuốc";
            btnThanhToanXuatThuoc.UseVisualStyleBackColor = false;
            btnThanhToanXuatThuoc.Click += btnThanhToanXuatThuoc_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Bold);
            label1.Location = new Point(304, 103);
            label1.Name = "label1";
            label1.Size = new Size(127, 37);
            label1.TabIndex = 4;
            label1.Text = "Lịch Hẹn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Bold);
            label2.Location = new Point(1195, 103);
            label2.Name = "label2";
            label2.Size = new Size(155, 37);
            label2.TabIndex = 4;
            label2.Text = "Đơn Thuốc";
            // 
            // formThanhToanPhatthuocNhanvien
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(1684, 897);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnThanhToanXuatThuoc);
            Controls.Add(lblTongTien);
            Controls.Add(dgvChiTietDonThanhToan);
            Controls.Add(dgvDanhSachChoThanhToan);
            Name = "formThanhToanPhatthuocNhanvien";
            Text = "formThanhToanPhatthuocNhanvien";
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachChoThanhToan).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvChiTietDonThanhToan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDanhSachChoThanhToan;
        private DataGridView dgvChiTietDonThanhToan;
        private Label lblTongTien;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button btnThanhToanXuatThuoc;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column11;
        private Label label1;
        private Label label2;
    }
}