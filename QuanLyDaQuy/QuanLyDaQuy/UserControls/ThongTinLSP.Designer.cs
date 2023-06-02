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
            this.maLSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLSPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loiNhuanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lOAISANPHAMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDQDataSet = new QuanLyDaQuy.QLDQDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.maDVTDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dVTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dONVITINHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.lOAISANPHAMTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.LOAISANPHAMTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dONVITINHTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.DONVITINHTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOAISANPHAMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONVITINHBindingSource)).BeginInit();
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
            // maLSPDataGridViewTextBoxColumn
            // 
            this.maLSPDataGridViewTextBoxColumn.DataPropertyName = "MaLSP";
            this.maLSPDataGridViewTextBoxColumn.HeaderText = "MaLSP";
            this.maLSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maLSPDataGridViewTextBoxColumn.Name = "maLSPDataGridViewTextBoxColumn";
            this.maLSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLSPDataGridViewTextBoxColumn
            // 
            this.tenLSPDataGridViewTextBoxColumn.DataPropertyName = "TenLSP";
            this.tenLSPDataGridViewTextBoxColumn.HeaderText = "TenLSP";
            this.tenLSPDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLSPDataGridViewTextBoxColumn.Name = "tenLSPDataGridViewTextBoxColumn";
            this.tenLSPDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loiNhuanDataGridViewTextBoxColumn
            // 
            this.loiNhuanDataGridViewTextBoxColumn.DataPropertyName = "LoiNhuan";
            this.loiNhuanDataGridViewTextBoxColumn.HeaderText = "LoiNhuan";
            this.loiNhuanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.loiNhuanDataGridViewTextBoxColumn.Name = "loiNhuanDataGridViewTextBoxColumn";
            this.loiNhuanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // maDVTDataGridViewTextBoxColumn
            // 
            this.maDVTDataGridViewTextBoxColumn.DataPropertyName = "MaDVT";
            this.maDVTDataGridViewTextBoxColumn.HeaderText = "MaDVT";
            this.maDVTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDVTDataGridViewTextBoxColumn.Name = "maDVTDataGridViewTextBoxColumn";
            this.maDVTDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.panel1.Controls.Add(this.textBox4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 161);
            this.panel1.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAISANPHAMBindingSource, "MaLSP", true));
            this.textBox4.Location = new System.Drawing.Point(142, 46);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(177, 22);
            this.textBox4.TabIndex = 13;
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
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAISANPHAMBindingSource, "MaDVT", true));
            this.textBox3.Location = new System.Drawing.Point(142, 134);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 22);
            this.textBox3.TabIndex = 11;
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
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Controls.Add(this.button3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(382, 127);
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
            this.label3.Location = new System.Drawing.Point(9, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thông tin loại sản phẩm : ";
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAISANPHAMBindingSource, "LoiNhuan", true));
            this.textBox2.Location = new System.Drawing.Point(142, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lOAISANPHAMBindingSource, "TenLSP", true));
            this.textBox1.Location = new System.Drawing.Point(142, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 22);
            this.textBox1.TabIndex = 3;
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(340, 32);
            this.label2.TabIndex = 13;
            this.label2.Text = "Thông tin loại sản phẩm";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.dataGridView3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(554, 252);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(397, 357);
            this.panel4.TabIndex = 17;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDVTDataGridViewTextBoxColumn1,
            this.dVTDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.dONVITINHBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(3, 28);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(389, 324);
            this.dataGridView3.TabIndex = 8;
            // 
            // maDVTDataGridViewTextBoxColumn1
            // 
            this.maDVTDataGridViewTextBoxColumn1.DataPropertyName = "MaDVT";
            this.maDVTDataGridViewTextBoxColumn1.HeaderText = "MaDVT";
            this.maDVTDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.maDVTDataGridViewTextBoxColumn1.Name = "maDVTDataGridViewTextBoxColumn1";
            this.maDVTDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dVTDataGridViewTextBoxColumn
            // 
            this.dVTDataGridViewTextBoxColumn.DataPropertyName = "DVT";
            this.dVTDataGridViewTextBoxColumn.HeaderText = "DVT";
            this.dVTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dVTDataGridViewTextBoxColumn.Name = "dVTDataGridViewTextBoxColumn";
            this.dVTDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dONVITINHBindingSource
            // 
            this.dONVITINHBindingSource.DataMember = "DONVITINH";
            this.dONVITINHBindingSource.DataSource = this.qLDQDataSet;
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
            this.panel3.Controls.Add(this.textBox5);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Location = new System.Drawing.Point(554, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(395, 104);
            this.panel3.TabIndex = 15;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.button2);
            this.flowLayoutPanel2.Controls.Add(this.button4);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(228, 70);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(162, 29);
            this.flowLayoutPanel2.TabIndex = 9;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thêm";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(84, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Sửa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Thông tin đơn vị tính : ";
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dONVITINHBindingSource, "DVT", true));
            this.textBox5.Location = new System.Drawing.Point(108, 77);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(111, 22);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.dONVITINHBindingSource, "MaDVT", true));
            this.textBox6.Location = new System.Drawing.Point(108, 49);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(111, 22);
            this.textBox6.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "Đơn vị tính : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Mã đơn vị tính : ";
            // 
            // dONVITINHTableAdapter
            // 
            this.dONVITINHTableAdapter.ClearBeforeFill = true;
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
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dONVITINHBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLSPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loiNhuanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource lOAISANPHAMBindingSource;
        private QLDQDataSet qLDQDataSet;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDVTDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dVTDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dONVITINHBindingSource;
        private QLDQDataSetTableAdapters.LOAISANPHAMTableAdapter lOAISANPHAMTableAdapter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private QLDQDataSetTableAdapters.DONVITINHTableAdapter dONVITINHTableAdapter;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
    }
}
