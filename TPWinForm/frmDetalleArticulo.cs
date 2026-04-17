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
    public partial class frmDetalleArticulo : Form
    {
        public frmDetalleArticulo()
        {
            InitializeComponent();
        }

        private void frmDetalleArticulo_Load(object sender, EventArgs e)
        {

        }

        private void btnDetalleVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal formPrincipal = new frmPrincipal();
            formPrincipal.ShowDialog();
        }
    }
}
