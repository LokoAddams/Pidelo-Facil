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
    public partial class frmRegistrarCliente : Form
    {
        public frmRegistrarCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            StringBuilder insertCliente = new StringBuilder();
            insertCliente.AppendFormat("insert into Entidad(nombre,celular,Email,PaisyCiudad,contrasenia) " +
            "values('{0}','{1}','{2}','{3}','{5}') DECLARE @IdEntidad INT; SET @IdEntidad = SCOPE_IDENTITY();" +
            " insert into Cliente(codCliente) values(@IdEntidad) " +
            "insert into Direcciones(codEntidad,ubicacion) values(@IdEntidad,'{4}')",
            txbNombre.Text, tbxCelular.Text, tbxEmail.Text, cmbPaisCiudad.Text, tbxDireccion.Text,tbxContrasenia.Text);

            int cantRegistros = GestorDeBaseDeDatos.Instance.EjecutarConsulta(insertCliente.ToString());
            if(cantRegistros>=3)
            MessageBox.Show($"Se ingresó {cantRegistros - 2} su Usuario", "Registro Exitoso!!!");
            else
            {
                MessageBox.Show($"Posibles ERRORES:\n\r Email duplicado\n\rEmail no contiene '@'\n\r numero de telefono duplicado");
            }
            this.Close();
        }

        private void frmRegistrarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
