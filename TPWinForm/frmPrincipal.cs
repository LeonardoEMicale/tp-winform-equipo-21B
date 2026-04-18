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
    }
}
