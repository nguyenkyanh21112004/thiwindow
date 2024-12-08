using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_MON;
using DTO_MON;

namespace BUS_MON
{
    public class BUS_Mon
    {
        DAL_Mon dal = new DAL_Mon();
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
