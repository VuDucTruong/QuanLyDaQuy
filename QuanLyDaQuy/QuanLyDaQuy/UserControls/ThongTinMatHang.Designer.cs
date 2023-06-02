namespace QuanLyDaQuy
{
    partial class ThongTinMatHang
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
            this.mãSảnPhẩmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênSảnPhẩmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tênLoạiSảnPhẩmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.đơnGiáBánDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.đơnGiáMuaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sốLượngTồnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.đơnVịTínhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadSanPhamFullBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDQDataSet = new QuanLyDaQuy.QLDQDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.loadSanPhamFullTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadSanPhamFullTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lOAISANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOAISANPHAMTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.LOAISANPHAMTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.sANPHAMTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.SANPHAMTableAdapter();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadSanPhamFullBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANPHAMBindingSource)).BeginInit();
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
            this.panel2.Size = new System.Drawing.Size(945, 357);
            this.panel2.TabIndex = 18;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mãSảnPhẩmDataGridViewTextBoxColumn,
            this.tênSảnPhẩmDataGridViewTextBoxColumn,
            this.tênLoạiSảnPhẩmDataGridViewTextBoxColumn,
            this.đơnGiáBánDataGridViewTextBoxColumn,
            this.đơnGiáMuaDataGridViewTextBoxColumn,
            this.sốLượngTồnDataGridViewTextBoxColumn,
            this.đơnVịTínhDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loadSanPhamFullBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(937, 324);
            this.dataGridView1.TabIndex = 8;
            // 
            // mãSảnPhẩmDataGridViewTextBoxColumn
            // 
            this.mãSảnPhẩmDataGridViewTextBoxColumn.DataPropertyName = "Mã sản phẩm";
            this.mãSảnPhẩmDataGridViewTextBoxColumn.HeaderText = "Mã mặt hàng";
            this.mãSảnPhẩmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mãSảnPhẩmDataGridViewTextBoxColumn.Name = "mãSảnPhẩmDataGridViewTextBoxColumn";
            this.mãSảnPhẩmDataGridViewTextBoxColumn.ReadOnly = true;
            this.mãSảnPhẩmDataGridViewTextBoxColumn.Width = 113;
            // 
            // tênSảnPhẩmDataGridViewTextBoxColumn
            // 
            this.tênSảnPhẩmDataGridViewTextBoxColumn.DataPropertyName = "Tên sản phẩm";
            this.tênSảnPhẩmDataGridViewTextBoxColumn.HeaderText = "Tên mặt hàng";
            this.tênSảnPhẩmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tênSảnPhẩmDataGridViewTextBoxColumn.Name = "tênSảnPhẩmDataGridViewTextBoxColumn";
            this.tênSảnPhẩmDataGridViewTextBoxColumn.ReadOnly = true;
            this.tênSảnPhẩmDataGridViewTextBoxColumn.Width = 118;
            // 
            // tênLoạiSảnPhẩmDataGridViewTextBoxColumn
            // 
            this.tênLoạiSảnPhẩmDataGridViewTextBoxColumn.DataPropertyName = "Tên loại sản phẩm";
            this.tênLoạiSảnPhẩmDataGridViewTextBoxColumn.HeaderText = "Tên loại mặt hàng";
            this.tênLoạiSảnPhẩmDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tênLoạiSảnPhẩmDataGridViewTextBoxColumn.Name = "tênLoạiSảnPhẩmDataGridViewTextBoxColumn";
            this.tênLoạiSảnPhẩmDataGridViewTextBoxColumn.ReadOnly = true;
            this.tênLoạiSảnPhẩmDataGridViewTextBoxColumn.Width = 143;
            // 
            // đơnGiáBánDataGridViewTextBoxColumn
            // 
            this.đơnGiáBánDataGridViewTextBoxColumn.DataPropertyName = "Đơn giá bán";
            this.đơnGiáBánDataGridViewTextBoxColumn.HeaderText = "Đơn giá bán";
            this.đơnGiáBánDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.đơnGiáBánDataGridViewTextBoxColumn.Name = "đơnGiáBánDataGridViewTextBoxColumn";
            this.đơnGiáBánDataGridViewTextBoxColumn.ReadOnly = true;
            this.đơnGiáBánDataGridViewTextBoxColumn.Width = 108;
            // 
            // đơnGiáMuaDataGridViewTextBoxColumn
            // 
            this.đơnGiáMuaDataGridViewTextBoxColumn.DataPropertyName = "Đơn giá mua";
            this.đơnGiáMuaDataGridViewTextBoxColumn.HeaderText = "Đơn giá mua";
            this.đơnGiáMuaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.đơnGiáMuaDataGridViewTextBoxColumn.Name = "đơnGiáMuaDataGridViewTextBoxColumn";
            this.đơnGiáMuaDataGridViewTextBoxColumn.ReadOnly = true;
            this.đơnGiáMuaDataGridViewTextBoxColumn.Width = 111;
            // 
            // sốLượngTồnDataGridViewTextBoxColumn
            // 
            this.sốLượngTồnDataGridViewTextBoxColumn.DataPropertyName = "Số lượng tồn";
            this.sốLượngTồnDataGridViewTextBoxColumn.HeaderText = "Số lượng tồn";
            this.sốLượngTồnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sốLượngTồnDataGridViewTextBoxColumn.Name = "sốLượngTồnDataGridViewTextBoxColumn";
            this.sốLượngTồnDataGridViewTextBoxColumn.ReadOnly = true;
            this.sốLượngTồnDataGridViewTextBoxColumn.Width = 110;
            // 
            // đơnVịTínhDataGridViewTextBoxColumn
            // 
            this.đơnVịTínhDataGridViewTextBoxColumn.DataPropertyName = "Đơn vị tính";
            this.đơnVịTínhDataGridViewTextBoxColumn.HeaderText = "Đơn vị tính";
            this.đơnVịTínhDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.đơnVịTínhDataGridViewTextBoxColumn.Name = "đơnVịTínhDataGridViewTextBoxColumn";
            this.đơnVịTínhDataGridViewTextBoxColumn.ReadOnly = true;
            this.đơnVịTínhDataGridViewTextBoxColumn.Width = 96;
            // 
            // loadSanPhamFullBindingSource
            // 
            this.loadSanPhamFullBindingSource.DataMember = "loadSanPhamFull";
            this.loadSanPhamFullBindingSource.DataSource = this.qLDQDataSet;
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
            this.label4.Size = new System.Drawing.Size(135, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Danh sách mặt hàng :";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(5, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 142);
            this.panel1.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadSanPhamFullBindingSource, "Số lượng tồn", true));
            this.textBox4.Location = new System.Drawing.Point(738, 49);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(177, 22);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(645, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Số lượng tồn :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(337, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Đơn vị tính : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadSanPhamFullBindingSource, "Tên loại sản phẩm", true));
            this.label9.Location = new System.Drawing.Point(337, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Loại mặt hàng : ";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadSanPhamFullBindingSource, "Đơn giá bán", true));
            this.textBox3.Location = new System.Drawing.Point(443, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 22);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Đơn giá bán :";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(778, 108);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(162, 29);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(84, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Sửa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thông tin mặt hàng : ";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadSanPhamFullBindingSource, "Đơn giá mua", true));
            this.textBox2.Location = new System.Drawing.Point(102, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadSanPhamFullBindingSource, "Tên sản phẩm", true));
            this.textBox1.Location = new System.Drawing.Point(102, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn giá mua : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mặt hàng : ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 32);
            this.label2.TabIndex = 16;
            this.label2.Text = "Thông tin mặt hàng";
            // 
            // loadSanPhamFullTableAdapter
            // 
            this.loadSanPhamFullTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadSanPhamFullBindingSource, "Tên loại sản phẩm", true));
            this.comboBox1.DataSource = this.lOAISANPHAMBindingSource;
            this.comboBox1.DisplayMember = "TenLSP";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(443, 77);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // lOAISANPHAMBindingSource
            // 
            this.lOAISANPHAMBindingSource.DataMember = "LOAISANPHAM";
            this.lOAISANPHAMBindingSource.DataSource = this.qLDQDataSet;
            // 
            // lOAISANPHAMTableAdapter
            // 
            this.lOAISANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadSanPhamFullBindingSource, "Đơn vị tính", true));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(443, 110);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 24);
            this.comboBox2.TabIndex = 19;
            // 
            // sANPHAMTableAdapter
            // 
            this.sANPHAMTableAdapter.ClearBeforeFill = true;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadSanPhamFullBindingSource, "Mã sản phẩm", true));
            this.textBox5.Location = new System.Drawing.Point(102, 49);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(177, 22);
            this.textBox5.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Mã mặt hàng : ";
            // 
            // ThongTinMatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Name = "ThongTinMatHang";
            this.Size = new System.Drawing.Size(954, 618);
            this.Load += new System.EventHandler(this.ThongTinMatHang_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadSanPhamFullBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANPHAMBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource loadSanPhamFullBindingSource;
        private QLDQDataSet qLDQDataSet;
        private QLDQDataSetTableAdapters.loadSanPhamFullTableAdapter loadSanPhamFullTableAdapter;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn mãSảnPhẩmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênSảnPhẩmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tênLoạiSảnPhẩmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn đơnGiáBánDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn đơnGiáMuaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sốLượngTồnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn đơnVịTínhDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource lOAISANPHAMBindingSource;
        private QLDQDataSetTableAdapters.LOAISANPHAMTableAdapter lOAISANPHAMTableAdapter;
        private QLDQDataSetTableAdapters.SANPHAMTableAdapter sANPHAMTableAdapter;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
    }
}
