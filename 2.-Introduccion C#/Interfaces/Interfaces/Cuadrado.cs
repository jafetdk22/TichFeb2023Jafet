using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Cuadrado : IFigura
    {
        public double Lado;
        public Cuadrado() { }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public double Area()
        {
            return Lado * Lado;
        }
        public double Perimetro()
        {
            return Lado * 4;
        }
    }
}
