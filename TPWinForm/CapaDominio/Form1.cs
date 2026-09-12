using CapaDominio;
using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformApp
{
    public partial class Form1 : Form
    {
        private List<Imagen> listaImagen;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ImagenNegocio imgNegocio = new ImagenNegocio();
            listaImagen = imgNegocio.listar();

            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvArticulos.DataSource = negocio.listar();
            // negocio.listar va a la DB y devuelve una lista de datos
            // DataSource recibe esos datos y los modela en la tabla
            dgvArticulos.Columns["IdMarca"].Visible = false;      //No quiero que muestre estos IDs
            dgvArticulos.Columns["IdCategoria"].Visible = false;
        }


        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            int id = seleccionado.Id;
            buscarYMostrarImagen(id);

        }

        private void buscarYMostrarImagen(int idArticuloBuscado)
        {
            Imagen imgEncontrada = null;

            if(listaImagen != null) { 
                foreach (Imagen item in listaImagen)
                {
                    if(item.IdArticulo == idArticuloBuscado)
                    {
                        imgEncontrada = item;
                        break;
                    }
                }
            }
            if (imgEncontrada != null)
            {
                cargarImagen(imgEncontrada.ImagenUrl);
            }
            else
            {
                cargarImagen(""); // Al estar vacío salta al catch y muestra el placeholder
            }
        }
        private void cargarImagen(string imagen)
        {
            try
            {
                pBoxImagenArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pBoxImagenArticulo.Load("https://efectocolibri.com/wp-content/uploads/2021/01/placeholder.png");
            }

        }
    }
}
