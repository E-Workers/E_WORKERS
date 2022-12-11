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
    public class Table_CityController : Controller
    {
        private Model1 db = new Model1();

        // GET: Table_City
        public ActionResult Index()
        {
            return View(db.Table_City.ToList());
        }

        // GET: Table_City/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_City table_City = db.Table_City.Find(id);
            if (table_City == null)
            {
                return HttpNotFound();
            }
            return View(table_City);
        }

        // GET: Table_City/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table_City/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "City_ID,City_Name")] Table_City table_City)
        {
            if (ModelState.IsValid)
            {
                db.Table_City.Add(table_City);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table_City);
        }

        // GET: Table_City/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_City table_City = db.Table_City.Find(id);
            if (table_City == null)
            {
                return HttpNotFound();
            }
            return View(table_City);
        }

        // POST: Table_City/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "City_ID,City_Name")] Table_City table_City)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_City).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_City);
        }

        // GET: Table_City/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_City table_City = db.Table_City.Find(id);
            if (table_City == null)
            {
                return HttpNotFound();
            }
            return View(table_City);
        }

        // POST: Table_City/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_City table_City = db.Table_City.Find(id);
            db.Table_City.Remove(table_City);
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
