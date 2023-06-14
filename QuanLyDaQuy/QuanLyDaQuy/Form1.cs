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

        private void phiếuMuaHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PhieuMuaHang phieu = new PhieuMuaHang();
            phieu.ShowDialog(this);
        }

        private void phiếuBánHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PhieuBanHang phieu = new PhieuBanHang();
            phieu.ShowDialog(this);
        }

        private void phiếuDịchVụToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PhieuDichVu phieu = new PhieuDichVu();
            phieu.ShowDialog(this);
        }

        private void phieuDichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSPhieuDV dSPhieuDV = new DSPhieuDV();
            dSPhieuDV.ShowDialog(this);
        }

        private void phiếuMuaHàngToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DSPhieuMH dSPhieuMH = new DSPhieuMH();
            dSPhieuMH.ShowDialog(this);
        }


        private void phiếuBánHàngToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DsPhieuBH dsPhieuBH = new DsPhieuBH();
            dsPhieuBH.ShowDialog(this);
        }

        private void báoBáoTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoTonKho baoCaoTonKho = new BaoCaoTonKho();
            baoCaoTonKho.ShowDialog(this);
        }

        private void thêmMặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongTinMatHang1.insert_btn_Click(null, null);
        }

        private void thêmDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongTinDichVu1.button1_Click(null, null);
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongTinKhachHang1.button1_Click(null, null);
        }

        private void thêmNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongTinNCC1.insert_btn_Click(null, null);
        }

        private void thêmLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongTinLSP1.insertLSP_btn_Click((object)null, null);
        }

        private void thêmĐơnVịTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thongTinLSP1.insertDVT_btn_Click(((object)null), null);
        }

        private void thayĐổiThamSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThayDoiThamSo thayDoiThamSo = new ThayDoiThamSo();
            thayDoiThamSo.ShowDialog(this);
        }
    }

}
