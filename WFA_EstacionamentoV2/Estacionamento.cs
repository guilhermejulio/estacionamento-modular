using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_EstacionamentoV2 {
    class Estacionamento {
        private string nome;
        private int vagas;
        private int vagasOcupadas;
        private int CarroGrande;
        private int CarroPequeno;
        private int Motos;
        public Estacionamento(string nome, int v) {
            this.nome = nome;
            DistribuirVagas(v);
            this.vagas = v;
            vagasOcupadas = 0;
        }
        public Estacionamento(string nome, Vagas v) {
            this.nome = nome;
            DistribuirVagas(v.getVagasTotal());
            this.vagas = v.getVagasTotal();

            vagasOcupadas = 0;
        }
        public string getLocalizacao() {
            return nome;
        }
        public int getVagas() {
            return vagas;
        }
        public int getVagasCarroGrande() {
            return CarroGrande;
        }
        public void setVagasOcupadas(int vagasOcupadas) {
            this.vagasOcupadas = vagasOcupadas;
        }
        public int getVagasCarroPequeno() {
            return CarroPequeno;
        }
        public int getVagasOcupadas() {
            return vagasOcupadas;
        }

        public int getVagasMotos() {
            return Motos;
        }

        public void DistribuirVagas(int v) {

            if (v > 0) {


                int tmp = v;
                if (v == 1) {
                    CarroPequeno = v;
                    CarroGrande = 0;
                    Motos = 0;
                }
                else if (v == 2) {
                    CarroPequeno = 1;
                    CarroGrande = 1;
                    Motos = 0;
                }
                else if (v == 3) {
                    CarroPequeno = 1;
                    CarroGrande = 1;
                    Motos = 1;
                }
                else {
                    CarroPequeno = tmp / 2;
                    CarroGrande = (tmp - CarroPequeno) / 2;
                    Motos = tmp - CarroGrande - CarroPequeno;
                }
            }
        }
    }
}
