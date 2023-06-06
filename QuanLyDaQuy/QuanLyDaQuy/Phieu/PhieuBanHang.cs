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
using System.Text.RegularExpressions;

namespace QuanLyDaQuy.Phieu
{
    public partial class PhieuBanHang : Form
    {
<<<<<<< HEAD
        DataTable KHACHHANG = new DataTable();
        DataTable SANPHAM = new DataTable();
=======
>>>>>>> parent of 533b904 (loading related data after choosing SanPham)

        public PhieuBanHang()
        {
            InitializeComponent();


            AutoFillMaPBH();
            AutoFillNgayLap();
<<<<<<< HEAD
            AutoFillInfo();

            LoadRelatedTables();
            LoadKhachHang();
            LoadSanPham();

        }

        private void AutoFillInfo()
        {
            // STT dòng đầu dgv
            dgv_phieubanhang.Rows[0].Cells[0].Value = 1;

            // Textbox số phiếu
            if (!int.TryParse(DataProvider.Instance.ExecuteScalar("select max(MaPhieuBH) from PHIEUBANHANG").ToString(),
                out int soPhieu))
            {
                soPhieu = 1;
            }
            tb_sophieu.Text = soPhieu.ToString();

            // Textbox ngày lập
            tb_ngaylap.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void LoadRelatedTables()
        {
            SANPHAM = DataProvider.Instance.ExecuteQuery("select * from SANPHAM");
            KHACHHANG = DataProvider.Instance.ExecuteQuery("select *  from KHACHHANG");

=======
            LoadKhachHang();
            LoadSanPham();
>>>>>>> parent of 533b904 (loading related data after choosing SanPham)
        }

        private void LoadSanPham()
        {

        }

        private void LoadKhachHang()
        {
            // load data from KHACHHANG
            try
            {

            }
            catch
            {

            }

            cb_khachhang.Text = "TriPero";
        }

        private void AutoFillNgayLap()
        {
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
<<<<<<< HEAD

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
            //try
            //{
            //    var dataGridView = sender as DataGridView;
            //    var rowNumber = (e.RowIndex + 1).ToString();

            //    // Lấy kích thước của số thứ tự
            //    var size = TextRenderer.MeasureText(rowNumber, dataGridView.RowHeadersDefaultCellStyle.Font);

            //    // Vẽ số thứ tự vào cột tiêu đề của dòng
            //    if (dataGridView.RowHeadersWidth < (size.Width + 20))
            //    {
            //        dataGridView.RowHeadersWidth = size.Width + 20;
            //    }

            //    var center = (dataGridView.RowHeadersWidth - size.Width) / 2;
            //    e.Graphics.DrawString(rowNumber, dataGridView.RowHeadersDefaultCellStyle.Font, SystemBrushes.ControlText, e.RowBounds.Left + center, e.RowBounds.Top + 4);

            //}
            //catch
            //{
            //    MessageBox.Show("Lỗi hàm dgv_phieubanhang_RowPostPaint");

            //}
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

                // Gán số lượng & thành tiền mặc định bằng 0
                currentRow.Cells["sl_col"].Value = 0;
                currentRow.Cells["tt_col"].Value = 0;

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
                                int soLuong = 0;

                                // Lấy giá trị số lượng
                                object slValue = row.Cells["sl_col"].Value;
                                if (slValue == null 
                                    || !int.TryParse(slValue.ToString(), out soLuong)
                                    || soLuong < 0)
                                {
                                    row.Cells["sl_col"].Value = 0;
                                }

                                // Lấy giá trị đơn giá
                                float donGia = Convert.ToSingle(row.Cells["dg_col"].Value);

                                // Tính toán giá trị thành tiền
                                float thanhTien = soLuong * donGia;

                                // Làm tròn giá trị thành tiền đến 2 chữ số thập phân
                                thanhTien = (float)Math.Round(thanhTien, 2);

                                // Gán giá trị thành tiền vào ô tương ứng
                                row.Cells["tt_col"].Value = (long)thanhTien;
                            }
                        }

                        float tongTien = 0;
                        // Tính tổng các dòng thành tiền và gán vào ô TextBox tổng tiền
                        foreach (DataGridViewRow row in dgv_phieubanhang.Rows)
                        {
                            if (!row.IsNewRow && row.Cells["tt_col"].Value != null)
                            {
                                float thanhTien = Convert.ToSingle(row.Cells["tt_col"].Value);
                                tongTien += thanhTien;
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
            // Kiểm tra xem có cell nào đang được chọn hay không
            if (dgv_phieubanhang.SelectedCells.Count > 0)
            {
                // Lấy cell đầu tiên được chọn
                DataGridViewCell selectedCell = dgv_phieubanhang.SelectedCells[0];

                // Lấy hàng chứa cell đó
                DataGridViewRow selectedRow = selectedCell.OwningRow;

                // Kiểm tra nếu hàng không phải là hàng mới
                if (!selectedRow.IsNewRow)
                {
                    // Xóa hàng
                    dgv_phieubanhang.Rows.Remove(selectedRow);
                }
            }

        }

        private void dgv_phieubanhang_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            float tongTien = 0;

            // Cập nhật lại giá trị của cột STT cho tất cả các hàng
            for (int i = 0; i < dgv_phieubanhang.Rows.Count; i++)
            {
                dgv_phieubanhang.Rows[i].Cells[0].Value = i + 1;
            }

            // Tính tổng tiền từ các hàng còn lại
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

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            // Kiểm tra độ dài số điện thoại (ví dụ: 10 chữ số)
            if (phoneNumber.Length != 10)
            {
                return false;
            }

            // Kiểm tra các ký tự trong số điện thoại (chỉ chấp nhận số từ 0 đến 9)
            foreach (char c in phoneNumber)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }

            // Kiểm tra định dạng số điện thoại (ví dụ: theo một mẫu nhất định)
            string pattern = @"^(0\d{9})$"; // Mẫu kiểm tra: số bắt đầu bằng 0, sau đó là 9 chữ số (tổng cộng 10 chữ số)
            if (!Regex.IsMatch(phoneNumber, pattern))
            {
                return false;
            }

            // Số điện thoại hợp lệ
            return true;
        }

        private void cb_sdt_Leave(object sender, EventArgs e)
        {
            // Kiểm tra hợp lệ của số điện thoại nhập vào
            string phoneNumber = cb_sdt.Text;

            // Thực hiện kiểm tra và xử lý tùy theo yêu cầu

            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string tenKhachHang = cb_khachhang.Text;
            string sdt = cb_sdt.Text;
            string ngayLap = tb_ngaylap.Text;

            if(!float.TryParse(tb_tongtien.Text, out float tongtien))
                return;

            if (!int.TryParse(tb_sophieu.Text, out int maPhieuBH))
                return;

            InsertKhachHang(tenKhachHang, sdt);

            // Duyệt qua từng dòng trong DataGridView
            List<DataGridViewRow> rows = dgv_phieubanhang.Rows.Cast<DataGridViewRow>().ToList();
            foreach (DataGridViewRow row in rows)
            {
                if (row.IsNewRow)
                    return;

                    // Lấy thông tin sản phẩm từ dòng hiện tại
                    string tenSP = row.Cells["sp_col"].Value.ToString();
                int soLuong = Convert.ToInt32(row.Cells["sl_col"].Value);
                float donGia = Convert.ToSingle(row.Cells["dg_col"].Value);
                float thanhTien = Convert.ToSingle(row.Cells["tt_col"].Value);

                // Cập nhật thuộc tính SoLuongTon trong bảng Sản phẩm
                // Thực hiện truy vấn SQL hoặc gọi hàm để cập nhật giá trị SoLuongTon

                // Thêm chi tiết phiếu bán hàng vào bảng CT_PHIEUBANHANG
                // Thực hiện truy vấn SQL hoặc gọi hàm để thêm chi tiết phiếu bán hàng
            }

            UpdateSLT();
            //AddPhieuMuaHang();
            ReloadForm();

        }

        private void AddPhieuMuaHang()
        {
            throw new NotImplementedException();
        }

        private void UpdateSLT()
        {
            string updateSoLuongTonQuery = "UPDATE SANPHAM SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaSP = @MaSP";

            //// Lấy thông tin sản phẩm từ DataGridView
            //int maSP = // Lấy mã sản phẩm từ dòng hiện tại
            //int soLuong = // Lấy số lượng từ cột số lượng hoặc điểm cần lấy

            //object[] updateSoLuongTonParams = new object[] { soLuong, maSP };

            //int rowCount = ExecuteNonQuery(updateSoLuongTonQuery, updateSoLuongTonParams);
        }

        private void InsertKhachHang(string tenKH, string sdt)
        {

            string query = "SELECT COUNT(*) FROM KHACHHANG WHERE TenKH = @TenKhachHang AND SDT = @SoDienThoai";
            object[] parameters = new object[] { tenKH, sdt };
            string[] parameterNames = new string[] { "@TenKhachHang", "@SoDienThoai" };

            int rowCount;
            if (int.TryParse(DataProvider.Instance.ExecuteScalar(query, parameters).ToString(), out rowCount))
            {
                // Kiểm tra giá trị rowCount để xác định xem khách hàng đã tồn tại hay chưa
                if (rowCount == 0)
                {
                    // Thêm thông tin khách hàng vào cơ sở dữ liệu
                    string insertQuery = "INSERT INTO KHACHHANG (TenKH, SDT) VALUES (@TenKhachHang, @SoDienThoai)";

                    // Thay thế các tham số trong câu truy vấn bằng giá trị tương ứng
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        insertQuery = insertQuery.Replace(parameterNames[i], "'" + parameters[i].ToString() + "'");
                    }

                    int affectedRows = DataProvider.Instance.ExecuteNonQuery(insertQuery);
                    MessageBox.Show($"{affectedRows} khách hàng mới đã được thêm");
                }
            }
            else
            {
                // Xử lý khi không thể chuyển đổi giá trị rowCount thành kiểu int
                MessageBox.Show("Lỗi ép kiểu dữ liệu trả về sau khi truy vấn CSDL");

            }
        }

        private void ReloadForm()
        {
            AutoFillMaPBH();
            AutoFillNgayLap();
            LoadRelatedTables();
            LoadKhachHang();
            LoadSanPham();

            tb_tongtien.Text = "0";
            dgv_phieubanhang.Rows.Clear();
            this.Refresh();
        }

        private void dgv_phieubanhang_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            dgv_phieubanhang.Rows[e.RowIndex].Cells[0].Value = e.RowIndex + 1;
        }

        private void cb_khachhang_Leave(object sender, EventArgs e)
        {
            string ten = cb_khachhang.Text;

            if (string.IsNullOrEmpty(ten))
            {
                MessageBox.Show("Tên khách hàng không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

=======
>>>>>>> parent of 533b904 (loading related data after choosing SanPham)
    }
}