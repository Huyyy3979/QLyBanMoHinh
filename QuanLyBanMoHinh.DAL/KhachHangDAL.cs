using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.DAL
{
    public class KhachHangDAL
    {
        private Model1 db = new Model1();

        public List<KhachHang> GetAll()
        {
            return db.KhachHangs.ToList();
        }
        
        public List<KhachHang> GetVIPs()
        {
             return db.KhachHangs.Where(k => k.LaVIP == true).ToList();
        }

        public void Add(KhachHang kh)
        {
            db.KhachHangs.Add(kh);
            db.SaveChanges();
        }

        public void Update(KhachHang kh)
        {
            var existing = db.KhachHangs.Find(kh.MaKH);
            if (existing != null)
            {
                existing.TenKH = kh.TenKH;
                existing.DienThoai = kh.DienThoai;
                existing.Email = kh.Email;
                existing.MatKhau = kh.MatKhau;
                existing.DiaChi = kh.DiaChi;
                existing.NgayCapNhat = kh.NgayCapNhat;
                existing.LaVIP = kh.LaVIP;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var kh = db.KhachHangs.Find(id);
            if (kh != null)
            {
                db.KhachHangs.Remove(kh);
                db.SaveChanges();
            }
        }

        public bool HasDependents(int id)
        {
            return db.DonBans.Any(d => d.MaKH == id);
        }

        public List<KhachHang> SearchByPhone(string phone)
        {
            return db.KhachHangs
                .Where(k => k.DienThoai.Contains(phone))
                .ToList();
        }
    }
}
