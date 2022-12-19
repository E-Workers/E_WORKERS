using E_WORKERS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace E_WORKERS.Controllers
{
    public class CartController : Controller
    {
        Model1 db = new Model1();
        // GET: Cart
        public ActionResult Addtocart(int id)
        {
            List<Table_Products> CartList = new List<Table_Products>();
            if (Session["cart"] != null)
            {
                CartList = (List<Table_Products>)Session["cart"]; 
            }

            Table_Products existingproduct = CartList.Where(x => x.Products_ID == id).FirstOrDefault();
            if (existingproduct !=null)
            {
                existingproduct.Quantity++;
            }
            else
            {

           
            
            Table_Products table_Products = db.Table_Products.Where(x => x.Products_ID == id).FirstOrDefault();
            table_Products.Quantity = 1;
            CartList.Add(table_Products);
            }
            Session["cart"] = CartList;

            return RedirectToAction("DisplayCart");
        } 
         
         public ActionResult DisplayCart()
        {
            return View();
        } 
        public ActionResult Checkout()
        {
            return View();
        } 
        public ActionResult RemoveFromCart(int id)
        {
            List<Table_Products>  list = new List<Table_Products>();
           list=(List<Table_Products>)Session["cart"];
            list.RemoveAt(id);
            Session["cart"] = list;
            return RedirectToAction("DisplayCart");
        }
        public ActionResult PlusToCart(int id)
        {
            List<Table_Products>  list = new List<Table_Products>();
            list=(List<Table_Products>)Session["cart"];
          
            list[id].Quantity++;
            Session["cart"] = list;
            return RedirectToAction("DisplayCart");
        }
        public ActionResult MinusFromCart(int id)
        {
            List<Table_Products>  list = new List<Table_Products>();
           list=(List<Table_Products>)Session["cart"];
            list[id].Quantity--;
            if (list[id].Quantity < 1)
            {
                list.RemoveAt(id);
            }
            Session["cart"] = list;
            return RedirectToAction("DisplayCart");
        }
    }
}