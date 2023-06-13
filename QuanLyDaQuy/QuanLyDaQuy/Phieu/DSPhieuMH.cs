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
            Init_DateTimeSearch();
            // TODO: This line of code loads data into the 'qLDQDataSet.loadPhieuMH_Full' table. You can move, or remove it, as needed.
            this.loadPhieuMH_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuMH_Full, 0, 0, 0);
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
                // TongTien
                case 3:
                    {
                        enableSearchBox = true;
                        break;
                    }
            }
            tb_Search.Enabled = enableSearchBox;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            int day = Convert.ToInt32(comboBox_Ngay.Text);
            int month = Convert.ToInt32(comboBox_Thang.Text);
            int year = Convert.ToInt32(textBox_Nam.Text);
            //all
            if (comboBox_SearchMode.SelectedIndex == 0)
            {
                dtgView_DS_phieu_mua_hang.DataSource = this.qLDQDataSet.loadPhieuMH_Full;
                this.loadPhieuMH_FullTableAdapter.Fill(this.qLDQDataSet.loadPhieuMH_Full, day, month, year);
                return;
            }
            else if (tb_Search.Text == "")
            {
                MessageBox.Show("Bạn hãy nhập thông tin cần tìm", "Cảnh báo");
                return;
            }
            switch (comboBox_SearchMode.SelectedIndex)
            {
                // MaPhieuMH
                case 1:
                    {
                        dtgView_DS_phieu_mua_hang.DataSource = this.qLDQDataSet.loadPhieuMH_byMaPhieuMH;
                        this.loadPhieuMH_byMaPhieuMHTableAdapter.Fill(this.qLDQDataSet.loadPhieuMH_byMaPhieuMH, Convert.ToInt32(tb_Search.Text), day, month, year);
                        break;
                    }
                // TenNCC
                case 2:
                    {
                        dtgView_DS_phieu_mua_hang.DataSource = this.qLDQDataSet.loadPhieuMH_byTenNCC;
                        this.loadPhieuMH_byTenNCCTableAdapter.Fill(this.qLDQDataSet.loadPhieuMH_byTenNCC, tb_Search.Text, day, month, year);
                        break;
                    }
                // TongTien
                case 3:
                    { 
                        dtgView_DS_phieu_mua_hang.DataSource = this.qLDQDataSet.loadPhieuMH_byTongTien;
                        this.loadPhieuMH_byTongTienTableAdapter.Fill(this.qLDQDataSet.loadPhieuMH_byTongTien, Convert.ToInt32(tb_Search.Text), day, month, year);
                        break;
                    }
            }
            if (dtgView_DS_phieu_mua_hang.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy kết quả!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Tra cứu thành công!", "Thông báo");
            }
        }
        private void Init_DateTimeSearch()
        {
            List<int> Days31 = new List<int>();
            List<int> Month12 = new List<int>();
            for (int i = 0; i <= 31; i++)
            {
                Days31.Add(i);
            }
            for (int i = 0; i <= 12; i++)
            {
                Month12.Add(i);
            }
            comboBox_Thang.DataSource = Month12;
            comboBox_Ngay.DataSource = Days31;


            textBox_Nam.Text = "0";
            comboBox_Thang.SelectedIndex = 0;
            comboBox_Ngay.SelectedIndex = 0;

            comboBox_Ngay.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Thang.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void comboBox_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (textBox_Nam.Text == null || textBox_Nam.Text == "")
            {
                return;
            }
            int thang = Convert.ToInt32(comboBox_Thang.Text);
            int nam = Convert.ToInt32(textBox_Nam.Text);
            List<int> ngay = new List<int>();
            int saveIndex = 0;
            if (thang == 0)
            {
                for (int i = 0; i <= 31; i++)
                {
                    ngay.Add(i);
                }
            }
            else
            {
                if (nam == 0)
                {
                    nam = 1;
                }
                for (int i = 0; i <= DateTime.DaysInMonth(nam, thang); i++)
                {
                    ngay.Add(i);
                }
            }
            comboBox_Ngay.DataSource = ngay;
            comboBox_Ngay.SelectedIndex = saveIndex;
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
            int MaPhieuMH = 0;
            try
            {
                MaPhieuMH = Convert.ToInt32(dtgView_DS_phieu_mua_hang.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bạn phải chọn một dòng để xem chi tiết phiếu!", "Cảnh báo");
                return;
            }
            DSPhieuMH_CT_PhieuMuaHang dSPhieuMH_CT_PhieuMuaHang = new DSPhieuMH_CT_PhieuMuaHang(MaPhieuMH);
            dSPhieuMH_CT_PhieuMuaHang.Show();
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
    }
}
