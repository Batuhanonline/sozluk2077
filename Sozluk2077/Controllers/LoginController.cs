using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace sozluk2077.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Admin admin)
        {
            LoginManager loginManager = new LoginManager();
            Admin adminuserInfo = loginManager.AdminLogin(admin);

            if (adminuserInfo != null)
            {
                FormsAuthentication.SetAuthCookie(adminuserInfo.AdminUserName, false);
                Session["AdminUserName"] = adminuserInfo.AdminUserName;
                return RedirectToAction("Index", "AdminCategory");
            } else
            {
                return RedirectToAction("Login");
            }
        }
    }
}