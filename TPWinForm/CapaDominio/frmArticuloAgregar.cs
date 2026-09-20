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

namespace WinformApp
{
    public partial class frmArticuloAgregar : Form
    {
        public frmArticuloAgregar()
        {
            InitializeComponent();
        }

            private void frmArticulo_Load(object sender, EventArgs e)
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

                cboMarca.DataSource = marcaNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();
            }

        private void cargarImagen(string imagen)
        {
            try
            {
                pBoxImagen.Load(imagen);
            }
            catch (Exception)
            {
                pBoxImagen.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    MessageBox.Show("El código no puede estar vacío");
                    return;
                }

                bool codigoExiste = negocio.listar().Any(a => a.Codigo.ToLower() == txtCodigo.Text.Trim().ToLower());

                if (codigoExiste)
                {
                    MessageBox.Show("Ya existe un artículo con ese código.");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacío");
                    return;
                }
                
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("La descripción no puede estar vacía");
                    return;
                }
                if (txtDescripcion.Text.Trim().Length > 50)
                {
                    MessageBox.Show("La descripción no puede tener más de 50 caracteres.");
                    return;
                }
                decimal precio;

                if (!decimal.TryParse(txtPrecio.Text, out precio))
                {
                    MessageBox.Show("El precio debe ser un número válido");
                    return;
                }
                if (precio <=0)
                { MessageBox.Show("El precio debe ser mayor a cero");
                    return;
                }
                if (cboMarca.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una marcar");
                    return;
                }
                if (cboCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una categoría");
                    return;
                }

                
                nuevo.Codigo = txtCodigo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.Precio = decimal.Parse(txtPrecio.Text);

                nuevo.Marca = (Marca)cboMarca.SelectedItem;
                nuevo.Categoria = (Categoria)cboCategoria.SelectedItem;

                negocio.agregar(nuevo);

                Articulo articuloGuardado = negocio.listar().FirstOrDefault(a => a.Codigo == nuevo.Codigo);

                if (articuloGuardado != null)
                {
                    ImagenNegocio imagenNegocio = new ImagenNegocio();

                    foreach (string url in listImagen.Items)
                    {
                        Imagen nuevaImagen = new Imagen();

                        nuevaImagen.IdArticulo = articuloGuardado.Id;
                        nuevaImagen.ImagenUrl = url;


                        imagenNegocio.agregar(nuevaImagen);
                    }
                }
                MessageBox.Show("Artículo agregado correctamente.");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el artículo: " + ex.Message);
            }

        }

        private void txtImagenUrl_leave(object sender, EventArgs e)
        {
            cargarImagen(txtImagenUrl.Text);
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtImagenUrl.Text))
            {
                MessageBox.Show("Debe ingresar una URL de imagen");
                return;
            }
            if(listImagen.Items.Contains(txtImagenUrl.Text.Trim()))
            {
                MessageBox.Show("Esa imagen ya fue agregada");
                return;
            }

            listImagen.Items.Add(txtImagenUrl.Text.Trim());
            txtImagenUrl.Text = "";
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            if(listImagen.SelectedItems == null)
            {
                MessageBox.Show("Debe seleccionar una imagen");
                return;
            }

            listImagen.Items.Remove(listImagen.SelectedItem);
        }

        private void listImagen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listImagen_Click(object sender, EventArgs e)
        {
            if (listImagen.SelectedItems != null)
            {
                cargarImagen(listImagen.SelectedItem.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
