using BurgerMVCProject.Domain.Entities;
using BurgerMVCProject.Domain.Enums;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgerMVCProject.UI.Models
{
    public class OrderVM
    {
        public OrderVM()
        {
            ExtraProducts = new List<SelectListItem>();
            Souces = new();
            MenuVM = new MenuVM(); 
            Product = new eProductVM();
        }

        public MenuVM MenuVM { get; set; }

        public eProductVM Product { get; set; }

        public OrderItem OrderItem { get; set; }

        public int UserId { get; set; }
        public int Id { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public string? Description { get; set; }

        public int Quantity { get; set; }
        public string SoucesName { get; set; }

        public List<SelectListItem> Souces { get; set; }

        public List<SelectListItem> ExtraProducts { get; set; }

        public bool IsMenu { get; set; }
    }
}
