using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNhom3.Model;
using System.IO;

namespace DoAnNhom3
{
    public partial class themdonhang : UserControl
    {
        public themdonhang()
        {
            InitializeComponent();
        }

        private void themdonhang_Load(object sender, EventArgs e)
        {

        }

        private void themdonhang_Load_1(object sender, EventArgs e)
        {

        }
        public void SetData(string tenMonAn, decimal donGia, string tenHinhAnh, int soLuong)
        {
            txbtenmonan.Text = tenMonAn;
            txbdongia.Text = donGia.ToString("N0") + " đ";
            txbslg.Text = soLuong.ToString();
            string path = Path.Combine(Application.StartupPath, "HinhAnh", tenHinhAnh);
            if (File.Exists(path))
                ptbanhmonan.Image = Image.FromFile(path);
            else
                ptbanhmonan.Image = null;
        }
    }
}
