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

namespace TPWinForm
{
    public partial class frmPrincipal : Form
    {

        private List<Articulo> listaArticulo;
        private List<string> listaImagenes;
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
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            frmDetalleArticulo formDetalleArticulo = new frmDetalleArticulo();
            formDetalleArticulo.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            frmAlta formModificacion = new frmAlta();
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

            cargarImagen(listaImagenes);
        }

        private void cargarImagen(List<string> listaURL)
        {
            try
            {
                if(listaURL != null && listaURL.Count > 0)
                    
                    pbImagen.Load(listaURL[indiceImagen]);
            }
            catch (Exception)
            { 
                pbImagen.Load("https://community.softr.io/uploads/db9110/original/2X/7/74e6e7e382d0ff5d7773ca9a87e6f6f8817a68a6.jpeg");
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(indiceImagen == listaImagenes.Count - 1)
            {
                indiceImagen = 0;
                cargarImagen(listaImagenes);
            }
            else
            {
                indiceImagen++;
                cargarImagen(listaImagenes);
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceImagen == 0)
                indiceImagen = listaImagenes.Count - 1;
            else
                indiceImagen--;
            
            cargarImagen(listaImagenes);
        }
    }
}
