using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisios_POO
{
    internal class Average_of_Four
    {
        #region properties
        int[] vec = new int[4];

        #endregion
        #region methods
        public void IngresaNum() { 
        
        for (int i=0; i<vec.Length; i++)
            {
                Console.WriteLine($"ingrese un número :");
                vec[i] = int.Parse(Console.ReadLine()); 
            }
        

        }
        public void prom() {
            double prom = 0;
            double suma = 0;
            for (int i=0 ; i<vec.Length; i++) {
                suma = suma + vec[i];
            }
            prom = suma / vec.Length;
            Console.WriteLine($"El promedio es: " + prom);

        }



        #endregion

    }
}
