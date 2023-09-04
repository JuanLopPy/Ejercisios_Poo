using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercisios_POO
{
    internal class Root_or_Square
    {
        #region properties
        public double num { get; set; }

        #endregion


        #region methods

        public Root_or_Square()
        {
           
        }
        public Root_or_Square(double num1)
        {
            num = num1;
        }


        public void CalcularNumero() {
            if (num >= 0)
            {
                double raizCuadrada = Math.Sqrt(num);
                Console.WriteLine($"La raíz cuadrada de {num} es {raizCuadrada}");

            }
            else
            {
                double cuadrado = Math.Pow(num, 2);
                Console.WriteLine($"El cuadrado de {num} es {cuadrado}");
            } 
                
            
        }

    }


        #endregion


}

