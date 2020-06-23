using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoanWindow.Models;
using System.Data.Entity.Migrations;
using System.Data;

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
        public DataTable Searchgv(string Ten)
        {
            QuanlidoansinhvienEntities sv = new QuanlidoansinhvienEntities();
            var data = from p in sv.GiaoViens
                       where p.Ten.Contains(Ten)||p.ID.Contains(Ten)
                       select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ten");
            dt.Columns.Add("NgaySinh");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("ChucVu");
            dt.Columns.Add("Khoa");
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("Sdt");
            foreach (var q in data)
            {
                dt.Rows.Add(q.ID, q.Ten, q.NgaySinh, q.GioiTinh, q.ChucVu, q.Khoa, q.DiaChi, q.Sdt);
            }
            return dt;
        }
    }
}
