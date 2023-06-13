namespace QuanLyDaQuy.Phieu
{
    partial class DSPhieuMH
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btn_search = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.comboBox_SearchMode = new System.Windows.Forms.ComboBox();
            this.lb_ds_phieu_mua_hang = new System.Windows.Forms.Label();
            this.dtgView_DS_phieu_mua_hang = new System.Windows.Forms.DataGridView();
            this.lb_timKiem = new System.Windows.Forms.Label();
            this.lb_tu_khoa = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Nam = new System.Windows.Forms.TextBox();
            this.lb_nam = new System.Windows.Forms.Label();
            this.comboBox_Thang = new System.Windows.Forms.ComboBox();
            this.lb_thang = new System.Windows.Forms.Label();
            this.comboBox_Ngay = new System.Windows.Forms.ComboBox();
            this.lb_ngay = new System.Windows.Forms.Label();
            this.btn_xemChiTietPhieu = new System.Windows.Forms.Button();
            this.qLDQDataSet = new QuanLyDaQuy.QLDQDataSet();
            this.loadPhieuMHFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadPhieuMH_FullTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuMH_FullTableAdapter();
            this.loadPhieuMH_byTongTienTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuMH_byTongTienTableAdapter();
            this.loadPhieuMH_byTenNCCTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuMH_byTenNCCTableAdapter();
            this.loadPhieuMH_byMaPhieuMHTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuMH_byMaPhieuMHTableAdapter();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView_DS_phieu_mua_hang)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuMHFullBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.14725F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.02339F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.14336F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.07692F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.60908F));
            this.tableLayoutPanel.Controls.Add(this.btn_search, 4, 1);
            this.tableLayoutPanel.Controls.Add(this.tb_Search, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.comboBox_SearchMode, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lb_ds_phieu_mua_hang, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.dtgView_DS_phieu_mua_hang, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.lb_timKiem, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lb_tu_khoa, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.btn_xemChiTietPhieu, 3, 4);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 5;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 513);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_search.Location = new System.Drawing.Point(701, 68);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(96, 29);
            this.btn_search.TabIndex = 10;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Search.Location = new System.Drawing.Point(397, 68);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(298, 22);
            this.tb_Search.TabIndex = 9;
            // 
            // comboBox_SearchMode
            // 
            this.comboBox_SearchMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_SearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SearchMode.FormattingEnabled = true;
            this.comboBox_SearchMode.Items.AddRange(new object[] {
            "Tất cả",
            "Mã phiếu",
            "Tên nhà cung cấp",
            "Tổng tiền"});
            this.comboBox_SearchMode.Location = new System.Drawing.Point(140, 68);
            this.comboBox_SearchMode.Name = "comboBox_SearchMode";
            this.comboBox_SearchMode.Size = new System.Drawing.Size(138, 24);
            this.comboBox_SearchMode.TabIndex = 7;
            this.comboBox_SearchMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_SearchMode_SelectedIndexChanged);
            // 
            // lb_ds_phieu_mua_hang
            // 
            this.lb_ds_phieu_mua_hang.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.lb_ds_phieu_mua_hang, 5);
            this.lb_ds_phieu_mua_hang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ds_phieu_mua_hang.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ds_phieu_mua_hang.Location = new System.Drawing.Point(3, 0);
            this.lb_ds_phieu_mua_hang.Name = "lb_ds_phieu_mua_hang";
            this.lb_ds_phieu_mua_hang.Size = new System.Drawing.Size(794, 65);
            this.lb_ds_phieu_mua_hang.TabIndex = 3;
            this.lb_ds_phieu_mua_hang.Text = "DANH SÁCH PHIẾU MUA HÀNG";
            this.lb_ds_phieu_mua_hang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgView_DS_phieu_mua_hang
            // 
            this.dtgView_DS_phieu_mua_hang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgView_DS_phieu_mua_hang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel.SetColumnSpan(this.dtgView_DS_phieu_mua_hang, 5);
            this.dtgView_DS_phieu_mua_hang.Location = new System.Drawing.Point(3, 138);
            this.dtgView_DS_phieu_mua_hang.Name = "dtgView_DS_phieu_mua_hang";
            this.dtgView_DS_phieu_mua_hang.RowHeadersWidth = 51;
            this.dtgView_DS_phieu_mua_hang.RowTemplate.Height = 24;
            this.dtgView_DS_phieu_mua_hang.Size = new System.Drawing.Size(794, 318);
            this.dtgView_DS_phieu_mua_hang.TabIndex = 0;
            this.dtgView_DS_phieu_mua_hang.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgView_DS_phieu_mua_hang_DataBindingComplete);
            // 
            // lb_timKiem
            // 
            this.lb_timKiem.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_timKiem.AutoSize = true;
            this.lb_timKiem.Location = new System.Drawing.Point(40, 74);
            this.lb_timKiem.Name = "lb_timKiem";
            this.lb_timKiem.Size = new System.Drawing.Size(94, 16);
            this.lb_timKiem.TabIndex = 11;
            this.lb_timKiem.Text = "Tìm kiếm theo:";
            // 
            // lb_tu_khoa
            // 
            this.lb_tu_khoa.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_tu_khoa.AutoSize = true;
            this.lb_tu_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_tu_khoa.Location = new System.Drawing.Point(325, 73);
            this.lb_tu_khoa.Name = "lb_tu_khoa";
            this.lb_tu_khoa.Size = new System.Drawing.Size(66, 18);
            this.lb_tu_khoa.TabIndex = 8;
            this.lb_tu_khoa.Text = "Từ khóa:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel.SetColumnSpan(this.tableLayoutPanel1, 3);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.53819F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.72291F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.60391F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.30195F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_Nam, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_nam, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Thang, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_thang, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Ngay, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_ngay, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(140, 103);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(555, 29);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // textBox_Nam
            // 
            this.textBox_Nam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Nam.Location = new System.Drawing.Point(416, 3);
            this.textBox_Nam.MaxLength = 5;
            this.textBox_Nam.Name = "textBox_Nam";
            this.textBox_Nam.Size = new System.Drawing.Size(136, 22);
            this.textBox_Nam.TabIndex = 8;
            this.textBox_Nam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nam_KeyPress);
            this.textBox_Nam.Leave += new System.EventHandler(this.textBox_Nam_FocusLeave);
            // 
            // lb_nam
            // 
            this.lb_nam.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_nam.AutoSize = true;
            this.lb_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_nam.Location = new System.Drawing.Point(370, 5);
            this.lb_nam.Name = "lb_nam";
            this.lb_nam.Size = new System.Drawing.Size(40, 18);
            this.lb_nam.TabIndex = 7;
            this.lb_nam.Text = "Năm";
            // 
            // comboBox_Thang
            // 
            this.comboBox_Thang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Thang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Thang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Thang.FormattingEnabled = true;
            this.comboBox_Thang.Location = new System.Drawing.Point(245, 3);
            this.comboBox_Thang.Name = "comboBox_Thang";
            this.comboBox_Thang.Size = new System.Drawing.Size(108, 24);
            this.comboBox_Thang.TabIndex = 6;
            this.comboBox_Thang.SelectedIndexChanged += new System.EventHandler(this.comboBox_Thang_SelectedIndexChanged);
            // 
            // lb_thang
            // 
            this.lb_thang.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_thang.AutoSize = true;
            this.lb_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_thang.Location = new System.Drawing.Point(190, 5);
            this.lb_thang.Name = "lb_thang";
            this.lb_thang.Size = new System.Drawing.Size(49, 18);
            this.lb_thang.TabIndex = 5;
            this.lb_thang.Text = "Tháng";
            // 
            // comboBox_Ngay
            // 
            this.comboBox_Ngay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Ngay.FormattingEnabled = true;
            this.comboBox_Ngay.Location = new System.Drawing.Point(72, 3);
            this.comboBox_Ngay.Name = "comboBox_Ngay";
            this.comboBox_Ngay.Size = new System.Drawing.Size(102, 24);
            this.comboBox_Ngay.TabIndex = 4;
            // 
            // lb_ngay
            // 
            this.lb_ngay.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lb_ngay.AutoSize = true;
            this.lb_ngay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_ngay.Location = new System.Drawing.Point(24, 5);
            this.lb_ngay.Name = "lb_ngay";
            this.lb_ngay.Size = new System.Drawing.Size(42, 18);
            this.lb_ngay.TabIndex = 1;
            this.lb_ngay.Text = "Ngày";
            // 
            // btn_xemChiTietPhieu
            // 
            this.btn_xemChiTietPhieu.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_xemChiTietPhieu.Location = new System.Drawing.Point(573, 469);
            this.btn_xemChiTietPhieu.Name = "btn_xemChiTietPhieu";
            this.btn_xemChiTietPhieu.Size = new System.Drawing.Size(122, 34);
            this.btn_xemChiTietPhieu.TabIndex = 1;
            this.btn_xemChiTietPhieu.Text = "Xem chi tiết phiếu";
            this.btn_xemChiTietPhieu.UseVisualStyleBackColor = true;
            this.btn_xemChiTietPhieu.Click += new System.EventHandler(this.button1_Click);
            // 
            // qLDQDataSet
            // 
            this.qLDQDataSet.DataSetName = "QLDQDataSet";
            this.qLDQDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loadPhieuMHFullBindingSource
            // 
            this.loadPhieuMHFullBindingSource.DataMember = "loadPhieuMH_Full";
            this.loadPhieuMHFullBindingSource.DataSource = this.qLDQDataSet;
            // 
            // loadPhieuMH_FullTableAdapter
            // 
            this.loadPhieuMH_FullTableAdapter.ClearBeforeFill = true;
            // 
            // loadPhieuMH_byTongTienTableAdapter
            // 
            this.loadPhieuMH_byTongTienTableAdapter.ClearBeforeFill = true;
            // 
            // loadPhieuMH_byTenNCCTableAdapter
            // 
            this.loadPhieuMH_byTenNCCTableAdapter.ClearBeforeFill = true;
            // 
            // loadPhieuMH_byMaPhieuMHTableAdapter
            // 
            this.loadPhieuMH_byMaPhieuMHTableAdapter.ClearBeforeFill = true;
            // 
            // DSPhieuMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "DSPhieuMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DANH SÁCH PHIẾU MUA HÀNG";
            this.Load += new System.EventHandler(this.DSPhieuMH_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView_DS_phieu_mua_hang)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuMHFullBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.DataGridView dtgView_DS_phieu_mua_hang;
        private QLDQDataSet qLDQDataSet;
        private System.Windows.Forms.BindingSource loadPhieuMHFullBindingSource;
        private QLDQDataSetTableAdapters.loadPhieuMH_FullTableAdapter loadPhieuMH_FullTableAdapter;
        private System.Windows.Forms.Label lb_ds_phieu_mua_hang;
        private System.Windows.Forms.ComboBox comboBox_SearchMode;
        private System.Windows.Forms.Label lb_tu_khoa;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button btn_search;
        private QLDQDataSetTableAdapters.loadPhieuMH_byTongTienTableAdapter loadPhieuMH_byTongTienTableAdapter;
        private QLDQDataSetTableAdapters.loadPhieuMH_byTenNCCTableAdapter loadPhieuMH_byTenNCCTableAdapter;
        private QLDQDataSetTableAdapters.loadPhieuMH_byMaPhieuMHTableAdapter loadPhieuMH_byMaPhieuMHTableAdapter;
        private System.Windows.Forms.Button btn_xemChiTietPhieu;
        private System.Windows.Forms.Label lb_timKiem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_ngay;
        private System.Windows.Forms.ComboBox comboBox_Ngay;
        private System.Windows.Forms.Label lb_thang;
        private System.Windows.Forms.ComboBox comboBox_Thang;
        private System.Windows.Forms.Label lb_nam;
        private System.Windows.Forms.TextBox textBox_Nam;
    }
}