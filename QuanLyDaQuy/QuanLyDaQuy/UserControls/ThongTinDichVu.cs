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

        private void ThongTinDichVu_Load(object sender, EventArgs e)
        {
            dICHVUTableAdapter.Fill(this.qLDQDataSet.DICHVU);
        }
    }
}
