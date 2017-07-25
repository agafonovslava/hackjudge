using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Portal.Models;

namespace Portal.Controllers
{
    public class OpinionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OpinionsController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index(string query = null)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                var opinions = _context.Opinions.Include(o => o.Judge);
                var viewModel = new OpinionViewModel
                {
                    ShowActions = User.Identity.IsAuthenticated,
                    Opinions = opinions.ToList()
                };
                return View(viewModel);
            }
            else
            {
                var containsList = _context.Opinions.Where(s => s.Title.Contains(query));
                List<Opinion> opinions = containsList.ToList();

                var viewModel = new OpinionViewModel
                {
                    ShowActions = User.Identity.IsAuthenticated,
                    Opinions = opinions
                };

                return View(viewModel);
            }
        }

        // GET: Opinions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opinion opinion = _context.Opinions.Find(id);
            if (opinion == null)
            {
                return HttpNotFound();
            }
            return View(opinion);
        }

        // GET: Opinions/Create
        public ActionResult Create()
        {
            ViewBag.JudgeId = new SelectList(_context.Judges, "JudgeId", "JudgeId");
            return View();
        }

        // POST: Opinions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "OpinionId,Title,Url,JudgeId,JudgeName")] Opinion opinion)
        {
            if (ModelState.IsValid)
            {
                _context.Opinions.Add(opinion);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.JudgeId = new SelectList(_context.Judges, "JudgeId", "JudgeId", opinion.JudgeId);
            return View(opinion);
        }

        // GET: Opinions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opinion opinion = _context.Opinions.Find(id);
            if (opinion == null)
            {
                return HttpNotFound();
            }
            ViewBag.JudgeId = new SelectList(_context.Judges, "JudgeId", "JudgeId", opinion.JudgeId);
            return View(opinion);
        }

        // POST: Opinions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "OpinionId,Title,Url,JudgeId,JudgeName")] Opinion opinion)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(opinion).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.JudgeId = new SelectList(_context.Judges, "JudgeId", "JudgeId", opinion.JudgeId);
            return View(opinion);
        }

        // GET: Opinions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Opinion opinion = _context.Opinions.Find(id);
            if (opinion == null)
            {
                return HttpNotFound();
            }
            return View(opinion);
        }

        // POST: Opinions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Opinion opinion = _context.Opinions.Find(id);
            _context.Opinions.Remove(opinion);
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
        public ActionResult Search(OpinionViewModel viewModel)
        {
            return RedirectToAction("Index", "Opinions", new { query = viewModel.SearchTerm });
        }
    }
}
