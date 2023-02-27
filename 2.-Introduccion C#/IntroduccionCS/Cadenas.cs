using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroduccionCS
{
    public class Cadenas
    {
        public static string HolaMundo(string nom,string priApe,string segApe, int edad)
        {
            string resultado = "Hola"+" "+nom + " " + priApe + " " + segApe;

            return resultado;
        }

        public static void FormatoCompuesto(string nom, string priApe, string segApe, int ed)
        {

            string nombre = nom;
            string primerApellido = priApe;
            string segundoApellido = segApe;
            int edad = ed;
            Console.WriteLine("{0} {1} {2} tiene {3} años de edad."
            , nombre, primerApellido, segundoApellido, edad);

        }
        public static void Interpolacion(string nom, string priApe, string segApe, int ed)
        {
            string nombre = nom.ToUpper();
            string primerApellido = priApe.ToUpper();
            string segundoApellido = segApe.ToUpper();
            int edad = ed;
            String cadena;
            //Interpolación
            cadena = $"Gusto en conocerte {nombre} {primerApellido} {segundoApellido}!!!.";
            Console.WriteLine(cadena);

        }
        public static void CadenaLiteral()
        {
            string cadena;
            string ruta = "C:\\Documentos\\Diplomado.Net\\JorgeValdiviaRosas.docx";
            Console.WriteLine(ruta);
        }

    }

}
