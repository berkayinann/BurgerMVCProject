using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVCProject.Domain.Entities
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int MenuId { get; set; }
        public int ExtraProductId { get; set; }

        public Order Order { get; set; }
        public Menu Menu { get; set; }
        public ExtraProduct ExtraProduct { get; set; }
    }
}
