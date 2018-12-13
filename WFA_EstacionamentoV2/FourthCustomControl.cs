using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EstacionamentoV2
{
    public partial class FourthCustomControl : UserControl
    {
        public FourthCustomControl()
        {
            InitializeComponent();
            gBCliente.Enabled = false;
            gBFaturamento.Enabled = false; ;
            gBTipo.Enabled = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rBCentro_CheckedChanged(object sender, EventArgs e)
        {
            gBTipo.Enabled = true;
        }

        private void rBVendaNova_CheckedChanged(object sender, EventArgs e)
        {
            gBTipo.Enabled = true;
        }

        private void rBBarroPreto_CheckedChanged(object sender, EventArgs e)
        {
            gBTipo.Enabled = true;
        }

        private void rBTodos_CheckedChanged(object sender, EventArgs e)
        {
            gBTipo.Enabled = true;
        }

        private void rBExtratoCliente_CheckedChanged(object sender, EventArgs e)
        {
            gBCliente.Enabled = true;
            gBFaturamento.Enabled = true;
        }

        private void rBFaturamento_CheckedChanged(object sender, EventArgs e)
        {
            gBCliente.Enabled = false;
            gBFaturamento.Enabled = true;
        }
    }
}
