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
        public DataTable Searchsv(string Ten)
        {
            QuanlidoansinhvienEntities sv = new QuanlidoansinhvienEntities();
            var data = from p in sv.DeTais
                       where p.TenDeTai.Contains(Ten) || p.ID.Contains(Ten)
                       select p;
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("TenDeTai");
            dt.Columns.Add("LoaiDeTai");
            dt.Columns.Add("GiaoVienHuongDan");
            dt.Columns.Add("MoTa");
            dt.Columns.Add("SoLuongSinhVien");
            dt.Columns.Add("ThoiGianBatDau");
            dt.Columns.Add("ThoiGianKetThuc");
            dt.Columns.Add("SoLanBaoCao");
            dt.Columns.Add("TinhTrang");
            foreach (var q in data)
            {
                dt.Rows.Add(q.ID, q.TenDeTai, q.LoaiDeTai, q.GiaoVienHuongDan, q.MoTa, q.SoLuongSinhVien, q.ThoiGianBatDau, q.ThoiGianKetThuc, q.SoLanBaoCao, q.TinhTrang);
            }
            return dt;
        }
    }
}
