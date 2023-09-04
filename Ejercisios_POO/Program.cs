using Ejercisios;
using Ejercisios_POO;
using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyfirstOOPcode_saturday
{
    public class Program
    {
        static void Main(string[] args)
        {
            // primer ejercisio 
            /*Console.Write("Possitive power.\n");
            Possitive_Power cuadradoPositivo = new Possitive_Power();
            cuadradoPositivo.IngresarNumero();
            cuadradoPositivo.CalcularCuadrado(); 
            //segundo ejercisio 

            Console.Write("Dour or triple.\n");
            Dour_or_Triple dour_Or_Triple = new Dour_or_Triple();
            dour_Or_Triple.IngresarNumeros();
            dour_Or_Triple.CalcularNumero();*/
            // tercer ejercisio

            Console.Write("Root or Square.\n");
            Console.Write("Ingresa un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            Root_or_Square root= new Root_or_Square(numero);
            root.CalcularNumero();




        }








    }


}