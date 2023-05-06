namespace WindowsFormsApp1
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Sua = new WindowsFormsApp1.More_option.CssButton();
            this.btn_Xoa = new WindowsFormsApp1.More_option.CssButton();
            this.btn_Them = new WindowsFormsApp1.More_option.CssButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textbox1 = new WindowsFormsApp1.More_option.textbox();
            this.textbox2 = new WindowsFormsApp1.More_option.textbox();
            this.Dangxuat = new WindowsFormsApp1.More_option.CssButton();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HangHoa)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_HangHoa
            // 
            this.DGV_HangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_HangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGV_HangHoa.Location = new System.Drawing.Point(42, 12);
            this.DGV_HangHoa.Name = "DGV_HangHoa";
            this.DGV_HangHoa.RowHeadersWidth = 62;
            this.DGV_HangHoa.RowTemplate.Height = 28;
            this.DGV_HangHoa.Size = new System.Drawing.Size(665, 780);
            this.DGV_HangHoa.TabIndex = 1;
            this.DGV_HangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_HangHoa_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "MaDM";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên Danh Mục";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.Color.SeaGreen;
            this.btn_Sua.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btn_Sua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Sua.BorderRadius = 20;
            this.btn_Sua.BorderSize = 0;
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(846, 592);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(464, 90);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa danh mục";
            this.btn_Sua.TextColor = System.Drawing.Color.White;
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.Color.Tomato;
            this.btn_Xoa.BackgroundColor = System.Drawing.Color.Tomato;
            this.btn_Xoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Xoa.BorderRadius = 20;
            this.btn_Xoa.BorderSize = 0;
            this.btn_Xoa.FlatAppearance.BorderSize = 0;
            this.btn_Xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(846, 479);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(464, 90);
            this.btn_Xoa.TabIndex = 5;
            this.btn_Xoa.Text = "Xóa danh mục";
            this.btn_Xoa.TextColor = System.Drawing.Color.White;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
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
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(846, 353);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(464, 90);
            this.btn_Them.TabIndex = 4;
            this.btn_Them.Text = "Tạo danh mục";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(841, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Danh Mục";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(841, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã Danh Mục";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.SystemColors.Window;
            this.textbox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox1.BorderSize = 2;
            this.textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox1.ForeColor = System.Drawing.Color.DimGray;
            this.textbox1.Location = new System.Drawing.Point(1012, 61);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.Multiline = false;
            this.textbox1.Name = "textbox1";
            this.textbox1.Padding = new System.Windows.Forms.Padding(7);
            this.textbox1.PasswordChar = false;
            this.textbox1.Size = new System.Drawing.Size(298, 39);
            this.textbox1.TabIndex = 9;
            this.textbox1.Texts = "";
            this.textbox1.UnderlinedStyle = false;
            this.textbox1._TextChanged += new System.EventHandler(this.textbox1__TextChanged);
            // 
            // textbox2
            // 
            this.textbox2.BackColor = System.Drawing.SystemColors.Window;
            this.textbox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox2.BorderSize = 2;
            this.textbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox2.ForeColor = System.Drawing.Color.DimGray;
            this.textbox2.Location = new System.Drawing.Point(1012, 154);
            this.textbox2.Margin = new System.Windows.Forms.Padding(4);
            this.textbox2.Multiline = false;
            this.textbox2.Name = "textbox2";
            this.textbox2.Padding = new System.Windows.Forms.Padding(7);
            this.textbox2.PasswordChar = false;
            this.textbox2.Size = new System.Drawing.Size(298, 39);
            this.textbox2.TabIndex = 10;
            this.textbox2.Texts = "";
            this.textbox2.UnderlinedStyle = false;
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
            this.Dangxuat.Location = new System.Drawing.Point(846, 711);
            this.Dangxuat.Name = "Dangxuat";
            this.Dangxuat.Size = new System.Drawing.Size(464, 81);
            this.Dangxuat.TabIndex = 16;
            this.Dangxuat.Text = "Đăng xuất";
            this.Dangxuat.TextColor = System.Drawing.Color.White;
            this.Dangxuat.UseVisualStyleBackColor = false;
            this.Dangxuat.Click += new System.EventHandler(this.Dangxuat_Click);
            // 
            // QuanLyDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 844);
            this.Controls.Add(this.Dangxuat);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.DGV_HangHoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuanLyDanhMuc";
            this.Text = "QuanLyDanhMuc";
            this.Load += new System.EventHandler(this.QuanLyDanhMuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HangHoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_HangHoa;
        private More_option.CssButton btn_Sua;
        private More_option.CssButton btn_Xoa;
        private More_option.CssButton btn_Them;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private More_option.textbox textbox1;
        private More_option.textbox textbox2;
        private More_option.CssButton Dangxuat;
    }
}