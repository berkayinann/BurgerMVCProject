namespace BurgerMVCProject.Domain.Entities
{
    public class ExtraProduct : BaseEntity
    {

        public string ExtraProductId { get; set; }
        public int MenuId { get; set; }

        public Menu Menu { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int Quantity { get; set; }

        public string ImageSrc { get; set; }

        public double Price { get; set; }

        public string? Description { get; set; }
    }
}