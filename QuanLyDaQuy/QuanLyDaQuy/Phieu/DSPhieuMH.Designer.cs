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
            this.lb_tu_khoa = new System.Windows.Forms.Label();
            this.comboBox_SearchMode = new System.Windows.Forms.ComboBox();
            this.lb_tim_kiem = new System.Windows.Forms.Label();
            this.lb_ds_phieu_mua_hang = new System.Windows.Forms.Label();
            this.dtgView_DS_phieu_mua_hang = new System.Windows.Forms.DataGridView();
            this.qLDQDataSet = new QuanLyDaQuy.QLDQDataSet();
            this.loadPhieuMHFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadPhieuMH_FullTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuMH_FullTableAdapter();
            this.loadPhieuMH_byTongTienTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuMH_byTongTienTableAdapter();
            this.loadPhieuMH_byTenNCCTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuMH_byTenNCCTableAdapter();
            this.loadPhieuMH_byNgayLapTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuMH_byNgayLapTableAdapter();
            this.loadPhieuMH_byMaPhieuMHTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuMH_byMaPhieuMHTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView_DS_phieu_mua_hang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuMHFullBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 5;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.125F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.125F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.49425F));
            this.tableLayoutPanel.Controls.Add(this.btn_search, 4, 1);
            this.tableLayoutPanel.Controls.Add(this.tb_Search, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.lb_tu_khoa, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.comboBox_SearchMode, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.lb_tim_kiem, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.lb_ds_phieu_mua_hang, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.dtgView_DS_phieu_mua_hang, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(800, 513);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn_search.Location = new System.Drawing.Point(709, 68);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(88, 29);
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
            this.tb_Search.Size = new System.Drawing.Size(306, 22);
            this.tb_Search.TabIndex = 9;
            // 
            // lb_tu_khoa
            // 
            this.lb_tu_khoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_tu_khoa.AutoSize = true;
            this.lb_tu_khoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_tu_khoa.Location = new System.Drawing.Point(325, 65);
            this.lb_tu_khoa.Name = "lb_tu_khoa";
            this.lb_tu_khoa.Size = new System.Drawing.Size(66, 35);
            this.lb_tu_khoa.TabIndex = 8;
            this.lb_tu_khoa.Text = "Từ khóa:";
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
            "Ngày lập phiếu (MM/yyyy)",
            "Tổng tiền"});
            this.comboBox_SearchMode.Location = new System.Drawing.Point(140, 68);
            this.comboBox_SearchMode.Name = "comboBox_SearchMode";
            this.comboBox_SearchMode.Size = new System.Drawing.Size(138, 24);
            this.comboBox_SearchMode.TabIndex = 7;
            this.comboBox_SearchMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_SearchMode_SelectedIndexChanged);
            // 
            // lb_tim_kiem
            // 
            this.lb_tim_kiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_tim_kiem.AutoSize = true;
            this.lb_tim_kiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lb_tim_kiem.Location = new System.Drawing.Point(28, 65);
            this.lb_tim_kiem.Name = "lb_tim_kiem";
            this.lb_tim_kiem.Size = new System.Drawing.Size(106, 35);
            this.lb_tim_kiem.TabIndex = 6;
            this.lb_tim_kiem.Text = "Tìm kiếm theo:";
            // 
            // lb_ds_phieu_mua_hang
            // 
            this.lb_ds_phieu_mua_hang.AutoSize = true;
            this.tableLayoutPanel.SetColumnSpan(this.lb_ds_phieu_mua_hang, 5);
            this.lb_ds_phieu_mua_hang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_ds_phieu_mua_hang.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ds_phieu_mua_hang.Location = new System.Drawing.Point(3, 0);
            this.lb_ds_phieu_mua_hang.Name = "lb_ds_phieu_mua_hang";
            this.lb_ds_phieu_mua_hang.Size = new System.Drawing.Size(794, 65);
            this.lb_ds_phieu_mua_hang.TabIndex = 3;
            this.lb_ds_phieu_mua_hang.Text = "Danh sách phiếu mua hàng";
            this.lb_ds_phieu_mua_hang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtgView_DS_phieu_mua_hang
            // 
            this.dtgView_DS_phieu_mua_hang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgView_DS_phieu_mua_hang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel.SetColumnSpan(this.dtgView_DS_phieu_mua_hang, 5);
            this.dtgView_DS_phieu_mua_hang.Location = new System.Drawing.Point(3, 103);
            this.dtgView_DS_phieu_mua_hang.Name = "dtgView_DS_phieu_mua_hang";
            this.dtgView_DS_phieu_mua_hang.RowHeadersWidth = 51;
            this.dtgView_DS_phieu_mua_hang.RowTemplate.Height = 24;
            this.dtgView_DS_phieu_mua_hang.Size = new System.Drawing.Size(794, 344);
            this.dtgView_DS_phieu_mua_hang.TabIndex = 0;
            this.dtgView_DS_phieu_mua_hang.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dtgView_DS_phieu_mua_hang_DataBindingComplete);
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
            // loadPhieuMH_byNgayLapTableAdapter
            // 
            this.loadPhieuMH_byNgayLapTableAdapter.ClearBeforeFill = true;
            // 
            // loadPhieuMH_byMaPhieuMHTableAdapter
            // 
            this.loadPhieuMH_byMaPhieuMHTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 457);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DSPhieuMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "DSPhieuMH";
            this.Text = "DSPhieuMH";
            this.Load += new System.EventHandler(this.DSPhieuMH_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgView_DS_phieu_mua_hang)).EndInit();
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
        private System.Windows.Forms.Label lb_tim_kiem;
        private System.Windows.Forms.ComboBox comboBox_SearchMode;
        private System.Windows.Forms.Label lb_tu_khoa;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Button btn_search;
        private QLDQDataSetTableAdapters.loadPhieuMH_byTongTienTableAdapter loadPhieuMH_byTongTienTableAdapter;
        private QLDQDataSetTableAdapters.loadPhieuMH_byTenNCCTableAdapter loadPhieuMH_byTenNCCTableAdapter;
        private QLDQDataSetTableAdapters.loadPhieuMH_byNgayLapTableAdapter loadPhieuMH_byNgayLapTableAdapter;
        private QLDQDataSetTableAdapters.loadPhieuMH_byMaPhieuMHTableAdapter loadPhieuMH_byMaPhieuMHTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}