using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Controllers
{
    // The "Portfolios" page  ->  /Portfolios
    public class PortfoliosController : Controller
    {
        public IActionResult Index()
        {
            // The view lives in Views/Shared, so we name it explicitly.
            return View("Portfolios");
        }
    }
}
