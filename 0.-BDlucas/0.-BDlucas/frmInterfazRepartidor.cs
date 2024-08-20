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
    public partial class frmInterfazRepartidor : Form
    {
        int id;
        public frmInterfazRepartidor(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void frmInterfazRepartidor_Load(object sender, EventArgs e)
        {

        }
    }
}
