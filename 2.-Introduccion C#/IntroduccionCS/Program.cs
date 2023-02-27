using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuál es tu nombre?");
            string nombre = Console.ReadLine();
            Console.WriteLine("¿Cuál es tu primer apellido?");
            string pirmer_apellido = Console.ReadLine();
            Console.WriteLine("¿Cuál es tu segundo apellido?");
            string segindo_apellido = Console.ReadLine();
            Console.WriteLine("¿Cuál es tu edad?");
            int edad = int.Parse(Console.ReadLine());
            //string mostrarNom = Cadenas.HolaMundo(nombre,pirmer_apellido, segindo_apellido,edad);
            //Cadenas.FormatoCompuesto(nombre, pirmer_apellido, segindo_apellido, edad);
            //Cadenas.Interpolacion(nombre, pirmer_apellido, segindo_apellido, edad);
            //Cadenas.CadenaLiteral();
           Console.WriteLine(Cadenas.HolaMundo(nombre.Trim(), pirmer_apellido.Trim(), segindo_apellido.Trim(), edad));

            Console.ReadKey();

        }
    }
}
