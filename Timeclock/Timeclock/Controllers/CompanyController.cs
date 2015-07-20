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
    public class CompanyController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Company
        public ActionResult CompanyMain()
        {
            return View(db.CompanyModels.ToList());
        }

        // GET: Company/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyModel companyModel = db.CompanyModels.Find(id);
            if (companyModel == null)
            {
                return HttpNotFound();
            }
            return View(companyModel);
        }

        // GET: Company/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Company/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "companyName,companyNumber,companyDescription")] CompanyModel companyModel)
        {
            if (ModelState.IsValid)
            {
                db.CompanyModels.Add(companyModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(companyModel);
        }

        // GET: Company/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyModel companyModel = db.CompanyModels.Find(id);
            if (companyModel == null)
            {
                return HttpNotFound();
            }
            return View(companyModel);
        }

        // POST: Company/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "companyName,companyNumber,companyDescription")] CompanyModel companyModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(companyModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(companyModel);
        }

        // GET: Company/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CompanyModel companyModel = db.CompanyModels.Find(id);
            if (companyModel == null)
            {
                return HttpNotFound();
            }
            return View(companyModel);
        }

        // POST: Company/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CompanyModel companyModel = db.CompanyModels.Find(id);
            db.CompanyModels.Remove(companyModel);
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
