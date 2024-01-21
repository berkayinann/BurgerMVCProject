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
                orderVM.Id = id;
                orderVM.MenuVM.MenuId = id;
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
            orderVM1.Id = id;
            orderVM1.Product.ProductId = id;
            orderVM1.Product.Name=product.Name;
            orderVM1.Product.ProductId = product.ExtraProductId;
            orderVM1.Product.ImageSRC = product.ImageSrc;
            orderVM1.Product.Price = product.Price;
            return View(orderVM1);


        }

        [HttpPost]
        public IActionResult Create(OrderVM orderVM)
        {

            ExtraProduct product = eProdutService.GetByIdProduct(orderVM.Id);
            Menu menu = menuService.GetByIdMenu(orderVM.Id);

            if (menu != null)
            {
                Order or = new();
               

                or.CreatedDate = DateTime.Now;

                Menu menu1 = new();
                menu1.MenuId = orderVM.Id;
                menu1.Quantity = orderVM.MenuVM.Quantity;
                var result1 = int.TryParse(orderVM.MenuVM.Size, out int result);
                if (result1)
                    menu1.Size = (Size)result;
                menu1.Price = orderVM.MenuVM.Price;
                menu1.CreatedDate = DateTime.Now;

                or.Menus.Add(menu1);

                bool isAdded = orderService.AddOrder(or);


                if (isAdded)
                {

                    TempData["SuccessMessage"] = "Öğrenci başarıyla eklendi!";
                    return RedirectToAction("Index");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Öğrenci eklenirken bir hata oluştu. Lütfen tekrar deneyin.");
                    return View();
                }

            }

            //Order or2 = new();

            //or2.CreatedDate = DateTime.Now;

            //ExtraProduct menu2 = new();
            //menu2.MenuId = orderVM.Id;
            //menu2.Quantity = orderVM.MenuVM.Quantity;
            //var result1 = int.TryParse(orderVM.MenuVM.Size, out int result);
            //if (result1)
            //    menu1.Size = (Size)result;
            //menu1.Price = orderVM.MenuVM.Price;
            //menu1.CreatedDate = DateTime.Now;

            //or.Menus.Add(menu1);

            //bool isAdded = orderService.AddOrder(or);


            //if (isAdded)
            //{

            //    TempData["SuccessMessage"] = "Öğrenci başarıyla eklendi!";
            //    return RedirectToAction("Orders");
            //}
            //else
            //{
            //    ModelState.AddModelError(string.Empty, "Öğrenci eklenirken bir hata oluştu. Lütfen tekrar deneyin.");
            //    return View();
            //}


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
            .Select(s => new SelectListItem { Value = s.ExtraProductId.ToString(), Text = s.Name })
            .ToList();
        }

    }
}
