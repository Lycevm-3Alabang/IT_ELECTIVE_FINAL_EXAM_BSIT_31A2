using Microsoft.AspNetCore.Mvc;
using IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Controllers
{
    public class MagnayonController : Controller
    {
        public IActionResult Index()
    {
        var myProjects = MagnayonProjectData.GetProjects();

        return View("MagnayonPortfolio", myProjects);
    }
}
}