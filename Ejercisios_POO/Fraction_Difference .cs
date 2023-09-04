using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisios_POO
{
    internal class Fraction_Difference
    {
        public string fraccion1 { get; set; }
        public string fraccion2 { get; set; }

      
        public string Calcularfraccion()
        {
            string[] partes1 = fraccion1.Split('/');
            string[] partes2 = fraccion2.Split('/');

            int numerador1 = int.Parse(partes1[0]);
            int denominador1 = int.Parse(partes1[1]);
            int numerador2 = int.Parse(partes2[0]);
            int denominador2 = int.Parse(partes2[1]);

            int nuevoNumerador = numerador1 * denominador2 - numerador2 * denominador1;
            int nuevoDenominador = denominador1 * denominador2;

            int mcd = CalcularMCD(Math.Abs(nuevoNumerador), Math.Abs(nuevoDenominador));
            nuevoNumerador /= mcd;
            nuevoDenominador /= mcd;

            if (nuevoDenominador == 1)
            {
                return nuevoNumerador.ToString();
            }
            else
            {
                return $"{nuevoNumerador}/{nuevoDenominador}";
            }
        }

       public static int CalcularMCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        public void mostrar() {

            string resultado = Calcularfraccion();
            Console.WriteLine($"Resultado es: {resultado}");

        }

    }




    }

