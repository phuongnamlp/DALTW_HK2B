using Project_Travel.Models;
using Project_WebDuLich.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Project_WebDuLich.Controllers
{
    public class GioHangController : Controller
    {
        // GET: GioHang
        TourDB data = new TourDB();
        public List<Giohang> LayGiohang()
        {
            List<Giohang> listGiohang = Session["Giohang"] as List<Giohang>;
            if (listGiohang == null)
            {
                listGiohang = new List<Giohang>();
                Session["Giohang"] = listGiohang;
            }
            return listGiohang;
        }
        public ActionResult ThemGiohang(int Matour, string strURL)
        {
            List<Giohang> listGiohang = LayGiohang();
            Giohang sanpham = listGiohang.Find(n => n.MaTour == Matour);
            if (sanpham == null)
            {
                sanpham = new Giohang(Matour);
                listGiohang.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.iSoluonglon++;
                sanpham.iSoluongnho++;
                return Redirect(strURL);
            }
        }
        private int TongSoluong()
        {
            int tong = 0;
            List<Giohang> listGiohang = Session["Giohang"] as List<Giohang>;
            if (listGiohang != null)
            {

                tong = listGiohang.Sum(n => n.iSoluonglon) + listGiohang.Sum(n => n.iSoluongnho);
            }
            return tong;
        }
        private int TongSoLuongSanPham()
        {
            int tong = 0;
            List<Giohang> listGiohang = Session["Giohang"] as List<Giohang>;
            if (listGiohang != null)
            {
                tong = listGiohang.Count;
            }
            return tong;
        }
        private double TongTien()
        {
            double tongtien = 0;
            List<Giohang> listGiohang = Session["Giohang"] as List<Giohang>;
            if (listGiohang != null)
            {
                tongtien = listGiohang.Sum(n => n.dThanhtien);
            }
            return tongtien;
        }
        public ActionResult Giohang()
        {
            List<Giohang> listGiohang = LayGiohang();
            ViewBag.Tongsoluong = TongSoluong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return View(listGiohang);
        }
        public ActionResult XoaGiohang(string tentour)
        {
            List<Giohang> listGiohang = LayGiohang();
            Giohang sanpham = listGiohang.SingleOrDefault(n => n.TenTour == tentour);
            if (sanpham != null)
            {
                listGiohang.RemoveAll(n => n.TenTour == tentour);
                return RedirectToAction("Giohang");
            }
            return RedirectToAction("Giohang");
        }

        public ActionResult CapnhatGiohang(int MaTour, FormCollection collection)
        {
            List<Giohang> lstGiohang = LayGiohang();
            Giohang sanpham = lstGiohang.SingleOrDefault(n => n.MaTour == MaTour);
            if (sanpham != null)
            {
                sanpham.iSoluonglon = int.Parse(collection["txtSolglon"].ToString());
                sanpham.iSoluongnho = int.Parse(collection["txtSolgnho"].ToString());
            }
            return RedirectToAction("Giohang");
        }

        public ActionResult XoaTatCaGiohang()
        {
            List<Giohang> listGiohang = LayGiohang();
            listGiohang.Clear();
            return RedirectToAction("Giohang");
        }
        public ActionResult DatHang()
        {
            try
            {
                DonHangDetail donhang = new DonHangDetail();
                List<Giohang> lstGiohang = LayGiohang();
                donhang.TongGia = (decimal?)(TongTien());
                data.DonHangDetails.Add(donhang);
                data.SaveChanges();
                XoaTatCaGiohang();
                TempData["msg"] = "<script>alert('Đặt hàng thành công ! Mã đơn hàng là : " + donhang.MaDH.ToString() + "');</script>";
                return RedirectToAction("Index", "Home");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Home");
            }

        }
    }
}