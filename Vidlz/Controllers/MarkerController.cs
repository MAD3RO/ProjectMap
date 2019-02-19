using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Vidlz.DAL;
using Vidlz.Models;

namespace Vidlz.Controllers
{
    public class MarkerController : Controller
    {
        private MarkerContext db = new MarkerContext();

        // GET: Marker
        public ActionResult Index()
        {
            return View(db.Marker.ToList());
        }

        // POST: Marker/Insert
        [HttpPost]
        public ActionResult Insert(float x, float y)
        {
            float x1 = x;
            float y1 = y;
            var marker = new Marker() { Longitude = x, Latitude = y };
            db.Marker.Add(marker);
            db.SaveChanges();
            return Json(new {x=x1, y=y1}, JsonRequestBehavior.AllowGet);
        }

        // GET: Marker/Random
        public ActionResult Random()
        {
            double x = 0, y = 0;
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            { 
                x = random.NextDouble() * (180 + 180) - 180;
                y = random.NextDouble() * (85 - 0) + 0;
                var marker = new Marker() {Longitude = x, Latitude = y};
                db.Marker.Add(marker);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: Marker/DeleteAll
        public ActionResult DeleteAll()
        {
            db.Database.ExecuteSqlCommand("TRUNCATE TABLE [Marker]");
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
