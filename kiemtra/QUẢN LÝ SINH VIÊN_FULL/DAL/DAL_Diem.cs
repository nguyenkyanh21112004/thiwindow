using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Diem : Connect
    {
        public DataTable LoadMALOP()
        {
            return Load("SELECT * FROM LOP");
        }
        public DataTable LoadTENMON()
        {
            return Load("SELECT * FROM MON");
        }
        public DataTable LayDanhsach(string tenlop, string tenmon)
        {
            return Load("SELECT SINHVIEN.MASV, HOTEN, NGAYSINH, DIEM FROM SINHVIEN, LOP, MON, DIEM WHERE SINHVIEN.MASV = DIEM.MASV AND MON.MAMON = DIEM.MAMON AND SINHVIEN.MALOP = LOP.MALOP AND TENLOP = N'" + tenlop + "' AND TENMON = N'" + tenmon + "'");
        }

        public void Luudiem(Diem d)
        {
            string sql = "UPDATE DIEM SET DIEM = " + d.d + " WHERE MASV = '" + d.Masv + "' AND MAMON = '" + d.Mamon + "'";
            Execute(sql); 
        }
    }
}
