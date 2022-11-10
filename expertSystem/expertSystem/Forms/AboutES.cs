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
    public partial class AboutES : Form
    {
        public AboutES()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExpertSystem.ActiveForm.Show();
            //ExpertSystem inicial = ExpertSystem();
            //inicial.Show();
            this.Hide();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autores autores = new Autores();
            autores.Show();
            this.Hide();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
    }
}
