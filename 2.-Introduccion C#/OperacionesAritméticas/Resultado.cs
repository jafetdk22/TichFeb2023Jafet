using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritméticas
{
    public struct Resultado
    {
        public Resultado(decimal suma, decimal resta, decimal multiplicacion, decimal dividir, decimal modulo)
        {
            this.suma = suma;
            this.resta = resta;
            this.multiplicacion = multiplicacion;
            this.dividir = dividir;
            this.modulo = modulo;
        }

        public decimal suma { get; set; }
        public decimal resta { get; set; }
        public decimal multiplicacion { get; set; }
        public decimal dividir { get; set; }
        public decimal modulo { get; set; }
    }
}
