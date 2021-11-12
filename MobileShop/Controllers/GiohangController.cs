using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MobileShop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Controllers
{
    public class GiohangController : Controller
    {
        MobileShopContext db = new MobileShopContext();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserSession") == null)
            {
                return RedirectToAction("Login", "Users");
            }
            Nguoidung abc = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            Nguoidung user = db.Nguoidungs.SingleOrDefault(s => s.Email.Equals(abc.Email));


            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));

            int maND = user.MaNguoiDung;
            var giohang = db.Giohangs.Where(s => s.MaNguoiDung == maND);
            return View(giohang.ToList());
        }
        public IActionResult CapnhatGiohang(int Masp, int Soluong)
        {
            if (HttpContext.Session.GetString("UserSession") == null)
            {
                return RedirectToAction("Login", "Users");
            }
            Nguoidung abc = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            Nguoidung user = db.Nguoidungs.SingleOrDefault(s => s.Email.Equals(abc.Email));




            int maND = user.MaNguoiDung;
            Giohang gh = db.Giohangs.SingleOrDefault(n => n.Masp == Masp && n.MaNguoiDung == maND);


            gh = new Giohang();
            gh.Masp = Masp;
            gh.Dongia = (decimal)db.Sanphams.SingleOrDefault(n => n.Masp == Masp).Giatien;
            gh.Soluong = Soluong;
            gh.MaNguoiDung = maND;


            db.Update(gh);
            db.SaveChanges();


            return RedirectToAction("Index");
        }




        [HttpPost]
        public IActionResult ThemGioHang(int Ma)
        {
            if (HttpContext.Session.GetString("UserSession") == null)
            {
                return RedirectToAction("Login", "Users");
            }
            Nguoidung abc = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            Nguoidung user = db.Nguoidungs.SingleOrDefault(s => s.Email.Equals(abc.Email));




            int maND = user.MaNguoiDung;
            Giohang gh = db.Giohangs.SingleOrDefault(n => n.Masp == Ma && n.MaNguoiDung == maND);

            if (gh == null)
            {
                gh = new Giohang();
                gh.Masp = Ma;
                gh.Dongia = (decimal)db.Sanphams.SingleOrDefault(n => n.Masp == Ma).Giatien;
                gh.Soluong = 1;
                gh.MaNguoiDung = maND;


                db.Giohangs.Add(gh);
                db.SaveChanges();
            }
            else
            {
                gh.Soluong++;
                db.SaveChanges();

            }
            return RedirectToAction("Index");
        }
        public IActionResult XoaGioHang(int Masp)
        {
            if (HttpContext.Session.GetString("UserSession") == null)
            {
                return RedirectToAction("Login", "Users");
            }
            Nguoidung abc = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            Nguoidung user = db.Nguoidungs.SingleOrDefault(s => s.Email.Equals(abc.Email));




            int maND = user.MaNguoiDung;
            Giohang gh = db.Giohangs.SingleOrDefault(n => n.Masp == Masp && n.MaNguoiDung == maND);

            db.Giohangs.Remove(gh);
            db.SaveChanges();


            return RedirectToAction("Index");
        }
        public IActionResult DatHang(string? name,string? address , string? phone)
        {
            if (HttpContext.Session.GetString("UserSession") == null)
            {
                return RedirectToAction("Login", "Users");
            }
            Nguoidung abc = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            Nguoidung user = db.Nguoidungs.SingleOrDefault(s => s.Email.Equals(abc.Email));
            int maND = user.MaNguoiDung;
            Donhang dh = new Donhang();
            dh.MaNguoidung = maND;
            dh.Ngaydat = DateTime.Today;
            dh.Nguoinhan = name;
            dh.Tinhtrang = 1;
            dh.Sdt = phone;
            dh.Diachi = address;
            db.Donhangs.Add(dh);

            db.SaveChanges();
            List<Giohang> list = db.Giohangs.Where(s => s.MaNguoiDung == maND).ToList();
            foreach(Giohang item in list)
            {
                Chitietdonhang ct = new Chitietdonhang() {
                    Madon = dh.Madon,
                    Masp = item.Masp,
                    Soluong = item.Soluong,
                    Dongia = item.Dongia,
                    Thanhtien = item.Soluong * item.Dongia,
                    Thang = DateTime.Now.Month,
                    Nam = DateTime.Now.Year
                };
                db.Chitietdonhangs.Add(ct);
                db.SaveChanges();




            }
           

            



            return RedirectToAction("Index","Home");
        }

    }
}