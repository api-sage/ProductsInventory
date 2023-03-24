using Microsoft.AspNetCore.Mvc;

namespace ProductInventoryMgt.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
