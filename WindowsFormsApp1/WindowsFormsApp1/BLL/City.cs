using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
   public class City
    {
        private int codeCity;

        public int CodeCity
        {
            get { return codeCity; }
            set { codeCity = value; }
        }
        private string shemCity;

        public string ShemCity
        {
            get { return shemCity; }
            set {
                if (value.Length < 2)
                {
                    throw new Exception("הזנת ערך שגוי שם עיר צריך להכיל לפחות 2 אותיות");
                }
                shemCity = value; }
        }
        private DataRow drow;

        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        CityTable MyCityT = new CityTable();
        public void FillFields()
        {
            this.CodeCity = Convert.ToInt32(drow["CodeCity"]);
            this.ShemCity = Convert.ToString(drow["ShemCity"]);

        }
        public void FillDrow()
        {
            drow["ShemCity"] = this.ShemCity;
            drow["CodeCity"] = this.CodeCity;
        }
        public City()
        {

        }
        public City(int id)
        {
            drow = MyCityT.Find(id);
            FillFields();

        }
        public void Add()
        {
            if (MyCityT.Find("ShemCity", ShemCity) != null)
            {
                throw new Exception("עיר זו קימת במאגר");

            }
            drow = MyCityT.GetNewRow();
            FillDrow();
            MyCityT.AddRow(drow);
            MyCityT.Save();

        }
        public void Update()
        {
            if (MyCityT.Find("ShemCity", ShemCity) != null)
            {
                throw new Exception("עיר זן קימת במאגר");

            }
            FillDrow();
            MyCityT.Save();
        }
        public void Delete()
        {
            drow.Delete();
            MyCityT.Save();
        }


    }
}
