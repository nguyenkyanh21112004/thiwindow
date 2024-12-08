using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Sinhvien;
namespace DAL_Sinhvien
{
    public class DAL_Sv : Connect
    {
        public DataTable LoadDL()
        {
            return Load("SELECT * FROM SINHVIEN");
        }
        public DataTable LoadMalop()
        {
            return Load("SELECT * FROM LOP");
        }
        public void Insert(Sinhvien sv)
        {
            string sql = "INSERT INTO SINHVIEN VALUES('" + sv.Masv + "','" + sv.Hoten + "', '" + sv.Ngaysinh + "', '" + sv.Malop + "')";
            Execute(sql);
        }
        public void Update(Sinhvien sv)
        {
            string sql = "UPDATE SINHVIEN SET HOTEN ='" + sv.Hoten + ", NGAYSINH = '" + sv.Ngaysinh + "', MALOP = '" + sv.Malop + "' WHERE MASV ='" + sv.Masv + "'";
            Execute(sql);
        }
        public void Delete(Sinhvien sv)
        {
            string sql = "DELETE FROM SINHVIEN WHERE MASV = '" + sv.Masv + "'";
            Execute(sql);
        }
    }
}
