using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoanWindow.Models;
using System.Data.Entity.Migrations;

namespace DoanWindow.Controllers
{
    class DeTaiController
    {
        public static bool adddetai(DeTai dt)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                _context.DeTais.Add(dt);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool updatedetai(DeTai dt)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                _context.DeTais.AddOrUpdate(dt);
                _context.SaveChanges();
                return true;
            }
        }

        public static DeTai getdt(string ID)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                var detai = (from u in _context.DeTais
                            where u.ID == ID
                            select u).ToList();
                if (detai.Count == 1)
                {
                    return detai[0];
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
