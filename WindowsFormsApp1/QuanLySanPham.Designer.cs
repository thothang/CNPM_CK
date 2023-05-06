namespace WindowsFormsApp1
{
    partial class QuanLySanPham
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textbox3 = new WindowsFormsApp1.More_option.textbox();
            this.textbox2 = new WindowsFormsApp1.More_option.textbox();
            this.textbox1 = new WindowsFormsApp1.More_option.textbox();
            this.btn_Sua = new WindowsFormsApp1.More_option.CssButton();
            this.btn_Xoa = new WindowsFormsApp1.More_option.CssButton();
            this.btn_Them = new WindowsFormsApp1.More_option.CssButton();
            this.Dangxuat = new WindowsFormsApp1.More_option.CssButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(47, 231);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(983, 585);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Mã Hàng Hoá";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên Hàng Hoá";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Giá";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Hàng Hoá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên Hàng Hoá:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Giá:";
            // 
            // textbox3
            // 
            this.textbox3.BackColor = System.Drawing.SystemColors.Window;
            this.textbox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox3.BorderSize = 2;
            this.textbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox3.ForeColor = System.Drawing.Color.DimGray;
            this.textbox3.Location = new System.Drawing.Point(201, 141);
            this.textbox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox3.Multiline = false;
            this.textbox3.Name = "textbox3";
            this.textbox3.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.textbox3.PasswordChar = false;
            this.textbox3.Size = new System.Drawing.Size(281, 43);
            this.textbox3.TabIndex = 10;
            this.textbox3.Texts = "";
            this.textbox3.UnderlinedStyle = false;
            // 
            // textbox2
            // 
            this.textbox2.BackColor = System.Drawing.SystemColors.Window;
            this.textbox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox2.BorderSize = 2;
            this.textbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox2.ForeColor = System.Drawing.Color.DimGray;
            this.textbox2.Location = new System.Drawing.Point(749, 36);
            this.textbox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox2.Multiline = false;
            this.textbox2.Name = "textbox2";
            this.textbox2.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.textbox2.PasswordChar = false;
            this.textbox2.Size = new System.Drawing.Size(281, 43);
            this.textbox2.TabIndex = 9;
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
            this.textbox1.Location = new System.Drawing.Point(201, 36);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textbox1.Multiline = false;
            this.textbox1.Name = "textbox1";
            this.textbox1.Padding = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.textbox1.PasswordChar = false;
            this.textbox1.Size = new System.Drawing.Size(281, 43);
            this.textbox1.TabIndex = 8;
            this.textbox1.Texts = "";
            this.textbox1.UnderlinedStyle = false;
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
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(1114, 631);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(230, 72);
            this.btn_Sua.TabIndex = 3;
            this.btn_Sua.Text = "Sửa sản phẩm";
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
            this.btn_Xoa.Location = new System.Drawing.Point(1114, 515);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(230, 72);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa sản phẩm";
            this.btn_Xoa.TextColor = System.Drawing.Color.White;
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
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
            this.btn_Them.Location = new System.Drawing.Point(1114, 401);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(230, 72);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm sản phẩm";
            this.btn_Them.TextColor = System.Drawing.Color.White;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
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
            this.Dangxuat.Location = new System.Drawing.Point(1114, 751);
            this.Dangxuat.Name = "Dangxuat";
            this.Dangxuat.Size = new System.Drawing.Size(230, 65);
            this.Dangxuat.TabIndex = 16;
            this.Dangxuat.Text = "Đăng xuất";
            this.Dangxuat.TextColor = System.Drawing.Color.White;
            this.Dangxuat.UseVisualStyleBackColor = false;
            this.Dangxuat.Click += new System.EventHandler(this.Dangxuat_Click);
            // 
            // QuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 844);
            this.Controls.Add(this.Dangxuat);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLySanPham";
            this.Text = "QuanLySanPham";
            this.Load += new System.EventHandler(this.QuanLySanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private More_option.CssButton btn_Them;
        private More_option.CssButton btn_Xoa;
        private More_option.CssButton btn_Sua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private More_option.textbox textbox1;
        private More_option.textbox textbox2;
        private More_option.textbox textbox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private More_option.CssButton Dangxuat;
    }
}