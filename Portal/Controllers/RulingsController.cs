using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Portal.Models;

namespace Portal.Controllers
{
    public class RulingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RulingsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index(string query = null)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                var Rulings = _context.Rulings.Include(o => o.Judge);
                var viewModel = new RulingViewModel
                {
                    ShowActions = User.Identity.IsAuthenticated,
                    Rulings = Rulings.ToList()
                };
                return View(viewModel);
            }
            else
            {
                var containsList = _context.Rulings.Where(s => s.Title.Contains(query));
                List<Ruling> Rulings = containsList.ToList();

                var viewModel = new RulingViewModel
                {
                    ShowActions = User.Identity.IsAuthenticated,
                    Rulings = Rulings
                };

                return View(viewModel);
            }
        }

        // GET: Rulings/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ruling Ruling = _context.Rulings.Find(id);
            if (Ruling == null)
            {
                return HttpNotFound();
            }
            return View(Ruling);
        }

        // GET: Rulings/Create
        public ActionResult Create()
        {
            ViewBag.JudgeId = new SelectList(_context.Judges, "JudgeId", "JudgeId");
            return View();
        }

        // POST: Rulings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RulingId,Title,Url,JudgeId")] Ruling Ruling)
        {
            if (ModelState.IsValid)
            {
                _context.Rulings.Add(Ruling);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.JudgeId = new SelectList(_context.Judges, "JudgeId", "JudgeId", Ruling.JudgeId);
            return View(Ruling);
        }

        // GET: Rulings/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ruling Ruling = _context.Rulings.Find(id);
            if (Ruling == null)
            {
                return HttpNotFound();
            }
            ViewBag.JudgeId = new SelectList(_context.Judges, "JudgeId", "JudgeId", Ruling.JudgeId);
            return View(Ruling);
        }

        // POST: Rulings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RulingId,Title,Url,JudgeId,JudgeName")] Ruling Ruling)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(Ruling).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.JudgeId = new SelectList(_context.Judges, "JudgeId", "JudgeId", Ruling.JudgeId);
            return View(Ruling);
        }

        // GET: Rulings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ruling Ruling = _context.Rulings.Find(id);
            if (Ruling == null)
            {
                return HttpNotFound();
            }
            return View(Ruling);
        }

        // POST: Rulings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ruling Ruling = _context.Rulings.Find(id);
            _context.Rulings.Remove(Ruling);
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


        [HttpPost]
        public ActionResult Search(RulingViewModel viewModel)
        {
            return RedirectToAction("Index", "Rulings", new { query = viewModel.SearchTerm });
        }
    }
}
