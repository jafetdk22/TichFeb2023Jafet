using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    public class Saludo
    {
        public static String Saludar( string nom)// SE CREA EL METDO SALUDAR DE FORMA PUBLICA Y ESTATICA RECIBIENDO EL PARAMETRO NOM QUE ES DE TIPO STRING
        {
            //concatena el mensaje con el parametro de entrada.
            string saludo = "Hola. ¿Como estas "+nom+"?";  
            //retorna el saludo completo.
            return saludo;
        }

    }
}




            /* CALCULANDO EL FACTOR */
           /* if (edadEnAnios >= 0 && edadEnAnios <= 20)
            {
                if (genero == 'M')
                {
                    Factor = tabla[7,3];
                }else if (genero == 'H')
                {
                    Factor = tabla[7,3];
                }
            } else if (edadEnAnios >= 21 || edadEnAnios <= 30)
            {
                if (genero == 'H')
                {
                    Factor = [1,3];
                }else if( genero == 'M') {
                    Factor = 0.1m;
                }
            } else if (edadEnAnios >= 31 || edadEnAnios <= 40)
            {
                if (genero == 'H' || genero == 'M')
                {
                    Factor = 0.4m;
                }
            } else if (edadEnAnios >= 41 || edadEnAnios <= 50)
            {
                if (genero == 'H')
                {
                    Factor = 0.55m;
                }
                else
                {
                    Factor = 0.5m;
                }
            }
            else if (edadEnAnios >= 51 || edadEnAnios <= 60)
            {
                if (genero == 'H')
                {
                    Factor = 0.7m;
                }
                else
                {
                    Factor = 0.65m;
                }
            } else if (edadEnAnios >= 61)
            {
                if (genero == 'H')
                {
                    Factor = 0.9m;
                }
                else
                {
                    Factor = 0.85m;
                }
            }*/