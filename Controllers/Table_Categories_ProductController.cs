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
    public class Table_Categories_ProductController : Controller
    {
        private Model1 db = new Model1();

        // GET: Table_Categories_Product
        public ActionResult Index()
        {
            return View(db.Table_Categories_Product.ToList());
        }

        // GET: Table_Categories_Product/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Categories_Product table_Categories_Product = db.Table_Categories_Product.Find(id);
            if (table_Categories_Product == null)
            {
                return HttpNotFound();
            }
            return View(table_Categories_Product);
        }

        // GET: Table_Categories_Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table_Categories_Product/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Categories_Product_ID,Categories_Product_Name,Categories_Product_Icon,Categories_Product_Status")] Table_Categories_Product table_Categories_Product)
        {
            if (ModelState.IsValid)
            {
                db.Table_Categories_Product.Add(table_Categories_Product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table_Categories_Product);
        }

        // GET: Table_Categories_Product/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Categories_Product table_Categories_Product = db.Table_Categories_Product.Find(id);
            if (table_Categories_Product == null)
            {
                return HttpNotFound();
            }
            return View(table_Categories_Product);
        }

        // POST: Table_Categories_Product/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Categories_Product_ID,Categories_Product_Name,Categories_Product_Icon,Categories_Product_Status")] Table_Categories_Product table_Categories_Product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_Categories_Product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_Categories_Product);
        }

        // GET: Table_Categories_Product/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Categories_Product table_Categories_Product = db.Table_Categories_Product.Find(id);
            if (table_Categories_Product == null)
            {
                return HttpNotFound();
            }
            return View(table_Categories_Product);
        }

        // POST: Table_Categories_Product/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_Categories_Product table_Categories_Product = db.Table_Categories_Product.Find(id);
            db.Table_Categories_Product.Remove(table_Categories_Product);
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
