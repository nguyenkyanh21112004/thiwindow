using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DAL_Lop : Connect
    {
        public DataTable LoadDL()
        {
            return Load("SELECT * FROM LOP");
        }
        public bool Check(string key)
        {
            DataTable dt = LoadDL();
            foreach(DataRow  r in dt.Rows)
            {
                if (key == r[0].ToString()) return true;
            }
            return false;

        }
        public bool  Insert(Lop lop)
        {
            
            string sql = "INSERT INTO LOP VALUES('" + lop.Malop + "', N'" + lop.Tenlop + "')";
            if (!Check(lop.Malop))
            {
                Execute(sql); return true;
            }
            return false;
        }
        public void Update(Lop lop)
        {
            string sql = "UPDATE LOP SET TENLOP = N'" + lop.Tenlop + "' WHERE MALOP ='" + lop.Malop + "'";
            Execute(sql);
        }
        public void Delete(Lop lop)
        {
            string sql = "DELETE FROM LOP WHERE MALOP = '" + lop.Malop + "'";
            Execute(sql);
        }
    }
}
