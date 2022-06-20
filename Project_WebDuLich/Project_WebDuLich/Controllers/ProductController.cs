using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_WebDuLich.Context;

namespace Project_WebDuLich.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        TourDB data = new TourDB(); 
        public ActionResult Detail(int id)
        {
            var thistour = data.Tours.Where(n => n.MaTour == id).First();
            return View(thistour);
        }
    }
}