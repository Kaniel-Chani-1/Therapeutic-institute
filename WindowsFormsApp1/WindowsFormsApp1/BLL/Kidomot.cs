using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
  public  class Kidomot
    {
        private string kid;

        public string Kid
        {
            get { return kid; }
            set {
                if (value.Length < 2)
                {
                    throw new Exception("הזנת ערך שגוי מספר קידומת צריך להכיל לפחות 2 מספרים");
                }
                kid = value; }
        }
        private DataRow drow;

        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        KidomotTable MyKidomotT = new KidomotTable();
        public void FillFields()
        {
            this.kid = Convert.ToString(drow["kid"]);

        }
        public void FillDrow()
        {
            drow["kid"] = this.kid;
           
        }
        public Kidomot()
        {

        }
        public Kidomot(string id)
        {
            drow = MyKidomotT.Find(id);
            FillFields();

        }
        public void Add()
        {
            if (MyKidomotT.Find("kid", kid) != null)
            {
                throw new Exception("קידומת זו קימת במאגר");

            }
            drow = MyKidomotT.GetNewRow();
            FillDrow();
            MyKidomotT.AddRow(drow);
            MyKidomotT.Save();

        }
        public void Update()
        {
            if (MyKidomotT.Find("kid", kid) != null)
            {
                throw new Exception("קידומת זו קימת במאגר");

            }
            FillDrow();
            MyKidomotT.Save();
        }
        public void Delete()
        {
            drow.Delete();
            MyKidomotT.Save();
        }


    }
}
