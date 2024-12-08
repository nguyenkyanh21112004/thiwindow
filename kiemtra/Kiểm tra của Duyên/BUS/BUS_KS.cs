using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BUS
{
    public class BUS_KS
    {
        DAL_KS dal= new DAL_KS();
        public DataTable BUS_loaddl()
        { return dal.DAL_loaddl(); }
        public void BUS_Them(DTO_KS kS)
        {  dal.DAL_them(kS); }
        public void BUS_Sua(DTO_KS kS)
        { dal.DAL_Sua(kS); }
        public void BUS_Xoa(DTO_makh kS)
        { dal.DAL_Xoa(kS); }
        public DataTable BUS_loadEX(DTO_makh kS)
        {
            return dal.DAL_LoadEX(kS);
        }   
    }
}
