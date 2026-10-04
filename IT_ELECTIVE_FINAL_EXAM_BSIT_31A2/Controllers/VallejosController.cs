using Microsoft.AspNetCore.Mvc;
using System.Linq;
using IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Controllers
{
    public class VallejosController : Controller
    {
        public IActionResult Index()
        {
            return View("VallejosPortfolio", VallejosProjectData.Projects);
        }

        public IActionResult Details(int id)
        {
            var project = VallejosProjectData.Projects.FirstOrDefault(p => p.Id == id);
            if (project == null) return NotFound();

            return View("VallejosPortfolio", project);
        }
    }
}