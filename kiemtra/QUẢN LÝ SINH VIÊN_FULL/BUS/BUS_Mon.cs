using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BUS
{
    public class BUS_Mon
    {
        DAL_MON dal = new DAL_MON();
        public DataTable LoadMon()
        {
            return dal.LoadDL();
        }
        public void Insert(Mon mon)
        {
            dal.Insert(mon);
        }
        public void Update(Mon mon)
        {
            dal.Update(mon);
        }
        public void Delete(Mon mon)
        {
            dal.Delete(mon);
        }
    }
}
