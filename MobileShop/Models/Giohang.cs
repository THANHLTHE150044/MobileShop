using System;
using System.Collections.Generic;

#nullable disable

namespace MobileShop.Models
{
    public partial class Giohang
    {
        public int Masp { get; set; }
        public decimal Dongia { get; set; }
        public int Soluong { get; set; }
        public int MaNguoiDung { get; set; }

        public virtual Nguoidung MaNguoiDungNavigation { get; set; }
        public virtual Sanpham MaspNavigation { get; set; }
    }
}
