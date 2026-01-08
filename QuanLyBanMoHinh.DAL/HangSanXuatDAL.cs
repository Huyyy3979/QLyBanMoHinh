using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.DAL
{
    public class HangSanXuatDAL
    {
        private Model1 db = new Model1();

        public List<HangSanXuat> GetAll()
        {
            return db.HangSanXuats.ToList();
        }

        public void Add(HangSanXuat hang)
        {
            db.HangSanXuats.Add(hang);
            db.SaveChanges();
        }

        public void Update(HangSanXuat hang)
        {
            var existing = db.HangSanXuats.Find(hang.MaHang);
            if (existing != null)
            {
                existing.TenHang = hang.TenHang;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var hang = db.HangSanXuats.Find(id);
            if (hang != null)
            {
                db.HangSanXuats.Remove(hang);
                db.SaveChanges();
            }
        }

        public bool HasDependents(int id)
        {
            return db.Gundams.Any(g => g.MaHang == id);
        }
    }
}
