using Microsoft.AspNetCore.Mvc;

namespace ProductManagement.Controllers
{
    public class AppoinmentController : Controller
    {
        public IActionResult Index()
        {
            //string todayDate = DateTime.Now.ToShortDateString();
            //return Ok(todayDate);

            return View();
        }

        public IActionResult UserId(int userId)
        {
            string display = string.Concat("Welcome user ",userId);
            return Ok(display);
        }
    }
}
