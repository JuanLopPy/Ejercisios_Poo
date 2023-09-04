using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisios_POO
{
    internal class Sum_Evens
    {

        #region properties 
        #endregion

        #region methods

        public void suma() {
            int suma = 0;

            for (int i = 2; i <= 50; i += 2)
            {
                suma += i;
            }

            Console.WriteLine($"La suma de los números pares entre 1 y 50 es: {suma}");

        }
        #endregion
    }
}
