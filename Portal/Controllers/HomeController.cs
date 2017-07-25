using System.Collections.Generic;
using System.Linq;
using Portal.Models;
using System.Web.Mvc;

namespace Portal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index(string query = null)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                List<Judge> judges = _context.Judges.ToList();
                var viewModel = new HomeViewModel
                {
                    ShowActions = User.Identity.IsAuthenticated,
                    Judges = judges
                };
                return View(viewModel);
            }
            else
            {
                var containsList = _context.Judges.Where(s => s.Name.Contains(query));
                List<Judge> judges = containsList.ToList();

                var viewModel = new HomeViewModel
                {
                    ShowActions = User.Identity.IsAuthenticated,
                    Judges = judges
                };

                return View(viewModel);
            }
        }
    }
}