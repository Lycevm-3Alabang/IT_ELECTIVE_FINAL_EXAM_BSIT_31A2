using IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Controllers
{
    public class GomezController : Controller
    {
        public IActionResult Index()
        {

            return View("GomezPortfolio", GomezProjectData.All);
        }
    }
}
