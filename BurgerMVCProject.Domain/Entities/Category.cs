namespace BurgerMVCProject.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string CategoryId { get; set; }

        public ICollection<ExtraProduct> ExtraProducts { get; set; }

        public string Description { get; set; }
    }
}