using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Incredibles" };

            //return View(movie);

            //return Content("Test message to test Content ActionResult type");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new { code = 1, sortby = "age" });
            return new EmptyResult();
        }

        public ActionResult Edit(int moviesId)
        {
            return Content($"Url parameter is {moviesId}");
        }

        public ActionResult Index(int? pageIndex, string category)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(category))
                category = "main";

            return Content($"Parameters values are PageIndex : {pageIndex}, Category : {category}.");
        }

        public ActionResult Search(int year, short month)
        {
            return Content($"Search parameters are year {year}, month {month}");
        }
          
    }
}