using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
 public   class PerutTipulBesidra
    {
        private int mistIPerutTipul;

        public int MistIPerutTipul
        {
            get { return mistIPerutTipul; }
            set { mistIPerutTipul = value; }
        }
        private DateTime taharich;

        public DateTime Taharich
        {
            get { return taharich; }
            set { taharich = value; }
        }
        private string tehurPehilut;

        public string TehurPehilut
        {
            get { return tehurPehilut; }
            set { tehurPehilut = value; }
        }
        private int misSidratTipulim;

        public int MisSidratTipulim
        {
            get { return misSidratTipulim; }
            set { misSidratTipulim = value; }
        }
        private string kezevHitkadmut;

        public string KezevHitkadmut
        {
            get { return kezevHitkadmut; }
            set { kezevHitkadmut = value; }
        }
        private DataRow drow;

        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        PerutTipulBesidraTable MyPerutTipulBesidraT = new PerutTipulBesidraTable();
        public void FillFields()
        {
            this.MistIPerutTipul = Convert.ToInt32(drow["MistIPerutTipul"]);
            this.Taharich = Convert.ToDateTime(drow["Taharich"]);
            this.TehurPehilut = Convert.ToString(drow["TehurPehilut"]);
            this.MisSidratTipulim = Convert.ToInt32(drow["MisSidratTipulim"]);
            this.KezevHitkadmut = Convert.ToString(drow["KezevHitkadmut"]);

        }
        public void FillDrow()
        {
            drow["MistIPerutTipul"] = this.MistIPerutTipul;
            drow["Taharich"] = this.Taharich;
            drow["TehurPehilut"] = this.TehurPehilut;
            drow["MisSidratTipulim"] = this.MisSidratTipulim;
            drow["KezevHitkadmut"] = this.KezevHitkadmut;
        }
        public PerutTipulBesidra()
        {

        }
        public PerutTipulBesidra(int id)
        {
            drow = MyPerutTipulBesidraT.Find(id);
            FillFields();

        }
        public void Add()
        {
          
            drow = MyPerutTipulBesidraT.GetNewRow();
            FillDrow();
            MyPerutTipulBesidraT.AddRow(drow);
            MyPerutTipulBesidraT.Save();

        }
        public void Update()
        {
            
            FillDrow();
            MyPerutTipulBesidraT.Save();
        }
        public void Delete()
        {
            drow.Delete();
            MyPerutTipulBesidraT.Save();
        }


    }
}
