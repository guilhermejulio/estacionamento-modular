using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_EstacionamentoV2 {
     class Registro {

        public string formaDeCobranca;

        public DateTime Entrada { get; set; }

        public DateTime Saida { get; set; }

        public int vagasOcupadas { get; set; }
        public Cliente RegistroCliente { get; set; }

        public double Calcular(Registro registro) {
            return 0;
        }

    }
}
