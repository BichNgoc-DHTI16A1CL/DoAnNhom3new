namespace DoAnNhom3
{
    partial class DangNhap
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
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            txbtendangnhap = new TextBox();
            txbmatkhau = new TextBox();
            btdangnhap = new Button();
            btquenmatkhau = new Button();
            panel1 = new Panel();
            btDangKy = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(110, 22);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(98, 23);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ScrollBar;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 63);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ScrollBar;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 146);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 4;
            label5.Text = "Mật khẩu";
            // 
            // txbtendangnhap
            // 
            txbtendangnhap.Location = new Point(20, 89);
            txbtendangnhap.Margin = new Padding(4, 3, 4, 3);
            txbtendangnhap.Name = "txbtendangnhap";
            txbtendangnhap.Size = new Size(266, 23);
            txbtendangnhap.TabIndex = 5;
            // 
            // txbmatkhau
            // 
            txbmatkhau.Location = new Point(20, 171);
            txbmatkhau.Margin = new Padding(4, 3, 4, 3);
            txbmatkhau.Name = "txbmatkhau";
            txbmatkhau.Size = new Size(266, 23);
            txbmatkhau.TabIndex = 8;
            // 
            // btdangnhap
            // 
            btdangnhap.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btdangnhap.Location = new Point(87, 278);
            btdangnhap.Margin = new Padding(4, 3, 4, 3);
            btdangnhap.Name = "btdangnhap";
            btdangnhap.Size = new Size(138, 38);
            btdangnhap.TabIndex = 9;
            btdangnhap.Text = "Đăng nhập";
            btdangnhap.UseVisualStyleBackColor = true;
            btdangnhap.Click += btdangnhap_Click;
            // 
            // btquenmatkhau
            // 
            btquenmatkhau.BackColor = Color.FromArgb(0, 0, 0, 0);
            btquenmatkhau.FlatAppearance.BorderColor = SystemColors.Control;
            btquenmatkhau.FlatAppearance.BorderSize = 0;
            btquenmatkhau.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btquenmatkhau.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btquenmatkhau.FlatStyle = FlatStyle.Flat;
            btquenmatkhau.Font = new Font("Times New Roman", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btquenmatkhau.ForeColor = SystemColors.ActiveCaptionText;
            btquenmatkhau.Location = new Point(88, 239);
            btquenmatkhau.Margin = new Padding(4, 3, 4, 3);
            btquenmatkhau.Name = "btquenmatkhau";
            btquenmatkhau.Size = new Size(135, 32);
            btquenmatkhau.TabIndex = 10;
            btquenmatkhau.Text = "Quên mật khẩu";
            btquenmatkhau.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
            panel1.Controls.Add(btDangKy);
            panel1.Controls.Add(btquenmatkhau);
            panel1.Controls.Add(btdangnhap);
            panel1.Controls.Add(txbmatkhau);
            panel1.Controls.Add(txbtendangnhap);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(376, 99);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 366);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btDangKy
            // 
            btDangKy.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDangKy.Location = new Point(87, 322);
            btDangKy.Margin = new Padding(4, 3, 4, 3);
            btDangKy.Name = "btDangKy";
            btDangKy.Size = new Size(138, 38);
            btDangKy.TabIndex = 11;
            btDangKy.Text = "Đăng ký";
            btDangKy.UseVisualStyleBackColor = true;
            btDangKy.Click += btDangKy_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1050, 614);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DangNhap";
            Text = "DangNhap";
            Load += DangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbtendangnhap;
        private System.Windows.Forms.TextBox txbmatkhau;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.Button btquenmatkhau;
        private System.Windows.Forms.Panel panel1;
        private Button btDangKy;
    }
}