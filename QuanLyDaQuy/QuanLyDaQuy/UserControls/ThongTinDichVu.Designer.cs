﻿namespace QuanLyDaQuy
{
    partial class ThongTinDichVu
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
            this.maDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGiaDVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loadDichVuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDQDataSet = new QuanLyDaQuy.QLDQDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DV_tb = new System.Windows.Forms.TextBox();
            this.DonGia_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.insert_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaDV_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadDichVuTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadDichVuTableAdapter();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadDichVuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.panel2.Location = new System.Drawing.Point(3, 263);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(948, 352);
            this.panel2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDVDataGridViewTextBoxColumn,
            this.tenDVDataGridViewTextBoxColumn,
            this.donGiaDVDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loadDichVuBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(946, 324);
            this.dataGridView1.TabIndex = 8;
            // 
            // maDVDataGridViewTextBoxColumn
            // 
            this.maDVDataGridViewTextBoxColumn.DataPropertyName = "MaDV";
            this.maDVDataGridViewTextBoxColumn.HeaderText = "Mã dịch vụ";
            this.maDVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maDVDataGridViewTextBoxColumn.Name = "maDVDataGridViewTextBoxColumn";
            this.maDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenDVDataGridViewTextBoxColumn
            // 
            this.tenDVDataGridViewTextBoxColumn.DataPropertyName = "TenDV";
            this.tenDVDataGridViewTextBoxColumn.HeaderText = "Tên dịch vụ";
            this.tenDVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDVDataGridViewTextBoxColumn.Name = "tenDVDataGridViewTextBoxColumn";
            this.tenDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // donGiaDVDataGridViewTextBoxColumn
            // 
            this.donGiaDVDataGridViewTextBoxColumn.DataPropertyName = "DonGiaDV";
            this.donGiaDVDataGridViewTextBoxColumn.HeaderText = "Đơn giá";
            this.donGiaDVDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.donGiaDVDataGridViewTextBoxColumn.Name = "donGiaDVDataGridViewTextBoxColumn";
            this.donGiaDVDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loadDichVuBindingSource
            // 
            this.loadDichVuBindingSource.DataMember = "loadDichVu";
            this.loadDichVuBindingSource.DataSource = this.qLDQDataSet;
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
            this.label4.Size = new System.Drawing.Size(122, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Danh sách dịch vụ :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(948, 100);
            this.label2.TabIndex = 10;
            this.label2.Text = "THÔNG TIN DỊCH VỤ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Dịch vụ : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Đơn giá : ";
            // 
            // DV_tb
            // 
            this.DV_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadDichVuBindingSource, "TenDV", true));
            this.DV_tb.Location = new System.Drawing.Point(104, 61);
            this.DV_tb.Name = "DV_tb";
            this.DV_tb.ReadOnly = true;
            this.DV_tb.Size = new System.Drawing.Size(177, 22);
            this.DV_tb.TabIndex = 3;
            // 
            // DonGia_tb
            // 
            this.DonGia_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadDichVuBindingSource, "DonGiaDV", true));
            this.DonGia_tb.Location = new System.Drawing.Point(104, 89);
            this.DonGia_tb.Name = "DonGia_tb";
            this.DonGia_tb.ReadOnly = true;
            this.DonGia_tb.Size = new System.Drawing.Size(177, 22);
            this.DonGia_tb.TabIndex = 4;
            this.DonGia_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Thông tin dịch vụ : ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.insert_btn);
            this.flowLayoutPanel1.Controls.Add(this.update_btn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(325, 89);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(162, 32);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // insert_btn
            // 
            this.insert_btn.AutoSize = true;
            this.insert_btn.Location = new System.Drawing.Point(3, 3);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 26);
            this.insert_btn.TabIndex = 6;
            this.insert_btn.Text = "Thêm";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_btn
            // 
            this.update_btn.AutoSize = true;
            this.update_btn.Location = new System.Drawing.Point(84, 3);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(75, 26);
            this.update_btn.TabIndex = 8;
            this.update_btn.Text = "Sửa";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.MaDV_tb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.DonGia_tb);
            this.panel1.Controls.Add(this.DV_tb);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 126);
            this.panel1.TabIndex = 11;
            // 
            // MaDV_tb
            // 
            this.MaDV_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadDichVuBindingSource, "MaDV", true));
            this.MaDV_tb.Location = new System.Drawing.Point(104, 33);
            this.MaDV_tb.Name = "MaDV_tb";
            this.MaDV_tb.ReadOnly = true;
            this.MaDV_tb.Size = new System.Drawing.Size(177, 22);
            this.MaDV_tb.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã dịch vụ : ";
            // 
            // loadDichVuTableAdapter
            // 
            this.loadDichVuTableAdapter.ClearBeforeFill = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(954, 618);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // ThongTinDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ThongTinDichVu";
            this.Size = new System.Drawing.Size(954, 618);
            this.Load += new System.EventHandler(this.ThongTinDichVu_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loadDichVuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DV_tb;
        private System.Windows.Forms.TextBox DonGia_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGiaDVDataGridViewTextBoxColumn;
        private QLDQDataSet qLDQDataSet;
        private System.Windows.Forms.TextBox MaDV_tb;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource loadDichVuBindingSource;
        private QLDQDataSetTableAdapters.loadDichVuTableAdapter loadDichVuTableAdapter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
