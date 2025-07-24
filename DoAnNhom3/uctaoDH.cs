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

namespace DoAnNhom3
{
    public partial class uctaoDH : UserControl
    {
        public uctaoDH()
        {
            InitializeComponent();
        }

        private void labelgiohang_Click(object sender, EventArgs e)
        {

        }
        public void HienThiMonAn(MonAn mon)
        {
            var item = new themdonhang();
            item.SetData(mon.TenMon, mon.GiaTien, mon.HinhAnh, mon.SoLuong);
            flpGioHang.Controls.Add(item);
        }
        public void LoadGioHang()
        {
            flpGioHang.Controls.Clear();

            foreach (var mon in GioHangService.DanhSachMon)
            {
                themdonhang item = new themdonhang();
                item.SetData(mon.TenMon, mon.GiaTien, mon.HinhAnh, mon.SoLuong);
                flpGioHang.Controls.Add(item);
            }
        }

        private void btthemvaogiohang_Click(object sender, EventArgs e)
        {
            var form = this.FindForm() as KhachHangDangNhap;
            if (form != null)
            {
                this.Visible = false; // Ẩn giỏ hàng
                form.flowLayoutPanel1.Visible = true; // Hiện menu
                //form.label1.Text = "MENU";
            }
        }
        public void HienThiGioHang()
        {
            flpGioHang.Controls.Clear();

            foreach (var mon in GioHangService.DanhSachMon)
            {
                // Tạo 1 UserControl để hiển thị món ăn (giả sử bạn có ucThemDonHang)
                themdonhang item = new themdonhang();
                item.SetData(mon.TenMon, mon.GiaTien, mon.HinhAnh, mon.SoLuong);

                flpGioHang.Controls.Add(item);
            }
        }

        private void btthanhtoanKH_Click(object sender, EventArgs e)
        {

        }
    }
}
