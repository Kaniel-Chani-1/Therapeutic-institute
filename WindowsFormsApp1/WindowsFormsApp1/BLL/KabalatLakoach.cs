using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
  public  class KabalatLakoach
    {
        private int misKabala;

        public int MisKabala
        {
            get { return misKabala; }
            set { misKabala = value; }
        }
        private string tazLakoach;

        public string TazLakoach
        {
            get { return tazLakoach; }
            set { tazLakoach = value; }
        }
        private string shemKovezHivchun;

        public string ShemKovezHivchun
        {
            get { return shemKovezHivchun; }
            set { shemKovezHivchun = value; }
        }
        private DateTime taharichKabala;

        public DateTime TaharichKabala
        {
            get { return taharichKabala; }
            set { taharichKabala = value; }
        }
        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }
        KabalatLakoachTable MyKabalatLakoachT = new KabalatLakoachTable();
        private DataRow drow;

        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        public void FillFields()
        {
            this.MisKabala = Convert.ToInt32(drow["MisKabala"]);
            this.TazLakoach = Convert.ToString(drow["TazLakoach"]);
            this.ShemKovezHivchun = Convert.ToString(drow["ShemKovezHivchun"]);
            this.TaharichKabala = Convert.ToDateTime(drow["TaharichKabala"]);
            this.Status = Convert.ToBoolean(drow["Status"]);

        }
        public void FillDrow()
        {
            drow["MisKabala"] = this.MisKabala;
            drow["TazLakoach"] = this.TazLakoach;
            drow["ShemKovezHivchun"] = this.ShemKovezHivchun;
            drow["TaharichKabala"] = this.TaharichKabala;
            drow["Status"] = this.Status;
        }
      
        public KabalatLakoach()
        {

        }
        public KabalatLakoach(int id)
        {
            drow = MyKabalatLakoachT.Find(id);
            FillFields();
        }
        public void Add()
        {
            
            drow = MyKabalatLakoachT.GetNewRow();
            FillDrow();
            MyKabalatLakoachT.AddRow(drow);
            MyKabalatLakoachT.Save();

        }
        public void Update()
        {
           
            FillDrow();
            MyKabalatLakoachT.Save();
        }
        public void Delete()
        {
            drow.Delete();
            MyKabalatLakoachT.Save();
        }







    }
}
