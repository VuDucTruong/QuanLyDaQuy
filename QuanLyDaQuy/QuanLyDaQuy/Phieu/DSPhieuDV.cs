using QuanLyDaQuy.QLDQDataSetTableAdapters;
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
    public partial class DSPhieuDV : Form
    {
        public DSPhieuDV()
        {
            InitializeComponent();
        }

        private void DSPhieuDV_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDQDataSet.loadPhieuDV_Full' table. You can move, or remove it, as needed.
            this.loadPhieuDV_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_Full);
            // TODO: This line of code loads data into the 'qLDQDataSet.loadPhieuDV_Full' table. You can move, or remove it, as needed.
            this.loadPhieuDV_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_Full);
            // TODO: This line of code loads data into the 'qLDQDataSet.loadPhieuDV_Full' table. You can move, or remove it, as needed.
            this.loadPhieuDV_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_Full);
            // TODO: This line of code loads data into the 'qLDQDataSet.PHIEUDICHVU' table. You can move, or remove it, as needed.
            comboBox_SearchMode.SelectedIndex = 0;

        }

        private void comboBox_SearchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool enableSearchBox = false;
            switch (comboBox_SearchMode.SelectedIndex)
            {
                // all
                case 0:
                    {
                        textBox_Search.Text = "";
                        break;
                    }
                // TenKH
                case 1:
                    {
                        enableSearchBox = true;
                        break;
                    }
                // SDT
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
                // Hoan thanh
                case 4:
                    {
                        textBox_Search.Text = "";
                        break;
                    }
                // Chua hoan thanh
                case 5:
                    {
                        textBox_Search.Text = "";
                        break;
                    }
            }

            textBox_Search.Enabled = enableSearchBox;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Search.Text == "")
            {
                this.loadPhieuDV_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_Full);
                return;
            }    

            switch (comboBox_SearchMode.SelectedIndex)
            {
                // all
                case 0:
                    {
                        this.loadPhieuDV_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_Full);
                        break;
                    }
                // TenKH
                case 1:
                    {
                        this.loadPhieuDV_FullTableAdapter.FillBy_TenKH(this.qLDQDataSet.loadPhieuDV_Full, textBox_Search.Text);
                        break;
                    }
                // SDT
                case 2:
                    {
                        this.loadPhieuDV_FullTableAdapter.FillBy_SDT(this.qLDQDataSet.loadPhieuDV_Full, textBox_Search.Text);
                        break;
                    }
                // NgayLap
                case 3:
                    {

                        if (Validating_DateTimeBy_MonthYear(textBox_Search.Text))
                        {
                            string[] datetime = textBox_Search.Text.Split('/');
                            int month = Convert.ToInt32(datetime[0]);
                            int year = Convert.ToInt32(datetime[1]);
                            this.loadPhieuDV_FullTableAdapter.FillBy_NgayLap(this.qLDQDataSet.loadPhieuDV_Full, month, year);
                        }    
                        break;
                    }
                // Hoan thanh
                case 4:
                    {
                        this.loadPhieuDV_FullTableAdapter.FillBy_HoanThanh(this.qLDQDataSet.loadPhieuDV_Full);
                        break;
                    }
                // Chua hoan thanh
                case 5:
                    {
                        this.loadPhieuDV_FullTableAdapter.FillBy_ChuaHoanThanh(this.qLDQDataSet.loadPhieuDV_Full);
                        break;
                    }
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
    }
}
