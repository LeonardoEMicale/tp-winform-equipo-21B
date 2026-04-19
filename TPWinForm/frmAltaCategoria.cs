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

namespace TPWinForm
{
    public partial class frmAltaCategoria : Form
    {
        private Categoria categoria = null;
        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        public frmAltaCategoria(Categoria categoria)
        {
            InitializeComponent();
            this.categoria = categoria;
            Text = "Modificación de Categoría";
        }

        private void btcAceptarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                //Si viene vacío es agregar. Crea nueva Categoría.
                if(categoria == null)
                {
                    categoria = new Categoria();
                }

                categoria.Descripcion = txtDescripcionCategoria.Text;

                if(categoria.IdCategoria != 0)
                {
                    categoriaNegocio.modificar(categoria);
                    MessageBox.Show("Categoria modificada con éxito.");
                }
                else
                {
                categoriaNegocio.agregar(categoria);
                MessageBox.Show("Categoria agregada con éxito.");
                }

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarCategoria_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaCategoria_Load(object sender, EventArgs e)
        {
            if(categoria != null)
            {
                txtDescripcionCategoria.Text = categoria.Descripcion;
            }
        }
    }
}
