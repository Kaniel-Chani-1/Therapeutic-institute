using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
  public   class CustomersTable:GeneralTable
    {
        public CustomersTable() : base("Customers", "TazLakoach")
        {

        }
        public DataTable GetNiceCustTable()
        {
            return dal.GetQuery("SELECT Customers.TazLakoach, [Customers]![ShemPraty] & ' ' & [Customers]![ShemMishpacha] AS shemMale, Customers.TaharichLeida, [Customers]![Ctovet] & ' ' & [Customers]![MisparCtovet] AS ctovet, City.ShemCity, [Customers]![KidTelephone] & '-' & [Customers]![Telephone] AS telephone, Customers.ShemEm, [Customers]![KidPelephoneEm] & '-' & [Customers]![PelephoneEm] AS pelephoneEm, Customers.ShemAv, [Customers]![KidPelephoneAv] & '-' & [Customers]![PelephoneAv] AS pelephoneAv, CupotCholim.ShemCupatCholim FROM CupotCholim INNER JOIN(City INNER JOIN Customers ON City.CodeCity = Customers.CodeCity) ON CupotCholim.CodeCupatCholim = Customers.CodeCupatCholim             ");
        }
        public DataTable GetYomanTorim()
        {
            return dal.GetQuery("SELECT KabalatLakoach.TazLakoach, PerutTipulBesidra.MistIPerutTipul, PerutTipulBesidra.Taharich, SidratTipulim.MisSidratTipulim, SidratTipulim.MisKabala, SidratTipulim.TazOved, [Employess]![ShemPraty] & ' ' & [Employess]![ShemMishpacha] AS ShemMaleOved, SidratTipulim.YomBeshevuha, SidratTipulim.Shaha FROM(KabalatLakoach INNER JOIN(Employess INNER JOIN SidratTipulim ON Employess.TazOved = SidratTipulim.TazOved) ON KabalatLakoach.MisKabala = SidratTipulim.MisKabala) INNER JOIN PerutTipulBesidra ON SidratTipulim.MisSidratTipulim = PerutTipulBesidra.MisSidratTipulim;             ");
        }
        public DataTable GetYomanTorimMeudcan()
        {
            return dal.GetQuery("SELECT Customers.TazLakoach, [Customers]![ShemPraty] & ' ' & [Customers]![ShemMishpacha] AS ShemMaleLakohach, PerutTipulBesidra.MistIPerutTipul, SidratTipulim.MisSidratTipulim, KabalatLakoach.MisKabala, Employess.TazOved, [Employess]![ShemPraty] & ' ' & [Employess]![ShemMishpacha] AS ShemMaleOved, SidratTipulim.Shaha, SidratTipulim.YomBeshevuha, PerutTipulBesidra.Taharich FROM((Customers INNER JOIN KabalatLakoach ON Customers.TazLakoach = KabalatLakoach.TazLakoach) INNER JOIN(Employess INNER JOIN SidratTipulim ON Employess.TazOved = SidratTipulim.TazOved) ON KabalatLakoach.MisKabala = SidratTipulim.MisKabala) INNER JOIN PerutTipulBesidra ON SidratTipulim.MisSidratTipulim = PerutTipulBesidra.MisSidratTipulim;             ");
        }
    }
}
