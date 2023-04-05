
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieumuahang)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_title.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_title.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.Location = new System.Drawing.Point(0, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(800, 35);
            this.lb_title.TabIndex = 1;
            this.lb_title.Text = "PHIẾU BÁN HÀNG";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_sophieu
            // 
            this.lb_sophieu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_sophieu.ForeColor = System.Drawing.Color.Black;
            this.lb_sophieu.Location = new System.Drawing.Point(37, 35);
            this.lb_sophieu.Name = "lb_sophieu";
            this.lb_sophieu.Size = new System.Drawing.Size(97, 35);
            this.lb_sophieu.TabIndex = 2;
            this.lb_sophieu.Text = "Số phiếu:";
            this.lb_sophieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_khachhang
            // 
            this.lb_khachhang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_khachhang.ForeColor = System.Drawing.Color.Black;
            this.lb_khachhang.Location = new System.Drawing.Point(37, 75);
            this.lb_khachhang.Name = "lb_khachhang";
            this.lb_khachhang.Size = new System.Drawing.Size(97, 35);
            this.lb_khachhang.TabIndex = 3;
            this.lb_khachhang.Text = "Khách hàng:";
            this.lb_khachhang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_ngaylap
            // 
            this.lb_ngaylap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ngaylap.ForeColor = System.Drawing.Color.Black;
            this.lb_ngaylap.Location = new System.Drawing.Point(503, 35);
            this.lb_ngaylap.Name = "lb_ngaylap";
            this.lb_ngaylap.Size = new System.Drawing.Size(70, 35);
            this.lb_ngaylap.TabIndex = 4;
            this.lb_ngaylap.Text = "Ngày lập:";
            this.lb_ngaylap.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgv_phieumuahang
            // 
            this.dgv_phieumuahang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phieumuahang.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_phieumuahang.GridColor = System.Drawing.Color.Silver;
            this.dgv_phieumuahang.Location = new System.Drawing.Point(0, 113);
            this.dgv_phieumuahang.Name = "dgv_phieumuahang";
            this.dgv_phieumuahang.RowHeadersWidth = 51;
            this.dgv_phieumuahang.RowTemplate.Height = 24;
            this.dgv_phieumuahang.Size = new System.Drawing.Size(800, 337);
            this.dgv_phieumuahang.TabIndex = 12;
            // 
            // tb_sophieu
            // 
            this.tb_sophieu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_sophieu.BackColor = System.Drawing.SystemColors.Control;
            this.tb_sophieu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_sophieu.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_sophieu.Location = new System.Drawing.Point(140, 44);
            this.tb_sophieu.Name = "tb_sophieu";
            this.tb_sophieu.Size = new System.Drawing.Size(258, 18);
            this.tb_sophieu.TabIndex = 13;
            this.tb_sophieu.Text = "001";
            // 
            // tb_khachhang
            // 
            this.tb_khachhang.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_khachhang.BackColor = System.Drawing.SystemColors.Control;
            this.tb_khachhang.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_khachhang.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_khachhang.Location = new System.Drawing.Point(140, 84);
            this.tb_khachhang.Name = "tb_khachhang";
            this.tb_khachhang.Size = new System.Drawing.Size(258, 18);
            this.tb_khachhang.TabIndex = 14;
            this.tb_khachhang.Text = "TriPero";
            // 
            // tb_ngaylap
            // 
            this.tb_ngaylap.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_ngaylap.BackColor = System.Drawing.SystemColors.Control;
            this.tb_ngaylap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_ngaylap.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ngaylap.Location = new System.Drawing.Point(579, 44);
            this.tb_ngaylap.Name = "tb_ngaylap";
            this.tb_ngaylap.Size = new System.Drawing.Size(196, 18);
            this.tb_ngaylap.TabIndex = 15;
            this.tb_ngaylap.Text = "2/3/2023";
            // 
            // PhieuBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_ngaylap);
            this.Controls.Add(this.tb_khachhang);
            this.Controls.Add(this.tb_sophieu);
            this.Controls.Add(this.dgv_phieumuahang);
            this.Controls.Add(this.lb_ngaylap);
            this.Controls.Add(this.lb_khachhang);
            this.Controls.Add(this.lb_sophieu);
            this.Controls.Add(this.lb_title);
            this.Name = "PhieuBanHang";
            this.Text = "PhieuBanHang";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phieumuahang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}