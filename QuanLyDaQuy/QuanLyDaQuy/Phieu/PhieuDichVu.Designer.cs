namespace QuanLyDaQuy.Phieu
{
    partial class PhieuDichVu
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label_TongTien = new System.Windows.Forms.Label();
            this.label_KhachHang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SoPhieu = new System.Windows.Forms.TextBox();
            this.label_SoPhieu = new System.Windows.Forms.Label();
            this.label_NgayLap = new System.Windows.Forms.Label();
            this.textBox_NgayLap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_TongTienTraTruoc = new System.Windows.Forms.Label();
            this.button_Huy = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaDuocTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TraTruoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ConLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TinhTrang = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.TenDV,
            this.DonGia,
            this.DonGiaDuocTinh,
            this.SL,
            this.ThanhTien,
            this.TraTruoc,
            this.ConLai,
            this.NgayGiao,
            this.TinhTrang});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 6);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 190);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 4);
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(983, 217);
            this.dataGridView1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_TongTien, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_KhachHang, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_SoPhieu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_SoPhieu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_NgayLap, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_NgayLap, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_TongTienTraTruoc, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.05263F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.94737F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 113F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(989, 409);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(660, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Tổng tiền còn lại";
            // 
            // label_TongTien
            // 
            this.label_TongTien.AutoSize = true;
            this.label_TongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TongTien.Location = new System.Drawing.Point(4, 136);
            this.label_TongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TongTien.Name = "label_TongTien";
            this.label_TongTien.Size = new System.Drawing.Size(69, 18);
            this.label_TongTien.TabIndex = 15;
            this.label_TongTien.Text = "Tổng tiền";
            // 
            // label_KhachHang
            // 
            this.label_KhachHang.AutoSize = true;
            this.label_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_KhachHang.Location = new System.Drawing.Point(4, 98);
            this.label_KhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_KhachHang.Name = "label_KhachHang";
            this.label_KhachHang.Size = new System.Drawing.Size(86, 18);
            this.label_KhachHang.TabIndex = 9;
            this.label_KhachHang.Text = "Khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label1, 6);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(983, 60);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lập phiếu dịch vụ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_SoPhieu
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_SoPhieu, 2);
            this.textBox_SoPhieu.Location = new System.Drawing.Point(168, 64);
            this.textBox_SoPhieu.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_SoPhieu.Name = "textBox_SoPhieu";
            this.textBox_SoPhieu.Size = new System.Drawing.Size(257, 22);
            this.textBox_SoPhieu.TabIndex = 5;
            // 
            // label_SoPhieu
            // 
            this.label_SoPhieu.AutoSize = true;
            this.label_SoPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SoPhieu.Location = new System.Drawing.Point(4, 60);
            this.label_SoPhieu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_SoPhieu.Name = "label_SoPhieu";
            this.label_SoPhieu.Size = new System.Drawing.Size(66, 18);
            this.label_SoPhieu.TabIndex = 6;
            this.label_SoPhieu.Text = "Số phiếu";
            // 
            // label_NgayLap
            // 
            this.label_NgayLap.AutoSize = true;
            this.label_NgayLap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NgayLap.Location = new System.Drawing.Point(496, 60);
            this.label_NgayLap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NgayLap.Name = "label_NgayLap";
            this.label_NgayLap.Size = new System.Drawing.Size(65, 18);
            this.label_NgayLap.TabIndex = 7;
            this.label_NgayLap.Text = "Ngày lập";
            // 
            // textBox_NgayLap
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_NgayLap, 2);
            this.textBox_NgayLap.Location = new System.Drawing.Point(660, 64);
            this.textBox_NgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_NgayLap.Name = "textBox_NgayLap";
            this.textBox_NgayLap.Size = new System.Drawing.Size(257, 22);
            this.textBox_NgayLap.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "SĐT";
            // 
            // label_TongTienTraTruoc
            // 
            this.label_TongTienTraTruoc.AutoSize = true;
            this.label_TongTienTraTruoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TongTienTraTruoc.Location = new System.Drawing.Point(332, 136);
            this.label_TongTienTraTruoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TongTienTraTruoc.Name = "label_TongTienTraTruoc";
            this.label_TongTienTraTruoc.Size = new System.Drawing.Size(128, 18);
            this.label_TongTienTraTruoc.TabIndex = 16;
            this.label_TongTienTraTruoc.Text = "Tổng tiền trả trước";
            // 
            // button_Huy
            // 
            this.button_Huy.Location = new System.Drawing.Point(835, 412);
            this.button_Huy.Margin = new System.Windows.Forms.Padding(20, 4, 4, 4);
            this.button_Huy.Name = "button_Huy";
            this.button_Huy.Size = new System.Drawing.Size(139, 32);
            this.button_Huy.TabIndex = 14;
            this.button_Huy.Text = "Hủy";
            this.button_Huy.UseVisualStyleBackColor = true;
            // 
            // button_OK
            // 
            this.button_OK.AutoSize = true;
            this.button_OK.Location = new System.Drawing.Point(672, 412);
            this.button_OK.Margin = new System.Windows.Forms.Padding(4);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(139, 32);
            this.button_OK.TabIndex = 15;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // TenDV
            // 
            this.TenDV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenDV.HeaderText = "Loại dịch vụ";
            this.TenDV.MinimumWidth = 6;
            this.TenDV.Name = "TenDV";
            this.TenDV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TenDV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // DonGia
            // 
            this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGia.HeaderText = "Đơn giá dịch vụ";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // DonGiaDuocTinh
            // 
            this.DonGiaDuocTinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DonGiaDuocTinh.HeaderText = "Đơn giá được tính";
            this.DonGiaDuocTinh.MinimumWidth = 6;
            this.DonGiaDuocTinh.Name = "DonGiaDuocTinh";
            this.DonGiaDuocTinh.ReadOnly = true;
            // 
            // SL
            // 
            this.SL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.SL.HeaderText = "Số lượng";
            this.SL.MinimumWidth = 6;
            this.SL.Name = "SL";
            // 
            // ThanhTien
            // 
            this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.MinimumWidth = 6;
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // TraTruoc
            // 
            this.TraTruoc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TraTruoc.HeaderText = "Trả trước";
            this.TraTruoc.MinimumWidth = 6;
            this.TraTruoc.Name = "TraTruoc";
            this.TraTruoc.ReadOnly = true;
            // 
            // ConLai
            // 
            this.ConLai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ConLai.HeaderText = "Còn lại";
            this.ConLai.MinimumWidth = 6;
            this.ConLai.Name = "ConLai";
            this.ConLai.ReadOnly = true;
            // 
            // NgayGiao
            // 
            this.NgayGiao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayGiao.HeaderText = "Ngày giao";
            this.NgayGiao.MinimumWidth = 6;
            this.NgayGiao.Name = "NgayGiao";
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.ReadOnly = true;
            this.TinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TinhTrang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PhieuDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.button_Huy);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhieuDichVu";
            this.Text = "Nhập phiếu dịch vụ";
            this.Load += new System.EventHandler(this.PhieuDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_NgayLap;
        private System.Windows.Forms.TextBox textBox_SoPhieu;
        private System.Windows.Forms.Label label_SoPhieu;
        private System.Windows.Forms.Label label_KhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Huy;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_NgayLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_TongTien;
        private System.Windows.Forms.Label label_TongTienTraTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewComboBoxColumn TenDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaDuocTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn TraTruoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConLai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayGiao;
        private System.Windows.Forms.DataGridViewComboBoxColumn TinhTrang;
    }
}