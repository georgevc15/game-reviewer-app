using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GameReviewer.Models;

namespace GameReviewer.Controllers
{
    public class ReviewController : Controller
    {
        [HttpGet]
        public ActionResult Create(string gameName)
        {
            ViewData["Game"] = gameName;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Review review, string gameName)
        {
            var game = Game.Read(gameName);
            game.AddGameReviewToGame(review);
            return RedirectToAction("Index", "Game");
        }

    }
}