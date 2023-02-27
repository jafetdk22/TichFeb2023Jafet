using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HolaMundo
{
    internal class Program
    {
        static void Main(string[] args)/*firma del metodo, accesos estatico, devuelve vacio,nombre del metodo y argumentos*/
        {
            //Creacion de variable de tipo string llamado nombre
            string nombre; /*se declara primero el tipo de dato y el nombre de la variable */
        
            /*el metoso WriteLine se utiliza para escribir en consola*/
            Console.WriteLine("¿Cuál es tu nombre?");
            /*ReadLine se utiliza para leer un dato en consola*/
            nombre = Console.ReadLine();
            /*nombre = int.Parse(Cosole.ReadLine()); --------------------esto convierte de string a Int*/

            //SE INVOCA LA CLASE SALUDO Y SE ACCEDE AL METODO SALUDAR  Y SE ENVIA EL ARGUMENTO.
            string saludo = Saludo.Saludar(nombre);
            //imprime en consola el saldo.
            Console.WriteLine(saludo);
            //cuerra la consola con cualquier tecla.
            Console.ReadKey();

        }
    }
}
