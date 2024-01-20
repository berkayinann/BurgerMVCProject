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
    public class ExtraProductConfiguration : IEntityTypeConfiguration<ExtraProduct>
    {
        public void Configure(EntityTypeBuilder<ExtraProduct> builder)
        {

            builder.ToTable("Extra Products");
            builder.HasKey(x => x.ExtraProductId);

            builder.HasData(
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 1,
                Name = "Coca-Cola Zero Sugar (33 cl)",
                Price = 30.00,
                ImageSrc = "DrinkPhotos/1-coca-cola-zero-sugar_30tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 2,
                Name = "Coca-Cola (33 cl)",
                Price = 30.00,
                ImageSrc = "DrinkPhotos/2-coca-cola-33cl_30tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 3,
                Name = "Coca-Cola Light (33 cl)",
                Price = 30.00,
                ImageSrc = "DrinkPhotos/3-coca-cola-light_30tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 4,
                Name = "Fanta (33 cl)",
                Price = 30.00,
                ImageSrc = "DrinkPhotos/4-fanta-33cl_30tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 5,
                Name = "Fuse Tea (33 cl)",
                Price = 30.00,
                ImageSrc = "DrinkPhotos/5-fuse-tea-33cl_30tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 6,
                Name = "Sprite (33 cl)",
                Price = 30.00,
                ImageSrc = "DrinkPhotos/6-sprite-33cl_30tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 7,
                Name = "Ayran (195 ml)",
                Price = 20.00,
                ImageSrc = "DrinkPhotos/7-ayran-195-ml_20tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 8,
                Name = "Ayran (300 ml)",
                Price = 25.00,
                ImageSrc = "DrinkPhotos/8-ayran-300-ml_25tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 9,
                Name = "Water (33 cl)",
                Price = 15.00,
                ImageSrc = "DrinkPhotos/9-su-15.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 10,
                Name = "Tea",
                Price = 10.00,
                ImageSrc = "DrinkPhotos/10-cay_10.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 11,
                Name = "Filter Coffee",
                Price = 30.00,
                ImageSrc = "DrinkPhotos/11-Filtre-Kahve_30.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 12,
                Name = "Americano",
                Price = 40.00,
                ImageSrc = "DrinkPhotos/12-Americano_40.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 13,
                Name = "Latte",
                Price = 50.00,
                ImageSrc = "DrinkPhotos/13-Latte_50.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 14,
                Name = "Hazelnut Latte",
                Price = 55.00,
                ImageSrc = "DrinkPhotos/14-Findik_Latte_55.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 15,
                Name = "Caramel Latte",
                Price = 55.00,
                ImageSrc = "DrinkPhotos/15-Karamel_Latte_55.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 16,
                Name = "Chai Tea Latte",
                Price = 55.00,
                ImageSrc = "DrinkPhotos/16-Chai_Tea _Latte_55.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 17,
                Name = "Cappucino",
                Price = 50.00,
                ImageSrc = "DrinkPhotos/17-Cappucino_50.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 18,
                Name = "Flat White",
                Price = 50.00,
                ImageSrc = "DrinkPhotos/18-Flat_White_50.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 19,
                Name = "Mocha",
                Price = 50.00,
                ImageSrc = "DrinkPhotos/19-mocha_50.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 20,
                Name = "Turkish Coffee",
                Price = 45.00,
                ImageSrc = "DrinkPhotos/20-Turk_Kahvesi_45.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 21,
                Name = "Hot Chocolate",
                Price = 45.00,
                ImageSrc = "DrinkPhotos/21-Sicak_cikolata_45.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 22,
                Name = "Iced Americano",
                Price = 40.00,
                ImageSrc = "DrinkPhotos/22-iced-americano_40.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 23,
                Name = "Iced Latte",
                Price = 50.00,
                ImageSrc = "DrinkPhotos/23-iced-latte_50.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Drinks,
                ExtraProductId = 24,
                Name = "Iced Mocha",
                Price = 50.00,
                ImageSrc = "DrinkPhotos/24-iced-mocha_50.png",
            },

            //Burgers
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Burgers,
                ExtraProductId = 25,
                Name = "Hamburger",
                Price = 115.00,
                ImageSrc = "BurgerPhotos/1-hamburger_115.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Burgers,
                ExtraProductId = 26,
                Name = "Cheeseburger",
                Price = 120.00,
                ImageSrc = "BurgerPhotos/2-cheeseburger_120.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Burgers,
                ExtraProductId = 27,
                Name = "Double Cheeseburger",
                Price = 155.00,
                ImageSrc = "BurgerPhotos/3-double_cheeseburger_155.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Burgers,
                ExtraProductId = 28,
                Name = "Mega Double Cheeseburger",
                Price = 250.00,
                ImageSrc = "BurgerPhotos/4-mega_double_cheeseburger_250.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Burgers,
                ExtraProductId = 29,
                Name = "Meatball Burger",
                Price = 130.00,
                ImageSrc = "BurgerPhotos/5-kofteburger_130.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Burgers,
                ExtraProductId = 30,
                Name = "Double Meatball Burger",
                Price = 145.00,
                ImageSrc = "BurgerPhotos/6-double_kofteburger_145.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Burgers,
                ExtraProductId = 31,
                Name = "Whopper",
                Price = 170.00,
                ImageSrc = "BurgerPhotos/7-whopper_170.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Burgers,
                ExtraProductId = 32,
                Name = "Double Whopper",
                Price = 235.00,
                ImageSrc = "BurgerPhotos/8-double_whopper_235.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Burgers,
                ExtraProductId = 33,
                Name = "Triple Whopper",
                Price = 280.00,
                ImageSrc = "BurgerPhotos/9-triple_whopper_280.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Burgers,
                ExtraProductId = 34,
                Name = "Chicken Burger",
                Price = 100.00,
                ImageSrc = "BurgerPhotos/10-tavukburger_100.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Burgers,
                ExtraProductId = 35,
                Name = "King Chicken Burger",
                Price = 120.00,
                ImageSrc = "BurgerPhotos/11-king_chicken_burger_120.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Burgers,
                ExtraProductId = 36,
                Name = "Double King Chicken Burger",
                Price = 150.00,
                ImageSrc = "BurgerPhotos/12-double_king_chicken_150.png",
            },

            //Snacks
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Snacks,
                ExtraProductId = 37,
                Name = "French Fries Small",
                Price = 35.00,
                ImageSrc = "SnacksPhotos/1-patates_kucuk_35.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Snacks,
                ExtraProductId = 38,
                Name = "French Fries Medium",
                Price = 40.00,
                ImageSrc = "SnacksPhotos/2-patates_orta_40.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Snacks,
                ExtraProductId = 39,
                Name = "French Fries Large",
                Price = 45.00,
                ImageSrc = "SnacksPhotos/3-patates_buyuk_45.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Snacks,
                ExtraProductId = 40,
                Name = "Onion Rings (8 pieces)",
                Price = 35.00,
                ImageSrc = "SnacksPhotos/4-sogan-halkasi_8li_35.png",
            },
             new ExtraProduct
             {
                 Category = BurgerMVCProject.Domain.Enums.Category.Snacks,
                 ExtraProductId = 41,
                 Name = "Onion Rings (12 pieces)",
                 Price = 40.00,
                 ImageSrc = "SnacksPhotos/5-sogan-halkasi_12li_40.png",
             },
             new ExtraProduct
             {
                 Category = BurgerMVCProject.Domain.Enums.Category.Snacks,
                 ExtraProductId = 42,
                 Name = "Onion Rings (16 pieces)",
                 Price = 60.00,
                 ImageSrc = "SnacksPhotos/6-sogan-halkasi_16li_45.png",
             },
             new ExtraProduct
             {
                 Category = BurgerMVCProject.Domain.Enums.Category.Snacks,
                 ExtraProductId = 43,
                 Name = "Chicken Tenders (4 pieces)",
                 Price = 40.00,
                 ImageSrc = "SnacksPhotos/7-chicken-tenders_4lu_40.png",
             },
             new ExtraProduct
             {
                 Category = BurgerMVCProject.Domain.Enums.Category.Snacks,
                 ExtraProductId = 44,
                 Name = "Chicken Tenders (6 pieces)",
                 Price = 55.00,
                 ImageSrc = "SnacksPhotos/8-chicken-tenders_6li_55.png",
             },
             new ExtraProduct
             {
                 Category = BurgerMVCProject.Domain.Enums.Category.Snacks,
                 ExtraProductId = 45,
                 Name = "Chicken Tenders (9 pieces)",
                 Price = 70.00,
                 ImageSrc = "SnacksPhotos/9-chicken-tenders_9lu_70.png",
             },
             new ExtraProduct
             {
                 Category = BurgerMVCProject.Domain.Enums.Category.Snacks,
                 ExtraProductId = 46,
                 Name = "Nuggets (4 pieces)",
                 Price = 40.00,
                 ImageSrc = "SnacksPhotos/10-nuggets_4lu_40.png",
             },
             new ExtraProduct
             {
                 Category = BurgerMVCProject.Domain.Enums.Category.Snacks,
                 ExtraProductId = 47,
                 Name = "Nuggets (6 pieces)",
                 Price = 55.00,
                 ImageSrc = "SnacksPhotos/11-nuggets_6li_55.png",
             },
             new ExtraProduct
             {
                 Category = BurgerMVCProject.Domain.Enums.Category.Snacks,
                 ExtraProductId = 48,
                 Name = "Nuggets (9 pieces)",
                 Price = 70.00,
                 ImageSrc = "SnacksPhotos/12-nuggets_9lu_70.png",
             },


            //Sauces
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Sauces,
                ExtraProductId = 49,
                Name = "Ketchup",
                Price = 5.00,
                ImageSrc = "SaucesPhotos/1-ketcap_sos_5tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Sauces,
                ExtraProductId = 50,
                Name = "Mayonnaise",
                Price = 5.00,
                ImageSrc = "SaucesPhotos/2-mayonez_sos_5tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Sauces,
                ExtraProductId = 51,
                Name = "Garlic Mayonnaise",
                Price = 5.00,
                ImageSrc = "SaucesPhotos/3-sarimsakli_mayonez_sos_5tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Sauces,
                ExtraProductId = 52,
                Name = "Ranch Sauce",
                Price = 5.00,
                ImageSrc = "SaucesPhotos/4-ranch-sos_5tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Sauces,
                ExtraProductId = 53,
                Name = "Barbeque Sauce",
                Price = 5.00,
                ImageSrc = "SaucesPhotos/5-barbeku_sos_5tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Sauces,
                ExtraProductId = 54,
                Name = "Hot Sauce",
                Price = 5.00,
                ImageSrc = "SaucesPhotos/6-Aci_sos_5tl.png",
            },

            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Sauces,
                ExtraProductId = 55,
                Name = "Hot Mustard Sauce",
                Price = 5.00,
                ImageSrc = "SaucesPhotos/7-aci_hardal_sos_5tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Sauces,
                ExtraProductId = 56,
                Name = "Buffalo Sauce",
                Price = 5.00,
                ImageSrc = "SaucesPhotos/8-buffalo_sos_5tl.png",
            },

            //Desserts
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Desserts,
                ExtraProductId = 57,
                Name = "Chocolate Cookies",
                Price = 60.00,
                ImageSrc = "DessertPhotos/1-cikolatali-cookie_60tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Desserts,
                ExtraProductId = 58,
                Name = "Chocolate Chip Cookies",
                Price = 60.00,
                ImageSrc = "DessertPhotos/2-cikolata-parcacikli-cookie_60tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Desserts,
                ExtraProductId = 59,
                Name = "Apple Dessert",
                Price = 60.00,
                ImageSrc = "DessertPhotos/3-elmali-tatli-60tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Desserts,
                ExtraProductId = 60,
                Name = "Cherry Dessert",
                Price = 60.00,
                ImageSrc = "DessertPhotos/4-visneli-tatli-60tl.png",
            },
            new ExtraProduct
            {
                Category = BurgerMVCProject.Domain.Enums.Category.Desserts,
                ExtraProductId = 61,
                Name = "Souffle",
                Price = 70.00,
                ImageSrc = "DessertPhotos/5-sufle-70tl.png",
            }
            );

        }
    }
}
