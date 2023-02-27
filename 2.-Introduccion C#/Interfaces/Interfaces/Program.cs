using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFigura[] figuras= new IFigura[2];
            figuras[0] = new Cuadrado(5.0);
            figuras[1] = new Triangulo(4.0,3.0);
            foreach(IFigura figura in figuras)
            {
                if (figura == figuras[0])
                {
                    Console.WriteLine($"El área del cuadrado es:{figura.Area()}");
                    Console.WriteLine($"El perimetro del cuadrado es:{figura.Perimetro()}");
                }
                else if(figura == figuras[1])
                {
                    Console.WriteLine($"El área del Triángulo es:{figura.Area()}");
                    Console.WriteLine($"El perimetro del Triángulo es:{figura.Perimetro()}");
                }
            }
            Console.ReadKey();
        }
    }
}
