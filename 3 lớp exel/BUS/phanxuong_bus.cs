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
    public class phanxuong_bus
    {
        phanxuong_dal phanxuong= new phanxuong_dal();
        public DataTable load_bus()
        {
            return phanxuong.load_px();
        }
        public void Insert_bus(phanxuong px)
        {
           phanxuong.Insert_px(px) ;
        }
        public void Update_bus(phanxuong px)
        {
            phanxuong.Update_px(px);
        }
        public void delete_bus(phanxuong px)
        {
            phanxuong.Delete_px(px);
        }
    }
}
