using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuGeneral
{
    public class Poliza
    {
        public static PolizaResultado Calcular(DateTime FechaInicio, int periodo, int cantidadP, int suma, DateTime nacimiento, int genero)
        {

            PolizaResultado poliza = new PolizaResultado();

            TimeSpan edad = DateTime.Now.Subtract(nacimiento);
            int edadEnAnios = (int)edad.TotalDays / 365;
            decimal Factor;

            decimal[,] tabla = new decimal[12, 4];

            tabla{
                { 0,20, 0, 0.05},
                { 21,30, 0, 0.1},
                { 31,40, 0, 0.4},
                { 41,50, 0, 0.5},
                { 51,60, 0, 0.65},
                { 61,62, 0, 0.85},
                { 0,20, 1, 0.05},
                { 21,30, 1, 0.1},
                { 31,40, 1, 0.4},
                { 41,50, 1, 0.55},
                { 51,60, 1, 0.7},
                { 61,62, 1, 0.9},
            }
            for (int i = 0; i < tabla.Length; i++)
            {
                if (edadEnAnios >= tabla[i, 0] && edadEnAnios <= tabla[i, 1] && genero == tabla[i, 2])
                {
                    Factor = tabla[i, 3];
                }

            }
            /* saber si el periodo */
            if (periodo == 1)/*años*/
            {
                poliza.Fecha_Termino = FechaInicio.AddYears(cantidadP);
                iTimeSpan dias = poliza.Fecha_Termino - FechaInicio;
                int diferenciaD = dias.Days;
                poliza.prima = (suma * Factor) * (diferenciaD / 365);
            }
            else if (periodo == 2)/*meses*/
            {
                poliza.Fecha_Termino = FechaInicio.AddMonths(cantidadP);
                /*calcular los dias del mes en base a la fecha de inicio y la fecha de termino*/
                iTimeSpan dias = poliza.Fecha_Termino - FechaInicio;
                int diferenciaD = dias.Days;
                poliza.prima = (suma * Factor) * (diferenciaD / 365);
            }
            else if (periodo == 3)/*días*/
            {
                poliza.Fecha_Termino = FechaInicio.AddDays(cantidadP);
                poliza.prima = (suma * Factor)(cantidadP / 365);
            }
            return poliza;

        }
        public static void Presentacion()
        {
            Console.WriteLine("Ingresa fecha de inicio : ejemplo - 2021-04-01 \r\n");
            DateTime a = conver.toDateTime(Console.ReadLine());
            Console.WriteLine("elige el tipo de periodo\n" +
                "1.-Anual.\n" +
                "2.-Mensual.\n" +
                "3.-Diario.\n"
                );
            decimal b = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa la cantidad de periodos ejemplo 2");
            DateTime c = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la suma asegurada");
            DateTime d = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa fecha de Nacimiento : ejemplo - 1999-04-01 \r\n");
            DateTime e = conver.toDateTime(Console.ReadLine());

            Console.WriteLine("seleccione un genero\n" +
                "0.-Mujer.\n" +
                "1.-Hombre.\n"
            );
            DateTime f = int.Parse(Console.ReadLine());

            Calcular(a, b, c, d, e, f);
        }
    }
}
