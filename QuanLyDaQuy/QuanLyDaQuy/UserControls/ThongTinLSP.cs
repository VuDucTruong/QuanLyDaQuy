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
    public partial class ThongTinLSP : UserControl
    {
        public ThongTinLSP()
        {
            InitializeComponent();
        }

        private void ThongTinLSP_Load(object sender, EventArgs e)
        {
            dONVITINHTableAdapter.Fill(this.qLDQDataSet.DONVITINH);
            lOAISANPHAMTableAdapter.Fill(this.qLDQDataSet.LOAISANPHAM);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemLSPForm themLSPForm = new ThemLSPForm();
            themLSPForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ThemDVForm themDVForm = new ThemDVForm();
            themDVForm.ShowDialog();
        }
    }
}
