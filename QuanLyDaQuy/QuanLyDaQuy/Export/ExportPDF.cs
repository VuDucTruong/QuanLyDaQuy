using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout;

namespace QuanLyDaQuy.Export
{
    public class ExportPDF
    {
        public static PdfFont GetUtf8Font()
        {
            string fontPath = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName + "//arial.ttf";
            PdfFont font = PdfFontFactory.CreateFont(fontPath);
            return font;
        }
        public static Boolean ExcuteDataGridView(Paragraph header, Paragraph content, DataGridView dataGridView)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.pdf)|*.pdf";
            saveFileDialog.ShowDialog();

            if(!String.IsNullOrEmpty(saveFileDialog.FileName))
            {
                PdfWriter writer = new PdfWriter(saveFileDialog.FileName);
                PdfDocument pdf = new PdfDocument(writer);
                Document document = new Document(pdf);


                Table table = new Table(dataGridView.Columns.Count, false);
                foreach (DataGridViewColumn column in dataGridView.Columns)
                {
                    table.AddCell(new Cell(1, 1).SetBackgroundColor(ColorConstants.GRAY)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(column.HeaderText).SetFont(GetUtf8Font())));
                }
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {

                        if (cell.Value != null)
                        {
                            table.AddCell(new Cell(1, 1).SetBackgroundColor(ColorConstants.WHITE)
                        .SetTextAlignment(TextAlignment.CENTER)
                        .Add(new Paragraph(cell.Value.ToString()).SetFont(GetUtf8Font())));
                        }
                    }
                }
                LineSeparator ls = new LineSeparator(new SolidLine());
                document.Add(header);
                document.Add(ls);
                document.Add(content);
                document.Add(ls);
                document.Add(table);
                document.Close();
                return true;
            }
            else { return false; }

            
        }
    }
}
