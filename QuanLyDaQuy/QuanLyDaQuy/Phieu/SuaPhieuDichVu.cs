﻿using QuanLyDaQuy.DTO;
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
    public partial class SuaPhieuDichVu : Form
    {
        private int MaPhieuDV = 0;
        string tinhTrangPhieu = "";
        List<int> MaDVs = new List<int>();

        public SuaPhieuDichVu(int maPhieuDV)
        {
            InitializeComponent();
            MaPhieuDV = maPhieuDV;

        }

        private void PhieuDichVu_Load(object sender, EventArgs e)
        {
            textBox_SoPhieu.Text = MaPhieuDV.ToString();

            // Select PHIEUDICHVU dataTable
            DataTable data_phieu = DAO.DataProvider.Instance.ExecuteQuery("EXEC [dbo].[loadPhieuDV_byMaPhieuDV] @MaPhieuDV = " + MaPhieuDV);
            foreach (DataRow row in data_phieu.Rows)
            {
                textBox_KhachHang.Text = row["TenKH"].ToString();
                textBox_SDT.Text = row["SDT"].ToString();
                textBox_TongTien.Text = row["TongTien"].ToString();
                textBox_TongTienTraTruoc.Text = row["TraTruoc"].ToString();
                textBox_TongTienConLai.Text = row["ConLai"].ToString();
                DateTime NgayLapPhieu;
                DateTime.TryParseExact(row["NgayLap"].ToString().Split(' ')[0], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out NgayLapPhieu);
                textBox_NgayLap.Text = NgayLapPhieu.ToString("dd/MM/yyyy");
                tinhTrangPhieu = row["TinhTrang"].ToString();
            }

            // Select CT_PHIEUDICHVU
            DataTable data_ct = DAO.DataProvider.Instance.ExecuteQuery("EXEC [dbo].[loadCTPhieuDV_byMaPhieuDV] @MaPhieuDV = " + MaPhieuDV);
            int stt = 1;
            foreach (DataRow row in data_ct.Rows)
            {
                MaDVs.Add(Convert.ToInt32(row["MaDV"]));
                // tenDV
                string tenDV = row["TenDV"].ToString();
                string donGia = row["DonGia"].ToString();
                string donGiaDuocTinh = row["DonGiaDuocTinh"].ToString();
                string sl = row["SL"].ToString();
                string thanhTien = row["ThanhTien"].ToString();
                string traTruoc = row["TraTruoc"].ToString();
                string conLai = row["ConLai"].ToString();
                DateTime NgayGiao;
                DateTime.TryParseExact(row["NgayGiao"].ToString().Split(' ')[0], "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out NgayGiao);
                string ngayGiao = NgayGiao.ToString("dd/MM/yyyy");
                string tinhTrang = row["TinhTrang"].ToString();
                dataGridView1.Rows.Add(stt, tenDV, donGia, donGiaDuocTinh, sl, thanhTien, traTruoc, conLai, ngayGiao, tinhTrang);
                stt++;
            }           
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

        }


        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            tinhTrangPhieu = "Hoàn thành";

            // check Tinh Trang
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow || row.Cells[0].Value == null)
                    continue;
                if (row.Cells[9].Value.ToString() != "Hoàn thành")
                {
                    tinhTrangPhieu = "Chưa hoàn thành";
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

            // Finish validating
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn cập nhật phiếu này không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    DAO.DataProvider.Instance.ExecuteQuery( "update PHIEUDICHVU " +
                                                            "set TinhTrang = N'" + tinhTrangPhieu + "' " +
                                                            "where MaPhieuDV = " + MaPhieuDV);
                    foreach(DataGridViewRow row in dataGridView1.Rows)
                    {
                        DAO.DataProvider.Instance.ExecuteQuery( "update CT_PHIEUDICHVU " +
                                                                "set TinhTrang = N'" + row.Cells[9].Value.ToString() + "' " +
                                                                "where MaPhieuDV = " + MaPhieuDV + " and MaDV = " + MaDVs[row.Index]);
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
    }
}