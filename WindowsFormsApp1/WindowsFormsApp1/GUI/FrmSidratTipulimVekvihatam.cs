using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BLL;
using word = Microsoft.Office.Interop;


namespace WindowsFormsApp1.GUI
{
    public partial class FrmSidratTipulimVekvihatam : Form
    {
        KabalatLakoachTable MyKabalatLakoachT = new KabalatLakoachTable();
        KabalatLakoach MyKabalatLakoach1;
        Customers MyCustomers1;
        DataView dvOved;
        DataView dvPerutTipulimBesidra;
        DataView dvUpdateKabala;
        SidratTipulim mySdratTip1 ;
        SidratTipulimTable mySdratTipTT = new SidratTipulimTable();
        PerutTipulBesidra myPerutipTBesid1;
        PerutTipulBesidraTable myPerTipBesT = new PerutTipulBesidraTable();
        string MyFrmState;
        string file;
        public void MiluyCombs()
        {
            dvOved = new DataView(new EmployessTable().GetNiceEmployeeTable());
            combShemOved.DataSource = dvOved;
            combShemOved.ValueMember = "TazOved";
            combShemOved.DisplayMember = "shemMale";
            combTchumTipul.DataSource = new HitmachuiotTable().GetDataTable();
            combTchumTipul.DisplayMember = "ShemHitmachut";
            combTchumTipul.ValueMember = "CodeHitmachut";
            


        }
       
        public FrmSidratTipulimVekvihatam()
        {
            InitializeComponent();
            MiluyCombs();
        }
        public FrmSidratTipulimVekvihatam(Customers cc,string frmstate)//חדש מתוך טופס לקוח
        {
            InitializeComponent();
            MiluyCombs();
            
            MyFrmState = frmstate;
          if (MyFrmState=="NEW")
          {
            MyKabalatLakoach1 = new KabalatLakoach();
            MyCustomers1 =cc;
            lblCode.Text = Convert.ToString( MyKabalatLakoachT.GetNewKey());
            lblTazMetupal.Text = MyCustomers1.TazLakoach;
            lblShemPraty.Text = MyCustomers1.ShemPraty;
            lblShemMishpacha.Text = MyCustomers1.ShemMishpacha;
            lblTaharichKabala.Text = DateTime.Today.ToShortDateString();
            chkbPail.Checked = false;
          }
         if (MyFrmState=="UPDATE")
           {
                MyCustomers1 = cc;

              dvUpdateKabala = new DataView(new KabalatLakoachTable().GetDataTable());
                dvUpdateKabala.RowFilter = "TazLakoach='" + cc.TazLakoach + "' and Status=true";
                int misKabala = (int)dvUpdateKabala[0][0];
                MyKabalatLakoach1 = new KabalatLakoach(misKabala);
                lblCode.Text = MyKabalatLakoach1.MisKabala.ToString();
                lblTazMetupal.Text = MyCustomers1.TazLakoach;
                lblShemPraty.Text = MyCustomers1.ShemPraty;
                lblShemMishpacha.Text = MyCustomers1.ShemMishpacha;
                lblTaharichKabala.Text = MyKabalatLakoach1.TaharichKabala.ToString();
                chkbPail.Checked = MyKabalatLakoach1.Status;
                lblHivchunKovezt.Text = MyKabalatLakoach1.ShemKovezHivchun;
                groupBox1.Enabled = false;
                btnLekvihatSidratTipulim.Visible = true;
                btnEyun.Visible = true;
            }
           
        }

        //private void FrmSidratTipulimVekvihatam_Load(object sender, EventArgs e)
        //{

        //}

        private void btnEshur_Click(object sender, EventArgs e)
        {
            if (MyFrmState=="NEW")
            {
                if (lblHivchunKovezt.Text=="")
                {
                    MessageBox.Show("עליך לבחור קובץ הפניה");
                }
                else
                {
                             MyKabalatLakoach1.MisKabala = Convert.ToInt32(lblCode.Text);
            MyKabalatLakoach1.Status = chkbPail.Checked;
            MyKabalatLakoach1.ShemKovezHivchun = lblHivchunKovezt.Text;
            MyKabalatLakoach1.TaharichKabala = Convert.ToDateTime(lblTaharichKabala.Text);
            MyKabalatLakoach1.TazLakoach = lblTazMetupal.Text;
            MyKabalatLakoach1.ShemKovezHivchun = file;

            MyKabalatLakoach1.Add();
                }
           

            }

           

            
            if (chkbPail.Checked==true)
            {
btnLekvihatSidratTipulim.Visible = true;
                btnEyun.Visible = true;
            }
            else
            {
                MessageBox.Show("המטופל מועבר לקבלת אשור קבלה");
                btnEshur.Enabled = false;
            }
            
        }

        private void btnLekvihatSidratTipulim_Click(object sender, EventArgs e)
        {
            grbKvihatSidratTipulim.Visible = true;
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddDays(14);

        }

        private void combTchumTipul_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dvOved.RowFilter = " ShemHitmachut  ='" + combTchumTipul.Text + "'";
            }
            catch (Exception)
            {

               
            }
            try
            {DataView dv = new DataView(new SidratTipulimTable().GetKabalatMetupal());
            dv.RowFilter = "CodeHitmachut=" + combTchumTipul.SelectedValue + " and TazLakoach='" + lblTazMetupal.Text+ "'";
            if (dv.Count>0)
            {
                MessageBox.Show("למטופל יש סידרת טיפולים קימת בתחום זה אין אפשרות לקבוע סידרה נוספת במקביל");
            }

            }
            catch (Exception)
            {

               
            }
            
            

        }

       // private void combMishmeret_SelectedIndexChanged(object sender, EventArgs e)
      //  {
           // if (combMishmeret.Text=="משמרת בוקר")
           // {
             //   numericUpShaha.Minimum = 8;
               // numericUpShaha.Maximum = 13;
           // }
            //if (combMishmeret.Text== "משמרת אחר הצהרים")
           // {
               // numericUpShaha.Minimum = 15;
               // numericUpShaha.Maximum = 18;
           // }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            mySdratTip1 = new SidratTipulim();
            

           
            if (combYomBeshavuha.Text=="")
            {
                MessageBox.Show("עליך לבחור זמני טיפול");
            }
            else
            { mySdratTip1.MisSidratTipulim = mySdratTipTT.GetNewKey();
            mySdratTip1.CodeHitmachut = Convert.ToInt32(combTchumTipul.SelectedValue);
            mySdratTip1.MisKabala = MyKabalatLakoach1.MisKabala;
            mySdratTip1.MisTipulimBesidra = Convert.ToInt32(numericUpMisTipulim.Value); 
            mySdratTip1.MisTipulimNotarim=Convert.ToInt32(numericUpMisTipulim.Value); 
            mySdratTip1.Shaha=Convert.ToInt32(numericUpShaha.Value);
            mySdratTip1.TazOved = combShemOved.SelectedValue.ToString();
           // mySdratTip1.TehurTipul =txtTEurTipul.Text;
            mySdratTip1.YomBeshevuha = combYomBeshavuha.Text;
  try
            {
                mySdratTip1.Add();

            }
            catch (Exception ex)
            {

                throw;
            }
           
          
            DateTime dd = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString());
           
            for (int i = 0; i < mySdratTip1.MisTipulimBesidra; i++)
            {
                myPerutipTBesid1 = new PerutTipulBesidra();
                myPerutipTBesid1.MistIPerutTipul = myPerTipBesT.GetNewKey();
                myPerutipTBesid1.MisSidratTipulim = mySdratTip1.MisSidratTipulim;
               myPerutipTBesid1.Taharich = dd;
                dd = dd.Date.AddDays(7);               
                    
                myPerutipTBesid1.TehurPehilut = "";
                myPerutipTBesid1.KezevHitkadmut = "";
                try
                {
                    myPerutipTBesid1.Add();

                  

                }
                catch (Exception ex)
                {

                    throw;
                }
                  
            }
            MessageBox.Show("הסדרה נוספה בהצלחה");
             AvBen();
                btnLekvihatSidratTipulim.Enabled = false;
                button2.Visible = true;
            }
        }

        public void AvBen()
        {
            dvPerutTipulimBesidra = new DataView(new PerutTipulBesidraTable().GetDataTable());
            dgvPerutTipulimBesidra.DataSource = dvPerutTipulimBesidra;
            dvPerutTipulimBesidra.RowFilter = "MisSidratTipulim=" + mySdratTip1.MisSidratTipulim;
            dgvPerutTipulimBesidra.Visible = true;
            dgvPerutTipulimBesidra.Columns[0].Visible = false;
            dgvPerutTipulimBesidra.Columns[1].HeaderText = "תאריך טיפול";
            dgvPerutTipulimBesidra.Columns[2].Visible = false;
            dgvPerutTipulimBesidra.Columns[3].Visible = false;
            dgvPerutTipulimBesidra.Columns[4].Visible = false;


        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            String yy="";
            switch (dateTimePicker1.Value.DayOfWeek)
            {
                case DayOfWeek.Sunday: yy = "ראשון";
                    break;
                case DayOfWeek.Monday: yy = "שני";
                   
                    break;
                case DayOfWeek.Tuesday: yy = "שלישי";
                    break;
                case DayOfWeek.Wednesday:yy = "רביעי";
                    
                    break;
                case DayOfWeek.Thursday:yy = "חמישי";
                    
                    break;
                  
 }
            if (yy!=combYomBeshavuha.Text)
            {
                MessageBox.Show("התאריך המבוקש לא יוצא ביום "+" "+combYomBeshavuha.Text);
            }
        }

        private void combYomBeshavuha_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void dgvPerutTipulimBesidra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (combShemOved.SelectedValue==null)
            {
                MessageBox.Show("עליך להזין שם התמחות ושם עובד");
            }
            else
            {
  Employess MyEmployess = new Employess(combShemOved.SelectedValue.ToString());
            Customers MyCustomers = new Customers(lblTazMetupal.Text);
            FrmMaharechetTorim ff = new FrmMaharechetTorim(MyEmployess,this);
            ff.ShowDialog();
            }
          

        }

        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void FrmSidratTipulimVekvihatam_Load(object sender, EventArgs e)
        {

        }

        private void btnKoveztHivchun_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            file  = openFileDialog1.FileName;
            lblHivchunKovezt.Text = file;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dgvPerutTipulimBesidra.Visible = false;
            combTchumTipul.SelectedIndex = 0;
           
            numericUpMisTipulim.Value = numericUpMisTipulim.Minimum;
            numericUpShaha.Value = numericUpShaha.Minimum;
            combYomBeshavuha.SelectedValue = null;
            try
            {
                dvOved.RowFilter = " ShemHitmachut  ='" + combTchumTipul.Text + "'";
            }
            catch (Exception)
            {


            }


        }

        private void btnEyun_Click(object sender, EventArgs e)
        {
            string file = MyKabalatLakoach1.ShemKovezHivchun;
            openFileDialog1.FileName = file;
            //openFileDialog1.ShowDialog();
            word.Word.Application winword = new word.Word.Application();
            word.Word.Document ww = winword.Documents.Open(file);

        }
    }
}
