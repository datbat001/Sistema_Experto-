using expertSystem.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace expertSystem
{
    public partial class ExpertSystem : Form
    {
        public ExpertSystem()
        {
            InitializeComponent();
            label1.BackColor = Color.Transparent;
            tecno.BackColor = Color.Transparent;
            itz.BackColor = Color.Transparent;
            tecnm.BackColor = Color.Transparent;
            About.BackColor = Color.AliceBlue;
            Enter.BackColor = Color.AliceBlue;
            btnSalir.BackColor = Color.AliceBlue;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void About_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutES f2 = new AboutES();
            f2.Show();
            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ExpertSystem_Load(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutES f2 = new AboutES();
            f2.Show();
        }

        private void autoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Autores autores = new Autores();
            autores.Show();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
