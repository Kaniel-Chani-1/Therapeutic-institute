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
    public partial class FrmCnisatRoshTchum : Form
    {
        DataView dvTaz;
        public FrmCnisatRoshTchum()
        {
            InitializeComponent();
        }

        private void btnEshur_Click(object sender, EventArgs e)
        {
            dvTaz = new DataView(new EmployessTable().GetDataTable());
            dvTaz.RowFilter = "TazOved='" + txtMisZehut.Text + "'";
            if (dvTaz.Count > 0)
            {
                FrmSidratTipulim ff = new FrmSidratTipulim(txtMisZehut.Text);
                ff.Show();
                this.Close();

            }
            else
            {
                MessageBox.Show("המספר לא זוהה נסה שוב");
                txtMisZehut.Text = "";
            }
        }

        private void FrmCnisatRoshTchum_Load(object sender, EventArgs e)
        {

        }
    }
}
