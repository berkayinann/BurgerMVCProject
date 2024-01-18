using BurgerMVCProject.BLL.Services.Abstract;
using BurgerMVCProject.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCProject.UI.Controllers.Admin
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ExtraProductController : Controller
    {
        private readonly IExtraProductService extraProductService;
        public ExtraProductController(IExtraProductService extraProductService)
        {
            this.extraProductService = extraProductService;
        }

        public IActionResult Index()
        {
            List<ExtraProduct> extraProducts = extraProductService.GetEProducts();
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(ExtraProduct extraProduct)
        {
            extraProductService.AddEProduct(extraProduct);
            return RedirectToAction("Index");
        }

        public ActionResult Update(int eProductId)
        {
            extraProductService.GetByIdProduct(eProductId);
            return View();
        }

        [HttpPost]
        public IActionResult Update(ExtraProduct extraProduct)
        {
            extraProductService.UpdateEProduct(extraProduct);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int eProductId)
        {
            ExtraProduct extraProduct = extraProductService.GetByIdProduct(eProductId);
            extraProductService.DeleteEProduct(extraProduct);
            return RedirectToAction("Index");
        }
    }
}
