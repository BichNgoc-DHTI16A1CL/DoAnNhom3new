namespace DoAnNhom3
{
    partial class ucMonAn
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
            lbtenmonan = new Label();
            lbgia = new Label();
            btmuangay = new Button();
            pictureBox1 = new PictureBox();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lbtenmonan
            // 
            lbtenmonan.AutoSize = true;
            lbtenmonan.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbtenmonan.Location = new Point(66, 161);
            lbtenmonan.Margin = new Padding(4, 0, 4, 0);
            lbtenmonan.Name = "lbtenmonan";
            lbtenmonan.Size = new Size(45, 19);
            lbtenmonan.TabIndex = 1;
            lbtenmonan.Text = "label1";
            // 
            // lbgia
            // 
            lbgia.AutoSize = true;
            lbgia.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbgia.Location = new Point(66, 182);
            lbgia.Margin = new Padding(4, 0, 4, 0);
            lbgia.Name = "lbgia";
            lbgia.Size = new Size(45, 19);
            lbgia.TabIndex = 2;
            lbgia.Text = "label2";
            // 
            // btmuangay
            // 
            btmuangay.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btmuangay.Location = new Point(6, 233);
            btmuangay.Margin = new Padding(4, 3, 4, 3);
            btmuangay.Name = "btmuangay";
            btmuangay.Size = new Size(166, 36);
            btmuangay.TabIndex = 21;
            btmuangay.Text = "Thêm vào giỏ hàng";
            btmuangay.UseVisualStyleBackColor = true;
            btmuangay.Click += btmuangay_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(8, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(157, 155);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(66, 204);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(61, 23);
            numericUpDown1.TabIndex = 25;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // ucMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            Controls.Add(numericUpDown1);
            Controls.Add(pictureBox1);
            Controls.Add(btmuangay);
            Controls.Add(lbgia);
            Controls.Add(lbtenmonan);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ucMonAn";
            Size = new Size(175, 276);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbtenmonan;
        private System.Windows.Forms.Label lbgia;
        private System.Windows.Forms.Button btmuangay;
        private PictureBox pictureBox1;
        private NumericUpDown numericUpDown1;
    }
}
