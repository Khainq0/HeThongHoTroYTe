using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HeThongHoTroYTe.Models;

namespace HeThongHoTroYTe.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var x = Session["username"];
            if (x == null)
            {
                return View("Login");
            }
            else
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginAction(User us)
        {
            if ("admin".Equals(us.username) && "123456".Equals(us.pwd))
            {
                Session["username"] = us.username;
                return RedirectToAction("Index", "User");


            }
            else
            {

                return RedirectToAction("Login", "User");
            }
        }
        
            }
}