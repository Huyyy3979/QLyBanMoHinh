using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyBanMoHinh.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=QuanLyBanMoHinhDB")
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}