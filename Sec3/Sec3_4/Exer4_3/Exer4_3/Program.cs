using System;
using System.Globalization;
namespace Exer4_3 {
    class program {
        static void Main(string[] args) { 
        int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++){
                string[] valores = Console.ReadLine().Split(' ');
                double num1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                double num2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                double num3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

                double media = (((num1 * 2.0) + (num2 * 3.0) + (num3 * 5.0)) / 10);
                Console.WriteLine(media.ToString("F1"), CultureInfo.InvariantCulture);
                }
            }
    }
}