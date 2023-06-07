
namespace QuanLyDaQuy.Phieu
{
    partial class PhieuBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_sophieu = new System.Windows.Forms.Label();
            this.lb_khachhang = new System.Windows.Forms.Label();
            this.lb_ngaylap = new System.Windows.Forms.Label();
            this.dgv_phieubanhang = new System.Windows.Forms.DataGridView();
            this.stt_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_col = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.lsp_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_sophieu = new System.Windows.Forms.TextBox();
            this.tb_ngaylap = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_sdt = new System.Windows.Forms.ComboBox();
            this.tb_tongtien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_khachhang = new System.Windows.Forms.ComboBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieubanhang)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_title.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(3, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(976, 50);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "PHIẾU BÁN HÀNG";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_sophieu
            // 
            this.lb_sophieu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sophieu.ForeColor = System.Drawing.Color.Black;
            this.lb_sophieu.Location = new System.Drawing.Point(40, 20);
            this.lb_sophieu.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.lb_sophieu.Name = "lb_sophieu";
            this.lb_sophieu.Size = new System.Drawing.Size(115, 24);
            this.lb_sophieu.TabIndex = 2;
            this.lb_sophieu.Text = "Số phiếu:";
            this.lb_sophieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_khachhang
            // 
            this.lb_khachhang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_khachhang.ForeColor = System.Drawing.Color.Black;
            this.lb_khachhang.Location = new System.Drawing.Point(490, 20);
            this.lb_khachhang.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.lb_khachhang.Name = "lb_khachhang";
            this.lb_khachhang.Size = new System.Drawing.Size(115, 18);
            this.lb_khachhang.TabIndex = 3;
            this.lb_khachhang.Text = "Khách hàng:";
            this.lb_khachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_ngaylap
            // 
            this.lb_ngaylap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaylap.ForeColor = System.Drawing.Color.Black;
            this.lb_ngaylap.Location = new System.Drawing.Point(40, 84);
            this.lb_ngaylap.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.lb_ngaylap.Name = "lb_ngaylap";
            this.lb_ngaylap.Size = new System.Drawing.Size(84, 18);
            this.lb_ngaylap.TabIndex = 4;
            this.lb_ngaylap.Text = "Ngày lập:";
            this.lb_ngaylap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_phieubanhang
            // 
            this.dgv_phieubanhang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_phieubanhang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_phieubanhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieubanhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt_col,
            this.sp_col,
            this.lsp_col,
            this.sl_col,
            this.dvt_col,
            this.dg_col,
            this.tt_col});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_phieubanhang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_phieubanhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_phieubanhang.GridColor = System.Drawing.Color.Silver;
            this.dgv_phieubanhang.Location = new System.Drawing.Point(3, 253);
            this.dgv_phieubanhang.Name = "dgv_phieubanhang";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_phieubanhang.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_phieubanhang.RowHeadersVisible = false;
            this.dgv_phieubanhang.RowHeadersWidth = 51;
            this.dgv_phieubanhang.RowTemplate.Height = 24;
            this.dgv_phieubanhang.Size = new System.Drawing.Size(976, 246);
            this.dgv_phieubanhang.TabIndex = 3;
            this.dgv_phieubanhang.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_phieubanhang_CellValueChanged);
            this.dgv_phieubanhang.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgv_phieubanhang_EditingControlShowing);
            this.dgv_phieubanhang.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgv_phieubanhang_RowsAdded);
            this.dgv_phieubanhang.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dgv_phieubanhang_RowsRemoved);
            // 
            // stt_col
            // 
            this.stt_col.HeaderText = "STT";
            this.stt_col.MinimumWidth = 6;
            this.stt_col.Name = "stt_col";
            this.stt_col.Width = 64;
            // 
            // sp_col
            // 
            this.sp_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sp_col.DataPropertyName = "TenSP";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sp_col.DefaultCellStyle = dataGridViewCellStyle2;
            this.sp_col.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.sp_col.DropDownWidth = 2;
            this.sp_col.HeaderText = "Sản phẩm";
            this.sp_col.MinimumWidth = 6;
            this.sp_col.Name = "sp_col";
            this.sp_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sp_col.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sp_col.Width = 101;
            // 
            // lsp_col
            // 
            this.lsp_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lsp_col.DataPropertyName = "TenLSP";
            this.lsp_col.HeaderText = "Loại sản phẩm";
            this.lsp_col.MinimumWidth = 6;
            this.lsp_col.Name = "lsp_col";
            this.lsp_col.ReadOnly = true;
            this.lsp_col.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.lsp_col.Width = 130;
            // 
            // sl_col
            // 
            this.sl_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sl_col.DataPropertyName = "SoLuongTon";
            this.sl_col.HeaderText = "Số lượng";
            this.sl_col.MinimumWidth = 6;
            this.sl_col.Name = "sl_col";
            this.sl_col.Width = 93;
            // 
            // dvt_col
            // 
            this.dvt_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dvt_col.DataPropertyName = "DVT";
            this.dvt_col.HeaderText = "Đơn vị tính";
            this.dvt_col.MinimumWidth = 6;
            this.dvt_col.Name = "dvt_col";
            this.dvt_col.ReadOnly = true;
            this.dvt_col.Width = 104;
            // 
            // dg_col
            // 
            this.dg_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dg_col.DataPropertyName = "DonGiaBan";
            this.dg_col.HeaderText = "Đơn giá";
            this.dg_col.MinimumWidth = 6;
            this.dg_col.Name = "dg_col";
            this.dg_col.ReadOnly = true;
            this.dg_col.Width = 86;
            // 
            // tt_col
            // 
            this.tt_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tt_col.HeaderText = "Thành tiền";
            this.tt_col.MinimumWidth = 6;
            this.tt_col.Name = "tt_col";
            this.tt_col.ReadOnly = true;
            this.tt_col.Width = 105;
            // 
            // tb_sophieu
            // 
            this.tb_sophieu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_sophieu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sophieu.Location = new System.Drawing.Point(198, 20);
            this.tb_sophieu.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tb_sophieu.Name = "tb_sophieu";
            this.tb_sophieu.ReadOnly = true;
            this.tb_sophieu.Size = new System.Drawing.Size(100, 25);
            this.tb_sophieu.TabIndex = 13;
            this.tb_sophieu.Text = "000";
            // 
            // tb_ngaylap
            // 
            this.tb_ngaylap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_ngaylap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ngaylap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ngaylap.Location = new System.Drawing.Point(198, 84);
            this.tb_ngaylap.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tb_ngaylap.Name = "tb_ngaylap";
            this.tb_ngaylap.ReadOnly = true;
            this.tb_ngaylap.Size = new System.Drawing.Size(100, 25);
            this.tb_ngaylap.TabIndex = 15;
            this.tb_ngaylap.Text = "20/20/2000";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_phieubanhang, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 502);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Controls.Add(this.lb_sophieu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_sophieu, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.cb_sdt, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_tongtien, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_ngaylap, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_ngaylap, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_khachhang, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.cb_khachhang, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(976, 194);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(490, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "SĐT:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_sdt
            // 
            this.cb_sdt.FormattingEnabled = true;
            this.cb_sdt.Location = new System.Drawing.Point(685, 84);
            this.cb_sdt.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.cb_sdt.Name = "cb_sdt";
            this.cb_sdt.Size = new System.Drawing.Size(180, 24);
            this.cb_sdt.TabIndex = 2;
            this.cb_sdt.Leave += new System.EventHandler(this.cb_sdt_Leave);
            // 
            // tb_tongtien
            // 
            this.tb_tongtien.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_tongtien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_tongtien.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tongtien.Location = new System.Drawing.Point(685, 148);
            this.tb_tongtien.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tb_tongtien.Name = "tb_tongtien";
            this.tb_tongtien.ReadOnly = true;
            this.tb_tongtien.Size = new System.Drawing.Size(180, 25);
            this.tb_tongtien.TabIndex = 20;
            this.tb_tongtien.Text = "0";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(490, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tổng tiền:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_khachhang
            // 
            this.cb_khachhang.FormattingEnabled = true;
            this.cb_khachhang.Location = new System.Drawing.Point(685, 20);
            this.cb_khachhang.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.cb_khachhang.Name = "cb_khachhang";
            this.cb_khachhang.Size = new System.Drawing.Size(180, 24);
            this.cb_khachhang.TabIndex = 1;
            this.cb_khachhang.SelectedIndexChanged += new System.EventHandler(this.cb_khachhang_SelectedIndexChanged);
            this.cb_khachhang.Leave += new System.EventHandler(this.cb_khachhang_Leave);
            // 
            // btn_ok
            // 
            this.btn_ok.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ok.Location = new System.Drawing.Point(768, 508);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 38);
            this.btn_ok.TabIndex = 18;
            this.btn_ok.Text = "Lập phiếu";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(12, 508);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 37);
            this.btn_delete.TabIndex = 19;
            this.btn_delete.Text = "Xóa dòng";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(874, 508);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 37);
            this.button1.TabIndex = 21;
            this.button1.Text = "Hủy phiếu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PhieuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btn_ok);
            this.Name = "PhieuBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PhieuBanHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieubanhang)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_sophieu;
        private System.Windows.Forms.Label lb_khachhang;
        private System.Windows.Forms.Label lb_ngaylap;
        private System.Windows.Forms.DataGridView dgv_phieubanhang;
        private System.Windows.Forms.TextBox tb_sophieu;
        private System.Windows.Forms.TextBox tb_ngaylap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cb_sdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_khachhang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_tongtien;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt_col;
        private System.Windows.Forms.DataGridViewComboBoxColumn sp_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn lsp_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt_col;
    }
}