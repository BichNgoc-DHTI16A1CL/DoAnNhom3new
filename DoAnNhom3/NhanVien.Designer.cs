
namespace DoAnNhom3
{
    partial class NhanVien
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
            button3 = new Button();
            bttaodonhang = new Button();
            btqldonhang = new Button();
            btqldanhmuc = new Button();
            panelMain = new Panel();
            panelMainContent = new Panel();
            panelContent = new Panel();
            button4 = new Button();
            dgvmenuNV = new DataGridView();
            label2 = new Label();
            cbbTenmonmenuNV = new ComboBox();
            txbsoluongmenuNV = new TextBox();
            txbdongiamenuNV = new TextBox();
            label4 = new Label();
            label1 = new Label();
            panelSideBar = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panelMain.SuspendLayout();
            panelMainContent.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmenuNV).BeginInit();
            panelSideBar.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = SystemColors.Highlight;
            button3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(0, 436);
            button3.Margin = new Padding(4, 3, 4, 3);
            button3.Name = "button3";
            button3.Size = new Size(206, 102);
            button3.TabIndex = 8;
            button3.Text = "Thống kê";
            button3.UseVisualStyleBackColor = false;
            // 
            // bttaodonhang
            // 
            bttaodonhang.Anchor = AnchorStyles.None;
            bttaodonhang.BackColor = SystemColors.Highlight;
            bttaodonhang.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bttaodonhang.Location = new Point(0, 346);
            bttaodonhang.Margin = new Padding(4, 3, 4, 3);
            bttaodonhang.Name = "bttaodonhang";
            bttaodonhang.Size = new Size(206, 97);
            bttaodonhang.TabIndex = 25;
            bttaodonhang.Text = "Tạo đơn hàng";
            bttaodonhang.UseVisualStyleBackColor = false;
            // 
            // btqldonhang
            // 
            btqldonhang.Anchor = AnchorStyles.None;
            btqldonhang.BackColor = SystemColors.Highlight;
            btqldonhang.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btqldonhang.ForeColor = Color.Black;
            btqldonhang.Location = new Point(0, 256);
            btqldonhang.Margin = new Padding(4, 3, 4, 3);
            btqldonhang.Name = "btqldonhang";
            btqldonhang.Size = new Size(206, 97);
            btqldonhang.TabIndex = 7;
            btqldonhang.Text = "Quản lí đơn hàng";
            btqldonhang.UseVisualStyleBackColor = false;
            // 
            // btqldanhmuc
            // 
            btqldanhmuc.Anchor = AnchorStyles.None;
            btqldanhmuc.BackColor = SystemColors.Highlight;
            btqldanhmuc.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btqldanhmuc.ForeColor = Color.Black;
            btqldanhmuc.Location = new Point(0, 162);
            btqldanhmuc.Margin = new Padding(4, 3, 4, 3);
            btqldanhmuc.Name = "btqldanhmuc";
            btqldanhmuc.Size = new Size(206, 97);
            btqldanhmuc.TabIndex = 5;
            btqldanhmuc.Text = "Quản lí menu";
            btqldanhmuc.UseVisualStyleBackColor = false;
            btqldanhmuc.Click += btqldanhmuc_Click;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelMainContent);
            panelMain.Controls.Add(panelSideBar);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1370, 670);
            panelMain.TabIndex = 26;
            // 
            // panelMainContent
            // 
            panelMainContent.Controls.Add(panelContent);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(208, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(1162, 670);
            panelMainContent.TabIndex = 29;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(button4);
            panelContent.Controls.Add(dgvmenuNV);
            panelContent.Controls.Add(label2);
            panelContent.Controls.Add(cbbTenmonmenuNV);
            panelContent.Controls.Add(txbsoluongmenuNV);
            panelContent.Controls.Add(txbdongiamenuNV);
            panelContent.Controls.Add(label4);
            panelContent.Controls.Add(label1);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1162, 670);
            panelContent.TabIndex = 27;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(535, 35);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(148, 44);
            button4.TabIndex = 7;
            button4.Text = "MENU";
            button4.UseVisualStyleBackColor = true;
            // 
            // dgvmenuNV
            // 
            dgvmenuNV.Anchor = AnchorStyles.None;
            dgvmenuNV.BackgroundColor = SystemColors.ButtonHighlight;
            dgvmenuNV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvmenuNV.Location = new Point(283, 107);
            dgvmenuNV.Margin = new Padding(4, 3, 4, 3);
            dgvmenuNV.Name = "dgvmenuNV";
            dgvmenuNV.Size = new Size(610, 174);
            dgvmenuNV.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(403, 304);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 14;
            label2.Text = "Tên món ăn";
            // 
            // cbbTenmonmenuNV
            // 
            cbbTenmonmenuNV.FormattingEnabled = true;
            cbbTenmonmenuNV.Items.AddRange(new object[] { "Gà rán nguyên con", "Khoai tây chiên", "Nước ép dưa hấu", "Nước ép dưa chuột" });
            cbbTenmonmenuNV.Location = new Point(412, 328);
            cbbTenmonmenuNV.Margin = new Padding(4, 3, 4, 3);
            cbbTenmonmenuNV.Name = "cbbTenmonmenuNV";
            cbbTenmonmenuNV.Size = new Size(215, 23);
            cbbTenmonmenuNV.TabIndex = 22;
            cbbTenmonmenuNV.SelectedIndexChanged += cbbTenmonmenuNV_SelectedIndexChanged;
            // 
            // txbsoluongmenuNV
            // 
            txbsoluongmenuNV.Location = new Point(412, 409);
            txbsoluongmenuNV.Margin = new Padding(4, 3, 4, 3);
            txbsoluongmenuNV.Name = "txbsoluongmenuNV";
            txbsoluongmenuNV.Size = new Size(224, 23);
            txbsoluongmenuNV.TabIndex = 19;
            //txbsoluongmenuNV.TextChanged += this.txbsoluongmenuNV_TextChanged;
            // 
            // txbdongiamenuNV
            // 
            txbdongiamenuNV.Location = new Point(412, 495);
            txbdongiamenuNV.Margin = new Padding(4, 3, 4, 3);
            txbdongiamenuNV.Name = "txbdongiamenuNV";
            txbdongiamenuNV.Size = new Size(224, 23);
            txbdongiamenuNV.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(412, 385);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 18;
            label4.Text = "Số lượng";
            //label4.Click += this.label4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(412, 471);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 23;
            label1.Text = "Đơn giá";
            // 
            // panelSideBar
            // 
            panelSideBar.Controls.Add(panel1);
            panelSideBar.Controls.Add(bttaodonhang);
            panelSideBar.Controls.Add(btqldanhmuc);
            panelSideBar.Controls.Add(button3);
            panelSideBar.Controls.Add(btqldonhang);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(208, 670);
            panelSideBar.TabIndex = 28;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 154);
            panel1.TabIndex = 26;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.logo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(0, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 154);
            panel2.TabIndex = 9;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 670);
            Controls.Add(panelMain);
            Margin = new Padding(4, 3, 4, 3);
            Name = "NhanVien";
            Text = "NhanVien";
            panelMain.ResumeLayout(false);
            panelMainContent.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmenuNV).EndInit();
            panelSideBar.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btqldonhang;
        private System.Windows.Forms.Button btqldanhmuc;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bttaodonhang;
        private PaintEventHandler panel2_Paint;
        public Panel panelMain;
        public Panel panelSideBar;
        public Panel panelContent;
        private Button button4;
        private DataGridView dgvmenuNV;
        private Label label2;
        private ComboBox cbbTenmonmenuNV;
        private TextBox txbsoluongmenuNV;
        private TextBox txbdongiamenuNV;
        private Label label4;
        private Label label1;
        private Panel panelMainContent;
        private Panel panel1;
        private Panel panel2;
    }
}