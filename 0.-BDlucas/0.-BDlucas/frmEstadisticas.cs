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
    public partial class frmEstadisticas : Form
    {
        DataSet dstEstadisticas;
        public frmEstadisticas()
        {
            dstEstadisticas = new DataSet();
            InitializeComponent();
        }

        private void frmEstadisticas_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            StringBuilder   sb = new StringBuilder();
            sb.AppendFormat("execute sp_cantPedidosPorCliente");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource=dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_cantProdDifPorPedido");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_precioTotalPorPedido");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_cantProdPorNegocio");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_parejasPediConProdComun");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_cantProdPorPed2");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_parejasSinProdComun");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_ProdCategoComida");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_ClientesPidieronComida");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_clienteNuncaPidieron");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_clientesNombreConC");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_celularIniciaNueve");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_parejasCombConMismoPrecio");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_cantProdCategoComida");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_estadPorPedido");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_maxProducPorPedido");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_cantPedLucas");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_clientesPidieronCat1NoCat2");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_cantPedidosPorCliente");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("execute sp_NegocioConMaxProductos");
            dstEstadisticas = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sb.ToString());
            dgdEstadisticas.DataSource = dstEstadisticas.Tables[0];
        }
    }
}
