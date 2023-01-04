using System;

namespace Hora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a Hora inicial e dpois a hora final: ");

            string[] horas = Console.ReadLine().Split(' ');
            int horaI = int.Parse(horas[0]);
            int horas2 = int.Parse(horas[1]);

            int duracao;

            if (horaI < horas2)
            {
                duracao = horas2 - horaI;
            }
            else
            {
                duracao = 24 - horaI - horas2;
            }
            Console.WriteLine($"o jogo durou {duracao} horas");
        }
    }
}
