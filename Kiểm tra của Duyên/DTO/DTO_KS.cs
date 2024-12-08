using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KS
    {
        private string Makh;
        private string Maphong;
        private string Ngayden;
        private string Ngaydi;
        public string makh
        { get { return Makh; } set { Makh = value; } }
        public string maphong
        { get { return Maphong; } set { Maphong = value; } }
        public string ngayden
        { get { return Ngayden; } set { Ngayden = value; } }
        public string ngaydi
        { get { return Ngaydi; } set { Ngaydi = value; } }

        public DTO_KS() { }
        public DTO_KS(string Makh,string Maphong,string Ngayden,string Ngaydi)
        {
            this.Makh = Makh;
            this.Maphong = Maphong;
            this.Ngayden = Ngayden;
            this.Ngaydi = Ngaydi;
        }
    }
}
