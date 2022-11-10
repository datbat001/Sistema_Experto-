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
    public partial class Autores : Form
    {
        public Autores()
        {
            InitializeComponent();
            namemom.ForeColor.Equals(Color.Red);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutES f2 = new AboutES();
            f2.Show();
            this.Hide();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
