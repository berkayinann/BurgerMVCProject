namespace BurgerMVCProject.Domain.Entities
{
    public class Order : BaseEntity
    {

        public string OrderId { get; set; }
        public string AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        public int  Quantity { get; set; }

        public double TotalPrice { get; set; }

        public ICollection<Menu> Menus { get; set; }
    }
}