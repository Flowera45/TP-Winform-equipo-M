using Dominio;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinformApp
{
    public partial class frmArticuloEliminar : Form
    {
        public frmArticuloEliminar()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtBoxBuscar.Text.Trim();
                ArticuloNegocio negocio = new ArticuloNegocio();
                List<Articulo> todos = negocio.listar();

                List<Articulo> resultado;

                if (string.IsNullOrEmpty(criterio))
                {
                    resultado = todos;
                }
                else
                {
                    int idBuscado;
                    bool esNumero = int.TryParse(criterio, out idBuscado);

                    resultado = todos.Where(a => (esNumero && a.Id == idBuscado)).ToList();
                }

                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = resultado;
                dgvArticulos.Columns["IdMarca"].Visible = false;
                dgvArticulos.Columns["IdCategoria"].Visible = false;

                if (resultado.Count == 0)
                {
                    MessageBox.Show("El artículo no existe");
                }


            }
            catch (FormatException)
            {
                MessageBox.Show("El id debe ser un numero");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvArticulos.CurrentRow == null || dgvArticulos.CurrentRow.DataBoundItem == null)
                {
                    MessageBox.Show("Por favor, busque y seleccione un artículo primero.");
                    return;
                }

                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar este artículo?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

                    ArticuloNegocio negocio = new ArticuloNegocio();
                    negocio.eliminar(seleccionado.Id);

                    MessageBox.Show("Artículo eliminado correctamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al eliminar: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
