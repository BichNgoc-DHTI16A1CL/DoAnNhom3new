using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DoAnNhom3.Model;
using Microsoft.Identity.Client.NativeInterop;

namespace DoAnNhom3
{
    public partial class ucMonAn : UserControl
    {
        private string tenMon;
        private decimal giaTien;
        private string tenFileAnh;
        public MonAn MonAn { get; set; }
        public ucMonAn()
        {
            InitializeComponent();
            
        }
        
        private void ucMonAn_Load(object sender, EventArgs e)
        {
            if (MonAn != null)
            {
                lbtenmonan.Text = MonAn.TenMon;
                lbgia.Text = MonAn.GiaTien.ToString("N0") + " đ";

                string path = Path.Combine(Application.StartupPath, "HinhAnh", MonAn.HinhAnh);
                if (File.Exists(path))
                    ptbanhmonan.Image = Image.FromFile(path);
                else
                    ptbanhmonan.Image = null;
            }
        }
        public string GetTenMon()
        {
            return lbtenmonan.Text;
        }

        public decimal GetGiaTien()
        {
            if (decimal.TryParse(lbgia.Text.Replace(" đ", "").Replace(",", ""), out decimal gia))
                return gia;
            return 0;
        }

        public void SetData(string tenMon, decimal gia, string fileAnh)
        {
            this.tenMon= tenMon;
            this.giaTien = gia;
            this.tenFileAnh = fileAnh;
            lbtenmonan.Text = tenMon;
            lbgia.Text = gia.ToString("N0") + " đ";

            string duongDan = Path.Combine(Application.StartupPath, "HinhAnh", fileAnh);
            if (File.Exists(duongDan))
            {
                ptbanhmonan.Image = Image.FromFile(duongDan);
                ptbanhmonan.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                ptbanhmonan.Image = null;
            }
        }
        /*private void ucMonAn_Load(object sender, EventArgs e)
        {

        }*/
        public event EventHandler<MonAnEventArgs> MuaNgayClicked;

        public event EventHandler<MonAnEventArgs> ThemVaoGioHang;
        private void btgiohang_Click(object sender, EventArgs e)
        {

            ThemVaoGioHang?.Invoke(this, new MonAnEventArgs
            {
                TenMon = this.GetTenMon(),
                GiaTien = this.GetGiaTien(),
                HinhAnh = this.tenFileAnh
            });

        }

        private void btmuangay_Click_1(object sender, EventArgs e)
        {
            var args = new MonAnEventArgs
            {
                TenMon = tenMon,
                GiaTien = giaTien,
                HinhAnh = tenFileAnh
            };
            MuaNgayClicked?.Invoke(this, args);
        }
    }
}
