using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fahrenheit_para_Celsisu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Grau Fahrenheit para Grau Celsius;

            double fahrenheit, celsius;

            Console.WriteLine("Formula (37 °F − 32) × 5/9 = 2,778 °C");
            Console.WriteLine("Converter Grau Fahrenheit para Grau Celsius ");

            Console.Write("Digite uma temperatura: ");
            fahrenheit = double.Parse(Console.ReadLine());

            celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine($"Portanto, {fahrenheit} graus Fahrenheit equivalem a {celsius.ToString("F2")} graus Celsius.");


            Console.ReadKey();
        }
    }
}
