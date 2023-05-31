using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDaQuy.DTO;
using QuanLyDaQuy.DAO;

namespace QuanLyDaQuy.Phieu
{
    public partial class PhieuBanHang : Form
    {

        public PhieuBanHang()
        {
            InitializeComponent();
            AutoFillMaPBH();
            AutoFillNgayLap();
            LoadKhachHang();
            LoadSanPham();
        }

        private void LoadSanPham()
        {

        }

        private void LoadKhachHang()
        {
            // load data from KHACHHANG
            try
            {

            }
            catch
            {

            }

            cb_khachhang.Text = "TriPero";
        }

        private void AutoFillNgayLap()
        {
            tb_ngaylap.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void AutoFillMaPBH()
        {
            int soPhieu = 0;
            try
            {
                soPhieu = (int)DataProvider.Instance.ExecuteScalar("select max(MaPhieuBH) from PHIEUBANHANG");
            }
            catch
            {
                soPhieu = 1;
            }
            finally
            {
                tb_sophieu.Text = soPhieu.ToString();
            }

        }
    }
}