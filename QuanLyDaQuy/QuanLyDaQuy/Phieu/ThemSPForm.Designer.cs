namespace QuanLyDaQuy.Phieu
{
    partial class ThemSPForm
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
            this.label_Title = new System.Windows.Forms.Label();
            this.MaSP_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.LoaiSP_cb = new System.Windows.Forms.ComboBox();
            this.loadLoaiSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDQDataSet = new QuanLyDaQuy.QLDQDataSet();
            this.SLT_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Mua_tb = new System.Windows.Forms.TextBox();
            this.TenSP_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.DVT_tb = new System.Windows.Forms.TextBox();
            this.insert_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.loadLoaiSanPhamTableAdapter = new QuanLyDaQuy.QLDQDataSetTableAdapters.loadLoaiSanPhamTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.loadLoaiSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_Title
            // 
            this.label_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(292, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(257, 33);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "THÊM MẶT HÀNG";
            // 
            // MaSP_tb
            // 
            this.MaSP_tb.Location = new System.Drawing.Point(106, 5);
            this.MaSP_tb.Name = "MaSP_tb";
            this.MaSP_tb.ReadOnly = true;
            this.MaSP_tb.Size = new System.Drawing.Size(177, 22);
            this.MaSP_tb.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Mã mặt hàng : ";
            // 
            // LoaiSP_cb
            // 
            this.LoaiSP_cb.DataSource = this.loadLoaiSanPhamBindingSource;
            this.LoaiSP_cb.DisplayMember = "TenLSP";
            this.LoaiSP_cb.FormattingEnabled = true;
            this.LoaiSP_cb.Location = new System.Drawing.Point(491, 5);
            this.LoaiSP_cb.Name = "LoaiSP_cb";
            this.LoaiSP_cb.Size = new System.Drawing.Size(177, 24);
            this.LoaiSP_cb.TabIndex = 32;
            // 
            // loadLoaiSanPhamBindingSource
            // 
            this.loadLoaiSanPhamBindingSource.DataMember = "loadLoaiSanPham";
            this.loadLoaiSanPhamBindingSource.DataSource = this.qLDQDataSet;
            // 
            // qLDQDataSet
            // 
            this.qLDQDataSet.DataSetName = "QLDQDataSet";
            this.qLDQDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // SLT_tb
            // 
            this.SLT_tb.Location = new System.Drawing.Point(491, 87);
            this.SLT_tb.Name = "SLT_tb";
            this.SLT_tb.Size = new System.Drawing.Size(177, 22);
            this.SLT_tb.TabIndex = 31;
            this.SLT_tb.Text = "\r\n";
            this.SLT_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SLT_tb_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 30;
            this.label7.Text = "Số lượng tồn :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "Đơn vị tính : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 28;
            this.label9.Text = "Loại mặt hàng : ";
            // 
            // Mua_tb
            // 
            this.Mua_tb.Location = new System.Drawing.Point(106, 87);
            this.Mua_tb.Name = "Mua_tb";
            this.Mua_tb.Size = new System.Drawing.Size(177, 22);
            this.Mua_tb.TabIndex = 25;
            this.Mua_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Mua_tb_KeyPress);
            // 
            // TenSP_tb
            // 
            this.TenSP_tb.Location = new System.Drawing.Point(106, 46);
            this.TenSP_tb.Name = "TenSP_tb";
            this.TenSP_tb.Size = new System.Drawing.Size(177, 22);
            this.TenSP_tb.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Đơn giá mua : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Mặt hàng : ";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.DVT_tb, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.SLT_tb, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.MaSP_tb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.LoaiSP_cb, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label8, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.TenSP_tb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Mua_tb, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label9, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 126);
            this.tableLayoutPanel1.TabIndex = 36;
            // 
            // DVT_tb
            // 
            this.DVT_tb.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.loadLoaiSanPhamBindingSource, "DVT", true));
            this.DVT_tb.Location = new System.Drawing.Point(491, 46);
            this.DVT_tb.Name = "DVT_tb";
            this.DVT_tb.Size = new System.Drawing.Size(177, 22);
            this.DVT_tb.TabIndex = 39;
            this.DVT_tb.Text = "\r\n";
            // 
            // insert_btn
            // 
            this.insert_btn.Location = new System.Drawing.Point(605, 237);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_btn.TabIndex = 37;
            this.insert_btn.Text = "Thêm";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(713, 237);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 38;
            this.cancel_btn.Text = "Hủy bỏ";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // loadLoaiSanPhamTableAdapter
            // 
            this.loadLoaiSanPhamTableAdapter.ClearBeforeFill = true;
            // 
            // ThemSPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 279);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_Title);
            this.Name = "ThemSPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM MẶT HÀNG";
            this.Load += new System.EventHandler(this.ThemSPForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadLoaiSanPhamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDQDataSet)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox MaSP_tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox LoaiSP_cb;
        private System.Windows.Forms.TextBox SLT_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Mua_tb;
        private System.Windows.Forms.TextBox TenSP_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.TextBox DVT_tb;
        private QLDQDataSet qLDQDataSet;
        private System.Windows.Forms.BindingSource loadLoaiSanPhamBindingSource;
        private QLDQDataSetTableAdapters.loadLoaiSanPhamTableAdapter loadLoaiSanPhamTableAdapter;
    }
}