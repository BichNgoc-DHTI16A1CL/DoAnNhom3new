﻿using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNhom3.Model;

namespace DoAnNhom3
{
    public partial class NhanVien : Form
    {
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QuanLyBanHangOnline1;Integrated Security=True;Trust Server Certificate=True";
        private MonAn monAnDangChon;

        private ucDonHang ucDonHangControl;
        private HoaDon hoaDonControl;
        private QuanLiDonHang ucQLDonHangControl;
        private ucBaoCaoThongKe ucBaoCaoControl;

        public NhanVien()
        {
            InitializeComponent();
            this.Load += NhanVien_Load;

            dgvmenuNV.SelectionChanged += dgvmenuNV_SelectionChanged;
            bttaodonhang.Click += bttaodonhang_Click;
            btqldanhmuc.Click += btqldanhmuc_Click;
            btqldonhang.Click += btqldonhang_Click;
            button3.Click += button3_Click;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadMonAn();

            panelMain.Controls.Clear();
            panelSideBar.Dock = DockStyle.Left;
            panelContent.Dock = DockStyle.Fill;

            panelMain.Controls.Add(panelContent);
            panelMain.Controls.Add(panelSideBar);

            ucDonHangControl = new ucDonHang();
            ucDonHangControl.Dock = DockStyle.Fill;

            ucQLDonHangControl = new QuanLiDonHang();
            ucQLDonHangControl.Dock = DockStyle.Fill;

            ucDonHangControl.QuayVeClicked += () =>
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(panelContent);
                panelMain.Controls.Add(panelSideBar);
            };

            ucDonHangControl.ThanhToanClicked += async (dsMon) =>
            {
                hoaDonControl = new HoaDon();
                hoaDonControl.Dock = DockStyle.Fill;

                string sdtKH = "0900000001";
                hoaDonControl.SetData(dsMon, sdtKH);

                hoaDonControl.BatSuKienDatHang(async (s, e) =>
                {
                    await LuuHoaDonAsync(dsMon, sdtKH);
                });

                hoaDonControl.DonHangDatThanhCong += () =>
                {
                    ucQLDonHangControl.Reload();
                    panelMain.Controls.Clear();
                    panelMain.Controls.Add(panelContent);
                    panelMain.Controls.Add(panelSideBar);
                };

                panelMain.Controls.Clear();
                panelMain.Controls.Add(hoaDonControl);
                panelMain.Controls.Add(panelSideBar);
            };
        }

        private void LoadMonAn()
        {
            string query = @"SELECT m.MaMon, m.TenMon, m.GiaTien, d.SoLuong, m.HinhAnh 
                             FROM MonAn m 
                             LEFT JOIN DanhMuc_MonAn d ON m.MaMon = d.MaMon";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    dgvmenuNV.DataSource = table;
                    dgvmenuNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    cbbTenmonmenuNV.Items.Clear();
                    foreach (DataRow row in table.Rows)
                    {
                        string tenMon = row["TenMon"].ToString();
                        if (!cbbTenmonmenuNV.Items.Contains(tenMon))
                            cbbTenmonmenuNV.Items.Add(tenMon);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải món ăn: " + ex.Message);
            }
        }

        private void dgvmenuNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvmenuNV.SelectedRows.Count > 0)
            {
                var row = dgvmenuNV.SelectedRows[0];

                monAnDangChon = new MonAn
                {
                    MaMon = row.Cells["MaMon"].Value.ToString(),
                    TenMon = row.Cells["TenMon"].Value.ToString(),
                    GiaTien = Convert.ToDecimal(row.Cells["GiaTien"].Value),
                    SoLuong = row.Cells["SoLuong"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["SoLuong"].Value) : 1,
                    HinhAnh = row.Cells["HinhAnh"].Value.ToString()
                };

                cbbTenmonmenuNV.Text = monAnDangChon.TenMon;
                txbdongiamenuNV.Text = monAnDangChon.GiaTien.ToString("N0") + " đ";
                txbsoluongmenuNV.Text = monAnDangChon.SoLuong.ToString();
            }
        }

        private void bttaodonhang_Click(object sender, EventArgs e)
        {
            if (monAnDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn trước!");
                return;
            }

            ucDonHangControl.AddItem(monAnDangChon);

            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucDonHangControl);
            panelMain.Controls.Add(panelSideBar);
        }

        private void btqldanhmuc_Click(object sender, EventArgs e)
        {
            LoadMonAn();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(panelContent);
            panelMain.Controls.Add(panelSideBar);
        }

        private void btqldonhang_Click(object sender, EventArgs e)
        {
            if (ucQLDonHangControl == null)
            {
                ucQLDonHangControl = new QuanLiDonHang();
                ucQLDonHangControl.Dock = DockStyle.Fill;
            }

            ucQLDonHangControl.Reload();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucQLDonHangControl);
            panelMain.Controls.Add(panelSideBar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ucBaoCaoControl == null)
            {
                ucBaoCaoControl = new ucBaoCaoThongKe();
                ucBaoCaoControl.Dock = DockStyle.Fill;

                ucBaoCaoControl.QuayVeClicked += () =>
                {
                    panelMain.Controls.Clear();
                    panelMain.Controls.Add(panelContent);
                    panelMain.Controls.Add(panelSideBar);
                };
            }

            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucBaoCaoControl);
            panelMain.Controls.Add(panelSideBar);
        }

        // ✅ Hàm lưu hóa đơn + gọi thêm Báo cáo ngày
        private async Task LuuHoaDonAsync(List<MonAn> danhSachMon, string sdtKhach)
        {
            string maHD = "HD" + DateTime.Now.Ticks.ToString().Substring(10);

            string query1 = "INSERT INTO HoaDon (MaHoaDon, NgayLap, SoDienThoaiKH, MaNhanVien) VALUES (@MaHoaDon, @NgayLap, @SoDT, @MaNV)";
            string query2 = "INSERT INTO ChiTietHoaDon (MaHoaDon, MaMon, DonGia, SoLuong, ThanhTien) VALUES (@MaHoaDon, @MaMon, @DonGia, @SoLuong, @ThanhTien)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    // Lưu hóa đơn
                    SqlCommand cmd1 = new SqlCommand(query1, conn, tran);
                    cmd1.Parameters.AddWithValue("@MaHoaDon", maHD);
                    cmd1.Parameters.AddWithValue("@NgayLap", DateTime.Now);
                    cmd1.Parameters.AddWithValue("@SoDT", sdtKhach);
                    cmd1.Parameters.AddWithValue("@MaNV", "NV01");
                    await cmd1.ExecuteNonQueryAsync();

                    // Lưu chi tiết hóa đơn
                    foreach (var mon in danhSachMon)
                    {
                        SqlCommand cmd2 = new SqlCommand(query2, conn, tran);
                        cmd2.Parameters.AddWithValue("@MaHoaDon", maHD);
                        cmd2.Parameters.AddWithValue("@MaMon", mon.MaMon);
                        cmd2.Parameters.AddWithValue("@DonGia", mon.GiaTien);
                        cmd2.Parameters.AddWithValue("@SoLuong", mon.SoLuong);
                        cmd2.Parameters.AddWithValue("@ThanhTien", mon.GiaTien * mon.SoLuong);
                        await cmd2.ExecuteNonQueryAsync();
                    }

                    // Commit trước khi thêm báo cáo để tránh deadlock
                    tran.Commit();
                    MessageBox.Show("Đặt hàng thành công!");

                    // Gọi hàm thêm báo cáo ngày
                    await ThemBaoCaoNgayAsync(danhSachMon, DateTime.Now);

                    // Gọi event hoàn tất
                    hoaDonControl?.GoiSuKienDatHangThanhCong();
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi lưu hóa đơn: " + ex.Message);
                }
            }
        }


        private async Task ThemBaoCaoNgayAsync(List<MonAn> danhSachMon, DateTime ngay)
        {
            string query = @"
        INSERT INTO BaoCaoNgay (MaBaoCaoNgay, Ngay, MaMon, DonViTinh, SoLuong, DoanhThuNgay)
        VALUES (@MaBaoCaoNgay, @Ngay, @MaMon, @DonViTinh, @SoLuong, @DoanhThuNgay)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();

                foreach (var mon in danhSachMon)
                {
                    string maBaoCao = "BCN" + DateTime.Now.Ticks.ToString().Substring(10);

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@MaBaoCaoNgay", maBaoCao);
                        cmd.Parameters.AddWithValue("@Ngay", ngay.Date);
                        cmd.Parameters.AddWithValue("@MaMon", mon.MaMon);
                        cmd.Parameters.AddWithValue("@DonViTinh", "Phần"); // hoặc lấy từ DB nếu có
                        cmd.Parameters.AddWithValue("@SoLuong", mon.SoLuong);
                        cmd.Parameters.AddWithValue("@DoanhThuNgay", mon.SoLuong * mon.GiaTien);

                        await cmd.ExecuteNonQueryAsync();
                    }
                }
            }
        }

        private void cbbTenmonmenuNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap DN = new DangNhap();
            DN.Show();
        }
    }
}

