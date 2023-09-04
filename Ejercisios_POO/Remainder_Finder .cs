using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisios_POO
{

    internal class Remainder_Finder
    {
        #region properties
        public double num1 { get; set; }
        public double num2 { get; set; }
        #endregion
        #region methods
        public void calcularResiduo() {
         
           
            if (double.TryParse(Console.ReadLine(), out double numero2)) // to validate a correct input of second number 
            {
                double residuo = num1 % num2;
                Console.WriteLine($"El residuo de {num1} dividido por {numero2} es {residuo}");
            }
            else
            {
                Console.WriteLine("Entrada no válida para el segundo número. Debe ser un número válido.");
            }

        }



        #endregion





    }
}
