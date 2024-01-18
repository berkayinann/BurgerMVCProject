using Microsoft.AspNetCore.Mvc;

namespace BurgerMVCProject.UI.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
