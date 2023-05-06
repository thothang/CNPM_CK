namespace WindowsFormsApp1
{
    partial class QuanLyKhuyenMai
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
            this.DGV_KhuyenMai = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dangxuat = new WindowsFormsApp1.More_option.CssButton();
            this.textbox2 = new WindowsFormsApp1.More_option.textbox();
            this.textbox1 = new WindowsFormsApp1.More_option.textbox();
            this.btn_Them = new WindowsFormsApp1.More_option.CssButton();
            this.btn_xoa = new WindowsFormsApp1.More_option.CssButton();
            this.btn_sua = new WindowsFormsApp1.More_option.CssButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_KhuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_KhuyenMai
            // 
            this.DGV_KhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_KhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGV_KhuyenMai.Location = new System.Drawing.Point(37, 10);
            this.DGV_KhuyenMai.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGV_KhuyenMai.Name = "DGV_KhuyenMai";
            this.DGV_KhuyenMai.RowHeadersWidth = 62;
            this.DGV_KhuyenMai.RowTemplate.Height = 28;
            this.DGV_KhuyenMai.Size = new System.Drawing.Size(676, 624);
            this.DGV_KhuyenMai.TabIndex = 0;
            this.DGV_KhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_KhuyenMai_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(748, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mã Khuyến Mãi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(782, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tỉ Lệ:";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Mã Khuyến Mãi";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tỉ Lệ";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Dangxuat
            // 
            this.Dangxuat.BackColor = System.Drawing.Color.Crimson;
            this.Dangxuat.BackgroundColor = System.Drawing.Color.Crimson;
            this.Dangxuat.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Dangxuat.BorderRadius = 20;
            this.Dangxuat.BorderSize = 0;
            this.Dangxuat.FlatAppearance.BorderSize = 0;
            this.Dangxuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dangxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dangxuat.ForeColor = System.Drawing.Color.White;
            this.Dangxuat.Location = new System.Drawing.Point(946, 560);
            this.Dangxuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dangxuat.Name = "Dangxuat";
            this.Dangxuat.Size = new System.Drawing.Size(215, 63);
            this.Dangxuat.TabIndex = 16;
            this.Dangxuat.Text = "Đăng xuất";
            this.Dangxuat.TextColor = System.Drawing.Color.White;
            this.Dangxuat.UseVisualStyleBackColor = false;
            this.Dangxuat.Click += new System.EventHandler(this.Dangxuat_Click);
            // 
            // textbox2
            // 
            this.textbox2.BackColor = System.Drawing.SystemColors.Window;
            this.textbox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox2.BorderSize = 2;
            this.textbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox2.ForeColor = System.Drawing.Color.DimGray;
            this.textbox2.Location = new System.Drawing.Point(900, 112);
            this.textbox2.Margin = new System.Windows.Forms.Padding(4);
            this.textbox2.Multiline = false;
            this.textbox2.Name = "textbox2";
            this.textbox2.Padding = new System.Windows.Forms.Padding(7);
            this.textbox2.PasswordChar = false;
            this.textbox2.Size = new System.Drawing.Size(265, 35);
            this.textbox2.TabIndex = 10;
            this.textbox2.Texts = "";
            this.textbox2.UnderlinedStyle = false;
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.SystemColors.Window;
            this.textbox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox1.BorderSize = 2;
            this.textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox1.ForeColor = System.Drawing.Color.DimGray;
            this.textbox1.Location = new System.Drawing.Point(900, 49);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.Multiline = false;
            this.textbox1.Name = "textbox1";
            this.textbox1.Padding = new System.Windows.Forms.Padding(7);
            this.textbox1.PasswordChar = false;
            this.textbox1.Size = new System.Drawing.Size(265, 35);
            this.textbox1.TabIndex = 9;
            this.textbox1.Texts = "";
            this.textbox1.UnderlinedStyle = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Them.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btn_Them.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Them.BorderRadius = 20;
            this.btn_Them.BorderSize = 0;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(946, 269);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(215, 65);
            this.btn_Them.TabIndex = 6;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.Tomato;
            this.btn_xoa.BackgroundColor = System.Drawing.Color.Tomato;
            this.btn_xoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_xoa.BorderRadius = 20;
            this.btn_xoa.BorderSize = 0;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.Color.White;
            this.btn_xoa.Location = new System.Drawing.Point(946, 366);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(215, 65);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa ";
            this.btn_xoa.TextColor = System.Drawing.Color.White;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_sua.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_sua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_sua.BorderRadius = 20;
            this.btn_sua.BorderSize = 0;
            this.btn_sua.FlatAppearance.BorderSize = 0;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.Color.White;
            this.btn_sua.Location = new System.Drawing.Point(946, 464);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(215, 65);
            this.btn_sua.TabIndex = 4;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.Color.White;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // QuanLyKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.Dangxuat);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.DGV_KhuyenMai);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyKhuyenMai";
            this.Text = "QuanLyKhuyenMai";
            this.Activated += new System.EventHandler(this.QuanLyKhuyenMai_Activated);
            this.Load += new System.EventHandler(this.QuanLyKhuyenMai_Load);
            this.MouseEnter += new System.EventHandler(this.QuanLyKhuyenMai_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_KhuyenMai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_KhuyenMai;
        private More_option.CssButton btn_sua;
        private More_option.CssButton btn_xoa;
        private More_option.CssButton btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private More_option.textbox textbox1;
        private More_option.textbox textbox2;
        private More_option.CssButton Dangxuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}