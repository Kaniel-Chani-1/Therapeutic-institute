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
    public partial class FrmLoPail : Form
    {
        DataView dv;
        Employess MyEmployess1;
        public FrmLoPail()
        {
            InitializeComponent();
           
        }
        public void TextTable()
        { dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].HeaderText ="מספר זהות מטפל";
            dataGridView1.Columns[5].HeaderText = "מספר זהות מטופל";
            dataGridView1.Columns[6].HeaderText = "שם פרטי";
            dataGridView1.Columns[7].HeaderText = "שם משפחה";
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;
            dataGridView1.Columns[10].Visible = false;
            dataGridView1.Columns[11].Visible = false;
            dataGridView1.Columns[13].HeaderText = "תאריך קבלה";
            dataGridView1.Columns[12].Visible = false;


        }
        public FrmLoPail(Employess ee)
        {
            InitializeComponent();
            MyEmployess1 = new Employess(ee.TazOved);
            DateTime dd = DateTime.Today.AddDays(-14);
            dv = new DataView(new SidratTipulimTable().GetAllSdarot());
            dv.RowFilter = "TaharichKabala<'" + dd + "' and CodeHitmachut='" + MyEmployess1.CodeHitmachut + "' and Status=false";
            dataGridView1.DataSource = dv;
            TextTable();
        }

        private void FrmLoPail_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
