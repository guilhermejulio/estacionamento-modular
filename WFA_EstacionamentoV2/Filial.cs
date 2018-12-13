using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace WFA_EstacionamentoV2 {
    class CadastrarFilial {


        private List<Estacionamento> listaEstacionamentos = new List<Estacionamento>();
        
        public Estacionamento estacionamento;
        public CadastrarFilial() {}
        public CadastrarFilial(Estacionamento centro, Estacionamento barroPreto, Estacionamento vendaNova) {
            listaEstacionamentos.Add(centro);
            listaEstacionamentos.Add(barroPreto);
            listaEstacionamentos.Add(vendaNova);

        }
        public CadastrarFilial(Estacionamento estacionamento) {
            listaEstacionamentos.Add(estacionamento);
        }
        public CadastrarFilial(string filial, Vagas vagas) {

            //CadastrarFilial cadastrarFilial = new CadastrarFilial();
            estacionamento = new Estacionamento(filial, vagas);
            listaEstacionamentos.Add(estacionamento);
        }


    }
}
