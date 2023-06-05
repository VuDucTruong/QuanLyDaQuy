﻿using QuanLyDaQuy.DTO;
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
    public partial class PhieuDichVu : Form
    {
        private List<double>DonGiaDVs = new List<double>();
        private List<string> SDT = new List<string>();
        private List<int> MKH = new List<int>();
        double PhanTramTraTruocToiThieu = 0; 

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
                MKH.Add(Convert.ToInt32(row["MaKH"]));
                khachHangs.Items.Add(row["TenKH"]);
                SDT.Add(row["SDT"].ToString());
            }
            comboBox_KhachHang.DataSource = khachHangs.DataSource;

            // NgayLap
            textBox_NgayLap.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");

            // Select DichVu
            ComboBox dichVus = new ComboBox();
            DataTable data_dv = DAO.DataProvider.Instance.ExecuteQuery("select * from DICHVU");
            foreach (DataRow row in data_dv.Rows)
            {
                dichVus.Items.Add(row["TenDV"]);
                DonGiaDVs.Add((double)row["DonGiaDV"]);
            }           
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["TenDV"]).DataSource = dichVus.Items;

            // Select ThamSo
            DataTable ThamSo = DAO.DataProvider.Instance.ExecuteQuery("select GiaTri from THAMSO where TenThamSo = 'SoTienTraTruoc'");
            foreach (DataRow row in ThamSo.Rows)
            {
                PhanTramTraTruocToiThieu = Convert.ToDouble(row["GiaTri"]);
            }
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
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            if (rowIndex < 0 || columnIndex != 1)
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
            DataGridViewCell NgayGiao = row.Cells[8];
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
            if (NgayGiao.Value == null)
                NgayGiao.Value = DateTime.UtcNow.ToString("dd/MM/yyyy");
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Cell_Validating(sender, e);

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
                        // update TraTruoc
                        double minValue = (ThanhTien * PhanTramTraTruocToiThieu);
                        if (TraTruoc < minValue)
                        {
                            TraTruoc = minValue;
                            row.Cells[6].Value = TraTruoc;
                        }    
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

        private void button_Huy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            // Validating
            if (comboBox_KhachHang.SelectedIndex < 0
                || textBox_SDT.Text == "" || dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("Không được để trống các ô nội dung!", "Thông báo");
                return;
            }
            
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                bool testEmpty = false;
                // Dich vu
                if (row.Cells[1].Value == null || row.Cells[1].Value.ToString() == "")
                {
                    testEmpty = true;
                }    
                // TrangThai
                else if (row.Cells[9].Value == null || row.Cells[9].Value.ToString() == "")
                {
                    testEmpty = true;
                }    
                if (testEmpty)
                {
                    MessageBox.Show("Không được để trống các ô nội dung!", "Thông báo");
                    return;
                }    
            }

            // Finish validating
            DialogResult dialogResult = MessageBox.Show("Xin hãy kiểm tra kĩ nội dung trước khi lập phiếu." +
                                                       "\nBạn có chắc muốn lập phiếu này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    int maPhieuDV = Convert.ToInt32(textBox_SoPhieu.Text);
                    int maKH = MKH[comboBox_KhachHang.SelectedIndex];
                    DateTime ngayLap;
                    double tongTien = Convert.ToDouble(textBox_TongTien);
                    double traTruoc = Convert.ToDouble(textBox_TongTienTraTruoc);
                    double conLai = Convert.ToDouble(textBox_TongTienConLai);
                    string tinhTrang = "Hoàn thành";
                    DateTime.TryParseExact(textBox_NgayLap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayLap);

                    // check Tinh Trang
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[9].Value.ToString() != "Hoàn thành")
                        {
                            tinhTrang = "Chưa hoàn thành";
                            break;
                        }    
                    }

                    PhieuDichVuDTO ph = new PhieuDichVuDTO(maPhieuDV, maKH, ngayLap, tongTien, traTruoc, conLai, tinhTrang);
                    List<CT_PhieuDichVu> listCT = new List<CT_PhieuDichVu>();

                    DataTable table = dataGridView1.DataSource as DataTable;
                    foreach(DataRow row in table.Rows)
                    {
                        listCT.Add(new CT_PhieuDichVu(row));
                    }

                    ph.Perform_Insert();
                    foreach (CT_PhieuDichVu ct in listCT)
                    {
                        ct.Perform_Insert();
                    }    
                }
                catch (Exception error)
                {
                    MessageBox.Show("Lập phiếu thất bại." +
                                    " Lỗi: \n" + error.Message,"Thông báo");
                }
                finally
                {
                    MessageBox.Show("Lập phiếu thành công!", "Thông báo");
                    Close();
                }
            }    
        }

        #region SupportFunctions
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

        private void Cell_Validating(object sender, DataGridViewCellEventArgs e)
        {
            // Update new value
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            string fixValue = "";
            bool cancel = false;

            // Empty
            if (row.Cells[e.ColumnIndex].Value == null)
            {
                switch (e.ColumnIndex)
                {
                    // DonGiaDuocTinh
                    case 3:
                        {
                            fixValue = "0";
                            cancel = true;
                            break;
                        }
                    // SL changed
                    case 4:
                        {
                            fixValue = "0";
                            cancel = true;
                            break;
                        }
                    // Tra truoc changed          
                    case 6:
                        {
                            double ThanhTien = Convert.ToDouble(row.Cells[5].Value);
                            fixValue = (ThanhTien * PhanTramTraTruocToiThieu).ToString();
                            cancel = true;
                            break;
                        }
                    case 8:
                        {
                            fixValue = "";
                            cancel = true;
                            break;
                        }
                }
            }
            else
            {
                // Have value
                string value = row.Cells[e.ColumnIndex].Value.ToString();
                switch (e.ColumnIndex)
                {
                    // DonGiaDuocTinh
                    case 3:
                        {
                            if (Validating_NumberDouble(value))
                            {
                                double amount = Convert.ToDouble(value);
                                if (amount < 0)
                                {
                                    MessageBox.Show("Bạn không được nhập số nhỏ hơn 0 vào ô này!", "Cảnh báo");
                                    fixValue = "0";
                                    cancel = true;
                                }
                            }
                            else
                            {
                                fixValue = "0";
                                cancel = true;
                            }

                            break;
                        }
                    // SL changed
                    case 4:
                        {
                            if (Validating_NumberInt(value))
                            {
                                double amount = Convert.ToInt32(value);
                                if (amount < 0)
                                {
                                    MessageBox.Show("Bạn không được nhập số nhỏ hơn 0 vào ô này!", "Cảnh báo");
                                    fixValue = "0";
                                    cancel = true;
                                }
                            }
                            else
                            {
                                fixValue = "0";
                                cancel = true;
                            }

                            break;
                        }
                    // Tra truoc changed          
                    case 6:
                        {
                            double ThanhTien = Convert.ToDouble(row.Cells[5].Value);
                            double amount = Convert.ToDouble(value);
                            double Rate = PhanTramTraTruocToiThieu * 100;
                            if (Validating_NumberDouble(value))
                            {
                                if (amount < ThanhTien * PhanTramTraTruocToiThieu)
                                {
                                    MessageBox.Show("Số tiền trả trước phải lớn hơn "
                                        + Rate.ToString() + "% thành tiền!", "Cảnh báo");
                                    fixValue = (ThanhTien * PhanTramTraTruocToiThieu).ToString();
                                    cancel = true;
                                }
                            }
                            else
                            {
                                fixValue = (ThanhTien * PhanTramTraTruocToiThieu).ToString();
                                cancel = true;
                            }

                            break;
                        }
                    // Ngay gui
                    case 8:
                        {
                            if (!Validating_DateTime(value))
                            {
                                fixValue = DateTime.UtcNow.ToString("dd/MM/yyyy");
                                cancel = true;
                            }
                            else if (compare_DateTime(DateTime.UtcNow.ToString("dd/MM/yyyy"), value) == 1)
                            {
                                MessageBox.Show("Ngày giao hàng không thể nhỏ hơn ngày lập phiếu!", "Cảnh báo");
                                fixValue = DateTime.UtcNow.ToString("dd/MM/yyyy");
                                cancel = true;
                            }
                            break;
                        }
                }
            } 
                

            if (cancel)
            {
                row.Cells[e.ColumnIndex].Value = fixValue;
            }    
        }

        private bool Validating_NumberInt(string text)
        {
            try
            {
                int number = Convert.ToInt32(text);
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn phải nhập số nguyên vào ô này!", "Cảnh báo");
                return false;
            }
            return true;
        }

        private bool Validating_NumberDouble(string text)
        {
            try
            {
                Convert.ToDouble(text);
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn phải nhập số thực vào ô này!", "Cảnh báo");
                return false;
            }
            return true;
        }

        private bool Validating_DateTime(string date)
        {
            DateTime d;
            bool testDate = DateTime.TryParseExact(date, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
            if (!testDate)
            {
                MessageBox.Show("Bạn phải nhập ngày tháng năm theo format dd/MM/yyyy vào ô này!", "Cảnh báo");
            }    
            return testDate;
        }

        static public int compare_DateTime(string date1, string date2)
        {
            DateTime d1, d2;
            bool testDate = false;
            testDate = DateTime.TryParseExact(date1, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d1);
            if (!testDate)
            {
                // Wrong format at date1
                return -2;
            }
            testDate = DateTime.TryParseExact(date2, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d2);
            if (!testDate)
            {
                // Wrong format at date2
                return 2;
            }
            if (d1 < d2)
            {
                return -1;
            }
            else if (d1 > d2)
            {
                return 1;
            }
            return 0;
        }
        #endregion
    }
}
