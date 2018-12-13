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
    public partial class FirstCustomControl : UserControl
    {
        Estacionamento centro = new Estacionamento("Centro", 10);
        Estacionamento barropreto = new Estacionamento("Barro Preto", 10);
        Estacionamento vendaNova = new Estacionamento("Venda Nova", 10);
        public FirstCustomControl()
        {
            InitializeComponent();
            CadastrarFilial cadastrarFilial = new CadastrarFilial(centro, barropreto, vendaNova);
       
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            CadastrarFilial novaFilial = new CadastrarFilial();
            Vagas vagas = new Vagas(int.Parse(totalVagasText.Text));
            Estacionamento estacionamento = new Estacionamento(localizacaoText.Text, vagas);
            novaFilial = new CadastrarFilial(estacionamento);
            localizacaoText.Clear();
            totalVagasText.Clear();
        }

        private void txbTotalVagas_KeyPress(object sender, KeyPressEventArgs e) {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)) || (Char.IsSeparator(e.KeyChar)) || (Char.IsPunctuation(e.KeyChar))) {
                MessageBox.Show("Digite somente numeros!");
                e.Handled = true;
            }
        }
    }
}
