namespace DoanWindow
{
    partial class frmBaoCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIDBaocao = new System.Windows.Forms.TextBox();
            this.cbbIDDetai = new System.Windows.Forms.ComboBox();
            this.cbbLanBC = new System.Windows.Forms.ComboBox();
            this.txtTailieu = new System.Windows.Forms.TextBox();
            this.txtNhanxet = new System.Windows.Forms.TextBox();
            this.txtDiem = new System.Windows.Forms.TextBox();
            this.rbHT = new System.Windows.Forms.RadioButton();
            this.rbCHT = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBaocao = new System.Windows.Forms.DataGridView();
            this.cIDBaocao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cIDDetai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLanBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTailieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNhanxet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTrangthai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaocao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã báo cáo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đề tài:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lần báo cáo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tài liệu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhận xét:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 458);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Điểm tổng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Trạng thái:";
            // 
            // txtIDBaocao
            // 
            this.txtIDBaocao.Location = new System.Drawing.Point(107, 43);
            this.txtIDBaocao.Name = "txtIDBaocao";
            this.txtIDBaocao.Size = new System.Drawing.Size(229, 22);
            this.txtIDBaocao.TabIndex = 1;
            // 
            // cbbIDDetai
            // 
            this.cbbIDDetai.FormattingEnabled = true;
            this.cbbIDDetai.Location = new System.Drawing.Point(107, 87);
            this.cbbIDDetai.Name = "cbbIDDetai";
            this.cbbIDDetai.Size = new System.Drawing.Size(229, 24);
            this.cbbIDDetai.TabIndex = 2;
            // 
            // cbbLanBC
            // 
            this.cbbLanBC.FormattingEnabled = true;
            this.cbbLanBC.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbbLanBC.Location = new System.Drawing.Point(107, 138);
            this.cbbLanBC.Name = "cbbLanBC";
            this.cbbLanBC.Size = new System.Drawing.Size(229, 24);
            this.cbbLanBC.TabIndex = 3;
            // 
            // txtTailieu
            // 
            this.txtTailieu.Location = new System.Drawing.Point(107, 183);
            this.txtTailieu.Name = "txtTailieu";
            this.txtTailieu.Size = new System.Drawing.Size(229, 22);
            this.txtTailieu.TabIndex = 4;
            // 
            // txtNhanxet
            // 
            this.txtNhanxet.Location = new System.Drawing.Point(107, 228);
            this.txtNhanxet.Name = "txtNhanxet";
            this.txtNhanxet.Size = new System.Drawing.Size(229, 22);
            this.txtNhanxet.TabIndex = 5;
            // 
            // txtDiem
            // 
            this.txtDiem.Location = new System.Drawing.Point(107, 272);
            this.txtDiem.Name = "txtDiem";
            this.txtDiem.Size = new System.Drawing.Size(229, 22);
            this.txtDiem.TabIndex = 6;
            // 
            // rbHT
            // 
            this.rbHT.AutoSize = true;
            this.rbHT.Location = new System.Drawing.Point(107, 321);
            this.rbHT.Name = "rbHT";
            this.rbHT.Size = new System.Drawing.Size(103, 21);
            this.rbHT.TabIndex = 7;
            this.rbHT.TabStop = true;
            this.rbHT.Text = "Hoàn thành";
            this.rbHT.UseVisualStyleBackColor = true;
            // 
            // rbCHT
            // 
            this.rbCHT.AutoSize = true;
            this.rbCHT.Location = new System.Drawing.Point(107, 362);
            this.rbCHT.Name = "rbCHT";
            this.rbCHT.Size = new System.Drawing.Size(138, 21);
            this.rbCHT.TabIndex = 8;
            this.rbCHT.TabStop = true;
            this.rbCHT.Text = "Chưa hoàn thành";
            this.rbCHT.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtIDBaocao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rbCHT);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rbHT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDiem);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNhanxet);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtTailieu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbbLanBC);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.cbbIDDetai);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 458);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin báo cáo";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(255, 405);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 32);
            this.btnNew.TabIndex = 13;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(173, 405);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 32);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(91, 405);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(65, 32);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(9, 406);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 32);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Điểm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBaocao);
            this.groupBox2.Location = new System.Drawing.Point(402, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(997, 458);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách báo cáo";
            // 
            // dgvBaocao
            // 
            this.dgvBaocao.AllowUserToOrderColumns = true;
            this.dgvBaocao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaocao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaocao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cIDBaocao,
            this.cIDDetai,
            this.cLanBC,
            this.cTailieu,
            this.cNhanxet,
            this.cDiem,
            this.cTrangthai});
            this.dgvBaocao.Location = new System.Drawing.Point(6, 46);
            this.dgvBaocao.Name = "dgvBaocao";
            this.dgvBaocao.RowHeadersWidth = 51;
            this.dgvBaocao.RowTemplate.Height = 24;
            this.dgvBaocao.Size = new System.Drawing.Size(973, 406);
            this.dgvBaocao.TabIndex = 0;
            this.dgvBaocao.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBaocao_CellClick);
            // 
            // cIDBaocao
            // 
            this.cIDBaocao.HeaderText = "Mã báo cáo";
            this.cIDBaocao.MinimumWidth = 6;
            this.cIDBaocao.Name = "cIDBaocao";
            // 
            // cIDDetai
            // 
            this.cIDDetai.HeaderText = "Mã đề tài";
            this.cIDDetai.MinimumWidth = 6;
            this.cIDDetai.Name = "cIDDetai";
            // 
            // cLanBC
            // 
            this.cLanBC.HeaderText = "Lần báo cáo";
            this.cLanBC.MinimumWidth = 6;
            this.cLanBC.Name = "cLanBC";
            // 
            // cTailieu
            // 
            this.cTailieu.HeaderText = "Tài liệu";
            this.cTailieu.MinimumWidth = 6;
            this.cTailieu.Name = "cTailieu";
            // 
            // cNhanxet
            // 
            this.cNhanxet.HeaderText = "Nhận xét";
            this.cNhanxet.MinimumWidth = 6;
            this.cNhanxet.Name = "cNhanxet";
            // 
            // cDiem
            // 
            this.cDiem.HeaderText = "Điểm";
            this.cDiem.MinimumWidth = 6;
            this.cDiem.Name = "cDiem";
            // 
            // cTrangthai
            // 
            this.cTrangthai.HeaderText = "Trạng thái";
            this.cTrangthai.MinimumWidth = 6;
            this.cTrangthai.Name = "cTrangthai";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1406, 484);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBaoCao";
            this.Text = "frmQLBC";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaocao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIDBaocao;
        private System.Windows.Forms.ComboBox cbbIDDetai;
        private System.Windows.Forms.ComboBox cbbLanBC;
        private System.Windows.Forms.TextBox txtTailieu;
        private System.Windows.Forms.TextBox txtNhanxet;
        private System.Windows.Forms.TextBox txtDiem;
        private System.Windows.Forms.RadioButton rbHT;
        private System.Windows.Forms.RadioButton rbCHT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBaocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDBaocao;
        private System.Windows.Forms.DataGridViewTextBoxColumn cIDDetai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLanBC;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTailieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNhanxet;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTrangthai;
        private System.Windows.Forms.ErrorProvider error;
    }
}