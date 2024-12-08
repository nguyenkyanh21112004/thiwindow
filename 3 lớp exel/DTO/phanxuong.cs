using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class phanxuong
    {
        private string stt { get; set; }
        private string manv { get; set; }
        private string tennv { get; set; }
        private string ngaysinh  { get; set; }

        private string gioitinh {  get; set; }
        private string mapx { get; set; }
        private string tenpx { get; set; }
        private string soluong { get; set; }

        public string STT
        {
            get { return stt; }
            set { stt = value; }
        }
        public string Manv
        {
            get { return manv; }
            set { manv = value; }
        }
        public string Gioitinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        public string Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }
        public string Ngaysinh 
        {
            get { return ngaysinh ; }
            set { ngaysinh  = value; }
        }
        public string Mapx
        {
            get { return mapx; }
            set { mapx = value; }
        }
        public string Tenpx
        {
            get { return tenpx; }
            set { tenpx = value; }
        }
        public string Soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public phanxuong() { }
        public phanxuong(string manv, string tennv, string ngaysinh , string mapx, string gioitinh)
        {


            this.manv = manv;
            this.tennv = tennv;
            this.ngaysinh = ngaysinh;
            this.mapx = mapx;
            this.gioitinh = gioitinh;
            
        }
    }
}
