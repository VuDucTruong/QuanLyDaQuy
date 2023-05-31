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

        private void ThongTinMatHang_Load(object sender, EventArgs e)
        {
            loadSanPhamFullTableAdapter.Fill(qLDQDataSet.loadSanPhamFull);
        }
    }
}
