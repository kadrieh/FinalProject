using PrayerTimes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace PrayerTimes.Controllers
{
    public class TimesForPrayersController : Controller
    {
        // GET: TimesForPrayers
        public ActionResult Index()
        {
            var times = GetTimesForPrayers();
            return View(times);
        }

        private IEnumerable<TimesForPrayer> GetTimesForPrayers()
        {
            return new List<TimesForPrayer>
            {
                new TimesForPrayer{Id = 1, Name = "Fajir", PrayerTime = 6.00, ReturnDate = DateTime.Now },
                new TimesForPrayer{Id = 2, Name = "Shroq", PrayerTime = 6.00, ReturnDate = DateTime.Now},
                new TimesForPrayer{Id = 3, Name = "Zhur", PrayerTime = 6.00, ReturnDate = DateTime.Now},
                new TimesForPrayer{Id = 4, Name = "Asr", PrayerTime = 6.00, ReturnDate = DateTime.Now},
                new TimesForPrayer{Id = 5, Name = "Maghrib", PrayerTime = 6.00, ReturnDate = DateTime.Now},
                new TimesForPrayer{Id = 6, Name = "Isha", PrayerTime = 6.00, ReturnDate = DateTime.Now}
            };
        }

        [HttpGet]
        public ActionResult SomeAction()
        {
            var viewModel = new TimesForPrayer
            {
                ReturnDate = System.DateTime.Now
            };

            return View(viewModel);
        }
        private DatabaseContext db = new DatabaseContext();

        // GET: Todos/Details/5
        public ActionResult Details(int? id)
        {
            Trace.WriteLine("GET /TimesForPrayers/Details/" + id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimesForPrayer timesForPrayer = db.TimeForPrayers.Find(id);
            if (timesForPrayer == null)
            {
                return HttpNotFound();
            }
            return View(timesForPrayer);
        }

        // GET: Todos/Create
        //public ActionResult Create()
        //{
        //    Trace.WriteLine("GET /Todos/Create");
        //    return View(new TimesForPrayer { CreatedDate = DateTime.Now });
        //}

        // POST: Todos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Description,CreatedDate")] TimesForPrayer timesForPrayer)
        {
            Trace.WriteLine("POST /Todos/Create");
            if (ModelState.IsValid)
            {
                db.TimeForPrayers.Add(timesForPrayer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(timesForPrayer);
        }

        // GET: Todos/Edit/5
        public ActionResult Edit(int? id)
        {
            Trace.WriteLine("GET /Todos/Edit/" + id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimesForPrayer timesForPrayer = db.TimeForPrayers.Find(id);
            if (timesForPrayer == null)
            {
                return HttpNotFound();
            }
            return View(timesForPrayer);
        }

        // POST: Todos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Description,CreatedDate")] TimesForPrayer timesForPrayer)
        {
            Trace.WriteLine("POST /Todos/Edit/" + timesForPrayer.Id);
            if (ModelState.IsValid)
            {
                db.Entry(timesForPrayer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(timesForPrayer);
        }

        // GET: Todos/Delete/5
        public ActionResult Delete(int? id)
        {
            Trace.WriteLine("GET /Todos/Delete/" + id);
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TimesForPrayer timesForPrayer = db.TimeForPrayers.Find(id);
            if (timesForPrayer == null)
            {
                return HttpNotFound();
            }
            return View(timesForPrayer);
        }

        // POST: Todos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trace.WriteLine("POST /Todos/Delete/" + id);
            TimesForPrayer timesForPrayer = db.TimeForPrayers.Find(id);
            db.TimeForPrayers.Remove(timesForPrayer);
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