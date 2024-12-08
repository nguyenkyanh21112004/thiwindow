using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_MON;
namespace DAL_MON
{
    public class DAL_Mon : Connect
    {
        public DataTable LoadDL()
        {
            return Load("SELECT * FROM MON");
        }
        public void Insert(Mon mon)
        {
            string sql = "INSERT INTO MON VALUES('" + mon.Mamon + "', '" + mon.Tenmon + "' ," + mon.Sotinchi + ")";
            Execute(sql);
        }
        public void Update(Mon mon)
        {
            string sql = "UPDATE MON SET TENMON ='" + mon.Tenmon + ", SOTC =" + mon.Sotinchi + "' WHERE MAMON ='" + mon.Mamon + "'";
            Execute(sql);
        }
        public void Delete(Mon mon)
        {
            string sql = "DELETE FROM MON WHERE MAMON = '" + mon.Mamon + "'";
            Execute(sql);
        }
    }
}
