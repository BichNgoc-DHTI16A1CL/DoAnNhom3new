namespace DoAnNhom3
{
    partial class themdonhang
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
            ptbanhmonan = new PictureBox();
            txbtenmonan = new TextBox();
            txbdongia = new TextBox();
            txbslg = new TextBox();
            ((System.ComponentModel.ISupportInitialize)ptbanhmonan).BeginInit();
            SuspendLayout();
            // 
            // ptbanhmonan
            // 
            ptbanhmonan.Location = new Point(0, 1);
            ptbanhmonan.Margin = new Padding(4, 3, 4, 3);
            ptbanhmonan.Name = "ptbanhmonan";
            ptbanhmonan.Size = new Size(144, 97);
            ptbanhmonan.TabIndex = 0;
            ptbanhmonan.TabStop = false;
            // 
            // txbtenmonan
            // 
            txbtenmonan.Location = new Point(161, 8);
            txbtenmonan.Margin = new Padding(4, 3, 4, 3);
            txbtenmonan.Name = "txbtenmonan";
            txbtenmonan.Size = new Size(144, 23);
            txbtenmonan.TabIndex = 1;
            // 
            // txbdongia
            // 
            txbdongia.Location = new Point(161, 37);
            txbdongia.Margin = new Padding(4, 3, 4, 3);
            txbdongia.Name = "txbdongia";
            txbdongia.Size = new Size(144, 23);
            txbdongia.TabIndex = 2;
            // 
            // txbslg
            // 
            txbslg.Location = new Point(161, 66);
            txbslg.Margin = new Padding(4, 3, 4, 3);
            txbslg.Name = "txbslg";
            txbslg.Size = new Size(90, 23);
            txbslg.TabIndex = 3;
            // 
            // themdonhang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txbslg);
            Controls.Add(txbdongia);
            Controls.Add(txbtenmonan);
            Controls.Add(ptbanhmonan);
            Margin = new Padding(4, 3, 4, 3);
            Name = "themdonhang";
            Size = new Size(376, 99);
            Load += themdonhang_Load_1;
            ((System.ComponentModel.ISupportInitialize)ptbanhmonan).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbanhmonan;
        private System.Windows.Forms.TextBox txbtenmonan;
        private System.Windows.Forms.TextBox txbdongia;
        private TextBox txbslg;
    }
}
