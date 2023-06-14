using QuanLyDaQuy.DAO;
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
    public partial class DsPhieuBH : Form
    {
        public DsPhieuBH()
        {
            InitializeComponent();
        }

        private void DsPhieuBH_Load(object sender, EventArgs e)
        {
            try
            {
                cbb_searchMode.SelectedIndex = 0;

                string query = "SELECT PBH.MaPhieuBH, PBH.MaKH, KH.TenKH, KH.SDT, PBH.NgayLap, FORMAT(PBH.TongTien,'c', 'vi-VN') as TongTien " +
                               "FROM PHIEUBANHANG PBH " +
                               "JOIN KHACHHANG KH ON PBH.MaKH = KH.MaKH";

                DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);

                dgv_ds_pbh.DataSource = dataTable;

                // Gọi hàm AddRowNumbers để thêm cột STT vào DataTable
                //AddRowNumbers(dataTable, "STT");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void AddRowNumbers(DataTable dataTable, string columnName)
        {
            // Thêm cột số thứ tự vào DataTable
            dataTable.Columns.Add(columnName, typeof(int));

            // Đánh số thứ tự cho mỗi dòng trong DataTable
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i][columnName] = i + 1;
            }

            dgv_ds_pbh.DataSource = dataTable;
            dgv_ds_pbh.Columns["STT"].Width = 50;
            dgv_ds_pbh.Columns["STT"].DisplayIndex = 0;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                int searchOption = cbb_searchMode.SelectedIndex;
                string keyword = tb_keyWord.Text.Trim();
                string query = "";
                bool hasDay = false;
                bool hasMonth = false;
                bool hasYear = false;
                int day = 0, month = 0, year = 0;

                switch (searchOption)
                {
                    case 0: // Tất cả
                        query = "SELECT PBH.MaPhieuBH, PBH.MaKH, KH.TenKH, KH.SDT, PBH.NgayLap, FORMAT(PBH.TongTien,'c', 'vi-VN') as TongTien " +
                                       "FROM PHIEUBANHANG PBH " +
                                       "JOIN KHACHHANG KH ON PBH.MaKH = KH.MaKH";
                        break;

                    case 1: // Mã phiếu
                        query = "SELECT p.MaPhieuBH, p.MaKH, k.TenKH, k.SDT, p.NgayLap, FORMAT(p.TongTien,'c', 'vi-VN') as TongTien FROM PHIEUBANHANG p INNER JOIN KHACHHANG k ON p.MaKH = k.MaKH WHERE p.MaPhieuBH = @Keyword";
                        break;
                    case 2: // Mã khách hàng
                        query = "SELECT p.MaPhieuBH, p.MaKH, k.TenKH, k.SDT, p.NgayLap, FORMAT(p.TongTien,'c', 'vi-VN') as TongTien FROM PHIEUBANHANG p INNER JOIN KHACHHANG k ON p.MaKH = k.MaKH WHERE p.MaKH = @Keyword";
                        break;
                    case 3: // Tên khách hàng
                        query = "SELECT p.MaPhieuBH, p.MaKH, k.TenKH, k.SDT, p.NgayLap, FORMAT(p.TongTien,'c', 'vi-VN') as TongTien FROM PHIEUBANHANG p INNER JOIN KHACHHANG k ON p.MaKH = k.MaKH WHERE k.TenKH LIKE '%' + @Keyword + '%'";
                        break;
                    case 4: // Số điện thoại
                        query = "SELECT p.MaPhieuBH, p.MaKH, k.TenKH, k.SDT, p.NgayLap, FORMAT(p.TongTien,'c', 'vi-VN') as TongTien FROM PHIEUBANHANG p INNER JOIN KHACHHANG k ON p.MaKH = k.MaKH WHERE k.SDT LIKE '%' + @Keyword + '%'";
                        break;
                    case 5: // Ngày lập
                        {
                            // Kiểm tra xem người dùng đã nhập các ô ngày, tháng và năm hay chưa
                            hasDay = !string.IsNullOrEmpty(tb_day.Text.Trim());
                            hasMonth = !string.IsNullOrEmpty(tb_month.Text.Trim());
                            hasYear = !string.IsNullOrEmpty(tb_year.Text.Trim());

                            // Xử lý các trường hợp nhập các ô ngày, tháng và năm
                            if (hasDay && hasMonth && hasYear)
                            {
                                // Người dùng đã nhập cả ngày, tháng và năm
                                if (!int.TryParse(tb_day.Text, out day) || day < 1 || day > 31)
                                {
                                    MessageBox.Show("Ngày không hợp lệ.");
                                    return;
                                }

                                if (!int.TryParse(tb_month.Text, out month) || month < 1 || month > 12)
                                {
                                    MessageBox.Show("Tháng không hợp lệ.");
                                    return;
                                }

                                if (!int.TryParse(tb_year.Text, out year) || year < 1900 || year > 2100)
                                {
                                    MessageBox.Show("Năm không hợp lệ.");
                                    return;
                                }

                                // Kiểm tra ngày tháng hợp lệ
                                if (!IsValidDate(day, month, year))
                                {
                                    MessageBox.Show("Ngày không hợp lệ.");
                                    return;
                                }

                                query = "SELECT p.MaPhieuBH, p.MaKH, k.TenKH, k.SDT, p.NgayLap, FORMAT(p.TongTien,'c', 'vi-VN') as TongTien " +
                                        "FROM PHIEUBANHANG p " +
                                        "INNER JOIN KHACHHANG k ON p.MaKH = k.MaKH " +
                                        "WHERE YEAR(p.NgayLap) = @Year AND MONTH(p.NgayLap) = @Month AND DAY(p.NgayLap) = @Day";
                            }
                            else if (hasMonth && hasYear)
                            {
                                // Người dùng chỉ nhập tháng và năm
                                if (!int.TryParse(tb_month.Text, out month) || month < 1 || month > 12)
                                {
                                    MessageBox.Show("Tháng không hợp lệ.");
                                    return;
                                }

                                if (!int.TryParse(tb_year.Text, out year) || year < 1900 || year > 2100)
                                {
                                    MessageBox.Show("Năm không hợp lệ.");
                                    return;
                                }

                                query = "SELECT p.MaPhieuBH, p.MaKH, k.TenKH, k.SDT, p.NgayLap, FORMAT(p.TongTien,'c', 'vi-VN') as TongTien " +
                                        "FROM PHIEUBANHANG p " +
                                        "INNER JOIN KHACHHANG k ON p.MaKH = k.MaKH " +
                                        "WHERE YEAR(p.NgayLap) = @Year AND MONTH(p.NgayLap) = @Month";
                            }
                            else if (hasYear)
                            {
                                // Người dùng chỉ nhập năm
                                if (!int.TryParse(tb_year.Text, out year) || year < 1900 || year > 2100)
                                {
                                    MessageBox.Show("Năm không hợp lệ.");
                                    return;
                                }

                                query = "SELECT p.MaPhieuBH, p.MaKH, k.TenKH, k.SDT, p.NgayLap, FORMAT(p.TongTien,'c', 'vi-VN') as TongTien " +
                                        "FROM PHIEUBANHANG p " +
                                        "INNER JOIN KHACHHANG k ON p.MaKH = k.MaKH " +
                                        "WHERE YEAR(p.NgayLap) = @Year";
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng nhập ngày, tháng hoặc năm để tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                        }
                        break;

                    default:
                        break;
                }

                DataTable dataTable = null;

                // Trường hợp đã xây dựng query cho ngày lập
                if (searchOption == 5 && (hasDay && hasMonth && hasYear || hasMonth && hasYear || hasYear))
                {
                    // Truyền tham số tùy theo trường hợp
                    if (hasDay)
                        dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { year, month, day });
                    else if (hasMonth)
                        dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { year, month });
                    else if (hasYear)
                        dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { year });
                }
                else
                {
                    // Trường hợp thông thường
                    // Kiểm tra từ khóa tìm kiếm không được rỗng 
                    if (cbb_searchMode.SelectedIndex != 0 && string.IsNullOrEmpty(keyword))
                    {
                        MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { keyword });
                }

                // Xử lý hiển thị dữ liệu và thêm cột STT
                if (dataTable.Rows.Count > 0)
                {
                    dgv_ds_pbh.DataSource = dataTable;
                    MessageBox.Show("Tìm kiếm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgv_ds_pbh.DataSource = null;
                    MessageBox.Show("Tìm kiếm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateDateBoxes()
        {
            // Kiểm tra giá trị ngày, tháng, năm
            int day, month, year;
            if (!int.TryParse(tb_day.Text, out day) || day < 1 || day > 31)
            {
                MessageBox.Show("Ngày không hợp lệ.");
                return false;
            }

            if (!int.TryParse(tb_month.Text, out month) || month < 1 || month > 12)
            {
                MessageBox.Show("Tháng không hợp lệ.");
                return false;
            }

            if (!int.TryParse(tb_year.Text, out year) || year < 1900 || year > 2100)
            {
                MessageBox.Show("Năm không hợp lệ.");
                return false;
            }

            // Kiểm tra ngày tháng hợp lệ
            if (!IsValidDate(day, month, year))
            {
                MessageBox.Show("Ngày không hợp lệ.");
                return false;
            }

            // Nếu tất cả hợp lệ, trả về true
            return true;
        }

        private bool IsValidDate(int day, int month, int year)
        {
            // Kiểm tra ngày tháng hợp lệ
            bool isValid = true;

            // Kiểm tra ngày hợp lệ trong tháng
            int[] daysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0))
            {
                daysInMonth[1] = 29; // Năm nhuận, tháng 2 có 29 ngày
            }

            if (day < 1 || day > daysInMonth[month - 1])
            {
                isValid = false;
            }

            return isValid;
        }


        private void cbb_searchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isEnableKeyWord = false;
            bool isEnableDate = false;

            switch (cbb_searchMode.SelectedIndex)
            { 
                case 1: // Mã phiếu
                    {
                        isEnableKeyWord = true;
                    }
                    break;

                case 2: // Mã khách hàng
                    {
                        isEnableKeyWord = true;

                    }

                    break;

                case 3: // Tên khách hàng
                    {
                        isEnableKeyWord = true;

                    }

                    break;

                case 4: // Số điện thoại
                    {
                        isEnableKeyWord = true;

                    }

                    break;

                case 5: // Ngày lập
                    {
                        isEnableKeyWord = false;
                        isEnableDate = true;

                    }

                    break;

                default:
                    break;
            }

            tb_keyWord.Enabled = isEnableKeyWord;
            tb_day.Enabled = isEnableDate;
            tb_month.Enabled = isEnableDate;
            tb_year.Enabled = isEnableDate;

            tb_keyWord.Text = "";
            tb_day.Text = "";
            tb_month.Text = "";
            tb_year.Text = "";

        }

        private void tb_keyWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_search.PerformClick();

                // Ngăn chặn âm thanh "beep"
                e.SuppressKeyPress = true;
            }
        }

        private void dgv_ds_pbh_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dgv_ds_pbh.Columns["NgayLap"].Index && e.Value != null)
            {
                // Kiểm tra giá trị ngày lập có đúng định dạng ngày không
                if (DateTime.TryParse(e.Value.ToString(), out DateTime ngayLap))
                {
                    // Định dạng ngày thành chuỗi "ddMMyyyy"
                    e.Value = ngayLap.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }

        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            int MaPhieuBH = 0;
            try
            {
                MaPhieuBH = Convert.ToInt32(dgv_ds_pbh.SelectedRows[0].Cells[0].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn phải chọn một dòng để xem chi tiết phiếu!", "Cảnh báo");
                return;
            }
            CTPhieuBH cTPhieuBH = new CTPhieuBH(MaPhieuBH);
            cTPhieuBH.ShowDialog();
        }
    }
}
