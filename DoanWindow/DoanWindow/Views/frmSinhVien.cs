using DoanWindow.Controllers;
using DoanWindow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoanWindow
{
    public partial class frmSinhVien : Form
    {
        private QuanlidoansinhvienEntities sv = new QuanlidoansinhvienEntities();
        public frmSinhVien()
        {
            InitializeComponent();
            this.cIDSV.DataPropertyName = nameof(SinhVien.ID);
            this.cTen.DataPropertyName = nameof(SinhVien.Ten);
            this.cGioiTinh.DataPropertyName = nameof(SinhVien.GioiTinh);
            this.cNgaySinh.DataPropertyName = nameof(SinhVien.NgaySinh);
            this.cLop.DataPropertyName = nameof(SinhVien.Lop);
            this.ckhoa.DataPropertyName = nameof(SinhVien.khoa);
            this.cDiachi.DataPropertyName = nameof(SinhVien.DiaChi);
            this.cSDT.DataPropertyName = nameof(SinhVien.Sdt);
            this.cDetai.DataPropertyName = nameof(SinhVien.DeTai);
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";            
        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            Load_data();
            Load_cbb_Detai();
            Load_cbb_Khoa();
            Load_cbb_Lop();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            this.cbbKhoa.Text = "";
            this.cbbLop.Text = "";
            this.cbbDetai.Text = "";
        }

        public void Load_data()
        {
            var data = from c in sv.SinhViens
                       select new
                       {
                           ID = c.ID,
                           Ten = c.Ten,
                           GioiTinh = c.GioiTinh,
                           NgaySinh = c.NgaySinh,
                           Lop = c.Lop,
                           Khoa = c.khoa,
                           DiaChi = c.DiaChi,
                           Sdt = c.Sdt,
                           DeTai = c.DeTai                           
                       };
            dgvSinhVien.DataSource = data.ToList();
        }
        public void Load_cbb_Khoa()
        {
            List<Khoa> khoa = sv.Khoas.ToList();
            cbbKhoa.DataSource = khoa;
            cbbKhoa.ValueMember = "ID";
            cbbKhoa.DisplayMember = "TenKhoa";
        }
        public void Load_cbb_Lop()
        {
            List<Lop> lop = sv.Lops.ToList();
            cbbLop.DataSource = lop;
            cbbLop.ValueMember = "ID";
            cbbLop.DisplayMember = "TenLop";
        }
        public void Load_cbb_Detai()
        {
            List<DeTai> dt = sv.DeTais.ToList();
            cbbDetai.DataSource = dt;
            cbbDetai.ValueMember = "ID";
            cbbDetai.DisplayMember = "TenDeTai";
        }
        public void clean()
        {
            this.txtIDSV.Text = "";
            this.txtTenSV.Text = "";
            this.rbNam.Checked = false;
            this.rbNu.Checked = false;
            this.dtpNgaySinh.Value = DateTime.Now;
            this.cbbLop.Text = "";
            this.cbbKhoa.Text = "";
            this.txtDiaChi.Text = "";
            this.txtSDT.Text = "";
            this.cbbDetai.Text = "";
        }

        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            this.txtIDSV.Enabled = false;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvSinhVien.Rows[e.RowIndex];
            txtIDSV.Text = row.Cells[0].Value.ToString();
            txtTenSV.Text = row.Cells[1].Value.ToString();
            try
            {
                if ((bool)row.Cells[2].Value == true)
                {
                    rbNam.Checked = true;
                }
                else rbNu.Checked = true;
            }
            catch
            { }
            dtpNgaySinh.Value = (DateTime)row.Cells[3].Value;
            cbbLop.Text = row.Cells[4].Value.ToString();
            cbbKhoa.Text = row.Cells[5].Value.ToString();
            txtDiaChi.Text = row.Cells[6].Value.ToString();
            txtSDT.Text = row.Cells[7].Value.ToString();
            cbbDetai.Text = row.Cells[8].Value.ToString();                       
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SinhVien sinhvien = new SinhVien();
            if (txtIDSV.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtIDSV, "Hãy nhập mã sinh viên!!!");
                return;
            }
            else if (SinhVienController.getsv(txtIDSV.Text.Trim()) != null)
            {
                this.error.SetError(txtIDSV, "ID đã tồn tại!!!");
                return;
            }
            this.error.Clear();
            if (txtTenSV.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtTenSV, "Hãy nhập tên của sinh viên!!!");
                return;
            }
            this.error.Clear();
            if (rbNam.Checked == false && rbNu.Checked == false)
            {
                this.error.SetError(rbNu, "Hãy chọn giới tính cho sinh viên!!!");
                return;
            }
            this.error.Clear();
            DateTime bd = dtpNgaySinh.Value;
            int y = bd.Year;
            int old = DateTime.Now.Year - y;
            if (old < 18)
            {
                this.error.SetError(dtpNgaySinh, "Sinh viên phải lớn hơn 18 tuổi!!!");
                return;
            }
            this.error.Clear();
           
            if (cbbLop.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbLop, "Hãy nhập lớp của sinh viên!!!");
                return;
            }
            this.error.Clear();
            if (cbbKhoa.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbKhoa, "Hãy nhập Khoa của giảng viên!!!");
                return;
            }
            this.error.Clear();
            if (txtDiaChi.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtDiaChi, "Hãy nhập địa chỉ của sinh viên!!!");
                return;
            }
            this.error.Clear();
            if (txtSDT.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtSDT, "Hãy nhập số điện thoại của sinh viên!!!");
                return;
            }
            else
            {
                this.error.Clear();
                string phone = txtSDT.Text.ToString();
                foreach (char c in phone)
                {
                    if (!Char.IsDigit(c))
                    {
                        this.error.SetError(txtSDT, "Số điện thoại không chứa chữ cái!!!");
                        return;
                    }
                }
            }
            this.error.Clear();
            var num = (from u in sv.DeTais
                      where u.ID==cbbDetai.SelectedValue.ToString()
                      select u.SoLuongSinhVien).FirstOrDefault();
            var num1 = from t in sv.SinhViens
                       where t.DeTai == cbbDetai.SelectedValue.ToString()
                       select t.DeTai;
            int b = num1.Count();
            if (cbbDetai.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbDetai, "Hãy nhập đề tài cho sinh viên!!!");
                return;
            }
            else if (b == num)
            {
                this.error.SetError(cbbDetai, "Đề tài này đã đủ số lượng sinh viên đăng ký!!!");
                return;
            }
            this.error.Clear();
            sinhvien.ID = this.txtIDSV.Text.Trim();
            sinhvien.Ten = this.txtTenSV.Text.Trim();
            if (rbNam.Checked == true)
            {
                sinhvien.GioiTinh = true;
            }
            else
            {
                sinhvien.GioiTinh = false;
            }

            sinhvien.NgaySinh = this.dtpNgaySinh.Value.Date;
            sinhvien.Lop = this.cbbLop.SelectedValue.ToString();
            sinhvien.khoa = this.cbbKhoa.SelectedValue.ToString();
            sinhvien.DiaChi = this.txtDiaChi.Text.Trim();           
            sinhvien.DiaChi = this.txtDiaChi.Text.Trim();
            sinhvien.Sdt = this.txtSDT.Text.Trim();
            sinhvien.DeTai = this.cbbDetai.SelectedValue.ToString();
            if (SinhVienController.addsinhvien(sinhvien) == false)
            {
                MessageBox.Show("thêm thất bại");

            }
            Load_data();
            clean();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clean();
            txtIDSV.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTenSV.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtTenSV, "Hãy nhập tên của sinh viên!!!");
                return;
            }
            this.error.Clear();
            if (rbNam.Checked == false && rbNu.Checked == false)
            {
                this.error.SetError(rbNu, "Hãy chọn giới tính cho sinh viên!!!");
                return;
            }
            this.error.Clear();
            DateTime bd = dtpNgaySinh.Value;
            int y = bd.Year;
            int old = DateTime.Now.Year - y;
            if (old < 18)
            {
                this.error.SetError(dtpNgaySinh, "Sinh viên phải lớn hơn 18 tuổi!!!");
                return;
            }
            this.error.Clear();

            if (cbbLop.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbLop, "Hãy nhập lớp của sinh viên!!!");
                return;
            }
            this.error.Clear();
            if (cbbKhoa.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbKhoa, "Hãy nhập Khoa của giảng viên!!!");
                return;
            }
            this.error.Clear();
            if (txtDiaChi.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtDiaChi, "Hãy nhập địa chỉ của sinh viên!!!");
                return;
            }
            this.error.Clear();
            if (txtSDT.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtSDT, "Hãy nhập số điện thoại của sinh viên!!!");
                return;
            }
            else
            {
                this.error.Clear();
                string phone = txtSDT.Text.ToString();
                foreach (char c in phone)
                {
                    if (!Char.IsDigit(c))
                    {
                        this.error.SetError(txtSDT, "Số điện thoại không chứa chữ cái!!!");
                        return;
                    }
                }
            }
            this.error.Clear();
            var num = (from u in sv.DeTais
                       where u.ID == cbbDetai.SelectedValue.ToString()
                       select u.SoLuongSinhVien).FirstOrDefault();
            var num1 = from t in sv.SinhViens
                       where t.DeTai == cbbDetai.SelectedValue.ToString()
                       select t.DeTai;
            int b = num1.Count();
            if (cbbDetai.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbDetai, "Hãy nhập đề tài cho sinh viên!!!");
                return;
            }
            else if (b > num)
            {
                this.error.SetError(cbbDetai, "Đề tài này đã đủ số lượng sinh viên đăng ký!!!");
                return;
            }
            this.error.Clear();
            string IDSV = this.dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
            SinhVien sinhvien = sv.SinhViens.Single(t => t.ID.Equals(IDSV));
            sinhvien.Ten = this.txtTenSV.Text.Trim();
            if (rbNam.Checked == true)
            {
                sinhvien.GioiTinh = true;
            }
            else
            {
                sinhvien.GioiTinh = false;
            }

            sinhvien.NgaySinh = this.dtpNgaySinh.Value.Date;
            sinhvien.Lop = this.cbbLop.SelectedValue.ToString();
            sinhvien.khoa = this.cbbKhoa.SelectedValue.ToString();
            sinhvien.DiaChi = this.txtDiaChi.Text.Trim();
            sinhvien.DiaChi = this.txtDiaChi.Text.Trim();
            sinhvien.Sdt = this.txtSDT.Text.Trim();
            sinhvien.DeTai = this.cbbDetai.SelectedValue.ToString();
            if (SinhVienController.updatesinhvien(sinhvien) == false)
            {
                MessageBox.Show("sửa thất bại");

            }
            Load_data();
            clean();
            this.txtIDSV.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string MaSV = this.dgvSinhVien.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                try
                {
                    SinhVien sinhvien = sv.SinhViens.Single(t => t.ID.Equals(MaSV));
                    sv.SinhViens.Remove(sinhvien);
                    sv.SaveChanges();
                    Load_data();
                    MessageBox.Show("Xóa thành công!!!");
                    clean();
                    txtIDSV.Enabled = true;

                }
                catch
                { MessageBox.Show("Xóa thất bại"); }
        }
    }
}
