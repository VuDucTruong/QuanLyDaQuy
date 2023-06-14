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
using System.Globalization;
using iText.Layout.Element;
using QuanLyDaQuy.Export;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyDaQuy.Phieu
{
    public partial class PhieuBanHang : Form
    {
        DataTable KHACHHANG = new DataTable();
        DataTable SANPHAM = new DataTable();
        DataTable LOAISANPHAM = new DataTable();

        public PhieuBanHang()
        {
            InitializeComponent();
            AutoFillInfo();
            LoadRelatedTables();
            LoadKhachHangFull();
            LoadSanPhamFull();
        }


        private void AutoFillInfo()
        {
            // STT dòng đầu dgv
            dgv_phieubanhang.Rows[0].Cells[0].Value = 1;

            // Textbox số phiếu
            if (!int.TryParse(DataProvider.Instance.ExecuteScalar("select max(MaPhieuBH) from PHIEUBANHANG").ToString(),
                out int soPhieu))
            {
                soPhieu = 0;
            }
            tb_sophieu.Text = (soPhieu + 1).ToString();

            // Textbox ngày lập
            tb_ngaylap.Text = DateTime.Now.ToString("dd/MM/yyyy");

        }

        private void LoadRelatedTables()
        {
            SANPHAM = DataProvider.Instance.ExecuteQuery("select * from SANPHAM");
            KHACHHANG = DataProvider.Instance.ExecuteQuery("select *  from KHACHHANG");
            LOAISANPHAM = DataProvider.Instance.ExecuteQuery("select *  from LOAISANPHAM");

        }

        private void LoadSanPhamFull()
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
                MessageBox.Show("Lỗi load sản phẩm");

            }
        }

        private void LoadKhachHangFull()
        {
            try
            {
                cb_khachhang.Items.Clear();

                // Lấy cột TenKH từ biến DataTable
                DataColumn column = KHACHHANG.Columns["TenKH"]; 

                // Lặp qua các hàng trong DataTable và thêm dữ liệu vào ComboBox
                foreach (DataRow row in KHACHHANG.Rows)
                {
                    string value = row[column].ToString(); 
                    cb_khachhang.Items.Add(value); 
                }

                // Cấu hình combobox cho chức năng suggest và tự động hoàn thành
                cb_khachhang.DropDownStyle = ComboBoxStyle.DropDown;
                cb_khachhang.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cb_khachhang.AutoCompleteSource = AutoCompleteSource.ListItems;

            }
            catch
            {
                cb_khachhang.Text = "Lỗi load dữ liệu";
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
                    cb_sdt.Text = value;
                }
            }

            cb_sdt.DropDownStyle = ComboBoxStyle.DropDown;
            cb_sdt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cb_sdt.AutoCompleteSource = AutoCompleteSource.ListItems;

        }

        // đăng ký sự kiện SelectedIndexChanged cho ComboBox mỗi lần chọn sản phẩm
        private void dgv_phieubanhang_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                var dataGridView = sender as DataGridView;

                if (dataGridView.CurrentCell is DataGridViewComboBoxCell && e.Control is System.Windows.Forms.ComboBox)
                {
                    var comboBox = e.Control as System.Windows.Forms.ComboBox;

                    // Cấu hình combobox cho chức năng suggest và tự động hoàn thành
                    comboBox.DropDownStyle = ComboBoxStyle.DropDown;
                    comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;


                    comboBox.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);

                    // Chặn phím Tab trong ComboBox
                    comboBox.PreviewKeyDown += new PreviewKeyDownEventHandler(ComboBox_PreviewKeyDown);

                    // Them event Leave
                    comboBox.Leave += new EventHandler(ComboBox_Leave);
                }

            }
            catch
            {
                // lỗi null sender hoặc e
                MessageBox.Show("Lỗi hàm dgv_phieubanhang_EditingControlShowing");
            }
        }

        private void ComboBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.IsInputKey = true;
            }
        }

        private void ComboBox_Leave(object sender, EventArgs e)
        {
            System.Windows.Forms.ComboBox comboBox = sender as System.Windows.Forms.ComboBox;
            comboBox.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
            comboBox.PreviewKeyDown -= new PreviewKeyDownEventHandler(ComboBox_PreviewKeyDown);
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var comboBox = sender as System.Windows.Forms.ComboBox;
                var selectedValue = comboBox.SelectedValue;
                if (selectedValue == null || !int.TryParse(selectedValue.ToString(), out int maSP))
                    return;

                string tenSP = comboBox.Text;

                if (IsDuplicateProductSelected(tenSP))
                {
                    MessageBox.Show("Sản phẩm đã được chọn trước đó!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox.SelectedIndex = -1; // Xóa chọn sản phẩm trong ComboBox
                    return;
                }

                string query = @"SELECT LSP.TenLSP, DVT.DVT,  SP.DonGiaBan
                FROM SANPHAM SP
                INNER JOIN LOAISANPHAM LSP ON SP.MaLSP = LSP.MaLSP
                INNER JOIN DONVITINH DVT ON LSP.MaDVT = DVT.MaDVT
                WHERE SP.MaSP = @MaSP";

                object[] parameters = new object[] { maSP };

                // Lấy cột loại sp, dvt & đơn giá để autofill sau khi chọn sản phẩm
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

                SendKeys.Send("{ENTER}");

                //currentRow.Cells["sl_col"].Selected = true;
            }
            catch
            {
                // lỗi khi thêm sản phẩm chỉ cập nhật giá trị hàng đầu
                MessageBox.Show("Lỗi hàm ComboBox_SelectedIndexChanged");
                return;

            }
        }

        private bool IsDuplicateProductSelected(string tenSP)
        {
            foreach (DataGridViewRow row in dgv_phieubanhang.Rows)
            {
                if (!row.IsNewRow)
                {
                    var cellValue = row.Cells["sp_col"].FormattedValue;
                    if (cellValue != null && cellValue.ToString() == tenSP)
                    {
                        return true; // Tồn tại sản phẩm trùng
                    }
                }
            }
            return false; // Không có sản phẩm trùng
        }


        private void dgv_phieubanhang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!dgv_phieubanhang.Columns.Contains("sl_col") || dgv_phieubanhang.Rows.Count == 0)
                    return;

                // Kiểm tra xem có thay đổi trong cột "Số lượng" hay không
                if (e.ColumnIndex != dgv_phieubanhang.Columns["sl_col"].Index)
                    return;

                // Lấy dòng hiện tại từ DataGridView
                DataGridViewRow currentRow = dgv_phieubanhang.Rows[e.RowIndex];
                if (currentRow.IsNewRow)
                    return;

                int soLuong = 0;
                object slValue = currentRow.Cells["sl_col"].Value;
                if (slValue == null || !int.TryParse(slValue.ToString(), out soLuong) || soLuong < 0)
                {
                    currentRow.Cells["sl_col"].Value = 0;
                }
                else
                {
                    // Lấy "Tên sản phẩm"
                    string tenSP = currentRow.Cells["sp_col"].FormattedValue.ToString();

                    // Kiểm tra số lượng tồn trong cơ sở dữ liệu
                    int soLuongTon = GetSoLuongTonFromDatabase(tenSP);

                    if (soLuong > soLuongTon)
                    {
                        // Số lượng nhập vào vượt quá số lượng tồn
                        MessageBox.Show("Số lượng tồn không đủ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        currentRow.Cells["sl_col"].Value = soLuongTon;
                        soLuong = soLuongTon;
                    }

                    float donGia = Convert.ToSingle(currentRow.Cells["dg_col"].Value);
                    float thanhTien = soLuong * donGia;
                    thanhTien = (float)Math.Round(thanhTien, 2);
                    currentRow.Cells["tt_col"].Value = (long)thanhTien;
                }

                long tongTien = 0;
                // Tính tổng các dòng thành tiền và gán vào ô TextBox tổng tiền
                foreach (DataGridViewRow row in dgv_phieubanhang.Rows)
                {
                    if (!row.IsNewRow && row.Cells["tt_col"].Value != null)
                    {
                        float thanhTien = Convert.ToSingle(row.Cells["tt_col"].Value);
                        tongTien += (long)thanhTien;
                    }
                }

                tb_tongtien.Text = tongTien.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi hàm dgv_phieubanhang_CellValueChanged");
            }
        }

        private int GetSoLuongTonFromDatabase(string tenSP)
        {
            int soLuongTon = 0;
            string query = "SELECT SoLuongTon FROM SANPHAM WHERE TenSP = @tenSP";
            object[] parameters = { tenSP };

            var slt = DataProvider.Instance.ExecuteScalar(query, parameters);
            if (slt == null || !int.TryParse(slt.ToString(), out soLuongTon))
                MessageBox.Show("Lỗi lấy số lượng tồn");

            return soLuongTon;
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
            long tongTien = 0;

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

            tb_tongtien.Text = tongTien.ToString();
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
                MessageBox.Show("Số điện thoại không hợp lệ! Cần nhập đủ 10 ký tự và bắt đầu bằng 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Xin hãy kiểm tra kĩ nội dung trước khi lập phiếu." +
                                           "\nBạn có chắc muốn lập phiếu này không?", "Thông báo", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No)
                    return;

                    // Lấy tất cả thông tin
                    string tenKH = cb_khachhang.Text;
                if (string.IsNullOrEmpty(tenKH))
                {
                    MessageBox.Show("Tên khách hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string sdt = cb_sdt.Text;
                if (!IsValidPhoneNumber(sdt))
                {
                    MessageBox.Show("Số điện thoại cần đủ 10 ký tự và bắt đầu bằng 0", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string ngayLap = tb_ngaylap.Text;

                if (!float.TryParse(tb_tongtien.Text, out float tongTien))
                    return;

                if (!int.TryParse(tb_sophieu.Text, out int maPhieuBH))
                    return;

                int maKH = FindMaKhachHang(tenKH, sdt);

                // Thêm khách hàng nếu chưa tồn tại trong csdl
                if (maKH == -1)
                {
                    maKH = InsertKhachHang(tenKH, sdt);
                    if (maKH == -1)
                    {
                        MessageBox.Show("Lỗi thêm khách hàng!");
                        return;
                    }

                }

                // Thêm phiếu bán hàng
                if (IsDataGridViewEmpty(dgv_phieubanhang))
                {
                    MessageBox.Show("Dữ liệu trống, xin hãy chọn sản phẩm!");
                    return;
                }
                else
                    AddPhieuBanHang(maKH, ngayLap, tongTien);

                // Duyệt qua từng dòng trong DataGridView
                List<DataGridViewRow> rows = dgv_phieubanhang.Rows.Cast<DataGridViewRow>().ToList();
                foreach (DataGridViewRow row in rows)
                {
                    // Nếu đã duyệt hết các hàng của bảng thì reload lại thành form mới
                    if (row.IsNewRow)
                    {
                        this.Close();
                        return;
                    }

                    // Lấy thông tin sản phẩm từ dòng hiện tại
                    int maSP = Convert.ToInt32(row.Cells["sp_col"].Value);
                    int soLuong = Convert.ToInt32(row.Cells["sl_col"].Value);
                    float donGia = Convert.ToSingle(row.Cells["dg_col"].Value);
                    float thanhTien = Convert.ToSingle(row.Cells["tt_col"].Value);

                    // Cập nhật thuộc tính SoLuongTon trong bảng Sản phẩm
                    UpdateSLT(maSP, soLuong);

                    // Thêm chi tiết phiếu bán hàng vào bảng CT_PHIEUBANHANG
                    AddCTPhieuBanHang(maPhieuBH, maSP, soLuong, donGia, thanhTien);

                }

            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        bool IsDataGridViewEmpty(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count == 0)
                return true;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (!row.IsNewRow)
                    return false;
            }

            return true;
        }

        private int FindMaKhachHang(string tenKH, string sdt)
        {
            int maKH = -1;

            string query = "SELECT MaKH FROM KHACHHANG WHERE TenKH = @tenKH AND SDT = @soDT";
            object[] parameters = { tenKH, sdt };

            var result = DataProvider.Instance.ExecuteScalar(query, parameters);
            if (result != null && int.TryParse(result.ToString(), out maKH))
            {
                return maKH;
            }

            return -1;
        }

        private void AddCTPhieuBanHang(int maPhieuBH, int maSP, int soLuong, float donGia, float thanhTien)
        {
            try
            {
                // Thêm chi tiết phiếu bán hàng vào cơ sở dữ liệu
                string insertQuery = $"INSERT INTO CT_PHIEUBANHANG (MaPhieuBH, MaSP, SL, DonGia, ThanhTien) VALUES ( {maPhieuBH}, {maSP}, {soLuong}, {donGia}, {thanhTien} )";

                object[] parameters = { maPhieuBH, maSP, soLuong, donGia, thanhTien };

                int affectedRows = DataProvider.Instance.ExecuteNonQuery(insertQuery);

                if (affectedRows <= 0)
                    MessageBox.Show($"Lỗi thêm chi tiết phiếu bán hàng ở sản phẩm có mã {maSP}!");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Lỗi thêm chi tiết phiếu bán hàng: {ex.Message}");
            }
        }

        private void AddPhieuBanHang(int maKH, string ngayLap, float tongTien)
        {
            try
            {
                DateTime ngayLapDateTime = DateTime.ParseExact(ngayLap, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string ngayLapFormatted = ngayLapDateTime.ToString("MM/dd/yyyy");

                string query = "insert into PHIEUBANHANG " +
                "( MaKH , NgayLap , TongTien ) values" +
                $"({maKH},'{ngayLapFormatted}',{tongTien})";

                int affectedRows = DataProvider.Instance.ExecuteNonQuery(query);
                MessageBox.Show($"Thêm thành công phiếu bán hàng");

            }
            catch
            {
                MessageBox.Show("Lỗi thêm PBH");
            }
        }

        private void UpdateSLT(int maSP, int soLuong)
        {
            string updateQuery = $"UPDATE SANPHAM SET SoLuongTon = SoLuongTon - {soLuong} WHERE MaSP = {maSP}";

            int affectedRows = DataProvider.Instance.ExecuteNonQuery(updateQuery);

            if (affectedRows <= 0)
                MessageBox.Show($"Lỗi cập nhật số lượng tồn sản phẩm có mã {maSP}");

        }

        private int InsertKhachHang(string tenKH, string sdt)
        {
            try
            {
                // Thêm thông tin khách hàng vào cơ sở dữ liệu
                string insertQuery = $"INSERT INTO KHACHHANG (TenKH, SDT) VALUES ( '{tenKH}', '{sdt}' ); SELECT SCOPE_IDENTITY();";

                object result = DataProvider.Instance.ExecuteScalar(insertQuery);

                if (result != null)
                {
                    int maKH = Convert.ToInt32(result);
                    MessageBox.Show($"Thêm khách hàng thành công");
                    return maKH;
                }

                MessageBox.Show($"Không thể lấy mã khách hàng");
                return -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm khách hàng: {ex.Message}");
                return -1;
            }
        }

        private void ReloadForm()
        {
            AutoFillInfo();
            LoadRelatedTables();
            LoadKhachHangFull();
            LoadSanPhamFull();

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
                MessageBox.Show("Tên khách hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhieuBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult result = MessageBox.Show("Bạn có chắc muốn đóng form?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.No)
            //{
            //    e.Cancel = true; // Hủy sự kiện đóng form nếu người dùng chọn "No"
            //}

        }

        private void dgv_phieubanhang_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if (e.ColumnIndex == dgv_phieubanhang.Columns["sp_col"].Index)
            //{
            //    dgv_phieubanhang.Columns["sp_col"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            //    dgv_phieubanhang.Columns["sp_col"].Width = 300;
            //}
        }

        private void dgv_phieubanhang_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == dgv_phieubanhang.Columns["sp_col"].Index)
            //{
            //    dgv_phieubanhang.Columns["sp_col"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //}
        }

        private void dgv_phieubanhang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
    {
        e.Handled = true; // Ngăn chặn sự kiện Tab mặc định của DataGridView

        MessageBox.Show("Vui lòng nhấn nút Enter để tiếp tục.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
        }

        private void dgv_phieubanhang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                DataGridView dataGridView = sender as DataGridView;
                if (dataGridView.CurrentCell is DataGridViewComboBoxCell)
                {
                    DataGridViewComboBoxCell comboBoxCell = dataGridView.CurrentCell as DataGridViewComboBoxCell;
                    comboBoxCell.Value = comboBoxCell.FormattedValue;
                }
            }
        }

        private void btn_XuatPDF_Click(object sender, EventArgs e)
        {
            string STRcontent = String.Format("Số phiếu : {0} \n", tb_sophieu.Text) +
                String.Format("Ngày lập : {0} \n", tb_ngaylap.Text) +
                String.Format("Khách hàng : {0} \n", cb_khachhang.Text) +
                String.Format("Số điện thoại : {0} \n", cb_sdt.Text) +
                String.Format("Tổng tiền : {0} ", tb_tongtien.Text);
            Paragraph header = new Paragraph(lb_title.Text).SetFont(ExportPDF.GetUtf8Font());
            Paragraph content = new Paragraph(STRcontent).SetFont(ExportPDF.GetUtf8Font());
            if (ExportPDF.ExcuteDataGridView(header, content, dgv_phieubanhang))
            {
                MessageBox.Show("Xuất thành công !");
            }
        }

        private void dgv_phieubanhang_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //dgv_phieubanhang.Rows.Remove(e.RowIndex);
            //dgv_phieubanhang.Rows[e.RowIndex].Cells[1].Value = "";
            //dgv_phieubanhang.Rows[e.RowIndex].Cells[2].Value = "";
            //dgv_phieubanhang.Rows[e.RowIndex].Cells[4].Value = "";
            //dgv_phieubanhang.Rows[e.RowIndex].Cells[5].Value = 0;
            ////e.Cancel = true;
            //dgv_phieubanhang.CurrentCell = dgv_phieubanhang.Rows[e.RowIndex].Cells["sl_col"];
            //MessageBox.Show("Giá trị không hợp lệ!");

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
}