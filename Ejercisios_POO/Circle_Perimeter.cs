using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisios_POO
{
    internal class Circle_Perimeter
    {
        #region properties
        public double radio { get; set; }
        #endregion


        #region methods
        public void CalcularPerimetro()
        {
            if (radio >= 0)
            {
                double perimetro = 2 * Math.PI * radio;
                Console.WriteLine($"El perímetro del círculo con radio {radio} es {perimetro}");
            }
            else
            {
                Console.WriteLine("El radio debe ser un número no negativo.");
            }
        }
        #endregion
    }
}
