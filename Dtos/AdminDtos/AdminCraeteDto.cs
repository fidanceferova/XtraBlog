using System.ComponentModel.DataAnnotations;

namespace XtraBlog.UI.Dtos.AdminDtos
{
    public class AdminCraeteDto
    {

        [Required]
        [Length(4, 50, ErrorMessage = "Ad minumum 4 maksimum 50 simvol olmalidir")]


        public string Name { get; set; }
        public string Description { get; set; }
        public string PhotoURL { get; set; }
        public string Position { get; set; }
    }
}
