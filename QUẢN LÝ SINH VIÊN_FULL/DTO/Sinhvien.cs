using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sinhvien
    {
        private string masv;
        private string hoten;
        private DateTime ngaysinh;
        private string malop;
        public string Masv
        {
            get { return masv; }
            set { masv = value; }
        }
        public string Hoten
        {
            get { return hoten; }
            set { hoten = value; }
        }
        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public string Malop
        {
            get { return malop; }
            set { malop = value; }
        }
        public Sinhvien() { }
        public Sinhvien(string masv, string hoten, DateTime ngaysinh, string malop)
        {
            this.malop = malop;
            this.masv = masv;
            this.ngaysinh = ngaysinh;
            this.hoten = hoten;
        }
    }
}
