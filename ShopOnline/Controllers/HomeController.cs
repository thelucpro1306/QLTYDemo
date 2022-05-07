using Model.DAO;
using Model.EF;
using ShopOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopOnline.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(AppointmentModel model)
        {
            if (ModelState.IsValid)
            {
                Apointment appointmentModel = new Apointment();
                appointmentModel.Name = model.Name;
                appointmentModel.Email = model.Email;
                appointmentModel.Phone = model.Phone;
                appointmentModel.Note = model.Note;
                appointmentModel.status = -1;
                appointmentModel.BookingDate = model.BookingDate;
                appointmentModel.DateCreate = DateTime.Now;
                AppointmentDao dao = new AppointmentDao();
                var rs = dao.Insert(appointmentModel);
                if(rs > 0)
                {
                    if(model.BookingDate <= DateTime.Now)
                    {
                        ModelState.AddModelError("", "please, check your clinic date ( the date must be higher than the present day) ");
                    }
                    else
                    {
                        model = new AppointmentModel();
                        ViewBag.Success = "Success!";
                        return RedirectToAction("Index", "Thanks");
                    }
                }
                else
                {
                    ModelState.AddModelError("","Error");
                }
            }
            return View(model);
        }

        [ChildActionOnly]
        public ActionResult MainMenu()
        {
            var model = new MenuDao().ListByGroupID(1);
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Footer()
        {
            return PartialView();
        }

    }
}