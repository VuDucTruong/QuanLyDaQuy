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
    public partial class ThayDoiThamSo : Form
    {
        public ThayDoiThamSo()
        {
            InitializeComponent();
        }

        private void ThayDoiThamSo_Load(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT MaThamSo, TenThamSo, GiaTri FROM THAMSO";

                DataTable thamSoData = DataProvider.Instance.ExecuteQuery(query);
                dgv_ds_thamSo.DataSource = thamSoData;

            }
            catch
            {
                MessageBox.Show("Lỗi load dữ liệu bảng tham số");
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy DataTable từ DataSource của DataGridView
                DataTable thamSoData = (DataTable)dgv_ds_thamSo.DataSource;

                // Cập nhật dữ liệu từ DataTable vào cơ sở dữ liệu
                foreach (DataRow row in thamSoData.Rows)
                {
                    int maThamSo = Convert.ToInt32(row["MaThamSo"]);
                    string tenThamSo = row["TenThamSo"].ToString();
                    float giaTri = Convert.ToSingle(row["GiaTri"]);

                    if (giaTri < 0 || giaTri > 1)
                    {
                        MessageBox.Show("Giá trị tham số nhập vào phải không âm và không quá 1");
                        return;
                    }

                    // Update CSDL
                    string query = string.Format("UPDATE THAMSO SET GiaTri = {0} WHERE MaThamSo = {1}", giaTri, maThamSo);
                    int affectedRows = DataProvider.Instance.ExecuteNonQuery(query);

                    if (affectedRows > 0)
                    {
                        MessageBox.Show("Lưu dữ liệu thành công!", "Thành công");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Lưu dữ liệu thất bại!", "Thất bại");
                }
            }
            catch
            {
                MessageBox.Show("Lỗi lưu dữ liệu vào bảng tham số");
            }
        }

        private void dgv_ds_thamSo_EditControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBox)
            {
                TextBox textBox = e.Control as TextBox;
                if (dgv_ds_thamSo.CurrentCell.ColumnIndex == 2)
                {
                    textBox.KeyPress -= new KeyPressEventHandler(CellNumber_KeyPress);
                    textBox.KeyPress += new KeyPressEventHandler(CellNumber_KeyPress);
                }
            }
        }

        private void CellNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

    }
}
