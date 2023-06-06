
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
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_sophieu = new System.Windows.Forms.Label();
            this.lb_khachhang = new System.Windows.Forms.Label();
            this.lb_ngaylap = new System.Windows.Forms.Label();
            this.dgv_phieumuahang = new System.Windows.Forms.DataGridView();
            this.tb_sophieu = new System.Windows.Forms.TextBox();
            this.tb_khachhang = new System.Windows.Forms.TextBox();
            this.tb_ngaylap = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.stt_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sp_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lsp_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sl_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvt_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dg_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tt_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieumuahang)).BeginInit();
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
            this.lb_title.Size = new System.Drawing.Size(794, 45);
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
            this.lb_sophieu.Size = new System.Drawing.Size(126, 24);
            this.lb_sophieu.TabIndex = 2;
            this.lb_sophieu.Text = "Số phiếu:";
            this.lb_sophieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_khachhang
            // 
            this.lb_khachhang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_khachhang.ForeColor = System.Drawing.Color.Black;
            this.lb_khachhang.Location = new System.Drawing.Point(40, 84);
            this.lb_khachhang.Margin = new System.Windows.Forms.Padding(40, 20, 3, 0);
            this.lb_khachhang.Name = "lb_khachhang";
            this.lb_khachhang.Size = new System.Drawing.Size(126, 18);
            this.lb_khachhang.TabIndex = 3;
            this.lb_khachhang.Text = "Khách hàng:";
            this.lb_khachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_ngaylap
            // 
            this.lb_ngaylap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaylap.ForeColor = System.Drawing.Color.Black;
            this.lb_ngaylap.Location = new System.Drawing.Point(532, 20);
            this.lb_ngaylap.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.lb_ngaylap.Name = "lb_ngaylap";
            this.lb_ngaylap.Size = new System.Drawing.Size(84, 18);
            this.lb_ngaylap.TabIndex = 4;
            this.lb_ngaylap.Text = "Ngày lập:";
            this.lb_ngaylap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_phieumuahang
            // 
            this.dgv_phieumuahang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieumuahang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt_col,
            this.sp_col,
            this.lsp_col,
            this.sl_col,
            this.dvt_col,
            this.dg_col,
            this.tt_col});
            this.dgv_phieumuahang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_phieumuahang.GridColor = System.Drawing.Color.Silver;
            this.dgv_phieumuahang.Location = new System.Drawing.Point(3, 187);
            this.dgv_phieumuahang.Name = "dgv_phieumuahang";
            this.dgv_phieumuahang.RowHeadersWidth = 51;
            this.dgv_phieumuahang.RowTemplate.Height = 24;
            this.dgv_phieumuahang.Size = new System.Drawing.Size(794, 260);
            this.dgv_phieumuahang.TabIndex = 12;
            // 
            // tb_sophieu
            // 
            this.tb_sophieu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_sophieu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sophieu.Location = new System.Drawing.Point(172, 20);
            this.tb_sophieu.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tb_sophieu.Name = "tb_sophieu";
            this.tb_sophieu.Size = new System.Drawing.Size(220, 25);
            this.tb_sophieu.TabIndex = 13;
            this.tb_sophieu.Text = "001";
            // 
            // tb_khachhang
            // 
            this.tb_khachhang.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_khachhang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_khachhang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_khachhang.Location = new System.Drawing.Point(172, 84);
            this.tb_khachhang.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tb_khachhang.Name = "tb_khachhang";
            this.tb_khachhang.Size = new System.Drawing.Size(300, 25);
            this.tb_khachhang.TabIndex = 14;
            this.tb_khachhang.Text = "TriPero";
            // 
            // tb_ngaylap
            // 
            this.tb_ngaylap.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tb_ngaylap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ngaylap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ngaylap.Location = new System.Drawing.Point(631, 20);
            this.tb_ngaylap.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.tb_ngaylap.Name = "tb_ngaylap";
            this.tb_ngaylap.Size = new System.Drawing.Size(159, 25);
            this.tb_ngaylap.TabIndex = 15;
            this.tb_ngaylap.Text = "2/3/2023";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgv_phieumuahang, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_title, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.88889F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.07547F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.92453F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.Controls.Add(this.lb_sophieu, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_sophieu, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_ngaylap, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_khachhang, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_khachhang, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lb_ngaylap, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 48);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 133);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // stt_col
            // 
            this.stt_col.HeaderText = "STT";
            this.stt_col.MinimumWidth = 6;
            this.stt_col.Name = "stt_col";
            this.stt_col.Width = 50;
            // 
            // sp_col
            // 
            this.sp_col.HeaderText = "Sản phẩm";
            this.sp_col.MinimumWidth = 6;
            this.sp_col.Name = "sp_col";
            this.sp_col.Width = 125;
            // 
            // lsp_col
            // 
            this.lsp_col.HeaderText = "Loại sản phẩm";
            this.lsp_col.MinimumWidth = 6;
            this.lsp_col.Name = "lsp_col";
            this.lsp_col.Width = 125;
            // 
            // sl_col
            // 
            this.sl_col.HeaderText = "Số lượng";
            this.sl_col.MinimumWidth = 6;
            this.sl_col.Name = "sl_col";
            this.sl_col.Width = 75;
            // 
            // dvt_col
            // 
            this.dvt_col.HeaderText = "Đơn vị tính";
            this.dvt_col.MinimumWidth = 6;
            this.dvt_col.Name = "dvt_col";
            // 
            // dg_col
            // 
            this.dg_col.HeaderText = "Đơn giá";
            this.dg_col.MinimumWidth = 6;
            this.dg_col.Name = "dg_col";
            this.dg_col.Width = 125;
            // 
            // tt_col
            // 
            this.tt_col.HeaderText = "Thành tiền";
            this.tt_col.MinimumWidth = 6;
            this.tt_col.Name = "tt_col";
            this.tt_col.Width = 125;
            // 
            // PhieuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PhieuBanHang";
            this.Text = "PhieuBanHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieumuahang)).EndInit();
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
        private System.Windows.Forms.DataGridView dgv_phieumuahang;
        private System.Windows.Forms.TextBox tb_sophieu;
        private System.Windows.Forms.TextBox tb_khachhang;
        private System.Windows.Forms.TextBox tb_ngaylap;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn sp_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn lsp_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn sl_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvt_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn dg_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn tt_col;
    }
}