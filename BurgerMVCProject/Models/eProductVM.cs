using BurgerMVCProject.Domain.Entities;
using BurgerMVCProject.Domain.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgerMVCProject.UI.Models
{
    public class eProductVM
    {
        public eProductVM()
        {
            Souces = new();
            Products = new List<SelectListItem>();
        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string ImageSRC { get; set; }
        public List<SelectListItem> Souces { get; set; }
        public List<SelectListItem> Products { get; set; }
 
    }
}
