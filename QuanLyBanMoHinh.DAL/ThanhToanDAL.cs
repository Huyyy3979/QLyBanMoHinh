using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.DAL
{
    public class ThanhToanDAL
    {
        private Model1 db = new Model1();

        public List<ThanhToan> GetAll()
        {
            return db.ThanhToans.ToList();
        }

        public void Add(ThanhToan item)
        {
            db.ThanhToans.Add(item);
            db.SaveChanges();
        }

        public void Update(ThanhToan item)
        {
            var existing = db.ThanhToans.Find(item.MaTT);
            if (existing != null)
            {
                existing.PhuongThuc = item.PhuongThuc;
                existing.TrangThai = item.TrangThai;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var existing = db.ThanhToans.Find(id);
            if (existing != null)
            {
                db.ThanhToans.Remove(existing);
                db.SaveChanges();
            }
        }
    }
}
