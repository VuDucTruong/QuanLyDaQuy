namespace QuanLyDaQuy.Phieu
{
    partial class ThemNCCForm
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
            this.canncel_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MaNCC_tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.NCC_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Address_tb = new System.Windows.Forms.TextBox();
            this.Phone_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // canncel_btn
            // 
            this.canncel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.canncel_btn.Location = new System.Drawing.Point(722, 236);
            this.canncel_btn.Name = "canncel_btn";
            this.canncel_btn.Size = new System.Drawing.Size(75, 23);
            this.canncel_btn.TabIndex = 46;
            this.canncel_btn.Text = "Hủy bỏ";
            this.canncel_btn.UseVisualStyleBackColor = true;
            this.canncel_btn.Click += new System.EventHandler(this.canncel_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_btn.Location = new System.Drawing.Point(560, 236);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(82, 23);
            this.insert_btn.TabIndex = 45;
            this.insert_btn.Text = "Thêm";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.MaNCC_tb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.NCC_tb, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Address_tb, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Phone_tb, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 126);
            this.tableLayoutPanel1.TabIndex = 44;
            // 
            // MaNCC_tb
            // 
            this.MaNCC_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaNCC_tb.Location = new System.Drawing.Point(131, 21);
            this.MaNCC_tb.Name = "MaNCC_tb";
            this.MaNCC_tb.ReadOnly = true;
            this.MaNCC_tb.Size = new System.Drawing.Size(208, 22);
            this.MaNCC_tb.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Mã nhà cung cấp : ";
            // 
            // NCC_tb
            // 
            this.NCC_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NCC_tb.Location = new System.Drawing.Point(131, 83);
            this.NCC_tb.Name = "NCC_tb";
            this.NCC_tb.Size = new System.Drawing.Size(208, 22);
            this.NCC_tb.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Nhà cung cấp : ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Số điện thoại : ";
            // 
            // Address_tb
            // 
            this.Address_tb.AcceptsReturn = true;
            this.Address_tb.Location = new System.Drawing.Point(449, 67);
            this.Address_tb.Multiline = true;
            this.Address_tb.Name = "Address_tb";
            this.Address_tb.Size = new System.Drawing.Size(322, 54);
            this.Address_tb.TabIndex = 37;
            // 
            // Phone_tb
            // 
            this.Phone_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Phone_tb.Location = new System.Drawing.Point(449, 21);
            this.Phone_tb.Name = "Phone_tb";
            this.Phone_tb.Size = new System.Drawing.Size(322, 22);
            this.Phone_tb.TabIndex = 25;
            this.Phone_tb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Phone_tb_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Địa chỉ : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Title
            // 
            this.label_Title.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(174, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(487, 43);
            this.label_Title.TabIndex = 43;
            this.label_Title.Text = "THÊM NHÀ CUNG CẤP";
            this.label_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ThemNCCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 277);
            this.Controls.Add(this.canncel_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThemNCCForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM NHÀ CUNG CẤP";
            this.Load += new System.EventHandler(this.ThemNCCForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button canncel_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NCC_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Phone_tb;
        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.TextBox Address_tb;
        private System.Windows.Forms.TextBox MaNCC_tb;
        private System.Windows.Forms.Label label2;
    }
}