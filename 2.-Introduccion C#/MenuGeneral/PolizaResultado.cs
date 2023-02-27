using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    public struct PolizaResultado
    {
        public PolizaResultado(DateTime fecha_Termino, decimal prima)
        {
            this.Fecha_Termino = fecha_Termino;
            this.prima = prima;
        }

        public DateTime Fecha_Termino{get; set; }
        public decimal prima { get; set; }
    }
}
