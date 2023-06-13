using QuanLyDaQuy.DAO;
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
    public partial class ThemDVTForm : Form
    {
        public ThemDVTForm()
        {
            InitializeComponent();
        }
        public ThongTinLSP thongTinLSP { get; set; }
        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(dvt_tb.Text))
            {
                try
                {
                    int data = ThemDVTFormDAO.Instance.insertDVT(dvt_tb.Text);
                    if (data > 0)
                    {
                        MessageBox.Show("Đã thêm đơn vị tính thành công!", "Thành công");
                        if (thongTinLSP != null)
                        {
                            thongTinLSP.RefreshDataDVT();
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

        private void ThemDVTForm_Load(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = ThemDVTFormDAO.Instance.getMaDVTLonNhat() + 1;
            }
            catch { id = 1; }
            id_tb.Text = id.ToString();

        }
    }
}
