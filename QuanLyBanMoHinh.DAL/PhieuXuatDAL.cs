using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.DAL
{
    public class PhieuXuatDAL
    {
        private Model1 db = new Model1();

        public List<PhieuXuat> GetAll()
        {
            return db.PhieuXuats.ToList();
        }

        public List<ChiTietPhieuXuat> GetDetails(int id)
        {
            return db.ChiTietPhieuXuats.Where(d => d.MaPX == id).ToList();
        }

        public object GetAllDetails()
        {
            return db.ChiTietPhieuXuats
                .Select(d => new
                {
                    MaPX = d.MaPX,
                    MaGundam = d.MaGundam,
                    TenGundam = d.Gundam.TenGundam,
                    SoLuong = d.SoLuong,
                    GiaXuat = d.GiaXuat,
                    NgayXuat = d.PhieuXuat.NgayXuat
                })
                .OrderByDescending(d => d.MaPX)
                .ToList();
        }

        public void Add(PhieuXuat px, List<ChiTietPhieuXuat> details)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.PhieuXuats.Add(px);
                    db.SaveChanges();

                    foreach (var d in details)
                    {
                        d.MaPX = px.MaPX;
                        db.ChiTietPhieuXuats.Add(d);

                        // Cập nhật tồn kho (Giảm đi)
                        var stock = db.TonKhoes.FirstOrDefault(s => s.MaGundam == d.MaGundam);
                        if (stock != null)
                        {
                            stock.SoLuongTon = stock.SoLuongTon.GetValueOrDefault() - d.SoLuong.GetValueOrDefault();
                            if (stock.SoLuongTon < 0) stock.SoLuongTon = 0; // Đảm bảo không âm
                        }
                    }

                    db.SaveChanges();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public void Delete(int id)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    var details = db.ChiTietPhieuXuats.Where(d => d.MaPX == id);
                    db.ChiTietPhieuXuats.RemoveRange(details);

                    var existing = db.PhieuXuats.Find(id);
                    if (existing != null) db.PhieuXuats.Remove(existing);

                    db.SaveChanges();
                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }
}
