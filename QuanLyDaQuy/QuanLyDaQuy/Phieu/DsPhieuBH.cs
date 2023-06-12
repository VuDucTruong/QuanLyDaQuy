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

                string query = "SELECT PBH.MaPhieuBH, PBH.MaKH, KH.TenKH, KH.SDT, PBH.NgayLap, PBH.TongTien " +
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

                // Kiểm tra từ khóa tìm kiếm không được rỗng 
                if (cbb_searchMode.SelectedIndex != 0 && string.IsNullOrEmpty(keyword))
                {
                    MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string query = "";
                switch (searchOption)
                {
                    case 0: // Tất cả
                        query = "SELECT PBH.MaPhieuBH, PBH.MaKH, KH.TenKH, KH.SDT, PBH.NgayLap, PBH.TongTien " +
                                       "FROM PHIEUBANHANG PBH " +
                                       "JOIN KHACHHANG KH ON PBH.MaKH = KH.MaKH";
                        break;

                    case 1: // Mã phiếu
                        query = "SELECT p.MaPhieuBH, p.MaKH, k.TenKH, k.SDT, p.NgayLap, p.TongTien FROM PHIEUBANHANG p INNER JOIN KHACHHANG k ON p.MaKH = k.MaKH WHERE p.MaPhieuBH = @Keyword";
                        break;
                    case 2: // Mã khách hàng
                        query = "SELECT p.MaPhieuBH, p.MaKH, k.TenKH, k.SDT, p.NgayLap, p.TongTien FROM PHIEUBANHANG p INNER JOIN KHACHHANG k ON p.MaKH = k.MaKH WHERE p.MaKH = @Keyword";
                        break;
                    case 3: // Tên khách hàng
                        query = "SELECT p.MaPhieuBH, p.MaKH, k.TenKH, k.SDT, p.NgayLap, p.TongTien FROM PHIEUBANHANG p INNER JOIN KHACHHANG k ON p.MaKH = k.MaKH WHERE k.TenKH LIKE '%' + @Keyword + '%'";
                        break;
                    case 4: // Số điện thoại
                        query = "SELECT p.MaPhieuBH, p.MaKH, k.TenKH, k.SDT, p.NgayLap, p.TongTien FROM PHIEUBANHANG p INNER JOIN KHACHHANG k ON p.MaKH = k.MaKH WHERE k.SDT LIKE '%' + @Keyword + '%'";
                        break;
                    case 5: // Ngày lập
                        {
                            string format = "d/M/yyyy";
                            DateTime date;

                            if (!DateTime.TryParseExact(keyword, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                            {
                                MessageBox.Show("Vui lòng nhập theo định dạng ngày/tháng/năm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }

                            query = "SELECT p.MaPhieuBH, p.MaKH, k.TenKH, k.SDT, p.NgayLap, p.TongTien " +
                            "FROM PHIEUBANHANG p " +
                            "INNER JOIN KHACHHANG k ON p.MaKH = k.MaKH " +
                            "WHERE CONVERT(date, p.NgayLap) = @Keyword ";

                        }

                        break;
                    default:
                        break;
                }

                DataTable dataTable = DataProvider.Instance.ExecuteQuery(query, new object[] { keyword });
                if (dataTable.Rows.Count > 0)
                {
                    dgv_ds_pbh.DataSource = dataTable;

                    // Gọi hàm AddRowNumbers để thêm cột STT vào DataTable
                    //AddRowNumbers(dataTable, "STT");
                }
                else
                {
                    dgv_ds_pbh.DataSource = null;
                    MessageBox.Show("Không tìm thấy kết quả!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbb_searchMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_searchMode.SelectedIndex == 0) // Chọn option "Tất cả"
                tb_keyWord.Enabled = false;
            else
                tb_keyWord.Enabled = true;

            tb_keyWord.Text = "";

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
    }
}
