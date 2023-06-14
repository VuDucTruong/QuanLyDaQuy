
namespace QuanLyDaQuy.Phieu
{
    partial class ThayDoiThamSo
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
            this.dgv_ds_thamSo = new System.Windows.Forms.DataGridView();
            this.maTS_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTS_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giatri_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_thamSo)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ds_thamSo
            // 
            this.dgv_ds_thamSo.AllowUserToAddRows = false;
            this.dgv_ds_thamSo.AllowUserToDeleteRows = false;
            this.dgv_ds_thamSo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ds_thamSo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTS_col,
            this.tenTS_col,
            this.giatri_col});
            this.dgv_ds_thamSo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_ds_thamSo.Location = new System.Drawing.Point(3, 53);
            this.dgv_ds_thamSo.Name = "dgv_ds_thamSo";
            this.dgv_ds_thamSo.RowHeadersVisible = false;
            this.dgv_ds_thamSo.RowHeadersWidth = 51;
            this.dgv_ds_thamSo.RowTemplate.Height = 24;
            this.dgv_ds_thamSo.Size = new System.Drawing.Size(636, 172);
            this.dgv_ds_thamSo.TabIndex = 0;
            // 
            // maTS_col
            // 
            this.maTS_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.maTS_col.DataPropertyName = "MaThamSo";
            this.maTS_col.HeaderText = "Mã tham số";
            this.maTS_col.MinimumWidth = 6;
            this.maTS_col.Name = "maTS_col";
            this.maTS_col.ReadOnly = true;
            this.maTS_col.Width = 105;
            // 
            // tenTS_col
            // 
            this.tenTS_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenTS_col.DataPropertyName = "TenThamSo";
            this.tenTS_col.HeaderText = "Tên tham số";
            this.tenTS_col.MinimumWidth = 6;
            this.tenTS_col.Name = "tenTS_col";
            this.tenTS_col.ReadOnly = true;
            // 
            // giatri_col
            // 
            this.giatri_col.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.giatri_col.DataPropertyName = "GiaTri";
            this.giatri_col.HeaderText = "Giá trị";
            this.giatri_col.MinimumWidth = 6;
            this.giatri_col.Name = "giatri_col";
            this.giatri_col.Width = 70;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dgv_ds_thamSo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(642, 263);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.Controls.Add(this.btn_save, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_cancel, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 231);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(636, 29);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btn_save
            // 
            this.btn_save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_save.Location = new System.Drawing.Point(399, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(114, 23);
            this.btn_save.TabIndex = 0;
            this.btn_save.Text = "Lưu thay đổi";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_cancel.Location = new System.Drawing.Point(519, 3);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(114, 23);
            this.btn_cancel.TabIndex = 1;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(636, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "THAY ĐỔI THAM SỐ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThayDoiThamSo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 263);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ThayDoiThamSo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THAY ĐỔI THAM SỐ";
            this.Load += new System.EventHandler(this.ThayDoiThamSo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ds_thamSo)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ds_thamSo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTS_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTS_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn giatri_col;
    }
}