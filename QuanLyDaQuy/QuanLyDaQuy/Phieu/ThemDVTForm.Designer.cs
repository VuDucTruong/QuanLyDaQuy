namespace QuanLyDaQuy.Phieu
{
    partial class ThemDVTForm
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
            this.cancel_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dvt_tb = new System.Windows.Forms.TextBox();
            this.label_Title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancel_btn
            // 
            this.cancel_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_btn.Location = new System.Drawing.Point(712, 157);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 49;
            this.cancel_btn.Text = "Hủy bỏ";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_btn.Location = new System.Drawing.Point(612, 157);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(75, 23);
            this.insert_btn.TabIndex = 48;
            this.insert_btn.Text = "Thêm";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 275F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 310F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.id_tb, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.dvt_tb, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(774, 78);
            this.tableLayoutPanel1.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 34;
            this.label10.Text = "Mã đơn vị tính : ";
            // 
            // id_tb
            // 
            this.id_tb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.id_tb.Location = new System.Drawing.Point(110, 28);
            this.id_tb.Name = "id_tb";
            this.id_tb.ReadOnly = true;
            this.id_tb.Size = new System.Drawing.Size(269, 22);
            this.id_tb.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Đơn vị tính : ";
            // 
            // dvt_tb
            // 
            this.dvt_tb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dvt_tb.Location = new System.Drawing.Point(471, 28);
            this.dvt_tb.Name = "dvt_tb";
            this.dvt_tb.Size = new System.Drawing.Size(304, 22);
            this.dvt_tb.TabIndex = 25;
            // 
            // label_Title
            // 
            this.label_Title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(251, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(278, 33);
            this.label_Title.TabIndex = 46;
            this.label_Title.Text = "THÊM ĐƠN VỊ TÍNH";
            // 
            // ThemDVTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 196);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label_Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThemDVTForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM ĐƠN VỊ TÍNH";
            this.Load += new System.EventHandler(this.ThemDVTForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox dvt_tb;
        private System.Windows.Forms.Label label_Title;
    }
}