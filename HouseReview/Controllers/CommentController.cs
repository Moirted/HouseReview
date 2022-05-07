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
        public IActionResult Comment()
        {
            IEnumerable<Comment> objList = _db.Comments;
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
            return RedirectToAction("Comment");
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
                return View(objList);
            }
            else
            {
                IEnumerable<Comment> objList = _db.Comments.Where(x => (x.Adress == Adress));
                return View(objList);
            }
        }
    }
}
