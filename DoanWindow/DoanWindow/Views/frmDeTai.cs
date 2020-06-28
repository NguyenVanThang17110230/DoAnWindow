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
    public partial class frmDeTai : Form
    {
        private QuanlidoansinhvienEntities sv = new QuanlidoansinhvienEntities();
        public frmDeTai()
        {
            InitializeComponent();
            this.cIDDetai.DataPropertyName = nameof(DeTai.ID);
            this.cTenDeTai.DataPropertyName = nameof(DeTai.TenDeTai);
            this.cLoaiDeTai.DataPropertyName = nameof(DeTai.LoaiDeTai);
            this.cGvhd.DataPropertyName = nameof(DeTai.GiaoVienHuongDan);
            this.cMoTa.DataPropertyName = nameof(DeTai.MoTa);
            this.cSoLuong.DataPropertyName = nameof(DeTai.SoLuongSinhVien);
            this.cNgayBD.DataPropertyName = nameof(DeTai.ThoiGianBatDau);
            this.cNgayKT.DataPropertyName = nameof(DeTai.ThoiGianKetThuc);
            this.cSolanBC.DataPropertyName = nameof(DeTai.SoLanBaoCao);
            this.cTinhTrangBC.DataPropertyName = nameof(DeTai.TinhTrang);
            dtpBD.Format = DateTimePickerFormat.Custom;
            dtpBD.CustomFormat = "dd/MM/yyyy";
            dtpKT.Format = DateTimePickerFormat.Custom;
            dtpKT.CustomFormat = "dd/MM/yyyy";
        }

        private void frmDeTai_Load(object sender, EventArgs e)
        {
            Load_data();
            Load_cbbGVHD();
            Load_cbbloaiDT();
            btnUpdateDeTai.Enabled = false;
            btnDeleteDeTai.Enabled = false;
            this.cbbGVHD.Text = "";
            this.cbbLoaiDeTai.Text = "";
        }

        public void Load_data()
        {
            var data = from c in sv.DeTais
                       select new
                       {
                           ID = c.ID,
                           TenDeTai = c.TenDeTai,
                           LoaiDeTai = c.LoaiDeTai,
                           GiaoVienHuongDan = c.GiaoVienHuongDan,
                           MoTa = c.MoTa,
                           SoLuongSinhVien = c.SoLuongSinhVien,
                           ThoiGianBatDau = c.ThoiGianBatDau,
                           ThoiGianKetThuc = c.ThoiGianKetThuc,
                           SoLanBaoCao = c.SoLanBaoCao,
                           TinhTrang = c.TinhTrang
                       };
            dgvDeTai.DataSource = data.ToList();
        }
        public void Load_cbbloaiDT()
        {
            List<LoaiDeTai> loaidetai = sv.LoaiDeTais.ToList();
            cbbLoaiDeTai.DataSource = loaidetai;
            cbbLoaiDeTai.ValueMember = "ID";
            cbbLoaiDeTai.DisplayMember = "LoaiDeTai1";
        }
        public void Load_cbbGVHD()
        {
            List<GiaoVien> gv = sv.GiaoViens.ToList();
            cbbGVHD.DataSource = gv;
            cbbGVHD.ValueMember = "ID";
            cbbGVHD.DisplayMember = "Ten";
        }
        public void clean()
        {
            this.txtIDDetai.Text = "";
            this.txtTenDeTai.Text = "";
            this.cbbLoaiDeTai.Text = "";
            this.cbbGVHD.Text = "";
            this.txtMoTa.Text = "";
            this.txtSoLuongSV.Text = "";
            this.dtpBD.Value = DateTime.Today;
            this.dtpKT.Value = DateTime.Today;
            this.txtSolanBC.Text = "";
            this.rbBD.Checked = false;
            this.rbKT.Checked = false;
        }
        private void dgvDeTai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDeleteDeTai.Enabled = true;
            btnUpdateDeTai.Enabled = true;
            this.txtIDDetai.Enabled = false;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvDeTai.Rows[e.RowIndex];
            txtIDDetai.Text = row.Cells[0].Value.ToString();
            txtTenDeTai.Text = row.Cells[1].Value.ToString();
            cbbLoaiDeTai.Text = row.Cells[2].Value.ToString();
            cbbGVHD.Text = row.Cells[3].Value.ToString();
            txtMoTa.Text = row.Cells[4].Value.ToString();
            txtSoLuongSV.Text = row.Cells[5].Value.ToString();
            dtpBD.Value = (DateTime)row.Cells[6].Value;
            dtpKT.Value = (DateTime)row.Cells[7].Value;
            txtSolanBC.Text = row.Cells[8].Value.ToString();
            try
            {
                if ((bool)row.Cells[9].Value == false)
                {
                    rbBD.Checked = true;
                }
                else rbKT.Checked = true;
            }
            catch
            { }
            timerdt.Start();
            this.pgbTime.Value = 0;
            this.label13.Text = "Day";
        }

        private void btnAddDeTai_Click(object sender, EventArgs e)
        {
            DeTai dt = new DeTai();
            if (txtIDDetai.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtIDDetai, "Hãy nhập mã đề tài!!!");
                return;
            }
            else if (DeTaiController.getdt(txtIDDetai.Text.Trim()) != null)
            {
                this.error.SetError(txtIDDetai, "ID đề tài đã tồn tại!!!");
                return;
            }
            this.error.Clear();
            if (txtTenDeTai.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtTenDeTai, "Hãy nhập tên của đề tài!!!");
                return;
            }
            this.error.Clear();
            if (cbbLoaiDeTai.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbLoaiDeTai, "Hãy nhập loại đề tài!!!");
                return;
            }
            this.error.Clear();
            if (cbbGVHD.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbGVHD, "Hãy nhập giảng viên hướng dẫn cho đề tài!!!");
                return;
            }
            this.error.Clear();
            if (txtMoTa.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtMoTa, "Hãy nhập mô tả cho đề tài!!!");
                return;
            }
            this.error.Clear();
            if (txtSoLuongSV.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtSoLuongSV, "Hãy nhập số lượng sinh viên thực hiện đề tài!!!");
                return;
            }
            this.error.Clear();
            DateTime now = DateTime.Now;
            if (dtpBD.Value < now)
            {
                this.error.SetError(dtpBD, "Ngày bắt đầu không thể nhỏ hơn thời điểm hiện tại!!!");
                return;
            }
            this.error.Clear();
            if (dtpKT.Value < dtpBD.Value)
            {
                this.error.SetError(dtpKT, "Ngày kết thúc không thể nhỏ hơn thời điểm bắt đầu!!!");
                return;
            }
            this.error.Clear();
            if (txtSolanBC.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtSolanBC, "Hãy nhập số lần báo cáo tiến độ đề tài!!!");
                return;
            }
            this.error.Clear();
            if (rbBD.Checked == false && rbKT.Checked == false)
            {
                this.error.SetError(rbKT, "Vui lòng chọn tình trạng của đề tài!!!!");
                return;
            }
            this.error.Clear();
            dt.ID = this.txtIDDetai.Text.Trim();
            dt.TenDeTai = this.txtTenDeTai.Text.Trim();
            dt.LoaiDeTai = this.cbbLoaiDeTai.SelectedValue.ToString();
            dt.GiaoVienHuongDan = this.cbbGVHD.SelectedValue.ToString();
            dt.MoTa = this.txtMoTa.Text.Trim();
            dt.SoLuongSinhVien = int.Parse(this.txtSoLuongSV.Text.ToString());
            dt.ThoiGianBatDau = this.dtpBD.Value.Date;
            dt.ThoiGianKetThuc = this.dtpKT.Value.Date;
            dt.SoLanBaoCao = int.Parse(this.txtSolanBC.Text.ToString());
            if (rbBD.Checked == true)
            {
                dt.TinhTrang = false;
            }
            else
            {
                dt.TinhTrang = true;
            }

            if (DeTaiController.adddetai(dt) == false)
            {
                MessageBox.Show("thêm thất bại");

            }
            Load_data();
            clean();

        }

        private void btnNewDeTai_Click(object sender, EventArgs e)
        {
            clean();
            txtIDDetai.Enabled = true;
        }

        private void btnUpdateDeTai_Click(object sender, EventArgs e)
        {

            if (txtTenDeTai.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtTenDeTai, "Hãy nhập tên của đề tài!!!");
                return;
            }
            this.error.Clear();
            if (cbbLoaiDeTai.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbLoaiDeTai, "Hãy nhập loại đề tài!!!");
                return;
            }
            this.error.Clear();
            if (cbbGVHD.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbGVHD, "Hãy nhập giảng viên hướng dẫn cho đề tài!!!");
                return;
            }
            this.error.Clear();
            if (txtMoTa.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtMoTa, "Hãy nhập mô tả cho đề tài!!!");
                return;
            }
            this.error.Clear();
            if (txtSoLuongSV.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtSoLuongSV, "Hãy nhập số lượng sinh viên thực hiện đề tài!!!");
                return;
            }
            this.error.Clear();
            DateTime now = DateTime.Now;
            if (dtpBD.Value < now)
            {
                this.error.SetError(dtpBD, "Ngày bắt đầu không thể nhỏ hơn thời điểm hiện tại!!!");
                return;
            }
            this.error.Clear();
            if (dtpKT.Value < dtpBD.Value)
            {
                this.error.SetError(dtpKT, "Ngày kết thúc không thể nhỏ hơn thời điểm bắt đầu!!!");
                return;
            }
            this.error.Clear();
            if (txtSolanBC.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtSolanBC, "Hãy nhập số lần báo cáo tiến độ đề tài!!!");
                return;
            }
            this.error.Clear();
            if (rbBD.Checked == false && rbKT.Checked == false)
            {
                this.error.SetError(rbKT, "Vui lòng chọn tình trạng của đề tài!!!!");
                return;
            }
            this.error.Clear();
            string IDDT = this.dgvDeTai.CurrentRow.Cells[0].Value.ToString();
            DeTai dt = sv.DeTais.Single(t => t.ID.Equals(IDDT));
            dt.TenDeTai = this.txtTenDeTai.Text.Trim();
            dt.LoaiDeTai = this.cbbLoaiDeTai.SelectedValue.ToString();
            dt.GiaoVienHuongDan = this.cbbGVHD.SelectedValue.ToString();
            dt.MoTa = this.txtMoTa.Text.Trim();
            dt.SoLuongSinhVien = int.Parse(this.txtSoLuongSV.Text.ToString());
            dt.ThoiGianBatDau = this.dtpBD.Value.Date;
            dt.ThoiGianKetThuc = this.dtpKT.Value.Date;
            dt.SoLanBaoCao = int.Parse(this.txtSolanBC.Text.ToString());
            if (rbBD.Checked == true)
            {
                dt.TinhTrang = false;
            }
            else
            {
                dt.TinhTrang = true;
            }
            if (DeTaiController.updatedetai(dt) == false)
            {
                MessageBox.Show("sửa thất bại");

            }
            Load_data();
            clean();
        }

        private void btnDeleteDeTai_Click(object sender, EventArgs e)
        {
            string MaDT = this.dgvDeTai.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                try
                {
                    DeTai dt = sv.DeTais.Single(t => t.ID.Equals(MaDT));
                    sv.DeTais.Remove(dt);
                    sv.SaveChanges();
                    Load_data();
                    MessageBox.Show("Xóa thành công!");
                    clean();

                }
                catch
                { MessageBox.Show("Xóa thất bại"); }
        }

        private void txtTimkiemdt_TextChanged(object sender, EventArgs e)
        {
            DeTaiController dtc = new DeTaiController();
            DataTable dt = dtc.Searchsv(txtTimkiemdt.Text);
            dgvDeTai.DataSource = dt;
            dgvDeTai.Refresh();
        }

        private void timerdt_Tick(object sender, EventArgs e)
        {
            DateTime dnow = DateTime.Now;
            if (this.dgvDeTai.Rows.Count > 0 && dnow < DateTime.Parse(this.dgvDeTai.CurrentRow.Cells[7].Value.ToString()))
            {
                TimeSpan ts = DateTime.Parse(this.dgvDeTai.CurrentRow.Cells[7].Value.ToString()) - dnow;

                if (this.label13.Text == "Day")
                {
                    int temp1 = int.Parse(Math.Round(ts.TotalDays).ToString());
                    if (temp1 <= 100)
                    {
                        pgbTime.Value += (100 - temp1);
                        timerdt.Stop();
                    }
                    else
                    {
                        pgbTime.Value = 100;
                        timerdt.Stop();
                    }
                }
            }
            else
            {
                pgbTime.Value = 100;
                timerdt.Stop();
            }
        }
    }
}
