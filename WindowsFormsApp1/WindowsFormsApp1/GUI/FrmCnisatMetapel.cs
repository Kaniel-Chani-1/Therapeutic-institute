using System;
using System.Collections.Generic;
using System.Data;
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
    public partial class FrmCnisatMetapel : Form
    {
        DataView dvTaz;
        public FrmCnisatMetapel()
        {
            InitializeComponent();
        }

        private void btnEshur_Click(object sender, EventArgs e)
        {
            dvTaz = new DataView(new EmployessTable().GetDataTable());
            dvTaz.RowFilter = "TazOved='" + txtMisZehut.Text + "'";
            if (dvTaz.Count >0)
            {
                FrmTorimLehayom ff = new FrmTorimLehayom(txtMisZehut.Text);
                ff.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("המספר לא זוהה נסה שוב");
                txtMisZehut.Text = "";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtMisZehut_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMisZehut_MouseLeave(object sender, EventArgs e)
        {

        }

        private void txtMisZehut_TextAlignChanged(object sender, EventArgs e)
        {
           // try
           // {
             //   Employess ee = new Employess(txtMisZehut.Text);
             //   Hitmachuiot hh = new Hitmachuiot(ee.CodeHitmachut);
             ///   label3.Text = ee.ShemPraty + " " + ee.ShemMishpacha + " " + hh.ShemHitmachut;
            //}
           // catch (Exception)
           // {

              //  throw;
            //}
        }

        private void FrmCnisatMetapel_Load(object sender, EventArgs e)
        {

        }
    }
}
