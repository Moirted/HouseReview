using HouseReview.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

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


        [HttpGet]
        public IActionResult CreateUser() => View();

        [HttpPost]
        public async Task<IActionResult> CreateUser(CreateUser model) {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else return View();
        }
    }
}
