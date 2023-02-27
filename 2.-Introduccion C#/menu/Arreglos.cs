using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    public class Arreglos
    {
        public static void Cadenas(string nom)
        {
            string[] arNom = nom.Split(' ');
            Console.WriteLine("Hola\n" + arNom[0] + "\n" + arNom[1] + "\n" + arNom[2]);
            char[] arregloChar = arNom[1].ToCharArray();
            foreach (char CharArr in arregloChar)
            {
                Console.WriteLine(CharArr);
            }


        }
        public static void Enteros(int n1, int n2, int n3, int n4, int n5)
        {
            int[] numeros = { n1, n2, n3, n4, n5 };
            int mayor = numeros[0], menor = numeros[0];

            for (int i = 1; i < numeros.Length; ++i)
            {
                if (numeros[i] > mayor) mayor = numeros[i];
                if (numeros[i] < menor) menor = numeros[i];
            }
            Console.WriteLine("El número mayor es: " + mayor + "\n");
            Console.WriteLine("El número menor es: " + menor + "\n\n");

        }
        public static void ConvierteATipoOracion(string palabra)
        {
            string[] frases = palabra.Split(' ');

            foreach (string frase in frases)
            {
                Console.Write(frase.Substring(0, 1).ToUpper() + frase.Substring(1) + "  \n");
            }
        }
    }
}
