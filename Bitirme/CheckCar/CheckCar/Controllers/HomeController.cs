using CheckCar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CheckCar.Controllers
{
    public class HomeController : Controller
    {
        CheckCarContext context = new CheckCarContext();
        HomePage home = new HomePage();
        // GET: Home
        public ActionResult Index()
        {
            home.Marka = context.Marks.ToList();
            home.YeniEklenenler = context.Releases.Where(i => i.ReleaseYear=="2018").ToList();
            home.EnYuksekFiyat = context.Releases.OrderBy(i=>i.Price).Take(4).ToList();
            home.CarDetail = context.CarDetails.ToList();
            home.News = context.News.OrderBy(i=> i.Date).Take(2).ToList();
            return View(home);
        }
        [HttpPost]
        public ActionResult Index(string EnAz, string EnCok/*, string Yakitturu, string Vitestipi, string Kasatipi, string Siralamasekli*/)
        {
            
            return View();
        }

        public ActionResult Mark()
        {
            return View(context.Marks.ToList());
        }
        public ActionResult MarkVersion(int id)
        {
            return View(context.MarkVersions.Where(i=> i.MarkID == id).ToList());
        }
        public ActionResult Release(int id)
        {
            return View(context.Releases.Where(i => i.MarkVersionID == id).ToList());
        }
        public ActionResult CarDetail(int id)
        {
            return View(context.CarDetails.Where(i =>i.Release.ID == id).FirstOrDefault());
        }
        public ActionResult News()
        {
            return View(context.News.ToList());
        }
        public ActionResult NewsDetail(int id)
        {
            return View(context.News.Where(i => i.ID == id).FirstOrDefault());
        }

        public ActionResult MatchUpCar()
        {
            return View();
        }
       
      

    }
}