using Microsoft.AspNetCore.Mvc;
using HouseReview.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace HouseReview.Controllers
{
    [Authorize]
    public class HomeController:Controller
    {
		//[HttpGet]
  //      public IActionResult CreateUser() => View();
		//[HttpPost]
  //      public async Task<IActionResult> CreateUser(CreateUser model) {
  //          if (ModelState.IsValid)
  //          {
  //              return RedirectToAction("Index");
  //          }
  //          else return View();
		//}
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Info()
        {
            return View();
        }

        public IActionResult House()
        {
            return View();
        }

        public IActionResult Regions()
        {
            return View();
        }

        public IActionResult Firstm()
        {
            return View();
        }

        public IActionResult Kirov()
        {
            return View();
        }

        public IActionResult Lenin()
        {
            return View();
        }

        public IActionResult October()
        {
            return View();
        }

        public IActionResult Railw()
        {
            return View();
        }

        public IActionResult Soviet()
        {
            return View();
        }

        public IActionResult Voroshil()
        {
            return View();
        }

        public IActionResult Prolet()
        {
            return View();
        }
    }
}
