using System;

namespace Exercicio1_2 {
    class Program {
        static void Main(string[] args) {
            int A, B, sum;
            Console.WriteLine("Digite o primeiro numero:");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero");
            B = int.Parse(Console.ReadLine());

            sum = A + B;
            Console.WriteLine("Resultado da soma dos dois numeros:");
            Console.WriteLine(sum);
        
        }  
    }
}