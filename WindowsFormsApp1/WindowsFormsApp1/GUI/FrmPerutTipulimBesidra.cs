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

namespace WindowsFormsApp1.GUI
{
    public partial class FrmPerutTipulimBesidra : Form
    {
        PerutTipulBesidra MyPerutTipulBesidra1;
        PerutTipulBesidraTable MyPerutTipulBesidraT = new PerutTipulBesidraTable();
        SidratTipulim MySidratTipulim1;
        Customers MyCustomers1;
        Employess MyEmployess1;
        KabalatLakoach MyKabalatLakohach1;
        string MyFrmState;
        DataView dv;
        DataView dvSiumTipul;
        DataView dvMenael;
        DataView dvEyun;
        Hitmachuiot hh;
        public FrmPerutTipulimBesidra()
        {
            InitializeComponent();
            
        }
       
        public FrmPerutTipulimBesidra( PerutTipulBesidra pp,string FrmState, string mishtamesh)//המטפל מעדכן את הטיול
        {
            InitializeComponent();
            MyPerutTipulBesidra1 = pp;
            MyFrmState = FrmState;
            if (MyFrmState=="UPDATE")
            {
                button1.Visible = false;
                button2.Visible = true;
                button3.Visible = false;
            
            lblCodeTipul.Text = MyPerutTipulBesidra1.MistIPerutTipul.ToString();
            txtTaharich.Text = MyPerutTipulBesidra1.Taharich.ToShortDateString();
            txtTeurTipul.Text = MyPerutTipulBesidra1.TehurPehilut;
               
            if (txtTeurTipul.Text!="")
            {
                button2.Enabled = false;
                txtTeurTipul.Enabled = false;
                MessageBox.Show("הטיפול מדווח אין אפשרות לדווח שוב");
            }

            MySidratTipulim1 = new SidratTipulim(MyPerutTipulBesidra1.MisSidratTipulim);
            txtShaha.Text = MySidratTipulim1.Shaha.ToString()+":00";
            txtYomBeshavuha.Text = MySidratTipulim1.YomBeshevuha.ToString();
            lblCodeSidra.Text = MyPerutTipulBesidra1.MisSidratTipulim.ToString();
            MyEmployess1 = new Employess(MySidratTipulim1.TazOved);
            txtShemMetapel.Text = MyEmployess1.ShemPraty + " " + MyEmployess1.ShemMishpacha;
            txtTelMetapel1.Text = MyEmployess1.KidPelephone + "-" + MyEmployess1.Pelephone;
            txtTelMetapel2.Text = MyEmployess1.KidTelephone + "-" + MyEmployess1.Telephone;
            MyKabalatLakohach1 = new KabalatLakoach(MySidratTipulim1.MisKabala);
            MyCustomers1 = new Customers(MyKabalatLakohach1.TazLakoach);
            txtPelEmMetupal.Text = MyCustomers1.KidPelephoneEm + "-" + MyCustomers1.PelephoneEm;
            txtShemMetupal.Text = MyCustomers1.ShemPraty + " " + MyCustomers1.ShemMishpacha;
            txtTazMetupal.Text = MyCustomers1.TazLakoach;
            txtTelephoneMetupal.Text = MyCustomers1.KidTelephone + "-" + MyCustomers1.Telephone;
            txtPelAv.Text = MyCustomers1.KidPelephoneAv + "-" + MyCustomers1.PelephoneAv;
                hh = new Hitmachuiot(MyEmployess1.CodeHitmachut);
                label17.Text = hh.ShemHitmachut;
}
            if (MyFrmState=="ZFIIA")
            {watch(MyPerutTipulBesidra1);
                if (mishtamesh=="menahel")
                {
                    label15.Visible = true;
                    dataGridView1.Visible = true;
                    dvMenael = new DataView(new SidratTipulimTable().GetAllSdarotMurchav());
                    dvMenael.RowFilter = "TazLakoach='" + MyKabalatLakohach1.TazLakoach + "'and CodeHitmachut=" + MySidratTipulim1.CodeHitmachut;
                    dataGridView1.DataSource = dvMenael;
                    TextTable();
                }
               
              
                


            }
        }
        public void TextTable()
        {
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].HeaderText = "סטטוס";
            dataGridView1.Columns[13].HeaderText = "שם מטפל";
            dataGridView1.Columns[12].HeaderText = "תאריך קבלה";
            dataGridView1.Columns[14].Visible = false;
            dataGridView1.Columns[15].Visible = false;


        }

        // public FrmPerutTipulimBesidra(customer cc)
        //  {
        //  InitializeComponent();

        //}

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void FrmPerutTipulimBesidra_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtTeurTipul.Text == "")
            {
                MessageBox.Show("עליך להזין תאור טיפול");


            }
            else
            {
                MyPerutTipulBesidra1.TehurPehilut = txtTeurTipul.Text;
                if (MySidratTipulim1.MisTipulimNotarim>0)
                {MySidratTipulim1.MisTipulimNotarim = MySidratTipulim1.MisTipulimNotarim - 1;

                }
                
                try
                {
                    MyPerutTipulBesidra1.Update();
                    MySidratTipulim1.Update();
                }
                catch (Exception)
                {

                    throw;
                }
                if (MySidratTipulim1.MisTipulimNotarim < 3)
                {
                    MessageBox.Show("טיפולים" + MySidratTipulim1.MisTipulimNotarim + "סדרת הטיפולים עומדת להגמר נותרו עוד ");
                }
                if (MySidratTipulim1.MisTipulimNotarim == 0)
                {
                    dvSiumTipul = new DataView(new SidratTipulimTable().GetDataTable());
                    MySidratTipulim1 = new SidratTipulim(MyPerutTipulBesidra1.MisSidratTipulim);
                    dvSiumTipul.RowFilter = "MisKabala=" + MySidratTipulim1.MisKabala + "and MisTipulimNotarim>0";
                    MyKabalatLakohach1 = new KabalatLakoach(MySidratTipulim1.MisKabala);
                    if (dvSiumTipul.Count==0)
                    {
                        MyKabalatLakohach1.Status = false;
                    }

                }
                    MessageBox.Show("הטיפול דווח בהצלחה");
                this.Close();
            }
          
          
        }

        private void txtTazMetupal_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTazMetupal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '\b' )
            {

            }
            else
                e.Handled = true;
        }

        private void txtTeurTipul_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dd = MyPerutTipulBesidra1.Taharich;
            dd = dd.AddDays(-7);

            dv = new DataView(new PerutTipulBesidraTable().GetDataTable());
            dv.RowFilter = "MisSidratTipulim=" + MyPerutTipulBesidra1.MisSidratTipulim + "and Taharich='" + dd.ToShortDateString()+"'";
            if (dv.Count>0)
            {  int oo = (int)dv[0][0];
            MyPerutTipulBesidra1 = new PerutTipulBesidra(oo);
                watch(MyPerutTipulBesidra1);

            }
            else
            {
                MessageBox.Show("אין טיפולים קודמים בסדרה");     
            }
          

        }

        private void watch(PerutTipulBesidra MyPerutTipulBesidra1)
        {
            txtTeurTipul.Enabled = false;
            button2.Visible = false;
            button1.Visible = true;
            button3.Visible = true;

            lblCodeTipul.Text = MyPerutTipulBesidra1.MistIPerutTipul.ToString();
            txtTaharich.Text = MyPerutTipulBesidra1.Taharich.ToShortDateString();
            txtTeurTipul.Text = MyPerutTipulBesidra1.TehurPehilut;
            MySidratTipulim1 = new SidratTipulim(MyPerutTipulBesidra1.MisSidratTipulim);
            txtShaha.Text = MySidratTipulim1.Shaha.ToString() + ":00";
            txtYomBeshavuha.Text = MySidratTipulim1.YomBeshevuha.ToString();
            lblCodeSidra.Text = MyPerutTipulBesidra1.MisSidratTipulim.ToString();
            MyEmployess1 = new Employess(MySidratTipulim1.TazOved);
            txtShemMetapel.Text = MyEmployess1.ShemPraty + " " + MyEmployess1.ShemMishpacha;
            txtTelMetapel1.Text = MyEmployess1.KidPelephone + "-" + MyEmployess1.Pelephone;
            txtTelMetapel2.Text = MyEmployess1.KidTelephone + "-" + MyEmployess1.Telephone;
            MyKabalatLakohach1 = new KabalatLakoach(MySidratTipulim1.MisKabala);
            MyCustomers1 = new Customers(MyKabalatLakohach1.TazLakoach);
            txtPelEmMetupal.Text = MyCustomers1.KidPelephoneEm + "-" + MyCustomers1.PelephoneEm;
            txtShemMetupal.Text = MyCustomers1.ShemPraty + " " + MyCustomers1.ShemMishpacha;
            txtTazMetupal.Text = MyCustomers1.TazLakoach;
            txtTelephoneMetupal.Text = MyCustomers1.KidTelephone + "-" + MyCustomers1.Telephone;
            txtPelAv.Text = MyCustomers1.KidPelephoneAv + "-" + MyCustomers1.PelephoneAv;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime dd = MyPerutTipulBesidra1.Taharich;
            dd = dd.AddDays(+7);

            dv = new DataView(new PerutTipulBesidraTable().GetDataTable());
            dv.RowFilter = "MisSidratTipulim=" + MyPerutTipulBesidra1.MisSidratTipulim + "and Taharich='" + dd.ToShortDateString() + "'";
            if (dv.Count > 0&&dd<=DateTime.Today)
            {
                int oo = (int)dv[0][0];
                MyPerutTipulBesidra1 = new PerutTipulBesidra(oo);
                watch(MyPerutTipulBesidra1);

            }
            else
            {
                MessageBox.Show("אין טיפולים נוספים מדווחים ");
            }


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dvEyun = new DataView(new PerutTipulBesidraTable().GetDataTable());
            dvEyun.RowFilter = "MisSidratTipulim=" + dataGridView1.SelectedRows[0].Cells[0].Value;
            MyPerutTipulBesidra1 = new PerutTipulBesidra((int)dvEyun[0][0]);
            
            lblCodeTipul.Text = MyPerutTipulBesidra1.MistIPerutTipul.ToString();
            txtTaharich.Text = MyPerutTipulBesidra1.Taharich.ToShortDateString();
            txtTeurTipul.Text = MyPerutTipulBesidra1.TehurPehilut;
            MySidratTipulim1 = new SidratTipulim(MyPerutTipulBesidra1.MisSidratTipulim);
            txtShaha.Text = MySidratTipulim1.Shaha.ToString() + ":00";
            txtYomBeshavuha.Text = MySidratTipulim1.YomBeshevuha.ToString();
            lblCodeSidra.Text = MyPerutTipulBesidra1.MisSidratTipulim.ToString();
            MyEmployess1 = new Employess(MySidratTipulim1.TazOved);
            txtShemMetapel.Text = MyEmployess1.ShemPraty + " " + MyEmployess1.ShemMishpacha;
            txtTelMetapel1.Text = MyEmployess1.KidPelephone + "-" + MyEmployess1.Pelephone;
            txtTelMetapel2.Text = MyEmployess1.KidTelephone + "-" + MyEmployess1.Telephone;
            MyKabalatLakohach1 = new KabalatLakoach(MySidratTipulim1.MisKabala);
            MyCustomers1 = new Customers(MyKabalatLakohach1.TazLakoach);
            txtPelEmMetupal.Text = MyCustomers1.KidPelephoneEm + "-" + MyCustomers1.PelephoneEm;
            txtShemMetupal.Text = MyCustomers1.ShemPraty + " " + MyCustomers1.ShemMishpacha;
            txtTazMetupal.Text = MyCustomers1.TazLakoach;
            txtTelephoneMetupal.Text = MyCustomers1.KidTelephone + "-" + MyCustomers1.Telephone;
            txtPelAv.Text = MyCustomers1.KidPelephoneAv + "-" + MyCustomers1.PelephoneAv;


        }
    }
}
