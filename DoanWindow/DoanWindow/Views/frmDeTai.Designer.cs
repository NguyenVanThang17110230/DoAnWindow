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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvDeTai = new System.Windows.Forms.DataGridView();
            this.cIDDetai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTenDeTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLoaiDeTai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGvhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cSolanBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTinhTrangBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNewDeTai = new System.Windows.Forms.Button();
            this.rbKT = new System.Windows.Forms.RadioButton();
            this.rbBD = new System.Windows.Forms.RadioButton();
            this.dtpKT = new System.Windows.Forms.DateTimePicker();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.cbbGVHD = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteDeTai = new System.Windows.Forms.Button();
            this.btnUpdateDeTai = new System.Windows.Forms.Button();
            this.btnAddDeTai = new System.Windows.Forms.Button();
            this.cbbLoaiDeTai = new System.Windows.Forms.ComboBox();
            this.txtSolanBC = new System.Windows.Forms.TextBox();
            this.txtSoLuongSV = new System.Windows.Forms.TextBox();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.txtIDDetai = new System.Windows.Forms.TextBox();
            this.txtTenDeTai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeTai)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1528, 586);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản lý danh sách đề tài";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvDeTai);
            this.groupBox4.Location = new System.Drawing.Point(407, 35);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1112, 545);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách đề tài";
            // 
            // dgvDeTai
            // 
            this.dgvDeTai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDeTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeTai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDDetai,
            this.cTenDeTai,
            this.cLoaiDeTai,
            this.cGvhd,
            this.cMoTa,
            this.cSoLuong,
            this.cNgayBD,
            this.cNgayKT,
            this.cSolanBC,
            this.cTinhTrangBC});
            this.dgvDeTai.Location = new System.Drawing.Point(10, 29);
            this.dgvDeTai.Name = "dgvDeTai";
            this.dgvDeTai.RowHeadersWidth = 51;
            this.dgvDeTai.RowTemplate.Height = 24;
            this.dgvDeTai.Size = new System.Drawing.Size(1093, 510);
            this.dgvDeTai.TabIndex = 0;
            this.dgvDeTai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDeTai_CellClick);
            // 
            // cIDDetai
            // 
            this.cIDDetai.HeaderText = "Mã đề tài";
            this.cIDDetai.MinimumWidth = 6;
            this.cIDDetai.Name = "cIDDetai";
            // 
            // cTenDeTai
            // 
            this.cTenDeTai.HeaderText = "Tên đề tài";
            this.cTenDeTai.MinimumWidth = 6;
            this.cTenDeTai.Name = "cTenDeTai";
            // 
            // cLoaiDeTai
            // 
            this.cLoaiDeTai.HeaderText = "Loại đề tài";
            this.cLoaiDeTai.MinimumWidth = 6;
            this.cLoaiDeTai.Name = "cLoaiDeTai";
            // 
            // cGvhd
            // 
            this.cGvhd.HeaderText = "Giáo viên hướng dẫn";
            this.cGvhd.MinimumWidth = 6;
            this.cGvhd.Name = "cGvhd";
            // 
            // cMoTa
            // 
            this.cMoTa.HeaderText = "Mô tả";
            this.cMoTa.MinimumWidth = 6;
            this.cMoTa.Name = "cMoTa";
            // 
            // cSoLuong
            // 
            this.cSoLuong.HeaderText = "Số lượng sinh viên";
            this.cSoLuong.MinimumWidth = 6;
            this.cSoLuong.Name = "cSoLuong";
            // 
            // cNgayBD
            // 
            this.cNgayBD.HeaderText = "Ngày bắt đầu";
            this.cNgayBD.MinimumWidth = 6;
            this.cNgayBD.Name = "cNgayBD";
            // 
            // cNgayKT
            // 
            this.cNgayKT.HeaderText = "Ngày kết thúc";
            this.cNgayKT.MinimumWidth = 6;
            this.cNgayKT.Name = "cNgayKT";
            // 
            // cSolanBC
            // 
            this.cSolanBC.HeaderText = "Số lần báo cáo";
            this.cSolanBC.MinimumWidth = 6;
            this.cSolanBC.Name = "cSolanBC";
            // 
            // cTinhTrangBC
            // 
            this.cTinhTrangBC.HeaderText = "Tình trạng";
            this.cTinhTrangBC.MinimumWidth = 6;
            this.cTinhTrangBC.Name = "cTinhTrangBC";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNewDeTai);
            this.groupBox2.Controls.Add(this.rbKT);
            this.groupBox2.Controls.Add(this.rbBD);
            this.groupBox2.Controls.Add(this.dtpKT);
            this.groupBox2.Controls.Add(this.dtpBD);
            this.groupBox2.Controls.Add(this.cbbGVHD);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnDeleteDeTai);
            this.groupBox2.Controls.Add(this.btnUpdateDeTai);
            this.groupBox2.Controls.Add(this.btnAddDeTai);
            this.groupBox2.Controls.Add(this.cbbLoaiDeTai);
            this.groupBox2.Controls.Add(this.txtSolanBC);
            this.groupBox2.Controls.Add(this.txtSoLuongSV);
            this.groupBox2.Controls.Add(this.txtMoTa);
            this.groupBox2.Controls.Add(this.txtIDDetai);
            this.groupBox2.Controls.Add(this.txtTenDeTai);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(6, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(395, 545);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phiếu thông tin";
            // 
            // btnNewDeTai
            // 
            this.btnNewDeTai.Location = new System.Drawing.Point(103, 460);
            this.btnNewDeTai.Name = "btnNewDeTai";
            this.btnNewDeTai.Size = new System.Drawing.Size(79, 34);
            this.btnNewDeTai.TabIndex = 12;
            this.btnNewDeTai.Text = "New";
            this.btnNewDeTai.UseVisualStyleBackColor = true;
            this.btnNewDeTai.Click += new System.EventHandler(this.btnNewDeTai_Click);
            // 
            // rbKT
            // 
            this.rbKT.AutoSize = true;
            this.rbKT.Location = new System.Drawing.Point(261, 399);
            this.rbKT.Name = "rbKT";
            this.rbKT.Size = new System.Drawing.Size(80, 21);
            this.rbKT.TabIndex = 11;
            this.rbKT.TabStop = true;
            this.rbKT.Text = "Kết thúc";
            this.rbKT.UseVisualStyleBackColor = true;
            // 
            // rbBD
            // 
            this.rbBD.AutoSize = true;
            this.rbBD.Location = new System.Drawing.Point(154, 399);
            this.rbBD.Name = "rbBD";
            this.rbBD.Size = new System.Drawing.Size(76, 21);
            this.rbBD.TabIndex = 10;
            this.rbBD.TabStop = true;
            this.rbBD.Text = "Bắt đầu";
            this.rbBD.UseVisualStyleBackColor = true;
            // 
            // dtpKT
            // 
            this.dtpKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKT.Location = new System.Drawing.Point(154, 322);
            this.dtpKT.Name = "dtpKT";
            this.dtpKT.Size = new System.Drawing.Size(205, 25);
            this.dtpKT.TabIndex = 9;
            // 
            // dtpBD
            // 
            this.dtpBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBD.Location = new System.Drawing.Point(154, 279);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.Size = new System.Drawing.Size(205, 25);
            this.dtpBD.TabIndex = 9;
            // 
            // cbbGVHD
            // 
            this.cbbGVHD.FormattingEnabled = true;
            this.cbbGVHD.Location = new System.Drawing.Point(154, 154);
            this.cbbGVHD.Name = "cbbGVHD";
            this.cbbGVHD.Size = new System.Drawing.Size(205, 25);
            this.cbbGVHD.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "Tình Trạng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Số lần báo cáo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Thời gian kết thúc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Thời gian bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Số lượng sinh viên:";
            // 
            // btnDeleteDeTai
            // 
            this.btnDeleteDeTai.Location = new System.Drawing.Point(292, 460);
            this.btnDeleteDeTai.Name = "btnDeleteDeTai";
            this.btnDeleteDeTai.Size = new System.Drawing.Size(79, 34);
            this.btnDeleteDeTai.TabIndex = 4;
            this.btnDeleteDeTai.Text = "Delete";
            this.btnDeleteDeTai.UseVisualStyleBackColor = true;
            this.btnDeleteDeTai.Click += new System.EventHandler(this.btnDeleteDeTai_Click);
            // 
            // btnUpdateDeTai
            // 
            this.btnUpdateDeTai.Location = new System.Drawing.Point(198, 460);
            this.btnUpdateDeTai.Name = "btnUpdateDeTai";
            this.btnUpdateDeTai.Size = new System.Drawing.Size(79, 34);
            this.btnUpdateDeTai.TabIndex = 4;
            this.btnUpdateDeTai.Text = "Update";
            this.btnUpdateDeTai.UseVisualStyleBackColor = true;
            this.btnUpdateDeTai.Click += new System.EventHandler(this.btnUpdateDeTai_Click);
            // 
            // btnAddDeTai
            // 
            this.btnAddDeTai.Location = new System.Drawing.Point(9, 460);
            this.btnAddDeTai.Name = "btnAddDeTai";
            this.btnAddDeTai.Size = new System.Drawing.Size(79, 34);
            this.btnAddDeTai.TabIndex = 4;
            this.btnAddDeTai.Text = "Add";
            this.btnAddDeTai.UseVisualStyleBackColor = true;
            this.btnAddDeTai.Click += new System.EventHandler(this.btnAddDeTai_Click);
            // 
            // cbbLoaiDeTai
            // 
            this.cbbLoaiDeTai.FormattingEnabled = true;
            this.cbbLoaiDeTai.Items.AddRange(new object[] {
            "Đồ án môn học",
            "Đồ án tốt nghiệp",
            "Tiểu luận chuyên ngành"});
            this.cbbLoaiDeTai.Location = new System.Drawing.Point(154, 112);
            this.cbbLoaiDeTai.Name = "cbbLoaiDeTai";
            this.cbbLoaiDeTai.Size = new System.Drawing.Size(205, 25);
            this.cbbLoaiDeTai.TabIndex = 2;
            // 
            // txtSolanBC
            // 
            this.txtSolanBC.Location = new System.Drawing.Point(154, 361);
            this.txtSolanBC.Name = "txtSolanBC";
            this.txtSolanBC.Size = new System.Drawing.Size(205, 25);
            this.txtSolanBC.TabIndex = 1;
            // 
            // txtSoLuongSV
            // 
            this.txtSoLuongSV.Location = new System.Drawing.Point(154, 240);
            this.txtSoLuongSV.Name = "txtSoLuongSV";
            this.txtSoLuongSV.Size = new System.Drawing.Size(205, 25);
            this.txtSoLuongSV.TabIndex = 1;
            // 
            // txtMoTa
            // 
            this.txtMoTa.Location = new System.Drawing.Point(154, 194);
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.Size = new System.Drawing.Size(205, 25);
            this.txtMoTa.TabIndex = 1;
            // 
            // txtIDDetai
            // 
            this.txtIDDetai.Location = new System.Drawing.Point(154, 29);
            this.txtIDDetai.Name = "txtIDDetai";
            this.txtIDDetai.Size = new System.Drawing.Size(205, 25);
            this.txtIDDetai.TabIndex = 1;
            // 
            // txtTenDeTai
            // 
            this.txtTenDeTai.Location = new System.Drawing.Point(154, 72);
            this.txtTenDeTai.Name = "txtTenDeTai";
            this.txtTenDeTai.Size = new System.Drawing.Size(205, 25);
            this.txtTenDeTai.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại đề tài:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giáo viên hướng dẫn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mô tả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đề tài:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đề tài:";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmDeTai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1545, 609);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDeTai";
            this.Text = "Thông tin đề tài";
            this.Load += new System.EventHandler(this.frmDeTai_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeTai)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvDeTai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteDeTai;
        private System.Windows.Forms.Button btnUpdateDeTai;
        private System.Windows.Forms.Button btnAddDeTai;
        private System.Windows.Forms.ComboBox cbbLoaiDeTai;
        private System.Windows.Forms.TextBox txtIDDetai;
        private System.Windows.Forms.TextBox txtTenDeTai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNewDeTai;
        private System.Windows.Forms.RadioButton rbKT;
        private System.Windows.Forms.RadioButton rbBD;
        private System.Windows.Forms.DateTimePicker dtpKT;
        private System.Windows.Forms.DateTimePicker dtpBD;
        private System.Windows.Forms.ComboBox cbbGVHD;
        private System.Windows.Forms.TextBox txtSolanBC;
        private System.Windows.Forms.TextBox txtSoLuongSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDetai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTenDeTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLoaiDeTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGvhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNgayKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn cSolanBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTinhTrangBC;
        private System.Windows.Forms.ErrorProvider error;
    }
}