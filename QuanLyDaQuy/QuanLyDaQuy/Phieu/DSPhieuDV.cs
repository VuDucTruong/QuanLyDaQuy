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
        private List<int> Days28 = new List<int>();
        private List<int> Days29 = new List<int>();
        private List<int> Days30 = new List<int>();
        private List<int> Days31 = new List<int>();
        private List<int> Month12 = new List<int>();

        private bool[] is31Day = new bool[13] { true, true, false, true, false, true, false, true, true, false, true, false, true};
        

        public DSPhieuDV()
        {
            InitializeComponent();
        }

        private void DSPhieuDV_Load(object sender, EventArgs e)
        {
            Init_DateTimeSearch();
            // TODO: This line of code loads data into the 'qLDQDataSet.loadPhieuDV_Full' table. You can move, or remove it, as needed.
            dataGridView1.DataSource = this.qLDQDataSet.loadPhieuDV_Full;
            this.loadPhieuDV_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_Full, 0, 0, 0);
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
            Reload_DataGrid(); 
            if (dataGridView1.Rows.Count > 0)
            {
                MessageBox.Show("Tra cứu thành công", "Thông báo");
            }
            else
            {
                MessageBox.Show("Không tìm thấy kết quả", "Thông báo");
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

        private void Reload_DataGrid()
        {
            int day = Convert.ToInt32(comboBox_Ngay.Text);
            int month = Convert.ToInt32(comboBox_Thang.Text);
            int year = Convert.ToInt32(textBox_Nam.Text);
            bool allowSearch = false;
            switch (comboBox_SearchMode.SelectedIndex)
            {
                // all
                case 0:
                    {
                        dataGridView1.DataSource = this.qLDQDataSet.loadPhieuDV_Full;
                        this.loadPhieuDV_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_Full, day, month, year);
                        break;
                    }
                // TenKH
                case 1:
                    {
                        dataGridView1.DataSource = this.qLDQDataSet.loadPhieuDV_byTenKH;
                        this.loadPhieuDV_byTenKHTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_byTenKH, textBox_Search.Text, day, month, year);
                        allowSearch = true;
                        break;
                    }
                // SDT
                case 2:
                    {
                        dataGridView1.DataSource = this.qLDQDataSet.loadPhieuDV_bySDT;
                        this.loadPhieuDV_bySDTTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_bySDT, textBox_Search.Text, day, month, year);
                        allowSearch = true;
                        break;
                    }
                // Hoan thanh
                case 3:
                    {
                        dataGridView1.DataSource = this.qLDQDataSet.loadPhieuDV_byHoanThanh;
                        this.loadPhieuDV_byHoanThanhTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_byHoanThanh, day, month, year);
                        break;
                    }
                // Chua hoan thanh
                case 4:
                    {
                        dataGridView1.DataSource = this.qLDQDataSet.loadPhieuDV_byChuaHoanThanh;
                        this.loadPhieuDV_byChuaHoanThanhTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_byChuaHoanThanh, day, month, year);
                        break;
                    }
            }

            if (allowSearch && textBox_Search.Text == "")
            {
                dataGridView1.DataSource = this.qLDQDataSet.loadPhieuDV_Full;
                this.loadPhieuDV_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuDV_Full, day, month, year);
                return;
            }
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }    
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region Other functions
        private void Create_DateTime_ComboBox_Items()
        {
            for (int i = 0; i <= 28; i++)
            {
                Days28.Add(i);
            }
            for (int i = 0; i <= 29; i++)
            {
                Days29.Add(i);
            }
            for (int i = 0; i <= 30; i++)
            {
                Days30.Add(i);
            }
            for (int i = 0; i <= 31; i++)
            {
                Days31.Add(i);
            }
            for (int i = 0; i <= 12; i++)
            {
                Month12.Add(i);
            }
        }

        private void Init_DateTimeSearch()
        {
            textBox_Nam.Text = "0";
            Create_DateTime_ComboBox_Items();
            comboBox_Thang.DataSource = Month12;
            comboBox_Ngay.DataSource = Days31;
            comboBox_Thang.SelectedIndex = 0;
            comboBox_Ngay.SelectedIndex = 0;
            comboBox_Ngay.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Thang.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        static private bool IsLeapYear(int year)
        {
            if (year % 4 == 0)//chia hết cho 4 là năm nhuận
            {
                if (year % 100 == 0) //nếu vừa chia hết cho 4 mà vừa chia hết cho 100 thì không phải năm nhuận
                {
                    if (year % 400 == 0)//chia hết cho 400 là năm nhuận
                        return true;
                    else
                        return false;//không chia hết cho 400 thì không phải năm nhuận
                }
                else//chia hết cho 4 nhưng không chia hết cho 100 là năm nhuận
                    return true;
            }
            return false;
        }

        #endregion

        private void comboBox_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool leapYear = IsLeapYear(Convert.ToInt32(textBox_Nam.Text));
            int saveIndex = 0;
            if (comboBox_Thang.SelectedIndex == 2)
            {
                if (leapYear)
                {
                    if (comboBox_Ngay.SelectedIndex > 29)
                    {
                        comboBox_Ngay.SelectedIndex = 29;
                    }
                    saveIndex = comboBox_Ngay.SelectedIndex;
                    comboBox_Ngay.DataSource = Days29;
                }
                else
                {
                    if (comboBox_Ngay.SelectedIndex > 28)
                    {
                        comboBox_Ngay.SelectedIndex = 28;
                    }
                    saveIndex = comboBox_Ngay.SelectedIndex;
                    comboBox_Ngay.DataSource = Days28;
                }
                comboBox_Ngay.SelectedIndex = saveIndex;
                return;
            }
            bool is31Days = is31Day[comboBox_Thang.SelectedIndex];
            if (is31Days)
            {
                saveIndex = comboBox_Ngay.SelectedIndex;
                comboBox_Ngay.DataSource = Days31;
            }
            else
            {
                if (comboBox_Ngay.SelectedIndex > 30)
                {
                    comboBox_Ngay.SelectedIndex = 30;
                }
                saveIndex = comboBox_Ngay.SelectedIndex;
                comboBox_Ngay.DataSource = Days30;
            } 
            comboBox_Ngay.SelectedIndex = saveIndex;
        }

        private void textBox_Nam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_Nam_FocusLeave(object sender, EventArgs e)
        {
            if (textBox_Nam.Text == "")
            {
                textBox_Nam.Text = "0";
            }    
        }

        private void buttonCT_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0 || dataGridView1.SelectedRows[0].Index < 0)
            {
                MessageBox.Show("Bạn phải chọn một dòng để xem chi tiết phiếu!", "Thông báo");
                return;
            }    

            int index = dataGridView1.SelectedRows[0].Index;
            SuaPhieuDichVu ct_phieu = new SuaPhieuDichVu(Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value));
            ct_phieu.ShowDialog();
            Reload_DataGrid();
        }
    }
}
