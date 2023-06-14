using iText.Layout.Element;
using QuanLyDaQuy.DTO;
using QuanLyDaQuy.Export;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaQuy.Phieu
{
    public partial class PhieuDichVu : Form
    {
        private List<double>DonGiaDVs = new List<double>();
        private List<string> SDT = new List<string>();
        private List<int> MKH = new List<int>();
        private List<int> MaDVs = new List<int>();
        private List<int> SavedMaDVs = new List<int>();
        double PhanTramTraTruocToiThieu = 0;
        bool firstInitComboBoxCell = true;
        private bool Init_CellSelectedIndex = false;

        public PhieuDichVu()
        {
            InitializeComponent();
        }

        private void PhieuDichVu_Load(object sender, EventArgs e)
        {
            // Select ID
            DataTable latestID = DAO.PhieuDichVuDAO.Instance.GetNew_MaPhieuDV();
            int id = 0;
            foreach (DataRow row in latestID.Rows)
            {
                id = (int)row["MaPhieuDV"];
            }
            id++;
            textBox_SoPhieu.Text = id.ToString();

            // Select KhachHang
            ComboBox khachHangs = new ComboBox();
            DataTable data_kh = DAO.PhieuDichVuDAO.Instance.GetAll_KhachHang();
            foreach (DataRow row in data_kh.Rows)
            {
                MKH.Add(Convert.ToInt32(row["MaKH"]));
                khachHangs.Items.Add(row["TenKH"].ToString());
                SDT.Add(row["SDT"].ToString());
            }
            comboBox_KhachHang.DataSource = khachHangs.Items;

            // NgayLap
            textBox_NgayLap.Text = DateTime.UtcNow.ToString("dd/MM/yyyy");

            // Select DichVu
            ComboBox dichVus = new ComboBox();
            DataTable data_dv = DAO.PhieuDichVuDAO.Instance.GetAll_DichVu();
            foreach (DataRow row in data_dv.Rows)
            {
                dichVus.Items.Add(row["TenDV"]);
                DonGiaDVs.Add((double)row["DonGiaDV"]);
                MaDVs.Add((int)row["MaDV"]);
            }           
            ((DataGridViewComboBoxColumn)dataGridView1.Columns["TenDV"]).DataSource = dichVus.Items;

            // Select ThamSo
            DataTable ThamSo = DAO.PhieuDichVuDAO.Instance.Get_SoTienTraTruoc();
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
                comboBox.SelectedIndexChanged += new EventHandler(CellDichVu_SelectedIndexChanged);
                comboBox.Leave += new EventHandler(CellDichVu_Leave);
            }
            else if (e.Control is TextBox)
            {
                TextBox textBox = e.Control as TextBox;
                if (dataGridView1.CurrentCell.ColumnIndex != 8)
                {
                    textBox.KeyPress -= new KeyPressEventHandler(CellNumber_KeyPress);
                    textBox.KeyPress += new KeyPressEventHandler(CellNumber_KeyPress);
                }
                else
                {
                    textBox.KeyPress -= new KeyPressEventHandler(CellDateTime_KeyPress);
                    textBox.KeyPress += new KeyPressEventHandler(CellDateTime_KeyPress);
                } 
                    
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
                if (rowIndex > SavedMaDVs.Count - 1)
                {
                    SavedMaDVs.Add(MaDVs[comboBox.SelectedIndex]);
                }
                else
                {
                    SavedMaDVs[rowIndex] = MaDVs[comboBox.SelectedIndex];
                } 
                    
                DonGia.Value = DonGiaDVs[comboBox.SelectedIndex];
                DonGiaDuocTinh.Value = DonGiaDVs[comboBox.SelectedIndex];
            }
        }

        private void CellDichVu_Leave(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            comboBox.SelectedIndexChanged -= new EventHandler(CellDichVu_SelectedIndexChanged);
        }

        private void CellNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CellDateTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)&& e.KeyChar != '/' && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
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
            if (row.IsNewRow || row.Cells[0].Value == null)
                return;
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
                            TraTruoc = Math.Round(minValue);
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
                if (row.IsNewRow || row.Cells[0].Value == null)
                    continue;
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
                    double tongTien = Convert.ToDouble(textBox_TongTien.Text);
                    double traTruoc = Convert.ToDouble(textBox_TongTienTraTruoc.Text);
                    double conLai = Convert.ToDouble(textBox_TongTienConLai.Text);
                    string tinhTrang = "Hoàn thành";
                    DateTime.TryParseExact(textBox_NgayLap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayLap);

                    // check Tinh Trang
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow || row.Cells[0].Value == null)
                            continue;
                        if (row.Cells[9].Value.ToString() != "Hoàn thành")
                        {
                            tinhTrang = "Chưa hoàn thành";
                            break;
                        }
                    }

                    PhieuDichVuDTO ph = new PhieuDichVuDTO(maPhieuDV, maKH, ngayLap, tongTien, traTruoc, conLai, tinhTrang);
                    List<CT_PhieuDichVu> listCT = new List<CT_PhieuDichVu>();

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.IsNewRow || row.Cells[0].Value == null)
                            continue;
                        int MaPhieuDV = Convert.ToInt32(textBox_SoPhieu.Text);
                        int MaDV = SavedMaDVs[row.Index];
                        double DonGia = Convert.ToDouble(row.Cells[2].Value);
                        double DonGiaDuocTinh = Convert.ToDouble(row.Cells[3].Value);
                        int SL = Convert.ToInt32(row.Cells[4].Value);
                        double ThanhTien = Convert.ToDouble(row.Cells[5].Value);
                        double TraTruoc = Convert.ToDouble(row.Cells[6].Value);
                        double ConLai = Convert.ToDouble(row.Cells[7].Value);
                        DateTime NgayGiao;
                        DateTime.TryParseExact(row.Cells[8].Value.ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out NgayGiao);
                        string TinhTrang = row.Cells[9].Value.ToString();
                        listCT.Add(new CT_PhieuDichVu(MaPhieuDV, MaDV, DonGia, DonGiaDuocTinh, SL, ThanhTien, TraTruoc, ConLai, NgayGiao, TinhTrang));
                    }

                    ph.Perform_Insert();
                    foreach (CT_PhieuDichVu ct in listCT)
                    {
                        ct.Perform_Insert();
                    }

                    MessageBox.Show("Lập phiếu thành công!", "Thông báo");
                    Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Lập phiếu thất bại." +
                                    " Lỗi: \n" + error.Message,"Thông báo");
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

        private void button_XoaDong_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.SelectedRows[0]);
            // Rearrange STT
            int stt = 1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow)
                {
                    row.Cells[0].Value = stt;
                    stt++;
                }
            }
                
        }

        private void dataGridView1_FocusLeave(object sender, EventArgs e)
        {
            //button_XoaDong.Enabled = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Cells[0].Value != null)
            {
                button_XoaDong.Enabled = true;
            }
            else
            {
                button_XoaDong.Enabled = false;
            }

        }

        private void btn_XuatPDF_Click(object sender, EventArgs e)
        {
            string STRcontent = String.Format("Số phiếu : {0} \n", textBox_SoPhieu.Text) +
                String.Format("Ngày lập : {0} \n", textBox_NgayLap.Text) +
                String.Format("Khách hàng : {0} \n", comboBox_KhachHang.Text) +
                String.Format("Số điện thoại : {0} \n", textBox_SDT.Text) +
                String.Format("Tổng tiền : {0} Tổng tiền trả trước : {1} Tổng tiền còn lại : {2}", textBox_TongTien.Text, textBox_TongTienTraTruoc.Text, textBox_TongTienConLai.Text);
            Paragraph header = new Paragraph(label_Title.Text).SetFont(ExportPDF.GetUtf8Font());
            Paragraph content = new Paragraph(STRcontent).SetFont(ExportPDF.GetUtf8Font());
            if (ExportPDF.ExcuteDataGridView(header, content, dataGridView1))
            {
                MessageBox.Show("Xuất thành công !");
            }
        }
    }
}
