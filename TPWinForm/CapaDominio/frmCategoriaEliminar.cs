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
    public partial class frmCategoriaEliminar : Form
    {
        public frmCategoriaEliminar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                int id = int.Parse(textBox1.Text);

                CategoriaNegocio negocio = new CategoriaNegocio();
                Categoria encontrada = negocio.listar().FirstOrDefault(c => c.Id == id);

                if (encontrada == null)
                {
                    MessageBox.Show("No se encontró la categoría con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox2.Text = "";
                    return;
                }

                textBox2.Text = encontrada.Descripcion;


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

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Por favor, ingrese un ID válido.");
                    return;
                }

                int id = int.Parse(textBox1.Text);

                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                bool estaenuso = articuloNegocio.listar().Any(a => a.Categoria.Id == id);

                if (estaenuso)
                {
                    MessageBox.Show("No se puede eliminar la categoría porque está en uso por uno o más artículos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar la categoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion != DialogResult.Yes)
                {
                    return;
                }

                CategoriaNegocio negocio = new CategoriaNegocio();
                negocio.eliminar(id);

                MessageBox.Show("Categoría eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();



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

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }
    }
}
