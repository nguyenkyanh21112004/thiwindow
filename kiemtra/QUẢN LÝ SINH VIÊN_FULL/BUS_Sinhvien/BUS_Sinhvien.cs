using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Sinhvien;
using DTO_Sinhvien;
namespace BUS_Sinhvien
{
    
    public class BUS_Sv
    {
      DAL_Sv dal = new DAL_Sv();
        public DataTable LayDL()
        {
            return dal.LoadDL();
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
