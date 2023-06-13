namespace QuanLyDaQuy.Phieu
{
    partial class CTPhieuBH
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
            this.loadPhieuBHbyMaPhieuBHForCTPhieuBHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDQDataSet = new QuanLyDaQuy.QLDQDataSet();
            this.loadPhieuMuaHangFull_BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lb_kh = new System.Windows.Forms.Label();
            this.tab_lay_phieubanhang = new System.Windows.Forms.TableLayoutPanel();
            this.kb_ngaylap = new System.Windows.Forms.Label();
            this.tb_ngaylap = new System.Windows.Forms.TextBox();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.tb_sdt = new System.Windows.Forms.TextBox();
            this.dgv_ct_phieubanhang = new System.Windows.Forms.DataGridView();
            this.phieuMuaHang_column_STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuMuaHang_column_sanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuMuaHang_column_loaiSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuMuaHang_column_soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuMuaHang_column_donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuMuaHang_column_donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phieuMuaHang_column_thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadCTPhieuBHbyMaPhieuBHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_kh = new System.Windows.Forms.TextBox();
            this.lb_tt = new System.Windows.Forms.Label();
            this.tb_tt = new System.Windows.Forms.TextBox();
            this.loadCTPhieuMHbyMaPhieuMHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHangTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHangTableAdapter();
            this.loadCTPhieuMH_byMaPhieuMHTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadCTPhieuMH_byMaPhieuMHTableAdapter();
            this.loadPhieuBH_byMaPhieuBH_For_CTPhieuBHTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuBH_byMaPhieuBH_For_CTPhieuBHTableAdapter();
            this.loadCTPhieuBH_byMaPhieuBHTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadCTPhieuBH_byMaPhieuBHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuBHbyMaPhieuBHForCTPhieuBHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuMuaHangFull_BindingSource)).BeginInit();
            this.tab_lay_phieubanhang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ct_phieubanhang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadCTPhieuBHbyMaPhieuBHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadCTPhieuMHbyMaPhieuMHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_lay_phieubanhang.SetColumnSpan(this.lb_title, 6);
            this.lb_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_title.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(3, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(784, 35);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "THÔNG TIN PHIẾU BÁN HÀNG";
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
            this.tb_sophieu.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadPhieuBHbyMaPhieuBHForCTPhieuBHBindingSource, "MaPhieuBH", true));
            this.tb_sophieu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sophieu.Location = new System.Drawing.Point(141, 40);
            this.tb_sophieu.Name = "tb_sophieu";
            this.tb_sophieu.ReadOnly = true;
            this.tb_sophieu.Size = new System.Drawing.Size(132, 25);
            this.tb_sophieu.TabIndex = 2;
            // 
            // loadPhieuBHbyMaPhieuBHForCTPhieuBHBindingSource
            // 
            this.loadPhieuBHbyMaPhieuBHForCTPhieuBHBindingSource.DataMember = "loadPhieuBH_byMaPhieuBH_For_CTPhieuBH";
            this.loadPhieuBHbyMaPhieuBHForCTPhieuBHBindingSource.DataSource = this.qLDQDataSet;
            // 
            // qLDQDataSet
            // 
            this.qLDQDataSet.DataSetName = "QLDQDataSet";
            this.qLDQDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loadPhieuMuaHangFull_BindingSource
            // 
            this.loadPhieuMuaHangFull_BindingSource.DataMember = "loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHang";
            this.loadPhieuMuaHangFull_BindingSource.DataSource = this.qLDQDataSet;
            // 
            // lb_kh
            // 
            this.lb_kh.AutoSize = true;
            this.lb_kh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_kh.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kh.Location = new System.Drawing.Point(279, 35);
            this.lb_kh.Name = "lb_kh";
            this.lb_kh.Size = new System.Drawing.Size(132, 35);
            this.lb_kh.TabIndex = 5;
            this.lb_kh.Text = "Khách hàng:";
            this.lb_kh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tab_lay_phieubanhang
            // 
            this.tab_lay_phieubanhang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_lay_phieubanhang.ColumnCount = 6;
            this.tab_lay_phieubanhang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.52629F));
            this.tab_lay_phieubanhang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.52629F));
            this.tab_lay_phieubanhang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.52629F));
            this.tab_lay_phieubanhang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.52629F));
            this.tab_lay_phieubanhang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.27591F));
            this.tab_lay_phieubanhang.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.61893F));
            this.tab_lay_phieubanhang.Controls.Add(this.lb_title, 0, 0);
            this.tab_lay_phieubanhang.Controls.Add(this.lb_sophieu, 0, 1);
            this.tab_lay_phieubanhang.Controls.Add(this.tb_sophieu, 1, 1);
            this.tab_lay_phieubanhang.Controls.Add(this.kb_ngaylap, 0, 2);
            this.tab_lay_phieubanhang.Controls.Add(this.tb_ngaylap, 1, 2);
            this.tab_lay_phieubanhang.Controls.Add(this.lb_kh, 2, 1);
            this.tab_lay_phieubanhang.Controls.Add(this.lb_sdt, 2, 2);
            this.tab_lay_phieubanhang.Controls.Add(this.tb_sdt, 3, 2);
            this.tab_lay_phieubanhang.Controls.Add(this.dgv_ct_phieubanhang, 0, 3);
            this.tab_lay_phieubanhang.Controls.Add(this.tb_kh, 3, 1);
            this.tab_lay_phieubanhang.Controls.Add(this.lb_tt, 4, 4);
            this.tab_lay_phieubanhang.Controls.Add(this.tb_tt, 5, 4);
            this.tab_lay_phieubanhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_lay_phieubanhang.Location = new System.Drawing.Point(0, 0);
            this.tab_lay_phieubanhang.Name = "tab_lay_phieubanhang";
            this.tab_lay_phieubanhang.RowCount = 5;
            this.tab_lay_phieubanhang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tab_lay_phieubanhang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tab_lay_phieubanhang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tab_lay_phieubanhang.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tab_lay_phieubanhang.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tab_lay_phieubanhang.Size = new System.Drawing.Size(792, 507);
            this.tab_lay_phieubanhang.TabIndex = 1;
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
            this.tb_ngaylap.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadPhieuBHbyMaPhieuBHForCTPhieuBHBindingSource, "NgayLap", true));
            this.tb_ngaylap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ngaylap.Location = new System.Drawing.Point(141, 75);
            this.tb_ngaylap.Name = "tb_ngaylap";
            this.tb_ngaylap.ReadOnly = true;
            this.tb_ngaylap.Size = new System.Drawing.Size(132, 25);
            this.tb_ngaylap.TabIndex = 4;
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_sdt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sdt.Location = new System.Drawing.Point(279, 70);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(132, 35);
            this.lb_sdt.TabIndex = 7;
            this.lb_sdt.Text = "Số điện thoại:";
            this.lb_sdt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_sdt
            // 
            this.tb_sdt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_sdt.BackColor = System.Drawing.SystemColors.Window;
            this.tb_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tab_lay_phieubanhang.SetColumnSpan(this.tb_sdt, 2);
            this.tb_sdt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadPhieuBHbyMaPhieuBHForCTPhieuBHBindingSource, "SDT", true));
            this.tb_sdt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sdt.Location = new System.Drawing.Point(417, 75);
            this.tb_sdt.Name = "tb_sdt";
            this.tb_sdt.ReadOnly = true;
            this.tb_sdt.Size = new System.Drawing.Size(268, 25);
            this.tb_sdt.TabIndex = 8;
            // 
            // dgv_ct_phieubanhang
            // 
            this.dgv_ct_phieubanhang.AutoGenerateColumns = false;
            this.dgv_ct_phieubanhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ct_phieubanhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.phieuMuaHang_column_STT,
            this.phieuMuaHang_column_sanPham,
            this.phieuMuaHang_column_loaiSanPham,
            this.phieuMuaHang_column_soLuong,
            this.phieuMuaHang_column_donViTinh,
            this.phieuMuaHang_column_donGia,
            this.phieuMuaHang_column_thanhTien});
            this.tab_lay_phieubanhang.SetColumnSpan(this.dgv_ct_phieubanhang, 6);
            this.dgv_ct_phieubanhang.DataSource = this.loadCTPhieuBHbyMaPhieuBHBindingSource;
            this.dgv_ct_phieubanhang.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_ct_phieubanhang.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_ct_phieubanhang.Location = new System.Drawing.Point(3, 108);
            this.dgv_ct_phieubanhang.Name = "dgv_ct_phieubanhang";
            this.dgv_ct_phieubanhang.RowHeadersWidth = 51;
            this.dgv_ct_phieubanhang.RowTemplate.Height = 24;
            this.dgv_ct_phieubanhang.Size = new System.Drawing.Size(784, 336);
            this.dgv_ct_phieubanhang.TabIndex = 11;
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
            // loadCTPhieuBHbyMaPhieuBHBindingSource
            // 
            this.loadCTPhieuBHbyMaPhieuBHBindingSource.DataMember = "loadCTPhieuBH_byMaPhieuBH";
            this.loadCTPhieuBHbyMaPhieuBHBindingSource.DataSource = this.qLDQDataSet;
            // 
            // tb_kh
            // 
            this.tb_kh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_kh.BackColor = System.Drawing.SystemColors.Window;
            this.tab_lay_phieubanhang.SetColumnSpan(this.tb_kh, 2);
            this.tb_kh.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadPhieuBHbyMaPhieuBHForCTPhieuBHBindingSource, "TenKH", true));
            this.tb_kh.Location = new System.Drawing.Point(417, 41);
            this.tb_kh.Name = "tb_kh";
            this.tb_kh.ReadOnly = true;
            this.tb_kh.Size = new System.Drawing.Size(268, 22);
            this.tb_kh.TabIndex = 20;
            // 
            // lb_tt
            // 
            this.lb_tt.AutoSize = true;
            this.lb_tt.Dock = System.Windows.Forms.DockStyle.Right;
            this.lb_tt.Location = new System.Drawing.Point(616, 452);
            this.lb_tt.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.lb_tt.Name = "lb_tt";
            this.lb_tt.Size = new System.Drawing.Size(69, 53);
            this.lb_tt.TabIndex = 12;
            this.lb_tt.Text = "Tổng tiền: ";
            // 
            // tb_tt
            // 
            this.tb_tt.BackColor = System.Drawing.SystemColors.Window;
            this.tb_tt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadPhieuBHbyMaPhieuBHForCTPhieuBHBindingSource, "TongTien", true));
            this.tb_tt.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_tt.Location = new System.Drawing.Point(691, 450);
            this.tb_tt.Name = "tb_tt";
            this.tb_tt.ReadOnly = true;
            this.tb_tt.Size = new System.Drawing.Size(96, 22);
            this.tb_tt.TabIndex = 13;
            // 
            // loadCTPhieuMHbyMaPhieuMHBindingSource
            // 
            this.loadCTPhieuMHbyMaPhieuMHBindingSource.DataMember = "loadCTPhieuMH_byMaPhieuMH";
            this.loadCTPhieuMHbyMaPhieuMHBindingSource.DataSource = this.qLDQDataSet;
            // 
            // loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHangTableAdapter
            // 
            this.loadPhieuMH_byMaPhieuMH_For_CT_PhieuMuaHangTableAdapter.ClearBeforeFill = true;
            // 
            // loadCTPhieuMH_byMaPhieuMHTableAdapter
            // 
            this.loadCTPhieuMH_byMaPhieuMHTableAdapter.ClearBeforeFill = true;
            // 
            // loadPhieuBH_byMaPhieuBH_For_CTPhieuBHTableAdapter
            // 
            this.loadPhieuBH_byMaPhieuBH_For_CTPhieuBHTableAdapter.ClearBeforeFill = true;
            // 
            // loadCTPhieuBH_byMaPhieuBHTableAdapter
            // 
            this.loadCTPhieuBH_byMaPhieuBHTableAdapter.ClearBeforeFill = true;
            // 
            // CTPhieuBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 507);
            this.Controls.Add(this.tab_lay_phieubanhang);
            this.Name = "CTPhieuBH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÔNG TIN PHIẾU BÁN HÀNG";
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuBHbyMaPhieuBHForCTPhieuBHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuMuaHangFull_BindingSource)).EndInit();
            this.tab_lay_phieubanhang.ResumeLayout(false);
            this.tab_lay_phieubanhang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ct_phieubanhang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadCTPhieuBHbyMaPhieuBHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadCTPhieuMHbyMaPhieuMHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tab_lay_phieubanhang;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_sophieu;
        private System.Windows.Forms.TextBox tb_sophieu;
        private System.Windows.Forms.Label lb_kh;
        private System.Windows.Forms.DataGridView dgv_ct_phieubanhang;
        private QLDQDataSet qLDQDataSet;
        private System.Windows.Forms.TextBox tb_kh;
        private System.Windows.Forms.TextBox tb_tt;
        private System.Windows.Forms.Label lb_tt;
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
        private System.Windows.Forms.BindingSource loadPhieuBHbyMaPhieuBHForCTPhieuBHBindingSource;
        private System.Windows.Forms.BindingSource loadCTPhieuBHbyMaPhieuBHBindingSource;
        private QLDQDataSetTableAdapters.loadPhieuBH_byMaPhieuBH_For_CTPhieuBHTableAdapter loadPhieuBH_byMaPhieuBH_For_CTPhieuBHTableAdapter;
        private QLDQDataSetTableAdapters.loadCTPhieuBH_byMaPhieuBHTableAdapter loadCTPhieuBH_byMaPhieuBHTableAdapter;
        private System.Windows.Forms.Label kb_ngaylap;
        private System.Windows.Forms.TextBox tb_ngaylap;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.TextBox tb_sdt;
    }
}