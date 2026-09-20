using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;

namespace WinformApp
{
    public partial class frmArticuloBuscar : Form
    {
        public frmArticuloBuscar()
        {
            InitializeComponent();
        }

        private void btnBucar_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtBuscar.Text.Trim();
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

                    resultado = todos.Where(a => (esNumero && a.Id == idBuscado) || a.Codigo.ToLower().Contains(criterio.ToLower()) || a.Nombre.ToLower().Contains(criterio.ToLower()) || a.Descripcion.ToLower().Contains(criterio.ToLower()) || a.Marca.Descripcion.ToLower().Contains(criterio.ToLower()) || a.Categoria.Descripcion.ToLower().Contains(criterio.ToLower())).ToList();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
