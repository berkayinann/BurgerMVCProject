using BurgerMVCProject.Domain.Entities;
using BurgerMVCProject.Domain.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgerMVCProject.UI.Models
{
    public class MenuVM
    {
        public MenuVM()
        {
            Menus = new List<SelectListItem>();
            Sizes= new List<SelectListItem>();    
        }


        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string Size { get; set; }
        public List<SelectListItem> Sizes { get; set; }
        public List<SelectListItem> Menus { get; set; }
        public string ImageSRC { get; set; }
    }
}
