using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.BLL
{
   public class CupotCholim
    {
        private int codeCupatCholim;

        public int CodeCupatCholim
        {
            get { return codeCupatCholim; }
            set { codeCupatCholim = value; }
        }
        private string shemCupatCholim;

        public string ShemCupatCholim
        {
            get { return shemCupatCholim; }
            set {
                if (value.Length < 2)
                {
                    throw new Exception("הזנת ערך שגוי שם קופת חולים צריך להכיל לפחות 2 אותיות");
                }
                shemCupatCholim = value; }
        }
        private DataRow drow;

        public DataRow Drow
        {
            get { return drow; }
            set { drow = value; }
        }
        CupotCholimTable MyCupatCholimT = new CupotCholimTable();
        public void FillFields()
        {
            this.CodeCupatCholim = Convert.ToInt32(drow["CodeCupatCholim"]);
            this.ShemCupatCholim = Convert.ToString(drow["ShemCupatCholim"]);

        }
        public void FillDrow()
        {
            drow["ShemCupatCholim"] = this.ShemCupatCholim;
            drow["CodeCupatCholim"] = this.CodeCupatCholim;
        }
        public CupotCholim()
        {

        }
        public CupotCholim(int id)
        {
            drow = MyCupatCholimT.Find(id);
            FillFields();

        }
        public void Add()
        {
            if (MyCupatCholimT.Find("ShemCupatCholim", ShemCupatCholim) != null)
            {
                throw new Exception(" שם קופה קים במאגר");

            }
            drow = MyCupatCholimT.GetNewRow();
            FillDrow();
            MyCupatCholimT.AddRow(drow);
            MyCupatCholimT.Save();

        }
        public void Update()
        {
            if (MyCupatCholimT.Find("ShemCupatCholim", ShemCupatCholim) != null)
            {
                throw new Exception("שם קופה קים במאגר");

            }
            FillDrow();
            MyCupatCholimT.Save();
        }
        public void Delete()
        {
            drow.Delete();
            MyCupatCholimT.Save();
        }

    }
}
