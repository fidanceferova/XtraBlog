using Microsoft.AspNetCore.Mvc;
using XtraBlog.UI.Data;
using XtraBlog.UI.Models;
using XtraBlog.UI.ViewModels;

namespace XtraBlog.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _post;
        private readonly AppDbContext _postGenre;
        private readonly AppDbContext _categorie;
        private readonly AppDbContext _comment;

        public HomeController(AppDbContext post, AppDbContext postGenre, AppDbContext categorie, AppDbContext comment)
        {
            _post = post;
            _postGenre = postGenre;
            _categorie = categorie;
            _comment = comment;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                Posts = _post.Posts.ToList(),
                PostGenres = _postGenre.PostGenres.ToList()
            };
            return View(viewModel);
        }

        public IActionResult Detail(int id)
        {
            var post = _post.Posts.FirstOrDefault(x => x.Id == id);
            var viewModel = new DetailViewModel
            {
                Post = post,
                Categories = _categorie.Categories.ToList(),
                Comments = _comment.Comments.ToList()
            };
            return View(viewModel);
        }
    }
}
