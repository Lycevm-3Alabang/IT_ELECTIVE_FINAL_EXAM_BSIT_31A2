using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Controllers
{
    public class VillamorController : Controller
    {
        public IActionResult Index()
        {
            return View("VillamorPortfolio", VillamorProjectData.All);
        }
    }
}