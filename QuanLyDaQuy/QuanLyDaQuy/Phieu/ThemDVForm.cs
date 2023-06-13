using QuanLyDaQuy.DAO;
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
    public partial class ThemDVForm : Form
    {
        public ThemDVForm()
        {
            InitializeComponent();
        }
        public ThongTinDichVu ThongTinDichVu { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(DonGia_tb.Text) && !string.IsNullOrEmpty(DV_tb.Text))
            {
                try
                {
                    int data = ThemDVFormDAO.Instance.insertDichVu(DV_tb.Text, DonGia_tb.Text);
                    if (data > 0)
                    {
                        MessageBox.Show("Đã thêm dịch vụ thành công!", "Thành công");
                        if(ThongTinDichVu != null)
                        {
                            ThongTinDichVu.RefreshData();
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

        private void ThemDVForm_Load(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = ThemDVFormDAO.Instance.getMaDVLonNhat() + 1;
            }
            catch { id = 1; }
            MaDV_tb.Text = id.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DonGia_tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    
    }
}
