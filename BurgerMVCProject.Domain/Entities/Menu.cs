using BurgerMVCProject.Domain.Enums;
using Microsoft.AspNetCore.Http;
using System.Drawing;

namespace BurgerMVCProject.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public int MenuId { get; set; }

        public double Price { get; set; }

        public string? Description { get; set; }

        public string? ImageSrc { get; set; }
        public IFormFile Image { get; set; }

        public int Quantity { get; set; }

        public int MyProperty { get; set; }

        public int? OrderId { get; set; }

        public Order Order { get; set; }

        public ICollection<ExtraProduct> ExtraProducts { get; set; }

        public Enums.Size Size { get; set; }

    }
}