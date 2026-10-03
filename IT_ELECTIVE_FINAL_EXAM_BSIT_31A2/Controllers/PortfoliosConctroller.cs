using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Controllers
{
    public class PortfoliosController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Shared/Portfolios.cshtml");
        }
    }
}