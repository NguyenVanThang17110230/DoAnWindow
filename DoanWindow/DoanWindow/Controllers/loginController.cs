using DoanWindow.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoanWindow.Controllers
{
    class loginController
    {
        public DataTable LayUser(string UserName, string Password)
        {
            QuanlidoansinhvienEntities sv= new QuanlidoansinhvienEntities();
            var s = from p in sv.Logins
                    where p.Username == UserName && p.Password == Password
                    select new { p.Username,p.Password,p.PhanQuyen};
            DataTable dt = new DataTable();
            dt.Columns.Add("UserName");
            dt.Columns.Add("PassWord");
            dt.Columns.Add("PhanQuyen");
            foreach (var q in s)
            {
                dt.Rows.Add(q.Username, q.Password,q.PhanQuyen);
            }
            return dt;
        }
    }
}
