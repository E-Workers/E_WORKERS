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
        public ActionResult Orderbook(Table_Order order)
        {
            order.Order_Status = "Booked";
            order.Order_Type = "Sale";
            order.Customer_FID = currentuser.currentcustomer.Customer_ID;
            order.Order_Date = System.DateTime.Now;
            db.Table_Order.Add(order);
            db.SaveChanges();
            Table_OrderDetails od = new Table_OrderDetails();
            foreach (var item in  (List<Table_Products>)Session["cart"])
            {
                od.Products_FID = item.Products_ID;
                od.Product_Quantity =item.Quantity;
                od.Products_Saleprice = item.Products_SalePrice;
                od.Products_Purchaseprice = item.Products_PurchasePrice;
                od.Order_FID = order.Order_ID;
                 db.Table_OrderDetails.Add(od);
                db.SaveChanges();
            } 



            return View();
        } 
        public ActionResult Checkout()
        {
            if (currentuser.currentcustomer == null)
            {
                return RedirectToAction("CustomerLogin", "Home");
            }

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