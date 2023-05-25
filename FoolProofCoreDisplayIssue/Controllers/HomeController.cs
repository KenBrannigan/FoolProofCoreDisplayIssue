using Microsoft.AspNetCore.Mvc;

namespace FoolProofCoreDisplayIssue.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(new Models.Index());
        }

        [HttpPost]
        public IActionResult Index(Models.Index index)
        {
            if (ModelState.IsValid)
            {
                return Content("Success");
            }

            return View(index);
        }
    }
}