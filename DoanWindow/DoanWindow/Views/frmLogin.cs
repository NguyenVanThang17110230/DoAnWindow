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
    public partial class frmLogin : Form
    {
        QuanlidoansinhvienEntities sv = new QuanlidoansinhvienEntities();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                loginController lg = new loginController();
                DataTable dt = lg.LayUser(this.txtUser.Text, this.txtPass.Text);
                if(dt.Rows.Count>0)
                {
                    MessageBox.Show("bạn đã đăng nhập thành công!!!","Thông báo");
                    this.Hide();
                    Form main = new frmMain(dt.Rows[0][0].ToString());
                    main.ShowDialog();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Đăng nhập không thành công!", "Thông báo");
                    txtUser.Clear();
                    txtPass.Clear();                   
                }    
            }
            catch { }
        }
    }
}
