using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisios_POO
{
    internal class Vowel_counter
    {

        #region properties 
        #endregion

        #region methods
        public void contarvocales(string palabra) {
            int cont = 0;
            char[] vocales = {'a','e','i','o','u'};
            for (int j = 0; j < vocales.Length; j++)
            {
                for (int i = 0; i < palabra.Length; i++)
                {
                    if (vocales[j]==palabra[i])
                    {
                      cont++;
                    }
                }
            }


            Console.WriteLine("el número de vocales que tiene la palabra es: " + cont);
        }

        #endregion
    }
}
