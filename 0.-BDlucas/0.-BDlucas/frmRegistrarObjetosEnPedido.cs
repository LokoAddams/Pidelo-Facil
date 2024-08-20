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
    public partial class frmRegistrarObjetosEnPedido : Form
    {
        string idCliente;
        string idNegocio;
        DataSet dstProductos;
        DataSet dstProductosSeleccionados;
        public frmRegistrarObjetosEnPedido(string idCliente, string idNegocio)
        {
            dstProductos = new DataSet();
            dstProductosSeleccionados = new DataSet();
            InitializeComponent();
            this.idCliente = idCliente;
            this.idNegocio = idNegocio;
        }

        private void frmRegistrarObjetosEnPedido_Load(object sender, EventArgs e)
        {
            try
            {
                StringBuilder selectProductos = new StringBuilder();
                selectProductos.AppendFormat("execute sp_obtenerProductosSegunNegocio '{0}'", idNegocio);
                dstProductos = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(selectProductos.ToString());
                if (dstProductos == null) { throw new Exception(); }
                dgdProductos.DataSource = dstProductos.Tables[0];
                DataTable clon = dstProductos.Tables[0].Clone();
                dstProductosSeleccionados.Tables.Add(clon);
                dgdProductosSelecionados.DataSource = dstProductosSeleccionados.Tables[0];

                dgdProductos.ColumnHeadersVisible = false;
                dgdProductos.ColumnHeadersVisible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Negocio no tiene productos");
            }
            lblCodCliente.Text= idCliente;
            lblCodNegocio.Text= idNegocio;
        }

        private void btnAddProducto_Click(object sender, EventArgs e)
        {
            for (int x = 0; x <= dgdProductos.RowCount - 1; x++)
            {
                if (dgdProductos.Rows[x].Selected == true)
                {
                    dstProductosSeleccionados.Tables[0].ImportRow(dstProductos.Tables[0].Rows[x]);
                    dstProductos.Tables[0].Rows.RemoveAt(x);
                }
            }
        }

        private void btnQuitarProducto_Click(object sender, EventArgs e)
        {
            for (int x = 0; x <= dgdProductosSelecionados.RowCount - 1; x++)
            {
                if (dgdProductosSelecionados.Rows[x].Selected == true)
                {
                    dstProductos.Tables[0].ImportRow(dstProductosSeleccionados.Tables[0].Rows[x]);
                    dstProductosSeleccionados.Tables[0].Rows.RemoveAt(x);
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int n = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("insert into Pedido(codCliente,codNegocio) " +
                "values('{0}','{1}')",idCliente,idNegocio);
            GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());

            StringBuilder sb2 = new StringBuilder();
            sb2.AppendFormat("execute Sp_NombreProcedimiento 'Pedido','codPedido'");

            DataSet dstUltimoId = new DataSet();
            dstUltimoId = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb2.ToString());
            DataTable tableUltimoId = dstUltimoId.Tables[0];

            int ultimoid;
            ultimoid =(int) tableUltimoId.Rows[0]["codPedido"];


            for (int i = 0; i < dgdProductosSelecionados.RowCount; i++)
            {
                string inscrip = "insert into DetallePedido(codPedido,codProducto) values(" +
                ultimoid.ToString()+
                ",'" +
                dgdProductosSelecionados.Rows[i].Cells[0].Value.ToString() + "')";
                n = GestorDeBaseDeDatos.Instance.EjecutarConsulta(inscrip);
            }
            if (n > 0)
            {
                MessageBox.Show("el Registro de pedido del cliente " + idCliente + " se llevó a cabo con éxito", "exito");
            }
            else
            {
                MessageBox.Show("Problemas en la inscripción... ", "error");
            }
            this.Close();
        }
    }
}
