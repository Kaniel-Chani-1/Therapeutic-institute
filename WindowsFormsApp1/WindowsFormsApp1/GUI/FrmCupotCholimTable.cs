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
    public partial class FrmCupotCholimTable : Form
    {
        CupotCholimTable MyCupotCholimT = new CupotCholimTable();
        CupotCholim MyCupotCholim1;
        public FrmCupotCholimTable()
        {
            InitializeComponent();
            dgvCupotCholimTable.DataSource = MyCupotCholimT.GetDataTable();
            dgvCupotCholimTable.Columns[0].HeaderText = "קוד קופה";
            dgvCupotCholimTable.Columns[1].HeaderText = " שם קופה";


        }

        private void FrmCupotCholimTable_Load(object sender, EventArgs e)
        {

        }

        private void dgvCupotCholimTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            grbAddUpdate.Visible = true;
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            MyCupotCholim1 = new CupotCholim(Convert.ToInt32(dgvCupotCholimTable.SelectedRows[0].Cells[0].Value));
            lblCodeCupa.Text = Convert.ToString(MyCupotCholim1.CodeCupatCholim);
            txtShemCupa.Text = MyCupotCholim1.ShemCupatCholim;
        }

        private void dgvCupotCholimTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool degel = true;
            errorProvider1.Clear();
            // btnAdd.Visible = false;
            //  btnUpdate.Visible = true;

            try
            {
                MyCupotCholim1.ShemCupatCholim = txtShemCupa.Text;

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtShemCupa, ex.Message);
                degel = false;

            }

            if (degel)
            {
                try
                {
                    MyCupotCholim1.Update();
                    MessageBox.Show("העיר עודכנה בהצלחה");
                    grbAddUpdate.Visible = false;
                    //  btnNew.Visible = true;
                    // btnDelete.Visible = true;
                }
                catch (Exception ex)
                {

                    errorProvider1.SetError(txtShemCupa, ex.Message);


                }

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            grbAddUpdate.Visible = true;
            btnAdd.Visible = true;
            btnUpdate.Visible = false;
            lblCodeCupa.Text = MyCupotCholimT.GetNewKey().ToString();
            txtShemCupa.Text = "";



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MyCupotCholim1 = new CupotCholim();
            errorProvider1.Clear();
            bool degel = true;
            MyCupotCholim1.CodeCupatCholim = Convert.ToInt32(lblCodeCupa.Text);

            try
            {
                MyCupotCholim1.ShemCupatCholim = txtShemCupa.Text;
            }
            catch (Exception ex)
            {

                MessageBox.Show(txtShemCupa, ex.Message);
                degel = false;
            }
            if (degel)
            {
                try
                {
                    MyCupotCholim1.Add();
                    grbAddUpdate.Visible = false;
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(txtShemCupa, ex.Message);
                    MessageBox.Show("קופה זו קימת במאגר");


                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MyCupotCholim1 = new CupotCholim(Convert.ToInt32(dgvCupotCholimTable.SelectedRows[0].Cells[0].Value));
            DataView dvCust = new DataView(new CustomersTable().GetDataTable());
            dvCust.RowFilter = "CodeCupatCholim=" + MyCupotCholim1.CodeCupatCholim;
            if ( dvCust.Count == 0)
            {

                if (MessageBox.Show("האם אתה בטוח שברצונך למחוק את הקופה", "מכון שלבים", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    MyCupotCholim1.Delete();
                }



            }
            else
            {
                MessageBox.Show("הקופה מקושרת לטבלאות אחרות אין אפשרות מחיקה");
            }
        }

        private void txtShemCupa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == '\b' || e.KeyChar == ' ' || e.KeyChar == '-')
            {

            }
            else
                e.Handled = true;
        }
    }
}
  
