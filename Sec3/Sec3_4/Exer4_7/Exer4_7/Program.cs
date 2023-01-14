using System;
namespace Exer4_7 {
    class program {
        static public void Main(string[] args) { 
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) {
                int num1 = i;
                int num2 = i * i;
                int num3 = i * i * i;
                Console.WriteLine($"{num1} {num2} {num3}");
            }
        }
    }
}