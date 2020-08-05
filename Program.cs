using System;

namespace HOLAMUNDO
{
    class Program
    {
        static void Main(string[] args)
        {   
            const double valorPI = 3.1416;
            Console.WriteLine("Programa que te calcula el área de un cículo dándole el radio");

            Console.WriteLine("Introduce tu radio por favor");
            double num1= double.Parse(Console.ReadLine());
            var resultado = valorPI*(num1*num1);
            Console.WriteLine("resultado: " + resultado);

        }
    }
}
