using System;
using System.Globalization;

namespace SequentialStructureExercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(" ");
            double pi = 3.14159;

            double a = double.Parse(numbers[0], CultureInfo.InvariantCulture);
            double b = double.Parse(numbers[1], CultureInfo.InvariantCulture);
            double c = double.Parse(numbers[2], CultureInfo.InvariantCulture);

            double areaTriangleRectangle = (a * c) / 2;
            double circleRadius = pi * (c * c);
            double trapeze = ((a + b) * c) / 2;
            double square = b * b;
            double rectangle = a * b;


            Console.WriteLine("TRIANGULO: " + areaTriangleRectangle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circleRadius.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapeze.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + square.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + rectangle.ToString("F3", CultureInfo.InvariantCulture));


        }
    }
}