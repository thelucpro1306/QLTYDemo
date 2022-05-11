using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DAO
{
    public class AppointmentDao
    {
        OnlineShopDBContext db = null;
        public AppointmentDao()
        {
            db = new OnlineShopDBContext();
        }


        public long Insert(Apointment apointment)
        {
            db.Apointment.Add(apointment);
            db.SaveChanges();            
            return apointment.Id;
        }

    }
}
