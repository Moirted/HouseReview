﻿using Microsoft.AspNetCore.Mvc;
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
    }
}
