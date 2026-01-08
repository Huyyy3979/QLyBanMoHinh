using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanMoHinh.DAL.enities;

namespace QuanLyBanMoHinh.DAL
{
    public class GradeScaleDAL
    {
        private Model1 db = new Model1();

        public List<GradeScale> GetAll()
        {
            return db.GradeScales.ToList();
        }
    }
}
