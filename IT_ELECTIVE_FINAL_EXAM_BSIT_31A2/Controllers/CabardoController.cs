using IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Controllers
{
    public class CabardoController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Shared/CabardoPortfolio.cshtml", CabardoProjectData.All);
        }
    }
}