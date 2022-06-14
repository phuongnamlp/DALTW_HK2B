using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Travel.Models;

namespace Project_Travel.Controllers
{
    public class TourController : Controller
    {
        // GET: Tour
        MyDataDataContext data = new MyDataDataContext();  
        public ActionResult ListTour()
        {
            var all_tour = from ss in data.Tours select ss;
            return View(all_tour);
        }
        public ActionResult Detail(int id)
        {
            var D_banggia = data.Tours.Where(m => m.MaTour == id).First();
            return View(D_banggia);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, Tour t)
        {
            var E_tentour = collection["TenTour"];
            var E_gia = Convert.ToDecimal(collection["Gia"]);
            var E_hinh = collection["Hinh"];
            var E_ngaykhoihanh = collection["NgayKhoiHanh"];
            var E_phuongtien = collection["PhuongTien"];
            var E_songaydi = collection["SoNgayDi"];
            var E_hotel_tieuchuan = Convert.ToInt32(collection["Hotel_TieuChuan"]);
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
                t.Gia = E_gia;
                t.Hinh = E_hinh.ToString();
                t.NgayKhoiHanh = E_ngaykhoihanh.ToString();
                t.PhuongTien = E_phuongtien.ToString();
                t.SoNgayDi = E_songaydi.ToString();
                t.Hotel_TieuChuan = E_hotel_tieuchuan;
                t.GiaNguoiLon = E_gianguoilon;
                t.GiaTreEm = E_gianguoilon;
                t.GhiChu = E_ghichu;
                data.Tours.InsertOnSubmit(t);
                data.SubmitChanges();
                return RedirectToAction("ListTour");
            }
            return this.Create();
        }
    }
}