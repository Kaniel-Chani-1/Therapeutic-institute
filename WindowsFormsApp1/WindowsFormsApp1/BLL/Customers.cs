using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
    public class Customers
    {
        private string tazLakoach;

        public string TazLakoach
        {
            get { return tazLakoach; }
            set {
                if (value.Length < 9 || value.Length > 9)
                {
                 throw new Exception("מספר הספרות לא מתאים");
                }

               int sum = 0;
                 int temp;

                    for (int i = 0; i < 9; i++)
{
                      if (i % 2 == 0)
                    {
                          sum += Convert.ToInt32(value[i].ToString());
                       }
                        else
                        {
                           temp = Convert.ToInt32(value[i].ToString()) * 2;
                           if (temp > 9)
                           {
                              temp = temp / 10 + temp % 10;
                            }
                           sum += temp;
                       }
                  }
                    if (sum % 10 == 0)
                tazLakoach = value;
                   else
                       throw new Exception("מספר הזהות שהוקש לא חוקי");


            }
        }
        private string shemPraty;

        public string ShemPraty
        {
            get { return shemPraty; }
            set {
                if (value.Length < 2)
                {
                    throw new Exception("הזנת ערך שגוי שם פרטי צריך להכיל לפחות 2 אותיות");
                }
                shemPraty = value; }
        }
        private string shemMishpacha;

        public string ShemMishpacha
        {
            get { return shemMishpacha; }
            set {
                if (value.Length < 2)
                {
                    throw new Exception("הזנת ערך שגוי שם משפחה צריך להכיל לפחות 2 אותיות");
                }
                shemMishpacha = value; }
        }
        private DateTime taharichLeida;

        public DateTime TaharichLeida
        {
            get { return taharichLeida; }
            set { taharichLeida = value; }
        }
        private string ctovet;

        public string Ctovet
        {
            get { return ctovet; }
            set {
                if (value.Length < 2)
                {
                    throw new Exception("הזנת ערך שגוי שם כתובת צריך להכיל לפחות 2 אותיות");
                }
                ctovet = value; }
        }
        private int misparCtovet;

        public int MisparCtovet
        {
            get { return misparCtovet; }
            set { misparCtovet = value; }
        }
        private int codeCity;

        public int CodeCity
        {
            get { return codeCity; }
            set { codeCity = value; }
        }
        private string kidTelephone;

        public string KidTelephone
        {
            get { return kidTelephone; }
            set { kidTelephone = value; }
        }
        private string telephone;

        public string Telephone
        {
            get { return telephone; }
            set {
                if (value.Length < 7)
                {
                    throw new Exception("הזנת ערך שגוי טלפון צריך להכיל 7 ספרות");
                }
                telephone = value; }
        }
        private string shemEm;

        public string ShemEm
        {
            get { return shemEm; }
            set
            {
                if (value.Length < 2)
                {
                    throw new Exception("הזנת ערך שגוי שם פרטי צריך להכיל לפחות 2 אותיות");
                }
                shemEm = value; }
        }
        private string kidPelephoneEm;

        public string KidPelephoneEm
        {
            get { return kidPelephoneEm; }
            set { kidPelephoneEm = value; }
        }
        private string pelephoneEm;

        public string PelephoneEm
        {
            get { return pelephoneEm; }
            set
            {
                if (value.Length < 7)
                {
                    throw new Exception("הזנת ערך שגוי פאלפון צריך להכיל 7 ספרות");
                }
                pelephoneEm = value; }
        }
        private string shemAv;

        public string ShemAv
        {
            get { return shemAv; }
            set
            {
                if (value.Length < 2)
                {
                    throw new Exception("הזנת ערך שגוי שם פרטי צריך להכיל לפחות 2 אותיות");
                }
                shemAv = value; }
        }
        private string kidPelephoneAv;

        public string KidPelephoneAv
        {
            get { return kidPelephoneAv; }
            set { kidPelephoneAv = value; }
        }
        private string pelephoneAv;

        public string PelephoneAv
        {
            get { return pelephoneAv; }
            set
            {
                if (value.Length < 7)
                {
                    throw new Exception("הזנת ערך שגוי פאלפון צריך להכיל 7 ספרות");
                }
                pelephoneAv = value; }
        }
        private int codeCupatCholim;

        public int CodeCupatCholim
        {
            get { return codeCupatCholim; }
            set { codeCupatCholim = value; }
        }
        private DataRow drow;

        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        CustomersTable MyCustomersT = new CustomersTable();

        public void FillFields()
        {
            this.TazLakoach = Convert.ToString(drow["TazLakoach"]);
            this.ShemPraty = Convert.ToString(drow["ShemPraty"]);
            this.ShemMishpacha = Convert.ToString(drow["ShemMishpacha"]);
            this.TaharichLeida = Convert.ToDateTime(drow["TaharichLeida"]);
            this.Ctovet = Convert.ToString(drow["Ctovet"]);
            this.MisparCtovet = Convert.ToInt32(drow["MisparCtovet"]);
            this.CodeCity = Convert.ToInt32(drow["CodeCity"]);
            this.KidTelephone = Convert.ToString(drow["KidTelephone"]);
            this.Telephone = Convert.ToString(drow["Telephone"]);
            this.ShemEm = Convert.ToString(drow["ShemEm"]);
            this.KidPelephoneEm = Convert.ToString(drow["KidPelephoneEm"]);
            this.PelephoneEm = Convert.ToString(drow["PelephoneEm"]);
            this.ShemAv = Convert.ToString(drow["ShemAv"]);
            this.KidPelephoneAv = Convert.ToString(drow["KidPelephoneAv"]);
            this.PelephoneAv = Convert.ToString(drow["PelephoneAv"]);
            this.CodeCupatCholim = Convert.ToInt32(drow["CodeCupatCholim"]);
        }
        public void FillDrow()
        {
            drow["TazLakoach"] = this.TazLakoach;
            drow["ShemPraty"] = this.ShemPraty;
            drow["ShemMishpacha"] = this.ShemMishpacha;
            drow["TaharichLeida"] = this.TaharichLeida;
            drow["Ctovet"] = this.Ctovet;
            drow["MisparCtovet"] = this.MisparCtovet;
            drow["CodeCity"] = this.CodeCity;
            drow["KidTelephone"] = this.KidTelephone;
            drow["Telephone"] = this.Telephone;
            drow["ShemEm"] = this.ShemEm;
            drow["KidPelephoneEm"] = this.KidPelephoneEm;
            drow["PelephoneEm"] = this.PelephoneEm;
            drow["ShemAv"] = this.ShemAv;
            drow["KidPelephoneAv"] = this.KidPelephoneAv;
            drow["PelephoneAv"] = this.PelephoneAv;
            drow["CodeCupatCholim"] = this.CodeCupatCholim;
        }
        public Customers()
        {

        }
   

    public Customers(string id)
    {
        drow = MyCustomersT.Find(id);
        FillFields();

    }
    public void Add()
    {
        if (MyCustomersT.Find(TazLakoach) != null)
        {
            throw new Exception("הלקוח קים במאגר");

        }
        drow = MyCustomersT.GetNewRow();
        FillDrow();
        MyCustomersT.AddRow(drow);
        MyCustomersT.Save();

    }
    public void Update()
    {
          // if (MyCustomersT.Find(TazLakoach) != null)
          //  {
             //  throw new Exception("הלקוח קים במאגר");

          // }
            FillDrow();
        MyCustomersT.Save();
    }
    public void Delete()
    {
        drow.Delete();
        MyCustomersT.Save();
    }












    }
}
