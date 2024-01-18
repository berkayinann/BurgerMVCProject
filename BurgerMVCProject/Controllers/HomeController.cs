using BurgerMVCProject.BLL.Services.Abstract;
using BurgerMVCProject.Domain.Entities;
using BurgerMVCProject.Models;
using BurgerMVCProject.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BurgerMVCProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExtraProductService eProductService;
        private readonly IMenuService menuService;
        private readonly IOrderService orderService;

        public static List<Menu> MenuList;

        public HomeController(IExtraProductService eProductService, IMenuService menuService, IOrderService orderService)
        {
            this.eProductService = eProductService;
            this.menuService = menuService;
            this.orderService = orderService;

            MenuList = new List<Menu>()
                {
                new Menu()
                {
                    MenuId=1,
                    Name="Burger",
                    Description="cheddarlı",
                    ImageSrc="~/MenuPhotos/b3.png",
                    //ExtraProducts=eProductService.GetEProducts()


                },
                new Menu()
                {
                    MenuId=2,
                    Name="Burger",
                    Description="cheddarlı",
                    ImageSrc="~/MenuPhotos/b3.png"
                },
                new Menu()
                {
                    MenuId=3,
                    Name="Burger",
                    Description="çift kaşarlı",
                    ImageSrc="~/MenuPhotos/b3.png"
                },

            };
        }
        public IActionResult Index()
        {
            return View(MenuList);
        }



        public IActionResult Privacy()
        {
            return View();
        }

    }
}
