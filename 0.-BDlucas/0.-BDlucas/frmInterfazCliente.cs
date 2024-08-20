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
    public partial class frmInterfazCliente : Form
    {
        int id;
        public frmInterfazCliente(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmInterfazCliente_Load(object sender, EventArgs e)
        {

        }

        private void realizarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarNegocio frmSeleccionarNegocio=new frmBuscarNegocio(id.ToString());
            frmSeleccionarNegocio.ShowDialog();
        }
    }
}
