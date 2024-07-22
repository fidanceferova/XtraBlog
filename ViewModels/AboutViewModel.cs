
using Microsoft.AspNetCore.Mvc;
using XtraBlog.UI.Data;
using XtraBlog.UI.Models;
namespace XtraBlog.UI.ViewModels

{
    public class AboutViewModel
    {
        

        public List<Admin> Admins { get; set; }
        public List<About> Abouts { get; set; }

        public List<Paramether> Paramethers { get; set; }
    }
}