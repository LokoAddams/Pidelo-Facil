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
    public partial class frmRegistrarHorarios : Form
    {
        string codProveedor;
        public frmRegistrarHorarios(string codProveedor)
        {
            InitializeComponent();
            this.codProveedor = codProveedor;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(codProveedor);
            StringBuilder insertNegocio = new StringBuilder();
            insertNegocio.AppendFormat("insert into Horarios(codProveedor,dia,horaInicio,horaFin) " +
            " values('{0}','{1}','{2}','{3}') ",
            codProveedor, txbDia.Text, dtpHoraInicio.Text, dtpHoraFin.Text);

            int cantRegistros = GestorDeBaseDeDatos.Instance.EjecutarConsulta(insertNegocio.ToString());
            if (cantRegistros == 1)
                MessageBox.Show($"Se ingresó {cantRegistros} registro(s) en Horarios", "Mensaje");
            else
            {
                MessageBox.Show($"Posibles ERRORES:\n\r Email duplicado\n\rEmail no contiene '@'\n\r numero de telefono duplicado");
            }
        }

        private void frmRegistrarHorarios_Load(object sender, EventArgs e)
        {

        }
    }
}
