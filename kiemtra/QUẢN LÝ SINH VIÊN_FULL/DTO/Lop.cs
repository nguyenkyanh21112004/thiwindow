using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Lop
    {
        private string malop;
        private string tenlop;
        public string Malop
        {
            get { return malop; }
            set { malop = value; }
        }
        public string Tenlop
        {
            get { return tenlop; }
            set { tenlop = value; }
        }
        public Lop() { }
        public Lop(string malop, string tenlop)
        {
            this.malop = malop;
            this.tenlop = tenlop;
        }
    }
}
