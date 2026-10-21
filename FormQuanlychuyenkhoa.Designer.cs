namespace phongkham1
{
    partial class FormQuanlychuyenkhoa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuanlychuyenkhoa));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            btnTimkiem = new Button();
            txtTimkiem = new TextBox();
            pictureBox3 = new PictureBox();
            label4 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            dtgChuyenkhoa = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            txtMota = new TextBox();
            txtTenchuyenkhoa = new TextBox();
            txtMachuyenkhoa = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            panel4 = new Panel();
            cboTrangthai = new ComboBox();
            label10 = new Label();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            btnSua = new Button();
            label9 = new Label();
            btnThem = new Button();
            btnLuu = new Button();
            btnLammoi = new Button();
            btnXoa = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgChuyenkhoa).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 238, 241);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(8, 102);
            panel1.Name = "panel1";
            panel1.Size = new Size(704, 73);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(31, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(555, 29);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 1;
            label3.Text = "Chi tiết bản ghi ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 77, 153);
            label2.Location = new Point(79, 21);
            label2.Name = "label2";
            label2.Size = new Size(289, 30);
            label2.TabIndex = 0;
            label2.Text = "THÔNG TIN CHUYÊN KHOA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 238, 241);
            panel2.Controls.Add(btnTimkiem);
            panel2.Controls.Add(txtTimkiem);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(734, 102);
            panel2.Name = "panel2";
            panel2.Size = new Size(918, 73);
            panel2.TabIndex = 4;
            // 
            // btnTimkiem
            // 
            btnTimkiem.BackColor = Color.White;
            btnTimkiem.FlatStyle = FlatStyle.Flat;
            btnTimkiem.Image = (Image)resources.GetObject("btnTimkiem.Image");
            btnTimkiem.ImageAlign = ContentAlignment.MiddleLeft;
            btnTimkiem.Location = new Point(575, 21);
            btnTimkiem.Name = "btnTimkiem";
            btnTimkiem.Size = new Size(32, 35);
            btnTimkiem.TabIndex = 3;
            btnTimkiem.TextAlign = ContentAlignment.MiddleLeft;
            btnTimkiem.UseVisualStyleBackColor = false;
            btnTimkiem.Click += btnTimkiem_Click;
            // 
            // txtTimkiem
            // 
            txtTimkiem.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimkiem.Location = new Point(613, 21);
            txtTimkiem.Multiline = true;
            txtTimkiem.Name = "txtTimkiem";
            txtTimkiem.PlaceholderText = "Tìm theo tên khoa...";
            txtTimkiem.Size = new Size(280, 35);
            txtTimkiem.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(24, 25);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(27, 24);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 1;
            pictureBox3.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 77, 153);
            label4.Location = new Point(73, 21);
            label4.Name = "label4";
            label4.Size = new Size(296, 30);
            label4.TabIndex = 0;
            label4.Text = "DANH SÁCH CHUYÊN KHOA";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(8, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1644, 73);
            panel3.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.6981125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 77, 153);
            label1.Location = new Point(616, 18);
            label1.Name = "label1";
            label1.Size = new Size(359, 40);
            label1.TabIndex = 1;
            label1.Text = "QUẢN LÝ CHUYÊN KHOA";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(573, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dtgChuyenkhoa
            // 
            dtgChuyenkhoa.BackgroundColor = Color.White;
            dtgChuyenkhoa.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.830189F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dtgChuyenkhoa.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dtgChuyenkhoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgChuyenkhoa.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dtgChuyenkhoa.Location = new Point(734, 214);
            dtgChuyenkhoa.Name = "dtgChuyenkhoa";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.830189F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(32, 37, 45);
            dataGridViewCellStyle2.Padding = new Padding(5, 0, 5, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(212, 227, 255);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(6, 75, 155);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dtgChuyenkhoa.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dtgChuyenkhoa.RowHeadersWidth = 45;
            dtgChuyenkhoa.ScrollBars = ScrollBars.None;
            dtgChuyenkhoa.Size = new Size(918, 719);
            dtgChuyenkhoa.TabIndex = 21;
            dtgChuyenkhoa.MouseClick += dtgChuyenkhoa_MouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ChuyenKhoaID";
            Column1.HeaderText = "Mã chuyên khoa";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 130;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "TenChuyenKhoa";
            Column2.HeaderText = "Tên chuyên khoa";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 250;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "MoTa";
            Column3.HeaderText = "Mô tả";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 400;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "TrangThai";
            Column4.HeaderText = "Trạng thái";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 93;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(564, 41);
            label8.Name = "label8";
            label8.Size = new Size(105, 20);
            label8.TabIndex = 23;
            label8.Text = "(Tự động sinh)";
            // 
            // txtMota
            // 
            txtMota.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMota.Location = new Point(15, 283);
            txtMota.Multiline = true;
            txtMota.Name = "txtMota";
            txtMota.Size = new Size(654, 163);
            txtMota.TabIndex = 24;
            // 
            // txtTenchuyenkhoa
            // 
            txtTenchuyenkhoa.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTenchuyenkhoa.Location = new Point(15, 171);
            txtTenchuyenkhoa.Multiline = true;
            txtTenchuyenkhoa.Name = "txtTenchuyenkhoa";
            txtTenchuyenkhoa.Size = new Size(654, 50);
            txtTenchuyenkhoa.TabIndex = 25;
            // 
            // txtMachuyenkhoa
            // 
            txtMachuyenkhoa.BackColor = Color.White;
            txtMachuyenkhoa.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMachuyenkhoa.Location = new Point(16, 82);
            txtMachuyenkhoa.Multiline = true;
            txtMachuyenkhoa.Name = "txtMachuyenkhoa";
            txtMachuyenkhoa.ReadOnly = true;
            txtMachuyenkhoa.Size = new Size(654, 50);
            txtMachuyenkhoa.TabIndex = 26;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 243);
            label7.Name = "label7";
            label7.Size = new Size(256, 25);
            label7.TabIndex = 27;
            label7.Text = "Mô tả chức năng và nhiệm vụ: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 135);
            label6.Name = "label6";
            label6.Size = new Size(152, 25);
            label6.TabIndex = 28;
            label6.Text = "Tên chuyên khoa: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 41);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 29;
            label5.Text = "Mã chuyên khoa: ";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(236, 238, 241);
            panel4.Controls.Add(cboTrangthai);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(txtMachuyenkhoa);
            panel4.Controls.Add(txtMota);
            panel4.Controls.Add(txtTenchuyenkhoa);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(8, 192);
            panel4.Name = "panel4";
            panel4.Size = new Size(704, 574);
            panel4.TabIndex = 31;
            // 
            // cboTrangthai
            // 
            cboTrangthai.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTrangthai.FormattingEnabled = true;
            cboTrangthai.Items.AddRange(new object[] { "Ngừng hoạt động", "Đang hoạt động" });
            cboTrangthai.Location = new Point(15, 515);
            cboTrangthai.Name = "cboTrangthai";
            cboTrangthai.Size = new Size(654, 33);
            cboTrangthai.TabIndex = 32;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(15, 469);
            label10.Name = "label10";
            label10.Size = new Size(98, 25);
            label10.TabIndex = 31;
            label10.Text = "Trạng thái: ";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(627, 96);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(16, 21);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 30;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(236, 238, 241);
            panel5.Controls.Add(btnSua);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(btnThem);
            panel5.Controls.Add(btnLuu);
            panel5.Controls.Add(btnLammoi);
            panel5.Controls.Add(btnXoa);
            panel5.Location = new Point(8, 784);
            panel5.Name = "panel5";
            panel5.Size = new Size(705, 149);
            panel5.TabIndex = 31;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(255, 219, 201);
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Bold);
            btnSua.ForeColor = Color.FromArgb(117, 52, 0);
            btnSua.Image = (Image)resources.GetObject("btnSua.Image");
            btnSua.ImageAlign = ContentAlignment.MiddleLeft;
            btnSua.Location = new Point(285, 72);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(120, 41);
            btnSua.TabIndex = 14;
            btnSua.Text = "   Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 20);
            label9.Name = "label9";
            label9.Size = new Size(178, 25);
            label9.TabIndex = 11;
            label9.Text = "THAO TÁC DỮ LIỆU";
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(236, 238, 241);
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Bold);
            btnThem.ForeColor = Color.FromArgb(0, 77, 153);
            btnThem.Image = (Image)resources.GetObject("btnThem.Image");
            btnThem.ImageAlign = ContentAlignment.MiddleLeft;
            btnThem.Location = new Point(10, 72);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(120, 41);
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
            btnLuu.Location = new Point(147, 72);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(120, 41);
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
            btnLammoi.Location = new Point(562, 72);
            btnLammoi.Name = "btnLammoi";
            btnLammoi.Size = new Size(130, 41);
            btnLammoi.TabIndex = 15;
            btnLammoi.Text = "     Làm mới";
            btnLammoi.UseVisualStyleBackColor = true;
            btnLammoi.Click += btnLammoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 218, 214);
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 12.2264156F, FontStyle.Bold);
            btnXoa.ForeColor = Color.FromArgb(147, 0, 10);
            btnXoa.Image = (Image)resources.GetObject("btnXoa.Image");
            btnXoa.ImageAlign = ContentAlignment.MiddleLeft;
            btnXoa.Location = new Point(425, 72);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(120, 41);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "   Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // FormQuanlychuyenkhoa
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(247, 249, 252);
            ClientSize = new Size(1675, 1059);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(dtgChuyenkhoa);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormQuanlychuyenkhoa";
            Text = "Formchuyenkhoa";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgChuyenkhoa).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label2;
        private Panel panel2;
        private Button btnTimkiem;
        private TextBox txtTimkiem;
        private PictureBox pictureBox3;
        private Label label4;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private DataGridView dtgChuyenkhoa;
        private Label label8;
        private TextBox txtMota;
        private TextBox txtTenchuyenkhoa;
        private TextBox txtMachuyenkhoa;
        private Label label7;
        private Label label6;
        private Label label5;
        private Panel panel4;
        private PictureBox pictureBox4;
        private Panel panel5;
        private Button btnSua;
        private Label label9;
        private Button btnThem;
        private Button btnLuu;
        private Button btnLammoi;
        private Button btnXoa;
        private ComboBox cboTrangthai;
        private Label label10;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}