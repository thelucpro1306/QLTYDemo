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
        OnlineShopDBContext db = new OnlineShopDBContext();
        public AppointmentDao()
        {
            
        }

        public long Insert(Apointment apointment)
        {
            db.Apointments.Add(apointment);
            db.SaveChanges();            
            return apointment.Id;
        }

    }
}
