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
    public partial class CTPhieuBH : Form
    {
        int MaPhieuBH;
        public CTPhieuBH(int maPhieuBH)
        {
            InitializeComponent();
            MaPhieuBH = maPhieuBH;
            setSTTValue();
            loadData();
        }
        
        private void loadData()
        {
            this.loadPhieuBH_byMaPhieuBH_For_CTPhieuBHTableAdapter.Fill(this.qLDQDataSet.loadPhieuBH_byMaPhieuBH_For_CTPhieuBH, MaPhieuBH);
            this.loadCTPhieuBH_byMaPhieuBHTableAdapter.Fill(this.qLDQDataSet.loadCTPhieuBH_byMaPhieuBH, MaPhieuBH);
        }
        private void setSTTValue()
        {
            foreach (DataGridViewRow dataRow in dgv_ct_phieubanhang.Rows)
            {
                dataRow.Cells[0].Value = dataRow.Index + 1;
            }
        }
    }
}
