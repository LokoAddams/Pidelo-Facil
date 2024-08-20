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
    public partial class frmBuscarPromo : Form
    {
        int idNegocio;
        string nombrePromo;
        DataSet dstPromociones;
        public frmBuscarPromo(int idnegocio, string nombrePromo)
        {
            InitializeComponent();
            this.idNegocio = idnegocio;
            this.nombrePromo = nombrePromo;
        }

        private void frmRegistrarProdudctoEnPromo_Load(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat("execute sp_obtenerPromosSegunNegocio '{0}'", idNegocio.ToString());
            dstPromociones = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(stringBuilder.ToString());
            txtNombre.Text = nombrePromo;
            dgdPromos.DataSource = dstPromociones.Tables[0];
        }

        private void dgdPromos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int posSel = e.RowIndex;
            string cod=dgdPromos.Rows[posSel].Cells["codObjetoVenta"].Value.ToString();
            frmRegistrarProductoEnPromo frmRegistrarProductoEnPromo = new frmRegistrarProductoEnPromo(cod,idNegocio.ToString());
            frmRegistrarProductoEnPromo.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow[] promos = dstPromociones.Tables[0].Select("nombre like '%" + txtNombre.Text + "%'");
            DataTable nuevo = promos.CopyToDataTable();
            dgdPromos.DataSource = nuevo;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
