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
    public partial class frmRegistrarProducto : Form
    {
        int idNegocio;
        public frmRegistrarProducto(int idNegocio)
        {
            InitializeComponent();
            this.idNegocio= idNegocio;
        }

        private void frmRegistrarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            StringBuilder insertProducto = new StringBuilder();
            insertProducto.AppendFormat("insert into ObjetoVenta(nombre,precio,codNegocio,nroVentas,cantStock,descripcion) " +
            "values('{0}','{1}','{2}',0,'{3}','{5}') DECLARE @IdObjetoVenta INT; SET @IdObjetoVenta = SCOPE_IDENTITY();" +
            "insert into Producto(codProducto,categoria) " +
            "values(@IdObjetoVenta,'{4}')",
            txbNombre.Text, tbxPrecio.Text, idNegocio.ToString(), tbxCantStock.Text,tbxCategoria.Text,tbxDescripcion.Text);

            int cantRegistros = GestorDeBaseDeDatos.Instance.EjecutarConsulta(insertProducto.ToString());
            if (cantRegistros == 2)
                MessageBox.Show($"Se ingresó {cantRegistros-1} registro(s) en Producto", "Mensaje");
            else
            {
                MessageBox.Show($"Posibles ERRORES:algun campo invalido");
            }
        }
    }
}
