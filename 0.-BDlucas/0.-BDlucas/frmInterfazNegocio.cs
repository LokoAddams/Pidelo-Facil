using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0._BDlucas
{
    public partial class frmInterfazNegocio : Form
    {
        int id;
        public frmInterfazNegocio(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmInterfazNegocio_Load(object sender, EventArgs e)
        {

        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarProducto frmRegistrarProducto=new frmRegistrarProducto(id);
            frmRegistrarProducto.ShowDialog();
        }

        private void registrarPromocionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarPromocion frmRegistrarProm=new frmRegistrarPromocion(id);
            frmRegistrarProm.ShowDialog();
        }

        private void miPerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
