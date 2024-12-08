using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public  class BUS_Diem
    {
        DAL_Diem dal = new DAL_Diem();
        public DataTable LoadCboLop()
        {
            return dal.LoadMALOP();
        }
        public DataTable LoadCboTenmon()
        {
            return dal.LoadTENMON();
        }
        public void Luudiem(Diem d)
        {
            dal.Luudiem(d);
        }
        public DataTable LayDS(string tenlop, string tenmon)
        {
            return dal.LayDanhsach(tenlop, tenmon);
        }
        public string Laymamon(string tenmon)
        {
            DataTable dtMon = dal.LoadTENMON();
            foreach (DataRow row in dtMon.Rows)
            {
                if (row["TENMON"].ToString() == tenmon)
                {
                    return row["MAMON"].ToString();
                }
            }

            return null;
        }
    }
}
