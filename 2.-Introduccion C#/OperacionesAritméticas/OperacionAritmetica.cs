using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritméticas
{
    internal struct OperacionAritmetica
    {
        public OperacionAritmetica(decimal operando1, decimal operando2, tipoOperacion tipoOper)
        {
            this.operando1 = operando1;
            this.operando2 = operando2;
            this.tipoOper = tipoOper;
        }

        public decimal operando1 { get; set; }
        public decimal operando2 { get; set; }
        public tipoOperacion tipoOper { get; set; }
    }
}
