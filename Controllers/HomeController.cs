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
        public ActionResult AccountLogin()
        {
            ViewBag.City_FID = new SelectList(db.Table_City, "City_ID", "City_Name");         
            return View();
        }

        [HttpPost]
        public ActionResult AccountLogin(Table_Customer customer)
        {

            if (customer.Customer_Name == null || customer.Customer_Address == null || customer.Customer_Phone == null)
            {

                Table_Customer result = db.Table_Customer.Where(x => x.Customer_Email == customer.Customer_Email && x.Customer_Password == customer.Customer_Password).FirstOrDefault();

                if (result != null)
                {
                    currentuser.currentcustomer = result;
                    return RedirectToAction("Products");
                }
                else
                {
                    ViewBag.msg = "  <script>   alert('InValid email and password')    </script> ";
                }
            }
            if (ModelState.IsValid)
            {
                db.Table_Customer.Add(customer);
                db.SaveChanges();
                ViewBag.msg = "  <script>   alert('Your Account Is Created')    </script> ";

            }
            ViewBag.City_FID = new SelectList(db.Table_City, "City_ID", "City_Name", customer.City_FID);
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
        public ActionResult Loginadmin(string email, string password)
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