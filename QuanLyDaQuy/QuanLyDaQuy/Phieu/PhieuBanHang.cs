using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyDaQuy.DTO;
using QuanLyDaQuy.DAO;

namespace QuanLyDaQuy.Phieu
{
    public partial class PhieuBanHang : Form
    {
        DataTable KHACHHANG = new DataTable();
        DataTable SANPHAM = new DataTable();
        long tongTien = 0;

        public PhieuBanHang()
        {
            InitializeComponent();
            AutoFillMaPBH();
            AutoFillNgayLap();
            LoadRelatedTables();
            LoadKhachHang();
            LoadSanPham();

        }

        private void LoadRelatedTables()
        {
            SANPHAM = DataProvider.Instance.ExecuteQuery("select * from SANPHAM");
            KHACHHANG = DataProvider.Instance.ExecuteQuery("select *  from KHACHHANG");

        }

        private void LoadSanPham()
        {
            try
            {
                // Tạo một DataGridViewComboBoxColumn trong DataGridView
                var comboBoxColumn = (DataGridViewComboBoxColumn)dgv_phieubanhang.Columns["sp_col"];

                comboBoxColumn.DropDownWidth = 500; // Thiết lập kích thước dropdown list là 300px (hoặc một giá trị phù hợp khác)

                // Gán nguồn dữ liệu cho ComboBox
                comboBoxColumn.DataSource = SANPHAM;
                comboBoxColumn.DisplayMember = "TenSP"; // tên cột hiển thị trong SANPHAM
                comboBoxColumn.ValueMember = "MaSP"; // tên cột giá trị trong SANPHAM
            }
            catch
            {

            }
        }

        private void LoadKhachHang()
        {
            try
            {
                // Lấy cột TenKH từ biến DataTable
                DataColumn column = KHACHHANG.Columns["TenKH"]; 

                // Lặp qua các hàng trong DataTable và thêm dữ liệu vào ComboBox
                foreach (DataRow row in KHACHHANG.Rows)
                {
                    string value = row[column].ToString(); 
                    cb_khachhang.Items.Add(value); 
                }
            }
            catch
            {
                cb_khachhang.Text = "Lỗi load dữ liệu";
            }

        }

        private void AutoFillNgayLap()
        {
            tb_ngaylap.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void AutoFillMaPBH()
        {
            int soPhieu = 0;
            try
            {
                soPhieu = (int)DataProvider.Instance.ExecuteScalar("select max(MaPhieuBH) from PHIEUBANHANG");
            }
            catch
            {
                soPhieu = 1;
            }
            finally
            {
                tb_sophieu.Text = soPhieu.ToString();
            }

        }

        private void cb_khachhang_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_sdt.Items.Clear();

            // Lấy mục được chọn trong ComboBox
            string selectedValue = cb_khachhang.SelectedItem.ToString();

            // Lấy cột TenKH từ biến DataTable
            DataColumn columnTenKH = KHACHHANG.Columns["TenKH"];
            DataColumn columnSDT = KHACHHANG.Columns["SDT"];

            // Lặp qua các hàng trong DataTable và thêm dữ liệu vào ComboBox
            foreach (DataRow row in KHACHHANG.Rows)
            {
                if (selectedValue == row[columnTenKH].ToString())
                {
                    string value = row[columnSDT].ToString();
                    cb_sdt.Items.Add(value);
                }
            }

        }

        private void dgv_phieubanhang_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            try
            {
                var dataGridView = sender as DataGridView;
                var rowNumber = (e.RowIndex + 1).ToString();

                // Lấy kích thước của số thứ tự
                var size = TextRenderer.MeasureText(rowNumber, dataGridView.RowHeadersDefaultCellStyle.Font);

                // Vẽ số thứ tự vào cột tiêu đề của dòng
                if (dataGridView.RowHeadersWidth < (size.Width + 20))
                {
                    dataGridView.RowHeadersWidth = size.Width + 20;
                }

                var center = (dataGridView.RowHeadersWidth - size.Width) / 2;
                e.Graphics.DrawString(rowNumber, dataGridView.RowHeadersDefaultCellStyle.Font, SystemBrushes.ControlText, e.RowBounds.Left + center, e.RowBounds.Top + 4);

            }
            catch
            {
                MessageBox.Show("Lỗi hàm dgv_phieubanhang_RowPostPaint");

            }
        }

        // đăng ký sự kiện SelectedIndexChanged cho ComboBox mỗi lần chọn sản phẩm
        private void dgv_phieubanhang_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                var dataGridView = sender as DataGridView;

                if (dataGridView.CurrentCell is DataGridViewComboBoxCell && e.Control is ComboBox)
                {
                    var comboBox = e.Control as ComboBox;
                    comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                    comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
                }

            }
            catch
            {
                // lỗi null sender hoặc e

                MessageBox.Show("Lỗi hàm dgv_phieubanhang_EditingControlShowing");
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var comboBox = sender as ComboBox;
                var selectedValue = comboBox.SelectedValue;
                if (selectedValue == null || !int.TryParse(selectedValue.ToString(), out int maSP))
                    return;

                string query = @"SELECT LSP.TenLSP, DVT.DVT,  SP.DonGiaBan
                FROM SANPHAM SP
                INNER JOIN LOAISANPHAM LSP ON SP.MaLSP = LSP.MaLSP
                INNER JOIN DONVITINH DVT ON LSP.MaDVT = DVT.MaDVT
                WHERE SP.MaSP = @MaSP";


                object[] parameters = new object[] { maSP };

                DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, parameters);

                // Lấy hàng đang được chọn trong DataGridView
                DataGridViewRow currentRow = dgv_phieubanhang.CurrentRow;

                // Lặp qua các cột trong DataGridView
                for (int i = 0; i < dgv_phieubanhang.Columns.Count; i++)
                {
                    string columnName = dgv_phieubanhang.Columns[i].DataPropertyName;

                    // Kiểm tra xem DataTable có chứa cột tương ứng hay không
                    if (dataTable.Columns.Contains(columnName))
                    {
                        // Lặp qua các dòng DataTable và gán dữ liệu vào các ô tương ứng trong DataGridView
                        for (int j = 0; j < dataTable.Rows.Count; j++)
                        {
                            object cellValue = dataTable.Rows[0][columnName]; // Lấy dữ liệu từ DataTable (chỉ lấy dữ liệu của hàng đầu tiên)
                            currentRow.Cells[i].Value = cellValue; // Gán dữ liệu vào ô tương ứng trong DataGridView
                        }
                    }
                }

            }
            catch
            {
                // lỗi khi thêm sản phẩm chỉ cập nhật giá trị hàng đầu
                MessageBox.Show("Lỗi hàm ComboBox_SelectedIndexChanged");
                return;

            }
        }

        private void dgv_phieubanhang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_phieubanhang.Columns.Contains("sl_col") && dgv_phieubanhang.Rows.Count > 0)
                {
                    // Kiểm tra xem có thay đổi trong cột "Số lượng" hay không
                    if (e.ColumnIndex == dgv_phieubanhang.Columns["sl_col"].Index)
                    {
                        // Lấy giá trị số lượng và đơn giá từ các ô tương ứng và tính toán thành tiền
                        foreach (DataGridViewRow row in dgv_phieubanhang.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                int soLuong = Convert.ToInt32(row.Cells["sl_col"].Value);
                                float donGia = Convert.ToSingle(row.Cells["dg_col"].Value);

                                // Tính toán giá trị thành tiền
                                float thanhTien = soLuong * donGia;

                                // Làm tròn giá trị thành tiền đến 2 chữ số thập phân
                                thanhTien = (float)Math.Round(thanhTien, 2);

                                // Gán giá trị thành tiền vào ô tương ứng
                                row.Cells["tt_col"].Value = (long)thanhTien;
                            }
                        }

                        // Tính tổng các dòng thành tiền và gán vào ô TextBox tổng tiền
                        foreach (DataGridViewRow row in dgv_phieubanhang.Rows)
                        {
                            if (!row.IsNewRow && row.Cells["tt_col"].Value != null)
                            {
                                float thanhTien = Convert.ToSingle(row.Cells["tt_col"].Value);
                                tongTien += (long)thanhTien;
                            }
                        }

                        tb_tongtien.Text = FormatNumberWithCommas(tongTien);
                    }

                }
            }
            catch
            {
                MessageBox.Show("Lỗi hàm dgv_phieubanhang_CellValueChanged");

            }
        }

        // Định dạng số thành chuỗi với dấu phân cách ","
        string FormatNumberWithCommas(float number)
        {
            return string.Format("{0:#,0}", number);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào đang được chọn hay không
            if (dgv_phieubanhang.SelectedRows.Count > 0)
            {
                // Lặp qua các hàng đang được chọn và xóa chúng
                foreach (DataGridViewRow row in dgv_phieubanhang.SelectedRows)
                {
                    // Kiểm tra nếu hàng đang được chọn không phải là hàng mới
                    if (!row.IsNewRow)
                    {
                        dgv_phieubanhang.Rows.Remove(row);
                    }
                }
            }
        }

        private void dgv_phieubanhang_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tongTien = 0;
            foreach (DataGridViewRow row in dgv_phieubanhang.Rows)
            {
                if (!row.IsNewRow && row.Cells["tt_col"].Value != null)
                {
                    long thanhTien = Convert.ToInt64(row.Cells["tt_col"].Value);
                    tongTien += thanhTien;
                }
            }

            tb_tongtien.Text = FormatNumberWithCommas(tongTien);
        }
    }
}