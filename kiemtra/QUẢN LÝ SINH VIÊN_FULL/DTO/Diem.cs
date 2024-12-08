using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Diem
    {
        private string masv;
        private string mamon;
        private float diem;
        public string Masv
        {
            get { return masv; }
            set { masv = value; }
        }
        public string Mamon
        {
            get { return mamon; }
            set { mamon = value; }
        }
        public float d
        {

            get { return diem; }
            set { diem = value; }
        }
        public Diem() { }
        public Diem(string masv, string mamon, float diem)
        {
            this.masv = masv;
            this.mamon = mamon;
            this.diem = diem;
        }
    }
}
