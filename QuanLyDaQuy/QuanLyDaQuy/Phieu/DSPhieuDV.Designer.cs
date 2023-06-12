namespace QuanLyDaQuy.Phieu
{
    partial class DSPhieuDV
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_SearchMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loadPhieuDVFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDQDataSet = new QuanLyDaQuy.QLDQDataSet();
            this.mãPhiếuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênKháchHàngDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadPhieuDV_FullTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuDV_FullTableAdapter();
            this.loadPhieuDVbyTenKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadPhieuDV_byTenKHTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuDV_byTenKHTableAdapter();
            this.loadPhieuDVbySDTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadPhieuDV_bySDTTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuDV_bySDTTableAdapter();
            this.loadPhieuDVbyHoanThanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadPhieuDV_byHoanThanhTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuDV_byHoanThanhTableAdapter();
            this.loadPhieuDVbyChuaHoanThanhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loadPhieuDV_byChuaHoanThanhTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadPhieuDV_byChuaHoanThanhTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_Ngay = new System.Windows.Forms.ComboBox();
            this.comboBox_Thang = new System.Windows.Forms.ComboBox();
            this.textBox_Nam = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuDVFullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuDVbyTenKHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuDVbySDTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuDVbyHoanThanhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuDVbyChuaHoanThanhBindingSource)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_SearchMode, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Search, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(840, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label3.Location = new System.Drawing.Point(255, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 40);
            this.label3.TabIndex = 6;
            this.label3.Text = "Từ khóa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 5);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(834, 60);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách phiếu dịch vụ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 5);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(834, 304);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            // 
            // comboBox_SearchMode
            // 
            this.comboBox_SearchMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_SearchMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_SearchMode.FormattingEnabled = true;
            this.comboBox_SearchMode.Items.AddRange(new object[] {
            "Tất cả",
            "Tên khách hàng",
            "Số điện thoại",
            "Đã hoàn thành",
            "Chưa hoàn thành"});
            this.comboBox_SearchMode.Location = new System.Drawing.Point(133, 63);
            this.comboBox_SearchMode.Name = "comboBox_SearchMode";
            this.comboBox_SearchMode.Size = new System.Drawing.Size(116, 24);
            this.comboBox_SearchMode.TabIndex = 4;
            this.comboBox_SearchMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_SearchMode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tìm kiếm theo:";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Search.Location = new System.Drawing.Point(355, 63);
            this.textBox_Search.MaxLength = 100;
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(361, 22);
            this.textBox_Search.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.button1.Location = new System.Drawing.Point(722, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Tìm kiếm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadPhieuDVFullBindingSource
            // 
            this.loadPhieuDVFullBindingSource.DataMember = "loadPhieuDV_Full";
            this.loadPhieuDVFullBindingSource.DataSource = this.qLDQDataSet;
            // 
            // qLDQDataSet
            // 
            this.qLDQDataSet.DataSetName = "QLDQDataSet";
            this.qLDQDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mãPhiếuDataGridViewTextBoxColumn
            // 
            this.mãPhiếuDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mãPhiếuDataGridViewTextBoxColumn.DataPropertyName = "Mã phiếu";
            this.mãPhiếuDataGridViewTextBoxColumn.HeaderText = "Mã phiếu";
            this.mãPhiếuDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mãPhiếuDataGridViewTextBoxColumn.Name = "mãPhiếuDataGridViewTextBoxColumn";
            this.mãPhiếuDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tênKháchHàngDataGridViewTextBoxColumn
            // 
            this.tênKháchHàngDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tênKháchHàngDataGridViewTextBoxColumn.DataPropertyName = "Tên khách hàng";
            this.tênKháchHàngDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.tênKháchHàngDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tênKháchHàngDataGridViewTextBoxColumn.Name = "tênKháchHàngDataGridViewTextBoxColumn";
            this.tênKháchHàngDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loadPhieuDV_FullTableAdapter
            // 
            this.loadPhieuDV_FullTableAdapter.ClearBeforeFill = true;
            // 
            // loadPhieuDVbyTenKHBindingSource
            // 
            this.loadPhieuDVbyTenKHBindingSource.DataMember = "loadPhieuDV_byTenKH";
            this.loadPhieuDVbyTenKHBindingSource.DataSource = this.qLDQDataSet;
            // 
            // loadPhieuDV_byTenKHTableAdapter
            // 
            this.loadPhieuDV_byTenKHTableAdapter.ClearBeforeFill = true;
            // 
            // loadPhieuDVbySDTBindingSource
            // 
            this.loadPhieuDVbySDTBindingSource.DataMember = "loadPhieuDV_bySDT";
            this.loadPhieuDVbySDTBindingSource.DataSource = this.qLDQDataSet;
            // 
            // loadPhieuDV_bySDTTableAdapter
            // 
            this.loadPhieuDV_bySDTTableAdapter.ClearBeforeFill = true;
            // 
            // loadPhieuDVbyHoanThanhBindingSource
            // 
            this.loadPhieuDVbyHoanThanhBindingSource.DataMember = "loadPhieuDV_byHoanThanh";
            this.loadPhieuDVbyHoanThanhBindingSource.DataSource = this.qLDQDataSet;
            // 
            // loadPhieuDV_byHoanThanhTableAdapter
            // 
            this.loadPhieuDV_byHoanThanhTableAdapter.ClearBeforeFill = true;
            // 
            // loadPhieuDVbyChuaHoanThanhBindingSource
            // 
            this.loadPhieuDVbyChuaHoanThanhBindingSource.DataMember = "loadPhieuDV_byChuaHoanThanh";
            this.loadPhieuDVbyChuaHoanThanhBindingSource.DataSource = this.qLDQDataSet;
            // 
            // loadPhieuDV_byChuaHoanThanhTableAdapter
            // 
            this.loadPhieuDV_byChuaHoanThanhTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Mã phiếu";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Mã phiếu";
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.comboBox_Thang, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label6, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBox_Ngay, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox_Nam, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(133, 103);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(583, 34);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label5.Location = new System.Drawing.Point(197, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tháng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label6.Location = new System.Drawing.Point(391, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Năm";
            // 
            // comboBox_Ngay
            // 
            this.comboBox_Ngay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Ngay.FormattingEnabled = true;
            this.comboBox_Ngay.Location = new System.Drawing.Point(73, 3);
            this.comboBox_Ngay.Name = "comboBox_Ngay";
            this.comboBox_Ngay.Size = new System.Drawing.Size(118, 24);
            this.comboBox_Ngay.TabIndex = 3;
            // 
            // comboBox_Thang
            // 
            this.comboBox_Thang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Thang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Thang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_Thang.FormattingEnabled = true;
            this.comboBox_Thang.Location = new System.Drawing.Point(267, 3);
            this.comboBox_Thang.Name = "comboBox_Thang";
            this.comboBox_Thang.Size = new System.Drawing.Size(118, 24);
            this.comboBox_Thang.TabIndex = 4;
            this.comboBox_Thang.SelectedIndexChanged += new System.EventHandler(this.comboBox_Thang_SelectedIndexChanged);
            // 
            // textBox_Nam
            // 
            this.textBox_Nam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_Nam.Location = new System.Drawing.Point(461, 3);
            this.textBox_Nam.MaxLength = 5;
            this.textBox_Nam.Name = "textBox_Nam";
            this.textBox_Nam.Size = new System.Drawing.Size(119, 22);
            this.textBox_Nam.TabIndex = 5;
            this.textBox_Nam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nam_KeyPress);
            this.textBox_Nam.Leave += new System.EventHandler(this.textBox_Nam_FocusLeave);
            // 
            // DSPhieuDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "DSPhieuDV";
            this.Text = "Danh sách phiếu dịch vụ";
            this.Load += new System.EventHandler(this.DSPhieuDV_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuDVFullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuDVbyTenKHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuDVbySDTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuDVbyHoanThanhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadPhieuDVbyChuaHoanThanhBindingSource)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_SearchMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãPhiếuDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênKháchHàngDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngàyLậpDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tổngTiềnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn trảTrướcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cònLạiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tìnhTrạngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãPhiếuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênKháchHàngDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhieuDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayLapDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn traTruocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conLaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrangDataGridViewTextBoxColumn;
        private QLDQDataSet qLDQDataSet;
        private System.Windows.Forms.BindingSource loadPhieuDVFullBindingSource;
        private QLDQDataSetTableAdapters.loadPhieuDV_FullTableAdapter loadPhieuDV_FullTableAdapter;
        private System.Windows.Forms.BindingSource loadPhieuDVbyTenKHBindingSource;
        private QLDQDataSetTableAdapters.loadPhieuDV_byTenKHTableAdapter loadPhieuDV_byTenKHTableAdapter;
        private System.Windows.Forms.BindingSource loadPhieuDVbySDTBindingSource;
        private QLDQDataSetTableAdapters.loadPhieuDV_bySDTTableAdapter loadPhieuDV_bySDTTableAdapter;
        private System.Windows.Forms.BindingSource loadPhieuDVbyHoanThanhBindingSource;
        private QLDQDataSetTableAdapters.loadPhieuDV_byHoanThanhTableAdapter loadPhieuDV_byHoanThanhTableAdapter;
        private System.Windows.Forms.BindingSource loadPhieuDVbyChuaHoanThanhBindingSource;
        private QLDQDataSetTableAdapters.loadPhieuDV_byChuaHoanThanhTableAdapter loadPhieuDV_byChuaHoanThanhTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_Ngay;
        private System.Windows.Forms.ComboBox comboBox_Thang;
        private System.Windows.Forms.TextBox textBox_Nam;
    }
}