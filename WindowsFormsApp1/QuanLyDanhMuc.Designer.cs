﻿namespace WindowsFormsApp1
{
    partial class QuanLyDanhMuc
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
            this.DGV_HangHoa = new System.Windows.Forms.DataGridView();
            this.btn_Sua = new WindowsFormsApp1.More_option.CssButton();
            this.btn_Xoa = new WindowsFormsApp1.More_option.CssButton();
            this.btn_Them = new WindowsFormsApp1.More_option.CssButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_HangHoa
            // 
            this.DGV_HangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_HangHoa.Location = new System.Drawing.Point(42, 40);
            this.DGV_HangHoa.Name = "DGV_HangHoa";
            this.DGV_HangHoa.RowHeadersWidth = 62;
            this.DGV_HangHoa.RowTemplate.Height = 28;
            this.DGV_HangHoa.Size = new System.Drawing.Size(1053, 752);
            this.DGV_HangHoa.TabIndex = 1;
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Sua.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Sua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Sua.BorderRadius = 20;
            this.btn_Sua.BorderSize = 0;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(1168, 339);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(230, 72);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa danh mục";
            this.btn_Sua.TextColor = System.Drawing.Color.White;
            this.btn_Sua.UseVisualStyleBackColor = false;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Xoa.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Xoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Xoa.BorderRadius = 20;
            this.btn_Xoa.BorderSize = 0;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(1168, 188);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(230, 72);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa danh mục";
            this.btn_Xoa.TextColor = System.Drawing.Color.White;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Them.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Them.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Them.BorderRadius = 20;
            this.btn_Them.BorderSize = 0;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(1168, 40);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(230, 72);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Tạo danh mục";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            // 
            // QuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 844);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.DGV_HangHoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyDanhMuc";
            this.Text = "QuanLyDanhMuc";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HangHoa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_HangHoa;
        private More_option.CssButton btn_Sua;
        private More_option.CssButton btn_Xoa;
        private More_option.CssButton btn_Them;
    }
}