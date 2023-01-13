using System;
using System.Globalization;

namespace Exercicio1_6 {
    class Program {
        static void Main(string[] args) {
            int product1, numproduct1, product2, numproduct2;
            double price1, price2, totalprice;

            string[] valores = Console.ReadLine().Split(' ');
            product1 = int.Parse(valores[0]);
            numproduct1 = int.Parse(valores[1]);
            price1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            product2 = int.Parse(valores[0]);
            numproduct2 = int.Parse(valores[1]);
            price2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            totalprice = price1 * numproduct1 + price2 * numproduct2;
            Console.WriteLine("Valor a pagar: R$" +totalprice.ToString("F2"), CultureInfo.InvariantCulture);
        }
    }
}