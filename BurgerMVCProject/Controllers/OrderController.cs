using BurgerMVCProject.BLL.Services.Abstract;
using BurgerMVCProject.Controllers;
using BurgerMVCProject.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCProject.UI.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        private readonly IMenuService menuService;
        private readonly IExtraProductService eProdutService;

        public OrderController(IOrderService orderService, IMenuService menuService, IExtraProductService eProdutService)
        {
            this.orderService = orderService;
            this.menuService = menuService;
            this.eProdutService = eProdutService;
        }

        public IActionResult Index(int id,string name)
        {
            if (name.EndsWith("Menu"))
            {
                Menu menu = menuService.GetByIdMenu(id);
                return View(menu);

            }
            ExtraProduct product = eProdutService.GetByIdProduct(id);
            return View(product);

        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Order order)
        {
            orderService.AddOrder(order);
            return RedirectToAction("Index");
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
    }
}
