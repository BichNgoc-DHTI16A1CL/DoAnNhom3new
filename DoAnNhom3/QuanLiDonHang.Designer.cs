namespace DoAnNhom3
{
    partial class QuanLiDonHang
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
            button4 = new Button();
            dgvDonHang = new DataGridView();
            btnTaiLai = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(436, 64);
            button4.Margin = new Padding(4, 3, 4, 3);
            button4.Name = "button4";
            button4.Size = new Size(261, 44);
            button4.TabIndex = 8;
            button4.Text = "Danh sách đơn hàng";
            button4.UseVisualStyleBackColor = true;
            // 
            // dgvDonHang
            // 
            dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonHang.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonHang.Location = new Point(166, 137);
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.Size = new Size(789, 277);
            dgvDonHang.TabIndex = 9;
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackColor = Color.MediumTurquoise;
            btnTaiLai.FlatAppearance.BorderSize = 0;
            btnTaiLai.FlatStyle = FlatStyle.Flat;
            btnTaiLai.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTaiLai.Location = new Point(533, 449);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(102, 43);
            btnTaiLai.TabIndex = 10;
            btnTaiLai.Text = "Update";
            btnTaiLai.UseVisualStyleBackColor = false;
            // 
            // QuanLiDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnTaiLai);
            Controls.Add(dgvDonHang);
            Controls.Add(button4);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QuanLiDonHang";
            Size = new Size(1081, 618);
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private DataGridView dgvDonHang;
        private Button btnTaiLai;
    }
}
