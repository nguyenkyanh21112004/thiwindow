using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Lop
{
    public class BUS_Lop
    {
        DAL_Lop dal = new DAL_Lop();
        public DataTable LoadLop()
        {
            return dal.LoadDL();
        }
        public void Insert(Lop lop)
        {
            dal.Insert(lop);
        }
        public void Update(Lop lop)
        {
            dal.Update(lop);
        }
        public void Delete(Lop lop) 
        { 
            dal.Delete(lop); 
        }
    }
}
