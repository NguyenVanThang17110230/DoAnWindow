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
        string Username = "";
        public frmMain()
        {
            InitializeComponent();      
            Width = 1200;
            Height = 600;
        }
        public frmMain(string Username)
        {
            InitializeComponent();
            this.Username = Username;
            
        }

        private void sinhvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Username=="giaovien")
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

    }
}
