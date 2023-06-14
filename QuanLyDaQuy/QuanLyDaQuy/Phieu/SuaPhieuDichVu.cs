using iText.Layout.Element;
using QuanLyDaQuy.DAO;
using QuanLyDaQuy.DTO;
using QuanLyDaQuy.Export;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyDaQuy.Phieu
{
    public partial class SuaPhieuDichVu : Form
    {
        private int MaPhieuDV = 0;
        string tinhTrangPhieu = "";
        List<int> MaDVs = new List<int>();
        double PhanTramTraTruocToiThieu = 0;
        public SuaPhieuDichVu(int maPhieuDV)
        {
            InitializeComponent();
            MaPhieuDV = maPhieuDV;

        }

        private void PhieuDichVu_Load(object sender, EventArgs e)
        {
            textBox_SoPhieu.Text = MaPhieuDV.ToString();

            // Select PHIEUDICHVU dataTable
            DataTable data_phieu = SuaPhieuDichVuDAO.Instance.getPhieuDV_byMaPhieu(MaPhieuDV);
            foreach (DataRow row in data_phieu.Rows)
            {
                textBox_KhachHang.Text = row["TenKH"].ToString();
                textBox_SDT.Text = row["SDT"].ToString();
                textBox_TongTien.Text = row["TongTien"].ToString().Split(',')[0].Replace(".", "");
                textBox_TongTienTraTruoc.Text = row["TraTruoc"].ToString().Split(',')[0].Replace(".", "");
                textBox_TongTienConLai.Text = row["ConLai"].ToString().Split(',')[0].Replace(".", "");
                DateTime NgayLapPhieu;
                DateTime.TryParseExact(row["NgayLap"].ToString().Split(' ')[0], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out NgayLapPhieu);
                textBox_NgayLap.Text = NgayLapPhieu.ToString("dd/MM/yyyy");
                tinhTrangPhieu = row["TinhTrang"].ToString();
            }

            // Select CT_PHIEUDICHVU
            DataTable data_ct = SuaPhieuDichVuDAO.Instance.getCTPhieuDV_byMaPhieu(MaPhieuDV);
            int stt = 1;
            foreach (DataRow row in data_ct.Rows)
            {
                MaDVs.Add(Convert.ToInt32(row["MaDV"]));
                // tenDV
                string tenDV = row["TenDV"].ToString();
                string donGia = row["DonGia"].ToString().Split(',')[0].Replace(".", "");
                string donGiaDuocTinh = row["DonGiaDuocTinh"].ToString().Split(',')[0].Replace(".", "");
                string sl = row["SL"].ToString();
                string thanhTien = row["ThanhTien"].ToString().Split(',')[0].Replace(".", "");
                string traTruoc = row["TraTruoc"].ToString().Split(',')[0].Replace(".", "");
                string conLai = row["ConLai"].ToString().Split(',')[0].Replace(".", "");
                DateTime NgayGiao;
                DateTime.TryParseExact(row["NgayGiao"].ToString().Split(' ')[0], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out NgayGiao);
                string ngayGiao = NgayGiao.ToString("dd/MM/yyyy");
                string tinhTrang = row["TinhTrang"].ToString();
                dataGridView1.Rows.Add(stt, tenDV, donGia, donGiaDuocTinh, sl, thanhTien, traTruoc, conLai, ngayGiao, tinhTrang);
                stt++;
            }

            // Select ThamSo
            DataTable ThamSo = DAO.PhieuDichVuDAO.Instance.Get_SoTienTraTruoc();
            foreach (DataRow row in ThamSo.Rows)
            {
                PhanTramTraTruocToiThieu = Convert.ToDouble(row["GiaTri"]);
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is System.Windows.Forms.TextBox)
            {
                System.Windows.Forms.TextBox textBox = e.Control as System.Windows.Forms.TextBox;
                textBox.KeyPress -= new KeyPressEventHandler(CellNumber_KeyPress);
                textBox.KeyPress += new KeyPressEventHandler(CellNumber_KeyPress);
            }
        }

        private void CellNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            Cell_Validating(sender, e);


            if (e.RowIndex < 0)
                return;
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (row.IsNewRow || row.Cells[0].Value == null)
                return;
            switch (e.ColumnIndex)
            {
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
                case 9:
                    {
                        tinhTrangPhieu = "Hoàn thành";

                        // check Tinh Trang
                        foreach (DataGridViewRow r in dataGridView1.Rows)
                        {
                            if (r.IsNewRow || r.Cells[0].Value == null)
                                continue;
                            if (r.Cells[9].Value.ToString() != "Hoàn thành")
                            {
                                tinhTrangPhieu = "Chưa hoàn thành";
                                break;
                            }
                        }
                        break;
                    }
            }



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
                }
            }


            if (cancel)
            {
                row.Cells[e.ColumnIndex].Value = fixValue;
            }
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

        private void button_Huy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {

            // Finish validating
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn cập nhật phiếu này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    SuaPhieuDichVuDAO.Instance.updatePhieuDV(textBox_TongTienTraTruoc.Text, textBox_TongTienConLai.Text, tinhTrangPhieu, MaPhieuDV);
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        SuaPhieuDichVuDAO.Instance.updateCTPhieuDV(row, MaPhieuDV, MaDVs);
                    }    

                    MessageBox.Show("Cập nhật phiếu thành công!", "Thông báo");
                    Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Cập nhật phiếu thất bại." +
                                    " Lỗi: \n" + error.Message,"Thông báo");
                }
            }    
        }


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
        }

        private void exPDF_btn_Click(object sender, EventArgs e)
        {
            string STRcontent = String.Format("Số phiếu : {0} \n Khách hàng : {1} \n Ngày lập : {2} \n Số điện thoại : {3} \n  Tổng tiền : {4} \n Tổng tiền trả trước : {5} \n Còn lại : {6} \n"
                , textBox_SoPhieu.Text, textBox_KhachHang.Text , textBox_NgayLap.Text , textBox_SDT.Text , textBox_TongTien.Text , textBox_TongTienTraTruoc.Text , textBox_TongTienConLai.Text);
            Paragraph header = new Paragraph(label_Title.Text).SetFont(ExportPDF.GetUtf8Font());
            Paragraph content = new Paragraph(STRcontent).SetFont(ExportPDF.GetUtf8Font());
            if (ExportPDF.ExcuteDataGridView(header, content, dataGridView1))
            {
                MessageBox.Show("Xuất thành công !");
            }
        }
    }
}
