using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DoAnNhom3.Model;
using DoAnNhom3.QuanLy;

namespace DoAnNhom3
{
    public partial class ucDonHang : UserControl
    {
        private KhachHangDangNhap parentForm;
        private List<MonAn> gioHang = new List<MonAn>();

        /*public ucDonHang(MonAn monAnDuocChon)
        {
            InitializeComponent();
            this.Load += ucDonHang_Load;
            if (monAnDuocChon != null)
            {
                var item = new themdonhang();
                item.SetData(monAnDuocChon.TenMon, monAnDuocChon.GiaTien, monAnDuocChon.HinhAnh);
                flpgiohang.Controls.Add(item);
            }

        }*/

        public ucDonHang()
        {
            InitializeComponent();
            
        }

        /*private void HienThiGioHang()
        {
            flpgiohang.Controls.Clear();
            foreach (var mon in gioHang)
            {
                Panel panel = new Panel { Width = 400, Height = 40 };

                Label lbl = new Label
                {
                    Text = $"{mon.TenMon} - {mon.GiaTien:N0} đ",
                    Width = 200,
                    Location = new Point(5, 10)
                };

                NumericUpDown numSL = new NumericUpDown
                {
                    Minimum = 1,
                    Value = 1,
                    Width = 60,
                    Location = new Point(220, 7),
                    Tag = mon
                };

                panel.Controls.Add(lbl);
                panel.Controls.Add(numSL);
                flpgiohang.Controls.Add(panel);
            }
        }*/

        /*private void btthanhtoanKH_Click(object sender, EventArgs e)
        {
            decimal tongTien = 0;

            foreach (Control item in flpgiohang.Controls)
            {
                if (item is Panel panel)
                {
                    foreach (Control ctrl in panel.Controls)
                    {
                        if (ctrl is NumericUpDown num && num.Tag is MonAn mon)
                        {
                            tongTien += mon.GiaTien * num.Value;
                        }
                    }
                }
            }

            MessageBox.Show($"Tổng tiền thanh toán: {tongTien:N0} đ", "Thông báo");
        }*/
        public ucDonHang(List<MonAn> ds, KhachHangDangNhap cha)
        {
            InitializeComponent();
            parentForm = cha;
            flpgiohang.Controls.Clear();
            foreach (var mon in ds)
            {
                var item = new themdonhang();
                item.SetData(mon.TenMon, mon.GiaTien, mon.HinhAnh, mon.SoLuong);
                flpgiohang.Controls.Add(item);
            }
        }
        public ucDonHang(List<MonAn> ds)
        {
            InitializeComponent();
            flpgiohang.Controls.Clear();
            foreach (var mon in ds)
            {
                var itemUc = new themdonhang();
                itemUc.SetData(mon.TenMon, mon.GiaTien, mon.HinhAnh, mon.SoLuong);
                flpgiohang.Controls.Add(itemUc);
            }
        }
        private void ucDonHang_Load(object sender, EventArgs e)
        {
            flpgiohang.Controls.Clear();
            foreach (var mon in GioHangService.DanhSachMon)
            {
                var itemUc = new themdonhang();
                itemUc.SetData(mon.TenMon, mon.GiaTien, mon.HinhAnh, mon.SoLuong);
                flpgiohang.Controls.Add(itemUc);
            }
        }
        private void btquaylai_Click(object sender, EventArgs e)
        {
            parentForm.panelkhachhang.Controls.Clear();
            parentForm.LoadMenu();
        }

        private void btthanhtoanKH_Click_1(object sender, EventArgs e)
        {

        }
    }

}
