namespace WindowsFormsApp1
{
    partial class QuanLyNhanVien
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
            this.btnSalary = new WindowsFormsApp1.More_option.CssButton();
            this.btnEdit = new WindowsFormsApp1.More_option.CssButton();
            this.btnRemove = new WindowsFormsApp1.More_option.CssButton();
            this.btnAdd = new WindowsFormsApp1.More_option.CssButton();
            this.cssButton1 = new WindowsFormsApp1.More_option.CssButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textbox1 = new WindowsFormsApp1.More_option.textbox();
            this.textbox2 = new WindowsFormsApp1.More_option.textbox();
            this.textbox3 = new WindowsFormsApp1.More_option.textbox();
            this.textbox5 = new WindowsFormsApp1.More_option.textbox();
            this.textbox6 = new WindowsFormsApp1.More_option.textbox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(32, 306);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(828, 348);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnSalary
            // 
            this.btnSalary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalary.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSalary.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSalary.BorderRadius = 20;
            this.btnSalary.BorderSize = 0;
            this.btnSalary.FlatAppearance.BorderSize = 0;
            this.btnSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalary.ForeColor = System.Drawing.Color.White;
            this.btnSalary.Location = new System.Drawing.Point(984, 478);
            this.btnSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalary.Name = "btnSalary";
            this.btnSalary.Size = new System.Drawing.Size(215, 65);
            this.btnSalary.TabIndex = 4;
            this.btnSalary.Text = "Tính lương";
            this.btnSalary.TextColor = System.Drawing.Color.White;
            this.btnSalary.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEdit.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btnEdit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEdit.BorderRadius = 20;
            this.btnEdit.BorderSize = 0;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(984, 359);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(215, 65);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Crimson;
            this.btnRemove.BackgroundColor = System.Drawing.Color.Crimson;
            this.btnRemove.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemove.BorderRadius = 20;
            this.btnRemove.BorderSize = 0;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(984, 230);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(215, 65);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Loại bỏ";
            this.btnRemove.TextColor = System.Drawing.Color.White;
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.BackgroundColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(984, 108);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(215, 65);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm nhân viên";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // cssButton1
            // 
            this.cssButton1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.cssButton1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.cssButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.cssButton1.BorderRadius = 20;
            this.cssButton1.BorderSize = 0;
            this.cssButton1.FlatAppearance.BorderSize = 0;
            this.cssButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cssButton1.ForeColor = System.Drawing.Color.White;
            this.cssButton1.Location = new System.Drawing.Point(984, 588);
            this.cssButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cssButton1.Name = "cssButton1";
            this.cssButton1.Size = new System.Drawing.Size(215, 66);
            this.cssButton1.TabIndex = 5;
            this.cssButton1.Text = "Chấm công";
            this.cssButton1.TextColor = System.Drawing.Color.White;
            this.cssButton1.UseVisualStyleBackColor = false;
            this.cssButton1.Click += new System.EventHandler(this.cssButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(461, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // textbox1
            // 
            this.textbox1.BackColor = System.Drawing.SystemColors.Window;
            this.textbox1.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox1.BorderSize = 2;
            this.textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox1.ForeColor = System.Drawing.Color.DimGray;
            this.textbox1.Location = new System.Drawing.Point(160, 86);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4);
            this.textbox1.Multiline = false;
            this.textbox1.Name = "textbox1";
            this.textbox1.Padding = new System.Windows.Forms.Padding(7);
            this.textbox1.PasswordChar = false;
            this.textbox1.Size = new System.Drawing.Size(250, 35);
            this.textbox1.TabIndex = 13;
            this.textbox1.Texts = "";
            this.textbox1.UnderlinedStyle = false;
            // 
            // textbox2
            // 
            this.textbox2.BackColor = System.Drawing.SystemColors.Window;
            this.textbox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox2.BorderSize = 2;
            this.textbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox2.ForeColor = System.Drawing.Color.DimGray;
            this.textbox2.Location = new System.Drawing.Point(160, 135);
            this.textbox2.Margin = new System.Windows.Forms.Padding(4);
            this.textbox2.Multiline = false;
            this.textbox2.Name = "textbox2";
            this.textbox2.Padding = new System.Windows.Forms.Padding(7);
            this.textbox2.PasswordChar = false;
            this.textbox2.Size = new System.Drawing.Size(250, 35);
            this.textbox2.TabIndex = 14;
            this.textbox2.Texts = "";
            this.textbox2.UnderlinedStyle = false;
            // 
            // textbox3
            // 
            this.textbox3.BackColor = System.Drawing.SystemColors.Window;
            this.textbox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox3.BorderSize = 2;
            this.textbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox3.ForeColor = System.Drawing.Color.DimGray;
            this.textbox3.Location = new System.Drawing.Point(160, 184);
            this.textbox3.Margin = new System.Windows.Forms.Padding(4);
            this.textbox3.Multiline = false;
            this.textbox3.Name = "textbox3";
            this.textbox3.Padding = new System.Windows.Forms.Padding(7);
            this.textbox3.PasswordChar = false;
            this.textbox3.Size = new System.Drawing.Size(250, 35);
            this.textbox3.TabIndex = 15;
            this.textbox3.Texts = "";
            this.textbox3.UnderlinedStyle = false;
            // 
            // textbox5
            // 
            this.textbox5.BackColor = System.Drawing.SystemColors.Window;
            this.textbox5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox5.BorderSize = 2;
            this.textbox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox5.ForeColor = System.Drawing.Color.DimGray;
            this.textbox5.Location = new System.Drawing.Point(589, 86);
            this.textbox5.Margin = new System.Windows.Forms.Padding(4);
            this.textbox5.Multiline = false;
            this.textbox5.Name = "textbox5";
            this.textbox5.Padding = new System.Windows.Forms.Padding(7);
            this.textbox5.PasswordChar = false;
            this.textbox5.Size = new System.Drawing.Size(250, 35);
            this.textbox5.TabIndex = 17;
            this.textbox5.Texts = "";
            this.textbox5.UnderlinedStyle = false;
            // 
            // textbox6
            // 
            this.textbox6.BackColor = System.Drawing.SystemColors.Window;
            this.textbox6.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox6.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox6.BorderSize = 2;
            this.textbox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox6.ForeColor = System.Drawing.Color.DimGray;
            this.textbox6.Location = new System.Drawing.Point(589, 135);
            this.textbox6.Margin = new System.Windows.Forms.Padding(4);
            this.textbox6.Multiline = false;
            this.textbox6.Name = "textbox6";
            this.textbox6.Padding = new System.Windows.Forms.Padding(7);
            this.textbox6.PasswordChar = false;
            this.textbox6.Size = new System.Drawing.Size(250, 35);
            this.textbox6.TabIndex = 16;
            this.textbox6.Texts = "";
            this.textbox6.UnderlinedStyle = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Mã Nhân Viên";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Tên Nhân Viên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Giới Tính";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Số Điện Thoại";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "Tài Khoản";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.HeaderText = "Mật Khẩu";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.textbox5);
            this.Controls.Add(this.textbox6);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cssButton1);
            this.Controls.Add(this.btnSalary);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyNhanVien";
            this.Text = "QuanLyNhanVien";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private More_option.CssButton btnAdd;
        private More_option.CssButton btnRemove;
        private More_option.CssButton btnEdit;
        private More_option.CssButton btnSalary;
        private More_option.CssButton cssButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private More_option.textbox textbox1;
        private More_option.textbox textbox2;
        private More_option.textbox textbox3;
        private More_option.textbox textbox5;
        private More_option.textbox textbox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}