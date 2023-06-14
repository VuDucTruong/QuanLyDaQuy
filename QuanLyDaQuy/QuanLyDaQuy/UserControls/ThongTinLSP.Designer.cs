namespace QuanLyDaQuy.UserControls
{
    partial class ThongTinLSP
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lOAISANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDQDataSet = new QuanLyDaQuy.QLDQDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaDVT_tb_1 = new System.Windows.Forms.TextBox();
            this.MaDVT_cb = new System.Windows.Forms.ComboBox();
            this.dONVITINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MaLSP_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.insertLSP_btn = new System.Windows.Forms.Button();
            this.updateLSP_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.LoiNhuan_tb = new System.Windows.Forms.TextBox();
            this.TenLSP_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.lOAISANPHAMTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.LOAISANPHAMTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.insertDVT_btn = new System.Windows.Forms.Button();
            this.updateDVT_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.DVT_tb = new System.Windows.Forms.TextBox();
            this.MaDVT_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dONVITINHTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.DONVITINHTableAdapter();
            this.maDVTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loiNhuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dONVITINHBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(5, 252);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(543, 357);
            this.panel2.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLSPDataGridViewTextBoxColumn,
            this.tenLSPDataGridViewTextBoxColumn,
            this.loiNhuanDataGridViewTextBoxColumn,
            this.maDVTDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lOAISANPHAMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(535, 324);
            this.dataGridView1.TabIndex = 8;
            // 
            // lOAISANPHAMBindingSource
            // 
            this.lOAISANPHAMBindingSource.DataMember = "LOAISANPHAM";
            this.lOAISANPHAMBindingSource.DataSource = this.qLDQDataSet;
            // 
            // qLDQDataSet
            // 
            this.qLDQDataSet.DataSetName = "QLDQDataSet";
            this.qLDQDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Danh sách loại sản phẩm :";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MaDVT_tb_1);
            this.panel1.Controls.Add(this.MaDVT_cb);
            this.panel1.Controls.Add(this.MaLSP_tb);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.LoiNhuan_tb);
            this.panel1.Controls.Add(this.TenLSP_tb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(522, 165);
            this.panel1.TabIndex = 14;
            // 
            // MaDVT_tb_1
            // 
            this.MaDVT_tb_1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAISANPHAMBindingSource, "MaDVT", true));
            this.MaDVT_tb_1.Location = new System.Drawing.Point(142, 131);
            this.MaDVT_tb_1.Name = "MaDVT_tb_1";
            this.MaDVT_tb_1.ReadOnly = true;
            this.MaDVT_tb_1.Size = new System.Drawing.Size(177, 22);
            this.MaDVT_tb_1.TabIndex = 18;
            // 
            // MaDVT_cb
            // 
            this.MaDVT_cb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAISANPHAMBindingSource, "MaDVT", true));
            this.MaDVT_cb.DataSource = this.dONVITINHBindingSource;
            this.MaDVT_cb.DisplayMember = "MaDVT";
            this.MaDVT_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MaDVT_cb.FormattingEnabled = true;
            this.MaDVT_cb.Location = new System.Drawing.Point(142, 130);
            this.MaDVT_cb.Name = "MaDVT_cb";
            this.MaDVT_cb.Size = new System.Drawing.Size(177, 24);
            this.MaDVT_cb.TabIndex = 18;
            this.MaDVT_cb.Visible = false;
            // 
            // dONVITINHBindingSource
            // 
            this.dONVITINHBindingSource.DataMember = "DONVITINH";
            this.dONVITINHBindingSource.DataSource = this.qLDQDataSet;
            // 
            // MaLSP_tb
            // 
            this.MaLSP_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAISANPHAMBindingSource, "MaLSP", true));
            this.MaLSP_tb.Location = new System.Drawing.Point(142, 46);
            this.MaLSP_tb.Name = "MaLSP_tb";
            this.MaLSP_tb.ReadOnly = true;
            this.MaLSP_tb.Size = new System.Drawing.Size(177, 22);
            this.MaLSP_tb.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mã loại sản phẩm : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã đơn vị tính : ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.insertLSP_btn);
            this.flowLayoutPanel1.Controls.Add(this.updateLSP_btn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(355, 127);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(162, 33);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // insertLSP_btn
            // 
            this.insertLSP_btn.AutoSize = true;
            this.insertLSP_btn.Location = new System.Drawing.Point(3, 3);
            this.insertLSP_btn.Name = "insertLSP_btn";
            this.insertLSP_btn.Size = new System.Drawing.Size(75, 27);
            this.insertLSP_btn.TabIndex = 6;
            this.insertLSP_btn.Text = "Thêm";
            this.insertLSP_btn.UseVisualStyleBackColor = true;
            this.insertLSP_btn.Click += new System.EventHandler(this.insertLSP_btn_Click);
            // 
            // updateLSP_btn
            // 
            this.updateLSP_btn.AutoSize = true;
            this.updateLSP_btn.Location = new System.Drawing.Point(84, 3);
            this.updateLSP_btn.Name = "updateLSP_btn";
            this.updateLSP_btn.Size = new System.Drawing.Size(75, 27);
            this.updateLSP_btn.TabIndex = 8;
            this.updateLSP_btn.Text = "Sửa";
            this.updateLSP_btn.UseVisualStyleBackColor = true;
            this.updateLSP_btn.Click += new System.EventHandler(this.updateLSP_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thông tin loại sản phẩm : ";
            // 
            // LoiNhuan_tb
            // 
            this.LoiNhuan_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAISANPHAMBindingSource, "LoiNhuan", true));
            this.LoiNhuan_tb.Location = new System.Drawing.Point(142, 102);
            this.LoiNhuan_tb.Name = "LoiNhuan_tb";
            this.LoiNhuan_tb.ReadOnly = true;
            this.LoiNhuan_tb.Size = new System.Drawing.Size(177, 22);
            this.LoiNhuan_tb.TabIndex = 4;
            this.LoiNhuan_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.LoiNhuan_tb_KeyPress);
            // 
            // TenLSP_tb
            // 
            this.TenLSP_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAISANPHAMBindingSource, "TenLSP", true));
            this.TenLSP_tb.Location = new System.Drawing.Point(142, 74);
            this.TenLSP_tb.Name = "TenLSP_tb";
            this.TenLSP_tb.ReadOnly = true;
            this.TenLSP_tb.Size = new System.Drawing.Size(177, 22);
            this.TenLSP_tb.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Lợi nhuận : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên loại sản phẩm : ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "THÔNG TIN LOẠI SẢN PHẨM";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGridView2);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(554, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 357);
            this.panel4.TabIndex = 17;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDVTDataGridViewTextBoxColumn1,
            this.dVTDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.dONVITINHBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(3, 28);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(389, 324);
            this.dataGridView2.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Danh sách đơn vị tính :";
            // 
            // lOAISANPHAMTableAdapter
            // 
            this.lOAISANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.flowLayoutPanel2);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.DVT_tb);
            this.panel3.Controls.Add(this.MaDVT_tb);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(554, 93);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.panel3.Size = new System.Drawing.Size(387, 145);
            this.panel3.TabIndex = 15;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.insertDVT_btn);
            this.flowLayoutPanel2.Controls.Add(this.updateDVT_btn);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(220, 107);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(162, 33);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // insertDVT_btn
            // 
            this.insertDVT_btn.AutoSize = true;
            this.insertDVT_btn.Location = new System.Drawing.Point(3, 3);
            this.insertDVT_btn.Name = "insertDVT_btn";
            this.insertDVT_btn.Size = new System.Drawing.Size(75, 27);
            this.insertDVT_btn.TabIndex = 6;
            this.insertDVT_btn.Text = "Thêm";
            this.insertDVT_btn.UseVisualStyleBackColor = true;
            this.insertDVT_btn.Click += new System.EventHandler(this.insertDVT_btn_Click);
            // 
            // updateDVT_btn
            // 
            this.updateDVT_btn.AutoSize = true;
            this.updateDVT_btn.Location = new System.Drawing.Point(84, 3);
            this.updateDVT_btn.Name = "updateDVT_btn";
            this.updateDVT_btn.Size = new System.Drawing.Size(75, 27);
            this.updateDVT_btn.TabIndex = 8;
            this.updateDVT_btn.Text = "Sửa";
            this.updateDVT_btn.UseVisualStyleBackColor = true;
            this.updateDVT_btn.Click += new System.EventHandler(this.updateDVT_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 8);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Thông tin đơn vị tính : ";
            // 
            // DVT_tb
            // 
            this.DVT_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dONVITINHBindingSource, "DVT", true));
            this.DVT_tb.Location = new System.Drawing.Point(122, 68);
            this.DVT_tb.Name = "DVT_tb";
            this.DVT_tb.ReadOnly = true;
            this.DVT_tb.Size = new System.Drawing.Size(111, 22);
            this.DVT_tb.TabIndex = 4;
            // 
            // MaDVT_tb
            // 
            this.MaDVT_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dONVITINHBindingSource, "MaDVT", true));
            this.MaDVT_tb.Location = new System.Drawing.Point(122, 37);
            this.MaDVT_tb.Name = "MaDVT_tb";
            this.MaDVT_tb.ReadOnly = true;
            this.MaDVT_tb.Size = new System.Drawing.Size(111, 22);
            this.MaDVT_tb.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Đơn vị tính : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã đơn vị tính : ";
            // 
            // dONVITINHTableAdapter
            // 
            this.dONVITINHTableAdapter.ClearBeforeFill = true;
            // 
            // maDVTDataGridViewTextBoxColumn1
            // 
            this.maDVTDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maDVTDataGridViewTextBoxColumn1.DataPropertyName = "MaDVT";
            this.maDVTDataGridViewTextBoxColumn1.HeaderText = "MaDVT";
            this.maDVTDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.maDVTDataGridViewTextBoxColumn1.Name = "maDVTDataGridViewTextBoxColumn1";
            this.maDVTDataGridViewTextBoxColumn1.ReadOnly = true;
            this.maDVTDataGridViewTextBoxColumn1.Width = 83;
            // 
            // dVTDataGridViewTextBoxColumn
            // 
            this.dVTDataGridViewTextBoxColumn.DataPropertyName = "DVT";
            this.dVTDataGridViewTextBoxColumn.HeaderText = "DVT";
            this.dVTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dVTDataGridViewTextBoxColumn.Name = "dVTDataGridViewTextBoxColumn";
            this.dVTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maLSPDataGridViewTextBoxColumn
            // 
            this.maLSPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maLSPDataGridViewTextBoxColumn.DataPropertyName = "MaLSP";
            this.maLSPDataGridViewTextBoxColumn.HeaderText = "MaLSP";
            this.maLSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLSPDataGridViewTextBoxColumn.Name = "maLSPDataGridViewTextBoxColumn";
            this.maLSPDataGridViewTextBoxColumn.ReadOnly = true;
            this.maLSPDataGridViewTextBoxColumn.Width = 80;
            // 
            // tenLSPDataGridViewTextBoxColumn
            // 
            this.tenLSPDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenLSPDataGridViewTextBoxColumn.DataPropertyName = "TenLSP";
            this.tenLSPDataGridViewTextBoxColumn.HeaderText = "TenLSP";
            this.tenLSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLSPDataGridViewTextBoxColumn.Name = "tenLSPDataGridViewTextBoxColumn";
            this.tenLSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loiNhuanDataGridViewTextBoxColumn
            // 
            this.loiNhuanDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.loiNhuanDataGridViewTextBoxColumn.DataPropertyName = "LoiNhuan";
            this.loiNhuanDataGridViewTextBoxColumn.HeaderText = "LoiNhuan";
            this.loiNhuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loiNhuanDataGridViewTextBoxColumn.Name = "loiNhuanDataGridViewTextBoxColumn";
            this.loiNhuanDataGridViewTextBoxColumn.ReadOnly = true;
            this.loiNhuanDataGridViewTextBoxColumn.Width = 93;
            // 
            // maDVTDataGridViewTextBoxColumn
            // 
            this.maDVTDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maDVTDataGridViewTextBoxColumn.DataPropertyName = "MaDVT";
            this.maDVTDataGridViewTextBoxColumn.HeaderText = "MaDVT";
            this.maDVTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDVTDataGridViewTextBoxColumn.Name = "maDVTDataGridViewTextBoxColumn";
            this.maDVTDataGridViewTextBoxColumn.ReadOnly = true;
            this.maDVTDataGridViewTextBoxColumn.Width = 83;
            // 
            // ThongTinLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "ThongTinLSP";
            this.Size = new System.Drawing.Size(954, 618);
            this.Load += new System.EventHandler(this.ThongTinLSP_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANPHAMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dONVITINHBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button insertLSP_btn;
        private System.Windows.Forms.Button updateLSP_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox LoiNhuan_tb;
        private System.Windows.Forms.TextBox TenLSP_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.BindingSource lOAISANPHAMBindingSource;
        private QLDQDataSet qLDQDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dONVITINHBindingSource;
        private QLDQDataSetTableAdapters.LOAISANPHAMTableAdapter lOAISANPHAMTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button insertDVT_btn;
        private System.Windows.Forms.Button updateDVT_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DVT_tb;
        private System.Windows.Forms.TextBox MaDVT_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private QLDQDataSetTableAdapters.DONVITINHTableAdapter dONVITINHTableAdapter;
        private System.Windows.Forms.TextBox MaLSP_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox MaDVT_cb;
        private System.Windows.Forms.TextBox MaDVT_tb_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loiNhuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDVTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTDataGridViewTextBoxColumn;
    }
}
