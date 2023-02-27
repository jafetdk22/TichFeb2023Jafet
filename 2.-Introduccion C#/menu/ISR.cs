using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{

    class CalculadoraISR
    {
        String[] datosTabla = new String[30];
        decimal[,] datosTablaDecimal = new decimal[21, 5];

        public void CargarTabla(String nombreArchivoTxt, String ruta)
        {
            StreamReader leer = new StreamReader($@"{ruta}\{nombreArchivoTxt}");
            String linea;
            var i = 0;

            while ((linea = leer.ReadLine()) != null)
            {
                datosTabla = linea.Split(',');
                datosTablaDecimal[i, 0] = decimal.Parse(datosTabla[1]);
                datosTablaDecimal[i, 1] = decimal.Parse(datosTabla[2]);
                datosTablaDecimal[i, 2] = decimal.Parse(datosTabla[3]);
                datosTablaDecimal[i, 3] = decimal.Parse(datosTabla[4]);
                datosTablaDecimal[i, 4] = decimal.Parse(datosTabla[5]);
                i++;
            }
        }

        public void Calcular(decimal sueldo)
        {
            decimal isr = 0m;
            decimal sueldoISR = sueldo / 2;

            for (int i = 0; i < 21; i++)
            {
                if (sueldoISR >= datosTablaDecimal[i, 0] && sueldoISR <= datosTablaDecimal[i, 1])
                {
                    isr = (((sueldoISR - datosTablaDecimal[i, 0]) * (datosTablaDecimal[i, 3] / 100)) + datosTablaDecimal[i, 2]) - datosTablaDecimal[i, 4];
                }
            }

            Console.WriteLine("Calculo de ISR: " + "\n" + isr.ToString("C2"));
        }

        public static void Presentacion()
        {
            CalculadoraISR calculadora = new CalculadoraISR();
            decimal sueldo;
            String nombreArchivoISR, rutaISR;

            Console.WriteLine("Ingrese su sueldo");
            sueldo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la ruta completa");
            rutaISR = Console.ReadLine();
            Console.WriteLine("Ingrese el nombre del archivo TXT");
            nombreArchivoISR = Console.ReadLine();

            calculadora.CargarTabla(nombreArchivoISR, rutaISR);
            calculadora.Calcular(sueldo);
        }
    }

}
