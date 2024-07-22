using XtraBlog.UI.Models;

namespace XtraBlog.UI.ViewModels
{
    public class HomeViewModel
    {
        public List<Post> Posts { get; set; }
        public List<PostGenre> PostGenres { get; set; }
    }
}