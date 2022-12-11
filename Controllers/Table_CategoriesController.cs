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
    public class Table_CategoriesController : Controller
    {
        private Model1 db = new Model1();

        // GET: Table_Categories
        public ActionResult Index()
        {
            var table_Categories = db.Table_Categories.Include(t => t.Table_Service);
            return View(table_Categories.ToList());
        }

        // GET: Table_Categories/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Categories table_Categories = db.Table_Categories.Find(id);
            if (table_Categories == null)
            {
                return HttpNotFound();
            }
            return View(table_Categories);
        }

        // GET: Table_Categories/Create
        public ActionResult Create()
        {
            ViewBag.Service_FID = new SelectList(db.Table_Service, "Service_ID", "Service_Name");
            return View();
        }

        // POST: Table_Categories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Categories_ID,Categories_Name,Service_FID")] Table_Categories table_Categories)
        {
            if (ModelState.IsValid)
            {
                db.Table_Categories.Add(table_Categories);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Service_FID = new SelectList(db.Table_Service, "Service_ID", "Service_Name", table_Categories.Service_FID);
            return View(table_Categories);
        }

        // GET: Table_Categories/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Categories table_Categories = db.Table_Categories.Find(id);
            if (table_Categories == null)
            {
                return HttpNotFound();
            }
            ViewBag.Service_FID = new SelectList(db.Table_Service, "Service_ID", "Service_Name", table_Categories.Service_FID);
            return View(table_Categories);
        }

        // POST: Table_Categories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Categories_ID,Categories_Name,Service_FID")] Table_Categories table_Categories)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_Categories).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Service_FID = new SelectList(db.Table_Service, "Service_ID", "Service_Name", table_Categories.Service_FID);
            return View(table_Categories);
        }

        // GET: Table_Categories/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Categories table_Categories = db.Table_Categories.Find(id);
            if (table_Categories == null)
            {
                return HttpNotFound();
            }
            return View(table_Categories);
        }

        // POST: Table_Categories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_Categories table_Categories = db.Table_Categories.Find(id);
            db.Table_Categories.Remove(table_Categories);
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
