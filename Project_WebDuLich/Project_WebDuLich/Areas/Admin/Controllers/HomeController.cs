using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_WebDuLich.Context;

namespace Project_WebDuLich.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        TourDB data = new TourDB();
        // GET: Admin/Product
        public ActionResult Index()
        {
            var lstTour = data.Tours.ToList();
            return View(lstTour);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, Tour t)
        {
            var E_tentour = collection["TenTour"];
            var E_hinh = collection["Hinh"];
            var E_gia = Convert.ToDecimal(collection["Gia"]);
            var E_ngaykhoihanh = collection["NgayKhoiHanh"];
            var E_phuongtien = collection["PhuongTien"];
            var E_songaydi = collection["SoNgayDi"];
            var E_hotel = Convert.ToInt32(collection["Hotel_TieuChuan"]);
            var E_gianguoilon = Convert.ToDecimal(collection["GiaNguoiLon"]);
            var E_giatreem = Convert.ToDecimal(collection["GiaTreEm"]);
            var E_ghichu = collection["GhiChu"];
            if (string.IsNullOrEmpty(E_tentour))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                t.TenTour = E_tentour.ToString();
                t.Hinh = E_hinh.ToString();
                t.Gia = E_gia;
                t.NgayKhoiHanh = E_ngaykhoihanh.ToString();
                t.PhuongTien = E_phuongtien.ToString();
                t.SoNgayDi = E_songaydi.ToString();
                t.Hotel_TieuChuan = E_hotel;
                t.GiaNguoiLon = E_gianguoilon;
                t.GiaTreEm = E_giatreem;
                t.GhiChu = E_ghichu;
                data.Tours.Add(t);
                data.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var D_tour = data.Tours.First(m => m.MaTour == id);
            return View(D_tour);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            TourDB data = new TourDB();
            Tour dbDelete = data.Tours.FirstOrDefault(p => p.MaTour == id);
            if (dbDelete != null)
            {
                data.Tours.Remove(dbDelete);
                data.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var E_tour = data.Tours.FirstOrDefault(m => m.MaTour == id);
            return View(E_tour);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection, Tour t)
        {
            var E_tour = data.Tours.FirstOrDefault(m => m.MaTour == id);
            var E_tentour = collection["TenTour"];
            var E_hinh = collection["Hinh"];
            var E_gia = Convert.ToDecimal(collection["Gia"]);
            var E_ngaykhoihanh = collection["NgayKhoiHanh"];
            var E_phuongtien = collection["PhuongTien"];
            var E_songaydi = collection["SoNgayDi"];
            var E_hotel = Convert.ToInt32(collection["Hotel_TieuChuan"]);
            var E_gianguoilon = Convert.ToDecimal(collection["GiaNguoiLon"]);
            var E_giatreem = Convert.ToDecimal(collection["GiaTreEm"]);
            var E_ghichu = collection["GhiChu"];
            if (string.IsNullOrEmpty(E_tentour))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                t.TenTour = E_tentour.ToString();
                t.Hinh = E_hinh.ToString();
                t.Gia = E_gia;
                t.NgayKhoiHanh = E_ngaykhoihanh.ToString();
                t.PhuongTien = E_phuongtien.ToString();
                t.SoNgayDi = E_songaydi.ToString();
                t.Hotel_TieuChuan = E_hotel;
                t.GiaNguoiLon = E_gianguoilon;
                t.GiaTreEm = E_giatreem;
                t.GhiChu = E_ghichu;
                data.Tours.AddOrUpdate(t);
                data.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public string ProcessUpload(HttpPostedFileBase file)
        {
            if (file == null)
            {
                return "";
            }
            file.SaveAs(Server.MapPath("~/Content/img/" + file.FileName));
            return "/Content/img/" + file.FileName;
        }
    }
}
