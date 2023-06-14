namespace QuanLyDaQuy.Phieu
{
    partial class ThemDVForm
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
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.MaDV_tb = new System.Windows.Forms.TextBox();
            this.DV_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DonGia_tb = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            this.btn_Huy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Huy.Location = new System.Drawing.Point(704, 237);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(75, 23);
            this.btn_Huy.TabIndex = 42;
            this.btn_Huy.Text = "Hủy bỏ";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Them.Location = new System.Drawing.Point(601, 237);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 41;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MaDV_tb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DV_tb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.DonGia_tb, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 83);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 126);
            this.tableLayoutPanel1.TabIndex = 40;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Mã dịch vụ : ";
            // 
            // MaDV_tb
            // 
            this.MaDV_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaDV_tb.Location = new System.Drawing.Point(93, 21);
            this.MaDV_tb.Name = "MaDV_tb";
            this.MaDV_tb.ReadOnly = true;
            this.MaDV_tb.Size = new System.Drawing.Size(269, 22);
            this.MaDV_tb.TabIndex = 35;
            // 
            // DV_tb
            // 
            this.DV_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DV_tb.Location = new System.Drawing.Point(93, 83);
            this.DV_tb.Name = "DV_tb";
            this.DV_tb.Size = new System.Drawing.Size(269, 22);
            this.DV_tb.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dịch vụ : ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Đơn giá : ";
            // 
            // DonGia_tb
            // 
            this.DonGia_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DonGia_tb.Location = new System.Drawing.Point(440, 21);
            this.DonGia_tb.Name = "DonGia_tb";
            this.DonGia_tb.Size = new System.Drawing.Size(331, 22);
            this.DonGia_tb.TabIndex = 25;
            this.DonGia_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DonGia_tb_KeyPress);
            // 
            // label_Title
            // 
            this.label_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(288, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(220, 33);
            this.label_Title.TabIndex = 39;
            this.label_Title.Text = "THÊM DỊCH VỤ";
            // 
            // ThemDVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 277);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThemDVForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM DỊCH VỤ";
            this.Load += new System.EventHandler(this.ThemDVForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox MaDV_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox DV_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DonGia_tb;
        private System.Windows.Forms.Label label_Title;
    }
}