namespace DoAnNhom3
{
    partial class Menu
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
            btqlnhanvien = new Button();
            btbaocao = new Button();
            btkhonguyenlieu = new Button();
            btqldanhmuc = new Button();
            btqlkhachhang = new Button();
            panel1 = new Panel();
            button2 = new Button();
            panelMain = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btqlnhanvien
            // 
            btqlnhanvien.BackColor = SystemColors.Highlight;
            btqlnhanvien.FlatAppearance.BorderSize = 0;
            btqlnhanvien.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btqlnhanvien.ForeColor = SystemColors.HighlightText;
            btqlnhanvien.Location = new Point(0, 69);
            btqlnhanvien.Margin = new Padding(4, 3, 4, 3);
            btqlnhanvien.Name = "btqlnhanvien";
            btqlnhanvien.Size = new Size(204, 73);
            btqlnhanvien.TabIndex = 0;
            btqlnhanvien.Text = "Quản lí nhân viên";
            btqlnhanvien.UseVisualStyleBackColor = false;
            //btqlnhanvien.Click += btqlnhanvien_Click;
            // 
            // btbaocao
            // 
            btbaocao.BackColor = SystemColors.Highlight;
            btbaocao.FlatAppearance.BorderSize = 0;
            btbaocao.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btbaocao.ForeColor = SystemColors.ButtonHighlight;
            btbaocao.Location = new Point(0, 340);
            btbaocao.Location = new Point(13, 248);
            btbaocao.Margin = new Padding(4, 3, 4, 3);
            btbaocao.Name = "btbaocao";
            btbaocao.Size = new Size(204, 63);
            btbaocao.TabIndex = 1;
            btbaocao.Text = "Báo cáo thống kê";
            btbaocao.UseVisualStyleBackColor = false;
            btbaocao.Click += btbaocao_Click;
            // 
            // btkhuyenmai
            // 
           /* btkhuyenmai.BackColor = SystemColors.Highlight;
            btkhuyenmai.FlatAppearance.BorderSize = 0;
            btkhuyenmai.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btkhuyenmai.ForeColor = SystemColors.ButtonHighlight;
            btkhuyenmai.Location = new Point(0, 201);
            btkhuyenmai.Margin = new Padding(4, 3, 4, 3);
            btkhuyenmai.Name = "btkhuyenmai";
            btkhuyenmai.Size = new Size(204, 76);
            btkhuyenmai.TabIndex = 2;
            btkhuyenmai.Text = "Khuyến mãi";
            btkhuyenmai.UseVisualStyleBackColor = false;*/
            // 
            // btkhonguyenlieu
            // 
            btkhonguyenlieu.BackColor = SystemColors.Highlight;
            btkhonguyenlieu.FlatAppearance.BorderSize = 0;
            btkhonguyenlieu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btkhonguyenlieu.ForeColor = SystemColors.ButtonHighlight;
            btkhonguyenlieu.Location = new Point(0, 272);
            btkhonguyenlieu.Location = new Point(13, 190);
            btkhonguyenlieu.Margin = new Padding(4, 3, 4, 3);
            btkhonguyenlieu.Name = "btkhonguyenlieu";
            btkhonguyenlieu.Size = new Size(204, 74);
            btkhonguyenlieu.TabIndex = 3;
            btkhonguyenlieu.Text = "Kho nguyên liệu";
            btkhonguyenlieu.UseVisualStyleBackColor = false;
            btkhonguyenlieu.Click += btkhonguyenlieu_Click;
            // 
            // btqldanhmuc
            // 
            btqldanhmuc.BackColor = SystemColors.Highlight;
            btqldanhmuc.FlatAppearance.BorderColor = SystemColors.Highlight;
            btqldanhmuc.FlatAppearance.BorderSize = 0;
            btqldanhmuc.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btqldanhmuc.ForeColor = Color.White;
            btqldanhmuc.Location = new Point(0, 0);
            btqldanhmuc.Margin = new Padding(4, 3, 4, 3);
            btqldanhmuc.Name = "btqldanhmuc";
            btqldanhmuc.Size = new Size(204, 70);
            btqldanhmuc.TabIndex = 4;
            btqldanhmuc.Text = "Quản lí menu";
            btqldanhmuc.UseVisualStyleBackColor = false;
            btqldanhmuc.Click += btqldanhmuc_Click;
            // 
            // btqlkhachhang
            // 
            btqlkhachhang.BackColor = SystemColors.Highlight;
            btqlkhachhang.FlatAppearance.BorderSize = 0;
            btqlkhachhang.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btqlkhachhang.ForeColor = SystemColors.HighlightText;
            btqlkhachhang.Location = new Point(0, 138);
            btqlkhachhang.Margin = new Padding(4, 3, 4, 3);
            btqlkhachhang.Name = "btqlkhachhang";
            btqlkhachhang.Size = new Size(204, 69);
            btqlkhachhang.TabIndex = 5;
            btqlkhachhang.Text = "Quản lí khách hàng";
            btqlkhachhang.UseVisualStyleBackColor = false;
            btqlkhachhang.Click += btqlkhachhang_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btqlnhanvien);
            panel1.Controls.Add(btqlkhachhang);
            panel1.Controls.Add(btqldanhmuc);
            panel1.Controls.Add(btbaocao);
            panel1.Controls.Add(btkhonguyenlieu);
            panel1.Location = new Point(2, 157);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 461);
            panel1.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Highlight;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(0, 399);
            button2.Location = new Point(13, 381);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(204, 62);
            button2.TabIndex = 7;
            button2.Text = "Đăng Xuất";
            button2.UseVisualStyleBackColor = false;
            //button2.Click += button2_Click;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Right;
            panelMain.Location = new Point(208, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(847, 618);
            panelMain.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.logo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(2, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 154);
            panel2.TabIndex = 8;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 618);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panelMain);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btqlnhanvien;
        private System.Windows.Forms.Button btbaocao;
        private System.Windows.Forms.Button btkhonguyenlieu;
        private System.Windows.Forms.Button btqldanhmuc;
        private System.Windows.Forms.Button btqlkhachhang;
        private System.Windows.Forms.Panel panel1;
        public Panel panelMain;
        private Button button2;
        private Panel panel2;
    }
}