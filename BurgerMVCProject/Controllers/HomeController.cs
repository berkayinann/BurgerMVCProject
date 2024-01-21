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

        public HomeController(IExtraProductService eProductService, IMenuService menuService, IOrderService orderService)
        {
            this.eProductService = eProductService;
            this.menuService = menuService;
            this.orderService = orderService;
        }
        public IActionResult Index()
        {
            List<Menu> Menus = menuService.GetMenus();
            return View(Menus);
        }

        public IActionResult Products()
        {
            List<ExtraProduct> extraProducts = eProductService.GetEProducts();
            return View(extraProducts);
        }


        public IActionResult Privacy()
        {
            return View();
        }

    }
}
