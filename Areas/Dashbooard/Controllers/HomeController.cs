using Microsoft.AspNetCore.Mvc;

namespace XtraBlog.UI.Areas.Dashbooard.Controllers
{
    [Area("Dashbooard")]
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> logger;
        public HomeController(ILogger<HomeController> logger)
        {
            logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}
