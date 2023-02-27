using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool menu = true;

            while (menu)
            {
                Console.WriteLine(
                    "1.-Cadenas\n" +
                    "2.-enteros\n" +
                    "3.-Conversion a Mayus\n" +
                    "4.-Poliza\n" +
                    "5.-Mostrar Archivo Txt\n" +
                    "6.-Ingrese la ruta con el nombre del archivo\n" +
                    "7.-Ambito de Variable\n" +
                    "8.-Condicionales\n" +
                    "9.-Ciclos\n" +
                    "10.-Cuerpo de Expresiones\n" +
                    "11.-Pase por Valor y Referencia\n" +
                    "12.-Manejo de Ecepciones\n" +
                    "13.-Listas\n" +
                    "14.-Nivel de Acceso\n" +
                    "15.-Programacion Orientada a Objetos\n" +
                    "F.-Termina\n"
                   );
                Console.WriteLine("Seleccione una opción");
                int number;
                string opcion = Console.ReadLine().ToLower();
                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("ingresa tu nombre");
                        string nombre = Console.ReadLine().ToLower();
                        Arreglos.Cadenas(nombre);

                        break;
                    case "2":
                        Console.WriteLine("ingresa el primer numero");
                        int n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresa el segundo numero");
                        int n2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresa el tercer numero");
                        int n3 = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresa el cuarto numero");
                        int n4 = int.Parse(Console.ReadLine());
                        Console.WriteLine("ingresa el quinto numero");
                        int n5 = int.Parse(Console.ReadLine());
                        Arreglos.Enteros(n1, n2, n3, n4, n5);

                        break;
                    case "3":
                        Console.WriteLine("Ingresa una frase");
                        string frase = Console.ReadLine();
                        Arreglos.ConvierteATipoOracion(frase);
                        break;
                    case "4":
                        Poliza.Presentacion();
                        break;
                    case "5":
                        Archivotxt.presentacion();

                        break;
                    case "6":
                        Console.WriteLine("Ingresa nombre del archivo con extención");
                        string nombreArchivo = Console.ReadLine();
                        Console.WriteLine("Ingresa ruta del archivo");
                        string ruta = Console.ReadLine();
                        Console.WriteLine("Elige una opción");
                        Console.WriteLine("1.- Nuevo");
                        Console.WriteLine("2.- Archivo Existente");
                        int nuevo1= int.Parse(Console.ReadLine());
                        bool nuevo= true;

                        if (nuevo1 == 2)
                        {
                            nuevo = true;
                        }
                        else if(nuevo1 == 1)
                        {
                            nuevo = false;
                        }
                        Console.WriteLine("Elige una opcion de codificación");
                        int codigo = Convert.ToInt16(Console.ReadLine());
                        Archivotxt.EscribirTxt(nombreArchivo,ruta,nuevo,codigo);
                        break;
                    case "7":
                        CalculadoraISR.Presentacion();
                        break;
                    case "8":
                        Console.WriteLine("Condicionales");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "9":
                        Console.WriteLine("Ciclos");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "10":
                        Console.WriteLine("Cuerpo de Expresiones");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "11":
                        Console.WriteLine("Pase por Valor y Referencia");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "12":
                        Console.WriteLine("Manejo de Ecepciones");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "13":
                        Console.WriteLine("Listas");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "14":
                        Console.WriteLine("Nivel de Acceso");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "15":
                        Console.WriteLine("Programacion Orientada a Objetos");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case "f":
                        Console.WriteLine("Adios");
                        menu = false;
                        break;
                    default:
                        Console.WriteLine($"Lo siento la opcion {opcion} no existe");
                        break;
                }
            }
        }
    }
}
