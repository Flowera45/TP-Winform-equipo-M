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
    public partial class frmCategoriaBuscar : Form
    {
        public frmCategoriaBuscar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = textBox1.Text.Trim();

                CategoriaNegocio negocio = new CategoriaNegocio();
                List<Categoria> todas = negocio.listar();

                List<Categoria> resultado;

                if (string.IsNullOrEmpty(criterio))
                {
                    resultado = todas;
                }
                else
                {
                    int idbuscado;
                    bool esnumero = int.TryParse(criterio, out idbuscado);

                    resultado = todas.Where(c =>
                        (esnumero && c.Id == idbuscado) ||
                        c.Descripcion.ToLower().Contains(criterio.ToLower())
                    ).ToList();
                }

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = resultado;

                if (resultado.Count == 0)
                {

                    MessageBox.Show("No se encontraron categorías que coincidan con la busqueda");
                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
