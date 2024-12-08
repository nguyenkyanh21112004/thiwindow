using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class phanxuong_dal:conncet
    {
        public DataTable load_px()
        {
            return load_dl ("select * from nhanvien");
        }
        public void Insert_px(phanxuong px)
        {
            string sql = "insert into nhanvien  (manv , tennv , ngaysinh , mapx, gioitinh) VALUES ('"
                         + px.Manv + "','"
                         + px.Tennv + "','"
                         + px.Ngaysinh + "','"          
                         + px.Mapx +"','"
                         +px.Gioitinh + "')";
            execute(sql);
        }

        public void Update_px(phanxuong px)
        {
            string sql = (" update nhanvien set mapx ='" + px.Mapx + "'  where manv='" + px.Manv + "' ");
            execute(sql);
        }
        public void Delete_px(phanxuong px)
        {
            string sql = (" delete from nhanvien where manv='" + px.Manv + "'");
            execute
                (sql);
        }
    }
}
