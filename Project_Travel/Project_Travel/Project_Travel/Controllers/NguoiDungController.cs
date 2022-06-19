using Project_Travel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Project_Travel.Controllers
{
    public class NguoiDungController : Controller
    {
        // GET: NguoiDung
        // GET: NguoiDung
        MyDataDataContext data = new MyDataDataContext();
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

                    return RedirectToAction("DangNhap");
                }
            }
            return this.DangKy();
        }
        //Get MD5
        //create a string MD5
        public ActionResult Dangnhap()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Dangnhap(FormCollection userlog)
        {
            string tendangnhap = userlog["TenDangNhap"].ToString();
            string password = userlog["MatKhau"].ToString();
            var islogin = data.KhachHangs.SingleOrDefault(x => x.TenDangNhap.Equals(tendangnhap) && x.MatKhau.Equals(password));

            if (islogin != null)
            {
                if (tendangnhap == "namle")
                {
                    Session["use"] = islogin;
                    return RedirectToAction("Index", "Admin/Home");
                    
                }
                else
                {
                    Session["use"] = islogin;
                    return RedirectToAction("ListTour", "Tour");
                }
            }
            else
            {
                TempData["msg"] = "<script>alert('Đăng Nhập Thất Bại !';</script>";
                return View("Dangnhap");
            }
        }
        public ActionResult DangXuat()
        {
            Session.Clear();//remove session
            return RedirectToAction("DangNhap");

        }
        public ActionResult Index()
        {
            return View();
        }
    }
}