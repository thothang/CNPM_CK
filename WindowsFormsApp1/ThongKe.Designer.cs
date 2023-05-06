namespace WindowsFormsApp1
{
    partial class ThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.btn_In = new WindowsFormsApp1.More_option.CssButton();
            this.btn_TKNam = new WindowsFormsApp1.More_option.CssButton();
            this.btn_TKThang = new WindowsFormsApp1.More_option.CssButton();
            this.btn_TKNgay = new WindowsFormsApp1.More_option.CssButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(60, 202);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1322, 574);
            this.dataGridView1.TabIndex = 0;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // btn_In
            // 
            this.btn_In.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_In.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_In.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_In.BorderRadius = 20;
            this.btn_In.BorderSize = 0;
            this.btn_In.FlatAppearance.BorderSize = 0;
            this.btn_In.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_In.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_In.ForeColor = System.Drawing.Color.White;
            this.btn_In.Location = new System.Drawing.Point(1136, 72);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(246, 61);
            this.btn_In.TabIndex = 10;
            this.btn_In.Text = "In thống kê";
            this.btn_In.TextColor = System.Drawing.Color.White;
            this.btn_In.UseVisualStyleBackColor = false;
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // btn_TKNam
            // 
            this.btn_TKNam.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_TKNam.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.btn_TKNam.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TKNam.BorderRadius = 20;
            this.btn_TKNam.BorderSize = 0;
            this.btn_TKNam.FlatAppearance.BorderSize = 0;
            this.btn_TKNam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TKNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TKNam.ForeColor = System.Drawing.Color.White;
            this.btn_TKNam.Location = new System.Drawing.Point(785, 72);
            this.btn_TKNam.Name = "btn_TKNam";
            this.btn_TKNam.Size = new System.Drawing.Size(246, 61);
            this.btn_TKNam.TabIndex = 9;
            this.btn_TKNam.Text = "Thống kê theo năm";
            this.btn_TKNam.TextColor = System.Drawing.Color.White;
            this.btn_TKNam.UseVisualStyleBackColor = false;
            this.btn_TKNam.Click += new System.EventHandler(this.btn_TKNam_Click);
            // 
            // btn_TKThang
            // 
            this.btn_TKThang.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_TKThang.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.btn_TKThang.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TKThang.BorderRadius = 20;
            this.btn_TKThang.BorderSize = 0;
            this.btn_TKThang.FlatAppearance.BorderSize = 0;
            this.btn_TKThang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TKThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TKThang.ForeColor = System.Drawing.Color.White;
            this.btn_TKThang.Location = new System.Drawing.Point(421, 72);
            this.btn_TKThang.Name = "btn_TKThang";
            this.btn_TKThang.Size = new System.Drawing.Size(246, 61);
            this.btn_TKThang.TabIndex = 8;
            this.btn_TKThang.Text = "Thống kê theo tháng";
            this.btn_TKThang.TextColor = System.Drawing.Color.White;
            this.btn_TKThang.UseVisualStyleBackColor = false;
            this.btn_TKThang.Click += new System.EventHandler(this.btn_TKThang_Click);
            // 
            // btn_TKNgay
            // 
            this.btn_TKNgay.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_TKNgay.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.btn_TKNgay.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_TKNgay.BorderRadius = 20;
            this.btn_TKNgay.BorderSize = 0;
            this.btn_TKNgay.FlatAppearance.BorderSize = 0;
            this.btn_TKNgay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_TKNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TKNgay.ForeColor = System.Drawing.Color.White;
            this.btn_TKNgay.Location = new System.Drawing.Point(60, 72);
            this.btn_TKNgay.Name = "btn_TKNgay";
            this.btn_TKNgay.Size = new System.Drawing.Size(246, 61);
            this.btn_TKNgay.TabIndex = 7;
            this.btn_TKNgay.Text = "Thống kê theo ngày";
            this.btn_TKNgay.TextColor = System.Drawing.Color.White;
            this.btn_TKNgay.UseVisualStyleBackColor = false;
            this.btn_TKNgay.Click += new System.EventHandler(this.btn_TKNgay_Click);
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 844);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.btn_TKNam);
            this.Controls.Add(this.btn_TKThang);
            this.Controls.Add(this.btn_TKNgay);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongKe";
            this.Text = "ThongKe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private More_option.CssButton btn_TKNgay;
        private More_option.CssButton btn_TKThang;
        private More_option.CssButton btn_In;
        private More_option.CssButton btn_TKNam;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}