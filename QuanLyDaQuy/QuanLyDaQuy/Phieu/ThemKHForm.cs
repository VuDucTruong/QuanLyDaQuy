﻿using QuanLyDaQuy.DAO;
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
    public partial class ThemKHForm : Form
    {
        public ThemKHForm()
        {
            InitializeComponent();
        }
        public ThongTinKhachHang thongTinKhachHang { get; set; }
        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(name_tb.Text) && !string.IsNullOrEmpty(phone_tb.Text))
            {
                if (phone_tb.Text.Length < 10)
                { MessageBox.Show("Số điện thoại phải từ 10 chữ số trở lên !"); return; }
                try
                {
                    int data = KhachHangDAO.Instance.insertKhachHang(name_tb.Text, phone_tb.Text);
                    if (data > 0)
                    {
                        MessageBox.Show("Đã thêm khách hàng thành công!", "Thành công");
                        if (thongTinKhachHang != null)
                        {
                            thongTinKhachHang.RefreshData();
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

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void phone_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ThemKHForm_Load(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = KhachHangDAO.Instance.getMaKHLonNhat() + 1;
            }
            catch { id = 1; }
            
            id_tb.Text = id.ToString();
        }
    }
}
