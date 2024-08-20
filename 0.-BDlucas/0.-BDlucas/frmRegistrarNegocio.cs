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
    public partial class frmRegistrarNegocio : Form
    {
        public frmRegistrarNegocio()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            StringBuilder insertNegocio = new StringBuilder();
            insertNegocio.AppendFormat("insert into Entidad(nombre,celular,Email,PaisyCiudad,contrasenia) "+
            "values('{0}','{1}','{2}','{3}','{6}') DECLARE @IdEntidad INT; SET @IdEntidad = SCOPE_IDENTITY();" +
            " insert into Proveedor(codProveedor) values(@IdEntidad) "+
            "insert into Negocio(codNegocio,categoria) values(@IdEntidad,'{4}')"+
            "insert into Direcciones(codEntidad,ubicacion) values(@IdEntidad,'{5}')",
            txbNombre.Text,tbxCelular.Text,tbxEmail.Text,cmbPaisCiudad.Text,cmbCategoria.Text,tbxDireccion.Text,tbxContrasenia.Text);

            int cantRegistros = GestorDeBaseDeDatos.Instance.EjecutarConsulta(insertNegocio.ToString());
            if (cantRegistros >= 3)
                MessageBox.Show($"Se ingresó {cantRegistros - 3} registro(s) en Negocio", "Mensaje");
            else
            {
                MessageBox.Show($"Posibles ERRORES:\n\r Email duplicado\n\rEmail no contiene '@'\n\r numero de telefono duplicado");
            }
            StringBuilder ultimoId = new StringBuilder();
            ultimoId.AppendFormat("execute Sp_NombreProcedimiento 'Entidad','codEntidad'");

            DataSet dstUltimoId = new DataSet();
            dstUltimoId = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(ultimoId.ToString());
            DataTable tableUltimoId = dstUltimoId.Tables[0];

            int ultimoid;
            ultimoid = (int)tableUltimoId.Rows[0]["codEntidad"];
            MessageBox.Show(ultimoid.ToString());

            frmRegistrarHorarios frmRegistrarHorarios = new frmRegistrarHorarios(ultimoid.ToString());
            frmRegistrarHorarios.ShowDialog();
        }

        private void frmRegistrarNegocio_Load(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
