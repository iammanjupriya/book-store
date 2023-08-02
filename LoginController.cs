using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication12.Models;

namespace WebApplication12.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Register objUser)
        {
            if (ModelState.IsValid)
            {
                using (taskEntities5 db = new taskEntities5())
                {
                    var obj = db.Registers.Where(a => a.username.Equals(objUser.username) && a.pasword.Equals(objUser.pasword)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["UserID"] = obj.fname.ToString();
                        Session["UserName"] = obj.username.ToString();
                        return RedirectToAction("UserDashBoard");
                    }
                }
            }
            return View(objUser);
        }

        public ActionResult UserDashBoard()
        {
            if (Session["UserID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
    }
}  
