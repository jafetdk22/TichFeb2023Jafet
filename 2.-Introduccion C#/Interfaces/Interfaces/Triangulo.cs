using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Triangulo : IFigura
    {
        public double Base;
        public double Altura;

        public Triangulo()
        {
        }

        public Triangulo(double baseTriang, double altura)
        {
            Base = baseTriang;
            Altura = altura;
        }

        public double Area() { return (Base * Altura) / 2; }
        public double Perimetro() { return 2 * Base + Math.Sqrt(2) * Altura; }
    }
}
