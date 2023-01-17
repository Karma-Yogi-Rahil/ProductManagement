using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
