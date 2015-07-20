﻿using System;
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
    public class ManagerController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Manager
        public ActionResult ManagerMain()
        {
            return View(db.ManagersModels.ToList());
        }

        // GET: Manager/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManagersModel managersModel = db.ManagersModels.Find(id);
            if (managersModel == null)
            {
                return HttpNotFound();
            }
            return View(managersModel);
        }

        // GET: Manager/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Manager/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "managerName")] ManagersModel managersModel)
        {
            if (ModelState.IsValid)
            {
                db.ManagersModels.Add(managersModel);
                db.SaveChanges();
                return RedirectToAction("ManagerMain");
            }

            return View(managersModel);
        }

        // GET: Manager/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManagersModel managersModel = db.ManagersModels.Find(id);
            if (managersModel == null)
            {
                return HttpNotFound();
            }
            return View(managersModel);
        }

        // POST: Manager/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "managerName")] ManagersModel managersModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(managersModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ManagerMain");
            }
            return View(managersModel);
        }

        // GET: Manager/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ManagersModel managersModel = db.ManagersModels.Find(id);
            if (managersModel == null)
            {
                return HttpNotFound();
            }
            return View(managersModel);
        }

        // POST: Manager/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            ManagersModel managersModel = db.ManagersModels.Find(id);
            db.ManagersModels.Remove(managersModel);
            db.SaveChanges();
            return RedirectToAction("ManagerMain");
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