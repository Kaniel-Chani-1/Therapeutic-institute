using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
  public  class SidratTipulim
    {
        private int misSidratTipulim;

        public int MisSidratTipulim
        {
            get { return misSidratTipulim; }
            set { misSidratTipulim = value; }
        }
        private int misKabala;

        public int MisKabala
        {
            get { return misKabala; }
            set { misKabala = value; }
        }
        private int codeHitmachut;

        public int CodeHitmachut
        {
            get { return codeHitmachut; }
            set { codeHitmachut = value; }
        }
        private string tehurTipul;

        public string TehurTipul
        {
            get { return tehurTipul; }
            set { tehurTipul = value; }
        }
        private string tazOved;

        public string TazOved
        {
            get { return tazOved; }
            set { tazOved = value; }
        }
        private int misTipulimBesidra;

        public int MisTipulimBesidra
        {
            get { return misTipulimBesidra; }
            set { misTipulimBesidra = value; }
        }
        private int misTipulimNotarim;

        public int MisTipulimNotarim
        {
            get { return misTipulimNotarim; }
            set { misTipulimNotarim = value; }
        }
        private string yomBeshevuha;

        public string YomBeshevuha
        {
            get { return yomBeshevuha; }
            set { yomBeshevuha = value; }
        }
        private int shaha;

        public int   Shaha
        {
            get { return shaha; }
            set { shaha = value; }
        }
        private DataRow drow;

        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        SidratTipulimTable MySidratTipulimT = new SidratTipulimTable();
        public void FillFields()
        {
            this.MisSidratTipulim = Convert.ToInt32(drow["MisSidratTipulim"]);
            this.MisKabala = Convert.ToInt32(drow["MisKabala"]);
            this.CodeHitmachut = Convert.ToInt32(drow["CodeHitmachut"]);
            this.TehurTipul = Convert.ToString(drow["TehurTipul"]);
            this.TazOved = Convert.ToString(drow["TazOved"]);
            this.MisTipulimBesidra = Convert.ToInt32(drow["MisTipulimBesidra"]);
            this.MisTipulimNotarim = Convert.ToInt32(drow["MisTipulimNotarim"]);
            this.YomBeshevuha = Convert.ToString(drow["YomBeshevuha"]);
            this.Shaha = Convert.ToInt32(drow["Shaha"]);

        }
        public void FillDrow()
        {
            drow["MisSidratTipulim"] = this.MisSidratTipulim;
            drow["MisKabala"] = this.MisKabala;
            drow["CodeHitmachut"] = this.CodeHitmachut;
            drow["TehurTipul"] = this.TehurTipul;
            drow["TazOved"] = this.TazOved;
            drow["MisTipulimBesidra"] = this.MisTipulimBesidra;
            drow["MisTipulimNotarim"] = this.MisTipulimNotarim;
            drow["YomBeshevuha"] = this.YomBeshevuha;
            drow["Shaha"] = this.Shaha;
            
        }
        public SidratTipulim()
        {

        }
        public SidratTipulim(int id)
        {
            drow = MySidratTipulimT.Find(id);
            FillFields();

        }
        public void Add()
        {
          
            drow = MySidratTipulimT.GetNewRow();
            FillDrow();
            MySidratTipulimT.AddRow(drow);
            MySidratTipulimT.Save();

        }
        public void Update()
        {
           
            FillDrow();
            MySidratTipulimT.Save();
        }
        public void Delete()
        {
            drow.Delete();
            MySidratTipulimT.Save();
        }

    }
}
