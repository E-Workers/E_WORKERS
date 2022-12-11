using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_WORKERS.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Addtocart(int id)
        {
            return View();
        } 
         
         public ActionResult DisplayCart()
        {
            return View();
        }
    }
}