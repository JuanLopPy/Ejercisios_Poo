using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ejercisios_POO
{
    internal class Midweek_Day
    {
        #region properties
        public int num { get; set; }

        #endregion
        #region methods
        public void CalcularDia() {
            string diaLaborable = "";

            switch (num)
            {
                case 1:
                    diaLaborable = "Lunes";
                    break;
                case 2:
                    diaLaborable = "Martes";
                    break;
                case 3:
                    diaLaborable = "Miércoles";
                    break;
                case 4:
                    diaLaborable = "Jueves";
                    break;
                case 5:
                    diaLaborable = "Viernes";
                    break;
                default:
                    diaLaborable = "No es un día laborable.";
                    break;
            }

            Console.WriteLine($"El día correspondiente al número {num} es {diaLaborable}");
        }

    }


        #endregion
    }
 