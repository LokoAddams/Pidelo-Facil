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
    public partial class frmRegistrarProductoEnPromo : Form
    {
        string idPromo;
        string negocio;
        DataSet dstProductos;
        DataSet dstProductosSeleccionados;
        public frmRegistrarProductoEnPromo(string idPromo, string negocio)
        {
            dstProductos = new DataSet();
            dstProductosSeleccionados=new DataSet();
            this.idPromo = idPromo;
            this.negocio = negocio;
            InitializeComponent();
        }

        private void frmRegistrarProductoEnPromo_Load(object sender, EventArgs e)
        {
            lblCodNegocio.Text = negocio;
            lblCodPromo.Text = idPromo;
            StringBuilder selectProductos = new StringBuilder();
            selectProductos.AppendFormat("execute sp_obtenerProductosSegunNegocio '{0}'", negocio);
            dstProductos=GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(selectProductos.ToString());
            dgdProductos.DataSource = dstProductos.Tables[0];
            DataTable clon = dstProductos.Tables[0].Clone();
            dstProductosSeleccionados.Tables.Add(clon);
            dgdProductosSelecionados.DataSource = dstProductosSeleccionados.Tables[0];

            dgdProductos.ColumnHeadersVisible = false;
            dgdProductos.ColumnHeadersVisible = false;
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
            for (int i = 0; i < dgdProductosSelecionados.RowCount; i++)
            {
                string inscrip = "insert into DetallePromocion(codPromocion,codProducto) values(" +
                idPromo +
                ",'" +
                dgdProductosSelecionados.Rows[i].Cells[0].Value.ToString() +"')";
                n = GestorDeBaseDeDatos.Instance.EjecutarConsulta(inscrip);
            }
            if (n > 0)
            {
                MessageBox.Show("el Registro de productos en la Promocion "+idPromo+" se llevó a cabo con éxito", "exito");
            }
            else
            {
                MessageBox.Show("Problemas en la inscripción... ", "error");
            }
            this.Close();
        }
    }
}
