namespace DoAnNhom3
{
    partial class ucXemLSDonHang
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
            dgvLichSu = new DataGridView();
            lblTongTien = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(341, 72);
            label1.Name = "label1";
            label1.Size = new Size(116, 15);
            label1.TabIndex = 0;
            label1.Text = "Danh sách đơn hàng";
            // 
            // dgvLichSu
            // 
            dgvLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSu.Location = new Point(80, 135);
            dgvLichSu.Name = "dgvLichSu";
            dgvLichSu.Size = new Size(624, 272);
            dgvLichSu.TabIndex = 1;
            dgvLichSu.CellContentClick += dgvDonHang_CellContentClick;
            // 
            // lblTongTien
            // 
            lblTongTien.AutoSize = true;
            lblTongTien.Location = new Point(309, 439);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(38, 15);
            lblTongTien.TabIndex = 2;
            lblTongTien.Text = "label2";
            // 
            // ucXemDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTongTien);
            Controls.Add(dgvLichSu);
            Controls.Add(label1);
            Name = "ucXemDonHang";
            Size = new Size(770, 548);
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvLichSu;
        private Label lblTongTien;
    }
}
