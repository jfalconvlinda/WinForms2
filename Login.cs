using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Login : Form
    {
        // USUARIOS PERMITIDOS
        string adminUser = "Admin";
        string adminPass = "Admin123";

        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string clave = txtClave.Text;

            // LOGIN ADMINISTRADOR
            if (usuario == adminUser && clave == adminPass)
            {
                MessageBox.Show("Bienvenido Administrador", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                MenuAdministrador admin = new MenuAdministrador();
                admin.Show();
                this.Hide();
            }
            // LOGIN MANU
            else if (usuario == "Manu" && clave == "Manu123")
            {
                MessageBox.Show("Bienvenido Manu", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                manu m = new manu();
                m.Show();
                this.Hide();
            }
            // LOGIN CAJERO
            else if (usuario == "Cajero" && clave == "Cajero123")
            {
                MessageBox.Show("Bienvenido Cajero", "Correcto",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                Cajerocs c = new Cajerocs();
                c.Show();
                this.Hide();
            }
            else
            {
                mensaje_error err = new mensaje_error();
                err.Show();
                this.Hide();
            }
        }
    }
}
