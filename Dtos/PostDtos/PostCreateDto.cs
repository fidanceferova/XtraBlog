using System.ComponentModel.DataAnnotations;

namespace XtraBlog.UI.Dtos.PostDtos
{
    public class PostCreateDto
    {
        [Required]
        [Length(4,50,ErrorMessage ="Ad minumum 4 maksimum 50 simvol olmalidir")]

        public string Title { get; set; }
        public string HomeDescription { get; set; }
        public string Description { get; set; }
        public string PhotoURL { get; set; }
        public string VideoURL { get; set; }
    }
}
