using System;
using System.Collections.Generic;

#nullable disable

namespace MobileShop.Models
{
    public partial class Donhang
    {
        public int Madon { get; set; }
        public DateTime? Ngaydat { get; set; }
        public int? Tinhtrang { get; set; }
        public int? MaNguoidung { get; set; }
        public string Nguoinhan { get; set; }
        public string Diachi { get; set; }
        public string Sdt { get; set; }

        public virtual Nguoidung MaNguoidungNavigation { get; set; }
    }
}
