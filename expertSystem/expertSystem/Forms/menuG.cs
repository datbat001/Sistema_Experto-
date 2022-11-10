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
    public partial class menuG : Form
    {
        public String welcome = "Bienvenido al sistema experto \n para la identificación de hábitos de estudio";
        public menuG()
        {
            InitializeComponent();
            textMenu.BackColor = Color.Transparent;
            btnInterfazExperto.BackColor = Color.Transparent;
            label1.Text = welcome;

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutES f2 = new AboutES();
            f2.Show();
            this.Hide();
        }

        private void autoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Autores autores = new Autores();
            autores.Show();
            this.Hide();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInterfazExperto_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Se Captura el conocimiento del experto, el objeto, \n sus caracteristicas y el cuadro relación";
        }

        private void btnInterfazExperto_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = welcome;
        }

        private void btnInterfazUsuario_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Interfaz Usuario";
        }

        private void btnInterfazUsuario_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = welcome;
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Salir";
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = welcome;
        }

        private void btnInterfazExperto_Click(object sender, EventArgs e)
        {
            Experto experto = new Experto();
            experto.Show();
            this.Hide();
        }
    }
}
