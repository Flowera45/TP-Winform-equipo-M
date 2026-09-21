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
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticuloBuscar ventana = new frmArticuloBuscar();
            ventana.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticuloEliminar ventana = new frmArticuloEliminar();
            ventana.ShowDialog();
        }

        //CATEGORÍA
        private void mostrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategoriaMostrar ventana = new frmCategoriaMostrar();
            ventana.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategoriaAgregar ventana = new frmCategoriaAgregar();
            ventana.ShowDialog();
        }

        private void modificarToolStripMenuItem1_click(object sender, EventArgs e)
        {
            frmCategoriaModificar ventana = new frmCategoriaModificar();
            ventana.ShowDialog();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategoriaEliminar ventana = new frmCategoriaEliminar();
            ventana.ShowDialog();
        }

        private void buscarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCategoriaBuscar ventana = new frmCategoriaBuscar();
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

        private void modicarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmMarcaModificar ventana = new frmMarcaModificar();
            ventana.ShowDialog();
        }

        private void eliminarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmMarcaEliminar ventana = new frmMarcaEliminar();
            ventana.ShowDialog();
        }

        private void buscarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmMarcaBuscar ventana = new frmMarcaBuscar();
            ventana.ShowDialog();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticuloModificar ventana = new frmArticuloModificar();
            ventana.ShowDialog();
        }

    }

}
