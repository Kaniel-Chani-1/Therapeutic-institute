using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
  public  class EmployessTable:GeneralTable
    {
        public EmployessTable():base("Employess", "TazOved")
        {

        }
        public DataTable GetNiceEmployeeTable()
        {
            return dal.GetQuery("SELECT Employess.TazOved, [Employess]![ShemPraty] & ' ' & [Employess]![ShemMishpacha] AS shemMale, [Employess]![Ctovet] & ' ' & [Employess]![MisparCtovet] AS ctovet, City.ShemCity, [Employess]![KidTelephone] & '-' & [Employess]![Telephone] AS telephone, [Employess]![KidPelephone] & '-' & [Employess]![Pelephone] AS pelephone, Employess.Mail, Employess.HekefMisra, Employess.TaharichTchilatAvoda, Hitmachuiot.ShemHitmachut, Employess.Tafkid, Employess.Pail FROM Hitmachuiot INNER JOIN(City INNER JOIN Employess ON City.CodeCity = Employess.CodeCity) ON Hitmachuiot.CodeHitmachut = Employess.CodeHitmachut;             ");
        }
    }
}
