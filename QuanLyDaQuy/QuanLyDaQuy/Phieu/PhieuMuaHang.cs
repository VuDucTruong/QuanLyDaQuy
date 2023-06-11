using QuanLyDaQuy.DAO;
using QuanLyDaQuy.DTO;
using QuanLyDaQuy.QLDQDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyDaQuy.Phieu
{
    public partial class PhieuMuaHang : Form
    {
        private List<LoaiSanPham> loaiSanPhams = null;
        private List<SanPham> sanPhams = null;
        private List<DonViTinh> donViTinhs = null;
        private List<NhaCungCap> NhaCungCaps = null;
        public PhieuMuaHang()
        {
            InitializeComponent();
            autoFillInfo();
            loadDataFromServer();
            loadDatatoViewSource();
        }

        private void btn_lapPhieu_Click(object sender, EventArgs e)
        {
            // Validating
            if (cb_nhaCungCap.SelectedIndex < 0
                || tb_ngaylap.Text == "" || dt_grid_phieumuahang.Rows.Count <= 0)
            {
                MessageBox.Show("Không được để trống các ô nội dung!", "Thông báo");
                return;
            }

            foreach (DataGridViewRow row in dt_grid_phieumuahang.Rows)
            {
                if (row.Index == dt_grid_phieumuahang.Rows.Count - 1)
                    continue;
                bool testEmpty = false;
                // San Pham
                if (row.Cells[1].Value == null || row.Cells[1].Value.ToString() == "")
                {
                    testEmpty = true;
                }
                // So luong
                else if (row.Cells[3].Value == null || row.Cells[3].Value.ToString() == "")
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
                    //Phieu mua hang
                    int maPhieuMH = Convert.ToInt32(tb_sophieu.Text);
                    int maNCC = NhaCungCaps.FirstOrDefault(x => x.TenNCC == cb_nhaCungCap.Text).MaNCC;
                    DateTime ngayLap;
                    DateTime.TryParseExact(tb_ngaylap.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngayLap); ;
                    double tongTien = Convert.ToDouble(tb_thanhTien.Text);
                    PhieuMuaHangDTO phieuMuaHang = new PhieuMuaHangDTO(maPhieuMH, maNCC, ngayLap, tongTien);

                    //CT_PhieuMuaHang
                    List<CT_PhieuMuaHang> ct_phieuMuaHangs = new List<CT_PhieuMuaHang>();
                    foreach (DataGridViewRow row in dt_grid_phieumuahang.Rows)
                    {
                        if (row.Index == dt_grid_phieumuahang.Rows.Count - 1)
                        {
                            continue;
                        }
                        int MaPhieuMH = Convert.ToInt32(tb_sophieu.Text);
                        int MaSP = sanPhams.FirstOrDefault(x => x.TenSP == row.Cells[1].Value.ToString()).MaSP;
                        int SL = Convert.ToInt32(row.Cells[3].Value);
                        double DonGia = Convert.ToInt32(row.Cells[5].Value);
                        double ThanhTien = Convert.ToInt32(row.Cells[6].Value);
                        ct_phieuMuaHangs.Add(new CT_PhieuMuaHang(MaPhieuMH, MaSP, SL, DonGia, ThanhTien));
                    }

                    //Insert
                    phieuMuaHang.Perform_Insert();
                    foreach (CT_PhieuMuaHang item in ct_phieuMuaHangs)
                    {
                        item.Perform_Insert();
                    }

                    MessageBox.Show("Lập phiếu thành công!", "Thông báo");
                    Close();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Lập phiếu thất bại." +
                                                        " Lỗi: \n" + error.Message, "Thông báo");
                }
            }
        }
        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dt_grid_phieumuahang_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var cb = e.Control as DataGridViewComboBoxEditingControl;
            if (cb != null)
            {
                cb.DropDownStyle = ComboBoxStyle.DropDown;
                cb.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb.AutoCompleteSource = AutoCompleteSource.ListItems;
            }

        }

        private void autoFillInfo()
        {
            dt_grid_phieumuahang.Rows[0].Cells[0].Value = 1;
            DateTime dt = DateTime.Today;
            tb_ngaylap.Text = dt.ToString("dd/MM/yyyy");
            int soPhieu = 0;
            try
            {
                soPhieu = Convert.ToInt32(DataProvider.Instance.ExecuteQuery("Select MAX(MaPhieuMH) " +
                    "From PHIEUMUAHANG"));
            }
            catch (Exception e)
            {
                soPhieu = 1;
            }
            tb_sophieu.Text = soPhieu.ToString();

            //foreach (DataGridViewColumn col in dt_grid_phieumuahang.Columns)
            //{
            //    col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //}
        }

        private void loadDataFromServer()
        {
            loaiSanPhams = new List<LoaiSanPham>();
            sanPhams = new List<SanPham>();
            donViTinhs = new List<DonViTinh>();
            NhaCungCaps = new List<NhaCungCap>();


            DataTable data = DataProvider.Instance.ExecuteQuery("Select * From LOAISANPHAM");
            foreach (DataRow item in data.Rows)
            {
                LoaiSanPham loaiSanPham = new LoaiSanPham(item);
                loaiSanPhams.Add(loaiSanPham);
            }

            data = DataProvider.Instance.ExecuteQuery("Select * From SANPHAM");
            foreach (DataRow item in data.Rows)
            {
                SanPham sanPham = new SanPham(item);
                sanPhams.Add(sanPham);
            }

            data = DataProvider.Instance.ExecuteQuery("Select * From DONVITINH");
            foreach (DataRow item in data.Rows)
            {
                DonViTinh donViTinh = new DonViTinh(item);
                donViTinhs.Add(donViTinh);
            }

            data = DataProvider.Instance.ExecuteQuery("Select * From NHACUNGCAP");
            foreach (DataRow item in data.Rows)
            {
                NhaCungCap nhaCungCap = new NhaCungCap(item);
                NhaCungCaps.Add(nhaCungCap);
            }
        }
        private void loadDatatoViewSource()
        {
            foreach (LoaiSanPham loaiSanPham in loaiSanPhams)
            {
                phieuMuaHang_column_loaiSanPham.Items.Add(loaiSanPham.TenLSP);
            }
            foreach (NhaCungCap nhaCungCap in NhaCungCaps)
            {
                cb_nhaCungCap.Items.Add(nhaCungCap.TenNCC);
            }
            foreach (SanPham sanPham in sanPhams)
            {
                phieuMuaHang_column_sanPham.Items.Add(sanPham.TenSP);
            }
        }

        private void dt_grid_phieumuahang_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Error happened " + e.Context.ToString());
            dt_grid_phieumuahang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
            e.Cancel = true;
        }

        private void dt_grid_phieumuahang_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (dt_grid_phieumuahang.Rows[e.RowIndex].Cells[2].Value != null)
                {
                    //Update items cb_sanpham
                    string tenLSP = dt_grid_phieumuahang.Rows[e.RowIndex].Cells[2].Value.ToString();
                    LoaiSanPham loaiSanPham = loaiSanPhams.FirstOrDefault(x => x.TenLSP == tenLSP);
                    List<SanPham> sanPhamByTenLSP = sanPhams.Where<SanPham>(x => x.MaLSP == loaiSanPham.MaLSP).ToList();
                    (dt_grid_phieumuahang.Rows[e.RowIndex].Cells[1] as DataGridViewComboBoxCell).Items.Clear();
                    foreach (SanPham sanPham in sanPhamByTenLSP)
                    {
                        (dt_grid_phieumuahang.Rows[e.RowIndex].Cells[1] as DataGridViewComboBoxCell).Items.Add(sanPham.TenSP);
                    }
                }
                else
                {
                    (dt_grid_phieumuahang.Rows[e.RowIndex].Cells[1] as DataGridViewComboBoxCell).Items.Clear();
                    foreach (SanPham sanPham in sanPhams)
                    {
                        (dt_grid_phieumuahang.Rows[e.RowIndex].Cells[1] as DataGridViewComboBoxCell).Items.Add(sanPham.TenSP);
                    }
                }
            }
        }

        private void dt_grid_phieumuahang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dt_grid_phieumuahang.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void dt_grid_phieumuahang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Choose San pham
            if (e.ColumnIndex == 1)
            {
                if (dt_grid_phieumuahang.Rows[e.RowIndex].Cells[1].Value == null)
                {
                    return;
                }
                string tenSP = dt_grid_phieumuahang.Rows[e.RowIndex].Cells[1].Value.ToString();
                SanPham sanPham = sanPhams.FirstOrDefault(x => x.TenSP == tenSP);
                //Update don gia mua
                dt_grid_phieumuahang.Rows[e.RowIndex].Cells[5].Value = sanPham.DonGiaMua;

                //Update loai san pham + DVT
                string tenLSP = loaiSanPhams.FirstOrDefault(x => x.MaLSP == sanPham.MaLSP).TenLSP;
                dt_grid_phieumuahang.Rows[e.RowIndex].Cells[2].Value = tenLSP;
                updateDonViTinh(tenLSP, e.RowIndex);
            }

            //Choose loai san pham
            if (e.ColumnIndex == 2)
            {
                if (dt_grid_phieumuahang.Rows[e.RowIndex].Cells[2].Value == null)
                {
                    return;
                }
                string tenLSP = dt_grid_phieumuahang.Rows[e.RowIndex].Cells[2].Value.ToString();
                //Update don vi tinh
                updateDonViTinh(tenLSP, e.RowIndex);
                //Xoa san pham
                dt_grid_phieumuahang.Rows[e.RowIndex].Cells[1].Value = null;
                //Xoa don gia
                dt_grid_phieumuahang.Rows[e.RowIndex].Cells[5].Value = null;
            }
            //So luong inputed
            if (dt_grid_phieumuahang.Rows[e.RowIndex].Cells[3].Value != null)
            {
                //Validating so luong
                if (!Validating_NumberInt(dt_grid_phieumuahang.Rows[e.RowIndex].Cells[3].Value.ToString()))
                {
                    dt_grid_phieumuahang.Rows[e.RowIndex].Cells[3].Value = null;
                    return;
                }
                //Calculating thanh tien
                if (dt_grid_phieumuahang.Rows[e.RowIndex].Cells[1].Value != null)
                {
                    dt_grid_phieumuahang.Rows[e.RowIndex].Cells[6].Value =
                        Convert.ToInt32(dt_grid_phieumuahang.Rows[e.RowIndex].Cells[3].Value)
                        * Convert.ToInt32(dt_grid_phieumuahang.Rows[e.RowIndex].Cells[5].Value);
                    int sum = 0;
                    for (int i = 0; i < dt_grid_phieumuahang.Rows.Count; ++i)
                    {
                        sum += Convert.ToInt32(dt_grid_phieumuahang.Rows[i].Cells[6].Value);
                    }
                    tb_thanhTien.Text = sum.ToString();
                }
            }
        }

        private void updateDonViTinh(string tenLSP, int RowIndex)
        {
            LoaiSanPham loaiSanPham = loaiSanPhams.FirstOrDefault(x => x.TenLSP == tenLSP);
            DonViTinh donViTinh = donViTinhs.FirstOrDefault(x => x.MaDVT == loaiSanPham.MaDVT);
            dt_grid_phieumuahang.Rows[RowIndex].Cells[4].Value = donViTinh.DVT;
        }

        private void btn_xoaDong_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem có hàng nào đang được chọn hay không
            if (dt_grid_phieumuahang.SelectedRows.Count > 0)
            {
                // Lặp qua các hàng đang được chọn và xóa chúng
                foreach (DataGridViewRow row in dt_grid_phieumuahang.SelectedRows)
                {
                    // Kiểm tra nếu hàng đang được chọn không phải là hàng mới
                    if (!row.IsNewRow)
                    {
                        dt_grid_phieumuahang.Rows.Remove(row);
                    }
                }
            }

            foreach (DataGridViewRow dataRow in dt_grid_phieumuahang.Rows)
            {
                dataRow.Cells[0].Value = dataRow.Index + 1;
            }
        }

        private void btn_add_ncc_Click(object sender, EventArgs e)
        {
            ThemNCCForm themNCC = new ThemNCCForm();
            themNCC.ShowDialog();
            refreshComboBoxNhaCungCaps();
        }

        private void cb_nhaCungCap_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_diachi.Text = NhaCungCaps.Where(i => i.TenNCC == cb_nhaCungCap.Text).FirstOrDefault().DiaChi;
            tb_sodienthoai.Text = NhaCungCaps.Where(i => i.TenNCC == cb_nhaCungCap.Text).FirstOrDefault().SDT;
        }

        private void refreshComboBoxNhaCungCaps()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * From NHACUNGCAP");
            NhaCungCaps.Clear();
            foreach (DataRow item in data.Rows)
            {
                NhaCungCap nhaCungCap = new NhaCungCap(item);
                NhaCungCaps.Add(nhaCungCap);
            }
            cb_nhaCungCap.Items.Clear();
            foreach (NhaCungCap nhaCungCap in NhaCungCaps)
            {
                cb_nhaCungCap.Items.Add(nhaCungCap.TenNCC);
            }
        }
        private void Cell_Validating(object sender, DataGridViewCellEventArgs e)
        {
            // Update new value
            if (e.RowIndex < 0)
                return;

            DataGridViewRow row = dt_grid_phieumuahang.Rows[e.RowIndex];

            string fixValue = "";
            bool cancel = false;

            // Empty
            if (row.Cells[e.ColumnIndex].Value == null)
            {
                //So luong
                if (e.ColumnIndex == 3)
                {
                    fixValue = "0";
                    cancel = true;
                }
            }
            else
            {
                // Have value
                string value = row.Cells[e.ColumnIndex].Value.ToString();
                if (e.ColumnIndex == 3)
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
        private void dt_grid_phieumuahang_SelectionChanged(object sender, EventArgs e)
        {
            if (dt_grid_phieumuahang.SelectedRows.Count > 0 &&
                !dt_grid_phieumuahang.SelectedRows.Contains(dt_grid_phieumuahang.Rows[dt_grid_phieumuahang.Rows.Count - 1]))
            {
                btn_xoaDong.Enabled = true;
            }
            else
            {
                btn_xoaDong.Enabled = false;
            }
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
        private void tb_ngaylap_Leave(object sender, EventArgs e)
        {
            if (!Validating_DateTime(tb_ngaylap.Text))
            {
                tb_ngaylap.Text = DateTime.Today.ToString("dd/MM/yyyy");
            }
        }
    }
}
