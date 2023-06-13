using iText.Layout.Element;
using QuanLyDaQuy.Export;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaQuy.Phieu
{
    public partial class CTPhieuBH : Form
    {
        int MaPhieuBH;
        public CTPhieuBH(int maPhieuBH)
        {
            InitializeComponent();
            MaPhieuBH = maPhieuBH;
            setSTTValue();
            loadData();
        }
        
        private void loadData()
        {
            this.loadPhieuBH_byMaPhieuBH_For_CTPhieuBHTableAdapter.Fill(this.qLDQDataSet.loadPhieuBH_byMaPhieuBH_For_CTPhieuBH, MaPhieuBH);
            this.loadCTPhieuBH_byMaPhieuBHTableAdapter.Fill(this.qLDQDataSet.loadCTPhieuBH_byMaPhieuBH, MaPhieuBH);
        }
        private void setSTTValue()
        {
            foreach (DataGridViewRow dataRow in dgv_ct_phieubanhang.Rows)
            {
                dataRow.Cells[0].Value = dataRow.Index + 1;
            }
        }

        private void btn_XuatPDF_Click(object sender, EventArgs e)
        {
            string STRcontent = String.Format("Số phiếu : {0} \n", tb_sophieu.Text) +
                String.Format("Ngày lập : {0} \n", tb_ngaylap.Text) +
                String.Format("Khách hàng : {0} \n", tb_kh.Text) +
                String.Format("Số điện thoại : {0} \n", tb_sdt.Text) +
                String.Format("Tổng tiền : {0} ", tb_tt.Text);
            Paragraph header = new Paragraph(lb_title.Text).SetFont(ExportPDF.GetUtf8Font());
            Paragraph content = new Paragraph(STRcontent).SetFont(ExportPDF.GetUtf8Font());
            if (ExportPDF.ExcuteDataGridView(header, content, dgv_ct_phieubanhang))
            {
                MessageBox.Show("Xuất thành công !");
            }
        }
    }
}
