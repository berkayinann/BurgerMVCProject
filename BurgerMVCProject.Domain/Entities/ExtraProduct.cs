using Microsoft.AspNetCore.Http;

namespace BurgerMVCProject.Domain.Entities
{
    public class ExtraProduct : BaseEntity
    {

        public int ExtraProductId { get; set; }
        public int MenuId { get; set; }

        public Menu Menu { get; set; }
        public Enums.Category Category { get; set; }

        public int Quantity { get; set; }

        public string ImageSrc { get; set; }

        public double Price { get; set; }
    }
}