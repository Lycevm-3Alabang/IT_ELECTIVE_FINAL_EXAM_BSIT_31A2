using Microsoft.AspNetCore.Mvc;
using System.Linq;
using IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Controllers
{
    public class AlbanoController : Controller
    {
        public IActionResult Index()
        {
            return View("AlbanoPortfolio", AlbanoProjectData.Projects);
        }

        public IActionResult Details(int id)
        {
            var project = AlbanoProjectData.Projects.FirstOrDefault(p => p.Id == id);
            if (project == null) return NotFound();

            return View("AlbanoPortfolio", project);
        }
    }
}
