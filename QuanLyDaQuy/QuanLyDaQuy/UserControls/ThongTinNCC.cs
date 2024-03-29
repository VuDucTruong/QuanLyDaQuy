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
    public partial class ThongTinNCC : UserControl
    {
        public ThongTinNCC()
        {
            InitializeComponent();
        }
        public void RefreshData()
        {
            nHACUNGCAPTableAdapter.Fill(this.qLDQDataSet.NHACUNGCAP);
        }
        private void ThongTinNCC_Load(object sender, EventArgs e)
        {
            RefreshData();
        }
        public void insert_btn_Click(object sender, EventArgs e)
        {
            ThemNCCForm themNCCForm = new ThemNCCForm();
            themNCCForm.thongTinNCC = this;
            themNCCForm.ShowDialog();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaNCC_tb.Text))
            {
                MessageBox.Show("Không có thông tin để sửa đổi !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isEditableNCC())
            {
                update_btn.Text = "Cập nhật lại";
                MessageBox.Show("Hãy cập nhật lại thông tin của nhà cung cấp !", "Thông báo");
                return;
            }


            int ID = Convert.ToInt32(MaNCC_tb.Text);


            if (!string.IsNullOrEmpty(NCC_tb.Text) && !string.IsNullOrEmpty(Phone_tb.Text) && !string.IsNullOrEmpty(Address_tb.Text) && ID > 0)
            {
                if(Phone_tb.Text.Length >= 10)
                {
                    int data = NhaCungCapDAO.Instance.updateNCC(NCC_tb.Text, Address_tb.Text, Phone_tb.Text, ID);
                    if (data > 0)
                    {
                        MessageBox.Show("Đã cập nhật thành công !", "Thành công");
                        update_btn.Text = "Sửa";
                        RefreshData();
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thất bại !", "Thất bại");
                    }
                }
                else { MessageBox.Show("Số điện thoại phải từ 10 số trở lên !"); }

            }
            else MessageBox.Show("Hãy nhập đầy đủ thông tin !");
        }

        private Boolean isEditableNCC()
        {
            if(!String.IsNullOrEmpty(NCC_tb.Text) && !String.IsNullOrEmpty(Phone_tb.Text) && !String.IsNullOrEmpty(Address_tb.Text)) 
            {
                if (Phone_tb.Text.Length < 10)
                { MessageBox.Show("Số điện thoại phải từ 10 chữ số trở lên !"); return false; }
                NCC_tb.ReadOnly = !NCC_tb.ReadOnly;
                Phone_tb.ReadOnly = !Phone_tb.ReadOnly;
                Address_tb.ReadOnly = !Address_tb.ReadOnly;
                dataGridView1.Enabled = !dataGridView1.Enabled;
            }
            else { MessageBox.Show("Không được để trống ô !"); }
            
            return NCC_tb.ReadOnly;
        }

        private void Phone_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

        }
    }
}
