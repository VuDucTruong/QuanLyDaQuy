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
    }
}
