namespace DoanWindow.Views
{
    partial class frmDiem
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
            this.dgvDiem = new System.Windows.Forms.DataGridView();
            this.cID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ckhoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTendt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cloaidt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDiemtong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDiem
            // 
            this.dgvDiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cID,
            this.cTen,
            this.cGioitinh,
            this.cLop,
            this.ckhoa,
            this.cTendt,
            this.cloaidt,
            this.cTrangthai,
            this.cDiemtong});
            this.dgvDiem.Location = new System.Drawing.Point(6, 74);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.RowHeadersWidth = 51;
            this.dgvDiem.RowTemplate.Height = 24;
            this.dgvDiem.Size = new System.Drawing.Size(1508, 511);
            this.dgvDiem.TabIndex = 0;
            // 
            // cID
            // 
            this.cID.HeaderText = "Mã số sinh viên";
            this.cID.MinimumWidth = 6;
            this.cID.Name = "cID";
            // 
            // cTen
            // 
            this.cTen.HeaderText = "Tên sinh viên";
            this.cTen.MinimumWidth = 6;
            this.cTen.Name = "cTen";
            // 
            // cGioitinh
            // 
            this.cGioitinh.HeaderText = "Giới tính";
            this.cGioitinh.MinimumWidth = 6;
            this.cGioitinh.Name = "cGioitinh";
            // 
            // cLop
            // 
            this.cLop.HeaderText = "Lớp";
            this.cLop.MinimumWidth = 6;
            this.cLop.Name = "cLop";
            // 
            // ckhoa
            // 
            this.ckhoa.HeaderText = "Khoa";
            this.ckhoa.MinimumWidth = 6;
            this.ckhoa.Name = "ckhoa";
            // 
            // cTendt
            // 
            this.cTendt.HeaderText = "Tên đề tài";
            this.cTendt.MinimumWidth = 6;
            this.cTendt.Name = "cTendt";
            // 
            // cloaidt
            // 
            this.cloaidt.HeaderText = "Loại đề tài";
            this.cloaidt.MinimumWidth = 6;
            this.cloaidt.Name = "cloaidt";
            // 
            // cTrangthai
            // 
            this.cTrangthai.HeaderText = "Trạng Thái";
            this.cTrangthai.MinimumWidth = 6;
            this.cTrangthai.Name = "cTrangthai";
            // 
            // cDiemtong
            // 
            this.cDiemtong.HeaderText = "Điểm tổng";
            this.cDiemtong.MinimumWidth = 6;
            this.cDiemtong.Name = "cDiemtong";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTimkiem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dgvDiem);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1520, 607);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin điểm số của sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tìm kiếm:";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(83, 30);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(330, 22);
            this.txtTimkiem.TabIndex = 2;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // frmDiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 644);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmDiem";
            this.Text = "frmDiem";
            this.Load += new System.EventHandler(this.frmDiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn cGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLop;
        private System.Windows.Forms.DataGridViewTextBoxColumn ckhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTendt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cloaidt;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTrangthai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDiemtong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Label label1;
    }
}