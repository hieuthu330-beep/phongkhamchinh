namespace phongkham1
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            label80 = new Label();
            button7 = new Button();
            btnDatlichkham = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            btnTrangchu = new Button();
            label1 = new Label();
            panelMain = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label80);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(btnDatlichkham);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnTrangchu);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1684, 85);
            panel1.TabIndex = 0;
            // 
            // label80
            // 
            label80.AutoSize = true;
            label80.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label80.ForeColor = Color.FromArgb(0, 106, 97);
            label80.Location = new Point(82, 44);
            label80.Name = "label80";
            label80.Size = new Size(130, 19);
            label80.TabIndex = 10;
            label80.Text = "CLINIC & WELLNESS";
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(1614, 20);
            button7.Name = "button7";
            button7.Size = new Size(37, 34);
            button7.TabIndex = 9;
            button7.UseVisualStyleBackColor = true;
            // 
            // btnDatlichkham
            // 
            btnDatlichkham.FlatAppearance.BorderSize = 0;
            btnDatlichkham.FlatStyle = FlatStyle.Flat;
            btnDatlichkham.Image = (Image)resources.GetObject("btnDatlichkham.Image");
            btnDatlichkham.Location = new Point(1489, 20);
            btnDatlichkham.Name = "btnDatlichkham";
            btnDatlichkham.Size = new Size(108, 37);
            btnDatlichkham.TabIndex = 8;
            btnDatlichkham.UseVisualStyleBackColor = true;
            btnDatlichkham.Click += btnDatlichkham_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button5.Location = new Point(1238, 31);
            button5.Name = "button5";
            button5.Size = new Size(146, 25);
            button5.TabIndex = 7;
            button5.Text = "Lịch hẹn của tôi";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button4.Location = new Point(1017, 31);
            button4.Name = "button4";
            button4.Size = new Size(133, 25);
            button4.TabIndex = 6;
            button4.Text = "Đội ngũ bác sĩ";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button3.Location = new Point(769, 33);
            button3.Name = "button3";
            button3.Size = new Size(161, 25);
            button3.TabIndex = 5;
            button3.Text = "Chuyên khoa";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            button2.Location = new Point(599, 31);
            button2.Name = "button2";
            button2.Size = new Size(122, 25);
            button2.TabIndex = 4;
            button2.Text = "Giới thiệu";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnTrangchu
            // 
            btnTrangchu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            btnTrangchu.FlatAppearance.BorderSize = 0;
            btnTrangchu.FlatStyle = FlatStyle.Flat;
            btnTrangchu.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold);
            btnTrangchu.Location = new Point(404, 31);
            btnTrangchu.Name = "btnTrangchu";
            btnTrangchu.Size = new Size(117, 25);
            btnTrangchu.TabIndex = 3;
            btnTrangchu.Text = "Trang chủ";
            btnTrangchu.UseVisualStyleBackColor = true;
            btnTrangchu.Click += btnTrangchu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 97, 148);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(260, 48);
            label1.TabIndex = 2;
            label1.Text = "       EcoHealth";
            // 
            // panelMain
            // 
            panelMain.AutoScroll = true;
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 85);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1684, 812);
            panelMain.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1684, 897);
            Controls.Add(panelMain);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "FormMain";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormMain_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btnTrangchu;
        private Button button7;
        private Button btnDatlichkham;
        private Label label80;
        private Panel panelMain;
    }
}