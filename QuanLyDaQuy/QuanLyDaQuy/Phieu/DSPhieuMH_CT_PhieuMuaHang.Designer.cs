namespace QuanLyDaQuy.Phieu
{
    partial class DSPhieuMH_CT_PhieuMuaHang
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
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_sophieu = new System.Windows.Forms.Label();
            this.tb_sophieu = new System.Windows.Forms.TextBox();
            this.loadPhieuMuaHangFull_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDQDataSet = new QuanLyDaQuy.QLDQDataSet();
            this.kb_ngaylap = new System.Windows.Forms.Label();
            this.tb_ngaylap = new System.Windows.Forms.TextBox();
            this.lb_nhacungcap = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.tb_diachi = new System.Windows.Forms.TextBox();
            this.lb_sodienthoai = new System.Windows.Forms.Label();
            this.tb_sodienthoai = new System.Windows.Forms.TextBox();
            this.tab_lay_phieumuahang = new System.Windows.Forms.TableLayoutPanel();
            this.dt_grid_phieumuahang = new System.Windows.Forms.DataGridView();
            this.phieuMuaHang_column_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuMuaHang_column_sanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuMuaHang_column_loaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuMuaHang_column_soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuMuaHang_column_donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuMuaHang_column_donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuMuaHang_column_thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadCTPhieuMHbyMaPhieuMHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_thanhTien = new System.Windows.Forms.TextBox();
            this.tb_nhaCungCap = new System.Windows.Forms.TextBox();
            this.lb_thanhTien = new System.Windows.Forms.Label();
            this.loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHangTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHangTableAdapter();
            this.loadCTPhieuMH_byMaPhieuMHTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadCTPhieuMH_byMaPhieuMHTableAdapter();
            this.sTTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuMuaHangFull_BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).BeginInit();
            this.tab_lay_phieumuahang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_grid_phieumuahang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadCTPhieuMHbyMaPhieuMHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_lay_phieumuahang.SetColumnSpan(this.lb_title, 6);
            this.lb_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_title.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(3, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(784, 35);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "THÔNG TIN PHIẾU MUA HÀNG";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_sophieu
            // 
            this.lb_sophieu.AutoSize = true;
            this.lb_sophieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_sophieu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sophieu.ForeColor = System.Drawing.Color.Black;
            this.lb_sophieu.Location = new System.Drawing.Point(3, 35);
            this.lb_sophieu.Name = "lb_sophieu";
            this.lb_sophieu.Size = new System.Drawing.Size(132, 35);
            this.lb_sophieu.TabIndex = 1;
            this.lb_sophieu.Text = "Số phiếu:";
            this.lb_sophieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_sophieu
            // 
            this.tb_sophieu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_sophieu.BackColor = System.Drawing.SystemColors.Window;
            this.tb_sophieu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_sophieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadPhieuMuaHangFull_BindingSource, "MaPhieuMH", true));
            this.tb_sophieu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sophieu.Location = new System.Drawing.Point(141, 40);
            this.tb_sophieu.Name = "tb_sophieu";
            this.tb_sophieu.ReadOnly = true;
            this.tb_sophieu.Size = new System.Drawing.Size(132, 25);
            this.tb_sophieu.TabIndex = 2;
            // 
            // loadPhieuMuaHangFull_BindingSource
            // 
            this.loadPhieuMuaHangFull_BindingSource.DataMember = "loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHang";
            this.loadPhieuMuaHangFull_BindingSource.DataSource = this.qLDQDataSet;
            // 
            // qLDQDataSet
            // 
            this.qLDQDataSet.DataSetName = "QLDQDataSet";
            this.qLDQDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kb_ngaylap
            // 
            this.kb_ngaylap.AutoSize = true;
            this.kb_ngaylap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kb_ngaylap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kb_ngaylap.Location = new System.Drawing.Point(3, 70);
            this.kb_ngaylap.Name = "kb_ngaylap";
            this.kb_ngaylap.Size = new System.Drawing.Size(132, 35);
            this.kb_ngaylap.TabIndex = 3;
            this.kb_ngaylap.Text = "Ngày lập:";
            this.kb_ngaylap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_ngaylap
            // 
            this.tb_ngaylap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ngaylap.BackColor = System.Drawing.SystemColors.Window;
            this.tb_ngaylap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ngaylap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadPhieuMuaHangFull_BindingSource, "NgayLap", true));
            this.tb_ngaylap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ngaylap.Location = new System.Drawing.Point(141, 75);
            this.tb_ngaylap.Name = "tb_ngaylap";
            this.tb_ngaylap.ReadOnly = true;
            this.tb_ngaylap.Size = new System.Drawing.Size(132, 25);
            this.tb_ngaylap.TabIndex = 4;
            // 
            // lb_nhacungcap
            // 
            this.lb_nhacungcap.AutoSize = true;
            this.lb_nhacungcap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_nhacungcap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nhacungcap.Location = new System.Drawing.Point(279, 35);
            this.lb_nhacungcap.Name = "lb_nhacungcap";
            this.lb_nhacungcap.Size = new System.Drawing.Size(132, 35);
            this.lb_nhacungcap.TabIndex = 5;
            this.lb_nhacungcap.Text = "Nhà cung cấp:";
            this.lb_nhacungcap.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_diachi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_diachi.Location = new System.Drawing.Point(279, 70);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(132, 35);
            this.lb_diachi.TabIndex = 7;
            this.lb_diachi.Text = "Địa chỉ:";
            this.lb_diachi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_diachi
            // 
            this.tb_diachi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_diachi.BackColor = System.Drawing.SystemColors.Window;
            this.tb_diachi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_lay_phieumuahang.SetColumnSpan(this.tb_diachi, 2);
            this.tb_diachi.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadPhieuMuaHangFull_BindingSource, "DiaChi", true));
            this.tb_diachi.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_diachi.Location = new System.Drawing.Point(417, 75);
            this.tb_diachi.Name = "tb_diachi";
            this.tb_diachi.ReadOnly = true;
            this.tb_diachi.Size = new System.Drawing.Size(268, 25);
            this.tb_diachi.TabIndex = 8;
            // 
            // lb_sodienthoai
            // 
            this.lb_sodienthoai.AutoSize = true;
            this.lb_sodienthoai.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_sodienthoai.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sodienthoai.Location = new System.Drawing.Point(279, 105);
            this.lb_sodienthoai.Name = "lb_sodienthoai";
            this.lb_sodienthoai.Size = new System.Drawing.Size(132, 35);
            this.lb_sodienthoai.TabIndex = 9;
            this.lb_sodienthoai.Text = "Số điện thoại:";
            this.lb_sodienthoai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_sodienthoai
            // 
            this.tb_sodienthoai.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_sodienthoai.BackColor = System.Drawing.SystemColors.Window;
            this.tb_sodienthoai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_lay_phieumuahang.SetColumnSpan(this.tb_sodienthoai, 2);
            this.tb_sodienthoai.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadPhieuMuaHangFull_BindingSource, "SDT", true));
            this.tb_sodienthoai.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sodienthoai.Location = new System.Drawing.Point(417, 110);
            this.tb_sodienthoai.Name = "tb_sodienthoai";
            this.tb_sodienthoai.ReadOnly = true;
            this.tb_sodienthoai.Size = new System.Drawing.Size(268, 25);
            this.tb_sodienthoai.TabIndex = 10;
            // 
            // tab_lay_phieumuahang
            // 
            this.tab_lay_phieumuahang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_lay_phieumuahang.ColumnCount = 6;
            this.tab_lay_phieumuahang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.52629F));
            this.tab_lay_phieumuahang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.52629F));
            this.tab_lay_phieumuahang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.52629F));
            this.tab_lay_phieumuahang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.52629F));
            this.tab_lay_phieumuahang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.27591F));
            this.tab_lay_phieumuahang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.61893F));
            this.tab_lay_phieumuahang.Controls.Add(this.lb_title, 0, 0);
            this.tab_lay_phieumuahang.Controls.Add(this.lb_sophieu, 0, 1);
            this.tab_lay_phieumuahang.Controls.Add(this.tb_sophieu, 1, 1);
            this.tab_lay_phieumuahang.Controls.Add(this.kb_ngaylap, 0, 2);
            this.tab_lay_phieumuahang.Controls.Add(this.tb_ngaylap, 1, 2);
            this.tab_lay_phieumuahang.Controls.Add(this.lb_nhacungcap, 2, 1);
            this.tab_lay_phieumuahang.Controls.Add(this.lb_diachi, 2, 2);
            this.tab_lay_phieumuahang.Controls.Add(this.tb_diachi, 3, 2);
            this.tab_lay_phieumuahang.Controls.Add(this.lb_sodienthoai, 2, 3);
            this.tab_lay_phieumuahang.Controls.Add(this.tb_sodienthoai, 3, 3);
            this.tab_lay_phieumuahang.Controls.Add(this.dt_grid_phieumuahang, 0, 4);
            this.tab_lay_phieumuahang.Controls.Add(this.tb_thanhTien, 5, 5);
            this.tab_lay_phieumuahang.Controls.Add(this.tb_nhaCungCap, 3, 1);
            this.tab_lay_phieumuahang.Controls.Add(this.lb_thanhTien, 4, 5);
            this.tab_lay_phieumuahang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_lay_phieumuahang.Location = new System.Drawing.Point(0, 0);
            this.tab_lay_phieumuahang.Name = "tab_lay_phieumuahang";
            this.tab_lay_phieumuahang.RowCount = 7;
            this.tab_lay_phieumuahang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tab_lay_phieumuahang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tab_lay_phieumuahang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tab_lay_phieumuahang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tab_lay_phieumuahang.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tab_lay_phieumuahang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tab_lay_phieumuahang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tab_lay_phieumuahang.Size = new System.Drawing.Size(792, 519);
            this.tab_lay_phieumuahang.TabIndex = 1;
            // 
            // dt_grid_phieumuahang
            // 
            this.dt_grid_phieumuahang.AutoGenerateColumns = false;
            this.dt_grid_phieumuahang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_grid_phieumuahang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phieuMuaHang_column_STT,
            this.phieuMuaHang_column_sanPham,
            this.phieuMuaHang_column_loaiSanPham,
            this.phieuMuaHang_column_soLuong,
            this.phieuMuaHang_column_donViTinh,
            this.phieuMuaHang_column_donGia,
            this.phieuMuaHang_column_thanhTien,
            this.sTTDataGridViewTextBoxColumn,
            this.tenSPDataGridViewTextBoxColumn,
            this.tenLSPDataGridViewTextBoxColumn,
            this.sLDataGridViewTextBoxColumn,
            this.dVTDataGridViewTextBoxColumn,
            this.donGiaDataGridViewTextBoxColumn,
            this.thanhTienDataGridViewTextBoxColumn});
            this.tab_lay_phieumuahang.SetColumnSpan(this.dt_grid_phieumuahang, 6);
            this.dt_grid_phieumuahang.DataSource = this.loadCTPhieuMHbyMaPhieuMHBindingSource;
            this.dt_grid_phieumuahang.Dock = System.Windows.Forms.DockStyle.Top;
            this.dt_grid_phieumuahang.GridColor = System.Drawing.SystemColors.Control;
            this.dt_grid_phieumuahang.Location = new System.Drawing.Point(3, 143);
            this.dt_grid_phieumuahang.Name = "dt_grid_phieumuahang";
            this.dt_grid_phieumuahang.RowHeadersWidth = 51;
            this.dt_grid_phieumuahang.RowTemplate.Height = 24;
            this.dt_grid_phieumuahang.Size = new System.Drawing.Size(784, 336);
            this.dt_grid_phieumuahang.TabIndex = 11;
            // 
            // phieuMuaHang_column_STT
            // 
            this.phieuMuaHang_column_STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.phieuMuaHang_column_STT.DataPropertyName = "STT";
            this.phieuMuaHang_column_STT.HeaderText = "STT";
            this.phieuMuaHang_column_STT.MinimumWidth = 6;
            this.phieuMuaHang_column_STT.Name = "phieuMuaHang_column_STT";
            this.phieuMuaHang_column_STT.ReadOnly = true;
            this.phieuMuaHang_column_STT.Width = 63;
            // 
            // phieuMuaHang_column_sanPham
            // 
            this.phieuMuaHang_column_sanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phieuMuaHang_column_sanPham.DataPropertyName = "TenSP";
            this.phieuMuaHang_column_sanPham.HeaderText = "Sản phẩm";
            this.phieuMuaHang_column_sanPham.MinimumWidth = 6;
            this.phieuMuaHang_column_sanPham.Name = "phieuMuaHang_column_sanPham";
            this.phieuMuaHang_column_sanPham.ReadOnly = true;
            this.phieuMuaHang_column_sanPham.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // phieuMuaHang_column_loaiSanPham
            // 
            this.phieuMuaHang_column_loaiSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phieuMuaHang_column_loaiSanPham.DataPropertyName = "TenLSP";
            this.phieuMuaHang_column_loaiSanPham.HeaderText = "Loại sản phẩm";
            this.phieuMuaHang_column_loaiSanPham.MinimumWidth = 6;
            this.phieuMuaHang_column_loaiSanPham.Name = "phieuMuaHang_column_loaiSanPham";
            this.phieuMuaHang_column_loaiSanPham.ReadOnly = true;
            this.phieuMuaHang_column_loaiSanPham.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.phieuMuaHang_column_loaiSanPham.Width = 114;
            // 
            // phieuMuaHang_column_soLuong
            // 
            this.phieuMuaHang_column_soLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phieuMuaHang_column_soLuong.DataPropertyName = "SL";
            this.phieuMuaHang_column_soLuong.HeaderText = "Số lượng";
            this.phieuMuaHang_column_soLuong.MinimumWidth = 6;
            this.phieuMuaHang_column_soLuong.Name = "phieuMuaHang_column_soLuong";
            this.phieuMuaHang_column_soLuong.ReadOnly = true;
            this.phieuMuaHang_column_soLuong.Width = 83;
            // 
            // phieuMuaHang_column_donViTinh
            // 
            this.phieuMuaHang_column_donViTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phieuMuaHang_column_donViTinh.DataPropertyName = "DVT";
            this.phieuMuaHang_column_donViTinh.HeaderText = "Đơn vị tính";
            this.phieuMuaHang_column_donViTinh.MinimumWidth = 6;
            this.phieuMuaHang_column_donViTinh.Name = "phieuMuaHang_column_donViTinh";
            this.phieuMuaHang_column_donViTinh.ReadOnly = true;
            this.phieuMuaHang_column_donViTinh.Width = 71;
            // 
            // phieuMuaHang_column_donGia
            // 
            this.phieuMuaHang_column_donGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phieuMuaHang_column_donGia.DataPropertyName = "DonGia";
            this.phieuMuaHang_column_donGia.HeaderText = "Đơn giá";
            this.phieuMuaHang_column_donGia.MinimumWidth = 6;
            this.phieuMuaHang_column_donGia.Name = "phieuMuaHang_column_donGia";
            this.phieuMuaHang_column_donGia.ReadOnly = true;
            this.phieuMuaHang_column_donGia.Width = 76;
            // 
            // phieuMuaHang_column_thanhTien
            // 
            this.phieuMuaHang_column_thanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phieuMuaHang_column_thanhTien.DataPropertyName = "ThanhTien";
            this.phieuMuaHang_column_thanhTien.HeaderText = "Thành tiền";
            this.phieuMuaHang_column_thanhTien.MinimumWidth = 6;
            this.phieuMuaHang_column_thanhTien.Name = "phieuMuaHang_column_thanhTien";
            this.phieuMuaHang_column_thanhTien.ReadOnly = true;
            this.phieuMuaHang_column_thanhTien.Width = 91;
            // 
            // loadCTPhieuMHbyMaPhieuMHBindingSource
            // 
            this.loadCTPhieuMHbyMaPhieuMHBindingSource.DataMember = "loadCTPhieuMH_byMaPhieuMH";
            this.loadCTPhieuMHbyMaPhieuMHBindingSource.DataSource = this.qLDQDataSet;
            // 
            // tb_thanhTien
            // 
            this.tb_thanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_thanhTien.BackColor = System.Drawing.SystemColors.Window;
            this.tb_thanhTien.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadPhieuMuaHangFull_BindingSource, "TongTien", true));
            this.tb_thanhTien.Location = new System.Drawing.Point(691, 485);
            this.tb_thanhTien.Name = "tb_thanhTien";
            this.tb_thanhTien.ReadOnly = true;
            this.tb_thanhTien.Size = new System.Drawing.Size(96, 22);
            this.tb_thanhTien.TabIndex = 13;
            // 
            // tb_nhaCungCap
            // 
            this.tb_nhaCungCap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_nhaCungCap.BackColor = System.Drawing.SystemColors.Window;
            this.tab_lay_phieumuahang.SetColumnSpan(this.tb_nhaCungCap, 2);
            this.tb_nhaCungCap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadPhieuMuaHangFull_BindingSource, "TenNCC", true));
            this.tb_nhaCungCap.Location = new System.Drawing.Point(417, 41);
            this.tb_nhaCungCap.Name = "tb_nhaCungCap";
            this.tb_nhaCungCap.ReadOnly = true;
            this.tb_nhaCungCap.Size = new System.Drawing.Size(268, 22);
            this.tb_nhaCungCap.TabIndex = 20;
            // 
            // lb_thanhTien
            // 
            this.lb_thanhTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_thanhTien.AutoSize = true;
            this.lb_thanhTien.Location = new System.Drawing.Point(616, 482);
            this.lb_thanhTien.Name = "lb_thanhTien";
            this.lb_thanhTien.Size = new System.Drawing.Size(69, 20);
            this.lb_thanhTien.TabIndex = 12;
            this.lb_thanhTien.Text = "Tổng tiền: ";
            // 
            // loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHangTableAdapter
            // 
            this.loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHangTableAdapter.ClearBeforeFill = true;
            // 
            // loadCTPhieuMH_byMaPhieuMHTableAdapter
            // 
            this.loadCTPhieuMH_byMaPhieuMHTableAdapter.ClearBeforeFill = true;
            // 
            // sTTDataGridViewTextBoxColumn
            // 
            this.sTTDataGridViewTextBoxColumn.DataPropertyName = "STT";
            this.sTTDataGridViewTextBoxColumn.HeaderText = "STT";
            this.sTTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sTTDataGridViewTextBoxColumn.Name = "sTTDataGridViewTextBoxColumn";
            this.sTTDataGridViewTextBoxColumn.ReadOnly = true;
            this.sTTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenSPDataGridViewTextBoxColumn
            // 
            this.tenSPDataGridViewTextBoxColumn.DataPropertyName = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.HeaderText = "TenSP";
            this.tenSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenSPDataGridViewTextBoxColumn.Name = "tenSPDataGridViewTextBoxColumn";
            this.tenSPDataGridViewTextBoxColumn.Width = 125;
            // 
            // tenLSPDataGridViewTextBoxColumn
            // 
            this.tenLSPDataGridViewTextBoxColumn.DataPropertyName = "TenLSP";
            this.tenLSPDataGridViewTextBoxColumn.HeaderText = "TenLSP";
            this.tenLSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLSPDataGridViewTextBoxColumn.Name = "tenLSPDataGridViewTextBoxColumn";
            this.tenLSPDataGridViewTextBoxColumn.Width = 125;
            // 
            // sLDataGridViewTextBoxColumn
            // 
            this.sLDataGridViewTextBoxColumn.DataPropertyName = "SL";
            this.sLDataGridViewTextBoxColumn.HeaderText = "SL";
            this.sLDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sLDataGridViewTextBoxColumn.Name = "sLDataGridViewTextBoxColumn";
            this.sLDataGridViewTextBoxColumn.Width = 125;
            // 
            // dVTDataGridViewTextBoxColumn
            // 
            this.dVTDataGridViewTextBoxColumn.DataPropertyName = "DVT";
            this.dVTDataGridViewTextBoxColumn.HeaderText = "DVT";
            this.dVTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dVTDataGridViewTextBoxColumn.Name = "dVTDataGridViewTextBoxColumn";
            this.dVTDataGridViewTextBoxColumn.Width = 125;
            // 
            // donGiaDataGridViewTextBoxColumn
            // 
            this.donGiaDataGridViewTextBoxColumn.DataPropertyName = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.HeaderText = "DonGia";
            this.donGiaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDataGridViewTextBoxColumn.Name = "donGiaDataGridViewTextBoxColumn";
            this.donGiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.donGiaDataGridViewTextBoxColumn.Width = 125;
            // 
            // thanhTienDataGridViewTextBoxColumn
            // 
            this.thanhTienDataGridViewTextBoxColumn.DataPropertyName = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.HeaderText = "ThanhTien";
            this.thanhTienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.thanhTienDataGridViewTextBoxColumn.Name = "thanhTienDataGridViewTextBoxColumn";
            this.thanhTienDataGridViewTextBoxColumn.ReadOnly = true;
            this.thanhTienDataGridViewTextBoxColumn.Width = 125;
            // 
            // DSPhieuMH_CT_PhieuMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 519);
            this.Controls.Add(this.tab_lay_phieumuahang);
            this.Name = "DSPhieuMH_CT_PhieuMuaHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÔNG TIN PHIẾU MUA HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuMuaHangFull_BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).EndInit();
            this.tab_lay_phieumuahang.ResumeLayout(false);
            this.tab_lay_phieumuahang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_grid_phieumuahang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadCTPhieuMHbyMaPhieuMHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tab_lay_phieumuahang;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_sophieu;
        private System.Windows.Forms.TextBox tb_sophieu;
        private System.Windows.Forms.Label kb_ngaylap;
        private System.Windows.Forms.TextBox tb_ngaylap;
        private System.Windows.Forms.Label lb_nhacungcap;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.TextBox tb_diachi;
        private System.Windows.Forms.Label lb_sodienthoai;
        private System.Windows.Forms.TextBox tb_sodienthoai;
        private System.Windows.Forms.DataGridView dt_grid_phieumuahang;
        private QLDQDataSet qLDQDataSet;
        private System.Windows.Forms.TextBox tb_nhaCungCap;
        private System.Windows.Forms.TextBox tb_thanhTien;
        private System.Windows.Forms.Label lb_thanhTien;
        private System.Windows.Forms.BindingSource loadPhieuMuaHangFull_BindingSource;
        private QLDQDataSetTableAdapters.loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHangTableAdapter loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHangTableAdapter;
        private System.Windows.Forms.BindingSource loadCTPhieuMHbyMaPhieuMHBindingSource;
        private QLDQDataSetTableAdapters.loadCTPhieuMH_byMaPhieuMHTableAdapter loadCTPhieuMH_byMaPhieuMHTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn phieuMuaHang_column_STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn phieuMuaHang_column_sanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn phieuMuaHang_column_loaiSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn phieuMuaHang_column_soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn phieuMuaHang_column_donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn phieuMuaHang_column_donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn phieuMuaHang_column_thanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn sTTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienDataGridViewTextBoxColumn;
    }
}