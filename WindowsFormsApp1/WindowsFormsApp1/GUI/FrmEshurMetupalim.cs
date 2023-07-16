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
    public partial class FrmEshurMetupalim : Form
    {
        FrmCustomersTable ff;
        DataView dv;
        KabalatLakoach MyKabalatLakoach;
        public FrmEshurMetupalim()
        {
            InitializeComponent();
            AvBen();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "מספר זהות";
            dataGridView1.Columns[2].HeaderText = "שם פרטי";
            dataGridView1.Columns[3].HeaderText = "שם משפחה";
            dataGridView1.Columns[4].HeaderText = "תאריך קבלה";
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Visible = false;
           
        }
        //public FrmEshurMetupalim()
        //{
         //   InitializeComponent();
       // }
        private void FrmEshurMetupalim_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void AvBen()
        {
            DateTime dd = DateTime.Today.AddDays(-14);
            dv = new DataView(new SidratTipulimTable().GetEshurMetupalim());
            dv.RowFilter = "TaharichKabala>'" + dd + "' and Status=false";
            dataGridView1.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyKabalatLakoach = new KabalatLakoach(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            if (MessageBox.Show("האם אתה בטוח שברצונך לאשר את הטיפול", "מכון שלבים", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
               
            MyKabalatLakoach.Status = true;

                MessageBox.Show("המטופל אושר בהצלחה");
                MyKabalatLakoach.Update();
                AvBen();
               
            }

            
            
        }

        private void btnLeun_Click(object sender, EventArgs e)
        {
            string file = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            openFileDialog1.FileName = file;
            //openFileDialog1.ShowDialog();
            word.Word.Application winword = new word.Word.Application();
            word.Word.Document ww = winword.Documents.Open(file);


        }
    }
}
