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
    public class Table_WorkerController : Controller
    {
        private Model1 db = new Model1();

        // GET: Table_Worker
        public ActionResult Index()
        {
            var table_Worker = db.Table_Worker.Include(t => t.Table_City);
            return View(table_Worker.ToList());
        }

        // GET: Table_Worker/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Worker table_Worker = db.Table_Worker.Find(id);
            if (table_Worker == null)
            {
                return HttpNotFound();
            }
            return View(table_Worker);
        }

        // GET: Table_Worker/Create
        public ActionResult Create()
        {
            ViewBag.City_FID = new SelectList(db.Table_City, "City_ID", "City_Name");
            return View();
        }

        // POST: Table_Worker/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Table_Worker table_Worker, HttpPostedFileBase pic)
        {

            string fullpath = Server.MapPath("~/content/projectpicture/" + pic.FileName);
            pic.SaveAs(fullpath);
            table_Worker.Worker_Image = "~/content/projectpicture/" + pic.FileName;
            if (ModelState.IsValid)
            {
                db.Table_Worker.Add(table_Worker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.City_FID = new SelectList(db.Table_City, "City_ID", "City_Name", table_Worker.City_FID);
            return View(table_Worker);
        }

        // GET: Table_Worker/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Worker table_Worker = db.Table_Worker.Find(id);
            if (table_Worker == null)
            {
                return HttpNotFound();
            }
            ViewBag.City_FID = new SelectList(db.Table_City, "City_ID", "City_Name", table_Worker.City_FID);
            return View(table_Worker);
        }

        // POST: Table_Worker/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Table_Worker table_Worker, HttpPostedFileBase pic)
        {

            string fullpath = Server.MapPath("~/content/projectpicture/" + pic.FileName);
            pic.SaveAs(fullpath);
            table_Worker.Worker_Image = "~/content/projectpicture/" + pic.FileName;
            if (ModelState.IsValid)
            {
                db.Table_Worker.Add(table_Worker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.City_FID = new SelectList(db.Table_City, "City_ID", "City_Name", table_Worker.City_FID);
            return View(table_Worker);
        }
        // GET: Table_Worker/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Worker table_Worker = db.Table_Worker.Find(id);
            if (table_Worker == null)
            {
                return HttpNotFound();
            }
            return View(table_Worker);
        }

        // POST: Table_Worker/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_Worker table_Worker = db.Table_Worker.Find(id);
            db.Table_Worker.Remove(table_Worker);
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
