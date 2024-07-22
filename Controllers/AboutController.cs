using Microsoft.AspNetCore.Mvc;
using XtraBlog.UI.Data;
using XtraBlog.UI.ViewModels;

namespace XtraBlog.UI.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _context;

        public AboutController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var viewModel = new AboutViewModel
            {
                Admins = _context.Admins.ToList(),
                Abouts = _context.Abouts.ToList(),
                Paramethers = _context.Paramethers.ToList()
            };
            return View(viewModel);
        }
    }
}