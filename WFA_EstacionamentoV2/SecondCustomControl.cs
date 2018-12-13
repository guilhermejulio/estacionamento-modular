using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Text;

namespace WFA_EstacionamentoV2
{
    public partial class SecondCustomControl : UserControl
    {
        public SecondCustomControl()
        {
            InitializeComponent();
            gBCliente.Enabled = false;
            gBData.Enabled = false;
            gBFormaCobranca.Enabled = false;
            gBVeiculo.Enabled = false;
            DadosVeiculo.Enabled = false;
            tipoVeiculo.Enabled = false;
            checkin.Enabled = false;
            checkout.Visible = false;
        }

    

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void dateTimeEntrada_ValueChanged(object sender, EventArgs e) {

        }

        private void Localizacao_SelectedIndexChanged(object sender, EventArgs e) {
            gBFormaCobranca.Enabled = true;
        }

        private void FormasCobranca_SelectedIndexChanged(object sender, EventArgs e) {
            gBVeiculo.Enabled = true;
            tipoVeiculo.Enabled = true;
        }

        private void tipoVeiculo_SelectedIndexChanged(object sender, EventArgs e) {
            if (tipoVeiculo.DropDownStyle >=0) {
                gBVeiculo.Enabled = true;
                DadosVeiculo.Enabled = true;
            }
        }

        private void gBVeiculo_Enter(object sender, EventArgs e) {

            DadosVeiculo.Enabled = true;
            if (FormasCobranca.SelectedIndex == 0) {
                gBVeiculo.Enabled = true;
                gBCliente.Enabled = true;
                gBData.Enabled = true;
            }
            else if (FormasCobranca.SelectedIndex == 1) {
                gBVeiculo.Enabled = true;
                gBCliente.Enabled = true;
                gBData.Enabled = true;
            }
            else {
                gBVeiculo.Enabled = true;
                gBCliente.Enabled = true;
                gBData.Enabled = false;
            }
        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void txbModelo_TextChanged(object sender, EventArgs e) {

        }

        private void txbCPF_KeyPress(object sender, KeyPressEventArgs e) {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)) || (Char.IsSeparator(e.KeyChar)) || (Char.IsPunctuation(e.KeyChar))) {
                MessageBox.Show("Digite somente numeros para o CPF!");
                e.Handled = true;
            }
        }
        private void checkin_Click(object sender, EventArgs e) {
            Registro registro;

            List<Registro> reg = null;
            //dateTimeEntrada.Text = null;
            //dateTimeSaida.Text = null;
            int maxDigCpf = 11;

            if (radioButton2.Checked == true) {
                checkout_Click(sender, e);
            }
            else {
                try {
                    if (txbCPF.MaxLength == maxDigCpf) {


                        Cliente novoCliente = new Cliente() {

                            Nome = txbNome.Text,
                            Cpf = Int64.Parse(txbCPF.Text),
                            PlacaCarro = txbPlaca.Text,
                            ModeloCarro = txbModelo.Text,
                            categoria = tipoVeiculo.Text
                           

                        };

                        registro = new Registro() {
                            RegistroCliente = novoCliente,

                            Entrada = Convert.ToDateTime(dateTimeEntrada.Value.GetDateTimeFormats()),
                            Saida = Convert.ToDateTime(dateTimeSaida.Value.GetDateTimeFormats()),
                            vagasOcupadas = 1

                        };

                        if (FormasCobranca.SelectedIndex == 0) {
                            registro.formaDeCobranca = "Horista";
                        }
                        else if (FormasCobranca.SelectedIndex == 1) {
                            registro.formaDeCobranca = "Vip";
                        }
                        else {
                            registro.formaDeCobranca = "Mensalista";
                        }
                        if (!File.Exists(Localizacao.Text + ".json")) {
                            reg = new List<Registro> { registro };
                        }
                        else {
                            reg = JsonConvert.DeserializeObject<List<Registro>>(File.ReadAllText(Localizacao.Text +".json"));
                            var re = reg.FindLast(x => x.vagasOcupadas >= 0).vagasOcupadas;
                            registro.vagasOcupadas = re;
                            if (registro.vagasOcupadas < 100) {

                                registro.vagasOcupadas++;
                                reg.Add(registro);

                            }
                            else {
                                MessageBox.Show("Não há vagas!");
                            }
                        }

                        string novoJson = JsonConvert.SerializeObject(reg);
                        File.WriteAllText(Localizacao.Text+".json", novoJson);
                        txbCPF.Clear();
                        txbModelo.Clear();
                        txbNome.Clear();
                        txbPlaca.Clear();
                        Localizacao.Text = "";
                        tipoVeiculo.Text = "";
                        FormasCobranca.Text = "";
                        dateTimeEntrada.Text = null;
                        dateTimeSaida.Text = null;
                    }
                }
                catch (Exception) {

                    MessageBox.Show("Erro Inesperado, tente novamente");

                }
 
            }

        }

        public void checkout_Click(object sender, EventArgs e) {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) {
            checkin.Enabled = true;
            checkin.Text = "Check-out";

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            checkin.Enabled = true;
            checkin.Text = "Check-in";
        }
    }
}
