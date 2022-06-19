using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Travel.Areas.Admin.Controllers
{
    public class NguoiDungController : Controller
    {
        // GET: Admin/NguoiDung
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DangXuat()
        {
            Session["use"] = null;
            return RedirectToAction("ListTour", "Tour");

        }
    }
}