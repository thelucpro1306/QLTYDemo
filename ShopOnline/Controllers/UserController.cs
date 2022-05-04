using BotDetect.Web.Mvc;
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
    public class UserController : Controller
    {
        // GET: User
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [CaptchaValidationActionFilter("CaptchaCode", "registerCaptcha", "Wrong Captcha!")]
        public ActionResult Register(RegisterModel model)
        {
            if (ModelState.IsValid) {
                var dao = new UserDao();
                if (dao.CheckUserName(model.Username)){
                    ModelState.AddModelError("", "Username da ton tai");
                }
                else if (dao.CheckEmail(model.Email))
                {
                    ModelState.AddModelError("", "Email da ton tai");
                }
                else
                {
                    var user = new User();
                    user.UserName = model.Username; 
                    user.Name = model.name;
                    user.Password = Encryptor.MD5Hash(model.Password);
                    user.Email = model.Email;
                    user.CreateTime = DateTime.Now;
                    user.Status = true;                    
                    var result = dao.Insert(user);
                    if(result > 0)
                    {
                        ViewBag.Success = "Dang ky thanh cong";
                        model = new RegisterModel();
                        return RedirectToAction("Index","Home");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Dang ky khong thanh cong");
                    }
                }
            }
            return View(model);
        }
        }
    }
