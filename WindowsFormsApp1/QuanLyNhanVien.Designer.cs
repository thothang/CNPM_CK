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
            this.lb1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textbox3 = new WindowsFormsApp1.More_option.textbox();
            this.textbox4 = new WindowsFormsApp1.More_option.textbox();
            this.textbox2 = new WindowsFormsApp1.More_option.textbox();
            this.textbox1 = new WindowsFormsApp1.More_option.textbox();
            this.Dangxuat = new WindowsFormsApp1.More_option.CssButton();
            this.btnEdit = new WindowsFormsApp1.More_option.CssButton();
            this.btnRemove = new WindowsFormsApp1.More_option.CssButton();
            this.btnAdd = new WindowsFormsApp1.More_option.CssButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textbox5 = new WindowsFormsApp1.More_option.textbox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(34, 201);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(828, 434);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.Location = new System.Drawing.Point(29, 53);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(108, 20);
            this.lb1.TabIndex = 19;
            this.lb1.Text = "Mã nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(479, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Số điện thoại";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Giới Tính";
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
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Giới Tính";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "SDT";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Mật Khẩu";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // textbox3
            // 
            this.textbox3.BackColor = System.Drawing.SystemColors.Window;
            this.textbox3.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox3.BorderSize = 2;
            this.textbox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox3.ForeColor = System.Drawing.Color.DimGray;
            this.textbox3.Location = new System.Drawing.Point(605, 42);
            this.textbox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox3.Multiline = false;
            this.textbox3.Name = "textbox3";
            this.textbox3.Padding = new System.Windows.Forms.Padding(6);
            this.textbox3.PasswordChar = false;
            this.textbox3.Size = new System.Drawing.Size(257, 33);
            this.textbox3.TabIndex = 25;
            this.textbox3.Texts = "";
            this.textbox3.UnderlinedStyle = false;
            // 
            // textbox4
            // 
            this.textbox4.BackColor = System.Drawing.SystemColors.Window;
            this.textbox4.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox4.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox4.BorderSize = 2;
            this.textbox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox4.ForeColor = System.Drawing.Color.DimGray;
            this.textbox4.Location = new System.Drawing.Point(188, 140);
            this.textbox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox4.Multiline = false;
            this.textbox4.Name = "textbox4";
            this.textbox4.Padding = new System.Windows.Forms.Padding(6);
            this.textbox4.PasswordChar = false;
            this.textbox4.Size = new System.Drawing.Size(257, 33);
            this.textbox4.TabIndex = 24;
            this.textbox4.Texts = "";
            this.textbox4.UnderlinedStyle = false;
            // 
            // textbox2
            // 
            this.textbox2.BackColor = System.Drawing.SystemColors.Window;
            this.textbox2.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox2.BorderSize = 2;
            this.textbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox2.ForeColor = System.Drawing.Color.DimGray;
            this.textbox2.Location = new System.Drawing.Point(188, 90);
            this.textbox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox2.Multiline = false;
            this.textbox2.Name = "textbox2";
            this.textbox2.Padding = new System.Windows.Forms.Padding(6);
            this.textbox2.PasswordChar = false;
            this.textbox2.Size = new System.Drawing.Size(257, 33);
            this.textbox2.TabIndex = 23;
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
            this.textbox1.Location = new System.Drawing.Point(188, 42);
            this.textbox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox1.Multiline = false;
            this.textbox1.Name = "textbox1";
            this.textbox1.Padding = new System.Windows.Forms.Padding(6);
            this.textbox1.PasswordChar = false;
            this.textbox1.Size = new System.Drawing.Size(257, 33);
            this.textbox1.TabIndex = 18;
            this.textbox1.Texts = "";
            this.textbox1.UnderlinedStyle = false;
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
            this.Dangxuat.Location = new System.Drawing.Point(988, 574);
            this.Dangxuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dangxuat.Name = "Dangxuat";
            this.Dangxuat.Size = new System.Drawing.Size(215, 61);
            this.Dangxuat.TabIndex = 17;
            this.Dangxuat.Text = "Đăng xuất";
            this.Dangxuat.TextColor = System.Drawing.Color.White;
            this.Dangxuat.UseVisualStyleBackColor = false;
            this.Dangxuat.Click += new System.EventHandler(this.Dangxuat_Click);
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
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(988, 476);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(215, 65);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.TextColor = System.Drawing.Color.White;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Tomato;
            this.btnRemove.BackgroundColor = System.Drawing.Color.Tomato;
            this.btnRemove.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRemove.BorderRadius = 20;
            this.btnRemove.BorderSize = 0;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(988, 373);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(215, 65);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Loại bỏ";
            this.btnRemove.TextColor = System.Drawing.Color.White;
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
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
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(988, 268);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(215, 65);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm nhân viên";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(479, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Passwords";
            // 
            // textbox5
            // 
            this.textbox5.BackColor = System.Drawing.SystemColors.Window;
            this.textbox5.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.textbox5.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textbox5.BorderSize = 2;
            this.textbox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox5.ForeColor = System.Drawing.Color.DimGray;
            this.textbox5.Location = new System.Drawing.Point(605, 90);
            this.textbox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textbox5.Multiline = false;
            this.textbox5.Name = "textbox5";
            this.textbox5.Padding = new System.Windows.Forms.Padding(6);
            this.textbox5.PasswordChar = false;
            this.textbox5.Size = new System.Drawing.Size(257, 33);
            this.textbox5.TabIndex = 27;
            this.textbox5.Texts = "";
            this.textbox5.UnderlinedStyle = false;
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 675);
            this.Controls.Add(this.textbox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textbox3);
            this.Controls.Add(this.textbox4);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.Dangxuat);
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
        private More_option.CssButton Dangxuat;
        private More_option.textbox textbox1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private More_option.textbox textbox2;
        private More_option.textbox textbox3;
        private More_option.textbox textbox4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label4;
        private More_option.textbox textbox5;
    }
}