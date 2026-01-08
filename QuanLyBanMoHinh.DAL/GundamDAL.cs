using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.DAL
{
    public class GundamDAL
    {
        private Model1 db = new Model1();

        public List<Gundam> GetAllGundams()
        {
            return db.Gundams.AsNoTracking().ToList();
        }

        public void Add(Gundam g)
        {
            db.Gundams.Add(g);
            db.SaveChanges();
        }

        public void Update(Gundam g)
        {
            var existing = db.Gundams.Find(g.MaGundam);
            if (existing != null)
            {
                db.Entry(existing).CurrentValues.SetValues(g);
                db.SaveChanges();
            }
        }

        public void DeleteForce(int id)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    // 1. Xóa trong bảng TonKho
                    var tk = db.TonKhoes.Find(id);
                    if (tk != null) db.TonKhoes.Remove(tk);

                    // 2. Xóa trong các bảng chi tiết
                    var ctdh = db.ChiTietDonHangs.Where(ct => ct.MaGundam == id);
                    db.ChiTietDonHangs.RemoveRange(ctdh);

                    var ctpn = db.ChiTietPhieuNhaps.Where(ct => ct.MaGundam == id);
                    db.ChiTietPhieuNhaps.RemoveRange(ctpn);

                    var ctpx = db.ChiTietPhieuXuats.Where(ct => ct.MaGundam == id);
                    db.ChiTietPhieuXuats.RemoveRange(ctpx);

                    // 3. Xóa Gundam
                    var g = db.Gundams.Find(id);
                    if (g != null) db.Gundams.Remove(g);

                    db.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public bool HasDependents(int id)
        {
            return db.ChiTietDonHangs.Any(ct => ct.MaGundam == id) ||
                   db.ChiTietPhieuNhaps.Any(ct => ct.MaGundam == id) ||
                   db.ChiTietPhieuXuats.Any(ct => ct.MaGundam == id);
        }
    }
}
