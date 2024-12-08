using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BUS
{
    public class BUS_Sinhvien
    {
        DAL_SINHVIEN dal = new DAL_SINHVIEN();
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
