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
    }
}
