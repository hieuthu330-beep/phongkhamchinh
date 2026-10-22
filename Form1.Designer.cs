namespace phongkham1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanelDangnhap = new TableLayoutPanel();
            panel1 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            button1 = new Button();
            label15 = new Label();
            btnLogin = new Button();
            label8 = new Label();
            label10 = new Label();
            pictureBox6 = new PictureBox();
            txtUsername = new TextBox();
            label11 = new Label();
            label9 = new Label();
            pictureBox7 = new PictureBox();
            label14 = new Label();
            txtPassword = new TextBox();
            label13 = new Label();
            label12 = new Label();
            pictureBox8 = new PictureBox();
            imageList1 = new ImageList(components);
            imageList2 = new ImageList(components);
            tableLayoutPanelDangnhap.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanelDangnhap
            // 
            tableLayoutPanelDangnhap.BackColor = Color.White;
            tableLayoutPanelDangnhap.ColumnCount = 2;
            tableLayoutPanelDangnhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelDangnhap.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelDangnhap.Controls.Add(panel1, 0, 0);
            tableLayoutPanelDangnhap.Controls.Add(panel2, 1, 0);
            tableLayoutPanelDangnhap.Dock = DockStyle.Fill;
            tableLayoutPanelDangnhap.Location = new Point(0, 0);
            tableLayoutPanelDangnhap.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanelDangnhap.Name = "tableLayoutPanelDangnhap";
            tableLayoutPanelDangnhap.RowCount = 1;
            tableLayoutPanelDangnhap.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelDangnhap.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelDangnhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelDangnhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelDangnhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelDangnhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelDangnhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelDangnhap.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanelDangnhap.Size = new Size(1262, 731);
            tableLayoutPanelDangnhap.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 723);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(625, 99);
            panel3.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 97, 148);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(2, 15);
            label1.Name = "label1";
            label1.Size = new Size(290, 54);
            label1.TabIndex = 1;
            label1.Text = "       EcoHealth";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(55, 69);
            label2.Name = "label2";
            label2.Size = new Size(259, 17);
            label2.TabIndex = 2;
            label2.Text = "Hệ thống Quản lý Phòng khám Thông minh";
            label2.Click += label2_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(35, 314);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(64, 64);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Dock = DockStyle.Bottom;
            label5.Font = new Font("Segoe UI", 7.8F);
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(0, 672);
            label5.Name = "label5";
            label5.Size = new Size(378, 17);
            label5.TabIndex = 5;
            label5.Text = "     Đồng bộ đa phân hệ: Tiếp đón, Khám bệnh, CLS & Nhà thuốc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Dock = DockStyle.Bottom;
            label4.Font = new Font("Segoe UI", 7.8F);
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(0, 689);
            label4.Name = "label4";
            label4.Size = new Size(325, 17);
            label4.TabIndex = 4;
            label4.Text = "     Bảo mật dữ liệu bệnh nhân & mã hóa phiên AES-256";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Dock = DockStyle.Bottom;
            label3.Font = new Font("Segoe UI", 7.8F);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(0, 706);
            label3.Name = "label3";
            label3.Size = new Size(330, 17);
            label3.TabIndex = 3;
            label3.Text = "     Quản lý hồ sơ bệnh án điện tử (EMR) chuẩn Bộ Y Tế";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(129, 328);
            label6.Name = "label6";
            label6.Size = new Size(249, 23);
            label6.TabIndex = 10;
            label6.Text = "Trung tâm Y khoa Kỹ thuật cao";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(129, 361);
            label7.Name = "label7";
            label7.Size = new Size(264, 17);
            label7.TabIndex = 11;
            label7.Text = "Hệ thống phân quyền vai trò bảo mật cấp 3";
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(pictureBox8);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(634, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(625, 723);
            panel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(0, 97, 148);
            button1.Location = new Point(300, 498);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Đăng ký";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(146, 503);
            label15.Name = "label15";
            label15.Size = new Size(139, 20);
            label15.TabIndex = 9;
            label15.Text = "Chưa có tài khoản ?";
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.BackColor = Color.FromArgb(0, 97, 148);
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(201, 407);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(188, 34);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Đăng nhập hệ thống";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(0, 97, 148);
            label8.Location = new Point(139, 159);
            label8.Name = "label8";
            label8.Size = new Size(172, 41);
            label8.TabIndex = 1;
            label8.Text = "Đăng nhập";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(153, 241);
            label10.Name = "label10";
            label10.Size = new Size(66, 17);
            label10.TabIndex = 3;
            label10.Text = "EcoHealth";
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(311, 177);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(8, 8);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 4;
            pictureBox6.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtUsername.Location = new Point(154, 291);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "vui lòng nhập tài khoản";
            txtUsername.Size = new Size(303, 27);
            txtUsername.TabIndex = 6;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 7.20000029F);
            label11.Location = new Point(154, 271);
            label11.Name = "label11";
            label11.Size = new Size(185, 17);
            label11.TabIndex = 5;
            label11.Text = "Tên đăng nhập / Số điện thoại";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(152, 212);
            label9.Name = "label9";
            label9.Size = new Size(351, 17);
            label9.TabIndex = 2;
            label9.Text = "Chào mừng bạn quay trở lại hệ thống quản lý phòng khám";
            // 
            // pictureBox7
            // 
            pictureBox7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(117, 287);
            pictureBox7.Margin = new Padding(3, 4, 3, 4);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(34, 36);
            pictureBox7.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 7.20000029F);
            label14.ForeColor = SystemColors.ActiveBorder;
            label14.Location = new Point(379, 341);
            label14.Name = "label14";
            label14.Size = new Size(78, 17);
            label14.TabIndex = 5;
            label14.Text = "txtPassword";
            // 
            // txtPassword
            // 
            txtPassword.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPassword.Location = new Point(154, 358);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "vui lòng nhập mật khẩu";
            txtPassword.Size = new Size(303, 27);
            txtPassword.TabIndex = 7;
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 7.20000029F);
            label13.ForeColor = SystemColors.ActiveBorder;
            label13.Location = new Point(376, 271);
            label13.Name = "label13";
            label13.Size = new Size(81, 17);
            label13.TabIndex = 5;
            label13.Text = "txtUsername";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 7.20000029F);
            label12.Location = new Point(155, 338);
            label12.Name = "label12";
            label12.Size = new Size(62, 17);
            label12.TabIndex = 5;
            label12.Text = "Mật khẩu";
            // 
            // pictureBox8
            // 
            pictureBox8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(115, 348);
            pictureBox8.Margin = new Padding(3, 4, 3, 4);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(33, 36);
            pictureBox8.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox8.TabIndex = 0;
            pictureBox8.TabStop = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // imageList2
            // 
            imageList2.ColorDepth = ColorDepth.Depth32Bit;
            imageList2.ImageSize = new Size(16, 16);
            imageList2.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 731);
            Controls.Add(tableLayoutPanelDangnhap);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += Form1_Load;
            tableLayoutPanelDangnhap.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanelDangnhap;
        private Panel panel1;
        private ImageList imageList1;
        private ImageList imageList2;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private Button btnLogin;
        private Panel panel3;
        private Panel panel2;
        private Label label15;
        private Button button1;
    }
}
