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
    public partial class Experto : Form
    {
        public Experto()
        {
            InitializeComponent();
            txtcambiable.Text = "";
            
        }

        private void btnAggHE_MouseEnter(object sender, EventArgs e)
        {
            txtcambiable.Text = "Agrega un nuevo hábito \n de estudio al sistema.";
        }

        private void bttnAggCar_MouseEnter(object sender, EventArgs e)
        {
            txtcambiable.Text = "Agrega Caracteristicas al sistema.";
        }

        private void bttnCuadro_MouseEnter(object sender, EventArgs e)
        {
            txtcambiable.Text = "Agrega cuadro \n morfologico al sistema.";
        }

        private void bttnSalir_MouseEnter(object sender, EventArgs e)
        {
            txtcambiable.Text = "Salir";
        }

        private void bttnSalir_MouseLeave(object sender, EventArgs e)
        {
            txtcambiable.Text = "Menú Interfaz Experto";
        }

        private void bttnCuadro_MouseLeave(object sender, EventArgs e)
        {
            txtcambiable.Text = "Menú Interfaz Experto";
        }

        private void bttnAggCar_MouseLeave(object sender, EventArgs e)
        {
            txtcambiable.Text = "Menú Interfaz Experto";
        }

        private void btnAggHE_MouseLeave(object sender, EventArgs e)
        {
            txtcambiable.Text = "Menú Interfaz Experto";
        }

        private void btnAggHE_Click(object sender, EventArgs e)
        {
            habitosCRUD habito = new habitosCRUD();
            habito.Show();
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void eliminarCaracteristicasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarHabitosDeEstudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            habitosCRUD habito = new habitosCRUD();
            habito.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
