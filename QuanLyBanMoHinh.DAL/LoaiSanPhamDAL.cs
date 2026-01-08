using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.DAL
{
    public class LoaiSanPhamDAL
    {
        private Model1 db = new Model1();

        public List<LoaiSanPham> GetAll()
        {
            return db.LoaiSanPhams.AsNoTracking().ToList();
        }

        public void Add(LoaiSanPham lsp)
        {
            db.LoaiSanPhams.Add(lsp);
            db.SaveChanges();
        }

        public void Update(LoaiSanPham lsp)
        {
            var existing = db.LoaiSanPhams.Find(lsp.MaLoai);
            if (existing != null)
            {
                db.Entry(existing).CurrentValues.SetValues(lsp);
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var existing = db.LoaiSanPhams.Find(id);
            if (existing != null)
            {
                db.LoaiSanPhams.Remove(existing);
                db.SaveChanges();
            }
        }

        public bool HasDependents(int id)
        {
            return db.Gundams.Any(g => g.MaLoai == id);
        }
    }
}
