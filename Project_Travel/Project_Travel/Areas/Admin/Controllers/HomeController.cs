using Project_Travel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_Travel.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();
        // GET: Admin/Home
        public ActionResult Index()
        {
            var all_Tour = from s in data.Tours select s;
            return View(all_Tour);
        }
        // Create
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
                return RedirectToAction("Index");
            }
            return this.Create();
        }
        //End
        public ActionResult Detail(int id)
        {
            var all_tour = data.Tours.Where(m => m.MaTour == id).First();
            return View(all_tour);
        }
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
            return RedirectToAction("Index");
        }
        //Edit
        public ActionResult Edit(int id)
        {
            var E_tour = data.Tours.First(m => m.MaTour == id);
            return View(E_tour);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var E_matour = data.Tours.First(m => m.MaTour == id);
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


            E_matour.MaTour = id;

            if (string.IsNullOrEmpty(E_tentour))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                E_tentour = E_tentour;
                E_hinh = E_hinh.ToString();
                E_gia = E_gia;
                E_ngaykhoihanh = E_ngaykhoihanh.ToString();
                E_phuongtien = E_phuongtien.ToString();
                E_songaydi = E_songaydi.ToString();
                E_hoteltieuchuan = E_hoteltieuchuan;
                E_gianguoilon = E_gianguoilon;
                E_giatreem = E_giatreem;
                E_ghichu = E_ghichu.ToString();

                UpdateModel(E_matour);
                data.SubmitChanges();
                return RedirectToAction("Index");
            }
            return this.Edit(id);
        }
        //Edn Edit
        public string ProcessUpload(HttpPostedFileBase file)
        {
            if (file == null)
            {
                return "";
            }
            file.SaveAs(Server.MapPath("~/Content/images/" + file.FileName));
            return "/Content/images/" + file.FileName;
        }
        public ActionResult DangXuat()
        {
            Session["use"] = null;
            return RedirectToAction("ListTour", "Tour");

        }
    }
}