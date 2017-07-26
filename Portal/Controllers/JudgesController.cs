using Portal.Models;
using System;
using System.Linq;
using System.Web.Mvc;
using SautinSoft;

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
                CommonlyCitedSources = j.CommonlyCitedSources,
                Country = j.Country,
                Born = j.Born,
                Education = j.Education,
                ImageUrl = j.ImageUrl,
                JudicalSystem = j.JudicalSystem,
                Jurisdiction = j.Jurisdiction,
                LastUpdated = j.LastUpdated,
                Memberships = j.Memberships,
                SatoriId = j.SatoriId,
                Name = j.Name,
                Description = j.Description,
                Rulings = j.Rulings,
                NumberOfCases = j.NumberOfCases,
                WasCitationUsed = j.WasCitationUsed,
                Language = j.Language,
                StudiedInWest = j.StudiedInWest,
                ArrestedForCorruption = j.ArrestedForCorruption
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
                CommonlyCitedSources = j.CommonlyCitedSources,
                Education = j.Education,
                ImageUrl = j.ImageUrl,
                JudicalSystem = j.JudicalSystem,
                Jurisdiction = j.Jurisdiction,
                LastUpdated = j.LastUpdated,
                Memberships = j.Memberships,
                SatoriId = j.SatoriId,
                Name = j.Name,
                Description = j.Description,
                Rulings = j.Rulings,
                NumberOfCases = j.NumberOfCases,
                WasCitationUsed = j.WasCitationUsed,
                Language = j.Language,
                StudiedInWest = j.StudiedInWest,
                ArrestedForCorruption = j.ArrestedForCorruption,
                Country = j.Country,
                Born = j.Born,
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
            j.CommonlyCitedSources = viewModel.CommonlyCitedSources;
            j.Education = viewModel.Education;
            j.ImageUrl = viewModel.ImageUrl;
            j.JudicalSystem = viewModel.JudicalSystem;
            j.Jurisdiction = viewModel.Jurisdiction;
            j.Memberships = viewModel.Memberships;
            j.SatoriId = viewModel.SatoriId;
            j.Name = viewModel.Name;
            j.Description = viewModel.Description;
            j.Rulings = viewModel.Rulings;
            j.NumberOfCases = viewModel.NumberOfCases;
            j.WasCitationUsed = viewModel.WasCitationUsed;
            j.Language = viewModel.Language;
            j.StudiedInWest = viewModel.StudiedInWest;
            j.ArrestedForCorruption = viewModel.ArrestedForCorruption;
            j.SatoriId = viewModel.SatoriId;
            j.Country = viewModel.Country;
            j.Born = viewModel.Born;
            j.Memberships = viewModel.Memberships;
            j.Rulings = viewModel.Rulings;
            j.Born = viewModel.Born;
            j.Country = viewModel.Country;
            j.CommonlyCitedSources = viewModel.CommonlyCitedSources;
            j.StudiedInWest = viewModel.StudiedInWest;
            j.WasCitationUsed = viewModel.WasCitationUsed;
            j.ArrestedForCorruption = viewModel.ArrestedForCorruption;
            j.Language = viewModel.Language;
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
            return RedirectToAction("Index", "Home", new { query = viewModel.SearchTerm });
        }

        public static string ParsePdf(string pathToPdf, string pathToText)
        {
            //Convert PDF file to Text file
            PdfFocus f = new PdfFocus();
            // You may download the latest version of SDK here:  
            // www.sautinsoft.com/products/pdf-focus/download.php  

            f.OpenPdf(pathToPdf);

            if (f.PageCount > 0)
            {
                int result = f.ToText(pathToText);

                //Show Text document
                if (result == 0)
                {
                    //TODO

                }
            }

            return string.Empty;
        }
    }
}