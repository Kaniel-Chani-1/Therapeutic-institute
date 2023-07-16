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
    public partial class FrmSidratTipulim : Form
    {
        DataView dv;
        Employess MyEmployess1;
        Hitmachuiot hh;
        Customers MyCCustomers1;
        SidratTipulim MySidratTipulim1;
        Hitmachuiot MyHitmachuiot1;
        DataView dvEyun;
        public FrmSidratTipulim()
        {
            InitializeComponent();
          dgtSidratTipulim.DataSource = new SidratTipulimTable().GetAllSdarotMurchav();
            
        }
        public FrmSidratTipulim(string tz)
        {
            InitializeComponent();
            MyEmployess1 = new Employess(tz);
            dv = new DataView(new SidratTipulimTable().GetAllSdarotMurchav());
            DateTime dd = DateTime.Today.AddDays(-14);
            dv.RowFilter= "Status=true and CodeHitmachut='" + MyEmployess1.CodeHitmachut + "'"; 
            dgtSidratTipulim.DataSource = dv;
            TextTable();
            hh = new Hitmachuiot(MyEmployess1.CodeHitmachut);
            label1.Text = "המטופלים ב" +hh.ShemHitmachut ;
            
        }
       
        public void TextTable()
        {
            dgtSidratTipulim.Columns[0].Visible = false;
            dgtSidratTipulim.Columns[1].Visible = false;
            dgtSidratTipulim.Columns[2].Visible = false;
            dgtSidratTipulim.Columns[3].Visible = false;
            dgtSidratTipulim.Columns[4].HeaderText = "מספר זהות מטופל";
            dgtSidratTipulim.Columns[5].HeaderText = "שם פרטי";
            dgtSidratTipulim.Columns[6].HeaderText = "שם משפחה";
            dgtSidratTipulim.Columns[7].HeaderText = "מספר טיפולים בסדרה";
            dgtSidratTipulim.Columns[8].HeaderText = "מספר טיפולים נותרים";
            dgtSidratTipulim.Columns[9].Visible = false;
            dgtSidratTipulim.Columns[10].Visible = false;
            dgtSidratTipulim.Columns[11].Visible = false;
            dgtSidratTipulim.Columns[13].HeaderText = "שם מטפל";
            dgtSidratTipulim.Columns[12].HeaderText = "תאריך קבלה";
            dgtSidratTipulim.Columns[14].HeaderText = "שם תחום טיפול";
            dgtSidratTipulim.Columns[15].Visible = false; 


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmSidratTipulim_Load(object sender, EventArgs e)
        {

        }

        private void btnMetupalLoPail_Click(object sender, EventArgs e)
        {
            FrmLoPail ff = new FrmLoPail(MyEmployess1);
            ff.Show();
        }

        private void btnEshurMetupalim_Click(object sender, EventArgs e)
        {
            FrmEshurMetupalim ff = new FrmEshurMetupalim();
            ff.Show();
        }

        private void btnLeun_Click(object sender, EventArgs e)
        {
            dvEyun = new DataView(new PerutTipulBesidraTable().GetDataTable());
            dvEyun.RowFilter = "MisSidratTipulim=" + dgtSidratTipulim.SelectedRows[0].Cells[0].Value;
            FrmPerutTipulimBesidra ff = new FrmPerutTipulimBesidra(new PerutTipulBesidra((int) dvEyun[0][0]),"ZFIIA","menahel");
            ff.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySidratTipulim1 = new SidratTipulim(Convert.ToInt32(dgtSidratTipulim.SelectedRows[0].Cells[0].Value));
            if (MessageBox.Show("האם אתה בטוח שברצונך להוסיף טיפולים", "מכון שלבים", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                MySidratTipulim1.MisTipulimBesidra = MySidratTipulim1.MisTipulimBesidra + Convert.ToInt32(numericUpDown1.Value);

                MessageBox.Show("הטיפולים הוספו בהצלחה");
                MySidratTipulim1.Update();
                dv = new DataView(new SidratTipulimTable().GetAllSdarot());
                dv.RowFilter = "Status=true and CodeHitmachut='" + MyEmployess1.CodeHitmachut + "'";
                dgtSidratTipulim.DataSource = dv;
                groupBox1.Visible = false;
            }
        }

        private void btnHosafatTipulim_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            MyCCustomers1 = new Customers(Convert.ToString(dgtSidratTipulim.SelectedRows[0].Cells[4].Value));
            lblNameMetupal.Text = MyCCustomers1.ShemPraty + " " + MyCCustomers1.ShemMishpacha;
            MyEmployess1=new Employess(Convert.ToString(dgtSidratTipulim.SelectedRows[0].Cells[15].Value));
            lblNameMetapel.Text = MyEmployess1.ShemPraty + " " + MyEmployess1.ShemMishpacha;
            MySidratTipulim1=new SidratTipulim(Convert.ToInt32(dgtSidratTipulim.SelectedRows[0].Cells[0].Value));
            MyHitmachuiot1 = new Hitmachuiot(MySidratTipulim1.CodeHitmachut);
            lblTchumTipul.Text = MyHitmachuiot1.ShemHitmachut;
            lblMisTipulim.Text = MySidratTipulim1.MisTipulimBesidra.ToString();

        }
    }
}
