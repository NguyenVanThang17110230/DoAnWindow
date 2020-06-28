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
    public partial class frmGiangVien : Form
    {
        private QuanlidoansinhvienEntities sv = new QuanlidoansinhvienEntities();
        public frmGiangVien()
        {
            InitializeComponent();
            this.cID.DataPropertyName = nameof(GiaoVien.ID);
            this.cName.DataPropertyName = nameof(GiaoVien.Ten);
            this.cNgaySinh.DataPropertyName = nameof(GiaoVien.NgaySinh);
            this.cGioiTinh.DataPropertyName = nameof(GiaoVien.GioiTinh);
            this.cChucVu.DataPropertyName = nameof(GiaoVien.ChucVu);
            this.cKhoa.DataPropertyName = nameof(GiaoVien.Khoa);
            this.cDiaChi.DataPropertyName = nameof(GiaoVien.DiaChi);
            this.cSDT.DataPropertyName = nameof(GiaoVien.Sdt);
            dtpNgaySinhGV.Format = DateTimePickerFormat.Custom;
            dtpNgaySinhGV.CustomFormat = "dd/MM/yyyy";
        }

        private void btnAddGiangVien_Click(object sender, EventArgs e)
        {
            
            GiaoVien gv = new GiaoVien();
            if (txtIDGiangVien.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtIDGiangVien, "Hãy nhập mã giảng viên!!!");
                return;
            }
            else if (GiaoVienController.getgv(txtIDGiangVien.Text.Trim())!= null)
            {
                this.error.SetError(txtIDGiangVien, "ID đã tồn tại!!!");
                return;
            }
            this.error.Clear();
            if (txtTenGiangVien.Text.Trim().Length <=0)
            {
                this.error.SetError(txtTenGiangVien, "Hãy nhập tên của giảng viên!!!");
                return;
            }
            this.error.Clear();
            DateTime bd = dtpNgaySinhGV.Value;
            int y = bd.Year;
            int old = DateTime.Now.Year - y;
            if(old < 18)
            {
                this.error.SetError(dtpNgaySinhGV, "Giảng viên phải lớn hơn 18 tuổi!!!");
                return;
            }
            this.error.Clear();
            if (rbNam.Checked==false && rbNu.Checked==false)
            {
                this.error.SetError(rbNu, "Hãy chọn giới tính cho giảng viên!!!");
                return;
            }
            this.error.Clear();
            if (txtChucVu.Text.Trim().Length<=0)
            {
                this.error.SetError(txtChucVu, "Hãy nhập chức vụ của giảng viên!!!");
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
                this.error.SetError(txtDiaChi, "Hãy nhập địa chỉ của giảng viên!!!");
                return;
            }
            this.error.Clear();
            if (txtSDT.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtSDT, "Hãy nhập số điện thoại của giảng viên!!!");
                return;
            }
            else
            {
                this.error.Clear();
                string phone = txtSDT.Text.ToString();
                foreach(char c in phone)
                {
                    if(!Char.IsDigit(c))
                    {
                        this.error.SetError(txtSDT, "Số điện thoại không chứa chữ cái!!!");
                        return;
                    }    
                }    
            }
            this.error.Clear();

            gv.ID = this.txtIDGiangVien.Text.Trim();
            gv.Ten = this.txtTenGiangVien.Text.Trim();
            if ( rbNam.Checked == true )
            {
                gv.GioiTinh = true;
            } else
            {
                gv.GioiTinh = false;
            }   

            gv.NgaySinh = this.dtpNgaySinhGV.Value.Date;
            gv.ChucVu = this.txtChucVu.Text.Trim();
            gv.Khoa = this.cbbKhoa.SelectedValue.ToString();
            gv.DiaChi = this.txtDiaChi.Text.Trim();
            gv.Sdt = this.txtSDT.Text.Trim();
            if(GiaoVienController.addgiangvien(gv)==false)
            {
                MessageBox.Show("thêm thất bại");
                
            }
            Load_data();
            clean();
        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            
            Load_data();
            Load_khoa();
            btnUpdateGiangVien.Enabled = false;
            btnDeleteGiangVien.Enabled = false;
            this.cbbKhoa.Text = "";
        }
        public void Load_data()
        {
            var data = from c in sv.GiaoViens
                       select new
                       {
                           ID = c.ID,
                           Ten = c.Ten,
                           NgaySinh = c.NgaySinh,
                           GioiTinh = c.GioiTinh,
                           ChucVu = c.ChucVu,
                           Khoa = c.Khoa,
                           DiaChi = c.DiaChi,
                           Sdt = c.Sdt
                       };
            dgvGiangVien.DataSource = data.ToList();
        }
        public void clean()
        {
            this.txtIDGiangVien.Text = "";
            this.txtTenGiangVien.Text = "";
            this.dtpNgaySinhGV.Value = DateTime.Today;
            this.txtChucVu.Text = "";
            this.cbbKhoa.Text = "";
            this.txtDiaChi.Text = "";
            this.txtSDT.Text = "";
            this.rbNam.Checked=false;
            this.rbNu.Checked=false;
        }

        private void btnUpdateGiangVien_Click(object sender, EventArgs e)
        {

            if (txtTenGiangVien.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtTenGiangVien, "Hãy nhập tên của giảng viên!!!");
                return;
            }
            this.error.Clear();
            DateTime bd = dtpNgaySinhGV.Value;
            int y = bd.Year;
            int old = DateTime.Now.Year - y;
            if (old < 18)
            {
                this.error.SetError(dtpNgaySinhGV, "Giảng viên phải lớn hơn 18 tuổi!!!");
                return;
            }
            this.error.Clear();
            if (rbNam.Checked == false && rbNu.Checked == false)
            {
                this.error.SetError(rbNu, "Hãy chọn giới tính cho giảng viên!!!");
                return;
            }
            this.error.Clear();
            if (txtChucVu.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtChucVu, "Hãy nhập chức vụ của giảng viên!!!");
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
                this.error.SetError(txtDiaChi, "Hãy nhập địa chỉ của giảng viên!!!");
                return;
            }
            this.error.Clear();
            if (txtSDT.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtSDT, "Hãy nhập số điện thoại của giảng viên!!!");
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
            string IDNV = this.dgvGiangVien.CurrentRow.Cells[0].Value.ToString();
            GiaoVien gv = sv.GiaoViens.Single(t => t.ID.Equals(IDNV));
            gv.Ten = this.txtTenGiangVien.Text;
            gv.NgaySinh = this.dtpNgaySinhGV.Value.Date;
            if (rbNam.Checked == true)
            {
                gv.GioiTinh = true;
            }
            else gv.GioiTinh = false;
            gv.NgaySinh = this.dtpNgaySinhGV.Value.Date;
            gv.ChucVu = this.txtChucVu.Text.Trim();
            gv.Khoa = this.cbbKhoa.SelectedValue.ToString();
            gv.DiaChi = this.txtDiaChi.Text.Trim();
            gv.Sdt = this.txtSDT.Text.Trim();
            if (GiaoVienController.updategiangvien(gv) == false)
            {
                MessageBox.Show("sửa thất bại");

            }
            Load_data();
            clean();
        }

        public void Load_khoa()
        {
            List<Khoa> khoa = sv.Khoas.ToList();
            cbbKhoa.DataSource = khoa;
            cbbKhoa.ValueMember = "ID";
            cbbKhoa.DisplayMember = "TenKhoa";
        }

        private void dgvGiangVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteGiangVien.Enabled = true;
            btnUpdateGiangVien.Enabled = true;
            this.txtIDGiangVien.Enabled = false;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvGiangVien.Rows[e.RowIndex];
            txtIDGiangVien.Text = row.Cells[0].Value.ToString();
            txtTenGiangVien.Text = row.Cells[1].Value.ToString();
            dtpNgaySinhGV.Value = (DateTime)row.Cells[2].Value;
            try
            {
                if ((bool)row.Cells[3].Value == true)
                {
                    rbNam.Checked = true;
                }
                else rbNu.Checked = true;
            } catch
            {}
            txtChucVu.Text = row.Cells[4].Value.ToString();
            cbbKhoa.Text = row.Cells[5].Value.ToString();
            txtDiaChi.Text = row.Cells[6].Value.ToString();
            txtSDT.Text = row.Cells[7].Value.ToString();
        }

        private void btnDeleteGiangVien_Click(object sender, EventArgs e)
        {
            string MaGV = this.dgvGiangVien.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Are you sure?", "confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                try
                {
                    GiaoVien gv = sv.GiaoViens.Single(t => t.ID.Equals(MaGV));
                    sv.GiaoViens.Remove(gv);
                    sv.SaveChanges();
                    Load_data();
                    MessageBox.Show("Xóa thành công!");
                    clean();

                }
                catch
                { MessageBox.Show("Xóa thất bại"); }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtIDGiangVien.Enabled = true;
            clean();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            GiaoVienController gvc = new GiaoVienController();
            DataTable dt = gvc.Searchgv(txtTimKiem.Text);
            dgvGiangVien.DataSource = dt;
            dgvGiangVien.Refresh();
        }
    }
}
