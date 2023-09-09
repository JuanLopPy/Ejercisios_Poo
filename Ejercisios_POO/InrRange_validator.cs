using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercisios_POO
{
    internal class InrRange_validator
    {
        public void rango(double numero) {
            if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine($"El número {numero} está en el rango de 10 a 20.");
            }
            else
            {
                Console.WriteLine($"El número {numero} NO está en el rango de 10 a 20.");
            }

        }
    }
}
