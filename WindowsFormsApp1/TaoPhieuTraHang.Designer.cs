namespace WindowsFormsApp1
{
    partial class TaoPhieuTraHang
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
            this.GB_ThongTinTra = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_InPNhap = new WindowsFormsApp1.More_option.CssButton();
            this.GB_ThongTinTra.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_ThongTinTra
            // 
            this.GB_ThongTinTra.Controls.Add(this.label8);
            this.GB_ThongTinTra.Controls.Add(this.label5);
            this.GB_ThongTinTra.Controls.Add(this.label4);
            this.GB_ThongTinTra.Controls.Add(this.label2);
            this.GB_ThongTinTra.Controls.Add(this.btn_InPNhap);
            this.GB_ThongTinTra.Location = new System.Drawing.Point(74, 48);
            this.GB_ThongTinTra.Name = "GB_ThongTinTra";
            this.GB_ThongTinTra.Size = new System.Drawing.Size(1321, 756);
            this.GB_ThongTinTra.TabIndex = 3;
            this.GB_ThongTinTra.TabStop = false;
            this.GB_ThongTinTra.Text = "Thông tin trả hàng";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(65, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 25);
            this.label8.TabIndex = 5;
            this.label8.Text = "Đơn vị trả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lý do trả hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày trả hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên mặt hàng";
            // 
            // btn_InPNhap
            // 
            this.btn_InPNhap.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_InPNhap.BackgroundColor = System.Drawing.Color.MediumPurple;
            this.btn_InPNhap.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_InPNhap.BorderRadius = 20;
            this.btn_InPNhap.BorderSize = 0;
            this.btn_InPNhap.FlatAppearance.BorderSize = 0;
            this.btn_InPNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InPNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_InPNhap.ForeColor = System.Drawing.Color.White;
            this.btn_InPNhap.Location = new System.Drawing.Point(369, 625);
            this.btn_InPNhap.Name = "btn_InPNhap";
            this.btn_InPNhap.Size = new System.Drawing.Size(509, 62);
            this.btn_InPNhap.TabIndex = 1;
            this.btn_InPNhap.Text = "In phiếu nhập hàng";
            this.btn_InPNhap.TextColor = System.Drawing.Color.White;
            this.btn_InPNhap.UseVisualStyleBackColor = false;
            this.btn_InPNhap.Click += new System.EventHandler(this.btn_InPNhap_Click);
            // 
            // TaoPhieuTraHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 844);
            this.Controls.Add(this.GB_ThongTinTra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TaoPhieuTraHang";
            this.Text = "TaoPhieuTraHang";
            this.GB_ThongTinTra.ResumeLayout(false);
            this.GB_ThongTinTra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_ThongTinTra;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private More_option.CssButton btn_InPNhap;
    }
}