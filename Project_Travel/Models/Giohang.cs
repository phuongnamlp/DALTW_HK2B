using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Project_Travel.Models;
using System.ComponentModel.DataAnnotations;

namespace Project_Travel.Models
{
    
    public class Giohang
    {
        MyDataDataContext data = new MyDataDataContext();

        public int MaTour { get; set; }
        [Display(Name = "Tour:")]
        public string TenTour { get; set; }
        [Display(Name = "Picture Tour")]
        public string Hinh { get; set; }
        [Display(Name = "Giá Người Lớn")]
        public Decimal GiaNguoiLon { get; set; }
        [Display(Name = "Giá Trẻ Em")]
        public Decimal GiaTreEm { get; set; }
        [Display(Name = "Số lượng vé Lớn")]
        public int iSoluonglon { get; set; }

        [Display(Name = "Số lượng vé Nhỏ")]
        public int iSoluongnho { get; set; }
        [Display(Name = "Thành tiền")]
        public Decimal dThanhtien
        {
            get { return (iSoluonglon * GiaNguoiLon) + (iSoluongnho * GiaTreEm); }
        }
        public Giohang(int MaTour)
        {
            this.MaTour = MaTour;
            Tour tour = data.Tours.Single(n => n.MaTour == MaTour);
            TenTour = tour.TenTour;
            Hinh = tour.Hinh;
            GiaNguoiLon = Decimal.Parse(tour.GiaNguoiLon.ToString());
            GiaTreEm = Decimal.Parse(tour.GiaTreEm.ToString());
            iSoluonglon = 0;
            iSoluongnho = 0;
        }
    }
}