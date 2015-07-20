using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Timeclock.Models;

namespace Timeclock.Controllers
{
    public class HoursController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Hours
        public ActionResult HoursMain()
        {
            return View(db.HoursModels.ToList());
        }

        // GET: Hours/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoursModel hoursModel = db.HoursModels.Find(id);
            if (hoursModel == null)
            {
                return HttpNotFound();
            }
            return View(hoursModel);
        }

        // GET: Hours/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Hours/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "hours")] HoursModel hoursModel)
        {
            if (ModelState.IsValid)
            {
                db.HoursModels.Add(hoursModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hoursModel);
        }

        // GET: Hours/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoursModel hoursModel = db.HoursModels.Find(id);
            if (hoursModel == null)
            {
                return HttpNotFound();
            }
            return View(hoursModel);
        }

        // POST: Hours/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "hours")] HoursModel hoursModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoursModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hoursModel);
        }

        // GET: Hours/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoursModel hoursModel = db.HoursModels.Find(id);
            if (hoursModel == null)
            {
                return HttpNotFound();
            }
            return View(hoursModel);
        }

        // POST: Hours/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HoursModel hoursModel = db.HoursModels.Find(id);
            db.HoursModels.Remove(hoursModel);
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
