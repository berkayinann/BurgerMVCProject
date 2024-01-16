using BurgerMVCProject.Domain.Enums;
using System.Drawing;

namespace BurgerMVCProject.Domain.Entities
{
    public class Menu : BaseEntity
    {
        public string MenuId { get; set; }

        public double Price { get; set; }

        public string? Description { get; set; }

        public string? ImageSrc { get; set; }

        public int Quantity { get; set; }

        public int MyProperty { get; set; }

        public int? OrderId { get; set; }

        public Order Order { get; set; }

        public ICollection<ExtraProduct> ExtraProducts { get; set; }

        public Enums.Size Size { get; set; }

    }
}