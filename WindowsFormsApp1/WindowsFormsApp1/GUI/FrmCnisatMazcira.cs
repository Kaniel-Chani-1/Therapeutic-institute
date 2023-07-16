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
    public partial class FrmCnisatMazcira : Form
    {
        public FrmCnisatMazcira()
        {
            InitializeComponent();
        }

        private void btnEshur_Click(object sender, EventArgs e)
        {
            if (txtMisSisma.Text=="1234")
            {
                FrmTofesMazcira ff = new FrmTofesMazcira();
                ff.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("הסיסמה לא זוהתה נסה שוב");
                txtMisSisma.Text = "";
            }
        }

        private void txtMisSisma_KeyPress(object sender, KeyPressEventArgs e)
        {
           
          
        }

        private void txtMisSisma_TextChanged(object sender, EventArgs e)
        {
           // try
          //  {
 //Employess ee = new Employess(txtMisSisma.Text);
        //    Hitmachuiot hh = new Hitmachuiot(ee.CodeHitmachut);
          //  label3.Text = ee.ShemPraty + " " + ee.ShemMishpacha + " " + hh.ShemHitmachut;
          //  }
           // catch (Exception)
          //  {

              //  throw;
           // }
           
        }

        private void FrmCnisatMazcira_Load(object sender, EventArgs e)
        {

        }
    }
}
