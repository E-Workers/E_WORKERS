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
    public class Table_AdminController : Controller
    {
        private Model1 db = new Model1();

        // GET: Table_Admin
        public ActionResult Index()
        {
            return View(db.Table_Admin.ToList());
        }

        // GET: Table_Admin/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Admin table_Admin = db.Table_Admin.Find(id);
            if (table_Admin == null)
            {
                return HttpNotFound();
            }
            return View(table_Admin);
        }

        // GET: Table_Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Table_Admin/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Admin_ID,Admin_Name,Admin_Password,Admin_Address,Admin_Phone,Admin_Email")] Table_Admin table_Admin)
        {
            if (ModelState.IsValid)
            {
                db.Table_Admin.Add(table_Admin);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table_Admin);
        }

        // GET: Table_Admin/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Admin table_Admin = db.Table_Admin.Find(id);
            if (table_Admin == null)
            {
                return HttpNotFound();
            }
            return View(table_Admin);
        }

        // POST: Table_Admin/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Admin_ID,Admin_Name,Admin_Password,Admin_Address,Admin_Phone,Admin_Email")] Table_Admin table_Admin)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_Admin).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_Admin);
        }

        // GET: Table_Admin/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_Admin table_Admin = db.Table_Admin.Find(id);
            if (table_Admin == null)
            {
                return HttpNotFound();
            }
            return View(table_Admin);
        }

        // POST: Table_Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table_Admin table_Admin = db.Table_Admin.Find(id);
            db.Table_Admin.Remove(table_Admin);
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
