using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaQuy.Phieu
{
    public partial class DSPhieuMH : Form
    {
        public DSPhieuMH()
        {
            InitializeComponent();
        }

        private void DSPhieuMH_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDQDataSet.loadPhieuMH_Full' table. You can move, or remove it, as needed.
            dtgView_DS_phieu_mua_hang.DataSource = this.qLDQDataSet.loadPhieuMH_Full;
            this.loadPhieuMH_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuMH_Full);
            comboBox_SearchMode.SelectedIndex = 0;
        }

        private void dtgView_DS_phieu_mua_hang_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn col in dtgView_DS_phieu_mua_hang.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void comboBox_SearchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableSearchBox = false;
            switch (comboBox_SearchMode.SelectedIndex)
            {
                // all
                case 0:
                    {
                        tb_Search.Text = "";
                        break;
                    }
                // MaPhieu
                case 1:
                    {
                        enableSearchBox = true;
                        break;
                    }
                // TenNCC
                case 2:
                    {
                        enableSearchBox = true;
                        break;
                    }
                // NgayLap
                case 3:
                    {
                        enableSearchBox = true;
                        break;
                    }
                // TongTien
                case 4:
                    {
                        enableSearchBox = true;
                        break;
                    }
            }
            tb_Search.Enabled = enableSearchBox;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bool allowSearch = false;
            switch (comboBox_SearchMode.SelectedIndex)
            {
                // all
                case 0:
                    {
                        dtgView_DS_phieu_mua_hang.DataSource = this.qLDQDataSet.loadPhieuMH_Full;
                        this.loadPhieuMH_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuMH_Full);
                        break;
                    }
                // MaPhieu
                case 1:
                    {
                        dtgView_DS_phieu_mua_hang.DataSource = this.qLDQDataSet.loadPhieuMH_byMaPhieuMH;
                        this.loadPhieuMH_byMaPhieuMHTableAdapter.Fill(this.qLDQDataSet.loadPhieuMH_byMaPhieuMH, Convert.ToInt32(tb_Search.Text));
                        allowSearch = true;
                        break;
                    }
                // TenNCC
                case 2:
                    {
                        dtgView_DS_phieu_mua_hang.DataSource = this.qLDQDataSet.loadPhieuMH_byTenNCC;
                        this.loadPhieuMH_byTenNCCTableAdapter.Fill(this.qLDQDataSet.loadPhieuMH_byTenNCC, tb_Search.Text);
                        allowSearch = true;
                        break;
                    }
                // NgayLap
                case 3:
                    {
                        if (Validating_DateTimeBy_MonthYear(tb_Search.Text))
                        {
                            string[] datetime = tb_Search.Text.Split('/');
                            int month = Convert.ToInt32(datetime[0]);
                            int year = Convert.ToInt32(datetime[1]);
                            dtgView_DS_phieu_mua_hang.DataSource = this.qLDQDataSet.loadPhieuMH_byNgayLap;
                            this.loadPhieuMH_byNgayLapTableAdapter.Fill(this.qLDQDataSet.loadPhieuMH_byNgayLap, month, year);
                            allowSearch = true;
                        }
                        break;
                    }
                // TongTien
                case 4:
                    {
                        dtgView_DS_phieu_mua_hang.DataSource = this.qLDQDataSet.loadPhieuMH_byTongTien;
                        this.loadPhieuMH_byTongTienTableAdapter.Fill(this.qLDQDataSet.loadPhieuMH_byTongTien, Convert.ToInt32(tb_Search.Text));
                        allowSearch = true;
                        break;
                    }
            }

            if (allowSearch && tb_Search.Text == "")
            {
                dtgView_DS_phieu_mua_hang.DataSource = this.qLDQDataSet.loadPhieuMH_Full;
                this.loadPhieuMH_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuMH_Full);
                return;
            }
        }
        private bool Validating_DateTimeBy_MonthYear(string date)
        {
            DateTime d;
            bool testDate = DateTime.TryParseExact(date, "MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
            if (!testDate)
            {
                MessageBox.Show("Bạn phải nhập tháng năm theo format MM/yyyy vào ô này!", "Cảnh báo");
            }
            return testDate;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int MaPhieuMH = Convert.ToInt32(dtgView_DS_phieu_mua_hang.SelectedRows[0].Cells[0].Value);
            DSPhieuMH_CT_PhieuMuaHang dSPhieuMH_CT_PhieuMuaHang = new DSPhieuMH_CT_PhieuMuaHang(MaPhieuMH);
            dSPhieuMH_CT_PhieuMuaHang.Show();
        }
    }
}
