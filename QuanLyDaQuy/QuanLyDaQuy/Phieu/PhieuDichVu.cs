using QuanLyDaQuy.DTO;
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
    public partial class PhieuDichVu : Form
    {
        private List<double>DonGiaDVs = new List<double>();
        private List<string> SDT = new List<string>();

        public PhieuDichVu()
        {
            InitializeComponent();
        }

        private void PhieuDichVu_Load(object sender, EventArgs e)
        {
            // Select ID
            DataTable latestID = DAO.DataProvider.Instance.ExecuteQuery("select TOP(1) MaPhieuDV from PHIEUDICHVU");
            int id = 0;
            foreach (DataRow row in latestID.Rows)
            {
                id = (int)row["MaPhieuDV"];
            }
            id++;
            textBox_SoPhieu.Text = id.ToString();

            // Select KhachHang
            ComboBox khachHangs = new ComboBox();
            DataTable data_kh = DAO.DataProvider.Instance.ExecuteQuery("select * from KHACHHANG");
            foreach (DataRow row in data_kh.Rows)
            {
                khachHangs.Items.Add(row["TenKH"]);
                SDT.Add(row["SDT"].ToString());
            }
            comboBox_KhachHang.DataSource = khachHangs.DataSource;

            // Select DichVu
            ComboBox dichVus = new ComboBox();
            DataTable data_dv = DAO.DataProvider.Instance.ExecuteQuery("select * from DICHVU");
            foreach (DataRow row in data_dv.Rows)
            {
                dichVus.Items.Add(row["TenDV"]);
                DonGiaDVs.Add((double)row["DonGiaDV"]);
            }           
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["TenDV"]).DataSource = dichVus.Items;
        }

        private void KhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ((ComboBox)sender).SelectedIndex;
            if (index == -1)
            {
                textBox_SDT.Text = "";
            }
            else
            {
                textBox_SDT.Text = SDT[index];
            }               
        }
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 1 && e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;

                // Add eventHandler
                comboBox.SelectedIndexChanged -= new EventHandler(CellDichVu_SelectedIndexChanged);
                comboBox.SelectedIndexChanged += new EventHandler(CellDichVu_SelectedIndexChanged);
            }
        }
        private void CellDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            // triggered cell
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            if (rowIndex < 0)
                return;
            DataGridViewCell DonGia = dataGridView1.Rows[rowIndex].Cells[2];
            DataGridViewCell DonGiaDuocTinh = dataGridView1.Rows[rowIndex].Cells[3];
            // Modified value
            if (comboBox.SelectedIndex == -1)
            {
                DonGia.Value = 0;
            }
            else
            {
                DonGia.Value = DonGiaDVs[comboBox.SelectedIndex];
                DonGiaDuocTinh.Value = DonGiaDVs[comboBox.SelectedIndex];
            }


        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            DataGridViewCell stt = row.Cells[0];
            DataGridViewCell DonGiaDV = row.Cells[2];
            DataGridViewCell DonGiaDuocTinh = row.Cells[3];
            DataGridViewCell SL = row.Cells[4];
            DataGridViewCell ThanhTien = row.Cells[5];
            DataGridViewCell TraTruoc = row.Cells[6];
            DataGridViewCell ConLai = row.Cells[7];
            if (stt != null)
            {
                stt.Value = stt.RowIndex + 1;
            }
            if (DonGiaDV.Value == null)
                DonGiaDV.Value = 0;
            DonGiaDuocTinh.Value = Convert.ToDouble(DonGiaDV.Value);
            if (SL.Value == null)
                SL.Value = 0;
            ThanhTien.Value = Convert.ToDouble(SL.Value) * Convert.ToDouble(DonGiaDuocTinh.Value);
            TraTruoc.Value = 0;
            ConLai.Value = Convert.ToDouble(ThanhTien.Value) - Convert.ToDouble(TraTruoc.Value);
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            // Update new value
            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            switch (e.ColumnIndex)
            {
                // DonGiaDuocTinh changed
                case 3:
                    {
                        double SL = Convert.ToDouble(row.Cells[4].Value);
                        double DonGiaDuocTinh = Convert.ToDouble(row.Cells[3].Value);
                        // update ThanhTien
                        row.Cells[5].Value = DonGiaDuocTinh * SL;
                        TinhTongTien();
                        break;
                    }
                // SL changed
                case 4:
                    {
                        double SL = Convert.ToDouble(row.Cells[4].Value);
                        double DonGiaDuocTinh = Convert.ToDouble(row.Cells[3].Value);
                        // update ThanhTien
                        row.Cells[5].Value = DonGiaDuocTinh * SL;
                        TinhTongTien();
                        break;
                    }
                // ThanhTien changed
                case 5:
                    {
                        double TraTruoc = Convert.ToDouble(row.Cells[6].Value);
                        double ThanhTien = Convert.ToDouble(row.Cells[5].Value);
                        // update ConLai
                        row.Cells[7].Value = ThanhTien - TraTruoc;
                        TinhTongTien();
                        TinhTongTienConLai();
                        break;
                    }
                // Tra truoc changed          
                case 6:
                    {
                        double TraTruoc = Convert.ToDouble(row.Cells[6].Value);
                        double ThanhTien = Convert.ToDouble(row.Cells[5].Value);
                        // update ConLai
                        row.Cells[7].Value = ThanhTien - TraTruoc;
                        TinhTongTienConLai();
                        TinhTongTienTraTruoc();
                        break;
                    }
            }
        }

        // Support Functions
        private void TinhTongTien()
        {
            double TongTien = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                TongTien += Convert.ToDouble(row.Cells[5].Value);
            }
            textBox_TongTien.Text = TongTien.ToString();
        }

        private void TinhTongTienTraTruoc()
        {
            double TongTienTraTruoc = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                TongTienTraTruoc += Convert.ToDouble(row.Cells[6].Value);
            }
            textBox_TongTienTraTruoc.Text = TongTienTraTruoc.ToString();
        }

        private void TinhTongTienConLai()
        {
            double TongTienConLai = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                TongTienConLai += Convert.ToDouble(row.Cells[7].Value);
            }
            textBox_TongTienConLai.Text = TongTienConLai.ToString();
        }

        private void button_Huy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
