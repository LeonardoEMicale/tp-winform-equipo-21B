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
using Utilidades;

namespace TPWinForm
{
    public partial class frmGestionImagen : Form
    {
        private Articulo articulo;
        private List<Imagen> listaImagenes;

        public frmGestionImagen()
        {
            InitializeComponent();
        }
        public frmGestionImagen(Articulo seleccionado)
        {
            InitializeComponent();
            articulo = seleccionado;
        }

        private void frmGestionImagen_Load(object sender, EventArgs e)
        {
            cargarListaUrl();
        }

        private void lbListaImg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbListaImg.SelectedItem != null)
            {
                Imagen seleccionada = (Imagen)lbListaImg.SelectedItem;

                Utils util = new Utils();
                util.cargarImagen(seleccionada.UrlImagen, pbGestImagen);
            }
        }

        private void cargarListaUrl()
        {
            ImagenNegocio imgNegocio = new ImagenNegocio();

            try
            {
                listaImagenes = imgNegocio.buscarImagenes(articulo.IdArticulo);
                lbListaImg.DataSource = null;
                lbListaImg.DataSource = listaImagenes;
                lbListaImg.DisplayMember = "UrlImagen";

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAgregarImg_Click(object sender, EventArgs e)
        {
            ImagenNegocio imgNegocio = new ImagenNegocio();

            try
            {
                if (string.IsNullOrEmpty(txtUrlNueva.Text))
                {
                    MessageBox.Show("Error: Ingrese una Url primero.");
                    return;
                }

                Imagen nueva = new Imagen();
                nueva.IdArticulo = articulo.IdArticulo;
                nueva.UrlImagen = txtUrlNueva.Text;

                imgNegocio.agregarImagen(nueva);

                txtUrlNueva.Clear();
                cargarListaUrl();

                MessageBox.Show("Imagen agregada con exito");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminarImg_Click(object sender, EventArgs e)
        {
            // Falta logica
        }
    }
}
