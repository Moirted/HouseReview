using HouseReview.Areas.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using HouseReview.Models;
using System.Collections.Generic;
using System.Linq;

namespace HouseReview.Controllers
{
    public class CommentController : Controller
    {
        private readonly CommentsDBContext _db;
        public CommentController(CommentsDBContext db)
        {
            _db = db;
        }
        public IActionResult CommentRegions()
        {
            IEnumerable<Comment> objList = _db.Comments.Where(x => (x.Adress == "Пролетарский" ||
            x.Adress == "Кировский" ||
            x.Adress == "Советский" ||
            x.Adress == "Ворошиловский" ||
            x.Adress == "Железнодорожный" ||
            x.Adress == "Ленинский" ||
            x.Adress == "Октябрьский" ||
            x.Adress == "Первомайский"));
            objList = objList.OrderByDescending(x => x.CreationTime);
            return View(objList);
        }

        public IActionResult CommentHouses()
        {
            IEnumerable<Comment> objList = _db.Comments.Where(x => (x.Adress != "Пролетарский" &&
            x.Adress != "Кировский" &&
            x.Adress != "Советский" &&
            x.Adress != "Ворошиловский" &&
            x.Adress != "Железнодорожный" &&
            x.Adress != "Ленинский" &&
            x.Adress != "Октябрьский" &&
            x.Adress != "Первомайский"));
            objList = objList.OrderByDescending(x => x.CreationTime);
            return View(objList);
        }

        public IActionResult Create(string Adress)
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public IActionResult Create1(Comment obj)
        {
            _db.Comments.Add(obj);
            _db.SaveChanges();
           if (obj.Adress == "Пролетарский" || obj.Adress == "Кировский" || obj.Adress == "Советский" || obj.Adress == "Ворошиловский" ||
                obj.Adress == "Железнодорожный" || obj.Adress == "Ленинский" || obj.Adress == "Октябрьский" || obj.Adress == "Первомайский")
                return RedirectToAction("CommentRegions");
           else
                return RedirectToAction("CommentHouses");
        }

        public IActionResult House()
        {
            return View();
        }

        public IActionResult FindAdr()
        {
            return View();
        }

        public IActionResult Find(string Adress)
        {
            if (Adress != null)
            {
                IEnumerable<Comment> objList = _db.Comments.Where(x => (x.Adress.Contains(Adress)));
                objList = objList.OrderByDescending(x => x.CreationTime);
                return View(objList);
            }
            else
            {
                IEnumerable<Comment> objList = _db.Comments.Where(x => (x.Adress == Adress));
                objList = objList.OrderByDescending(x => x.CreationTime);
                return View(objList);
            }
        }
    }
}
