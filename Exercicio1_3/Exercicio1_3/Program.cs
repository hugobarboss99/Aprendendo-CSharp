using System;
using System.Globalization;

namespace Exercicio1_3 {
    class Program {
        static void Main(string[] args) {
            double Pi = 3.14159;
            double R, Area;

            Console.WriteLine("Digite o valor do raio de um circulo");
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Area = R * R * Pi;
            Console.WriteLine("A area do circulo correspondente ao raio digitado e:");
            Console.WriteLine(Area.ToString("F4", CultureInfo.InvariantCulture));

        }   
    }
}