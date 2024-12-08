using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Mon
    {
        private string mamon;
        private string temmon;
        private int sotinchi;
        public string Mamon
        {
            get { return mamon; }
            set { mamon = value; }
        }
        public string Tenmon
        {
            get { return temmon; }
            set { temmon = value; }
        }
        public int Sotinchi
        {
            get { return sotinchi; }
            set { sotinchi = value; }
        }
        public Mon() { }
        public Mon(string mamon, string tenmon, int sotinchi)
        {
            this.mamon = mamon;
            this.temmon = tenmon;
            this.sotinchi = sotinchi;
        }
    }
}
