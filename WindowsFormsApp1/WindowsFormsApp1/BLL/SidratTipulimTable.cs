using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
 public   class SidratTipulimTable:GeneralTable
    {
        public SidratTipulimTable():base("SidratTipulim", "MisSidratTipulim")
        {

        }
        public DataTable  GetAllSdarot()
        {
            return dal.GetQuery("SELECT SidratTipulim.MisSidratTipulim, SidratTipulim.MisKabala, SidratTipulim.CodeHitmachut, SidratTipulim.TehurTipul, SidratTipulim.TazOved, KabalatLakoach.TazLakoach, Customers.ShemPraty, Customers.ShemMishpacha, SidratTipulim.MisTipulimBesidra, SidratTipulim.MisTipulimNotarim, SidratTipulim.YomBeshevuha, SidratTipulim.Shaha, KabalatLakoach.Status, KabalatLakoach.TaharichKabala FROM(Customers INNER JOIN KabalatLakoach ON Customers.TazLakoach = KabalatLakoach.TazLakoach) INNER JOIN SidratTipulim ON KabalatLakoach.MisKabala = SidratTipulim.MisKabala WHERE(((SidratTipulim.MisTipulimNotarim) > 0));             ");
        }
        public DataTable GetEshurMetupalim()
        {
            return dal.GetQuery("SELECT KabalatLakoach.MisKabala, Customers.TazLakoach, Customers.ShemPraty, Customers.ShemMishpacha, KabalatLakoach.TaharichKabala, KabalatLakoach.Status, KabalatLakoach.ShemKovezHivchun FROM Customers INNER JOIN KabalatLakoach ON Customers.TazLakoach = KabalatLakoach.TazLakoach;             ");
        }
        public DataTable GetKabalatMetupal()
        {
            return dal.GetQuery("SELECT KabalatLakoach.MisKabala, KabalatLakoach.TazLakoach, KabalatLakoach.ShemKovezHivchun, KabalatLakoach.TaharichKabala, KabalatLakoach.Status, SidratTipulim.MisSidratTipulim, SidratTipulim.CodeHitmachut, SidratTipulim.TehurTipul, SidratTipulim.TazOved, SidratTipulim.MisTipulimBesidra, SidratTipulim.MisTipulimNotarim, SidratTipulim.YomBeshevuha, SidratTipulim.Shaha FROM KabalatLakoach INNER JOIN SidratTipulim ON KabalatLakoach.MisKabala = SidratTipulim.MisKabala WHERE(((SidratTipulim.MisTipulimNotarim) > 0));             ");
        }
        public DataTable GetAllSdarotMurchav()
        {
            return dal.GetQuery("SELECT SidratTipulim.MisSidratTipulim, SidratTipulim.MisKabala, SidratTipulim.CodeHitmachut, SidratTipulim.TehurTipul, KabalatLakoach.TazLakoach, Customers.ShemPraty, Customers.ShemMishpacha, SidratTipulim.MisTipulimBesidra, SidratTipulim.MisTipulimNotarim, SidratTipulim.YomBeshevuha, SidratTipulim.Shaha, KabalatLakoach.Status, KabalatLakoach.TaharichKabala, [Employess]![ShemMishpacha] & ' ' & [Employess]![ShemPraty] AS shemMetapel, Hitmachuiot.ShemHitmachut, Employess.TazOved FROM(Customers INNER JOIN KabalatLakoach ON Customers.TazLakoach = KabalatLakoach.TazLakoach) INNER JOIN((Hitmachuiot INNER JOIN Employess ON Hitmachuiot.CodeHitmachut = Employess.CodeHitmachut) INNER JOIN SidratTipulim ON(Hitmachuiot.CodeHitmachut = SidratTipulim.CodeHitmachut) AND(Employess.TazOved = SidratTipulim.TazOved)) ON KabalatLakoach.MisKabala = SidratTipulim.MisKabala ;             ");
        }
    }
}
