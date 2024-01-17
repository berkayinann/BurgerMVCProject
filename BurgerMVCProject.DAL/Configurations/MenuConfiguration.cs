using BurgerMVCProject.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menus");
            builder.HasKey(x => x.MenuId);

            builder.HasData(
                    new Menu 
                    { 
                        MenuId = 1, 
                        Name = "Hamburger Menu", 
                        Size=BurgerMVCProject.Domain.Enums.Size.Medium,
                        Price = 145.00, 
                        ImageSrc = "~/MenuPhotos/1-hamburger-menu_145.png"
                    }, //"~/MenuPhotos/b3.png"
                    new Menu 
                    { 
                        MenuId = 2, 
                        Name = "Cheeseburger Menu", 
                        Price = 150.00, 
                        ImageSrc = "~/MenuPhotos/2-cheeseburger_menu_150.png"
                    },
                    new Menu 
                    { 
                        MenuId = 3, 
                        Name = "Double Cheeseburger Menu",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Price = 185.00, 
                        ImageSrc = "~/MenuPhotos/3-double_cheeseburger_menu_185.png"
                    },
                    new Menu
                    {
                        MenuId=4,
                        Name= "Mega Double Cheeseburger Menu",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Price = 280.00,
                        ImageSrc = "~/MenuPhotos/4-mega-double-cheeseburger-menu_280.png"
                    },
                    new Menu
                    {
                        MenuId = 5,
                        Name = "Meatball Burger Menu",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Price = 160.00,
                        ImageSrc = "~/MenuPhotos/5-kofteburger_menu_160.png"
                    },
                    new Menu
                    {
                        MenuId = 6,
                        Name = "Double Meatball Burger Menu",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Price = 175.00,
                        ImageSrc = "~/MenuPhotos/6-double-kofteburger-menu_175.png"
                    },
                    new Menu
                    {
                        MenuId = 7,
                        Name = "Whopper Menu",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Price = 200.00,
                        ImageSrc = "~/MenuPhotos/7-whopper-menu_200.png"
                    },
                    new Menu
                    {
                        MenuId = 8,
                        Name = "Double Whopper Menu",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Price = 265.00,
                        ImageSrc = "~/MenuPhotos/8-double-whopper-menu_265.png"
                    },
                    new Menu
                    {
                        MenuId = 9,
                        Name = "Triple Whopper Menu",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Price = 310.00,
                        ImageSrc = "~/MenuPhotos/9-triple-whopper-menu_310.png"
                    },
                    new Menu
                    {
                        MenuId = 10,
                        Name = "Chicken Burger Menu",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Price = 130.00,
                        ImageSrc = "~/MenuPhotos/10-tavukburger-menu_130.png"
                    },
                    new Menu
                    {
                        MenuId = 11,
                        Name = "King Chicken Burger Menu",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Price = 150.00,
                        ImageSrc = "~/MenuPhotos/11-king_chicken_burger_menu_150.png"
                    },
                    new Menu
                    {
                        MenuId = 12,
                        Name = "Double King Chicken Burger Menu",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Price = 180.00,
                        ImageSrc = "~/MenuPhotos/12-double-king-chicken-menu_180.png"
                    }
                );
        }
    }
}
