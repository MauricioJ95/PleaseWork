using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SocialMediaSat.Models;

namespace SocialMediaSat.Controllers
{
    public class TweetGeneratorsController : Controller
    {
        private SMSDBEntities db = new SMSDBEntities();

        // GET: TweetGenerators
        public ActionResult Index()
        {
            return View(db.TweetGenerators.ToList());
        }

        // GET: TweetGenerators/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TweetGenerator tweetGenerator = db.TweetGenerators.Find(id);
            if (tweetGenerator == null)
            {
                return HttpNotFound();
            }
            return View(tweetGenerator);
        }

        // GET: TweetGenerators/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TweetGenerators/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Username,Firstname,Lastname,Likes,Retweets,Text")] TweetGenerator tweetGenerator)
        {
            if (ModelState.IsValid)
            {
                db.TweetGenerators.Add(tweetGenerator);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tweetGenerator);
        }

        // GET: TweetGenerators/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TweetGenerator tweetGenerator = db.TweetGenerators.Find(id);
            if (tweetGenerator == null)
            {
                return HttpNotFound();
            }
            return View(tweetGenerator);
        }

        // POST: TweetGenerators/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Username,Firstname,Lastname,Likes,Retweets,Text")] TweetGenerator tweetGenerator)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tweetGenerator).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tweetGenerator);
        }

        // GET: TweetGenerators/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TweetGenerator tweetGenerator = db.TweetGenerators.Find(id);
            if (tweetGenerator == null)
            {
                return HttpNotFound();
            }
            return View(tweetGenerator);
        }

        // POST: TweetGenerators/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            TweetGenerator tweetGenerator = db.TweetGenerators.Find(id);
            db.TweetGenerators.Remove(tweetGenerator);
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
