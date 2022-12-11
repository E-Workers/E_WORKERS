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
    public class Table_Worker_Linked_ServicesController : Controller
    {
        private Model1 db = new Model1();

        // GET: Table_Worker_Linked_Services
        public ActionResult Index()
        {
            var table_Worker_Linked_Services = db.Table_Worker_Linked_Services.Include(t => t.Table_Service).Include(t => t.Table_Worker);
            return View(table_Worker_Linked_Services.ToList());
        }

        // GET: Table_Worker_Linked_Services/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Worker_Linked_Services table_Worker_Linked_Services = db.Table_Worker_Linked_Services.Find(id);
            if (table_Worker_Linked_Services == null)
            {
                return HttpNotFound();
            }
            return View(table_Worker_Linked_Services);
        }

        // GET: Table_Worker_Linked_Services/Create
        public ActionResult Create()
        {
            ViewBag.Service_FID = new SelectList(db.Table_Service, "Services_ID", "Services_Name");
            ViewBag.Worker_FID = new SelectList(db.Table_Worker, "Worker_ID", "Worker_Name");
            return View();
        }

        // POST: Table_Worker_Linked_Services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Worker_Linked_ServiceID,Worker_FID,Service_FID")] Table_Worker_Linked_Services table_Worker_Linked_Services)
        {
            if (ModelState.IsValid)
            {
                db.Table_Worker_Linked_Services.Add(table_Worker_Linked_Services);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Service_FID = new SelectList(db.Table_Service, "Services_ID", "Services_Name", table_Worker_Linked_Services.Service_FID);
            ViewBag.Worker_FID = new SelectList(db.Table_Worker, "Worker_ID", "Worker_Name", table_Worker_Linked_Services.Worker_FID);
            return View(table_Worker_Linked_Services);
        }

        // GET: Table_Worker_Linked_Services/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Worker_Linked_Services table_Worker_Linked_Services = db.Table_Worker_Linked_Services.Find(id);
            if (table_Worker_Linked_Services == null)
            {
                return HttpNotFound();
            }
            ViewBag.Service_FID = new SelectList(db.Table_Service, "Services_ID", "Services_Name", table_Worker_Linked_Services.Service_FID);
            ViewBag.Worker_FID = new SelectList(db.Table_Worker, "Worker_ID", "Worker_Name", table_Worker_Linked_Services.Worker_FID);
            return View(table_Worker_Linked_Services);
        }

        // POST: Table_Worker_Linked_Services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Worker_Linked_ServiceID,Worker_FID,Service_FID")] Table_Worker_Linked_Services table_Worker_Linked_Services)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_Worker_Linked_Services).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Service_FID = new SelectList(db.Table_Service, "Services_ID", "Services_Name", table_Worker_Linked_Services.Service_FID);
            ViewBag.Worker_FID = new SelectList(db.Table_Worker, "Worker_ID", "Worker_Name", table_Worker_Linked_Services.Worker_FID);
            return View(table_Worker_Linked_Services);
        }

        // GET: Table_Worker_Linked_Services/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Worker_Linked_Services table_Worker_Linked_Services = db.Table_Worker_Linked_Services.Find(id);
            if (table_Worker_Linked_Services == null)
            {
                return HttpNotFound();
            }
            return View(table_Worker_Linked_Services);
        }

        // POST: Table_Worker_Linked_Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_Worker_Linked_Services table_Worker_Linked_Services = db.Table_Worker_Linked_Services.Find(id);
            db.Table_Worker_Linked_Services.Remove(table_Worker_Linked_Services);
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
