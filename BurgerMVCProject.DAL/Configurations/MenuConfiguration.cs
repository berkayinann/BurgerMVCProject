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
                        Price = 145.00, 
                        ImageSrc= "MenuPhotos/1-hamburger-menu_145.png",
                        Size=BurgerMVCProject.Domain.Enums.Size.Medium,
                        Description= "Delicacy consisting of hamburger meat, small sesame sandwich bread, pickled cucumber, mustard and ketchup. Enjoy the Hamburger Menu as you wish, with delicious fries and drinks!"
                    }, 
                    new Menu 
                    { 
                        MenuId = 2, 
                        Name = "Cheeseburger Menu", 
                        Price = 150.00,
                        ImageSrc = "MenuPhotos/2-cheeseburger_menu_150.png",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Description= "Delicacy consisting of hamburger meat, small sesame sandwich bread, pickled cucumber, cheddar cheese, mustard and ketchup. Enjoy the Cheeseburger Menu as you wish, with delicious fries and drinks!"
                    },

                    new Menu
                    {
                        MenuId = 3,
                        Name = "Double Cheeseburger Menu",
                        Price = 185.00,
                        ImageSrc = "MenuPhotos/3-double_cheeseburger_menu_185.png",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Description= "Delicacy consisting of 2 hamburger meat, small sesame sandwich bread, pickled cucumber, 2 pieces of cheddar cheese, mustard and ketchup."
                    },
         
                    new Menu
                    {
                        MenuId=4,
                        Name= "Mega Double Cheeseburger Menu",
                        Price = 280.00,
                        ImageSrc = "MenuPhotos/4-mega-double-cheeseburger-menu_280.png",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Description= "The flavor consists of 2 Whopper meats, large sesame sandwich bread, pickled cucumber, 4 pieces of cheddar cheese, mustard and ketchup. Enjoy the Mega Double Cheeseburger Menu with delicious fries and drink as you wish!"
                    },
                    new Menu
                    {
                        MenuId = 5,
                        Name = "Meatball Burger Menu",
                        Price = 160.00,
                        ImageSrc = "MenuPhotos/5-kofteburger_menu_160.png",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Description= "A unique combination of meatball burger meat prepared according to mother's recipe, small sesame sandwich bread, pickled cucumber, ketchup, mayonnaise and lettuce. Enjoy the Meatball Burger Menu as you wish, with delicious fries and drink!"
                    },
                    new Menu
                    {
                        MenuId = 6,
                        Name = "Double Meatball Burger Menu",
                        Price = 175.00,
                        ImageSrc = "MenuPhotos/6-double-kofteburger-menu_175.png",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Description= "A unique combination of 2 Meatball burger meats, cheddar cheese, small sesame sandwich bread, pickled cucumber, ketchup, mayonnaise and lettuce, prepared according to mother's recipe. Enjoy the Double Meatball Burger Menu with delicious fries and drink as you wish!"
                    },
                    new Menu
                    {
                        MenuId = 7,
                        Name = "Whopper Menu",
                        Price = 200.00,
                        ImageSrc = "MenuPhotos/7-whopper-menu_200.png",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Description= "A classic consisting of Whopper meat, large sesame sandwich bread, pickled cucumber, ketchup, mayonnaise, chopped lettuce, tomato and onion. Enjoy the Whopper Menu as you wish, with delicious fries and drinks!"
                    },
                    new Menu
                    {
                        MenuId = 8,
                        Name = "Double Whopper Menu",
                        Price = 265.00,
                        ImageSrc = "MenuPhotos/8-double-whopper-menu_265.png",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Description= "Perfect for doubling the classic Whopper flavor with two Whopper meats, large sesame buns, pickled cucumber, ketchup, mayonnaise, chopped lettuce, tomato and onion. Enjoy the Double Whopper Menu as you wish, with delicious fries and drinks!"
                    },
                    new Menu
                    {
                        MenuId = 9,
                        Name = "Triple Whopper Menu",
                        Price = 310.00,
                        ImageSrc = "MenuPhotos/9-triple-whopper-menu_310.png",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Description= "A delicious selection consisting of 3 Whopper meats, large sesame sandwich bread, pickled cucumber, ketchup, mayonnaise, lettuce, tomato and onion. Enjoy the Triple Whopper Menu with delicious fries and drinks as you wish!"
                    },
                    new Menu
                    {
                        MenuId = 10,
                        Name = "Chicken Burger Menu",
                        Price = 130.00,
                        ImageSrc = "MenuPhotos/10-tavukburger-menu_130.png",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Description= "Enjoy this extremely simple alternative consisting of chicken burger meat, small sesame sandwich bread, mayonnaise and chopped lettuce, along with delicious fries and a drink, as you wish!"
                    },
                    new Menu
                    {
                        MenuId = 11,
                        Name = "King Chicken Burger Menu",
                        Price = 150.00,
                        ImageSrc = "MenuPhotos/11-king_chicken_burger_menu_150.png",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Description= "Enjoy this extremely simple alternative consisting of King Chicken meat, sesame sandwich bread, mayonnaise and chopped lettuce, along with delicious fries and a drink, as you wish!"
                    },
                    new Menu
                    {
                        MenuId = 12,
                        Name = "Double King Chicken Burger Menu",
                        Price = 180.00,
                        ImageSrc = "MenuPhotos/12-double-king-chicken-menu_180.png",
                        Size = BurgerMVCProject.Domain.Enums.Size.Medium,
                        Description= "Enjoy the classic flavor alternative consisting of 2 King Chicken meat, sesame sandwich bread, mayonnaise and chopped lettuce, along with delicious fries and a drink, as you wish!"
                    }
                );
        }
    }
}
