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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtLogin.BackColor = Color.Transparent;
            txtPassword.BackColor = Color.Transparent;
            //txtPasswordGiven.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtPasswordGiven.Text == "admin")
            {
                menuG menu = new menuG();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPasswordGiven_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}
