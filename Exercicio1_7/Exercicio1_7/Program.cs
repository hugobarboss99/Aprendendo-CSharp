using System;
using System.Globalization;

namespace Exercicio1_7 {
    class Program {
        static void Main(string[] args) {
            double Pi = 3.14159;
            double A, B, C;
            double TriangleArea, CircleArea, TrapezoidArea, SquareArea, RectangleArea;

            Console.WriteLine("Digite o valor de A, B e C (Na mesma linha): ");
            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            TriangleArea = (A * C) / 2;
            CircleArea = (C * C) * Pi;
            TrapezoidArea = ((A + B) / 2) * C;
            SquareArea = (B * B);
            RectangleArea = (A * B);

            Console.WriteLine("Area do triangulo: " +TriangleArea.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("Area do circulo: " + CircleArea.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("Area do trapezio: " + TrapezoidArea.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("Area do quadrado: " + SquareArea.ToString("F3"), CultureInfo.InvariantCulture);
            Console.WriteLine("Area do retangulo: " + RectangleArea.ToString("F3"), CultureInfo.InvariantCulture);
        }
    }
}