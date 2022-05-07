using Microsoft.AspNetCore.Mvc;
using HouseReview.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using HouseReview.Areas.Identity.Data;
using System.Collections.Generic;
using System.Linq;

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
        private readonly CommentsDBContext _db;
        public HomeController(CommentsDBContext db)
        {
            _db = db;
        }

        public IActionResult Comment()
        {
            IEnumerable<Comment> objList = _db.Comments;
            return View(objList);
        }

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
            IEnumerable<Comment> objList = _db.Comments.Where(x => (x.Adress == "Первомайский"));
            return View(objList);
        }

        public IActionResult Kirov()
        {
            IEnumerable<Comment> objList = _db.Comments.Where(x => (x.Adress == "Кировский"));
            return View(objList);
        }

        public IActionResult Lenin()
        {
            IEnumerable<Comment> objList = _db.Comments.Where(x => (x.Adress == "Ленинский"));
            return View(objList);
        }

        public IActionResult October()
        {
            IEnumerable<Comment> objList = _db.Comments.Where(x => (x.Adress == "Октябрьский"));
            return View(objList);
        }

        public IActionResult Railw()
        {
            IEnumerable<Comment> objList = _db.Comments.Where(x => (x.Adress == "Железнодорожный"));
            return View(objList);
        }

        public IActionResult Soviet()
        {
            IEnumerable<Comment> objList = _db.Comments.Where(x => (x.Adress == "Советский"));
            return View(objList);
        }

        public IActionResult Voroshil()
        {
            IEnumerable<Comment> objList = _db.Comments.Where(x => (x.Adress == "Ворошиловский"));
            return View(objList);
        }

        public IActionResult Prolet()
        {
            IEnumerable<Comment> objList = _db.Comments.Where(x => (x.Adress == "Пролетарский"));
            return View(objList);
        }

        public IActionResult Cadastr()
        {
            string url = "https://pkk.rosreestr.ru/#/search/" + HROptions.coords + "/17";
            return Redirect(url);
        }


        public IActionResult RentHouse()
        {
            string url = "https://realty.yandex.ru/rostov-na-donu/snyat/dom/?unifiedAddress=" + manageAdr(HROptions.adress);
            return Redirect(url);
        }

        public IActionResult BuyHouse()
        {
            string url = "https://realty.yandex.ru/rostov-na-donu/kupit/dom/?unifiedAddress=" + manageAdr(HROptions.adress);
            return Redirect(url);
        }


        public IActionResult RentFlat()
        {
            string url = "https://realty.yandex.ru/rostov-na-donu/snyat/kvartira/?unifiedAddress=" + manageAdr(HROptions.adress);
            return Redirect(url);
        }



        public IActionResult BuyFlat()
        {
            string url = "https://realty.yandex.ru/rostov-na-donu/kupit/kvartira/?unifiedAddress=" + manageAdr(HROptions.adress);
            return Redirect(url);
        }



        public IActionResult InputCoords(MapChoice mp)
        {
            HROptions.coords = mp.coords;
            HROptions.adress = mp.adress;
            return Redirect("House");
        }

        public static string manageAdr(string adr) {
            var arr = adr.Replace(", ",",").Split(",");
            string kom = "%2C%20";
            string sp = "%20";
            string res = "";
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == " ")
                {
                    res += sp;
                }
                else res += arr[i];
                if (i != adr.Length - 1) {
                    res += kom;
                }
            }
            return res;
        }
    }
}
