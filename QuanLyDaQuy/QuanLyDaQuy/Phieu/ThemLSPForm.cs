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
    public partial class ThemLSPForm : Form
    {
        public ThemLSPForm()
        {
            InitializeComponent();
        }
        public ThongTinLSP ThongTinLSP { get; set; }
        private void ThemLSPForm_Load(object sender, EventArgs e)
        {
            this.dONVITINHTableAdapter.Fill(this.qLDQDataSet.DONVITINH);
            int id;
            try
            {
                id = LoaiSanPhamDAO.Instance.getMaLSPLonNhat() + 1;
            }
            catch
            {
                id = 1;
            }
            id_tb.Text = id.ToString();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(LSP_tb.Text) && !string.IsNullOrEmpty(LoiNhuan_tb.Text) && !string.IsNullOrEmpty(DVT_cb.Text))
            {
                int DVT_id = DonViTinhDAO.Instance.getMaDVT_byDVT(DVT_cb.Text);

                try
                {
                    int data = LoaiSanPhamDAO.Instance.insertLSP(LSP_tb.Text, LoiNhuan_tb.Text, DVT_id);
                    if (data > 0)
                    {
                        MessageBox.Show("Đã thêm loại sản phẩm thành công!", "Thành công");
                        if (ThongTinLSP != null)
                        {
                            ThongTinLSP.RefreshDataLSP();
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
