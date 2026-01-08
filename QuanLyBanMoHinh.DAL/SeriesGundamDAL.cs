using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.DAL
{
    public class SeriesGundamDAL
    {
        private Model1 db = new Model1();

        public List<SeriesGundam> GetAll()
        {
            return db.SeriesGundams.ToList();
        }

        public void Add(SeriesGundam series)
        {
            db.SeriesGundams.Add(series);
            db.SaveChanges();
        }

        public void Update(SeriesGundam series)
        {
            var existing = db.SeriesGundams.Find(series.MaSeries);
            if (existing != null)
            {
                existing.TenSeries = series.TenSeries;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var series = db.SeriesGundams.Find(id);
            if (series != null)
            {
                db.SeriesGundams.Remove(series);
                db.SaveChanges();
            }
        }

        public bool HasDependents(int id)
        {
            return db.Gundams.Any(g => g.MaSeries == id);
        }
    }
}
