using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticuloMostrar ventana = new frmArticuloMostrar();
            ventana.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticuloAgregar ventana = new frmArticuloAgregar();

            ventana.ShowDialog();
        }
    }
}
