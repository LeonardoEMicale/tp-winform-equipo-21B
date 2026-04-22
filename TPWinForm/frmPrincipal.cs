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
    public partial class frmPrincipal : Form
    {

        private List<Articulo> listaArticulo;
        private List<Imagen> listaImagenes;
        private int indiceImagen;

        public frmPrincipal()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulo = negocio.listar();
                dgvArticulos.DataSource = listaArticulo;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAlta formAlta = new frmAlta();
            formAlta.ShowDialog();

            // Actualizo grilla luego de agregar un nuevo articulo
            ArticuloNegocio negocio = new ArticuloNegocio();
            listaArticulo = negocio.listar();
            dgvArticulos.DataSource = listaArticulo;
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            frmDetalleArticulo formDetalleArticulo = new frmDetalleArticulo();
            formDetalleArticulo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo artSeleccionado;
            artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAlta formModificacion = new frmAlta(artSeleccionado);
            formModificacion.ShowDialog();
        }

        private void administrarMarcasYCategoríasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdminMarcasYCategorias frmAdminMarcasYCategorias = new frmAdminMarcasYCategorias();
            frmAdminMarcasYCategorias.ShowDialog();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            ImagenNegocio imgNegocio = new ImagenNegocio();
            Articulo artSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            // Guardo todas las imagenes encontrada en la base de datos
            listaImagenes = imgNegocio.buscarImagenes(artSeleccionado.IdArticulo);
            indiceImagen = 0;

            Utils util = new Utils();
            util.cargarImagen(listaImagenes, pbImagen, indiceImagen);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Utils util = new Utils();

            if(indiceImagen == listaImagenes.Count - 1)
            {
                indiceImagen = 0;
                util.cargarImagen(listaImagenes, pbImagen, indiceImagen);
            }
            else
            {
                indiceImagen++;
                util.cargarImagen(listaImagenes, pbImagen, indiceImagen);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            Utils util = new Utils();

            if (indiceImagen == 0)
                indiceImagen = listaImagenes.Count - 1;
            else
                indiceImagen--;

            util.cargarImagen(listaImagenes, pbImagen, indiceImagen);
        }
    }
}
