using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
 public   class Employess
    {
        private string tazOved;

        public string TazOved
        {
            get { return tazOved; }
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
                    tazOved = value;
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
            set
            {
                if (value.Length < 7)
                {
                    throw new Exception("הזנת ערך שגוי טלפון צריך להכיל 7 ספרות");
                }
                telephone = value; }
        }
        private string kidPelephone;

        public string KidPelephone
        {
            get { return kidPelephone; }
            set { kidPelephone = value; }
        }
        private string pelephone;

        public string Pelephone
        {
            get { return pelephone; }
            set
            {
                if (value.Length < 7)
                {
                    throw new Exception("הזנת ערך שגוי פאלפון צריך להכיל 7 ספרות");
                }
                pelephone = value; }
        }
        private string mail;

        public string Mail
        {
            get { return mail; }
            set
            {
                string pattern = @"^(?<user>[^@]+)@(?<host>.+)$";
                Regex reg = new Regex(pattern);
                if (reg.IsMatch(value) == true || value == "")
                    mail = value;
                else

                    throw new Exception("כתובת הדואל לא חוקית");







            }
        }
        private string hekefMisra;

        public string HekefMisra
        {
            get { return hekefMisra; }
            set { hekefMisra = value; }
        }
        private DateTime taharichTchilatAvoda;

        public DateTime TaharichTchilatAvoda
        {
            get { return taharichTchilatAvoda; }
            set { taharichTchilatAvoda = value; }
        }
        private int codeHitmachut;

        public int CodeHitmachut
        {
            get { return codeHitmachut; }
            set { codeHitmachut = value; }
        }
        private string tafkid;

        public string Tafkid
        {
            get { return tafkid; }
            set { tafkid = value; }
        }
        private bool pail;

        public bool Pail
        {
            get { return pail; }
            set { pail = value; }
        }
        private DataRow drow;

        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        EmployessTable MyEmployessT = new EmployessTable();
        public void FillFields()
        {
            this.TazOved = Convert.ToString(drow["TazOved"]);
            this.ShemPraty = Convert.ToString(drow["ShemPraty"]);
            this.ShemMishpacha = Convert.ToString(drow["ShemMishpacha"]);
            this.Ctovet = Convert.ToString(drow["Ctovet"]);
            this.MisparCtovet = Convert.ToInt32(drow["MisparCtovet"]);
            this.CodeCity = Convert.ToInt32(drow["CodeCity"]);
            this.KidTelephone = Convert.ToString(drow["KidTelephone"]);
            this.Telephone = Convert.ToString(drow["Telephone"]);
            this.KidPelephone = Convert.ToString(drow["KidPelephone"]);
            this.Pelephone = Convert.ToString(drow["Pelephone"]);
            this.Mail = Convert.ToString(drow["Mail"]);
            this.HekefMisra = Convert.ToString(drow["HekefMisra"]);
            try
            { 
             this.TaharichTchilatAvoda = Convert.ToDateTime(drow["TaharichTchilatAvoda"]);
            }
            catch (Exception)
            {

               
            }
            this.CodeHitmachut = Convert.ToInt32(drow["CodeHitmachut"]);
            this.Tafkid = Convert.ToString(drow["Tafkid"]);
            this.Pail = Convert.ToBoolean(drow["Pail"]);
        }
        public void FillDrow()
        {
            drow["TazOved"] = this.TazOved;
            drow["ShemPraty"] = this.ShemPraty;
            drow["ShemMishpacha"] = this.ShemMishpacha;
            drow["Ctovet"] = this.Ctovet;
            drow["MisparCtovet"] = this.MisparCtovet;
            drow["CodeCity"] = this.CodeCity;
            drow["KidTelephone"] = this.KidTelephone;
            drow["Telephone"] = this.Telephone;
            drow["KidPelephone"] = this.KidPelephone;
            drow["Pelephone"] = this.Pelephone;
            drow["Mail"] = this.Mail;
            drow["HekefMisra"] = this.HekefMisra;
            drow["TaharichTchilatAvoda"] = this.TaharichTchilatAvoda;
            drow["CodeHitmachut"] = this.CodeHitmachut;
            drow["Tafkid"] = this.Tafkid;
            drow["Pail"] = this.Pail;
        }
        public Employess()
        {

        }

        public Employess(string id)
        {
            drow = MyEmployessT.Find(id);
            FillFields();

        }
        public void Add()
        {
            if (MyEmployessT.Find(TazOved) != null)
            {
                throw new Exception("העובד קים במאגר");

            }
            drow = MyEmployessT.GetNewRow();
            FillDrow();
            MyEmployessT.AddRow(drow);
            MyEmployessT.Save();

        }
        public void Update()
        {
           
            FillDrow();
            MyEmployessT.Save();
        }
        public void Delete()
        {
            drow.Delete();
            MyEmployessT.Save();
        }






    }
}
