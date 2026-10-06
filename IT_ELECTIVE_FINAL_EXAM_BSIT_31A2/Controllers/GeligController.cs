using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Controllers
{
    public class GeligController : Controller
    {
        public IActionResult Index()
        {
            var data = GeligProjectData.GetPortfolioData();
            return View("~/Views/Shared/GeligPortfolio.cshtml", data);
        }
    }
}