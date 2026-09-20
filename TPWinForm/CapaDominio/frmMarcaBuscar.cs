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
    public partial class frmMarcaBuscar : Form
    {
        public frmMarcaBuscar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = textBox1.Text.Trim();

                MarcaNegocio negocio = new MarcaNegocio();
                List<Marca> todas = negocio.listar();

                List<Marca> resultado;

                if (string.IsNullOrEmpty(criterio))
                {
                    resultado = todas;
                }
                else
                {
                    int idbuscado;
                    bool esnumero = int.TryParse(criterio, out idbuscado);

                    resultado = todas.Where(m =>
                        (esnumero && m.Id == idbuscado) ||
                        m.Descripcion.ToLower().Contains(criterio.ToLower())
                    ).ToList();
                }

                

                if (resultado.Count == 0)
                {
                    MessageBox.Show("No se encontraron resultados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                frmMarcaMostrar ventana = new frmMarcaMostrar(resultado);
                ventana.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}