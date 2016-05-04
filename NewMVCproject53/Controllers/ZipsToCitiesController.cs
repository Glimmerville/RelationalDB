using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NewMVCproject53.Models;

namespace NewMVCproject53.Controllers
{
    public class ZipsToCitiesController : Controller
    {
        private NewMVCproject53Context db = new NewMVCproject53Context();

        // GET: ZipsToCities
        public ActionResult Index()
        {
            var zipsToCities = db.ZipsToCities.Include(z => z.Citycode).Include(z => z.Zippitycode);
            return View(zipsToCities.ToList());
        }

        // GET: ZipsToCities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ZipsToCity zipsToCity = db.ZipsToCities.Find(id);
            if (zipsToCity == null)
            {
                return HttpNotFound();
            }
            return View(zipsToCity);
        }

        // GET: ZipsToCities/Create
        public ActionResult Create()
        {
            ViewBag.CityId = new SelectList(db.Cities, "CityId", "CityName");
            ViewBag.ZipCodeId = new SelectList(db.Zipcodes, "ZipCodeId", "ZipCodeValue");
            return View();
        }

        // POST: ZipsToCities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ZipsToCityId,ZipCodeId,CityId")] ZipsToCity zipsToCity)
        {
            if (ModelState.IsValid)
            {
                db.ZipsToCities.Add(zipsToCity);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CityId = new SelectList(db.Cities, "CityId", "CityName", zipsToCity.CityId);
            ViewBag.ZipCodeId = new SelectList(db.Zipcodes, "ZipCodeId", "ZipCodeValue", zipsToCity.ZipCodeId);
            return View(zipsToCity);
        }

        // GET: ZipsToCities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ZipsToCity zipsToCity = db.ZipsToCities.Find(id);
            if (zipsToCity == null)
            {
                return HttpNotFound();
            }
            ViewBag.CityId = new SelectList(db.Cities, "CityId", "CityName", zipsToCity.CityId);
            ViewBag.ZipCodeId = new SelectList(db.Zipcodes, "ZipCodeId", "ZipCodeValue", zipsToCity.ZipCodeId);
            return View(zipsToCity);
        }

        // POST: ZipsToCities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ZipsToCityId,ZipCodeId,CityId")] ZipsToCity zipsToCity)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zipsToCity).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CityId = new SelectList(db.Cities, "CityId", "CityName", zipsToCity.CityId);
            ViewBag.ZipCodeId = new SelectList(db.Zipcodes, "ZipCodeId", "ZipCodeValue", zipsToCity.ZipCodeId);
            return View(zipsToCity);
        }

        // GET: ZipsToCities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ZipsToCity zipsToCity = db.ZipsToCities.Find(id);
            if (zipsToCity == null)
            {
                return HttpNotFound();
            }
            return View(zipsToCity);
        }

        // POST: ZipsToCities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ZipsToCity zipsToCity = db.ZipsToCities.Find(id);
            db.ZipsToCities.Remove(zipsToCity);
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
