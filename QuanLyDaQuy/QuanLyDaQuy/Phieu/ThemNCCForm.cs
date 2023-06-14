using QuanLyDaQuy.DAO;
using QuanLyDaQuy.QLDQDataSetTableAdapters;
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
    public partial class ThemNCCForm : Form
    {
        public ThemNCCForm()
        {
            InitializeComponent();
        }
        public ThongTinNCC thongTinNCC { get; set; }
        private void ThemNCCForm_Load(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = NhaCungCapDAO.Instance.GetNew_MaNCC();
            }
            catch
            {
                id = 1;
            }
            MaNCC_tb.Text = id.ToString();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NCC_tb.Text) && !string.IsNullOrEmpty(Phone_tb.Text) && !string.IsNullOrEmpty(Address_tb.Text))
            {
                try
                {
                    int data = NhaCungCapDAO.Instance.Insert_NhaCungCap(NCC_tb.Text, Address_tb.Text, Phone_tb.Text);
                    if (data > 0)
                    {
                        MessageBox.Show("Đã thêm nhà cung cấp thành công!", "Thành công");
                        if (thongTinNCC != null)
                        {
                            thongTinNCC.RefreshData();
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

        private void canncel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
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
