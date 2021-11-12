using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MobileShop.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileShop.Controllers
{
    public class DonhangController : Controller
    {
        MobileShopContext context = new MobileShopContext();
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("UserSession") == null)
            {
                return RedirectToAction("Login", "Users");
            }
            Nguoidung abc = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            Nguoidung user = context.Nguoidungs.SingleOrDefault(s => s.Email.Equals(abc.Email));

            
            if (HttpContext.Session.GetString("UserSession") != null)
                TempData["User"] = JsonConvert.DeserializeObject<Nguoidung>(HttpContext.Session.GetString("UserSession"));
            
            int maND = user.MaNguoiDung;
            var donhangs = context.Donhangs.Include(d => d.MaNguoidungNavigation).Where(d => d.MaNguoidung == maND);
            return View(donhangs.ToList());
        }
        public ActionResult Details(int? id)
        {

            Donhang donhang = context.Donhangs.Find(id);
            var chitiet = context.Chitietdonhangs.Include(d => d.MaspNavigation).Where(d => d.Madon == id).ToList();
            return View(chitiet);
        }
    }
}
