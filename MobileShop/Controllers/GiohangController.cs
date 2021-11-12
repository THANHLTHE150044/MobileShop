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
            var giohang = db.Giohangs.Where(s=>s.MaNguoiDung==maND);
            return View(giohang.ToList());
        }
    }
}
