using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercisios_POO
{
    internal class String_Length
    {

        #region properties
        public string palabra;
        
        #endregion
        #region methods
        public string  NumPalabra() {
            string mostrar;
         int numpa=palabra.Length;
            mostrar = "La longitud es: " + numpa;
            return mostrar;
        }

        #endregion

    }
}
