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
    public class Table_ServiceController : Controller
    {
        private Model1 db = new Model1();

        // GET: Table_Service
        public ActionResult Index()
        {
            return View(db.Table_Service.ToList());
        }

        // GET: Table_Service/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Service table_Service = db.Table_Service.Find(id);
            if (table_Service == null)
            {
                return HttpNotFound();
            }
            return View(table_Service);
        }

        // GET: Table_Service/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table_Service/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Service_ID,Service_Name,Service_Charges")] Table_Service table_Service)
        {
            if (ModelState.IsValid)
            {
                db.Table_Service.Add(table_Service);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table_Service);
        }

        // GET: Table_Service/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Service table_Service = db.Table_Service.Find(id);
            if (table_Service == null)
            {
                return HttpNotFound();
            }
            return View(table_Service);
        }

        // POST: Table_Service/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Service_ID,Service_Name,Service_Charges")] Table_Service table_Service)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_Service).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_Service);
        }

        // GET: Table_Service/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Service table_Service = db.Table_Service.Find(id);
            if (table_Service == null)
            {
                return HttpNotFound();
            }
            return View(table_Service);
        }

        // POST: Table_Service/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_Service table_Service = db.Table_Service.Find(id);
            db.Table_Service.Remove(table_Service);
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
