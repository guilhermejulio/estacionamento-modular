using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_EstacionamentoV2 {
    class Cliente {
        public string categoria { get; set; }
        public Int64 Cpf { get; set; }
        public string Nome { get; set; }
        public string PlacaCarro { get; set; }

        public string ModeloCarro { get; set; }
    }
}
