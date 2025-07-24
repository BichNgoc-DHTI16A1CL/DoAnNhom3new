namespace DoAnNhom3
{
    partial class KhachHangDangNhap
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
            panel1 = new Panel();
            button1 = new Button();
            btdangxuatKH = new Button();
            btnTaiKhoan = new Button();
            btnMenu = new Button();
            panelkhachhang = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            panelkhachhang.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btdangxuatKH);
            panel1.Controls.Add(btnTaiKhoan);
            panel1.Controls.Add(btnMenu);
            panel1.Location = new Point(2, 68);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(241, 507);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(80, 228);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(148, 52);
            button1.TabIndex = 9;
            button1.Text = "Giỏ Hàng";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btdangxuatKH
            // 
            btdangxuatKH.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btdangxuatKH.ForeColor = Color.Black;
            btdangxuatKH.Location = new Point(80, 402);
            btdangxuatKH.Margin = new Padding(4, 3, 4, 3);
            btdangxuatKH.Name = "btdangxuatKH";
            btdangxuatKH.Size = new Size(148, 52);
            btdangxuatKH.TabIndex = 8;
            btdangxuatKH.Text = "Đăng xuất";
            btdangxuatKH.UseVisualStyleBackColor = true;
            btdangxuatKH.Click += btdangxuatKH_Click;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTaiKhoan.ForeColor = Color.Black;
            btnTaiKhoan.Location = new Point(80, 157);
            btnTaiKhoan.Margin = new Padding(4, 3, 4, 3);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(148, 52);
            btnTaiKhoan.TabIndex = 7;
            btnTaiKhoan.Text = "Tài khoản";
            btnTaiKhoan.UseVisualStyleBackColor = true;
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.Black;
            btnMenu.Location = new Point(80, 82);
            btnMenu.Margin = new Padding(4, 3, 4, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(148, 52);
            btnMenu.TabIndex = 6;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btmenuKH_Click;
            // 
            // panelkhachhang
            // 
            panelkhachhang.Controls.Add(label1);
            panelkhachhang.Location = new Point(251, 51);
            panelkhachhang.Margin = new Padding(4, 3, 4, 3);
            panelkhachhang.Name = "panelkhachhang";
            panelkhachhang.Size = new Size(807, 572);
            panelkhachhang.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(374, 17);
            label1.Name = "label1";
            label1.Size = new Size(81, 27);
            label1.TabIndex = 1;
            label1.Text = "MENU";
            // 
            // KhachHangDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 614);
            Controls.Add(panelkhachhang);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "KhachHangDangNhap";
            Text = "KhachHangDangNhap";
            panel1.ResumeLayout(false);
            panelkhachhang.ResumeLayout(false);
            panelkhachhang.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btdangxuatKH;
        private Label label1;
        public Panel panelkhachhang;
        private Button button1;
    }
}