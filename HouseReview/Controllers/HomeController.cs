using Microsoft.AspNetCore.Mvc;
namespace HouseReview.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult House()
        {
            return View();
        }
    }
}
