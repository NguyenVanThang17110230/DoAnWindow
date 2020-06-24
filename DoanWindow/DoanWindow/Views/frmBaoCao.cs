using DoanWindow.Controllers;
using DoanWindow.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DoanWindow
{
    public partial class frmBaoCao : Form
    {
        private QuanlidoansinhvienEntities sv = new QuanlidoansinhvienEntities();
        public frmBaoCao()
        {
            InitializeComponent();
            this.cIDBaocao.DataPropertyName = nameof(BaoCao.IDBaoCao);
            this.cIDDetai.DataPropertyName = nameof(BaoCao.IDDeTai);
            this.cLanBC.DataPropertyName = nameof(BaoCao.LanBaoCao);
            this.cTailieu.DataPropertyName = nameof(BaoCao.TaiLieu);
            this.cNhanxet.DataPropertyName = nameof(BaoCao.NhanXet);
            this.cDiem.DataPropertyName = nameof(BaoCao.DiemTong);
            this.cTrangthai.DataPropertyName = nameof(BaoCao.TrangThai);
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            Load_data();
            Load_cbb_IDDetai();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            cbbIDDetai.Text = "";
            cbbLanBC.Text = "";
        }
        public void Load_data()
        {
            var data = from c in sv.BaoCaos
                       select new
                       {
                           IDBaoCao = c.IDBaoCao,
                           IDDeTai = c.IDDeTai,
                           LanBaoCao = c.LanBaoCao,
                           TaiLieu = c.TaiLieu,
                           NhanXet = c.NhanXet,
                           DiemTong = c.DiemTong,
                           TrangThai = c.TrangThai,
                       };
            dgvBaocao.DataSource = data.ToList();
        }
        public void Load_cbb_IDDetai()
        {
            List<DeTai> detai = sv.DeTais.ToList();
            cbbIDDetai.DataSource = detai;
            cbbIDDetai.ValueMember = "ID";
            cbbIDDetai.DisplayMember = "TenDeTai";
        }
        public void clean()
        {
            this.txtIDBaocao.Text = "";
            this.cbbIDDetai.Text = "";
            this.rbHT.Checked = false;
            this.rbCHT.Checked = false;
            this.cbbLanBC.Text = "";
            this.txtTailieu.Text = "";
            this.txtNhanxet.Text = "";
            this.txtDiem.Text = "";            
        }

        private void dgvBaocao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            this.txtIDBaocao.Enabled = false;
            DataGridViewRow row = new DataGridViewRow();
            row = dgvBaocao.Rows[e.RowIndex];
            txtIDBaocao.Text = row.Cells[0].Value.ToString();
            cbbIDDetai.Text = row.Cells[1].Value.ToString();
            cbbLanBC.Text = row.Cells[2].Value.ToString();
            txtTailieu.Text = row.Cells[3].Value.ToString();
            txtNhanxet.Text = row.Cells[4].Value.ToString();
            try
            {
                if(row.Cells[5].Value==null)
                {
                    txtDiem.Text = "0";
                }
                else
                {
                    txtDiem.Text = row.Cells[5].Value.ToString();
                }    
            }
            catch { }
            
            try
            {
                if ((bool)row.Cells[6].Value == true)
                {
                    rbHT.Checked = true;
                }
                else rbCHT.Checked = true;
            }
            catch
            {                   
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BaoCao bc = new BaoCao();
            if (txtIDBaocao.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtIDBaocao, "Hãy nhập mã cho báo cáo!!!");
                return;
            }
            else if (BaocaoController.getbc(txtIDBaocao.Text.Trim()) != null)
            {
                this.error.SetError(txtIDBaocao, "Mã báo cáo đã tồn tại!!!");
                return;
            }
            this.error.Clear();
            var num = (from u in sv.DeTais
                       where u.ID == cbbIDDetai.SelectedValue.ToString()
                       select u.SoLanBaoCao).FirstOrDefault();
            var num1 = from t in sv.BaoCaos
                       where t.IDDeTai == cbbIDDetai.SelectedValue.ToString()
                       select t.IDDeTai;
            int b = num1.Count();
            if (cbbIDDetai.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbIDDetai, "Hãy nhập mã đề tài cho báo cáo!!!");
                return;
            }
            else if (b == num)
            {
                this.error.SetError(cbbIDDetai, "Số lần báo cáo đã đủ!!!");
                return;
            }
            this.error.Clear();
            if (cbbLanBC.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbLanBC, "Hãy nhập lần báo cáo cho báo cáo!!!");
                return;
            }
            this.error.Clear();
            if (txtTailieu.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtTailieu, "Hãy nhập tài liệu cho báo cáo!!!");
                return;
            }
            this.error.Clear();
            if (txtNhanxet.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtNhanxet, "Hãy nhập nhận xét cho báo cáo!!!");
                return;
            }
            this.error.Clear();
            string phone = txtDiem.Text.ToString();
            Regex rg = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            rg.IsMatch(phone);
            if (rg.IsMatch(phone)==false)
            {
                this.error.SetError(txtDiem, "Điểm không chứa chữ cái!!!");
                return;
            }
            else if (float.Parse(txtDiem.Text.Trim())<0||float.Parse(txtDiem.Text.Trim())>10)
            {
                this.error.SetError(txtDiem, "Điểm không nằm trong phạm vi cho phép!!!");
                return;
            }    
            this.error.Clear();
            if (rbHT.Checked == false && rbCHT.Checked == false)
            {
                this.error.SetError(rbHT, "Hãy chọn tiến độ đề tài!!!");
                return;
            }
            this.error.Clear();
            bc.IDBaoCao = this.txtIDBaocao.Text.Trim();
            bc.IDDeTai = this.cbbIDDetai.SelectedValue.ToString();
            bc.LanBaoCao = int.Parse(this.cbbLanBC.SelectedItem.ToString());
            bc.TaiLieu = this.txtTailieu.Text.Trim();
            bc.NhanXet = this.txtNhanxet.Text.Trim();
            if(this.txtDiem.Text=="")
            {
                bc.DiemTong = null;
            }
            else
            {
                bc.DiemTong = float.Parse(this.txtDiem.Text.ToString());
            }           
            if (rbHT.Checked == true)
            {
                bc.TrangThai = true;
            }
            else
            {
                bc.TrangThai = false;
            }

            
            if (BaocaoController.addbc(bc) == false)
            {
                MessageBox.Show("thêm thất bại");

            }
            Load_data();
            clean();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var num = (from u in sv.DeTais
                       where u.ID == cbbIDDetai.SelectedValue.ToString()
                       select u.SoLanBaoCao).FirstOrDefault();
            var num1 = from t in sv.BaoCaos
                       where t.IDDeTai == cbbIDDetai.SelectedValue.ToString()
                       select t.IDDeTai;
            int b = num1.Count();
            if (cbbIDDetai.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbIDDetai, "Hãy nhập mã đề tài cho báo cáo!!!");
                return;
            }
            else if (b == (num+1))
            {
                this.error.SetError(cbbIDDetai, "Đề tài này đã đủ số lần báo cáo!!!");
                return;
            }
            this.error.Clear();
            if (cbbLanBC.Text.Trim().Length <= 0)
            {
                this.error.SetError(cbbLanBC, "Hãy nhập lần báo cáo cho báo cáo!!!");
                return;
            }
            this.error.Clear();
            if (txtTailieu.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtTailieu, "Hãy nhập tài liệu cho báo cáo!!!");
                return;
            }
            this.error.Clear();
            if (txtNhanxet.Text.Trim().Length <= 0)
            {
                this.error.SetError(txtNhanxet, "Hãy nhập nhận xét cho báo cáo!!!");
                return;
            }
            this.error.Clear();
            string phone = txtDiem.Text.ToString();
            Regex rg = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            rg.IsMatch(phone);
            if (rg.IsMatch(phone) == false)
            {
                this.error.SetError(txtDiem, "Điểm không chứa chữ cái!!!");
                return;
            }
            else if (float.Parse(txtDiem.Text.Trim()) < 0 || float.Parse(txtDiem.Text.Trim()) > 10)
            {
                this.error.SetError(txtDiem, "Điểm không nằm trong phạm vi cho phép!!!");
                return;
            }
            this.error.Clear();
            if (rbHT.Checked == false && rbCHT.Checked == false)
            {
                this.error.SetError(rbHT, "Hãy chọn tiến độ đề tài!!!");
                return;
            }
            this.error.Clear();
            string IDBC = this.dgvBaocao.CurrentRow.Cells[0].Value.ToString();
            BaoCao bc = sv.BaoCaos.Single(t => t.IDBaoCao.Equals(IDBC));
            bc.IDDeTai = this.cbbIDDetai.SelectedValue.ToString();
            bc.LanBaoCao = int.Parse(this.cbbLanBC.SelectedItem.ToString());
            bc.TaiLieu = this.txtTailieu.Text.Trim();
            bc.NhanXet = this.txtNhanxet.Text.Trim();
            if (this.txtDiem.Text == "")
            {
                bc.DiemTong = null;
            }
            else
            {
                bc.DiemTong = float.Parse(this.txtDiem.Text.ToString());
            }
            if (rbHT.Checked == true)
            {
                bc.TrangThai = true;
            }
            else
            {
                bc.TrangThai = false;
            }
            if (BaocaoController.updatebc(bc) == false)
            {
                MessageBox.Show("sửa thất bại");

            }
            Load_data();
            clean();
            this.txtIDBaocao.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string MaBC = this.dgvBaocao.CurrentRow.Cells[0].Value.ToString();
            DialogResult dr = MessageBox.Show("Bạn chắc chắn muốn xóa?", "confirm", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                try
                {
                    BaoCao bc = sv.BaoCaos.Single(t => t.IDBaoCao.Equals(MaBC));
                    sv.BaoCaos.Remove(bc);
                    sv.SaveChanges();
                    Load_data();
                    MessageBox.Show("Xóa thành công!!!");
                    clean();
                    txtIDBaocao.Enabled = true;

                }
                catch
                { MessageBox.Show("Xóa thất bại"); }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            clean();
            txtIDBaocao.Enabled = true;
        }

        private void txtTimkiembc_TextChanged(object sender, EventArgs e)
        {
            BaocaoController bcc = new BaocaoController();
            DataTable dt = bcc.Searchsv(txtTimkiembc.Text);
            dgvBaocao.DataSource = dt;
            dgvBaocao.Refresh();
        }

        private void cbbIDDetai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var num1 = from t in sv.BaoCaos
                       where t.IDDeTai == cbbIDDetai.SelectedIndex.ToString()
                       select t.IDDeTai;
            int b = num1.Count();
            cbbLanBC.Text =(b + 1).ToString();
        }
    }
}
