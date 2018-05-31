using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CheckCar.Models;

namespace CheckCar.Controllers
{
    public class TechnologiesController : Controller
    {
        private CheckCarContext db = new CheckCarContext();

        // GET: Technologies
        public ActionResult Index()
        {
            var technologies = db.Technologies.Include(t => t.CarDetail);
            return View(technologies.ToList());
        }

        // GET: Technologies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Technology technology = db.Technologies.Find(id);
            if (technology == null)
            {
                return HttpNotFound();
            }
            return View(technology);
        }

        // GET: Technologies/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.CarDetails, "ID", "CarName");
            return View();
        }

        // POST: Technologies/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,ArkaParkSensoru,GeriGorusKamerasi,HizSabitlemeSistemi,YağmurSensoru,StartStopSistemi,BluetoothBaglantisi,OtomatikKatlananYanAynalar,ElektronikParkFreni,YolBilgisayari,YokusKalkisDestekSistemi,FarSensoru,USBGirisi,NavigasyonSistemi,XenonOnFarlar")] Technology technology)
        {
            if (ModelState.IsValid)
            {
                db.Technologies.Add(technology);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID = new SelectList(db.CarDetails, "ID", "CarName", technology.ID);
            return View(technology);
        }

        // GET: Technologies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Technology technology = db.Technologies.Find(id);
            if (technology == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = new SelectList(db.CarDetails, "ID", "CarName", technology.ID);
            return View(technology);
        }

        // POST: Technologies/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,ArkaParkSensoru,GeriGorusKamerasi,HizSabitlemeSistemi,YağmurSensoru,StartStopSistemi,BluetoothBaglantisi,OtomatikKatlananYanAynalar,ElektronikParkFreni,YolBilgisayari,YokusKalkisDestekSistemi,FarSensoru,USBGirisi,NavigasyonSistemi,XenonOnFarlar")] Technology technology)
        {
            if (ModelState.IsValid)
            {
                db.Entry(technology).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.CarDetails, "ID", "CarName", technology.ID);
            return View(technology);
        }

        // GET: Technologies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Technology technology = db.Technologies.Find(id);
            if (technology == null)
            {
                return HttpNotFound();
            }
            return View(technology);
        }

        // POST: Technologies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Technology technology = db.Technologies.Find(id);
            db.Technologies.Remove(technology);
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
