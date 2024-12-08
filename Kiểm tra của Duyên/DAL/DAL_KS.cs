using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_KS:DAL_CN
    {
        public DataTable DAL_loaddl()
        {
            string sql = "select * from Thuephong";
            return Loaddl(sql);
        }
        public void DAL_them(DTO_KS k)
        {
            string sql = "insert into Thuephong values('" + k.makh + "','" + k.maphong + "','" + k.ngayden + "','" + k.ngaydi + "')";
            thucthi(sql);
        }
        public void DAL_Sua(DTO_KS k)
        {
            string sql = "Update Thuephong set Maphong='"+k.maphong+"', Ngayden='"+k.ngayden+"', Ngaydi='"+k.ngaydi+"' where Makh='"+k.makh+"'";
            thucthi(sql);
        }
        public void DAL_Xoa(DTO_makh k)
        {
            string sql = "delete from Thuephong where Makh='"+k.makh+"'";
            thucthi(sql);
        }
        public DataTable DAL_LoadEX(DTO_makh kh)
        {
            string sql = "select Thuephong.Makh,Hoten,Phong.Maphong,Ngayden,Ngaydi,Gia,DATEDIFF(dd,Ngayden,Ngaydi) as songay ,DATEDIFF(dd,Ngayden,Ngaydi)*Gia as sotien from Khachhang,Phong,Thuephong where Khachhang.Makh=Thuephong.Makh and Thuephong.Maphong=Phong.Maphong and Thuephong.Makh='" + kh.makh + "'";
            return Loaddl(sql);
        }
    }
}
