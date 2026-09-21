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
    public partial class frmArticuloModificar : Form
    {
        private Articulo articuloSeleccionado;
        public frmArticuloModificar()
        {
            InitializeComponent();
        }

        private void frmArticuloModificar_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaNegocio marcaNegocio = new MarcaNegocio();
                CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.DisplayMember = "Descripción";
                cboMarca.ValueMember = "ID";
                cboMarca.SelectedIndex = -1;

                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.DisplayMember = "Descripción";
                cboCategoria.ValueMember = "ID";
                cboCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el formulario: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                int id;

                if (!int.TryParse(txtId.Text, out id))
                {
                    MessageBox.Show("El ID debe ser un número válido");
                    return;
                }

                ArticuloNegocio negocio = new ArticuloNegocio();
                articuloSeleccionado = negocio.listar().FirstOrDefault(a => a.Id == id);

                if (articuloSeleccionado == null)
                {
                    MessageBox.Show("No se encontró un artículo con ese ID");
                    limpiarCampos();
                    return;
                }

                txtCodigo.Text = articuloSeleccionado.Codigo;
                txtNombre.Text = articuloSeleccionado.Nombre;
                txtDescripcion.Text = articuloSeleccionado.Descripcion;
                txtPrecio.Text = articuloSeleccionado.Precio.ToString();

                cboMarca.SelectedValue = articuloSeleccionado.Marca.Id;
                cboCategoria.SelectedValue = articuloSeleccionado.Categoria.Id;

                cargarImagenesArticulo();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el artículo: " + ex.Message);
            }
        }

        private void cargarImagenesArticulo()
        {
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            List<Imagen> imagenes = imagenNegocio.listar().Where(i => i.IdArticulo == articuloSeleccionado.Id).ToList();

            listImagen.Items.Clear();

            foreach (Imagen imagen in imagenes)
            {
                listImagen.Items.Add(imagen.ImagenUrl);
            }

            if (listImagen.Items.Count > 0)
            {
                listImagen.SelectedIndex = 0;
                cargarImagen(listImagen.Items[0].ToString());
            }

            else
            {
                cargarImagen("");
            }

        }

        private void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
            cboCategoria.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
            listImagen.Items.Clear();
        }

        private void cargarImagen(string url)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(url))
                {
                    pBoxImagen.Image = null;
                    return;
                }

                pBoxImagen.Load(url);
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la imagen: " + ex.Message);
                pBoxImagen.Image = null;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (articuloSeleccionado == null)
                {
                    MessageBox.Show("Primero debe buscar un artículo.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtCodigo.Text))
                {
                    MessageBox.Show("El código no puede estar vacío.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    MessageBox.Show("El nombre no puede estar vacío.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtDescripcion.Text))
                {
                    MessageBox.Show("La descripción no puede estar vacía.");
                    return;
                }


                decimal precio;

                if (!decimal.TryParse(txtPrecio.Text, out precio))
                {
                    MessageBox.Show("El precio debe ser un número válido.");
                    return;
                }

                if (precio <= 0)
                {
                    MessageBox.Show("El precio debe ser mayor a cero.");
                    return;
                }

                if (cboMarca.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una marca.");
                    return;
                }

                if (cboCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una categoría.");
                    return;
                }

                ArticuloNegocio negocio = new ArticuloNegocio();

                // Verificamos que el código no pertenezca a OTRO artículo
                bool codigoExiste = negocio.listar().Any(a => a.Id != articuloSeleccionado.Id && a.Codigo.ToLower() == txtCodigo.Text.Trim().ToLower());

                if (codigoExiste)
                {
                    MessageBox.Show("Ya existe otro artículo con ese código.");
                    return;
                }


                // Actualizamos el objeto
                articuloSeleccionado.Codigo = txtCodigo.Text.Trim();
                articuloSeleccionado.Nombre = txtNombre.Text.Trim();
                articuloSeleccionado.Descripcion = txtDescripcion.Text.Trim();
                articuloSeleccionado.Precio = precio;
                articuloSeleccionado.Marca = (Marca)cboMarca.SelectedItem;
                articuloSeleccionado.Categoria = (Categoria)cboCategoria.SelectedItem;

                // MODIFICAR ARTÍCULO
                negocio.modificar(articuloSeleccionado);


                // MODIFICAR IMÁGENES
                ImagenNegocio imagenNegocio = new ImagenNegocio();

                imagenNegocio.eliminar(articuloSeleccionado.Id);

                foreach (string url in listImagen.Items)
                {
                    Imagen imagen = new Imagen();

                    imagen.IdArticulo = articuloSeleccionado.Id;
                    imagen.ImagenUrl = url;

                    imagenNegocio.agregar(imagen);
                }

                MessageBox.Show("Artículo modificado correctamente.");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al modificar el artículo: " + ex.Message
                );
            }
        }

        private void btnAgregarImagen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImagenUrl.Text))
            {
                MessageBox.Show("Debe ingresar una URL de imagen.");
                return;
            }

            if (listImagen.Items.Contains(txtImagenUrl.Text.Trim()))
            {
                MessageBox.Show("Esa imagen ya fue agregada.");
                return;
            }

            listImagen.Items.Add(txtImagenUrl.Text.Trim());

            cargarImagen(txtImagenUrl.Text.Trim());

            txtImagenUrl.Text = "";
        }

        private void btnQuitarImagen_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtImagenUrl.Text))
            {
                MessageBox.Show("Debe ingresar una URL de imagen.");
                return;
            }

            if (listImagen.Items.Contains(txtImagenUrl.Text.Trim()))
            {
                MessageBox.Show("Esa imagen ya fue agregada.");
                return;
            }

            listImagen.Items.Add(txtImagenUrl.Text.Trim());

            cargarImagen(txtImagenUrl.Text.Trim());

            txtImagenUrl.Text = "";
        }

        private void listImagen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listImagen.SelectedItem != null)
            {
                cargarImagen(listImagen.SelectedItem.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
