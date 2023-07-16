using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
   public class Hitmachuiot
    {
        private int codeHitmachut;

        public int CodeHitmachut
        {
            get { return codeHitmachut; }
            set { codeHitmachut = value; }
        }
        private string shemHitmachut;

        public string ShemHitmachut
        {
            get { return shemHitmachut; }
            set {
                if (value.Length < 2)
                {
                    throw new Exception("הזנת ערך שגוי שם התמחות צריך להכיל לפחות 2 אותיות");
                }
                shemHitmachut = value; }
        }
        private int tarif;

        public int Tarif
        {
            get { return tarif; }
            set { tarif = value; }
        }
        private DataRow drow;

        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        HitmachuiotTable MyHitmachuiotT = new HitmachuiotTable();
       
        public void FillFields()
        {
            this.CodeHitmachut = Convert.ToInt32(drow["CodeHitmachut"]);
            this.ShemHitmachut = Convert.ToString(drow["ShemHitmachut"]);
            this.tarif = Convert.ToInt32(drow["tarif"]);
        }
        public void FillDrow()
        {
            drow["ShemHitmachut"] = this.ShemHitmachut;
            drow["CodeHitmachut"] = this.CodeHitmachut;
            drow["tarif"] = this.tarif;
        }
        public Hitmachuiot()
        {

        }
        public Hitmachuiot(int id)
        {
            drow = MyHitmachuiotT.Find(id);
            FillFields();

        }
        public void Add()
        {
            if (MyHitmachuiotT.Find("ShemHitmachut", ShemHitmachut) != null)
            {
                throw new Exception("התמחות זו קימת במאגר");

            }
            drow = MyHitmachuiotT.GetNewRow();
            FillDrow();
            MyHitmachuiotT.AddRow(drow);
            MyHitmachuiotT.Save();

        }
        public void Update()
        {
           
            FillDrow();
            MyHitmachuiotT.Save();
        }
        public void Delete()
        {
            drow.Delete();
            MyHitmachuiotT.Save();
        }






    }
}
