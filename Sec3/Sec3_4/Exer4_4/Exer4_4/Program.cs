using System;
using System.Globalization;

namespace Exer4_4{
    class program{
        static void Main(string[] args) {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++){
                string[] valores = Console.ReadLine().Split(' ');
                int num1 = int.Parse(valores[0]);
                int num2 = int.Parse(valores[1]);
                if (num2 == 0) {
                    Console.WriteLine("Divisão impossivel");
                } else {
                    double div = (double)num1 / num2;
                    Console.WriteLine(div.ToString("F1", CultureInfo.InvariantCulture));  
                }
            }
        }
    }
}