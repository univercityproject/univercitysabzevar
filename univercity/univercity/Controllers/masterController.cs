using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using univercity.Models;

namespace univercity.Controllers
{
    public class masterController : Controller
    {
        univercityEntities db = new univercityEntities();
        // GET: master
        public ActionResult home()
        {
            return View();
        }
        public ActionResult login()
        {
            TempData["msg"] = "";
            return View();
        }

        public ActionResult _login(string txt_usernam ,string txt_pass)
        {
            //مدیراصلی

            tbl_adminstrator tba = db.tbl_adminstrator.Where(a=> a.name_user==txt_usernam && a.password==txt_pass).SingleOrDefault();
            if (tba==null)
            {
                TempData["msg"] = "نام کاربری یا رمز یافت نشد";
                return View("login");
            }
            else
            {
                return RedirectToAction("home","Admin");

            }
        }

        public ActionResult show_list()
        {
            return View();
        }

        public ActionResult show_project()
        {
            return View();
        }

        public ActionResult show_offer()
        {
            return View();
        }

        public ActionResult contact_us()
        {
            return View();
        }

    }
}