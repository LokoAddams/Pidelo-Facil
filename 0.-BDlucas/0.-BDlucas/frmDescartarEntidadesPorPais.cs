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
    public partial class frmDescartarEntidadesPorPais : Form
    //este formulario nos permite dar una interfaz personalizada y el mismo tiempo descartar
    //entidades de la busqueda par el inicio de sesion
    {
        string PaisyCiudad;
        DataTable entidades;
        public frmDescartarEntidadesPorPais(string PaisyCiudad)
        {
            InitializeComponent();
            this.PaisyCiudad = PaisyCiudad;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void frmDescartarEntidadesPorPais_Load(object sender, EventArgs e)
        {
            DataSet dstEntidadesPorPaisyCiudad;
            StringBuilder insertCliente = new StringBuilder();
            insertCliente.AppendFormat("execute sp_filtrarPorPaisyCiudad '{0}'",
            PaisyCiudad);

            dstEntidadesPorPaisyCiudad =GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(insertCliente.ToString());
            if (dstEntidadesPorPaisyCiudad.Tables.Count > 0)
            {
                DataTable tabla = dstEntidadesPorPaisyCiudad.Tables[0];
                this.entidades = tabla;
            }
            else
            {
                MessageBox.Show("No se encontró ninguna tabla en el conjunto de resultados");
            }
        }
        
        char verificarTipoEntidad(int id)
        {   
            
            if(id!=0)
            {
                StringBuilder selectCliente = new StringBuilder();
                selectCliente.AppendFormat("select * from Cliente");
                DataSet dstClientes = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(selectCliente.ToString());
                DataTable dtClientes = dstClientes.Tables[0];
                StringBuilder cliente = new StringBuilder();
                cliente.AppendFormat("codCliente='{0}'", id.ToString());
                DataRow[] dataRow = dtClientes.Select(cliente.ToString());
                if (dataRow.Length > 0)
                    return 'a';


                StringBuilder selectRepartidor = new StringBuilder();
                selectRepartidor.AppendFormat("select * from Repartidor");
                DataSet dstRepartidores = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(selectRepartidor.ToString());
                DataTable dtRepartidor = dstRepartidores.Tables[0];
                StringBuilder repartidor = new StringBuilder();
                repartidor.AppendFormat("codRepartidor='{0}'", id.ToString());
                DataRow[] dataRow2 = dtRepartidor.Select(repartidor.ToString());
                if (dataRow2.Length > 0)
                    return 'b';

                StringBuilder selectNegocio = new StringBuilder();
                selectNegocio.AppendFormat("select * from Negocio");
                DataSet dstNegocios = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(selectNegocio.ToString());
                DataTable dtNegocio = dstNegocios.Tables[0];
                StringBuilder negocio = new StringBuilder();
                negocio.AppendFormat("codNegocio='{0}'", id.ToString());
                DataRow[] dataRow3 = dtNegocio.Select(negocio.ToString());
                if (dataRow3.Length > 0)
                    return 'c';
            }
            return 'n';
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if(entidades!=null)
            {
                StringBuilder CorreoContrasenia = new StringBuilder();
                CorreoContrasenia.AppendFormat("Email='{0}' AND contrasenia='{1}'",
                    tbxEmail.Text, tbxContrasenia.Text);
                DataRow[] filas = entidades.Select(CorreoContrasenia.ToString());
                if (filas.Length > 0)
                {
                    // Obtener el ID del usuario
                    int idUsuario = 0;
                    idUsuario=(int)filas[0]["codEntidad"];
                    string nombre = (string)filas[0]["nombre"];
                    char opcion=verificarTipoEntidad(idUsuario);
                    switch (opcion)
                    {
                        case 'a':
                            MessageBox.Show("Bienvenido " + nombre);
                            frmInterfazCliente frmInterfazCliente= new frmInterfazCliente(idUsuario);
                            frmInterfazCliente.ShowDialog();
                            break;
                        case 'b':
                            MessageBox.Show("Bienvenido " + nombre);
                            frmInterfazRepartidor frmInterfazRepartidor=new frmInterfazRepartidor(idUsuario);
                            frmInterfazRepartidor.ShowDialog();

                            break;
                        case 'c':
                            MessageBox.Show("Bienvenido " + nombre);
                            frmInterfazNegocio frmInterfazNegocio= new frmInterfazNegocio(idUsuario);
                            frmInterfazNegocio.ShowDialog();
                            break;
                        default:
                            MessageBox.Show("no se logro identificar el tipo de cuenta");
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Correo electrónico o contraseña incorrectos,\n\r o no encontrados en esta region");
                }
            }
            else 
            {
                MessageBox.Show("no se creo la tabla entidades");
            }
            

        }
    }
}
