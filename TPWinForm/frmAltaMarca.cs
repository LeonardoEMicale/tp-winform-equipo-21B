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
    public partial class frmAltaMarca : Form
    {
        public frmAltaMarca()
        {
            InitializeComponent();
        }

        private void btcAceptarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = new Marca();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                marca.Descripcion = txtDescripcionMarca.Text;
                marcaNegocio.agregar(marca);
                MessageBox.Show("Marca agregada con éxito.");

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelarMarca_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
