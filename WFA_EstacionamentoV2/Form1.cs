using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_EstacionamentoV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sideOne.Height = btnInicio.Height;
            sideOne.Top = btnInicio.Top;
            firstCustomControl1.BringToFront();
        }

        

        private void btnInicio_Click(object sender, EventArgs e)
        {
            sideOne.Height = btnInicio.Height;
            sideOne.Top = btnInicio.Top;
            firstCustomControl1.BringToFront();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            sideOne.Height = btnRegistro.Height;
            sideOne.Top = btnRegistro.Top;
            secondCustomControl1.BringToFront();
        }

        private void btnExtrato_Click(object sender, EventArgs e)
        {
            sideOne.Height = btnExtrato.Height;
            sideOne.Top = btnExtrato.Top;
            fourthCustomControl1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e) {

        }

        private void fourthCustomControl1_Load(object sender, EventArgs e) {

        }
    }
}
