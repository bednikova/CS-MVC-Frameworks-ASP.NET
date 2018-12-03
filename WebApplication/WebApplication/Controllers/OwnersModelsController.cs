using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication.Data;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class OwnersModelsController : Controller
    {
        private StoreContext db = new StoreContext();

        // GET: OwnersModels
        public ActionResult Index()
        {
            var ownersModels = db.OwnersModels.Include(o => o.Model).Include(o => o.Owners);
            return View(ownersModels.ToList());
        }

        // GET: OwnersModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnersModels ownersModels = db.OwnersModels.Find(id);
            if (ownersModels == null)
            {
                return HttpNotFound();
            }
            return View(ownersModels);
        }

        // GET: OwnersModels/Create
        public ActionResult Create()
        {
            ViewBag.ModelId = new SelectList(db.Model, "ModelId", "Name");
            ViewBag.OwnersId = new SelectList(db.Owners, "OwnersId", "Name");
            return View();
        }

        // POST: OwnersModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OwnersModelsId,Description,OwnersId,ModelId")] OwnersModels ownersModels)
        {
            if (ModelState.IsValid)
            {
                db.OwnersModels.Add(ownersModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ModelId = new SelectList(db.Model, "ModelId", "Name", ownersModels.ModelId);
            ViewBag.OwnersId = new SelectList(db.Owners, "OwnersId", "Name", ownersModels.OwnersId);
            return View(ownersModels);
        }

        // GET: OwnersModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnersModels ownersModels = db.OwnersModels.Find(id);
            if (ownersModels == null)
            {
                return HttpNotFound();
            }
            ViewBag.ModelId = new SelectList(db.Model, "ModelId", "Name", ownersModels.ModelId);
            ViewBag.OwnersId = new SelectList(db.Owners, "OwnersId", "Name", ownersModels.OwnersId);
            return View(ownersModels);
        }

        // POST: OwnersModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OwnersModelsId,Description,OwnersId,ModelId")] OwnersModels ownersModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ownersModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ModelId = new SelectList(db.Model, "ModelId", "Name", ownersModels.ModelId);
            ViewBag.OwnersId = new SelectList(db.Owners, "OwnersId", "Name", ownersModels.OwnersId);
            return View(ownersModels);
        }

        // GET: OwnersModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            OwnersModels ownersModels = db.OwnersModels.Find(id);
            if (ownersModels == null)
            {
                return HttpNotFound();
            }
            return View(ownersModels);
        }

        // POST: OwnersModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            OwnersModels ownersModels = db.OwnersModels.Find(id);
            db.OwnersModels.Remove(ownersModels);
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
