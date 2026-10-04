using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Controllers
{
    public class TumalaController : Controller
    {
        [Route("Tumala")]
        public IActionResult Index()
        {
            var projects = TumalaProjectData.All;
            return View("~/Views/Shared/TumalaPortfolio.cshtml", projects);
        }
    }
}