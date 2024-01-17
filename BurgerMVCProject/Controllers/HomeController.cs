using BurgerMVCProject.BLL.Services.Abstract;
using BurgerMVCProject.Domain.Entities;
using BurgerMVCProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BurgerMVCProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IExtraProductService eProductService;
        private readonly IMenuService menuService;
        private readonly IOrderService orderService;

        public IActionResult Index()
        {
            List<Menu> menuList = new List<Menu>()
            {
                new Menu()
                {
                    MenuId=1,
                    Name="Burger",
                    Description="cheddarlı",
                    ImageSrc="~/MenuPhotos/b3.png"
                    
                   
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
            return View(menuList);
        }



        public IActionResult Privacy()
        {
            return View();
        }

    }
}
