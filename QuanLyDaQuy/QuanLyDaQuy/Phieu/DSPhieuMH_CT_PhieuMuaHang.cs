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
    public partial class DSPhieuMH_CT_PhieuMuaHang : Form
    {
        int MaPhieuMH;
        public DSPhieuMH_CT_PhieuMuaHang(int maPhieuMH)
        {
            InitializeComponent();
            MaPhieuMH = maPhieuMH;
            setSTTValue();
            loadData();
        }
        
        private void loadData()
        {
            this.loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHangTableAdapter.Fill(this.qLDQDataSet.loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHang, MaPhieuMH);
            this.loadCTPhieuMH_byMaPhieuMHTableAdapter.Fill(this.qLDQDataSet.loadCTPhieuMH_byMaPhieuMH, MaPhieuMH);
        }
        private void setSTTValue()
        {
            foreach (DataGridViewRow dataRow in dt_grid_phieumuahang.Rows)
            {
                dataRow.Cells[0].Value = dataRow.Index + 1;
            }
        }
    }
}
