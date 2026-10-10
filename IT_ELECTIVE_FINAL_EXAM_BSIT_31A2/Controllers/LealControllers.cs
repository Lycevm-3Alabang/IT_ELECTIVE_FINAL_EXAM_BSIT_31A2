using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Controllers
{
    public class LealController : Controller
    {
        public IActionResult Index()
        {
            var data = LealProjectData.GetPortfolioData();
            return View("~/Views/Shared/LealPortfolio.cshtml", data);
        }
    }
}