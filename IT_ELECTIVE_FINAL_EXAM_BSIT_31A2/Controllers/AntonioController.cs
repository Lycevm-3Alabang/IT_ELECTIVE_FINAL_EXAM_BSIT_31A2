using IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Controllers
{
    public class AntonioController : Controller
    {
        public IActionResult Index()
        {
            return View("AntonioPortfolio", AntonioProjectData.All);
        }
    }
}