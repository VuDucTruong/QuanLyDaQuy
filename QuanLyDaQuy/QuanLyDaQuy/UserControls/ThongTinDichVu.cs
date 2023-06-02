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
            dICHVUTableAdapter.Fill(this.qLDQDataSet.DICHVU);
        }

        private void ThongTinDichVu_Load(object sender, EventArgs e)
        {
            dICHVUTableAdapter.Fill(this.qLDQDataSet.DICHVU);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ThemDVForm themDVForm = new ThemDVForm();
            themDVForm.ShowDialog();
           /* int MaDV = Convert.ToInt32(textBox3.Text);
      
            int id = Convert.ToInt32(DataProvider.Instance.ExecuteScalar("select max(MaDV) from DICHVU")) + 1;
            dataGridView1.Rows[id-1].Selected = true;
            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                if(MaDV != id)
                {
                    textBox3.Text = id.ToString();
                    textBox1.Text = textBox2.Text = "";
                    MessageBox.Show("Hãy điền thông tin sản phẩm mới !", "Thông báo");
                }
                else
                {
                    if(!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
                    {
                        string query = string.Format("Insert into DICHVU values ( N'{0}' , {1} )", textBox1.Text, Convert.ToInt32(textBox2.Text));
                        int data = DataProvider.Instance.ExecuteNonQuery(query);
                        if (data > 0)
                        {
                            MessageBox.Show("Đã thêm thành công !", "Thành công");
                            RefreshData();
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại !", "Thất bại");
                        }
                        MessageBox.Show("What!!!");
                    }    
                }
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int MaDV = Convert.ToInt32(textBox3.Text);
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text))
            {
                string query = string.Format("update DICHVU set TenDV = N'{0}' , DonGiaDV = {1} where MaDV = {2}", textBox1.Text, Convert.ToInt32(textBox2.Text) , MaDV);
                int data = DataProvider.Instance.ExecuteNonQuery(query);
                if (data > 0)
                {
                    MessageBox.Show("Đã cập nhật thành công !", "Thành công");
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
    }
}
