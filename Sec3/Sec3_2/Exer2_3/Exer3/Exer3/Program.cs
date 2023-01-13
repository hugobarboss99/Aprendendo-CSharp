using System;
namespace Exer3 {
    class program {
        static void Main(string[] args){
            string[] valores = Console.ReadLine().Split(' ');
            int num1 = int.Parse(valores[0]);
            int num2 = int.Parse(valores[1]);
            if (num1 % num2 == 0 || num2 % num1 == 0) {
                Console.WriteLine("Esses numeros são multiplos");
            }
            else {
                Console.WriteLine("Esses numeros não são multiplos");
            }
        }

    }
}