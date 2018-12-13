using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_EstacionamentoV2 {
     class Vagas {
        private int vagasTotal;
        public Vagas(int vagas) {
            vagasTotal = vagas;
        }
        public Vagas() { }


        public int getVagasTotal() {
            return vagasTotal;
        }
        public void setTotal(int v) {
            vagasTotal = v;
        }

    }
}
