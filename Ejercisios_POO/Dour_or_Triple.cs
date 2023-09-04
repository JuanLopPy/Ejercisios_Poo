using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercisios_POO
{
    internal class Dour_or_Triple
    {
        #region properties 
        public double num1 { get; set; }
        public double num2 { get; set; }



        #endregion

        #region methods
        public void IngresarNumeros()
        {
            Console.Write("Ingresa un número: ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingresa otro número: ");
            num2 = Convert.ToDouble(Console.ReadLine());
        }

        public void Calcular_numero()
        {
            if (num1>=num2)
            {

                Console.WriteLine("El resultado es: " + num1 * 2);
            
            }
            else { Console.WriteLine("El resultado es: " + num2 * 3); }

        }




        #endregion

    }
}
