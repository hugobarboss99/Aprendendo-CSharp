using System;
using System.Globalization;
namespace Exer7 {
    class Program {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores[1], CultureInfo.InvariantCulture);
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (x == 0 && y == 0) {
                Console.WriteLine("Origem");
            }
            else {
                Console.WriteLine("Q4");
            }
        }
    }
}