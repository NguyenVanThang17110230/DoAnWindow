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
        public static bool updategiangvien(GiaoVien gv)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                _context.GiaoViens.AddOrUpdate(gv);
                _context.SaveChanges();
                return true;
            }
        }

        public static GiaoVien getgv(string ID)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                var user = (from u in _context.GiaoViens
                            where u.ID == ID
                            select u).ToList();
                if (user.Count == 1)
                {
                    return user[0];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
