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
        }

        private void btnAddGiangVien_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            gv.ID = this.txtIDGiangVien.Text.Trim();
            gv.Ten = this.txtTenGiangVien.Text.Trim();
            gv.NgaySinh = this.dtpNgaySinhGV.Value.Date;
            gv.ChucVu = this.txtChucVu.Text.Trim();
            gv.Khoa = this.cbbKhoa.Text.Trim();
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
        }
    }
}
