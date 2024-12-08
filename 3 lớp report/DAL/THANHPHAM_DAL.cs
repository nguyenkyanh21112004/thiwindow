using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class THANHPHAM_DAL : Connect
    {
        public THANHPHAM_DAL() { }

        // Load
        public DataTable Load_THANHPHAM()
        {
            return Load_DL("select * from THANHPHAM");
        }
        public void Insert_THANHPHAM(THANHPHAM ob)
        {
            string sql = "insert into THANHPHAM values('" +
                ob.MaSP + "','" + ob.MaNV + "','" + ob.NgayThanhPham + "','" + ob.SoLuongNop + "')";
            Excecute(sql);

        }
        public void Update_THANHPHAM(THANHPHAM ob)
        {
            string sql = "update THANHPHAM set MaSP='" + ob.MaSP + "'" +
                "where MaNV='" + ob.MaNV + "'";
            Excecute(sql);

        }
        public void Delete_THANHPHAM(string MaNV)
        {
            string sql = "delete from THANHPHAM where MaSP='" + MaNV + "'";
            Excecute(sql);

        }
    }
}
