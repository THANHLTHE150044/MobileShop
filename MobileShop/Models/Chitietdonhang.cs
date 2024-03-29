﻿using System;
using System.Collections.Generic;

#nullable disable

namespace MobileShop.Models
{
    public partial class Chitietdonhang
    {
        public int Madon { get; set; }
        public int Masp { get; set; }
        public int? Soluong { get; set; }
        public decimal? Dongia { get; set; }
        public decimal? Thanhtien { get; set; }
        public int? Thang { get; set; }
        public int? Nam { get; set; }
        public int Id { get; set; }

        public virtual Donhang MadonNavigation { get; set; }
        public virtual Sanpham MaspNavigation { get; set; }
    }
}
