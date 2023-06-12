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
            dataGridView1.DataSource = this.qLDQDataSet.loadPhieuDV_Full;
            this.loadPhieuDV_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_Full);
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
            bool allowSearch = false;
            switch (comboBox_SearchMode.SelectedIndex)
            {
                // all
                case 0:
                    {
                        dataGridView1.DataSource = this.qLDQDataSet.loadPhieuDV_Full;
                        this.loadPhieuDV_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_Full);
                        break;
                    }
                // TenKH
                case 1:
                    {
                        dataGridView1.DataSource = this.qLDQDataSet.loadPhieuDV_byTenKH;
                        this.loadPhieuDV_byTenKHTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_byTenKH, textBox_Search.Text);
                        allowSearch = true;
                        break;
                    }
                // SDT
                case 2:
                    {
                        dataGridView1.DataSource = this.qLDQDataSet.loadPhieuDV_bySDT;
                        this.loadPhieuDV_bySDTTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_bySDT, textBox_Search.Text);
                        allowSearch= true;
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
                            dataGridView1.DataSource = this.qLDQDataSet.loadPhieuDV_byNgayLap;
                            this.loadPhieuDV_byNgayLapTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_byNgayLap, month, year);
                            allowSearch = true;
                        }    
                        break;
                    }
                // Hoan thanh
                case 4:
                    {
                        dataGridView1.DataSource = this.qLDQDataSet.loadPhieuDV_byHoanThanh;
                        this.loadPhieuDV_byHoanThanhTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_byHoanThanh);
                        break;
                    }
                // Chua hoan thanh
                case 5:
                    {
                        dataGridView1.DataSource = this.qLDQDataSet.loadPhieuDV_byChuaHoanThanh;
                        this.loadPhieuDV_byChuaHoanThanhTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_byChuaHoanThanh);
                        break;
                    }
            }

            if (allowSearch && textBox_Search.Text == "")
            {
                dataGridView1.DataSource = this.qLDQDataSet.loadPhieuDV_Full;
                this.loadPhieuDV_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_Full);
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

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }    
        }
    }
}
