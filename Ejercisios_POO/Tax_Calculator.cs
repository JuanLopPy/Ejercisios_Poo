using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisios_POO
{
    internal class Tax_Calculator
    {
        #region properties
        public decimal salarioAnual;
       
     

        #endregion


        #region methods 
        public void calcularSalario() {

            decimal excedente = salarioAnual - 12000;
            if (excedente > 0)
            {
                decimal impuesto = excedente * 0.15m;
                Console.WriteLine($"El impuesto a pagar es: {impuesto:C}");
            }
            else
            {
                Console.WriteLine("No tienes que pagar impuestos.");
            }

        }

        #endregion

    }
}
