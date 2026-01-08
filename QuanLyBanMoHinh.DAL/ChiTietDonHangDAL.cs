using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.DAL
{
    public class ChiTietDonHangDAL
    {
        private Model1 db = new Model1();

        public List<ChiTietDonHang> GetAll()
        {
            return db.ChiTietDonHangs.ToList();
        }

        public List<ChiTietDonHang> GetByMaDon(int maDon)
        {
            return db.ChiTietDonHangs.Where(d => d.MaDon == maDon).ToList();
        }
    }
}
