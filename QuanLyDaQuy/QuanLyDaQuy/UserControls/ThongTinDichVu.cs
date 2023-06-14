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
    public partial class ThongTinDichVu : UserControl
    {
        public ThongTinDichVu()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            loadDichVuTableAdapter.Fill(this.qLDQDataSet.loadDichVu);
        }

        private void ThongTinDichVu_Load(object sender, EventArgs e)
        {
            loadDichVuTableAdapter.Fill(this.qLDQDataSet.loadDichVu);
        }

        public void button1_Click(object sender, EventArgs e)
        {
            
            ThemDVForm themDVForm = new ThemDVForm();
            themDVForm.ThongTinDichVu = this;
            themDVForm.ShowDialog();
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(!isEditableTextbox())
            {
                update_btn.Text = "Cập nhật lại";
                MessageBox.Show("Hãy cập nhật lại thông tin của dịch vụ !", "Thông báo");
                return;
            }

            int MaDV = Convert.ToInt32(MaDV_tb.Text);
            if (!string.IsNullOrEmpty(DV_tb.Text) && !string.IsNullOrEmpty(DonGia_tb.Text))
            {
                string query = string.Format("update DICHVU set TenDV = N'{0}' , DonGiaDV = {1} where MaDV = {2}", DV_tb.Text, Convert.ToInt32(DonGia_tb.Text.Split(',')[0]) , MaDV);
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public Boolean isEditableTextbox()
        {

            if (!String.IsNullOrEmpty(DV_tb.Text) && !String.IsNullOrEmpty(DonGia_tb.Text))
            {
                DV_tb.ReadOnly = !DV_tb.ReadOnly;
                DonGia_tb.ReadOnly = !DonGia_tb.ReadOnly;
                dataGridView1.Enabled = !dataGridView1.Enabled;

                if (!DonGia_tb.ReadOnly)
                {
                    DonGia_tb.Text = DonGia_tb.Text.Replace(".", string.Empty).Trim('₫');
                }
            }
            else MessageBox.Show("Không được để trống các ô đó !");
            return DV_tb.ReadOnly && DonGia_tb.ReadOnly;

        }
    }
}
