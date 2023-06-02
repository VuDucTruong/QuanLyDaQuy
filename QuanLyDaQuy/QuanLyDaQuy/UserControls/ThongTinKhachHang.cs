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
    public partial class ThongTinKhachHang : UserControl
    {
        public ThongTinKhachHang()
        {
            InitializeComponent();
        }

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            kHACHHANGTableAdapter.Fill(this.qLDQDataSet.KHACHHANG);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemKHForm themKHForm = new ThemKHForm();
            themKHForm.ShowDialog();
        }
    }
}
