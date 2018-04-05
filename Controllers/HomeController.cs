using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicWorld.Models;

namespace MusicWorld.Controllers
{
    public class HomeController : Controller
    {
        MusicWorldEntities storeDB = new MusicWorldEntities();
        public ActionResult Index()
        {
            //get most populer albums
            var album = GetTopSellingAlbums(5);
            return View(album);
        }

       private List<Album> GetTopSellingAlbums(int count)
        {
            return storeDB.Albums
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}