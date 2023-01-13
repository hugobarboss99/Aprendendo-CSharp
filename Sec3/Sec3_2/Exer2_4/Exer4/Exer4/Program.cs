using System;
namespace Exer4{
    class program {
        public static void Main(string[] args) {
            string[] valores = Console.ReadLine().Split(' ');
            int HoraInicio = int.Parse(valores[0]);
            int HoraFinal = int.Parse(valores[1]);
            int duracao;

            if (HoraInicio < HoraFinal){
                duracao = HoraFinal - HoraInicio;
            }
            else {
                duracao = 24 - HoraInicio + HoraFinal;
            }

            Console.WriteLine("O jogo durou " + duracao + " hora(s)");
        }
    }
}