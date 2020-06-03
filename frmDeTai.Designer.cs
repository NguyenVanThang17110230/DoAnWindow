namespace DoanWindow
{
    partial class frmDeTai
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteDeTai = new System.Windows.Forms.Button();
            this.btnUpdateDeTai = new System.Windows.Forms.Button();
            this.btnAddDeTai = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbbLoaiDeTai = new System.Windows.Forms.ComboBox();
            this.txtMoTaDeTai = new System.Windows.Forms.TextBox();
            this.txtTenDeTai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhomDangKy = new System.Windows.Forms.TextBox();
            this.ColumnLoaiDeTai = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnTenDeTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNgayDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNhomDangKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(-5, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(944, 428);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý danh sách đề tài";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(385, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(553, 380);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách đề tài";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnLoaiDeTai,
            this.ColumnTenDeTai,
            this.ColumnMoTa,
            this.ColumnNgayDangKy,
            this.ColumnNhomDangKy});
            this.dataGridView1.Location = new System.Drawing.Point(10, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(537, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteDeTai);
            this.groupBox2.Controls.Add(this.btnUpdateDeTai);
            this.groupBox2.Controls.Add(this.btnAddDeTai);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.cbbLoaiDeTai);
            this.groupBox2.Controls.Add(this.txtNhomDangKy);
            this.groupBox2.Controls.Add(this.txtMoTaDeTai);
            this.groupBox2.Controls.Add(this.txtTenDeTai);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 380);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu thông tin";
            // 
            // btnDeleteDeTai
            // 
            this.btnDeleteDeTai.Location = new System.Drawing.Point(225, 338);
            this.btnDeleteDeTai.Name = "btnDeleteDeTai";
            this.btnDeleteDeTai.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteDeTai.TabIndex = 4;
            this.btnDeleteDeTai.Text = "Delete";
            this.btnDeleteDeTai.UseVisualStyleBackColor = true;
            // 
            // btnUpdateDeTai
            // 
            this.btnUpdateDeTai.Location = new System.Drawing.Point(117, 338);
            this.btnUpdateDeTai.Name = "btnUpdateDeTai";
            this.btnUpdateDeTai.Size = new System.Drawing.Size(102, 23);
            this.btnUpdateDeTai.TabIndex = 4;
            this.btnUpdateDeTai.Text = "Update";
            this.btnUpdateDeTai.UseVisualStyleBackColor = true;
            // 
            // btnAddDeTai
            // 
            this.btnAddDeTai.Location = new System.Drawing.Point(9, 338);
            this.btnAddDeTai.Name = "btnAddDeTai";
            this.btnAddDeTai.Size = new System.Drawing.Size(102, 23);
            this.btnAddDeTai.TabIndex = 4;
            this.btnAddDeTai.Text = "Add";
            this.btnAddDeTai.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 142);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(215, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // cbbLoaiDeTai
            // 
            this.cbbLoaiDeTai.FormattingEnabled = true;
            this.cbbLoaiDeTai.Items.AddRange(new object[] {
            "Đồ án môn học",
            "Đồ án tốt nghiệp",
            "Tiểu luận chuyên ngành"});
            this.cbbLoaiDeTai.Location = new System.Drawing.Point(112, 29);
            this.cbbLoaiDeTai.Name = "cbbLoaiDeTai";
            this.cbbLoaiDeTai.Size = new System.Drawing.Size(215, 24);
            this.cbbLoaiDeTai.TabIndex = 2;
            // 
            // txtMoTaDeTai
            // 
            this.txtMoTaDeTai.Location = new System.Drawing.Point(112, 107);
            this.txtMoTaDeTai.Name = "txtMoTaDeTai";
            this.txtMoTaDeTai.Size = new System.Drawing.Size(215, 22);
            this.txtMoTaDeTai.TabIndex = 1;
            // 
            // txtTenDeTai
            // 
            this.txtTenDeTai.Location = new System.Drawing.Point(112, 73);
            this.txtTenDeTai.Name = "txtTenDeTai";
            this.txtTenDeTai.Size = new System.Drawing.Size(215, 22);
            this.txtTenDeTai.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mô tả:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ngày đăng ký:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nhóm đăng ký:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đề tài:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại đề tài:";
            // 
            // txtNhomDangKy
            // 
            this.txtNhomDangKy.Location = new System.Drawing.Point(112, 183);
            this.txtNhomDangKy.Name = "txtNhomDangKy";
            this.txtNhomDangKy.Size = new System.Drawing.Size(215, 22);
            this.txtNhomDangKy.TabIndex = 1;
            // 
            // ColumnLoaiDeTai
            // 
            this.ColumnLoaiDeTai.HeaderText = "Loại Đề Tài";
            this.ColumnLoaiDeTai.MinimumWidth = 6;
            this.ColumnLoaiDeTai.Name = "ColumnLoaiDeTai";
            this.ColumnLoaiDeTai.Width = 125;
            // 
            // ColumnTenDeTai
            // 
            this.ColumnTenDeTai.HeaderText = "Tên Đề Tài";
            this.ColumnTenDeTai.MinimumWidth = 6;
            this.ColumnTenDeTai.Name = "ColumnTenDeTai";
            this.ColumnTenDeTai.Width = 125;
            // 
            // ColumnMoTa
            // 
            this.ColumnMoTa.HeaderText = "Mô Tả";
            this.ColumnMoTa.MinimumWidth = 6;
            this.ColumnMoTa.Name = "ColumnMoTa";
            this.ColumnMoTa.Width = 125;
            // 
            // ColumnNgayDangKy
            // 
            this.ColumnNgayDangKy.HeaderText = "Ngày Đăng Ký";
            this.ColumnNgayDangKy.MinimumWidth = 6;
            this.ColumnNgayDangKy.Name = "ColumnNgayDangKy";
            this.ColumnNgayDangKy.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNgayDangKy.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnNgayDangKy.Width = 125;
            // 
            // ColumnNhomDangKy
            // 
            this.ColumnNhomDangKy.HeaderText = "Nhóm Đăng Ký";
            this.ColumnNhomDangKy.MinimumWidth = 6;
            this.ColumnNhomDangKy.Name = "ColumnNhomDangKy";
            this.ColumnNhomDangKy.Width = 125;
            // 
            // frmDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDeTai";
            this.Text = "Form Đề Tài";
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteDeTai;
        private System.Windows.Forms.Button btnUpdateDeTai;
        private System.Windows.Forms.Button btnAddDeTai;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cbbLoaiDeTai;
        private System.Windows.Forms.TextBox txtMoTaDeTai;
        private System.Windows.Forms.TextBox txtTenDeTai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhomDangKy;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnLoaiDeTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTenDeTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNgayDangKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNhomDangKy;
    }
}