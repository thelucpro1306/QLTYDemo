using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopOnline.Areas.Admin.Controllers
{
    public class AppointmentConfirmController : BaseController
    {
        OnlineShopDBContext db = new OnlineShopDBContext();
        // GET: Admin/AppointmentConfirm
        public ActionResult Index()
        {
            var list = db.Apointment.ToList();
            return View(list);
        }

       

    }
}