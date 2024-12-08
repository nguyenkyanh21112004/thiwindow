using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace CSDL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ThaotacCSDL" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ThaotacCSDL.svc or ThaotacCSDL.svc.cs at the Solution Explorer and start debugging.
    public class ThaotacCSDL : IThaotacCSDL
    {
        BUS_Lop bus = new BUS_Lop();
        public void Insert(Lop lop)
        {
            bus.Insert(lop);
        }
        public void Update(Lop lop)
        {
            bus.Update(lop);
        }
        public void Delete(Lop lop)
        {
            bus.Delete(lop);
        }
        public List<Lop> Load()
        {
            // Chuyển đổi từ DataTable sang List<Lop>
            List<Lop> lstLop = new List<Lop>();
            DataTable dt = bus.LoadLop();

            foreach (DataRow row in dt.Rows)
                {
                    Lop lop = new Lop
                    {
                        Malop = row[0].ToString(),
                        Tenlop = row[1].ToString()
                    };
                lstLop.Add(lop);
            }

            return lstLop;
        }
    }
}
