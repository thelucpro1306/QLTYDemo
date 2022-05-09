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
            OnlineShopDBContext context = new OnlineShopDBContext();
            Apointment apointment = new Apointment();
            apointment.list = context.Servicesses.ToList();           
            return View(apointment);
        }

        [HttpPost]
        public ActionResult Index(Apointment model)
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
                appointmentModel.ServicesId = model.ServicesId;
                if (model.BookingDate <= DateTime.Now)
                {
                    ModelState.AddModelError("", "please, check your clinic date ( the date must be higher than the present day) ");
                }                
                AppointmentDao dao = new AppointmentDao();
                var rs = dao.Insert(appointmentModel);
                if(rs > 0)
                {
                        ViewBag.Success = "Success!";
                        return Redirect("#page-section");                   
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