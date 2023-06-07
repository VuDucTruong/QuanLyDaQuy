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

namespace QuanLyDaQuy.UserControls
{
    public partial class ThongTinKhachHang : UserControl
    {
        public ThongTinKhachHang()
        {
            InitializeComponent();
        }

        public void RefreshData()
        {
            kHACHHANGTableAdapter.Fill(this.qLDQDataSet.KHACHHANG);
        }

        private void ThongTinKhachHang_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemKHForm themKHForm = new ThemKHForm();
            themKHForm.thongTinKhachHang = this;
            themKHForm.ShowDialog();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

            if(string.IsNullOrEmpty(id_tb.Text))
            {
                MessageBox.Show("Không có thông tin để sửa đổi !" , "Cảnh báo" , MessageBoxButtons.OK , MessageBoxIcon.Warning);
                return;
            }

            if (!isEditableTextbox())
            {
                update_btn.Text = "Cập nhật lại";
                MessageBox.Show("Hãy cập nhật lại thông tin của khách hàng !", "Thông báo");
                return;
            }

            int ID = Convert.ToInt32(id_tb.Text);

            
            if (!string.IsNullOrEmpty(KH_tb.Text) && !string.IsNullOrEmpty(Phone_tb.Text) && ID > 0)
            {
                string query = string.Format("update KHACHHANG set TenKH = N'{0}' , SDT = '{1}' where MaKH = {2}", KH_tb.Text, Phone_tb.Text, ID);
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

        public Boolean isEditableTextbox()
        {
            KH_tb.ReadOnly = !KH_tb.ReadOnly;
            Phone_tb.ReadOnly = !Phone_tb.ReadOnly;
            dataGridView1.Enabled = !dataGridView1.Enabled;
            return KH_tb.ReadOnly && Phone_tb.ReadOnly;
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
