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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void registrarNegocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarNegocio frmRegistrarNegocio = new frmRegistrarNegocio();
            frmRegistrarNegocio.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbPaisyCiudad.Text=="")
                MessageBox.Show("Error: seleccione una ciudda y pais");
            else
            {
                frmDescartarEntidadesPorPais frmDescartarEntidadesPorPais = new frmDescartarEntidadesPorPais(cmbPaisyCiudad.Text);
                frmDescartarEntidadesPorPais.ShowDialog();
            }
        }

        private void registrateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarCliente frmRegistrarCliente = new frmRegistrarCliente();
            frmRegistrarCliente.ShowDialog();
        }

        private void buscasTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarRepartidor frmRegistrarRepartidor = new frmRegistrarRepartidor();
            frmRegistrarRepartidor.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void estadisticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadisticas frmEstadisticas = new frmEstadisticas();
            frmEstadisticas.ShowDialog();
        }
    }
}
