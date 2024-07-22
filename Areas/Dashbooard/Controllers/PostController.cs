using Microsoft.AspNetCore.Mvc;
using XtraBlog.UI.Dtos.PostDtos;
using XtraBlog.UI.Data;
using XtraBlog.UI.Models;
using Microsoft.EntityFrameworkCore;
using XtraBlog.UI.Dtos.AdminDtos;


namespace XtraBlog.UI.Areas.Dashbooard.Controllers
{
    [Area("Dashbooard")]
    public class PostController : Controller
    {   
        private readonly AppDbContext _context;

        public PostController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var res =_context.Posts.ToList();
            return View(res);
        }
        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Create(PostCreateDto postCreate)
        {

            if (ModelState.IsValid)
            {
                var post = new Post
                {
                    Title = postCreate.Title,
                    Description = postCreate.Description,
                    PhotoURL = postCreate.PhotoURL,
                    HomeDescription = postCreate.HomeDescription,
                     VideoURL = postCreate.VideoURL,
                   CreatedDate= DateTime.Now,
                 
                };
                _context.Posts.Add(post);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(postCreate);
        }


        public IActionResult Edit(int id)
        {
            var post = _context.Posts.Find(id);
            if (post == null)
            {
                return NotFound();
            }

            var postEditDto = new PostEditDto
            {
                Id = post.Id,
                Title = post.Title,
                Description = post.Description,
                PhotoURL = post.PhotoURL,
                HomeDescription = post.HomeDescription, 
                VideoURL = post.VideoURL,
                CreatedDate= DateTime.Now,
                Admin=post.Admin

            };

            return View(postEditDto);
        }


        [HttpPost]
        public IActionResult Edit(PostEditDto postEditDto)
        {
            if (ModelState.IsValid)
            {
                var post = _context.Posts.Find(postEditDto.Id);
                if (post == null)
                {
                    return NotFound();
                }
              post.Title = postEditDto.Title;
             post.Description = postEditDto.Description;
                post.PhotoURL = postEditDto.PhotoURL;
                post.HomeDescription = postEditDto.HomeDescription;
                post.VideoURL = postEditDto.VideoURL;
                post.CreatedDate = DateTime.Now;

                _context.Entry(post).State = EntityState.Modified;
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(postEditDto);
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var post = _context.Posts.Find(id);
            if (post == null)
            {
                return NotFound();
            }

            _context.Posts.Remove(post);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}




    
