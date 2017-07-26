using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portal.Models;

namespace Portal.Controllers
{
    public class MembershipsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MembershipsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Memberships
        public ActionResult Index()
        {
            var memberships = _context.Memberships.Include(m => m.Judge);
            return View(memberships.ToList());
        }

        // GET: Memberships/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membership membership = _context.Memberships.Find(id);
            if (membership == null)
            {
                return HttpNotFound();
            }
            return View(membership);
        }

        // GET: Memberships/Create
        public ActionResult Create()
        {
            ViewBag.JudgeId = new SelectList(_context.Judges, "JudgeId", "JudgeId");
            return View();
        }

        // POST: Memberships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MembershipId,Title,JudgeId")] Membership membership)
        {
            if (ModelState.IsValid)
            {
                _context.Memberships.Add(membership);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.JudgeId = new SelectList(_context.Judges, "JudgeId", "JudgeId", membership.JudgeId);
            return View(membership);
        }

        // GET: Memberships/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membership membership = _context.Memberships.Find(id);
            if (membership == null)
            {
                return HttpNotFound();
            }
            ViewBag.JudgeId = new SelectList(_context.Judges, "JudgeId", "JudgeId", membership.JudgeId);
            return View(membership);
        }

        // POST: Memberships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MembershipId,Title,JudgeId")] Membership membership)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(membership).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.JudgeId = new SelectList(_context.Judges, "JudgeId", "JudgeId", membership.JudgeId);
            return View(membership);
        }

        // GET: Memberships/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Membership membership = _context.Memberships.Find(id);
            if (membership == null)
            {
                return HttpNotFound();
            }
            return View(membership);
        }

        // POST: Memberships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Membership membership = _context.Memberships.Find(id);
            _context.Memberships.Remove(membership);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
