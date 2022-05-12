using Model.DAO;
using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopOnline.Areas.Admin.Controllers
{
    public class ClientController : Controller
    {
        OnlineShopDBContext db = new OnlineShopDBContext();
        // GET: Admin/Client
        public ActionResult Index(string searchString, int page = 1, int pageSize = 10)
        {
            ClientDao dao = new ClientDao();
            var list = dao.ListAllPaging(searchString, page, pageSize);
            ViewBag.SearchString = searchString;
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Client model)
        {
            
                if (ModelState.IsValid)
                {
                    Client cl = new Client();
                    cl.Name = model.Name;
                    cl.email = model.email;
                    cl.Phone = model.Phone;
                    cl.DoB = model.DoB;
                    cl.Address = model.Address;
                    if (model.gender == true)
                    {
                        cl.gender = model.gender;
                    }
                    else
                    {
                        cl.gender = false;
                    }
                    ClientDao dao = new ClientDao();
                    var rs = dao.Insert(cl);
                    if (rs > 0)
                    {
                        ViewBag.Success = "Success!";
                        return Redirect("/Admin/Client");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Error");
                    }
                }
                return View(model);
            }

        }
    }
