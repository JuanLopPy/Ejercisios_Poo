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
           // first exercise 
            Console.Write("Possitive power.\n");
            Possitive_Power cuadradoPositivo = new Possitive_Power();
            cuadradoPositivo.IngresarNumero();
            cuadradoPositivo.CalcularCuadrado(); 
            //second exercise

            Console.Write("Dour or triple.\n");
            Dour_or_Triple dour_Or_Triple = new Dour_or_Triple();
            dour_Or_Triple.IngresarNumeros();
            dour_Or_Triple.CalcularNumero();
            // thyrd exercise 

            Console.Write("Root or Square.\n");
            Console.Write("Ingresa un número: ");
            double numero = Convert.ToDouble(Console.ReadLine());
            Root_or_Square root= new Root_or_Square(numero);
            root.CalcularNumero();

            // fourth exercise
            Console.Write("Circle Perimeter.\n");
            Console.Write("Ingresa el radio del circulo: ");
            double radio = Convert.ToDouble(Console.ReadLine());
            Circle_Perimeter circle = new Circle_Perimeter();
            circle.radio=radio;
            circle.CalcularPerimetro(); 

            //fifth exercise
            Console.Write("Midweek day.\n");
            Console.Write("Ingresa un número entre 1 y 7 : ");
            int num = Convert.ToInt32(Console.ReadLine());
           Midweek_Day midweek_Day = new Midweek_Day();
            midweek_Day.num=num;  
           midweek_Day.CalcularDia();
            // sixth exercise 
            Console.Write("Tax Calculator.\n");
            Console.Write("Ingresa tu salario: ");
            decimal salario = Convert.ToDecimal(Console.ReadLine());
            Tax_Calculator tax_Calculator = new Tax_Calculator();
            tax_Calculator.salarioAnual = salario;
            tax_Calculator.calcularSalario();
            


        }








    }


}