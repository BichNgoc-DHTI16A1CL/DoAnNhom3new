using DoAnNhom3.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhom3
{
    public partial class NhanVien : Form
    {
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QuanLyBanHangOnline1;Integrated Security=True;Trust Server Certificate=True";
        private MonAn monAnDangChon;

        private ucDonHang ucDonHangControl;
        private HoaDon hoaDonControl;
        private QuanLiDonHang ucQLDonHangControl;

        public NhanVien()
        {
            InitializeComponent();
            Load += NhanVien_Load;

            dgvmenuNV.SelectionChanged += dgvmenuNV_SelectionChanged;
            bttaodonhang.Click += bttaodonhang_Click;
            btqldonhang.Click += btqldonhang_Click;
            btDangXuat.Click += btDangXuat_Click;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadMonAn();

            panelMain.Controls.Clear();
            panelMain.Controls.Add(panelContent);
            panelMain.Controls.Add(panelSideBar);

            ucDonHangControl = new ucDonHang();
            ucDonHangControl.Dock = DockStyle.Fill;

            ucDonHangControl.QuayVeClicked += () =>
            {
                panelMain.Controls.Clear();
                panelMain.Controls.Add(panelContent);
                panelMain.Controls.Add(panelSideBar);
            };

            ucDonHangControl.ThanhToanClicked += dsMon =>
            {
                string maHD = "HD" + DateTime.Now.Ticks.ToString().Substring(10);
                string sdtKH = "0900000001";
                string tenKH = "Khách lẻ";
                string diaChiKH = "Không rõ";

                hoaDonControl = new HoaDon();
                hoaDonControl.Dock = DockStyle.Fill;
                hoaDonControl.SetData(dsMon, maHD, DateTime.Now, tenKH, sdtKH, diaChiKH);

                hoaDonControl.DonHangDatThanhCong += async (monList, sdt) =>
                {
                    await LuuHoaDonAsync(monList, sdt);
                    ucQLDonHangControl?.Reload();

                    var inDialog = MessageBox.Show("Bạn có muốn in hóa đơn?", "In hóa đơn", MessageBoxButtons.YesNo);
                    if (inDialog == DialogResult.Yes)
                        hoaDonControl.InHoaDon();

                    panelMain.Controls.Clear();
                    panelMain.Controls.Add(panelContent);
                    panelMain.Controls.Add(panelSideBar);
                };

                hoaDonControl.HuyDonClicked += () =>
                {
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
                    conn.Open();
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvmenuNV.DataSource = dt;
                    dgvmenuNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    cbbTenmonmenuNV.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        string tenMon = row["TenMon"].ToString();
                        if (!cbbTenmonmenuNV.Items.Contains(tenMon))
                            cbbTenmonmenuNV.Items.Add(tenMon);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu món ăn: " + ex.Message);
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
                MessageBox.Show("Vui lòng chọn món ăn!");
                return;
            }

            ucDonHangControl.AddItem(monAnDangChon);

            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucDonHangControl);
            panelMain.Controls.Add(panelSideBar);
        }

        private void btqldonhang_Click(object sender, EventArgs e)
        {
            ucQLDonHangControl ??= new QuanLiDonHang { Dock = DockStyle.Fill };
            ucQLDonHangControl.Reload();

            panelMain.Controls.Clear();
            panelMain.Controls.Add(ucQLDonHangControl);
            panelMain.Controls.Add(panelSideBar);
        }

        private async Task LuuHoaDonAsync(List<MonAn> danhSachMon, string sdtKH)
        {
            string maHD = "HD" + DateTime.Now.Ticks.ToString().Substring(10);
            string insertHD = "INSERT INTO HoaDon (MaHoaDon, NgayLap, SoDienThoaiKH, MaNhanVien) VALUES (@MaHD, @Ngay, @SDT, @MaNV)";
            string insertCT = "INSERT INTO ChiTietHoaDon (MaHoaDon, MaMon, DonGia, SoLuong, ThanhTien) VALUES (@MaHD, @MaMon, @DonGia, @SoLuong, @ThanhTien)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    SqlCommand cmdHD = new SqlCommand(insertHD, conn, tran);
                    cmdHD.Parameters.AddWithValue("@MaHD", maHD);
                    cmdHD.Parameters.AddWithValue("@Ngay", DateTime.Now);
                    cmdHD.Parameters.AddWithValue("@SDT", sdtKH);
                    cmdHD.Parameters.AddWithValue("@MaNV", "NV01");
                    await cmdHD.ExecuteNonQueryAsync();

                    foreach (var mon in danhSachMon)
                    {
                        SqlCommand cmdCT = new SqlCommand(insertCT, conn, tran);
                        cmdCT.Parameters.AddWithValue("@MaHD", maHD);
                        cmdCT.Parameters.AddWithValue("@MaMon", mon.MaMon);
                        cmdCT.Parameters.AddWithValue("@DonGia", mon.GiaTien);
                        cmdCT.Parameters.AddWithValue("@SoLuong", mon.SoLuong);
                        cmdCT.Parameters.AddWithValue("@ThanhTien", mon.SoLuong * mon.GiaTien);
                        await cmdCT.ExecuteNonQueryAsync();
                    }

                    tran.Commit();
                    MessageBox.Show("Đặt hàng thành công!");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi lưu hóa đơn: " + ex.Message);
                }
            }
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            new DangNhap().Show();
        }
    }
}
