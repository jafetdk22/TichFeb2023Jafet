using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesAritméticas
{
    internal class Calculadora
    {
        public static decimal sumar(decimal num1, decimal num2)
        {
            return num1 + num2;

        }
        public static decimal restar(decimal num1, decimal num2)
        {
            return num1 - num2;

        }

        public static decimal multiplicar(decimal num1, decimal num2)
        {
            return num1 * num2;

        }
        public static decimal dividir(decimal num1, decimal num2)
        {
            return num1 / num2;
        }
        public static decimal modulo(decimal num1, decimal num2)
        {
            return num1 % num2;
        }
        public static decimal Operacion(OperacionAritmetica OperacionAritmetica)
        {
            decimal Resultado = 0;
            if (OperacionAritmetica.tipoOper == tipoOperacion.sumar)
            {
                Resultado = Calculadora.sumar(OperacionAritmetica.operando1, OperacionAritmetica.operando2);


            }
            else if (OperacionAritmetica.tipoOper == tipoOperacion.restar)
            {
                Resultado = Calculadora.restar(OperacionAritmetica.operando1, OperacionAritmetica.operando2);
            }
            else if (OperacionAritmetica.tipoOper == tipoOperacion.multiplicar)
            {
                Resultado = Calculadora.multiplicar(OperacionAritmetica.operando1, OperacionAritmetica.operando2);
            }
            else if (OperacionAritmetica.tipoOper == tipoOperacion.dividir)
            {
                Resultado = Calculadora.dividir(OperacionAritmetica.operando1, OperacionAritmetica.operando2);

            }
            else if (OperacionAritmetica.tipoOper == tipoOperacion.modulo)
            {
                Resultado = Calculadora.modulo(OperacionAritmetica.operando1, OperacionAritmetica.operando2);
            }



            return Resultado;
        }
        public static Resultado Simultaneas(decimal num1, decimal num2)
        {
            Resultado Resultado = new Resultado();
            Resultado.suma = Calculadora.sumar(num1, num2);
            Resultado.resta = Calculadora.restar(num1, num2);
            Resultado.multiplicacion = Calculadora.multiplicar(num1, num2);
            Resultado.dividir = Calculadora.dividir(num1, num2);
            Resultado.modulo = Calculadora.modulo(num1, num2);

            return Resultado;
        }
        public static void Presentacion()
        {
            Console.WriteLine("Ingresa un múmero");
            decimal a = int.Parse(Console.ReadLine());
            Console.WriteLine("ahora ingresa otro número");
            decimal b = int.Parse(Console.ReadLine());
            Console.WriteLine("Elige una Opcion \n" +
                "1.-Sumar\n" +
                "2.-Restar\n" +
                "3.-Multiplicar\n" +
                "4.-Dividir\n" +
                "5.-Módulo\n" +
                "6.-Todas\n"
                );
            int opers = int.Parse(Console.ReadLine());
            OperacionAritmetica operacionAritmetica = new OperacionAritmetica();
            operacionAritmetica.operando1 = a;
            operacionAritmetica.operando2 = b;
            operacionAritmetica.tipoOper = (tipoOperacion)opers;
            decimal resultado = Operacion(operacionAritmetica);

            if (opers == 1)
            {
                Console.WriteLine($"la suma es = {resultado}");
            }
            else if (opers == 2)
            {
                Console.WriteLine($"la resta es = {resultado}");
            }
            else if (opers == 3)
            {
                Console.WriteLine($"la multiplicación es = {resultado}");
            }
            else if (opers == 4)
            {
                Console.WriteLine($"la división es = {resultado}");
            }
            else if (opers == 5)
            {
                Console.WriteLine($"la módulo es = {resultado}");
            }
            else if (opers == 6)
            {
                Resultado result = Simultaneas(a,b);
                Console.WriteLine($"la suma es = {result.suma}");
                Console.WriteLine($"la resta es = {result.resta}");
                Console.WriteLine($"la multiplicación es = {result.multiplicacion}");
                Console.WriteLine($"la división es = {result.dividir}");
                Console.WriteLine($"la módulo es = {result.modulo}");
            }
        }
    }
}
