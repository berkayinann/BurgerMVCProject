namespace BurgerMVCProject.UI.Models
{
    public class MenuVM
    {
        public MenuVM()
        {
            SelectedExtraProducts = new List<int>();
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public string? Description { get; set; }

        public int Quantity { get; set; }

        public List<int> SelectedExtraProducts { get; set; }
    }
}
