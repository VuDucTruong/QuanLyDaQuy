namespace QuanLyDaQuy
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Mặt hàng", 0);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Dịch vụ", 1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Khách hàng", 2);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Nhà cung cấp", 3);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Loại sản phẩm/Đơn vị tính", 4);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.thongTinMatHang1 = new QuanLyDaQuy.ThongTinMatHang();
            this.thongTinDichVu1 = new QuanLyDaQuy.ThongTinDichVu();
            this.thongTinNCC1 = new QuanLyDaQuy.UserControls.ThongTinNCC();
            this.thongTinKhachHang1 = new QuanLyDaQuy.UserControls.ThongTinKhachHang();
            this.thongTinLSP1 = new QuanLyDaQuy.UserControls.ThongTinLSP();
            this.phiếuDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lậpPhiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuMuaHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuMuaHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuBánHàngToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuDịchVụToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTồnKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.lậpPhiếuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuMuaHàngToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuBánHàngToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuDịchVụToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.traCứuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuMuaHàngToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuBánHàngToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.phiếuDịchVụToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoTồnKhoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý thông tin";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(3, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(245, 567);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "jewelry.png");
            this.imageList1.Images.SetKeyName(1, "service.png");
            this.imageList1.Images.SetKeyName(2, "customer.png");
            this.imageList1.Images.SetKeyName(3, "supplier.png");
            this.imageList1.Images.SetKeyName(4, "category_icon.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 621);
            this.panel2.TabIndex = 5;
            // 
            // thongTinMatHang1
            // 
            this.thongTinMatHang1.Location = new System.Drawing.Point(266, 32);
            this.thongTinMatHang1.Name = "thongTinMatHang1";
            this.thongTinMatHang1.Size = new System.Drawing.Size(954, 618);
            this.thongTinMatHang1.TabIndex = 6;
            // 
            // thongTinDichVu1
            // 
            this.thongTinDichVu1.Location = new System.Drawing.Point(266, 32);
            this.thongTinDichVu1.Name = "thongTinDichVu1";
            this.thongTinDichVu1.Size = new System.Drawing.Size(954, 618);
            this.thongTinDichVu1.TabIndex = 7;
            // 
            // thongTinNCC1
            // 
            this.thongTinNCC1.Location = new System.Drawing.Point(266, 32);
            this.thongTinNCC1.Name = "thongTinNCC1";
            this.thongTinNCC1.Size = new System.Drawing.Size(954, 618);
            this.thongTinNCC1.TabIndex = 9;
            // 
            // thongTinKhachHang1
            // 
            this.thongTinKhachHang1.Location = new System.Drawing.Point(266, 32);
            this.thongTinKhachHang1.Name = "thongTinKhachHang1";
            this.thongTinKhachHang1.Size = new System.Drawing.Size(954, 618);
            this.thongTinKhachHang1.TabIndex = 8;
            // 
            // thongTinLSP1
            // 
            this.thongTinLSP1.Location = new System.Drawing.Point(269, 32);
            this.thongTinLSP1.Name = "thongTinLSP1";
            this.thongTinLSP1.Size = new System.Drawing.Size(954, 618);
            this.thongTinLSP1.TabIndex = 10;
            // 
            // phiếuDịchVụToolStripMenuItem
            // 
            this.phiếuDịchVụToolStripMenuItem.Name = "phiếuDịchVụToolStripMenuItem";
            this.phiếuDịchVụToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpPhiếuToolStripMenuItem,
            this.traCứuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1235, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lậpPhiếuToolStripMenuItem
            // 
            this.lậpPhiếuToolStripMenuItem.Name = "lậpPhiếuToolStripMenuItem";
            this.lậpPhiếuToolStripMenuItem.Size = new System.Drawing.Size(14, 20);
            // 
            // traCứuToolStripMenuItem
            // 
            this.traCứuToolStripMenuItem.Name = "traCứuToolStripMenuItem";
            this.traCứuToolStripMenuItem.Size = new System.Drawing.Size(14, 20);
            // 
            // phiếuBánHàngToolStripMenuItem
            // 
            this.phiếuBánHàngToolStripMenuItem.Name = "phiếuBánHàngToolStripMenuItem";
            this.phiếuBánHàngToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // phiếuMuaHàngToolStripMenuItem
            // 
            this.phiếuMuaHàngToolStripMenuItem.Name = "phiếuMuaHàngToolStripMenuItem";
            this.phiếuMuaHàngToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // phiếuMuaHàngToolStripMenuItem1
            // 
            this.phiếuMuaHàngToolStripMenuItem1.Name = "phiếuMuaHàngToolStripMenuItem1";
            this.phiếuMuaHàngToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // phiếuBánHàngToolStripMenuItem1
            // 
            this.phiếuBánHàngToolStripMenuItem1.Name = "phiếuBánHàngToolStripMenuItem1";
            this.phiếuBánHàngToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // phiếuDịchVụToolStripMenuItem1
            // 
            this.phiếuDịchVụToolStripMenuItem1.Name = "phiếuDịchVụToolStripMenuItem1";
            this.phiếuDịchVụToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // báoCáoTồnKhoToolStripMenuItem
            // 
            this.báoCáoTồnKhoToolStripMenuItem.Name = "báoCáoTồnKhoToolStripMenuItem";
            this.báoCáoTồnKhoToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpPhiếuToolStripMenuItem1,
            this.traCứuToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1235, 28);
            this.menuStrip2.TabIndex = 12;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // lậpPhiếuToolStripMenuItem1
            // 
            this.lậpPhiếuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuMuaHàngToolStripMenuItem2,
            this.phiếuBánHàngToolStripMenuItem2,
            this.phiếuDịchVụToolStripMenuItem2});
            this.lậpPhiếuToolStripMenuItem1.Name = "lậpPhiếuToolStripMenuItem1";
            this.lậpPhiếuToolStripMenuItem1.Size = new System.Drawing.Size(88, 24);
            this.lậpPhiếuToolStripMenuItem1.Text = "Lập phiếu";
            // 
            // phiếuMuaHàngToolStripMenuItem2
            // 
            this.phiếuMuaHàngToolStripMenuItem2.Name = "phiếuMuaHàngToolStripMenuItem2";
            this.phiếuMuaHàngToolStripMenuItem2.Size = new System.Drawing.Size(198, 26);
            this.phiếuMuaHàngToolStripMenuItem2.Text = "Phiếu mua hàng";
            this.phiếuMuaHàngToolStripMenuItem2.Click += new System.EventHandler(this.phiếuMuaHàngToolStripMenuItem2_Click);
            // 
            // phiếuBánHàngToolStripMenuItem2
            // 
            this.phiếuBánHàngToolStripMenuItem2.Name = "phiếuBánHàngToolStripMenuItem2";
            this.phiếuBánHàngToolStripMenuItem2.Size = new System.Drawing.Size(198, 26);
            this.phiếuBánHàngToolStripMenuItem2.Text = "Phiếu bán hàng";
            this.phiếuBánHàngToolStripMenuItem2.Click += new System.EventHandler(this.phiếuBánHàngToolStripMenuItem2_Click);
            // 
            // phiếuDịchVụToolStripMenuItem2
            // 
            this.phiếuDịchVụToolStripMenuItem2.Name = "phiếuDịchVụToolStripMenuItem2";
            this.phiếuDịchVụToolStripMenuItem2.Size = new System.Drawing.Size(198, 26);
            this.phiếuDịchVụToolStripMenuItem2.Text = "Phiếu dịch vụ";
            this.phiếuDịchVụToolStripMenuItem2.Click += new System.EventHandler(this.phiếuDịchVụToolStripMenuItem2_Click);
            // 
            // traCứuToolStripMenuItem1
            // 
            this.traCứuToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.phiếuMuaHàngToolStripMenuItem3,
            this.phiếuBánHàngToolStripMenuItem3,
            this.phiếuDịchVụToolStripMenuItem3,
            this.báoCáoTồnKhoToolStripMenuItem1});
            this.traCứuToolStripMenuItem1.Name = "traCứuToolStripMenuItem1";
            this.traCứuToolStripMenuItem1.Size = new System.Drawing.Size(71, 24);
            this.traCứuToolStripMenuItem1.Text = "Tra cứu";
            // 
            // phiếuMuaHàngToolStripMenuItem3
            // 
            this.phiếuMuaHàngToolStripMenuItem3.Name = "phiếuMuaHàngToolStripMenuItem3";
            this.phiếuMuaHàngToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.phiếuMuaHàngToolStripMenuItem3.Text = "Phiếu mua hàng";
            this.phiếuMuaHàngToolStripMenuItem3.Click += new System.EventHandler(this.phiếuMuaHàngToolStripMenuItem3_Click);
            // 
            // phiếuBánHàngToolStripMenuItem3
            // 
            this.phiếuBánHàngToolStripMenuItem3.Name = "phiếuBánHàngToolStripMenuItem3";
            this.phiếuBánHàngToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.phiếuBánHàngToolStripMenuItem3.Text = "Phiếu bán hàng";
            // 
            // phiếuDịchVụToolStripMenuItem3
            // 
            this.phiếuDịchVụToolStripMenuItem3.Name = "phiếuDịchVụToolStripMenuItem3";
            this.phiếuDịchVụToolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.phiếuDịchVụToolStripMenuItem3.Text = "Phiếu dịch vụ";
            this.phiếuDịchVụToolStripMenuItem3.Click += new System.EventHandler(this.phieuDichVuToolStripMenuItem_Click);
            // 
            // báoCáoTồnKhoToolStripMenuItem1
            // 
            this.báoCáoTồnKhoToolStripMenuItem1.Name = "báoCáoTồnKhoToolStripMenuItem1";
            this.báoCáoTồnKhoToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.báoCáoTồnKhoToolStripMenuItem1.Text = "Báo cáo tồn kho";
            this.báoCáoTồnKhoToolStripMenuItem1.Click += new System.EventHandler(this.báoCáoTồnKhoToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 665);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.thongTinMatHang1);
            this.Controls.Add(this.thongTinDichVu1);
            this.Controls.Add(this.thongTinNCC1);
            this.Controls.Add(this.thongTinKhachHang1);
            this.Controls.Add(this.thongTinLSP1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel2;
        private ThongTinMatHang thongTinMatHang1;
        private ThongTinDichVu thongTinDichVu1;
        private UserControls.ThongTinKhachHang thongTinKhachHang1;
        private UserControls.ThongTinNCC thongTinNCC1;
        private UserControls.ThongTinLSP thongTinLSP1;
        private System.Windows.Forms.ToolStripMenuItem phiếuDịchVụToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuMuaHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phiếuMuaHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem phiếuBánHàngToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem phiếuDịchVụToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTồnKhoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem lậpPhiếuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem phiếuMuaHàngToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem phiếuBánHàngToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem phiếuDịchVụToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem traCứuToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem phiếuMuaHàngToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem phiếuBánHàngToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem phiếuDịchVụToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem báoCáoTồnKhoToolStripMenuItem1;
    }
}

