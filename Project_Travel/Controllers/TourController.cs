using Project_Travel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Travel.Controllers
{
    public class TourController : Controller
    {
        // GET: Tour
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListTour()
        {
            var all_tour = from ss in data.Tours select ss;
            return View(all_tour);
        }
        public ActionResult Detail(int id)
        {
            var all_tour = data.Tours.Where(m => m.MaTour == id).First();
            return View(all_tour);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, Tour t)
        {
            var E_matour = collection["MaTour"];
            var E_tentour = collection["TenTour"];
            var E_hinh = collection["Hinh"];
            var E_gia = Convert.ToDecimal(collection["Gia"]);
            var E_ngaykhoihanh = collection["NgayKhoiHanh"];
            var E_phuongtien = collection["PhuongTien"];
            var E_songaydi = collection["SoNgayDi"];
            var E_hoteltieuchuan = Convert.ToInt32(collection["Hotel_TieuChuan"]);
            var E_gianguoilon = Convert.ToDecimal(collection["GiaNguoiLon"]);
            var E_giatreem = Convert.ToDecimal(collection["GiaTreEm"]);
            var E_ghichu = collection["GhiChu"];


            if (string.IsNullOrEmpty(E_tentour))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                t.TenTour = E_tentour;
                t.Hinh = E_hinh.ToString();
                t.Gia = E_gia;
                t.NgayKhoiHanh = E_ngaykhoihanh.ToString();
                t.PhuongTien = E_phuongtien.ToString();
                t.SoNgayDi = E_songaydi.ToString();
                t.Hotel_TieuChuan = E_hoteltieuchuan;
                t.GiaNguoiLon = E_gianguoilon;
                t.GiaTreEm = E_giatreem;
                t.GhiChu = E_ghichu.ToString();

                data.Tours.InsertOnSubmit(t);
                data.SubmitChanges();
                return RedirectToAction("ListTour");
            }
            return this.Create();
        }
        //Delete
        public ActionResult Delete(int id)
        {
            var D_tour = data.Tours.First(m => m.MaTour == id);
            return View(D_tour);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_tour = data.Tours.Where(m => m.MaTour == id).First();
            data.Tours.DeleteOnSubmit(D_tour);
            data.SubmitChanges();
            return RedirectToAction("ListTour");
        }
        //End DElete
        public string ProcessUpload(HttpPostedFileBase file)
        {
            if (file == null)
            {
                return "";
            }
            file.SaveAs(Server.MapPath("~/Content/images/" + file.FileName));
            return "/Content/images/" + file.FileName;
        }
    }
}