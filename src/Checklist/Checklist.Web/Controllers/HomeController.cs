using System.Linq;
using System.Web.Mvc;
using Checklist.Web.Context;

namespace Checklist.Web.Controllers
{
    public class HomeController : Controller
    {
        // Yes, yes, I need to add StructureMap
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        public ActionResult Index()
        {
            var checklist = _context.Set<Data.Checklist>().SingleOrDefault();

            return View(checklist);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}