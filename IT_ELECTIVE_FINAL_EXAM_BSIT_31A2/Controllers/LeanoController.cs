using IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models;
using Microsoft.AspNetCore.Mvc;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Controllers
{
    public class LeanoController : Controller
    {
        public IActionResult Index()
        {
            return View("LeanoPortfolio", LeanoProjectsData.All);
        }
    }
}
