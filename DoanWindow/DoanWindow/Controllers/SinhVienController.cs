using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoanWindow.Models;
using System.Data.Entity.Migrations;
using System.Windows.Forms;
using System.Data;

namespace DoanWindow.Controllers
{
    class SinhVienController
    {
        public static bool addsinhvien(SinhVien sinhvien)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                _context.SinhViens.Add(sinhvien);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool updatesinhvien(SinhVien sinhVien)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                _context.SinhViens.AddOrUpdate(sinhVien);
                _context.SaveChanges();
                return true;
            }
        }

        public static SinhVien getsv(string ID)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                var user = (from u in _context.SinhViens
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
        public static SinhVien getidbaocao(string ID)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                var baocao = (from u in _context.SinhViens
                              where u.DeTai == ID
                              select u).ToList();
                if(baocao.Count == 1)
                {
                    return baocao[0];
                }
                else
                {
                    return null;
                }    
            }    
        }
        public DataTable Searchsv(string Ten)
        {
            QuanlidoansinhvienEntities sv = new QuanlidoansinhvienEntities();
            var data = from p in sv.SinhViens
                       where p.Ten.Contains(Ten) || p.ID.Contains(Ten)
                       select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Ten");
            dt.Columns.Add("GioiTinh");
            dt.Columns.Add("NgaySinh");
            dt.Columns.Add("Lop");
            dt.Columns.Add("Khoa");
            dt.Columns.Add("DiaChi");
            dt.Columns.Add("Sdt");
            dt.Columns.Add("DeTai");
            foreach (var q in data)
            {
                dt.Rows.Add(q.ID, q.Ten, q.GioiTinh, q.NgaySinh, q.Lop, q.khoa, q.DiaChi, q.Sdt, q.DeTai);
            }
            return dt;
        }
    }
}
