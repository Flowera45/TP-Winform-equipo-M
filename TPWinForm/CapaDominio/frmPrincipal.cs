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
        //ARTíCULO
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
        //CATEGORÍA
        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategoriaMostrar ventana = new frmCategoriaMostrar();
            ventana.ShowDialog();
        }

        //MARCA
        private void mostrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmMarcaMostrar ventana = new frmMarcaMostrar();
            ventana.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmMarcaAgregar ventana = new frmMarcaAgregar();
            ventana.ShowDialog();

        }
    }

}
