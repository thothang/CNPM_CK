namespace WindowsFormsApp1
{
    partial class TaoPhieuXuathHang
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GB_ThongTinXuat = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_InPXuat = new WindowsFormsApp1.More_option.CssButton();
            this.GB_ThongTinXuat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên mặt hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày xuất hàng";
            // 
            // GB_ThongTinXuat
            // 
            this.GB_ThongTinXuat.Controls.Add(this.label7);
            this.GB_ThongTinXuat.Controls.Add(this.label6);
            this.GB_ThongTinXuat.Controls.Add(this.label3);
            this.GB_ThongTinXuat.Controls.Add(this.label1);
            this.GB_ThongTinXuat.Controls.Add(this.btn_InPXuat);
            this.GB_ThongTinXuat.Location = new System.Drawing.Point(64, 56);
            this.GB_ThongTinXuat.Name = "GB_ThongTinXuat";
            this.GB_ThongTinXuat.Size = new System.Drawing.Size(1292, 742);
            this.GB_ThongTinXuat.TabIndex = 0;
            this.GB_ThongTinXuat.TabStop = false;
            this.GB_ThongTinXuat.Text = "Thông tin xuất hàng";
            this.GB_ThongTinXuat.Enter += new System.EventHandler(this.GB_ThongTinXuat_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Số lượng tồn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Số lượng xuất";
            // 
            // btn_InPXuat
            // 
            this.btn_InPXuat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_InPXuat.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.btn_InPXuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_InPXuat.BorderRadius = 20;
            this.btn_InPXuat.BorderSize = 0;
            this.btn_InPXuat.FlatAppearance.BorderSize = 0;
            this.btn_InPXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InPXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InPXuat.ForeColor = System.Drawing.Color.White;
            this.btn_InPXuat.Location = new System.Drawing.Point(419, 624);
            this.btn_InPXuat.Name = "btn_InPXuat";
            this.btn_InPXuat.Size = new System.Drawing.Size(509, 62);
            this.btn_InPXuat.TabIndex = 0;
            this.btn_InPXuat.Text = "In phiếu xuất hàng";
            this.btn_InPXuat.TextColor = System.Drawing.Color.White;
            this.btn_InPXuat.UseVisualStyleBackColor = false;
            this.btn_InPXuat.Click += new System.EventHandler(this.btn_InPXuat_Click);
            // 
            // TaoPhieuXuathHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 844);
            this.Controls.Add(this.GB_ThongTinXuat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaoPhieuXuathHang";
            this.Text = "QuanLyXuatHang";
            this.GB_ThongTinXuat.ResumeLayout(false);
            this.GB_ThongTinXuat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private More_option.CssButton btn_InPXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox GB_ThongTinXuat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}