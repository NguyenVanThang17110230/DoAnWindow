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
    public partial class frmMain : Form
    {
        frmBaoCao formbaocao;
        frmDeTai formdetai;
        frmSinhVien formsinhvien;
        frmGiangVien formgiangvien;
        frmDiem formdiem;
        string Quyen = "";
        public frmMain(string Quyen)
        {
            InitializeComponent();      
            Width = 1200;
            Height = 600;
            this.Quyen = Quyen;
        }
        private void sinhvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Quyen=="1"||Quyen=="2")
            {
                if (this.formsinhvien is null || this.formsinhvien.IsDisposed)
                {
                    this.formsinhvien = new frmSinhVien();
                    formsinhvien.MdiParent = this;
                    this.formsinhvien.Show();
                }
                else
                {
                    this.formsinhvien.Select();
                }
            }    
            else
            {
                MessageBox.Show("Bạn không có quyền!!!!");
            }    
        }

        private void giangvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Quyen=="1")
            {
                if (this.formgiangvien is null || this.formgiangvien.IsDisposed)
                {
                    this.formgiangvien = new frmGiangVien();
                    formgiangvien.MdiParent = this;
                    this.formgiangvien.Show();
                }
                else
                {
                    this.formgiangvien.Select();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền!!!", "Thông báo");
            }
        }

        private void detaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.formdetai is null || this.formdetai.IsDisposed)
            {
                this.formdetai = new frmDeTai();
                formdetai.MdiParent = this;
                this.formdetai.Show();
            }
            else
            {
                this.formdetai.Select();
            }
        }

        private void tiendoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Quyen=="1")
            {
                if (this.formbaocao is null || this.formbaocao.IsDisposed)
                {
                    this.formbaocao = new frmBaoCao();
                    formbaocao.MdiParent = this;
                    this.formbaocao.Show();
                }
                else
                {
                    this.formbaocao.Select();
                }
            }
            else
            {
                MessageBox.Show("Bạn không có quyền!!!", "Thông báo");
            }    
            
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null)
            {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;

            if (this.ActiveMdiChild.Tag == null)
            {
                TabPage tp = new TabPage(this.ActiveMdiChild.Text);
                tp.Tag = this.ActiveMdiChild;
                tp.Parent = this.tabMain;
                this.tabMain.SelectedTab = tp;
                this.ActiveMdiChild.Tag = tp;
                this.ActiveMdiChild.FormClosed += ActiveMdiChild_FormClosed;
            }
        }

        private void ActiveMdiChild_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabMain.SelectedTab != null && this.tabMain.SelectedTab.Tag != null)
            {
                (this.tabMain.SelectedTab.Tag as Form).Select();
            }
        }

        private void dangxuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bạn chắc chắn muốn đăng xuất", "Thông báo", MessageBoxButtons.YesNo);
            if(dialog==System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                Form lg = new frmLogin();
                lg.ShowDialog();
                this.Close();
            }
        }

        private void xemdiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.formdiem is null || this.formdiem.IsDisposed)
            {
                this.formdiem = new frmDiem();
                formdiem.MdiParent = this;
                this.formdiem.Show();
            }
            else
            {
                this.formdiem.Select();
            }
        }
    }
}
