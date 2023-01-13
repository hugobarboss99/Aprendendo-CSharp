using System;
using System.Globalization;

namespace Exercicio1_5 {
    class Program {
        static void Main(string[] args) {

            int idfun, hora;
            double salariohora, salariototal;

            Console.WriteLine("Digite o ID do funcionario:");
            idfun = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite as horas trabalhadas:");
            hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o salario recebido por hora:");
            salariohora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salariototal = salariohora * hora;
            Console.WriteLine("ID do funcionaro: " +idfun);
            Console.WriteLine("Salario: " +salariototal.ToString("F2"), CultureInfo.InvariantCulture);

        }
    }
}