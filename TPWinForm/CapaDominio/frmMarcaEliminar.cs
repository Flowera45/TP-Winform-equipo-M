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
    public partial class frmMarcaEliminar : Form
    {
        public frmMarcaEliminar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                int id = int.Parse(textBox1.Text);

                MarcaNegocio negocio = new MarcaNegocio();
                Marca encontrada = negocio.listar().Find(x => x.Id == id);

                if (encontrada == null)
                {
                    MessageBox.Show("No se encontró la marca con el ID especificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Por favor, ingrese un ID válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int id = int.Parse(textBox1.Text);

                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                bool estaenuso = articuloNegocio.listar().Any(x => x.Marca.Id == id);

                if (estaenuso)
                {
                    MessageBox.Show("No se puede eliminar la marca porque está en uso por un artículo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                DialogResult confirmacion = MessageBox.Show("¿Está seguro de que desea eliminar la marca?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion != DialogResult.Yes)
                {
                    return;
                }

                MarcaNegocio negocio = new MarcaNegocio();
                negocio.eliminar(id);

                MessageBox.Show("Marca eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();


            }
            catch(FormatException)
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
