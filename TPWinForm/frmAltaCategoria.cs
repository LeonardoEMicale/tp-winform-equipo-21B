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
        public frmAltaCategoria()
        {
            InitializeComponent();
        }

        private void btcAceptarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = new Categoria();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                categoria.Descripcion = txtDescripcionCategoria.Text;
                categoriaNegocio.agregar(categoria);
                MessageBox.Show("Categoria agregada con éxito.");

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
    }
}
