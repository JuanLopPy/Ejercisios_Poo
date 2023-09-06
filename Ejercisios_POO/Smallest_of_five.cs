using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisios_POO
{
    internal class Smallest_of_five
    {

        #region properties
        int[] vec = new int[5];

        #endregion
        #region methods
        public void IngresaNum()
        {

            for (int i = 0; i < vec.Length; i++)
            {
                Console.WriteLine($"ingrese un número :");
                vec[i] = int.Parse(Console.ReadLine());
            }


        }
        public void minimo()
        {
            double minimo= vec[0];
            for (int i = 0; i < vec.Length; i++)
            {
                if (vec[i] < minimo)
                {
                    minimo = vec[i];

                }

            }
            Console.WriteLine("El valor mínimo es: " + minimo);

        }

        #endregion
    }
}
