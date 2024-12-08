using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_makh
    {
       private string Makh;
        public string makh
        {   
            get { return Makh; }
            set { Makh = value; }
        }
        public DTO_makh() { }
        public DTO_makh(string Makh)
        {
            this.Makh = Makh;
        }
    }
}
