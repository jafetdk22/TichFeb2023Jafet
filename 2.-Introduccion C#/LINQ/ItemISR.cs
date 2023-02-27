using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class ItemISR
    {
        public ItemISR()
        {
        }

        public ItemISR(decimal limInf, decimal limSup, decimal cuotaFija, decimal proExceded, decimal subsidio)
        {
            LimInf = limInf;
            LimSup = limSup;
            CuotaFija = cuotaFija;
            ProExceded = proExceded;
            Subsidio = subsidio;
        }

        public decimal LimInf{ get; set; }
        public decimal LimSup { get; set; }
        public decimal CuotaFija { get; set; }
        public decimal ProExceded { get; set; }
        public decimal Subsidio { get; set; }
    }
}
