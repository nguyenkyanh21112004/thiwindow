using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;


namespace BUS
{
    public class THANHPHAM_Bus
    {
        THANHPHAM_DAL thanhpham = new THANHPHAM_DAL();
        public DataTable Load_Bus()
        {
            return thanhpham.Load_THANHPHAM();
        }
        public void Insert_Bus(THANHPHAM ob)
        {
            thanhpham.Insert_THANHPHAM(ob);
        }
        public void Update_Bus(THANHPHAM ob)
        {
            thanhpham.Update_THANHPHAM(ob);
        }
        public void Delete_Bus(string MaNV)
        {
            thanhpham.Delete_THANHPHAM(MaNV);
        }
    }
}
