using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.DAL
{
    public class DonBanDAL
    {
        private Model1 db = new Model1();

        public List<DonBan> GetAll()
        {
            return db.DonBans.ToList();
        }

        public void Add(DonBan don, List<ChiTietDonHang> details)
        {
            using (var transaction = db.Database.BeginTransaction())
            {
                try
                {
                    db.DonBans.Add(don);
                    db.SaveChanges(); // Lấy MaDon tự tăng

                    foreach (var d in details)
                    {
                        d.MaDon = don.MaDon;
                        db.ChiTietDonHangs.Add(d);
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
                    // Xóa chi tiết đơn hàng
                    var details = db.ChiTietDonHangs.Where(d => d.MaDon == id);
                    db.ChiTietDonHangs.RemoveRange(details);

                    // Xóa thanh toán
                    var payments = db.ThanhToans.Where(p => p.MaDon == id);
                    db.ThanhToans.RemoveRange(payments);

                    // Xóa đơn bán
                    var existing = db.DonBans.Find(id);
                    if (existing != null) db.DonBans.Remove(existing);

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
