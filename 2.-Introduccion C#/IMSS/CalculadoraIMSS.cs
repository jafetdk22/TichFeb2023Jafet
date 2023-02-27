using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMSS
{
    internal class CalculadoraIMSS
    {

        public static Aportaciones Calcular(decimal sbc, decimal uma, bool esPatron)
        {

            Aportaciones aportaciones = new Aportaciones();
            if (esPatron)
            {
                aportaciones.EnfermedadMaternidad = ((sbc - (3m * uma)) * 1.1m) / 100;
                aportaciones.InvalidezVida = sbc * 1.75m / 100;
                aportaciones.Retiro = (sbc * 2) / 100;
                aportaciones.Cesantia = (sbc * 3.150m) / 100;
                aportaciones.Infonavit = (sbc * 5m) / 100;
            }

            else
            {
                aportaciones.EnfermedadMaternidad = ((sbc - (3  * uma)) * 0.4m) / 100;
                aportaciones.InvalidezVida = sbc * 0.625m / 100;
                aportaciones.Retiro = sbc;
                aportaciones.Cesantia = (sbc * 1.125m) / 100;
                aportaciones.Infonavit = sbc;
            }

            return aportaciones;
        }
        public static void Presentacion()
        {
            Console.WriteLine("Ingrese el Salario Base de Cotización: ");
            decimal sbc = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la Unidad de Medida de Actualización: ");
            decimal uma = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Es el cálculo para el Patrón o para el Trabajador? (P/T): ");
            bool esPatron = (Console.ReadLine().ToUpper() == "P");

            Aportaciones aportaciones = Calcular(sbc, uma, esPatron);

            Console.WriteLine("=== Resultados ===");
            Console.WriteLine($"Enfermedad y maternidad: {aportaciones.EnfermedadMaternidad}");
            Console.WriteLine($"Invalidez y vida: {aportaciones.InvalidezVida}");
            Console.WriteLine($"Retiro: {aportaciones.Retiro}");
            Console.WriteLine($"Cesantía y vejez: {aportaciones.Cesantia}");
            Console.WriteLine($"Infonavit: {aportaciones.Infonavit}");

            decimal total = aportaciones.EnfermedadMaternidad + aportaciones.InvalidezVida +
                            aportaciones.Retiro + aportaciones.Cesantia + aportaciones.Infonavit;
            Console.WriteLine($"Total: {total}");

        }
    }
}
