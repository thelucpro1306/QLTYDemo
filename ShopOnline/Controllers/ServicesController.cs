﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopOnline.Controllers
{
    public class ServicesController : Controller
    {
        // GET: Admin/Services
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SurgicalServices()
        {
            return View();
        }
    }
}