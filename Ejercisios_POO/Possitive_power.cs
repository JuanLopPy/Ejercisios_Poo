using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercisios
{
    internal class Possitive_Power
    {
        #region properties
        public double numero { get; set; }
        #endregion


        #region methods
        public void IngresarNumero()
        {
            Console.Write("Ingresa un número: ");
            numero = Convert.ToDouble(Console.ReadLine());
        }

        public void CalcularCuadrado()
        {
            if (numero > 0)
            {
                double resultado = Math.Pow(numero, 2);
                Console.WriteLine($"El cuadrado del número {numero} es {resultado}");
            }
            else
            {
                Console.WriteLine("El número ingresado no es positivo.");
            }
        }
    }


    #endregion

}

