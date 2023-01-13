using System;

namespace Exer2{
    class program{
        static void Main(string[] args){
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) {
                Console.WriteLine("Numero par");
            }
            else{
                Console.WriteLine("Numero Impar");
            }
        }
    }
}