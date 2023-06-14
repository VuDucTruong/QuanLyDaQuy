
namespace QuanLyDaQuy.Phieu
{
    partial class DsPhieuBH
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_detail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_searchMode = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_keyWord = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.tb_day = new System.Windows.Forms.TextBox();
            this.tb_month = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_ds_pbh = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_pbh)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btn_detail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgv_ds_pbh, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(982, 553);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_detail
            // 
            this.btn_detail.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_detail.Location = new System.Drawing.Point(838, 506);
            this.btn_detail.Margin = new System.Windows.Forms.Padding(3, 10, 10, 10);
            this.btn_detail.Name = "btn_detail";
            this.btn_detail.Size = new System.Drawing.Size(134, 37);
            this.btn_detail.TabIndex = 7;
            this.btn_detail.Text = "Xem chi tiết phiếu";
            this.btn_detail.UseVisualStyleBackColor = true;
            this.btn_detail.Click += new System.EventHandler(this.btn_detail_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(976, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH PHIẾU BÁN HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.24055F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.598F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.973432F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.29778F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.890251F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbb_searchMode, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.tb_keyWord, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_search, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 58);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(976, 71);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(344, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 31);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm kiếm theo:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbb_searchMode
            // 
            this.cbb_searchMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbb_searchMode.Items.AddRange(new object[] {
            "Tất cả",
            "Mã phiếu",
            "Mã khách hàng",
            "Tên khách hàng",
            "Số điện thoại",
            "Ngày lập"});
            this.cbb_searchMode.Location = new System.Drawing.Point(112, 3);
            this.cbb_searchMode.Name = "cbb_searchMode";
            this.cbb_searchMode.Size = new System.Drawing.Size(175, 24);
            this.cbb_searchMode.TabIndex = 0;
            this.cbb_searchMode.SelectedIndexChanged += new System.EventHandler(this.cbb_searchMode_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(325, 5);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Từ khóa:";
            // 
            // tb_keyWord
            // 
            this.tb_keyWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_keyWord.Location = new System.Drawing.Point(390, 3);
            this.tb_keyWord.Name = "tb_keyWord";
            this.tb_keyWord.Size = new System.Drawing.Size(494, 22);
            this.tb_keyWord.TabIndex = 1;
            this.tb_keyWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_keyWord_KeyDown);
            // 
            // btn_search
            // 
            this.btn_search.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_search.Location = new System.Drawing.Point(890, 3);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 23);
            this.btn_search.TabIndex = 5;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_year, 4, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_day, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tb_month, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(390, 38);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(494, 30);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Right;
            this.label4.Location = new System.Drawing.Point(353, 5);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Năm";
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(395, 3);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(92, 22);
            this.tb_year.TabIndex = 4;
            this.tb_year.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_keyWord_KeyDown);
            // 
            // tb_day
            // 
            this.tb_day.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_day.Location = new System.Drawing.Point(3, 3);
            this.tb_day.Name = "tb_day";
            this.tb_day.Size = new System.Drawing.Size(92, 22);
            this.tb_day.TabIndex = 2;
            this.tb_day.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_keyWord_KeyDown);
            // 
            // tb_month
            // 
            this.tb_month.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_month.Location = new System.Drawing.Point(199, 3);
            this.tb_month.Name = "tb_month";
            this.tb_month.Size = new System.Drawing.Size(92, 22);
            this.tb_month.TabIndex = 3;
            this.tb_month.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_keyWord_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Right;
            this.label5.Location = new System.Drawing.Point(147, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tháng";
            // 
            // dgv_ds_pbh
            // 
            this.dgv_ds_pbh.AllowUserToAddRows = false;
            this.dgv_ds_pbh.AllowUserToDeleteRows = false;
            this.dgv_ds_pbh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ds_pbh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ds_pbh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ds_pbh.Location = new System.Drawing.Point(3, 135);
            this.dgv_ds_pbh.MultiSelect = false;
            this.dgv_ds_pbh.Name = "dgv_ds_pbh";
            this.dgv_ds_pbh.RowHeadersVisible = false;
            this.dgv_ds_pbh.RowHeadersWidth = 51;
            this.dgv_ds_pbh.RowTemplate.Height = 24;
            this.dgv_ds_pbh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ds_pbh.Size = new System.Drawing.Size(976, 358);
            this.dgv_ds_pbh.TabIndex = 6;
            this.dgv_ds_pbh.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_ds_pbh_CellFormatting);
            // 
            // DsPhieuBH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DsPhieuBH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DANH SÁCH PHIẾU BÁN HÀNG";
            this.Load += new System.EventHandler(this.DsPhieuBH_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_pbh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_searchMode;
        private System.Windows.Forms.TextBox tb_keyWord;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView dgv_ds_pbh;
        private System.Windows.Forms.Button btn_detail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.TextBox tb_day;
        private System.Windows.Forms.TextBox tb_month;
        private System.Windows.Forms.Label label5;
    }
}