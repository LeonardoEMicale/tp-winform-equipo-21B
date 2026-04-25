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
            ImagenNegocio imgNegocio = new ImagenNegocio();
            try
            {
                if(lbListaImg.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar una imagen para poder borrar..");
                    return;
                }

                DialogResult eleccion = MessageBox.Show("Está seguro que desea eliminar el articulo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (eleccion == DialogResult.Yes)
                {
                    Imagen seleccionada = (Imagen)lbListaImg.SelectedItem;
                    
                    imgNegocio.eliminarImagen(seleccionada.IdImagen);
                    cargarListaUrl();

                    if (lbListaImg.Items.Count == 0)
                        pbGestImagen.Image = null;
                }
            }
            catch (Exception ex)
            {

                throw ex;
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

        private void txtUrlNueva_TextChanged(object sender, EventArgs e)
        {
            Utils utils = new Utils();
            string url = txtUrlNueva.Text;

            if (url.StartsWith("http"))
                utils.cargarImagen(txtUrlNueva.Text, pbGestImagen);
            else
                pbGestImagen.Image = null;
        }
    }
}
