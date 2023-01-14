/*
Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
 */
using System;
namespace Exer4_2 {
    class Program {
        static void Main(string[] args) { 
            int n = int.Parse(Console.ReadLine());
            int count_in = 0;
            int count_out = 0;

            for (int i = 0; i < n; i++) {
                int aux = int.Parse(Console.ReadLine());
                if (aux >= 10 && aux <= 20)
                {
                    count_in++;
                }
                else {
                    count_out++;
                }
            }
            Console.WriteLine(count_in + " in");
            Console.WriteLine(count_out + " out");
        }
    }
}