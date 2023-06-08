using QuanLyDaQuy.DAO;
using QuanLyDaQuy.DTO;
using QuanLyDaQuy.Phieu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaQuy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                if (item != null)
                {
                    switch (item.Index)
                    {
                        case 0:
                            thongTinMatHang1.BringToFront();
                            break;
                        case 1:
                            thongTinDichVu1.BringToFront();
                            break;
                        case 2:
                            thongTinKhachHang1.BringToFront(); break;
                        case 3:
                            thongTinNCC1.BringToFront(); break;
                        case 4:
                            thongTinLSP1.BringToFront(); break;

                    }
                }
            }
        }

        private void phiếuBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuBanHang phieuBanHang = new PhieuBanHang();
            phieuBanHang.Show();
        }

        private void phiếuMuaHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuMuaHang phieuMuaHang = new PhieuMuaHang();
            phieuMuaHang.Show();
        }

        private void phiếuDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PhieuDichVu phieuDichVu = new PhieuDichVu();
            phieuDichVu.Show();
        }

        private void báoCáoTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoTonKho baoCaoTonKho = new BaoCaoTonKho();
            baoCaoTonKho.Show();
        }
    }
}
