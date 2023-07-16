using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.BLL;
using System.Windows.Forms;

namespace WindowsFormsApp1.GUI
{
    public partial class FrmMaharechetTorim : Form
    {
        DataView dv;
        FrmSidratTipulimVekvihatam mySourac;
        Hitmachuiot hh;
        public FrmMaharechetTorim()
        {
            InitializeComponent();
            dv = new DataView(new SidratTipulimTable().GetDataTable());
            dgvMaharechetTorim.DataSource = dv;
            dv.RowFilter = "MisTipulimNotarim>0";

        }
        public FrmMaharechetTorim(Employess myEmp,FrmSidratTipulimVekvihatam ff)
        {
            InitializeComponent();
            dv = new DataView(new SidratTipulimTable().GetDataTable());
            dgvMaharechetTorim.DataSource = dv;
            dv.RowFilter = "MisTipulimNotarim>0 and TazOved='" + myEmp.TazOved + "'";
            mySourac = ff;
            ppppee();
            label10.Text = myEmp.ShemPraty + " " + myEmp.ShemMishpacha;
            hh = new Hitmachuiot(myEmp.CodeHitmachut);
            label9.Text = hh.ShemHitmachut;
        }

        public void ppppee()
        {
            for (int i = 0; i < dgvMaharechetTorim.RowCount-1; i++)
            {
                if (dgvMaharechetTorim.Rows[i].Cells["YomBeshevuha"].Value.ToString()=="ראשון")
                {
                    foreach (Button bb in groupBox1.Controls)
                    {
                        if (Convert.ToInt32(bb.Tag)==Convert.ToInt32(dgvMaharechetTorim.Rows[i].Cells["Shaha"].Value))
                        {
                            bb.Text = "תפוס";
                            bb.Enabled = false;

                        }

                    }
                }
                if (dgvMaharechetTorim.Rows[i].Cells["YomBeshevuha"].Value.ToString() == "שני")
                {
                    foreach (Button bb in groupBox1.Controls)
                    {
                        if (Convert.ToInt32(bb.Tag) == Convert.ToInt32(dgvMaharechetTorim.Rows[i].Cells["Shaha"].Value))
                        {
                            bb.Text = "תפוס";
                            bb.Enabled = false;

                        }

                    }
                }
                if (dgvMaharechetTorim.Rows[i].Cells["YomBeshevuha"].Value.ToString() == "שלישי")
                {
                    foreach (Button bb in groupBox1.Controls)
                    {
                        if (Convert.ToInt32(bb.Tag) == Convert.ToInt32(dgvMaharechetTorim.Rows[i].Cells["Shaha"].Value))
                        {
                            bb.Text = "תפוס";
                            bb.Enabled = false;

                        }

                    }
                }
                if (dgvMaharechetTorim.Rows[i].Cells["YomBeshevuha"].Value.ToString() == "רביעי")
                {
                    foreach (Button bb in groupBox1.Controls)
                    {
                        if (Convert.ToInt32(bb.Tag) == Convert.ToInt32(dgvMaharechetTorim.Rows[i].Cells["Shaha"].Value))
                        {
                            bb.Text = "תפוס";
                            bb.Enabled = false;

                        }

                    }
                }
                if (dgvMaharechetTorim.Rows[i].Cells["YomBeshevuha"].Value.ToString() == "חמישי")
                {
                    foreach (Button bb in groupBox1.Controls)
                    {
                        if (Convert.ToInt32(bb.Tag) == Convert.ToInt32(dgvMaharechetTorim.Rows[i].Cells["Shaha"].Value))
                        {
                            bb.Text = "תפוס";
                            bb.Enabled = false;

                        }

                    }
                }
            }


        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmMaharechetTorim_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button bb = (Button)sender;
            mySourac.numericUpShaha.Value =Convert.ToInt32( bb.Tag);
            mySourac.combYomBeshavuha.Text = "ראשון";
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Button bb = (Button)sender;
            mySourac.numericUpShaha.Value = Convert.ToInt32(bb.Tag);
            mySourac.combYomBeshavuha.Text = "שני";
            this.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Button bb = (Button)sender;
            mySourac.numericUpShaha.Value = Convert.ToInt32(bb.Tag);
            mySourac.combYomBeshavuha.Text = "שלישי";
            this.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Button bb = (Button)sender;
            mySourac.numericUpShaha.Value = Convert.ToInt32(bb.Tag);
            mySourac.combYomBeshavuha.Text = "רביעי";
            this.Close();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Button bb = (Button)sender;
            mySourac.numericUpShaha.Value = Convert.ToInt32(bb.Tag);
            mySourac.combYomBeshavuha.Text = "חמישי";
            this.Close();
        }

        private void dgvMaharechetTorim_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
