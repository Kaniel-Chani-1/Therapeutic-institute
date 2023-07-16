using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
 public   class KidomotTable:GeneralTable
    {
        public KidomotTable():base("Kidomot", "Kid")
        {

        }
        public DataTable GetKidomot1()
        {
            return dal.GetQuery("SELECT Kidomot.* FROM Kidomot;             ");
        }
        public DataTable GetKidomot2()
        {
            return dal.GetQuery("SELECT Kidomot.* FROM Kidomot;             ");
        }
        public DataTable GetKidomot3()
        {
            return dal.GetQuery("SELECT Kidomot.* FROM Kidomot;             ");
        }

    }
}
