using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_WORKERS.Models;

namespace E_WORKERS.Controllers
{
    public class HomeController : Controller
    {
        Model1 db = new Model1(); 
        public ActionResult Indexcustomer()
        {
            return View();
        }
        public ActionResult Workers(int? id)
        {
              if (id != null)
               {
                ViewData["service_id"] = id;
                //ViewBag.cat_pro_id= id;
               }

            return View();
        }
        public ActionResult Products(int? id)
        {
            if (id != null)
            {
                ViewData["cat_pro_id"] = id;
                //ViewBag.cat_pro_id= id;
            }
            return View();
        }
       
        public ActionResult Indexadmin()
        {
            return View();
        }

        public ActionResult About()
        {
          
            return View();
        }
        public ActionResult Loginadmin()
        {
          
          return View();
        }
          [HttpPost]
         public ActionResult Loginadmin(string email,string password )
        {


            int v = db.Table_Admin.Where(x => x.Admin_Email == email && x.Admin_Password == password).Count();

            if (v > 0)
            {
                return RedirectToAction("Indexadmin");
            }
            else
            {
                ViewBag.loginerror = "Invalid Email and Password";
                return View();
            }
         
        }

        public ActionResult Contact()
        {
         
            return View();
        }
    }
}