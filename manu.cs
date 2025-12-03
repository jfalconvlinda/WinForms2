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
    public partial class manu : Form
    {
        public manu()
        {
            InitializeComponent();
        }

        private void dueñoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuAdministrador form = new MenuAdministrador();
            form.Show();

        }

        private void cajeraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cajerocs form = new Cajerocs();
            form.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();


        }
    }
}
