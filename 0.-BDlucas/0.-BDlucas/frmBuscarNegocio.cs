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
    public partial class frmBuscarNegocio : Form
    {
        string idCliente;
        DataSet dstNegocios;
        public frmBuscarNegocio( string idCliente)
        {
            dstNegocios = new DataSet();
            this.idCliente = idCliente;
            InitializeComponent();
        }

        private void frmSeleccionarNegocio_Load(object sender, EventArgs e)
        {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendFormat("execute sp_NegociosSegunCliente '{0}'", idCliente);
                dstNegocios = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(stringBuilder.ToString());
                lblCodCliente.Text = idCliente;
                dgdNegocios.DataSource = dstNegocios.Tables[0];
        }

        private void dgdNegocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posSel = e.RowIndex;
            string cod = dgdNegocios.Rows[posSel].Cells["codEntidad"].Value.ToString();
            frmRegistrarObjetosEnPedido frmRegistrarObjetosEnPedido=new frmRegistrarObjetosEnPedido(idCliente,cod);
            frmRegistrarObjetosEnPedido.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataRow[] promos = dstNegocios.Tables[0].Select("nombre like '%" + txtNombre.Text + "%'");
            DataTable nuevo = promos.CopyToDataTable();
            dgdNegocios.DataSource = nuevo;
        }
    }
}
