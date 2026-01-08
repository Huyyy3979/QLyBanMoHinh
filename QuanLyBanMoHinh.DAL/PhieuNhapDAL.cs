using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.DAL
{
    public class PhieuNhapDAL
    {
        private Model1 db = new Model1();

        public List<PhieuNhap> GetAll()
        {
            return db.PhieuNhaps.ToList();
        }

        public List<ChiTietPhieuNhap> GetDetails(int id)
        {
            return db.ChiTietPhieuNhaps.Where(d => d.MaPN == id).ToList();
        }

        public object GetAllDetails()
        {
            return db.ChiTietPhieuNhaps
                .Select(d => new
                {
                    MaPN = d.MaPN,
                    MaGundam = d.MaGundam,
                    TenGundam = d.Gundam.TenGundam,
                    SoLuong = d.SoLuong,
                    GiaNhap = d.GiaNhap,
                    NgayNhap = d.PhieuNhap.NgayNhap
                })
                .OrderByDescending(d => d.MaPN)
                .ToList();
        }

        public void Add(PhieuNhap pn, List<ChiTietPhieuNhap> details)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.PhieuNhaps.Add(pn);
                    db.SaveChanges();

                    foreach (var d in details)
                    {
                        d.MaPN = pn.MaPN;
                        db.ChiTietPhieuNhaps.Add(d);

                        // Cập nhật tồn kho
                        var stock = db.TonKhoes.FirstOrDefault(s => s.MaGundam == d.MaGundam);
                        if (stock != null)
                        {
                            stock.SoLuongTon = stock.SoLuongTon.GetValueOrDefault() + d.SoLuong.GetValueOrDefault();
                        }
                        else
                        {
                            db.TonKhoes.Add(new TonKho
                            {
                                MaGundam = d.MaGundam,
                                SoLuongTon = d.SoLuong
                            });
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
                    var details = db.ChiTietPhieuNhaps.Where(d => d.MaPN == id);
                    db.ChiTietPhieuNhaps.RemoveRange(details);

                    var existing = db.PhieuNhaps.Find(id);
                    if (existing != null) db.PhieuNhaps.Remove(existing);

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
