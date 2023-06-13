using iText.Layout.Element;
using QuanLyDaQuy.Export;
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
    public partial class DSPhieuMH_CT_PhieuMuaHang : Form
    {
        int MaPhieuMH;
        public DSPhieuMH_CT_PhieuMuaHang(int maPhieuMH)
        {
            InitializeComponent();
            MaPhieuMH = maPhieuMH;
            setSTTValue();
            loadData();
        }
        
        private void loadData()
        {
            this.loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHangTableAdapter.Fill(this.qLDQDataSet.loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHang, MaPhieuMH);
            this.loadCTPhieuMH_byMaPhieuMHTableAdapter.Fill(this.qLDQDataSet.loadCTPhieuMH_byMaPhieuMH, MaPhieuMH);
        }
        private void setSTTValue()
        {
            foreach (DataGridViewRow dataRow in dt_grid_phieumuahang.Rows)
            {
                dataRow.Cells[0].Value = dataRow.Index + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string STRcontent = String.Format("Số phiếu : {0} \n Ngày lập : {1} \n Nhà cung cấp : {2} \n Địa chỉ : {3} \n Số điện thoại : {4} \n Tổng tiền : {5} \n"
                , tb_sophieu.Text, tb_ngaylap.Text , tb_nhaCungCap , tb_diachi.Text , tb_sodienthoai.Text , tb_thanhTien.Text);
            Paragraph header = new Paragraph(lb_title.Text).SetFont(ExportPDF.GetUtf8Font());
            Paragraph content = new Paragraph(STRcontent).SetFont(ExportPDF.GetUtf8Font());
            if (ExportPDF.ExcuteDataGridView(header, content, dt_grid_phieumuahang))
            {
                MessageBox.Show("Xuất thành công !");
            }
        }
    }
}
