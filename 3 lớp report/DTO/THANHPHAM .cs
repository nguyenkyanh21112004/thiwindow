using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class THANHPHAM
    {
        public string MaSP { get; set; }
        public string MaNV { get; set; }
        public string NgayThanhPham { get; set; }
        public string SoLuongNop { get; set; }



        public THANHPHAM() { }
        public THANHPHAM(string MaSP, string MaNV, string NgayThanhPham, string SoLuongNop)
        {
            this.MaSP = MaSP;
            this.MaNV = MaNV;
            this.NgayThanhPham = NgayThanhPham;
            this.SoLuongNop = SoLuongNop;



        }
    }
}
