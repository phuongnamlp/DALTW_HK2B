using Project_Travel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Project_Travel.Areas.Admin.Controllers
{
    public class NguoiDungController : Controller
    {
        // GET: Admin/NguoiDung
        MyDataDataContext data = new MyDataDataContext();

        public object HoTen { get; private set; }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ListNguoiDung()
        {
            var all_kh = from ss in data.KhachHangs select ss;
            return View(all_kh);
        }
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(FormCollection collection, KhachHang kh)
        {
            var hoten = collection["HoTen"];
            var email = collection["Email"];
            var diachi = collection["DiaChi"];
            var dienthoai = collection["SDT"];
            var tendangnhap = collection["TenDangNhap"];
            var matkhau = collection["MatKhau"];
            var MatKhauXacNhan = collection["MatKhauXacNhan"];



            //var ngaysinh = String.Format("{0:MM/dd/yyyy}", collection["ngaysinh"]);
            if (String.IsNullOrEmpty(MatKhauXacNhan))
            {
                ViewData["NhapMKXN"] = "Phải nhập mật khẩu xác nhận!";
            }
            else
            {
                if (!matkhau.Equals(MatKhauXacNhan))
                {
                    ViewData["MatKhauGiongNhau"] = "Mật khẩu và mật khẩu xác nhận phải giống nhau";
                }
                else
                {
                    kh.HoTen = hoten;
                    kh.Email = email;
                    kh.DiaChi = diachi;
                    kh.SDT = dienthoai;
                    kh.TenDangNhap = tendangnhap;
                    kh.MatKhau = matkhau;
                    data.KhachHangs.InsertOnSubmit(kh);
                    data.SubmitChanges();

                    //return RedirectToAction("DangNhap");
                }
            }
            return this.DangKy();
        }
        //Delete
        public ActionResult Delete(int id)
        {
            var D_kh = data.KhachHangs.First(m => m.MaKH == id);
            return View(D_kh);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_kh = data.KhachHangs.Where(m => m.MaKH== id).First();
            data.KhachHangs.DeleteOnSubmit(D_kh);
            data.SubmitChanges();
            return RedirectToAction("ListNguoiDung");
        }
        //End
        // Details
        public ActionResult Detail(int id)
        {
            var D_kh = data.KhachHangs.Where(m => m.MaKH == id).First();
            return View(D_kh);
        }
        // End Details
        public ActionResult DangXuat()
        {
            Session.Clear();//remove session
            return RedirectToAction("NguoiDung");
            //return View("ListTour","Tour");


        }
    }
}