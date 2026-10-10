using IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models;
using Microsoft.AspNetCore.Mvc;
namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Controllers
{
    public class BaswelController : Controller
    {
        [Route("Baswel")]
        public IActionResult Index()
        {
            var projects = BaswelProjectData.All;
            return View("~/Views/Shared/BaswelPortfolio.cshtml", projects);
        }
    }
}
