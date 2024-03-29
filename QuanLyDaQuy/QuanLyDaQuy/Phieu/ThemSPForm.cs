﻿using QuanLyDaQuy.DAO;
using QuanLyDaQuy.DTO;
using QuanLyDaQuy.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaQuy.Phieu
{
    public partial class ThemSPForm : Form
    {
        public ThemSPForm()
        {
            InitializeComponent();
        }
        public ThongTinMatHang thongTinMatHang { get; set; }
        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TenSP_tb.Text) && 
                !string.IsNullOrEmpty(Mua_tb.Text) && 
                !string.IsNullOrEmpty(LoaiSP_cb.Text) &&
                !string.IsNullOrEmpty(DVT_tb.Text) &&
                !string.IsNullOrEmpty(SLT_tb.Text))
            {
                string sub_query = string.Format("select * from LOAISANPHAM where TenLSP = N'{0}'", LoaiSP_cb.Text);
                DataTable dataTable = DataProvider.Instance.ExecuteQuery(sub_query);
                LoaiSanPham loaiSanPham = new LoaiSanPham(dataTable.Rows[0]);
                try
                {
                    int data = SanPhamDAO.Instance.Insert_SanPham(TenSP_tb.Text, loaiSanPham.MaLSP, Convert.ToDouble(Mua_tb.Text), Convert.ToInt16(SLT_tb.Text));
                    if (data > 0)
                    {
                        MessageBox.Show("Đã thêm sản phẩm thành công!", "Thành công");
                        if (thongTinMatHang != null)
                        {
                            thongTinMatHang.RefreshData();
                        }
                    }
                    else MessageBox.Show("Thêm thất bại !", "Thất bại");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Thông tin đã điền bị sai !", "Thông báo");
                }
            }
            else MessageBox.Show("Thông tin điền vào bị thiếu!", "Thông báo");
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mua_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private void SLT_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void ThemSPForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDQDataSet.loadLoaiSanPham' table. You can move, or remove it, as needed.
            this.loadLoaiSanPhamTableAdapter.Fill(this.qLDQDataSet.loadLoaiSanPham);
            int id;
            try
            {
                id = SanPhamDAO.Instance.GetNew_MaSP();
            }
            catch
            {
                id = 1;
            }
            MaSP_tb.Text = id.ToString();
        }
    }
}
