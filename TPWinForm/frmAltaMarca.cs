using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm
{
    public partial class frmAltaMarca : Form
    {
        private Marca marca = null;
        public frmAltaMarca()
        {
            InitializeComponent();
        }

        public frmAltaMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificación de Marca";
        }

        private void btcAceptarMarca_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcionMarca.Text))
            {
                MessageBox.Show("La descripción de la marca es obligatoria.", "Campo obligatorio");
                return;
            }

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                //Si viene vacío es agregar. Crea nueva Marca.
                if (marca == null)
                {
                    marca = new Marca();
                }

                marca.Descripcion = txtDescripcionMarca.Text;

                //Valida input con letras y números únicamente
                Regex soloAlfanumerico = new Regex("^[a-zA-Z0-9 ]*$");

                if (!soloAlfanumerico.IsMatch(marca.Descripcion))
                {
                    MessageBox.Show("Solo se permiten letras y números", "Formato incorrecto");
                    return;
                }

                if (marca.IdMarca != 0)
                {
                    marcaNegocio.modificar(marca);
                    MessageBox.Show("Marca modifica con éxito.");
                }
                else
                {
                marcaNegocio.agregar(marca);
                MessageBox.Show("Marca agregada con éxito.");
                }

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

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {
            if (marca != null)
            {
                txtDescripcionMarca.Text = marca.Descripcion;
            }
        }
    }
}
