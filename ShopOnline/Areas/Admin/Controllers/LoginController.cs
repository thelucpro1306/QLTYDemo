using Model.DAO;
using ShopOnline.Areas.Admin.Data;
using ShopOnline.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShopOnline.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult Login(LoginModel loginModel)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var rs = dao.Login(loginModel.Username, Encryptor.MD5Hash(loginModel.Password));
                if (rs)
                {
                    var user = dao.getByID(loginModel.Username);
                    var userSession = new UserLogin();
                    userSession.UserName = loginModel.Username;
                    userSession.ID = user.ID;
                    Session.Add(ConstantsCommon.USER_SESSION, userSession);
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    ModelState.AddModelError("", "Dang nhap that bai");
                }
            }
            return View("Index");
        }
    }
}