namespace DoAnNhom3
{
    partial class ucDonHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btthemvaogiohang = new Button();
            btthanhtoanKH = new Button();
            panel1 = new Panel();
            flpgiohang = new FlowLayoutPanel();
            btQuayVe = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 45;
            // 
            // btthemvaogiohang
            // 
            btthemvaogiohang.BackColor = Color.MediumTurquoise;
            btthemvaogiohang.FlatAppearance.BorderSize = 0;
            btthemvaogiohang.FlatStyle = FlatStyle.Flat;
            btthemvaogiohang.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btthemvaogiohang.Location = new Point(51, 322);
            btthemvaogiohang.Name = "btthemvaogiohang";
            btthemvaogiohang.Size = new Size(96, 56);
            btthemvaogiohang.TabIndex = 34;
            btthemvaogiohang.Text = "Thêm vào giỏ hàng";
            btthemvaogiohang.UseVisualStyleBackColor = false;
            // 
            // btthanhtoanKH
            // 
            btthanhtoanKH.BackColor = Color.MediumTurquoise;
            btthanhtoanKH.FlatAppearance.BorderSize = 0;
            btthanhtoanKH.FlatStyle = FlatStyle.Flat;
            btthanhtoanKH.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btthanhtoanKH.Location = new Point(205, 322);
            btthanhtoanKH.Name = "btthanhtoanKH";
            btthanhtoanKH.Size = new Size(95, 56);
            btthanhtoanKH.TabIndex = 39;
            btthanhtoanKH.Text = "Thanh toán";
            btthanhtoanKH.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(flpgiohang);
            panel1.Controls.Add(btQuayVe);
            panel1.Controls.Add(btthemvaogiohang);
            panel1.Controls.Add(btthanhtoanKH);
            panel1.Location = new Point(291, 79);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 409);
            panel1.TabIndex = 37;
            panel1.Paint += panel1_Paint;
            // 
            // flpgiohang
            // 
            flpgiohang.Anchor = AnchorStyles.None;
            flpgiohang.AutoScroll = true;
            flpgiohang.BackColor = SystemColors.ButtonHighlight;
            flpgiohang.FlowDirection = FlowDirection.TopDown;
            flpgiohang.Location = new Point(0, 0);
            flpgiohang.Name = "flpgiohang";
            flpgiohang.Size = new Size(479, 289);
            flpgiohang.TabIndex = 45;
            flpgiohang.WrapContents = false;
            // 
            // btQuayVe
            // 
            btQuayVe.BackColor = Color.MediumTurquoise;
            btQuayVe.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btQuayVe.Location = new Point(353, 322);
            btQuayVe.Name = "btQuayVe";
            btQuayVe.Size = new Size(83, 56);
            btQuayVe.TabIndex = 44;
            btQuayVe.Text = "Menu";
            btQuayVe.UseVisualStyleBackColor = false;
            // 
            // ucDonHang
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "ucDonHang";
            Size = new Size(1081, 618);
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button btthemvaogiohang;
        private Button btthanhtoanKH;
        private Panel panel1;
        private Button btQuayVe;
        private FlowLayoutPanel flpgiohang;
    }
}
