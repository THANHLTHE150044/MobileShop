using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace MobileShop.Models
{
    public partial class Nguoidung
    {
        public Nguoidung()
        {
            Donhangs = new HashSet<Donhang>();
            Giohangs = new HashSet<Giohang>();
        }

        public int MaNguoiDung { get; set; }
        public string Hoten { get; set; }
        public string Email { get; set; }
        public string Dienthoai { get; set; }
        public string Matkhau { get; set; }
        public int? Idquyen { get; set; }
        public string Diachi { get; set; }

        public virtual PhanQuyen IdquyenNavigation { get; set; }
        public virtual ICollection<Donhang> Donhangs { get; set; }
        public virtual ICollection<Giohang> Giohangs { get; set; }
        [NotMapped]
        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Matkhau")]
        public string NhaplaiMatkhau { get; set; }
    }

}
