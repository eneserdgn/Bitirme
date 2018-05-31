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
    public class CarDetailsController : Controller
    {
        private CheckCarContext db = new CheckCarContext();

        // GET: CarDetails
        public ActionResult Index()
        {
            var carDetails = db.CarDetails.Include(c => c.Release).Include(c => c.Security).Include(c => c.TechnicalSpecification).Include(c => c.Technology);
            return View(carDetails.ToList());
        }

        // GET: CarDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarDetail carDetail = db.CarDetails.Find(id);
            if (carDetail == null)
            {
                return HttpNotFound();
            }
            return View(carDetail);
        }

        // GET: CarDetails/Create
        public ActionResult Create()
        {
            ViewBag.ID = new SelectList(db.Releases, "ID", "ReleaseYear");
            ViewBag.ID = new SelectList(db.Securities, "ID", "ID");
            ViewBag.ID = new SelectList(db.TechnicalSpecifications, "ID", "SilindirHacmi");
            ViewBag.ID = new SelectList(db.Technologies, "ID", "ArkaParkSensoru");
            return View();
        }

        // POST: CarDetails/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,CarName,CarDetailImage,YakitTuketimi,MalzemeKalitesi,Yoltutusu,HızlanmaPerformansı,SesYalıtımı,VitesGecisleri,IcMekanGenisligi,DonanimTeknolojisi,İkinciElPiyasa")] CarDetail carDetail)
        {
            if (ModelState.IsValid)
            {
                db.CarDetails.Add(carDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ID = new SelectList(db.Releases, "ID", "ReleaseYear", carDetail.ID);
            ViewBag.ID = new SelectList(db.Securities, "ID", "ID", carDetail.ID);
            ViewBag.ID = new SelectList(db.TechnicalSpecifications, "ID", "SilindirHacmi", carDetail.ID);
            ViewBag.ID = new SelectList(db.Technologies, "ID", "ArkaParkSensoru", carDetail.ID);
            return View(carDetail);
        }

        // GET: CarDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarDetail carDetail = db.CarDetails.Find(id);
            if (carDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID = new SelectList(db.Releases, "ID", "ReleaseYear", carDetail.ID);
            ViewBag.ID = new SelectList(db.Securities, "ID", "ID", carDetail.ID);
            ViewBag.ID = new SelectList(db.TechnicalSpecifications, "ID", "SilindirHacmi", carDetail.ID);
            ViewBag.ID = new SelectList(db.Technologies, "ID", "ArkaParkSensoru", carDetail.ID);
            return View(carDetail);
        }

        // POST: CarDetails/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,CarName,CarDetailImage,YakitTuketimi,MalzemeKalitesi,Yoltutusu,HızlanmaPerformansı,SesYalıtımı,VitesGecisleri,IcMekanGenisligi,DonanimTeknolojisi,İkinciElPiyasa")] CarDetail carDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(carDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID = new SelectList(db.Releases, "ID", "ReleaseYear", carDetail.ID);
            ViewBag.ID = new SelectList(db.Securities, "ID", "ID", carDetail.ID);
            ViewBag.ID = new SelectList(db.TechnicalSpecifications, "ID", "SilindirHacmi", carDetail.ID);
            ViewBag.ID = new SelectList(db.Technologies, "ID", "ArkaParkSensoru", carDetail.ID);
            return View(carDetail);
        }

        // GET: CarDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CarDetail carDetail = db.CarDetails.Find(id);
            if (carDetail == null)
            {
                return HttpNotFound();
            }
            return View(carDetail);
        }

        // POST: CarDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CarDetail carDetail = db.CarDetails.Find(id);
            db.CarDetails.Remove(carDetail);
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
