using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicWorld.Models;

namespace MusicWorld.Controllers
{
    public class StoreController : Controller
    {
        MusicWorldEntities storeDB = new MusicWorldEntities();
        // GET: Store
        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();

            return View(genres);
        }

        public ActionResult Browse(string genre)
        {
            var genreModel = storeDB.Genres.Include("Albums")
                .Single(g => g.Name == genre);

            return View(genreModel);

        }


        public ActionResult Details(int Id)
        {
            var album = storeDB.Albums.Find(Id);

            return View(album);
        }
        [ChildActionOnly]
        public ActionResult GenreMenu()
        {
            var genres = storeDB.Genres.ToList();

            return PartialView(genres);
        } 
    }
}