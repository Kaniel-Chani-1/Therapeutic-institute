using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.GUI;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
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

        private void התמחויותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHitmachuiotTable ff = new FrmHitmachuiotTable();
            ff.Show();
        }

        private void קידומותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKidomotTable ff = new FrmKidomotTable();
            ff.Show();
        }

        private void לקוחותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomersTable ff = new FrmCustomersTable();
            ff.Show();
        }

        private void עובדיםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmployessTable ff = new FrmEmployessTable();
            ff.Show();
        }

        private void קביעתסידרתטיפוליםלמטופלToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSidratTipulimVekvihatam ff = new FrmSidratTipulimVekvihatam();
            ff.Show();
        }

        private void יומןתוריםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void תוריםלהיוםToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTorimLehayom ff = new FrmTorimLehayom();
            ff.Show();
        }

        private void יומןתוריםמלאToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYomanTorim ff = new FrmYomanTorim();
            ff.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmCnisatMetapel ff = new FrmCnisatMetapel();
            ff.Show();
        }

        private void סדרותטיפוליםקימותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSidratTipulim ff = new FrmSidratTipulim();
            ff.Show();
        }

        private void btnCnisatMazcira_Click(object sender, EventArgs e)
        {
            FrmCnisatMazcira ff = new FrmCnisatMazcira();
            ff.Show();
        }

        private void btnRoshTchum_Click(object sender, EventArgs e)
        {
            FrmCnisatRoshTchum ff = new FrmCnisatRoshTchum();
            ff.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
