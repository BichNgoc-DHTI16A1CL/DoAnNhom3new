using DoAnNhom3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNhom3.QuanLy;
namespace DoAnNhom3
{
    public partial class KhachHangDangNhap : Form
    {
        private ucMenuMonAn ucMenu;
        private uctaoDH ucDon;
        public KhachHangDangNhap()
        {
            InitializeComponent();
            ucMenu = new ucMenuMonAn();
            ucDon = new uctaoDH();

            ucMenu.Dock = DockStyle.Fill;
            ucDon.Dock = DockStyle.Fill;


            panelkhachhang.Controls.Add(ucMenu);
            panelkhachhang.Controls.Add(ucDon);

            ucMenu.Show();
            ucDon.Hide();
        }

        private void baoCaoThongKe1_Load(object sender, EventArgs e)
        {
           
        }

        private void KhachHangDangNhap_Load(object sender, EventArgs e)
        {
            ucDon = new uctaoDH();
            ucDon.Visible = false;
            ucDon.Dock = DockStyle.Fill;
            panelkhachhang.Controls.Add(ucDon);

            LoadMenu(); // Hiển thị danh sách món ăn
        }
        public void LoadMenu()
        {
            flowLayoutPanel1.Controls.Clear();
            string sql = "SELECT TenMon, GiaTien, HinhAnh FROM MonAn";
            DataTable dt = Database.GetData(sql);

            foreach (DataRow row in dt.Rows)
            {
                string ten = row["TenMon"].ToString();
                decimal gia = Convert.ToDecimal(row["GiaTien"]);
                string hinh = row["HinhAnh"].ToString();

                ucMonAn mon = new ucMonAn();
                mon.SetData(ten, gia, hinh);

                mon.MuaNgayClicked += (s, ev) =>
                {
                    // 1. Tạo món ăn từ dữ liệu được click
                    MonAn monDuocChon = new MonAn
                    {
                        TenMon = ev.TenMon,
                        GiaTien = ev.GiaTien,
                        HinhAnh = ev.HinhAnh,
                        SoLuong = 1
                    };

                    // 2. Tạo uctaoDH
                    uctaoDH ucdonhang = new uctaoDH();
                    ucdonhang.Dock = DockStyle.Fill;

                    // 3. Gọi hàm hiển thị món ăn lên flpGioHang
                    ucdonhang.HienThiMonAn(monDuocChon);

                    // 4. Hiển thị uctaoDH và ẩn flowLayoutPanel1
                    flowLayoutPanel1.Hide();
                    panelkhachhang.Controls.Add(ucdonhang);
                    ucdonhang.BringToFront();
                };

                mon.ThemVaoGioHang += (s, ev) =>
                {
                    // Thêm món vào giỏ
                    GioHangService.DanhSachMon.Add(new MonAn
                    {
                        TenMon = ev.TenMon,
                        GiaTien = ev.GiaTien,
                        HinhAnh = ev.HinhAnh,
                        SoLuong = 1
                    });

                    // Hiển thị giỏ hàng
                    ucDon.HienThiGioHang();

                    // Chuyển view
                    ucMenu.Hide();
                    ucDon.Show();
                    // Chuyển sang ucDonHang
                    ucDonHang donHang = new ucDonHang();
                    panelkhachhang.Controls.Clear();
                    panelkhachhang.Controls.Add(donHang);
                };

                flowLayoutPanel1.Controls.Add(mon);
            }

        }
       
    }
}
