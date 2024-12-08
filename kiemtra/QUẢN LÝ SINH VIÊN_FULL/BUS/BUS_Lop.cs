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
    public class BUS_Lop
    {
        DAL_Lop dal = new DAL_Lop();
        public DataTable LoadLop()
        {
            return dal.LoadDL();
        }
        public bool  Insert(Lop lop)
        {
            return dal.Insert(lop);
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
