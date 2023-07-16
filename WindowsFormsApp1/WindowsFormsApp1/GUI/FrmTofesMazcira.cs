using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI
{
    public partial class FrmTofesMazcira : Form
    {
        public FrmTofesMazcira()
        {
            InitializeComponent();
        }

        private void מאגריעזרToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void עריםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCityTable ff = new FrmCityTable();
            ff.Show();

        }

        private void קופותחוליםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCupotCholimTable ff = new FrmCupotCholimTable();
            ff.Show();
        }

        private void תחומיטיפולToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHitmachuiotTable ff = new FrmHitmachuiotTable();
            ff.Show();
        }

        private void קידומותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKidomotTable ff = new FrmKidomotTable();
            ff.Show();
        }

        private void מטופליםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomersTable ff = new FrmCustomersTable();
            ff.Show();
        }

        private void יומןתוריםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYomanTorim ff = new FrmYomanTorim();
            ff.Show();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
