using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using E_WORKERS.Models;

namespace E_WORKERS.Controllers
{
    public class Table_ProductsController : Controller
    {
        private Model1 db = new Model1();

        // GET: Table_Products
        public ActionResult Index()
        {
            var table_Products = db.Table_Products.Include(t => t.Table_Categories_Product);
            return View(table_Products.ToList());
        }

        // GET: Table_Products/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Products table_Products = db.Table_Products.Find(id);
            if (table_Products == null)
            {
                return HttpNotFound();
            }
            return View(table_Products);
        }

        // GET: Table_Products/Create
        public ActionResult Create()
        {
            ViewBag.Category_Product_FID = new SelectList(db.Table_Categories_Product, "Categories_Product_ID", "Categories_Product_Name");
            return View();
        }

        // POST: Table_Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Table_Products table_Products, HttpPostedFileBase pic)
        {

            string fullpath = Server.MapPath("~/content/projectpicture/" + pic.FileName);
            pic.SaveAs(fullpath);
            table_Products.Products_Image = "~/content/projectpicture/" + pic.FileName;
            if (ModelState.IsValid)
            {
                db.Table_Products.Add(table_Products);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Category_Product_FID = new SelectList(db.Table_Categories_Product, "Categories_Product_ID", "Categories_Product_Name", table_Products.Category_Product_FID);
            return View(table_Products);
        }

        // GET: Table_Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Products table_Products = db.Table_Products.Find(id);
            if (table_Products == null)
            {
                return HttpNotFound();
            }
            ViewBag.Category_Product_FID = new SelectList(db.Table_Categories_Product, "Categories_Product_ID", "Categories_Product_Name", table_Products.Category_Product_FID);
            return View(table_Products);
        }

        // POST: Table_Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Table_Products table_Products, HttpPostedFileBase pic)
        {
            if (pic != null) { 
            string fullpath = Server.MapPath("~/content/projectpicture/" + pic.FileName);
            pic.SaveAs(fullpath);
            table_Products.Products_Image = "~/content/projectpicture/" + pic.FileName;
            }
            if (ModelState.IsValid)
            {
                db.Entry(table_Products).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Category_Product_FID = new SelectList(db.Table_Categories_Product, "Categories_Product_ID", "Categories_Product_Name", table_Products.Category_Product_FID);
            return View(table_Products);
        }

        // GET: Table_Products/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Products table_Products = db.Table_Products.Find(id);
            if (table_Products == null)
            {
                return HttpNotFound();
            }
            return View(table_Products);
        }

        // POST: Table_Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_Products table_Products = db.Table_Products.Find(id);
            db.Table_Products.Remove(table_Products);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
