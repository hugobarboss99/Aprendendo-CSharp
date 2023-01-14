using System;
namespace Exer4_5{
    class program {
        public static void Main(string[] args){
            int n = int.Parse(Console.ReadLine());
            int aux = 1;
            for (int i = 1; i <= n; i++) {
                aux = aux * i;
            }
            Console.WriteLine(aux);
        }
    }
}