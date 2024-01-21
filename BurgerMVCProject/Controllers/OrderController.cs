using BurgerMVCProject.BLL.Services.Abstract;
using BurgerMVCProject.Controllers;
using BurgerMVCProject.Domain.Entities;
using BurgerMVCProject.Domain.Enums;
using BurgerMVCProject.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BurgerMVCProject.UI.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly IMenuService menuService;
        private readonly IExtraProductService eProdutService;

        public static List<Menu> Menuler { get; private set; }
        public static List<ExtraProduct> ExtraProducts { get; private set; }

        public OrderController(IOrderService orderService, IMenuService menuService, IExtraProductService eProdutService)
        {
            this.orderService = orderService;
            this.menuService = menuService;
            this.eProdutService = eProdutService;
            Menuler = menuService.GetMenus();
            ExtraProducts = eProdutService.GetEProducts();
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
                ExtraProduct product = eProdutService.GetByIdProduct(id);
                Menu menu = menuService.GetByIdMenu(id);
            if (menu != null)
            {
                OrderVM orderVM = new();
                orderVM.MenuVM.Menus = GetMenus();
                orderVM.Product.Products = GetExtras();
                orderVM.MenuVM.MenuId=menu.MenuId;
                orderVM.MenuVM.Name = menu.Name;
                orderVM.MenuVM.ImageSRC = menu.ImageSrc;
                orderVM.MenuVM.Price = menu.Price;
                orderVM.MenuVM.Description = menu.Description;
                orderVM.MenuVM.Sizes = GetSizes();
                orderVM.Souces = GetSouces();
                orderVM.IsMenu = true;
                return View(orderVM);
            }
            
            OrderVM orderVM1 = new();
            orderVM1.Product.Products = GetExtras();
            orderVM1.MenuVM.Menus = GetMenus();
            orderVM1.Product.Name=product.Name;
            orderVM1.Product.ProductId = product.ExtraProductId;
            orderVM1.Product.ImageSRC = product.ImageSrc;
            orderVM1.Product.Price = product.Price;
            return View(orderVM1);
        }

        [HttpPost]
        public IActionResult Create(OrderVM orderVM)
        {


            return View();
        }


        public IActionResult Update(int orderId)
        {
            Order order = orderService.GetByIdOrder(orderId);
            return View(order);
        }

        [HttpPost]
        public IActionResult Update(Order order)
        {
            orderService.UpdateOrder(order);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int orderId)
        {
            Order order = orderService.GetByIdOrder(orderId);
            orderService.DeleteOrder(order);
            return RedirectToAction("Index");
        }

        public List<SelectListItem> GetSizes()
        {
            return menuService.GetMenus().Select(s => new SelectListItem { Value=s.Size.ToString() ,Text = s.Size.ToString() }).ToList() ;
        }

        public List<SelectListItem> GetExtras()
        {
            return eProdutService.GetEProducts()
            .Where(s => s.Category == Category.Snacks && s.Category == Category.Burgers)
            .Select(s => new SelectListItem { Value = s.ExtraProductId.ToString(), Text = s.Name })
            .ToList();
        }

        public List<SelectListItem> GetMenus()
        {
            return menuService.GetMenus().Select(s => new SelectListItem { Value = s.MenuId.ToString(), Text = s.Name })
            .ToList();
        }

        public List<SelectListItem> GetSouces()
        {
            return eProdutService.GetEProducts()
            .Where(s => s.Category == Category.Sauces )
            .Select(s => new SelectListItem { Value = s.Category.ToString(), Text = s.Category.ToString() })
            .ToList();
        }

    }
}
