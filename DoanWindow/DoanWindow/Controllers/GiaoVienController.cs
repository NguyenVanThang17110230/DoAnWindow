using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoanWindow.Models;
using System.Data.Entity.Migrations;

namespace DoanWindow.Controllers
{
    class GiaoVienController
    {
        public static bool addgiangvien(GiaoVien gv)
        {
            using(var _context = new QuanlidoansinhvienEntities())
            {
                _context.GiaoViens.Add(gv);
                _context.SaveChanges();
                return true;
            }    
        }

    }
}
