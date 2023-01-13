using System;

namespace Exercicio1_4 {
    class Program {
        static void Main(string[] args){

            int A, B, C, D, sumdif;
            
            Console.WriteLine("Digite o valor de A");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D");
            D = int.Parse(Console.ReadLine());

            sumdif = ((A * B) - (C * D));
            Console.WriteLine("O valor da diferença dos produtos e: " +sumdif);


        }
    }
}