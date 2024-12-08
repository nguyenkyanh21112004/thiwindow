using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Sinhvien;
using DTO_Sinhvien;

namespace BUS_SV
{
    public class BUS_Sinhvien
    {
        DAL_Sv dal = new DAL_Sv();
        public DataTable LayDL()
        {
            return dal.LoadDL();
        }
        public DataTable LayMalop()
        {
            return dal.LoadMalop();
        }
        public void Insert(Sinhvien sv)
        {
            dal.Insert(sv);
        }
        public void Update(Sinhvien sv)
        {
            dal.Update(sv);
        }
        public void Delete(Sinhvien sv)
        {
            dal.Delete(sv);
        }
    }
}
