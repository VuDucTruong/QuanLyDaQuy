using QuanLyDaQuy.DTO;
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
    public partial class PhieuDichVu : Form
    {
        private List<double>DonGiaDVs = new List<double>();
        public PhieuDichVu()
        {
            InitializeComponent();
        }

        private void PhieuDichVu_Load(object sender, EventArgs e)
        {
            ComboBox dichVus = new ComboBox();
            DataTable data = DAO.DataProvider.Instance.ExecuteQuery("select * from DICHVU");
            foreach (DataRow row in data.Rows)
            {
                dichVus.Items.Add(row["TenDV"]);
                DonGiaDVs.Add((double)row["DonGiaDV"]);
            }
            
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["TenDV"]).DataSource = dichVus;
        }
    }
}
