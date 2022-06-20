using Project_WebDuLich.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Project_WebDuLich.Controllers
{
    public class HomeController : Controller
    {
        TourDB data = new TourDB();
        public ActionResult Index()
        {
            var lstTour = data.Tours.ToList();
            return View(lstTour);
        }
        public ActionResult Register()
        {
            return View();
        }
        //POST: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(KhachHang kh)
        {
            if (ModelState.IsValid)
            {
                var check = data.KhachHangs.FirstOrDefault(s => s.Email == kh.Email);
                if (check == null)
                {
                    kh.MatKhau = GetMD5(kh.MatKhau);
                    data.Configuration.ValidateOnSaveEnabled = false;
                    data.KhachHangs.Add(kh);
                    data.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
                else
                {
                    ViewBag.error = "Email already exists";
                    return View();
                }          
            return View("Index");
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        /*public ActionResult Login(string email, string matkhau)
        {
                var f_password = GetMD5(matkhau);
                var dt = data.KhachHangs.Where(s => s.Email.Equals(email) && s.MatKhau.Equals(f_password)).ToList();
            if (dt.Count() > 0)
            {
                if (email == "namle")
                {
                    return RedirectToAction("Index", "Admin/Home");

                }
                //add session
                *//*                    Session["HoTen"] = dt.FirstOrDefault().HoTen;
                                    Session["Email"] = dt.FirstOrDefault().Email;
                                    Session["IsAdmin"] = dt.FirstOrDefault().IsAdmin;
                                    TempData["msg"] = "<script>alert('Đăng Nhập Thành Công');</script>";
                                    return RedirectToAction("Index", "Home");*//*
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                TempData["msg"] = "<script>alert('Đăng Nhập Thất Bại !';</script>";
                return View("Login");
            }
        }       */
        public ActionResult Login(string email, string matkhau)
        {
            var f_password = GetMD5(matkhau);
            var islogin = data.KhachHangs.Where(x => x.Email.Equals(email) && x.MatKhau.Equals(f_password));

            if (islogin != null)
            {
                if (email == "namle123@gmail.com")
                {
                    Session["use"] = islogin;
                    return RedirectToAction("Index", "Admin/Home");

                }
                else
                {
                    Session["use"] = islogin;
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                TempData["msg"] = "<script>alert('Đăng Nhập Thất Bại !';</script>";
                return View("Login");
            }
        }

            //create a string MD5
            public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");
            }
            return byte2String;
        }
        //Logout
        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("Login");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}