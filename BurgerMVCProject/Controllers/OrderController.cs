using BurgerMVCProject.BLL.Services.Abstract;
using BurgerMVCProject.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCProject.UI.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderService orderService;
        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }

        public IActionResult Index()
        {
            List<Order> orders = orderService.GetOrders().ToList();
            return View(orders);
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
