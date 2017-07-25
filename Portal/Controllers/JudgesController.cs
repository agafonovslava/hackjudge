using Portal.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace Portal.Controllers
{
    public class JudgesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public JudgesController()
        {
            _context = new ApplicationDbContext();
        }

        //[Authorize]
        // GET: Judge
        public ActionResult Create()
        {
            var viewModel = new Judge
            {
            };

            return View(viewModel);
        }

        public ActionResult View(int id)
        {
            var j = _context.Judges.Single(s => s.JudgeId == id);
            var viewModel = new Judge
            {
                JudgeId = j.JudgeId,
                AttorneyNames = j.AttorneyNames,
                CaseHolding = j.CaseHolding,
                CommonlySitedSources = j.CommonlySitedSources,
                Education = j.Education,
                ImageUrl = j.ImageUrl,
                JudicalSystem = j.JudicalSystem,
                Jurisdiction = j.Jurisdiction,
                LastUpdated = j.LastUpdated,
                Memberships = j.Memberships,
                SatoriId = j.SatoriId,
                Name = j.Name,
                Description = j.Description,
                Opinions = j.Opinions,
                Religion = j.Religion,
                NumberOfCases = j.NumberOfCases
            };

            return View("View", viewModel);
        }

        //[Authorize]
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Judge viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", viewModel);
            }
            viewModel.LastUpdated = DateTime.UtcNow;
            _context.Judges.Add(viewModel);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        //[Authorize]
        public ActionResult Edit(int id)
        {
            var j = _context.Judges.Single(s => s.JudgeId == id);
            var viewModel = new Judge
            {
               JudgeId = j.JudgeId,
               AttorneyNames = j.AttorneyNames,
               CaseHolding = j.CaseHolding,
               CommonlySitedSources = j.CommonlySitedSources,
               Education = j.Education,
               ImageUrl = j.ImageUrl,
               JudicalSystem = j.JudicalSystem,
               Jurisdiction = j.Jurisdiction,
               LastUpdated = j.LastUpdated,
               Memberships = j.Memberships,
               SatoriId = j.SatoriId,
               Name = j.Name,
               Description = j.Description,
               Opinions = j.Opinions,
               Religion = j.Religion,
               NumberOfCases = j.NumberOfCases
            };

            return View("Edit", viewModel);
        }

        //[Authorize]
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Judge viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Edit", viewModel);
            }

            var j = _context.Judges.Single(s => s.JudgeId == viewModel.JudgeId);
            j.LastUpdated = DateTime.UtcNow;
            j.AttorneyNames = viewModel.AttorneyNames;
            j.CaseHolding = viewModel.CaseHolding;
            j.CommonlySitedSources = viewModel.CommonlySitedSources;
            j.Education = viewModel.Education;
            j.ImageUrl = viewModel.ImageUrl;
            j.JudicalSystem = viewModel.JudicalSystem;
            j.Jurisdiction = viewModel.Jurisdiction;
            j.LastUpdated = viewModel.LastUpdated;
            j.Memberships = viewModel.Memberships;
            j.SatoriId = viewModel.SatoriId;
            j.Name = viewModel.Name;
            j.Description = viewModel.Description;
            j.Opinions = viewModel.Opinions;
            j.Religion = viewModel.Religion;
            j.NumberOfCases = viewModel.NumberOfCases;
            
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        //[Authorize]
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var j = _context.Judges.FirstOrDefault(s => s.JudgeId == id);
            if (j == null)
            {
                return View("Error");
            }

            _context.Judges.Remove(j);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public ActionResult Search(HomeViewModel viewModel)
        {
            return RedirectToAction("Index", "Home", new { query = viewModel.SearchTerm});
        }
    }
}