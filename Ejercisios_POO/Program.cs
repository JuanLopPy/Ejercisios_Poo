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


            while (true)
            {
                Console.WriteLine("Elija una opción:");
                Console.WriteLine("1. Positivo al cuadrado.");
                Console.WriteLine("2. Doble o triple.");
                Console.WriteLine("3. Raíz cuadrada o cuadrado.");
                Console.WriteLine("4. Perímetro del círculo.");
                Console.WriteLine("5. Día de la semana.");
                Console.WriteLine("6. Calculadora de impuestos.");
                Console.WriteLine("7. Calculadora de residuos.");
                Console.WriteLine("8. Suma de números pares.");
                Console.WriteLine("9. Diferencia de fracciones.");
                Console.WriteLine("10. Longitud de una cadena.");
                Console.WriteLine("11. Promedio de cuatro números.");
                Console.WriteLine("12. El número más pequeño de cinco.");
                Console.WriteLine("13. Contador de vocales.");
                Console.WriteLine("14. Buscador de factorial.");
                Console.WriteLine("15. Validador de rango.");
                Console.WriteLine("0. Salir del programa.");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Possitive power.\n");
                        Possitive_Power cuadradoPositivo = new Possitive_Power();
                        cuadradoPositivo.IngresarNumero();
                        cuadradoPositivo.CalcularCuadrado();
                        break;
                    case 2:
                        Console.Write("Dour or triple.\n");
                        Dour_or_Triple dour_Or_Triple = new Dour_or_Triple();
                        dour_Or_Triple.IngresarNumeros();
                        dour_Or_Triple.CalcularNumero();
                        break;
                    case 3:
                        Console.Write("Root or Square.\n");
                        Console.Write("Ingresa un número: ");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Root_or_Square root = new Root_or_Square(num);
                        root.CalcularNumero();
                        break;
                    case 4:
                        Console.Write("Circle Perimeter.\n");
                        Console.Write("Ingresa el radio del circulo: ");
                        double radio = Convert.ToDouble(Console.ReadLine());
                        Circle_Perimeter circle = new Circle_Perimeter();
                        circle.radio = radio;
                        circle.CalcularPerimetro();
                        break;
                    case 5:
                        Console.Write("Midweek day.\n");
                        Console.Write("Ingresa un número entre 1 y 7 : ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Midweek_Day midweek_Day = new Midweek_Day();
                        midweek_Day.num = n;
                        midweek_Day.CalcularDia();
                        break;
                    case 6:
                        Console.Write("Tax Calculator.\n");
                        Console.Write("Ingresa tu salario: ");
                        decimal salario = Convert.ToDecimal(Console.ReadLine());
                        Tax_Calculator tax_Calculator = new Tax_Calculator();
                        tax_Calculator.salarioAnual = salario;
                        tax_Calculator.calcularSalario();
                        break;
                    case 7:
                        Console.Write("Tax Calculator.\n");
                        Console.Write("Ingresa un número: ");
                        double numero1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Ingresa otro número: ");
                        double num2 = Convert.ToDouble(Console.ReadLine());
                        Remainder_Finder remainder_Finder = new Remainder_Finder();
                        remainder_Finder.num1 = numero1;
                        remainder_Finder.num2 = num2;
                        remainder_Finder.calcularResiduo();
                        break;
                    case 8:
                        Sum_Evens sum_Evens = new Sum_Evens();
                        sum_Evens.suma();
                        break;
                    case 9:
                        Console.Write("Fracction diference.\n");
                        Console.Write("Ingresa la primera fracción (numerador/denominador): ");
                        string fraccion1 = Console.ReadLine();
                        Console.Write("Ingresa la segunda fracción (numerador/denominador): ");
                        string fraccion2 = Console.ReadLine();
                        Fraction_Difference fraction_Difference = new Fraction_Difference();
                        fraction_Difference.fraccion1 = fraccion1;
                        fraction_Difference.fraccion2 = fraccion2;
                        fraction_Difference.mostrar();
                        break;
                    case 10:
                        Console.Write("String Length. \n ");
                        Console.Write("Ingrese una palabra: ");
                        string palabra = Console.ReadLine();
                        String_Length string_Length = new String_Length();
                        string_Length.palabra = palabra;
                        Console.Write("" + string_Length.NumPalabra());
                        break;
                    case 11:
                        Console.Write("Average of four. \n ");
                        Average_of_Four average = new Average_of_Four();
                        average.IngresaNum();
                        average.prom();
                        break;
                    case 12:
                        Console.Write(" Smallest of Five. \n ");
                        Smallest_of_five smallest = new Smallest_of_five();
                        smallest.IngresaNum();
                        smallest.minimo();
                        break;
                    case 13:
                        Console.Write(" Vowel Counter  \n ");
                        Vowel_counter vowe = new Vowel_counter();
                        Console.WriteLine("Ingrese la palabra");
                        string Palabra = Console.ReadLine();
                        vowe.contarvocales(Palabra);
                        break;
                    case 14:
                        Console.Write(" Factorial finder  \n ");
                        Factorial_Finder factorial_finder = new Factorial_Finder();
                        Console.Write("Ingresa un número positivo: ");
                        double number = Convert.ToDouble(Console.ReadLine());
                        factorial_finder.calcular(number);
                        break;
                    case 15:
                        Console.Write(" InRange Validator  \n ");
                        InrRange_validator inr_validator = new InrRange_validator();
                        Console.Write("Ingresa un número: ");
                        double number1 = Convert.ToDouble(Console.ReadLine());
                        inr_validator.rango(number1);
                        break;
                    case 0:
                        // Salir del programa
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, elija una opción válida.");
                        break;
                }


            }







        }
    }


}