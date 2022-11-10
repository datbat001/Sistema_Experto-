using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expertSystem.Forms
{
    public partial class habitosCRUD : Form
    {
        public habitosCRUD()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Limpiar los campos?", "limpiar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                txtboxHabito.Text = "";
                txtbox2.Text = "";
            }
        }

        private void habitosCRUD_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'habitos_EstudioDataSet.objetos' table. You can move, or remove it, as needed.
            this.objetosTableAdapter.Fill(this.habitos_EstudioDataSet.objetos);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fomr = new Form1();
            fomr.Show();
        }
    }
}
