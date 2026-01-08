using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.DAL
{
    public class TonKhoDAL
    {
        private Model1 db = new Model1();

        public List<TonKho> GetAll()
        {
            return db.TonKhoes.ToList();
        }

        public void Update(TonKho tk)
        {
            var existing = db.TonKhoes.Find(tk.MaGundam);
            if (existing != null)
            {
                existing.SoLuongTon = tk.SoLuongTon;
                db.SaveChanges();
            }
        }
    }
}
