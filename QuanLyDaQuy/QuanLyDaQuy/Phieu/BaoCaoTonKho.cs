using iText.Layout.Element;
using QuanLyDaQuy.DAO;
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
    public partial class BaoCaoTonKho : Form
    {
        public BaoCaoTonKho()
        {
            InitializeComponent();
        }

        private void BaoCaoTonKho_Load(object sender, EventArgs e)
        {
            string query = string.Format("select distinct YEAR(Thang) from TONKHO");
            DataTable dataTable = DataProvider.Instance.ExecuteQuery(query);
            
            foreach(DataRow row in dataTable.Rows)
            {
                comboBox2.Items.Add(row[0].ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Thang = 0, Nam = 0;
            try
            {
                Thang = Convert.ToInt16(comboBox1.Text);
                Nam = Convert.ToInt16(comboBox2.Text);
            }
            catch
            {
                MessageBox.Show("chưa có dữ liệu về tháng và năm !!");
                return;
            }
            
            // TODO: This line of code loads data into the 'qLDQDataSet.loadTonKho' table. You can move, or remove it, as needed.
            this.loadTonKhoTableAdapter.Fill(this.qLDQDataSet.loadTonKho, Thang, Nam);
            MessageBox.Show("Đã tra cứu thành công !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string STRcontent = String.Format("Tháng : {0} Năm : {1}", comboBox1.Text, comboBox2.Text);
            Paragraph header = new Paragraph(label1.Text).SetFont(ExportPDF.GetUtf8Font());
            Paragraph content = new Paragraph(STRcontent).SetFont(ExportPDF.GetUtf8Font());
            if(ExportPDF.ExcuteDataGridView(header, content, dataGridView1))
            {
                MessageBox.Show("Xuất thành công !");
            }
        }
    }
}
