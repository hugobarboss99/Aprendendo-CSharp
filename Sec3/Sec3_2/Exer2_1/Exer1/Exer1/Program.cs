using System;

namespace Exer1{
    class program{
        static void Main(string[] args){
            int x = int.Parse(Console.ReadLine());

            if (x > 0)
            {
                Console.WriteLine("Numero não negativo.");
            }
            else
                Console.WriteLine("Numero negativo.");
        }
    }
}