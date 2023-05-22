using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDaQuy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                if(item != null)
                {
                    switch(item.Index)
                    {
                        case 0:
                            thongTinMatHang1.BringToFront();
                            break;
                        case 1:
                            thongTinDichVu1.BringToFront();
                            break;
                        case 2:
                            thongTinKhachHang1.BringToFront() ; break;
                        case 3:
                            thongTinNCC1.BringToFront(); break;

                    }   
                }
            }
        }
    }
}
