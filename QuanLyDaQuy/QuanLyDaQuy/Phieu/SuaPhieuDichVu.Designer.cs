﻿namespace QuanLyDaQuy.Phieu
{
    partial class SuaPhieuDichVu
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
            this.label_Title = new System.Windows.Forms.Label();
            this.textBox_SoPhieu = new System.Windows.Forms.TextBox();
            this.label_SoPhieu = new System.Windows.Forms.Label();
            this.label_NgayLap = new System.Windows.Forms.Label();
            this.textBox_NgayLap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_TongTienTraTruoc = new System.Windows.Forms.Label();
            this.textBox_SDT = new System.Windows.Forms.TextBox();
            this.textBox_TongTien = new System.Windows.Forms.TextBox();
            this.textBox_TongTienTraTruoc = new System.Windows.Forms.TextBox();
            this.textBox_TongTienConLai = new System.Windows.Forms.TextBox();
            this.textBox_KhachHang = new System.Windows.Forms.TextBox();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_OK = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.exPDF_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(3, 182);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.dataGridView1, 4);
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(975, 220);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView1_RowsAdded);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.Leave += new System.EventHandler(this.dataGridView1_FocusLeave);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_TongTien, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label_KhachHang, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_Title, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_SoPhieu, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_SoPhieu, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_NgayLap, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBox_NgayLap, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.label_TongTienTraTruoc, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBox_SDT, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBox_TongTien, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_TongTienTraTruoc, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_TongTienConLai, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBox_KhachHang, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(981, 404);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(656, 140);
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
            this.label_TongTien.Location = new System.Drawing.Point(4, 140);
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
            this.label_KhachHang.Location = new System.Drawing.Point(4, 100);
            this.label_KhachHang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_KhachHang.Name = "label_KhachHang";
            this.label_KhachHang.Size = new System.Drawing.Size(86, 18);
            this.label_KhachHang.TabIndex = 9;
            this.label_KhachHang.Text = "Khách hàng";
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label_Title, 6);
            this.label_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Title.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(3, 0);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(975, 60);
            this.label_Title.TabIndex = 3;
            this.label_Title.Text = "PHIẾU DỊCH VỤ";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_SoPhieu
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_SoPhieu, 2);
            this.textBox_SoPhieu.Enabled = false;
            this.textBox_SoPhieu.Location = new System.Drawing.Point(167, 64);
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
            this.label_NgayLap.Location = new System.Drawing.Point(493, 60);
            this.label_NgayLap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_NgayLap.Name = "label_NgayLap";
            this.label_NgayLap.Size = new System.Drawing.Size(65, 18);
            this.label_NgayLap.TabIndex = 7;
            this.label_NgayLap.Text = "Ngày lập";
            // 
            // textBox_NgayLap
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_NgayLap, 2);
            this.textBox_NgayLap.Enabled = false;
            this.textBox_NgayLap.Location = new System.Drawing.Point(656, 64);
            this.textBox_NgayLap.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_NgayLap.Name = "textBox_NgayLap";
            this.textBox_NgayLap.Size = new System.Drawing.Size(257, 22);
            this.textBox_NgayLap.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 100);
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
            this.label_TongTienTraTruoc.Location = new System.Drawing.Point(330, 140);
            this.label_TongTienTraTruoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_TongTienTraTruoc.Name = "label_TongTienTraTruoc";
            this.label_TongTienTraTruoc.Size = new System.Drawing.Size(128, 18);
            this.label_TongTienTraTruoc.TabIndex = 16;
            this.label_TongTienTraTruoc.Text = "Tổng tiền trả trước";
            // 
            // textBox_SDT
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_SDT, 2);
            this.textBox_SDT.Enabled = false;
            this.textBox_SDT.Location = new System.Drawing.Point(655, 103);
            this.textBox_SDT.Name = "textBox_SDT";
            this.textBox_SDT.Size = new System.Drawing.Size(258, 22);
            this.textBox_SDT.TabIndex = 19;
            // 
            // textBox_TongTien
            // 
            this.textBox_TongTien.Enabled = false;
            this.textBox_TongTien.Location = new System.Drawing.Point(166, 143);
            this.textBox_TongTien.Name = "textBox_TongTien";
            this.textBox_TongTien.Size = new System.Drawing.Size(130, 22);
            this.textBox_TongTien.TabIndex = 20;
            this.textBox_TongTien.Text = "0";
            // 
            // textBox_TongTienTraTruoc
            // 
            this.textBox_TongTienTraTruoc.Enabled = false;
            this.textBox_TongTienTraTruoc.Location = new System.Drawing.Point(492, 143);
            this.textBox_TongTienTraTruoc.Name = "textBox_TongTienTraTruoc";
            this.textBox_TongTienTraTruoc.Size = new System.Drawing.Size(130, 22);
            this.textBox_TongTienTraTruoc.TabIndex = 21;
            this.textBox_TongTienTraTruoc.Text = "0";
            // 
            // textBox_TongTienConLai
            // 
            this.textBox_TongTienConLai.Enabled = false;
            this.textBox_TongTienConLai.Location = new System.Drawing.Point(818, 143);
            this.textBox_TongTienConLai.Name = "textBox_TongTienConLai";
            this.textBox_TongTienConLai.Size = new System.Drawing.Size(130, 22);
            this.textBox_TongTienConLai.TabIndex = 22;
            this.textBox_TongTienConLai.Text = "0";
            // 
            // textBox_KhachHang
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBox_KhachHang, 2);
            this.textBox_KhachHang.Enabled = false;
            this.textBox_KhachHang.Location = new System.Drawing.Point(166, 103);
            this.textBox_KhachHang.Name = "textBox_KhachHang";
            this.textBox_KhachHang.Size = new System.Drawing.Size(258, 22);
            this.textBox_KhachHang.TabIndex = 23;
            // 
            // button_Close
            // 
            this.button_Close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Close.Location = new System.Drawing.Point(866, 4);
            this.button_Close.Margin = new System.Windows.Forms.Padding(4);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(113, 24);
            this.button_Close.TabIndex = 14;
            this.button_Close.Text = "Đóng";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Huy_Click);
            // 
            // button_OK
            // 
            this.button_OK.AutoSize = true;
            this.button_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_OK.Location = new System.Drawing.Point(746, 4);
            this.button_OK.Margin = new System.Windows.Forms.Padding(4);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(112, 24);
            this.button_OK.TabIndex = 15;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel2.Controls.Add(this.button_Close, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.button_OK, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.exPDF_btn, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 415);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(983, 32);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // exPDF_btn
            // 
            this.exPDF_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.exPDF_btn.Location = new System.Drawing.Point(644, 3);
            this.exPDF_btn.Name = "exPDF_btn";
            this.exPDF_btn.Size = new System.Drawing.Size(95, 26);
            this.exPDF_btn.TabIndex = 16;
            this.exPDF_btn.Text = "Xuất PDF";
            this.exPDF_btn.UseVisualStyleBackColor = true;
            this.exPDF_btn.Click += new System.EventHandler(this.exPDF_btn_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(989, 450);
            this.tableLayoutPanel3.TabIndex = 16;
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
            this.TenDV.ReadOnly = true;
            this.TenDV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.SL.ReadOnly = true;
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
            this.NgayGiao.ReadOnly = true;
            // 
            // TinhTrang
            // 
            this.TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TinhTrang.HeaderText = "Tình trạng";
            this.TinhTrang.Items.AddRange(new object[] {
            "Hoàn thành",
            "Chưa hoàn thành"});
            this.TinhTrang.MinimumWidth = 6;
            this.TinhTrang.Name = "TinhTrang";
            this.TinhTrang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TinhTrang.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SuaPhieuDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 450);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SuaPhieuDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÔNG TIN PHIẾU DỊCH VỤ";
            this.Load += new System.EventHandler(this.PhieuDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Label label_NgayLap;
        private System.Windows.Forms.TextBox textBox_SoPhieu;
        private System.Windows.Forms.Label label_SoPhieu;
        private System.Windows.Forms.Label label_KhachHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.TextBox textBox_NgayLap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_TongTien;
        private System.Windows.Forms.Label label_TongTienTraTruoc;
        private System.Windows.Forms.TextBox textBox_SDT;
        private System.Windows.Forms.TextBox textBox_TongTien;
        private System.Windows.Forms.TextBox textBox_TongTienTraTruoc;
        private System.Windows.Forms.TextBox textBox_TongTienConLai;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textBox_KhachHang;
        private System.Windows.Forms.Button exPDF_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDV;
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