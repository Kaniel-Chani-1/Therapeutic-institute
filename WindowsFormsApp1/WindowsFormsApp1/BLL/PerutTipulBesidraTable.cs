using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
  public  class PerutTipulBesidraTable:GeneralTable
    {
        public PerutTipulBesidraTable():base("PerutTipulBesidra", "MistIPerutTipul")
        {

        }
        public DataTable GetMaharrechetShaot()
        {
            return dal.GetQuery("SELECT PerutTipulBesidra.MistIPerutTipul, PerutTipulBesidra.MisSidratTipulim, SidratTipulim.TazOved, SidratTipulim.Shaha, SidratTipulim.YomBeshevuha, PerutTipulBesidra.Taharich FROM SidratTipulim INNER JOIN PerutTipulBesidra ON SidratTipulim.MisSidratTipulim = PerutTipulBesidra.MisSidratTipulim;             ");
        }   
          
    }
}
