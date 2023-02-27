using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Archivotxt
    {
        public static void MostrarTxt(string nombre)
        {
            string linea;
            StreamReader archrivo = new StreamReader(@"C:\Users\jafet SG\Desktop\" + nombre + ".txt");
            linea = archrivo.ReadToEnd();
            Console.WriteLine(linea);
            archrivo.Close();
            Console.ReadLine();
        }

        public static void MostrarCSV(string ruta)
        {
            string linea;
            StreamReader archrivo = new StreamReader(@ruta);
            linea = archrivo.ReadToEnd();
            Console.WriteLine(linea);
            archrivo.Close();
            Console.ReadLine();

        }

        public static void EscribirTxt(string nombreArchivo, string ruta, bool nuevo, int codigo)
        {
            string linea;

            Encoding tipoCod = Encoding.Default;
            switch (codigo)
            {
                case 1:
                    tipoCod = Encoding.UTF7;
                    break;
                case 2:
                    tipoCod = Encoding.UTF8;
                    break;
                case 3:
                    tipoCod = Encoding.Unicode;
                    break;
                case 4:
                    tipoCod = Encoding.UTF32;
                    break;
                case 5:
                    tipoCod = Encoding.ASCII;
                    break;
            }
            bool agregarRegistro = true;
                while (agregarRegistro)
                {
                    Console.WriteLine("Ingresa tu nombre");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingresa tu primer Apellido");
                    string primerApellido = Console.ReadLine();
                    Console.WriteLine("Ingresa tu segundo Apellido");
                    string segundoApellido = Console.ReadLine();
                    Console.WriteLine("Ingresa tu edad");
                    string edad = Console.ReadLine();
                    Console.WriteLine("Ingresa tu estado de origen");
                    string estado = Console.ReadLine();

                    StreamWriter archivos = new StreamWriter($@"{ruta}\{nombreArchivo}", nuevo);
                    archivos.WriteLine($"{nombre},{primerApellido},{segundoApellido},{primerApellido},{edad},{estado}");
                    archivos.Close();
                    Console.WriteLine("¿Desea agregar otro registro? (S/N)");
                    string respuesta = Console.ReadLine();
                    if (respuesta.ToLower() == "n")
                    {
                        agregarRegistro = false;
                    }
                }
        }
        public static void presentacion()
        {
            Console.WriteLine("Ingresa el nombre del archivo");
            string ruta = Console.ReadLine();
            MostrarTxt(ruta);
            Console.WriteLine("Ingrese la ruta con el nombre del archivo .csv");
            string ruta1 = Console.ReadLine();
            Archivotxt.MostrarCSV(ruta1);
        }

    }
}
