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


        private void frmArticuloBuscar_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                ImagenNegocio imagenNegocio = new ImagenNegocio();

                cboMarca.DataSource = marcaNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();

                //Para que se pueda buscar por mas que el item este vacio
                cboMarca.SelectedIndex = -1;
                cboCategoria.SelectedIndex = -1;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }
        private void btnBucar_Click(object sender, EventArgs e)
        {
            try
            {
               
                ArticuloNegocio negocio = new ArticuloNegocio();
                List<Articulo> resultado = negocio.listar();
                
                //Buscar por ID

                if (!string.IsNullOrWhiteSpace(txtId.Text))
                {
                    int id;
                    
                    if (!int.TryParse(txtId.Text, out id))
                    {
                        MessageBox.Show("El ID debe ser un número válido");
                        return;
                    }

                    resultado = resultado.Where(a => a.Id == id).ToList();

                }

                //Buscar por CÓDIGO

                if (!string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    string codigo = txtCodigo.Text.Trim().ToLower();

                    resultado = resultado.Where(a => a.Codigo.ToLower().Contains(codigo)).ToList();
                }

                //Buscar por NOMBRE

                if (!string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    string nombre = txtCodigo.Text.Trim().ToLower();

                    resultado = resultado.Where(a => a.Codigo.ToLower().Contains(nombre)).ToList();
                }

                //Buscar por MARCA

                if(cboMarca.SelectedItem !=null)
                {
                    Marca marcaSeleccionada = (Marca)cboMarca.SelectedItem;
                    
                    resultado = resultado .Where(a => a.Marca.Id == marcaSeleccionada.Id).ToList();
                }

                //Buscar por CATEGORIA

                if (cboCategoria.SelectedItem != null)
                {
                    Categoria categoriaSeleccionada = (Categoria)cboCategoria.SelectedItem;

                    resultado = resultado.Where(a => a.Categoria.Id == categoriaSeleccionada.Id).ToList();
                }


                //PRECIO 

                decimal precioDesde;
                decimal precioHasta;

                if (!string.IsNullOrWhiteSpace(txtPrecioDesde.Text))
                { 
                    if (!decimal.TryParse(txtPrecioDesde.Text, out precioDesde))
                    {
                        MessageBox.Show("El precio debe ser un númeor válido");
                        return;
                    }

                    if (precioDesde < 0)
                    {
                        MessageBox.Show("El precio no puede ser negativo");
                        return;
                    }

                    resultado = resultado.Where(a => a.Precio >= precioDesde).ToList();
                 
                }

                if (!string.IsNullOrWhiteSpace(txtPrecioHasta.Text))
                {
                    if (!decimal.TryParse(txtPrecioDesde.Text, out precioHasta))
                    {
                        MessageBox.Show("El precio debe ser un númeor válido");
                        return;
                    }

                    if (precioHasta < 0)
                    {
                        MessageBox.Show("El precio no puede ser negativo");
                        return;
                    }

                    resultado = resultado.Where(a => a.Precio >= precioHasta).ToList();

                }

                if (!string.IsNullOrWhiteSpace(txtPrecioDesde.Text) && !string.IsNullOrWhiteSpace(txtPrecioHasta.Text))
                {
                    decimal.TryParse(txtPrecioDesde.Text, out precioDesde);
                    decimal.TryParse(txtPrecioHasta.Text, out precioHasta);

                    if (precioDesde > precioHasta)
                    {
                        MessageBox.Show("El precio 'DESDE' no puede ser mayor que el 'HASTA'");
                        return;
                    }
                }

                //MUESTRA RESULTADOS
                 frmArticuloMostrar ventana = new frmArticuloMostrar(resultado);
                 ventana.ShowDialog();
              

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
