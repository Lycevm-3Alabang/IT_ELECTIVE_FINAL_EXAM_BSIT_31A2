using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Controllers
{
    public class LlorenteController : Controller
    {
        [Route("Llorente")]
        public IActionResult Index()
        {
            var projects = LlorenteProjectData.All;
            return View("~/Views/Shared/LlorentePortfolio.cshtml", projects);
        }
    }
}