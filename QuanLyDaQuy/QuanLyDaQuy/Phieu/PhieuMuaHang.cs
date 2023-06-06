using QuanLyDaQuy.DAO;
using QuanLyDaQuy.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (String.IsNullOrEmpty(tb_sophieu.Text) && String.IsNullOrEmpty(tb_ngaylap.Text) && String.IsNullOrEmpty(tb_nhacungcap.Text) &&
                String.IsNullOrEmpty(tb_diachi.Text) && String.IsNullOrEmpty(tb_sodienthoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin phiếu mua hàng");
                return;
            }
            else
            {
                foreach (DataGridViewRow rw in this.dt_grid_phieumuahang.Rows)
                {
                    for (int i = 0; i < rw.Cells.Count; i++)
                    {
                        if (rw.Cells[i].Value == null || rw.Cells[i].Value == DBNull.Value || String.IsNullOrWhiteSpace(rw.Cells[i].Value.ToString()))
                        {
                            MessageBox.Show("Vui lòng nhập đầy đủ thông tin sản phẩm");
                            return;
                        }
                    }
                }
            }
            MessageBox.Show("Ok! :V");
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
            tb_ngaylap.Text = dt.ToString();
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

            //data = DataProvider.Instance.ExecuteQuery("Select * From NHACUNGCAP");
            //foreach (DataRow item in data.Rows)
            //{
            //    NhaCungCap nhaCungCap = new NhaCungCap(item);
            //    NhaCungCaps.Add(nhaCungCap);
            //}
        }
        private void loadDatatoViewSource()
        {
            foreach (LoaiSanPham loaiSanPham in loaiSanPhams)
            {
                phieuMuaHang_column_loaiSanPham.Items.Add(loaiSanPham.TenLSP);
            }
        }

        private void dt_grid_phieumuahang_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Giá trị không hợp lệ!");
        }

        private void dt_grid_phieumuahang_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                if (dt_grid_phieumuahang.Rows[e.RowIndex].Cells[2].Value == null)
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm!");
                }
                else
                {
                    phieuMuaHang_column_sanPham.Items.Clear();
                    List<SanPham> listSanPham = findSanPhambyTenLSP(dt_grid_phieumuahang.Rows[e.RowIndex].Cells[2].Value.ToString());
                    foreach (SanPham sanPham in listSanPham)
                    {
                        phieuMuaHang_column_sanPham.Items.Add(sanPham.TenSP);
                    }
                }
            }
        }
        private List<SanPham> findSanPhambyTenLSP(String tenLSP)
        {
            List<SanPham> listsanPhams = new List<SanPham>();
            LoaiSanPham loaiSanPham = null;
            foreach (LoaiSanPham item in loaiSanPhams)
            {
                if (item.TenLSP == tenLSP)
                {
                    loaiSanPham = item;
                    break;
                }
            }
            foreach (SanPham item in sanPhams)
            {
                if (item.MaLSP == loaiSanPham.MaLSP)
                {
                    listsanPhams.Add(item);
                }
            }
            return listsanPhams;
        }

        private void dt_grid_phieumuahang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dt_grid_phieumuahang.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void dt_grid_phieumuahang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string tenSP = dt_grid_phieumuahang.Rows[e.RowIndex].Cells[1].Value.ToString();
                foreach (SanPham item in sanPhams)
                {
                    if (tenSP == item.TenSP)
                    {
                        dt_grid_phieumuahang.Rows[e.RowIndex].Cells[5].Value = item.DonGiaMua;
                        break;
                    }
                }
            }
            if (e.ColumnIndex == 2)
            {
                string tenLSP = dt_grid_phieumuahang.Rows[e.RowIndex].Cells[2].Value.ToString();
                foreach (LoaiSanPham item in loaiSanPhams)
                {
                    if (tenLSP == item.TenLSP)
                    {
                        int maDVT = item.MaDVT;
                        foreach (DonViTinh donViTinh in donViTinhs)
                        {
                            if (maDVT == donViTinh.MaDVT)
                            {
                                dt_grid_phieumuahang.Rows[e.RowIndex].Cells[4].Value = donViTinh.DVT;
                                break;
                            }
                        }
                        break;
                    }
                }
            }
            if (dt_grid_phieumuahang.Rows[e.RowIndex].Cells[3].Value != null)
            {
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

        }
    }
}
