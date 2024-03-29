﻿using QuanLyDaQuy.DAO;
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

namespace QuanLyDaQuy.UserControls
{
    public partial class ThongTinLSP : UserControl
    {
        public ThongTinLSP()
        {
            InitializeComponent();
        }
        public void RefreshDataDVT()
        {
            dONVITINHTableAdapter.Fill(this.qLDQDataSet.DONVITINH);
        }
        public void RefreshDataLSP()
        {
            lOAISANPHAMTableAdapter.Fill(this.qLDQDataSet.LOAISANPHAM);
        }
        private void ThongTinLSP_Load(object sender, EventArgs e)
        {
            RefreshDataDVT();
            RefreshDataLSP();
            
        }
       
        public void insertDVT_btn_Click(object sender, EventArgs e)
        {
            ThemDVTForm themDVTForm = new ThemDVTForm();
            themDVTForm.thongTinLSP = this;
            themDVTForm.ShowDialog();
        }

        public void insertLSP_btn_Click(object sender, EventArgs e)
        {
            ThemLSPForm themLSPForm = new ThemLSPForm();
            themLSPForm.ThongTinLSP = this;
            themLSPForm.ShowDialog();
        }

        private void updateLSP_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaLSP_tb.Text))
            {
                MessageBox.Show("Không có thông tin để sửa đổi !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isEditableLSP())
            {
                updateLSP_btn.Text = "Cập nhật lại";
                /*MaDVT_cb.DataSource = dONVITINHBindingSource;
                MaDVT_cb.DisplayMember = "MaDVT";*/
                
                MessageBox.Show("Hãy cập nhật lại thông tin của loại sản phẩm !", "Thông báo");
                return;
            }
            

            int ID = Convert.ToInt32(MaLSP_tb.Text);


            if (!string.IsNullOrEmpty(TenLSP_tb.Text) && !string.IsNullOrEmpty(LoiNhuan_tb.Text) && !string.IsNullOrEmpty(MaDVT_cb.Text) && ID > 0)
            {

                int data = LoaiSanPhamDAO.Instance.updateLSP(TenLSP_tb.Text, Convert.ToDouble(LoiNhuan_tb.Text), Convert.ToInt32(MaDVT_cb.Text), ID);
                if (data > 0)
                {
                    MessageBox.Show("Đã cập nhật thành công !", "Thành công");
                    updateLSP_btn.Text = "Sửa";
                    RefreshDataLSP();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !", "Thất bại");
                }

            }
            else MessageBox.Show("Hãy nhập đầy đủ thông tin !");
        }

        private void updateDVT_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaDVT_tb.Text))
            {
                MessageBox.Show("Không có thông tin để sửa đổi !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isEditableDVT())
            {
                updateLSP_btn.Text = "Cập nhật lại";
                MessageBox.Show("Hãy cập nhật lại thông tin của đơn vị tính !", "Thông báo");
                return;
            }

            int ID = Convert.ToInt32(MaDVT_tb.Text);


            if (!string.IsNullOrEmpty(DVT_tb.Text) && ID > 0)
            {
                int data = DonViTinhDAO.Instance.updateDVT(DVT_tb.Text, ID);
                if (data > 0)
                {
                    MessageBox.Show("Đã cập nhật thành công !", "Thành công");
                    updateDVT_btn.Text = "Sửa";
                    RefreshDataDVT();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !", "Thất bại");
                }

            }
            else MessageBox.Show("Hãy nhập đầy đủ thông tin !");
        }
        private Boolean isEditableLSP()
        {
            if(!String.IsNullOrEmpty(TenLSP_tb.Text) && !String.IsNullOrEmpty(LoiNhuan_tb.Text))
            {
                TenLSP_tb.ReadOnly = !TenLSP_tb.ReadOnly;
                LoiNhuan_tb.ReadOnly = !LoiNhuan_tb.ReadOnly;
                MaDVT_tb_1.Visible = !MaDVT_tb_1.Visible;
                MaDVT_cb.Visible = !MaDVT_cb.Visible;
                dataGridView1.Enabled = !dataGridView1.Enabled;
            }
            else { MessageBox.Show("Không được để trống ô !"); }
            return TenLSP_tb.ReadOnly;
        }
        private Boolean isEditableDVT()
        {
            if(!String.IsNullOrEmpty(DVT_tb.Text))
            {
                DVT_tb.ReadOnly = !DVT_tb.ReadOnly;
                dataGridView2.Enabled = !dataGridView2.Enabled;
            }
            else { MessageBox.Show("Không được để trống ô !"); }
            
            return DVT_tb.ReadOnly;
        }

        private void LoiNhuan_tb_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
