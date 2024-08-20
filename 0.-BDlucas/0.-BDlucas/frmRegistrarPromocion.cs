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
    public partial class frmRegistrarPromocion : Form
    {
        int idNegocio;
        public frmRegistrarPromocion(int idNegocio)
        {
            InitializeComponent();
            this.idNegocio = idNegocio;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            StringBuilder insertProducto = new StringBuilder();
            insertProducto.AppendFormat("insert into ObjetoVenta(nombre,precio,codNegocio,nroVentas,cantStock,descripcion) " +
            "values('{0}','{1}','{2}',0,'{3}','{5}') DECLARE @IdObjetoVenta INT; SET @IdObjetoVenta = SCOPE_IDENTITY();" +
            "insert into Promocion(codPromocion,fechaInicio,fechaFin) " +
            "values(@IdObjetoVenta,'{4}','{6}')",
            txbNombre.Text, tbxPrecio.Text, idNegocio.ToString(), tbxCantStock.Text, dtFechaInicio.Text, tbxDescripcion.Text,dtFechaFin.Text);

            int cantRegistros = GestorDeBaseDeDatos.Instance.EjecutarConsulta(insertProducto.ToString());
            if (cantRegistros == 2)
            {
                MessageBox.Show($"Se ingresó {cantRegistros - 1} registro(s) en Promocion", "Mensaje");
                frmBuscarPromo frmRegistrarProdudctoEnPromo = new frmBuscarPromo(idNegocio,txbNombre.Text);
                frmRegistrarProdudctoEnPromo.ShowDialog();
            }
            else
            {
                MessageBox.Show($"Posibles ERRORES:algun campo invalido");
            }
        }

        private void frmRegistrarPromocion_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrarProductos_Click(object sender, EventArgs e)
        {
            
        }
    }
}
