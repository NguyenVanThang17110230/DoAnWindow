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
    class BaocaoController
    {
        public static bool addbc(BaoCao baocao)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                _context.BaoCaos.Add(baocao);
                _context.SaveChanges();
                return true;
            }
        }
        public static bool updatebc(BaoCao baocao)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                _context.BaoCaos.AddOrUpdate(baocao);
                _context.SaveChanges();
                return true;
            }
        }

        public static BaoCao getbc(string ID)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                var user = (from u in _context.BaoCaos
                            where u.IDBaoCao == ID
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
        public static BaoCao getidbaocao(string ID)
        {
            using (var _context = new QuanlidoansinhvienEntities())
            {
                var baocao = (from u in _context.BaoCaos
                              where u.IDBaoCao == ID
                              select u).ToList();
                if (baocao.Count == 1)
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
            var data = from p in sv.BaoCaos
                       where p.IDDeTai.Contains(Ten) || p.IDBaoCao.Contains(Ten)
                       select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("IDBaoCao");
            dt.Columns.Add("IDDeTai");
            dt.Columns.Add("LanBaoCao");
            dt.Columns.Add("TaiLieu");
            dt.Columns.Add("NhanXet");
            dt.Columns.Add("DiemTong");
            dt.Columns.Add("TrangThai");
            foreach (var q in data)
            {
                dt.Rows.Add(q.IDBaoCao, q.IDDeTai, q.LanBaoCao, q.TaiLieu, q.NhanXet, q.DiemTong, q.TrangThai);
            }
            return dt;
        }
    }
}
