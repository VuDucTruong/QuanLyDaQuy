using iText.Commons.Utils;
using QuanLyDaQuy.DAO;
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
    public partial class ThongTinMatHang : UserControl
    {
        public ThongTinMatHang()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            loadSanPhamFullTableAdapter.Fill(qLDQDataSet.loadSanPhamFull);
        }

        private void ThongTinMatHang_Load(object sender, EventArgs e)
        {
            loadSanPhamFullTableAdapter.Fill(qLDQDataSet.loadSanPhamFull);
            loadLoaiSanPhamTableAdapter.Fill(qLDQDataSet.loadLoaiSanPham);
        }

        public void insert_btn_Click(object sender, EventArgs e)
        {
            ThemSPForm themSPForm = new ThemSPForm();
            themSPForm.thongTinMatHang = this;
            themSPForm.ShowDialog();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(MaSP_tb.Text))
            {
                MessageBox.Show("Không có thông tin để sửa đổi !", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isEditableSP())
            {
                update_btn.Text = "Cập nhật lại";
                MessageBox.Show("Hãy cập nhật lại thông tin của sản phẩm !", "Thông báo");
                return;
            }


            int ID = Convert.ToInt32(MaSP_tb.Text);


            if (!string.IsNullOrEmpty(TenSP_tb.Text) &&
                !string.IsNullOrEmpty(Mua_tb.Text) &&
                !string.IsNullOrEmpty(Ban_tb.Text) &&
                !string.IsNullOrEmpty(LSP_cb.Text) &&
                !string.IsNullOrEmpty(DVT_tb.Text) &&
                !string.IsNullOrEmpty(SLT_tb.Text) && ID > 0)
            {
               
                string sub_query = string.Format("select * from LOAISANPHAM where TenLSP = N'{0}'", LSP_cb.Text);
                int MaLSP = (int)DataProvider.Instance.ExecuteScalar(sub_query);
                MessageBox.Show(Convert.ToDouble(Mua_tb.Text.Split(',')[0]).ToString());

                string query = string.Format("update SANPHAM set TenSP = N'{0}' , DonGiaMua = {1} , MaLSP = {2} , SoLuongTon = {3} where MaSP = {4}",
                    TenSP_tb.Text,
                    Convert.ToDouble(Mua_tb.Text.Split(',')[0]),
                    MaLSP,
                    Convert.ToInt32(SLT_tb.Text),
                    ID);
                int data = DataProvider.Instance.ExecuteNonQuery(query);
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
            else MessageBox.Show("Hãy nhập đầy đủ thông tin !");
            
        }


        private Boolean isEditableSP()
        {
            if(!String.IsNullOrEmpty(TenSP_tb.Text) && !String.IsNullOrEmpty(Mua_tb.Text) && !String.IsNullOrEmpty(SLT_tb.Text))
            {
                TenSP_tb.ReadOnly = !TenSP_tb.ReadOnly;
                Mua_tb.ReadOnly = !Mua_tb.ReadOnly;
                //DVT_tb.ReadOnly= !DVT_tb.ReadOnly;
                SLT_tb.ReadOnly = !SLT_tb.ReadOnly;

                dataGridView1.Enabled = !dataGridView1.Enabled;

                if (!TenSP_tb.ReadOnly)
                {
                    LSP_cb.BringToFront();
                    Mua_tb.Text = Mua_tb.Text.Replace(".", string.Empty).Trim('₫');

                    //,'₫'
                }
                else LSP_tb.BringToFront();
            }
            else
            {
                MessageBox.Show("Các ô không được để trống !");
            }
            return TenSP_tb.ReadOnly;
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

        private void button1_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
