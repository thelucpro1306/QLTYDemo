using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopOnline.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SurgicalServices()
        {
            return View();
        }

        public ActionResult PreventativeServices()
        {
            return View();
        }
    }
}