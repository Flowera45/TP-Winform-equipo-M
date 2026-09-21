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
    public partial class frmMarcaMostrar : Form
    {
        private List<Marca> listaMarcas;
        public frmMarcaMostrar()
        {
            InitializeComponent();
        }

        public frmMarcaMostrar(List<Marca> marcas)
        {
            InitializeComponent();

            listaMarcas = marcas;
        }
        private void frmMarcaMostrar_Load(object sender, EventArgs e)
        {
            if (listaMarcas == null)
            {
                MarcaNegocio negocio = new MarcaNegocio();
                dgvMarcas.DataSource = negocio.listar();
            }

            else
            {
                dgvMarcas.DataSource = listaMarcas;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
