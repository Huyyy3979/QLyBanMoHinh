using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanMoHinh.DAL
{
    public class AccountDAL
    {
        AppDbContext db = new AppDbContext();

        public Account Login(string username, string password)
        {
            return db.Accounts
                     .FirstOrDefault(a => a.Username == username
                                       && a.Password == password);
        }
    }
}