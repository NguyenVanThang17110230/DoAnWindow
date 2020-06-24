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

namespace DoanWindow.Views
{
    public partial class frmDiem : Form
    {
        QuanlidoansinhvienEntities sv = new QuanlidoansinhvienEntities();
        public frmDiem()
        {
            InitializeComponent();
            this.cID.DataPropertyName = nameof(SinhVien.ID);
            this.cTen.DataPropertyName = nameof(SinhVien.Ten);
            this.cGioitinh.DataPropertyName = nameof(SinhVien.GioiTinh);
            this.cLop.DataPropertyName = nameof(SinhVien.Lop);
            this.ckhoa.DataPropertyName = nameof(SinhVien.khoa);
            this.cTendt.DataPropertyName = nameof(DeTai.TenDeTai);
            this.cloaidt.DataPropertyName = nameof(LoaiDeTai.ID);
            this.cTrangthai.DataPropertyName = nameof(BaoCao.TrangThai);
            this.cDiemtong.DataPropertyName = nameof(BaoCao.DiemTong);
            
        }

        private void frmDiem_Load(object sender, EventArgs e)
        {
            Load_data();
        }
        public void Load_data()
        {
            var data = from c in sv.DeTais
                       join d in sv.SinhViens on c.ID equals d.DeTai
                       join a in sv.Lops on d.Lop equals a.ID
                       join b in sv.Khoas on d.khoa equals b.ID
                       join f in sv.BaoCaos on c.ID equals f.IDDeTai
                       join g in sv.LoaiDeTais on c.LoaiDeTai equals g.ID
                       where f.TrangThai==true
                       select new
                       {
                           ID = d.ID,
                           Ten = d.Ten,
                           GioiTinh = d.GioiTinh,
                           Lop = a.TenLop,
                           Khoa = b.TenKhoa,
                           TenDeTai = c.TenDeTai,
                           LoaiDeTai = g.LoaiDeTai1,
                           TrangThai = f.TrangThai,
                           DiemTong = f.DiemTong
 
                       };
            dgvDiem.DataSource = data.ToList();
        }

        private void txtTimkiem_TextChanged(object sender, EventArgs e)
        {
            DiemController dc = new DiemController();
            DataTable dt = dc.Searchsv(txtTimkiem.Text);
            dgvDiem.DataSource = dt;
            dgvDiem.Refresh();
        }
    }
}
